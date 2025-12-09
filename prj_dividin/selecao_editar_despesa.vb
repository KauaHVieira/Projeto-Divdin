Public Class selecao_editar_despesa
    Private Sub selecao_editar_despesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados_despesas()
        carregar_tipos_dados_despesas_editarD()

    End Sub

    Private Sub dgv_dados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            Try
                If .CurrentRow.Cells(6).Selected = True Then
                    resp = MsgBox("Deseja editar a despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        aux = .CurrentRow.Cells(1).Value
                        sql = $"select id_despesa from despesas where descricao='{aux}'"
                        rs = db.Execute(sql)
                        id_despesa = rs.Fields("id_despesa").Value
                        Dim tipo_despesa As String
                        tipo_despesa = .CurrentRow.Cells(4).Value.ToString()
                        If tipo_despesa = "Pagamento" Then
                            editar_despesas_pagamento.Show()
                        ElseIf tipo_despesa = "Divisao" Then
                            editar_despesas_divisao.Show()
                        ElseIf tipo_despesa = "Pessoal" Then
                            editar_despesas_pessoal.show()
                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End With
    End Sub

    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click
        With dgv_dados
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
            WHERE (d.pago_por = {token} OR dp.usuario_id = {token} OR dd.usuario_id = {token}) And {cmb_campo.Text} Like '{txt_buscar.Text}%'
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
End Class