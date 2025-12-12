Public Class cadastro
    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        If txt_email.Text = "" Or
           txt_usuario.Text = "" Or
           txt_senha.Text = "" Or
           txt_csenha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ElseIf txt_senha.Text <> txt_csenha.Text Then
            MsgBox("Senhas inválidas!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_senha.Clear()
            txt_csenha.Clear()
            txt_senha.Focus()

        Else
            sql = $"insert into cadastro_contas (usuario,email,senha) values
                        ('{txt_usuario.Text}', '{txt_email.Text}', '{txt_senha.Text}')"
            rs = db.Execute(sql)
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_usuario.Clear()
            txt_email.Clear()
            txt_senha.Clear()
            txt_csenha.Clear()
            txt_usuario.Focus()
            Me.Close()
            login.Show()
        End If
    End Sub

    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()

    End Sub

    Private Sub link_login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_login.LinkClicked
        Try
            login.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_ver_senha1_Click(sender As Object, e As EventArgs) Handles btn_ver_senha1.Click
        If txt_senha.PasswordChar = "*" Then
            txt_senha.PasswordChar = ChrW(0)
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_versenha2_Click(sender As Object, e As EventArgs) Handles btn_versenha2.Click
        If txt_csenha.PasswordChar = "*" Then
            txt_csenha.PasswordChar = ChrW(0)
        Else
            txt_csenha.PasswordChar = "*"
        End If
    End Sub
End Class