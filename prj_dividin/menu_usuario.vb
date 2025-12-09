Imports System.Runtime.Remoting.Messaging

Public Class menu_usuario


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_controle_despesas_Click(sender As Object, e As EventArgs) Handles btn_controle_despesas.Click
        despesas.Show()
    End Sub

    Private Sub btn_grupos_Click(sender As Object, e As EventArgs) Handles btn_grupos.Click
        grupos.showdialog()
    End Sub

    Private Sub menu_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        sql = $"select usuario from cadastro_contas where id_conta='{token}'"
        rs = db.Execute(sql)
        nameU = rs.Fields("usuario").Value.ToString()
        txt_nomeU.Text = nameU
    End Sub

    Private Sub btn_saldo_geral_Click(sender As Object, e As EventArgs) Handles btn_saldo_geral.Click
        saldo_geral_despesas.show()
    End Sub

    Private Sub btn_sair_conta_Click(sender As Object, e As EventArgs) Handles btn_sair_conta.Click
        resp = MsgBox("Deseja realmente sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            login.Show()
            Me.Close()
        End If
    End Sub
End Class
