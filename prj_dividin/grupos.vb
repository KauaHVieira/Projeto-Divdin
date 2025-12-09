Public Class grupos
    Private Sub grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados_grupos()
        sql = $"select usuario from cadastro_contas where id_conta='{token}'"
        rs = db.Execute(sql)
        txt_nomeU.Text = rs.Fields("usuario").Value.ToString()
    End Sub

    Private Sub btn_criar_grupo_Click(sender As Object, e As EventArgs) Handles btn_criar_grupo.Click
        criacao_grupo.showdialog()
        Me.Hide()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(5).Selected = True Then
                    resp = MsgBox("Deseja visualizar o grupo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        aux = .CurrentRow.Cells(1).Value
                        sql = $"select * from grupos where nome_grupo='{aux}'"
                        rs = db.Execute(sql)
                        id_gp = rs(0).Value
                        grupo_usuario.Show()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_meus_grupos_Click(sender As Object, e As EventArgs) Handles btn_meus_grupos.Click
        grupos_criados_usuario.Show()
        Me.Close()

    End Sub

End Class