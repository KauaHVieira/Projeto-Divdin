Public Class adicionar_despesas_grupo
    Private Sub adicionar_despesas_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_adicionar_Dgrupo()
        txt_valor_devedor1.ReadOnly = True
        lista_devedores_grupo.Clear()
        txt_valor_devedor1.Text = 0
    End Sub

    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        adicionar_membro.Show()
        dif_campo = 9
    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If txt_nome_despesa.Text = "" Or
           txt_valor_despesa.Text = "" Or
           txt_devedor.Text = "" Or
           cmb_categoria.SelectedItem Is Nothing Or
           cmb_data_despesa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = $"insert into despesas (grupo_id, descricao, valor_total, pago_por, tipo, data_despesa, criado_em, categoria) values 
                                            ('{id_gp}', '{txt_nome_despesa.Text}', {txt_valor_despesa.Text}, NULL, 'Divisao', '{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{cmb_categoria.SelectedItem.ToString()}')"
            db.Execute(sql)
            rs = db.Execute("SELECT LAST_INSERT_ID()")
            id_despesa = rs.Fields(0).Value
            rs.Close()

            For Each usuario In lista_devedores_grupo
                sql = $"select id_conta from cadastro_contas where id_conta ='{usuario}'"
                rs = db.Execute(sql)
                buscar_id_conta = rs.Fields("id_conta").Value
                rs.Close()

                sql = $"INSERT INTO despesas_divisoes (despesa_id, usuario_id, valor_individual, modo, criado_em)
                VALUES ('{id_despesa}', '{buscar_id_conta}','{valor}','Divisão igual', '{DateTime.Now}')"
                db.Execute(sql)
            Next

            MsgBox("Despesa registrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_valor_despesa.Clear()
            txt_nome_despesa.Clear()
            cmb_data_despesa.Value = DateTime.Today
            txt_devedor.Clear()
            cmb_categoria.SelectedIndex = -1
            txt_nome_despesa.Focus()
            grupo_usuario.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txt_devedor_TextChanged(sender As Object, e As EventArgs) Handles txt_devedor.TextChanged
        txt_valor_devedor1.ReadOnly = True
        If Decimal.TryParse(txt_valor_despesa.Text, valor) Then
        End If
        Dim numerodeitens As Integer = lista_devedores_grupo.Count
        valor = valor / numerodeitens
        txt_valor_devedor1.Text = valor
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_devedor.Text = ""
        txt_valor_devedor1.Text = 0
        lista_devedores_grupo.Clear()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class