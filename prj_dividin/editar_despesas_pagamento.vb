Public Class editar_despesas_pagamento
    Private Sub editar_despesas_pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_categorias_editar()

        sql = $"SELECT 
          d.descricao,
          d.valor_total,
          d.categoria,
          d.data_despesa,
          c_credor.usuario AS nome_credor,
          c_devedor.usuario AS nome_devedor,
          dp_credor.usuario_id AS id_credor,
          dp_devedor.usuario_id AS id_devedor
       FROM despesas d
       INNER JOIN despesas_pagamentos dp_credor 
            ON dp_credor.despesa_id = d.id_despesa 
            AND dp_credor.tipo_pagamento = 'credor'
       INNER JOIN cadastro_contas c_credor 
            ON c_credor.id_conta = dp_credor.usuario_id
       INNER JOIN despesas_pagamentos dp_devedor 
            ON dp_devedor.despesa_id = d.id_despesa 
            AND dp_devedor.tipo_pagamento = 'devedor'
       INNER JOIN cadastro_contas c_devedor 
            ON c_devedor.id_conta = dp_devedor.usuario_id
       WHERE d.id_despesa = {id_despesa}"

        rs = db.Execute(sql)
        txt_nome_despesa.Text = rs.Fields("descricao").Value.ToString()
        txt_valor_despesa.Text = rs.Fields("valor_total").Value.ToString()
        txt_credor.Text = rs.Fields("nome_credor").Value.ToString()
        txt_devedor.Text = rs.Fields("nome_devedor").Value.ToString()
        cmb_categoria.Text = rs.Fields("categoria").Value.ToString()
        cmb_data_despesa.Text = rs.Fields("data_despesa").Value.ToString()


    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        sql = $"select * from despesas where id_despesa='{id_despesa}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If txt_nome_despesa.Text = "" Or
           txt_valor_despesa.Text = "" Or
           txt_devedor.Text = "" Or
           txt_credor.Text = "" Or
           cmb_categoria.SelectedItem Is Nothing Or
           cmb_data_despesa.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_credor.Text <> nameU AndAlso txt_devedor.Text <> nameU Then
                MsgBox("O usuário precisa ser um participante da despesa!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_devedor.Clear()
                txt_credor.Clear()
                txt_devedor.Focus()
            Else
                sql = $"update despesas set descricao='{txt_nome_despesa.Text}',
                                             valor_total='{txt_valor_despesa.Text.Replace(",", ".")}',
                                             categoria='{cmb_categoria.Text}',
                                             data_despesa='{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}' where id_despesa='{id_despesa}'"
                db.Execute(sql)

                credor = txt_credor.Text
                'busca do idcredor
                sql = $"select id_conta from cadastro_contas where usuario='{credor}'"
                rs = db.Execute(sql)
                buscar_id_conta = rs.Fields("id_conta").Value
                rs.Close()

                'atualizar credor
                sql = $"update despesas_pagamentos set usuario_id='{buscar_id_conta}',
                                                  valor_pago='0'
                                                  where despesa_id='{id_despesa}' AND tipo_pagamento='credor'"
                db.Execute(sql)


                devedor = txt_devedor.Text
                'busca do iddevedor
                sql = $"select id_conta from cadastro_contas where usuario='{devedor}'"
                rs = db.Execute(sql)
                buscar_id_conta = rs.Fields("id_conta").Value
                rs.Close()

                'atualizar devedor
                sql = $"update despesas_pagamentos set usuario_id='{buscar_id_conta}',
                                                  valor_pago='{txt_valor_despesa.Text.Replace(",", ".")}'
                                                  where despesa_id='{id_despesa}' AND tipo_pagamento='devedor'"
                db.Execute(sql)

                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        pesquisa_usuario.Show()
        dif_campo = 4
    End Sub

    Private Sub btn_buscar_usuario1_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario1.Click
        pesquisa_usuario.Show()
        dif_campo = 5
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class