Public Class grupos_criados_usuario
    Private Sub grupos_criados_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados_grupos_usuario()
        txt_nomeU.Text = nameU
    End Sub

    Private Sub btn_meus_grupos_Click(sender As Object, e As EventArgs) Handles btn_meus_grupos.Click
        grupos.Show()
        Me.Close()
    End Sub

    Private Sub btn_criar_grupo_Click(sender As Object, e As EventArgs) Handles btn_criar_grupo.Click
        criacao_grupo.Show()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            Try
                If .CurrentRow.Cells(5).Selected = True Then
                    resp = MsgBox("Deseja editar o grupo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        aux = .CurrentRow.Cells(1).Value
                        sql = $"select id_grupo from grupos where nome_grupo='{aux}'"
                        rs = db.Execute(sql)
                        id_gp = rs.Fields("id_grupo").Value
                        editar_grupo.Show()
                        Me.Close()
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    resp = MsgBox("Deseja excluir o grupo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        aux = .CurrentRow.Cells(1).Value
                        sql = $"select id_grupo from grupos where nome_grupo='{aux}'"
                        rs = db.Execute(sql)
                        id_gp = rs.Fields("id_grupo").Value
                        rs.Close()

                        sql = $"DELETE FROM despesas_divisoes WHERE despesa_id IN (SELECT id_despesa FROM despesas WHERE grupo_id='{id_gp}')"
                        db.Execute(sql)
                        sql = $"delete from despesas where grupo_id='{id_gp}'"
                        db.Execute(sql)

                        sql = $"delete from usuarios_grupos where grupo_id='{id_gp}'"
                        db.Execute(sql)

                        sql = $"delete from grupos where id_grupo='{id_gp}'"
                        db.Execute(sql)
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End With
    End Sub
End Class