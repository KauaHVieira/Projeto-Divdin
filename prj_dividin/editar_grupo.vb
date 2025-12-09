Public Class editar_grupo
    Private Sub editar_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()

        sql = $"select * from grupos where id_grupo='{id_gp}'"
        rs = db.Execute(sql)
        id_gp = rs.Fields("id_grupo").Value

        txt_nome_grupo.Text = rs.Fields("nome_grupo").Value.ToString()
        txt_descricao.Text = rs.Fields("descricao").Value.ToString()
        txt_limiteM.Text = rs.Fields("limite_membros").Value.ToString()

    End Sub

    Private Sub btn_criar_grupo_Click(sender As Object, e As EventArgs) Handles btn_criar_grupo.Click
        If txt_nome_grupo.Text = "" Or
           txt_descricao.Text = "" Or
           txt_limiteM.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = $"update grupos set nome_grupo='{txt_nome_grupo.Text}',
                                      descricao='{txt_descricao.Text}',
                                      limite_membros='{txt_limiteM.Text}' where id_grupo='{id_gp}'"
            rs = db.Execute(sql)
            MsgBox("Grupo editado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_nome_grupo.Clear()
            txt_descricao.Clear()
            txt_limiteM.Clear()
            grupos_criados_usuario.Show()
            Me.Close()
        End If

    End Sub
End Class