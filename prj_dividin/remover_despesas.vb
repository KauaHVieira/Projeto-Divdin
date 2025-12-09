Public Class remover_despesas

    Private Sub remover_despesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados_remover_despesas()

    End Sub

    Private Sub dgv_dados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(6).Selected = True Then
                resp = MsgBox("Deseja remover a despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    aux = .CurrentRow.Cells(1).Value
                    sql = $"select id_despesa from despesas where descricao='{aux}'"
                    rs = db.Execute(sql)
                    id_despesa = rs.Fields("id_despesa").Value
                    rs.Close()

                    sql = $"delete from despesas_divisoes where despesa_id='{id_despesa}'"
                    db.Execute(sql)

                    sql = $"delete from despesas_pagamentos where despesa_id='{id_despesa}'"
                    db.Execute(sql)

                    sql = $"delete from despesas where id_despesa='{id_despesa}'"
                    db.Execute(sql)



                    MsgBox("Despesa removida com sucesso!", MsgBoxStyle.Information)

                    carregar_dados_remover_despesas()

                End If
            End If
        End With
    End Sub
End Class