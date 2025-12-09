Public Class despesas
    Private Sub btn_adicionar_despesas_Click(sender As Object, e As EventArgs) Handles btn_adicionar_despesas.Click
        tipo_despesa.Show()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        selecao_editar_despesa.Show()
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        visualizar_despesas.Show()
    End Sub

    Private Sub btn_remover_despesas_Click(sender As Object, e As EventArgs) Handles btn_remover_despesas.Click
        remover_despesas.showdialog()
        Me.Hide()
    End Sub

    Private Sub despesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class