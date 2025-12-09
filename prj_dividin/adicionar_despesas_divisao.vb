Public Class adicionar_despesas_divisao
    Private Sub adicionar_despesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_categorias_divisao()
        carregar_categorias_divisao2()
        txt_valor_devedor1.ReadOnly = True
        txt_valor_devedor2.ReadOnly = True
    End Sub

    Private Sub btn_buscar_usuario1_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario1.Click
        pesquisa_usuario.Show()
        dif_campo = 6
    End Sub
    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        pesquisa_usuario.Show()
        dif_campo = 7
    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If txt_nome_despesa.Text = "" Or
                txt_valor_despesa.Text = "" Or
                txt_devedor.Text = "" Or
                txt_devedor2.Text = "" Or
                cmb_modo_divisao.SelectedItem Is Nothing Or
                cmb_categoria.SelectedItem Is Nothing Or
                cmb_data_despesa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "ATENÇÃO")
            Exit Sub
        ElseIf txt_devedor.Text <> nameU AndAlso txt_devedor2.Text <> nameU Then
            MsgBox("O usuário precisa ser um participante da despesa!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_devedor.Clear()
            txt_devedor2.Clear()
            txt_devedor.Focus()
        Else
            Dim total As Decimal
            Dim v1 As Decimal
            Dim v2 As Decimal

            If Not Decimal.TryParse(txt_valor_despesa.Text, total) Then
                MsgBox("Valor da despesa inválido!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If Not Decimal.TryParse(txt_valor_devedor1.Text, v1) Then
                MsgBox("Valor do 1º devedor inválido!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If Not Decimal.TryParse(txt_valor_devedor2.Text, v2) Then
                MsgBox("Valor do 2º devedor inválido!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If v1 + v2 <> total Then
                MsgBox("A soma dos valores dos devedores deve ser IGUAL ao valor da despesa!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            sql = $"insert into despesas (grupo_id, descricao, valor_total, pago_por, tipo, data_despesa, criado_em, categoria) values 
            (NULL, '{txt_nome_despesa.Text}', {txt_valor_despesa.Text.Replace(",", ".")}, NULL, 'Divisao',
            '{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',
            '{cmb_categoria.SelectedItem.ToString()}')"

            db.Execute(sql)

            rs = db.Execute("SELECT LAST_INSERT_ID()")
            id_despesa = rs.Fields(0).Value
            rs.Close()

            credor = txt_devedor2.Text
            sql = $"select id_conta from cadastro_contas where usuario='{credor}'"
            rs = db.Execute(sql)
            buscar_id_conta = rs.Fields("id_conta").Value
            rs.Close()

            sql = $"INSERT INTO despesas_divisoes (despesa_id, usuario_id, valor_individual, modo, criado_em)
                VALUES ('{id_despesa}', '{buscar_id_conta}','{valor}','{cmb_modo_divisao.SelectedItem.ToString()}', '{DateTime.Now}')"
            db.Execute(sql)

            devedor = txt_devedor.Text
            sql = $"select id_conta from cadastro_contas where usuario='{devedor}'"
            rs = db.Execute(sql)
            buscar_id_conta = rs.Fields("id_conta").Value
            rs.Close()

            sql = $"INSERT INTO despesas_divisoes (despesa_id, usuario_id, valor_individual, modo, criado_em)
                VALUES ('{id_despesa}', '{buscar_id_conta}','{valor}','{cmb_modo_divisao.SelectedItem.ToString()}', '{DateTime.Now}')"
            db.Execute(sql)

            MsgBox("Despesa registrada com sucesso!", MsgBoxStyle.Information, "AVISO")

            txt_valor_despesa.Clear()
            txt_nome_despesa.Clear()
            cmb_data_despesa.Value = DateTime.Today
            txt_devedor.Clear()
            txt_devedor2.Clear()
            cmb_categoria.SelectedIndex = -1
            cmb_modo_divisao.SelectedIndex = -1
            txt_valor_devedor1.Clear()
            txt_valor_devedor2.Clear()
            txt_nome_despesa.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub cmb_modo_divisao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_modo_divisao.SelectedIndexChanged
        If cmb_modo_divisao.SelectedItem = "Valor fixo" Then
            txt_valor_devedor1.ReadOnly = False
            txt_valor_devedor2.ReadOnly = False
        ElseIf cmb_modo_divisao.SelectedItem = "Divisão igual" Then
            txt_valor_devedor1.ReadOnly = True
            txt_valor_devedor2.ReadOnly = True
            If Decimal.TryParse(txt_valor_despesa.Text, valor) Then
            Else
                MessageBox.Show("Valor inválido!")
            End If
            valor = valor / 2
            txt_valor_devedor1.Text = valor
            txt_valor_devedor2.Text = valor
        End If
    End Sub
End Class