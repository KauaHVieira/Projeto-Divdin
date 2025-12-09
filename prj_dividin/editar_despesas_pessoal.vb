Public Class editar_despesas_pessoal
    Private Sub editar_despesas_pessoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        cmb_categoria.Items.Clear()
        cmb_categoria.Items.Add("Alimentação")
        cmb_categoria.Items.Add("Transporte")
        cmb_categoria.Items.Add("Lazer")
        cmb_categoria.Items.Add("Saúde")
        cmb_categoria.Items.Add("Moradia")
        cmb_categoria.Items.Add("Educação")
        cmb_categoria.Items.Add("Outros")

        sql = $"SELECT * FROM despesas WHERE id_despesa = '{id_despesa}'"
        rs = db.Execute(sql)

        txt_nome_despesa.Text = rs.Fields("descricao").Value.ToString()
        txt_valor_despesa.Text = rs.Fields("valor_total").Value.ToString()

        Dim categoriaBanco As String = rs.Fields("categoria").Value.ToString().Trim()
        Dim index As Integer = cmb_categoria.FindStringExact(categoriaBanco)

        If index >= 0 Then
            cmb_categoria.SelectedIndex = index
        Else
            cmb_categoria.Text = categoriaBanco
        End If

        cmb_data_despesa.Value = Convert.ToDateTime(rs.Fields("data_despesa").Value)

    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click

        If txt_nome_despesa.Text = "" Or
           txt_valor_despesa.Text = "" Or
           String.IsNullOrWhiteSpace(cmb_categoria.Text) Or
           cmb_data_despesa.Text = "" Then

            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If

        sql = $"UPDATE despesas SET 
                    descricao = '{txt_nome_despesa.Text}',
                    valor_total = '{txt_valor_despesa.Text.Replace(",", ".")}',
                    data_despesa = '{cmb_data_despesa.Value:yyyy-MM-dd}',
                    categoria = '{cmb_categoria.Text}'
               WHERE id_despesa = '{id_despesa}'"

        db.Execute(sql)

        MsgBox("Despesa atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        txt_valor_despesa.Clear()
        txt_nome_despesa.Clear()
        cmb_categoria.SelectedIndex = -1
        cmb_data_despesa.Value = DateTime.Today

        txt_nome_despesa.Focus()
        Me.Close()

    End Sub

End Class
