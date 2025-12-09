Public Class tipo_despesa
    Private Sub tipo_despesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()

    End Sub

    Private Sub btn_pagamento_despesa_Click(sender As Object, e As EventArgs) Handles btn_pagamento_despesa.Click
        adicionar_despesas.Show()
        Me.Close()
    End Sub

    Private Sub btn_divisao_despesa_Click(sender As Object, e As EventArgs) Handles btn_divisao_despesa.Click
        adicionar_despesas_divisao.Show()
        Me.Close()
    End Sub

    Private Sub btn_despesa_pessoal_Click(sender As Object, e As EventArgs) Handles btn_despesa_pessoal.Click
        adicionar_despesas_pessoal.Show()
        Me.Close()
    End Sub
End Class