Public Class adicionar_despesas_pessoal
    Private Sub adicionar_despesas_pessoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_categorias_pessoal()
    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If txt_nome_despesa.Text = "" Or
           txt_valor_despesa.Text = "" Or
           cmb_categoria.SelectedItem Is Nothing Or
           cmb_data_despesa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = $"insert into despesas (grupo_id, descricao, valor_total, pago_por, tipo, data_despesa, criado_em, categoria) values 
                                            (NULL, '{txt_nome_despesa.Text}', {txt_valor_despesa.Text.Replace(",", ".")}, '{token}', 'Pessoal', '{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{cmb_categoria.SelectedItem.ToString()}')"
            db.Execute(sql)
            MsgBox("Despesa registrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_valor_despesa.Clear()
            txt_nome_despesa.Clear()
            cmb_data_despesa.Value = DateTime.Today
            cmb_categoria.SelectedIndex = -1
            txt_nome_despesa.Focus()
        End If
        Me.Close()
    End Sub
End Class