Imports System.Configuration

Module Mod_Geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public resp, sql, nome_usuario, nome_selecionado, token, id_dif, aux, devedor, credor, id_despesa, buscar_id_conta, id_divisoes, nameU As String
    Public cont, dif_campo, id_gp As Integer
    Public tipoQ_despesa As String
    Public lista_devedores_grupo As New List(Of String)
    Public valor As Decimal
    Sub conecta_banco_mysql()
        Try
            'String de conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=dividin_main_database;UID=root;PWD=usbw;port=3307;option=3;")
            'User=sdasdasdasd;PWD=2112212112. Caso queira usar com senha e usuario
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_dados()
        With pesquisa_usuario.dgv_dados
            sql = "select * from cadastro_contas order by usuario asc"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub carregar_dados_grupos()
        With grupos.dgv_dados

            'sql = $"SELECT g.* 
            ' From grupos g
            ' INNER JOIN usuarios_grupos ug ON g.id_grupo = ug.grupo_id
            ' WHERE ug.usuario_id = '{token}'
            ' ORDER BY g.nome_grupo ASC"

            sql = $"SELECT g.*, c.usuario AS nome_criador
           FROM grupos g
           INNER JOIN usuarios_grupos ug ON g.id_grupo = ug.grupo_id
           LEFT JOIN cadastro_contas c ON g.criado_por = c.id_conta
           WHERE ug.usuario_id = '{token}'
           ORDER BY g.nome_grupo ASC"

            rs = db.Execute(sql)

            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields("nome_criador").Value, rs.Fields(4).Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
    Sub carregar_dados_grupos_usuario()
        With grupos_criados_usuario.dgv_dados
            'sql = $"select * from grupos where criado_por='{token}'"
            sql = $"SELECT g.*, c.usuario AS nome_criador
                FROM grupos g
                LEFT JOIN cadastro_contas c ON g.criado_por = c.id_conta
                WHERE g.criado_por = '{token}'
                ORDER BY g.nome_grupo ASC"

            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields("nome_criador").Value, rs.Fields(4).Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub carregar_dados_membros_grupo()
        With membros_grupo.dgv_dados
            sql = $"select c.usuario, c.email from cadastro_contas c inner join usuarios_grupos ug on c.id_conta = ug.usuario_id
            where ug.grupo_id ='{id_gp}' order by c.id_conta asc"

            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields("usuario").Value, rs.Fields("email").Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With

        With adicionar_membro.dgv_dados
            sql = $"select c.usuario, c.email from cadastro_contas c inner join usuarios_grupos ug on c.id_conta = ug.usuario_id
            where ug.grupo_id ='{id_gp}' order by c.id_conta asc"

            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields("usuario").Value, rs.Fields("email").Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
    Sub carregar_dados_despesas()
        With selecao_editar_despesa.dgv_dados
            sql = $"SELECT 
               d.id_despesa,
               d.descricao,
               d.categoria,
               d.valor_total,
               d.tipo,
               CASE 
                   WHEN d.tipo = 'Pagamento' THEN dp.valor_pago
                   WHEN d.tipo = 'Divisao' THEN dd.valor_individual
                   WHEN d.tipo = 'Pessoal' THEN d.valor_total
               END AS valor_pago
            FROM despesas d
            LEFT JOIN despesas_pagamentos dp 
                ON dp.despesa_id = d.id_despesa 
                AND dp.usuario_id = {token} 
                AND d.tipo = 'Pagamento'
            LEFT JOIN despesas_divisoes dd 
                ON dd.despesa_id = d.id_despesa 
                AND dd.usuario_id = {token} 
                AND d.tipo = 'Divisao'
            WHERE d.pago_por = {token} OR dp.usuario_id = {token} OR dd.usuario_id = {token}
            ORDER BY d.data_despesa ASC"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value, Nothing)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub
    Sub carregar_dados_quitar_despesas()
        With selecao_quitar_despesas.dgv_dados
            sql = $"SELECT 
                    d.id_despesa,
                    d.descricao,
                    d.categoria,
                    d.valor_total,
                    d.tipo,
                    CASE 
                        WHEN d.tipo = 'Pagamento' THEN dp.valor_pago
                        WHEN d.tipo = 'Divisao' THEN dd.valor_individual
                        WHEN d.tipo = 'Pessoal' THEN d.valor_total
                    END AS valor_pago
                FROM despesas d
                LEFT JOIN despesas_pagamentos dp 
                    ON dp.despesa_id = d.id_despesa 
                    AND dp.usuario_id = {token} 
                    AND dp.tipo_pagamento = 'devedor' 
                LEFT JOIN despesas_divisoes dd 
                    ON dd.despesa_id = d.id_despesa 
                    AND dd.usuario_id = {token} 
                    AND d.tipo = 'Divisao'
                WHERE dp.usuario_id = {token} OR dd.usuario_id = {token} or d.pago_por = {token}
                ORDER BY d.data_despesa ASC;"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value, Nothing)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub
    Sub carregar_quitar_despesas_grupo()
        With selecao_quitar_despesas_grupo.dgv_dados
            sql = $"SELECT 
                    d.id_despesa,
                    d.descricao,
                    d.categoria,
                    d.valor_total,
                    d.tipo,
                    CASE 
                        WHEN d.tipo = 'Pagamento' THEN dp.valor_pago
                        WHEN d.tipo = 'Divisao' THEN dd.valor_individual
                        WHEN d.tipo = 'Pessoal' THEN d.valor_total
                    END AS valor_pago
                FROM despesas d
                LEFT JOIN despesas_pagamentos dp 
                    ON dp.despesa_id = d.id_despesa 
                    AND dp.usuario_id = {token} 
                    AND dp.tipo_pagamento = 'devedor' 
                LEFT JOIN despesas_divisoes dd 
                    ON dd.despesa_id = d.id_despesa 
                    AND dd.usuario_id = {token} 
                    AND d.tipo = 'Divisao'
               WHERE (dp.usuario_id = {token} OR dd.usuario_id = {token} OR d.pago_por = {token})
               AND d.grupo_id = {id_gp}
                ORDER BY d.data_despesa ASC;"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value, Nothing)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub

    Sub carregar_dados_visualizar_despesas()
        With visualizar_despesas.dgv_dados
            sql = $"SELECT 
               d.id_despesa,
               d.descricao,
               d.categoria,
               d.valor_total,
               d.tipo,
               CASE 
                   WHEN d.tipo = 'Pagamento' THEN dp.valor_pago
                   WHEN d.tipo = 'Divisao' THEN dd.valor_individual
                   WHEN d.tipo = 'Pessoal' THEN d.valor_total
               END AS valor_pago
            FROM despesas d
            LEFT JOIN despesas_pagamentos dp 
                ON dp.despesa_id = d.id_despesa 
                AND dp.usuario_id = {token} 
                AND d.tipo = 'Pagamento'
            LEFT JOIN despesas_divisoes dd 
                ON dd.despesa_id = d.id_despesa 
                AND dd.usuario_id = {token} 
                AND d.tipo = 'Divisao'
            WHERE d.pago_por = {token} OR dp.usuario_id = {token} OR dd.usuario_id = {token}
            ORDER BY d.data_despesa ASC"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub

    Sub carregar_dados_remover_despesas()
        With remover_despesas.dgv_dados
            sql = $"SELECT 
               d.id_despesa,
               d.descricao,
               d.categoria,
               d.valor_total,
               d.tipo,
               CASE 
                   WHEN d.tipo = 'Pagamento' THEN dp.valor_pago
                   WHEN d.tipo = 'Divisao' THEN dd.valor_individual
                   WHEN d.tipo = 'Pessoal' THEN d.valor_total
               END AS valor_pago
            FROM despesas d
            LEFT JOIN despesas_pagamentos dp 
                ON dp.despesa_id = d.id_despesa 
                AND dp.usuario_id = {token} 
                AND d.tipo = 'Pagamento'
            LEFT JOIN despesas_divisoes dd 
                ON dd.despesa_id = d.id_despesa 
                AND dd.usuario_id = {token} 
                AND d.tipo = 'Divisao'
            WHERE d.pago_por = {token} OR dp.usuario_id = {token} OR dd.usuario_id = {token}
            ORDER BY d.data_despesa ASC"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value, Nothing)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub
    Sub carregar_despesas_grupos()
        With grupo_usuario.dgv_dados
            sql = $"SELECT 
                d.id_despesa,
                d.descricao,
                d.categoria,
                d.valor_total,
                d.tipo,
                CASE 
                WHEN d.tipo = 'Divisao' THEN 
                    (SELECT valor_individual 
                     FROM despesas_divisoes 
                     WHERE despesa_id = d.id_despesa 
                       AND usuario_id = {token}
                     LIMIT 1)
                    ELSE NULL
                END AS valor_pago
                FROM despesas d
                WHERE d.grupo_id = {id_gp}
                ORDER BY d.data_despesa ASC"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub
    Sub carregar_tipos_dados()
        With pesquisa_usuario.cmb_campo.Items
            .Add("EMAIL")
            .Add("USUARIO")
        End With
        pesquisa_usuario.cmb_campo.SelectedIndex = 1
    End Sub

    Sub carregar_tipos_dados_despesas()
        With visualizar_despesas.cmb_campo.Items
            .Add("DESCRICAO")
            .Add("TIPO")
            .Add("CATEGORIA")
        End With
        visualizar_despesas.cmb_campo.SelectedIndex = 1
    End Sub
    Sub carregar_tipos_dados_despesas_editarD()
        With selecao_editar_despesa.cmb_campo.Items
            .Add("DESCRICAO")
            .Add("CATEGORIA")
            .Add("TIPO")
        End With
        selecao_editar_despesa.cmb_campo.SelectedIndex = 1
    End Sub

    Sub carregar_tipos_dados_quitar_grupos()
        With selecao_quitar_despesas_grupo.cmb_campo.Items
            .Add("DESCRICAO")
            .Add("CATEGORIA")
            .Add("TIPO")
        End With
        selecao_quitar_despesas_grupo.cmb_campo.SelectedIndex = 1
    End Sub
    Sub carregar_tipos_dados_quitar_despesas()
        With selecao_quitar_despesas.cmb_campo.Items
            .Add("DESCRICAO")
            .Add("CATEGORIA")
            .Add("TIPO")
        End With
        selecao_quitar_despesas.cmb_campo.SelectedIndex = 1
    End Sub

    Sub carregar_tipos_dados_membros()
        With membros_grupo.cmb_campo.Items
            .Add("EMAIL")
            .Add("USUARIO")
        End With
        membros_grupo.cmb_campo.SelectedIndex = 1
    End Sub

    Sub carregar_tipos_dados_add_membros()
        With adicionar_membro.cmb_campo.Items
            .Add("EMAIL")
            .Add("USUARIO")
        End With
        adicionar_membro.cmb_campo.SelectedIndex = 1
    End Sub

    Sub carregar_categorias()
        With adicionar_despesas.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        adicionar_despesas.cmb_categoria.SelectedIndex = -1
    End Sub

    Sub carregar_categorias_editar()
        With editar_despesas_pagamento.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        editar_despesas_pagamento.cmb_categoria.SelectedIndex = -1
    End Sub
    Sub carregar_categorias_divisao()
        With adicionar_despesas_divisao.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        adicionar_despesas_divisao.cmb_categoria.SelectedIndex = -1
    End Sub
    Sub carregar_editar_Dgrupo()
        With editar_despesas_grupo.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        editar_despesas_grupo.cmb_categoria.SelectedIndex = -1
    End Sub
    Sub carregar_adicionar_Dgrupo()
        With adicionar_despesas_grupo.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        adicionar_despesas_grupo.cmb_categoria.SelectedIndex = -1
    End Sub

    Sub carregar_categoria_editar_despesas1()
        With editar_despesas_divisao.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        editar_despesas_divisao.cmb_categoria.SelectedIndex = -1
    End Sub
    Sub carregar_categorias_pessoal()
        With adicionar_despesas_pessoal.cmb_categoria.Items
            .Add("Aluguel")
            .Add("Alimentação")
            .Add("Viagem")
            .Add("Dívida")
        End With
        adicionar_despesas_pessoal.cmb_categoria.SelectedIndex = -1
    End Sub
    Sub carregar_categorias_divisao2()
        With adicionar_despesas_divisao.cmb_modo_divisao.Items
            .Add("Valor fixo")
            .Add("Divisão igual")
        End With
        adicionar_despesas_divisao.cmb_modo_divisao.SelectedIndex = -1
    End Sub

    Sub carregar_categorias_editar_despesas()
        With editar_despesas_divisao.cmb_modo_divisao.Items
            .Add("Valor fixo")
            .Add("Divisão igual")
        End With
        editar_despesas_divisao.cmb_modo_divisao.SelectedIndex = -1
    End Sub



End Module


