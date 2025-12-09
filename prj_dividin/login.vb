Public Class login

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = "" Or
                txt_senha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = $"select * from cadastro_contas where (usuario='{txt_usuario.Text}' OR email='{txt_usuario.Text}') AND senha='{txt_senha.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                token = rs.Fields("id_conta").Value.ToString()
                Dim menu As New menu_usuario()
                Me.Hide()
                menu.Show()
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            Else
                MsgBox("Credenciais inválidas!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = AutoScaleMode.None
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        conecta_banco_mysql()
    End Sub

    Private Sub link_cadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_cadastro.LinkClicked
        Try
            cadastro.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao Executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_ver_senha_Click(sender As Object, e As EventArgs) Handles btn_ver_senha.Click
        If txt_senha.PasswordChar = "*" Then
            txt_senha.PasswordChar = ChrW(0)  ' mostra a senha
        Else
            txt_senha.PasswordChar = "*"c  ' oculta a senha
        End If
    End Sub
End Class