Public Class editar_despesas_divisao
    Private Sub editar_despesas_divisao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_categoria_editar_despesas1()
        carregar_categorias_editar_despesas()
        txt_valor_devedor1.ReadOnly = True
        txt_valor_devedor2.ReadOnly = True
        sql = $"SELECT 
         d.id_despesa,
         d.descricao,
         d.valor_total,
         d.categoria,
         d.data_despesa,
         dd1.modo AS modo_divisao,
         c1.usuario AS devedor1,
         dd1.valor_individual AS valor_devedor1,
         c2.usuario AS devedor2,
         dd2.valor_individual AS valor_devedor2
     FROM despesas d
     INNER JOIN despesas_divisoes dd1 ON dd1.despesa_id = d.id_despesa
     INNER JOIN cadastro_contas c1 ON dd1.usuario_id = c1.id_conta
     INNER JOIN despesas_divisoes dd2 ON dd2.despesa_id = d.id_despesa AND dd2.id_divisoes <> dd1.id_divisoes
     INNER JOIN cadastro_contas c2 ON dd2.usuario_id = c2.id_conta
     WHERE d.id_despesa = {id_despesa}
     LIMIT 1;"

        rs = db.Execute(sql)
        txt_nome_despesa.Text = rs.Fields("descricao").Value.ToString()
        txt_valor_despesa.Text = rs.Fields("valor_total").Value.ToString()
        cmb_categoria.Text = rs.Fields("categoria").Value.ToString()
        cmb_data_despesa.Text = rs.Fields("data_despesa").Value.ToString()
        cmb_modo_divisao.Text = rs.Fields("modo_divisao").Value.ToString()
        txt_devedor.Text = rs.Fields("devedor1").Value.ToString()
        txt_valor_devedor1.Text = rs.Fields("valor_devedor1").Value.ToString()
        txt_devedor2.Text = rs.Fields("devedor2").Value.ToString()
        txt_valor_devedor2.Text = rs.Fields("valor_devedor2").Value.ToString()

    End Sub


    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If txt_nome_despesa.Text = "" Or
            txt_valor_despesa.Text = "" Or
            txt_devedor.Text = "" Or
            txt_devedor2.Text = "" Or
            cmb_modo_divisao.SelectedItem Is Nothing Or
            cmb_categoria.SelectedItem Is Nothing Or
            cmb_data_despesa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
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

            sql = $"update despesas set descricao='{txt_nome_despesa.Text}',
                                        valor_total='{txt_valor_despesa.Text.Replace(",", ".")}',
                                        data_despesa='{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}',
                                        categoria='{cmb_categoria.SelectedItem.ToString()}' where id_despesa='{id_despesa}'"
            db.Execute(sql)

            ' Atualizar Devedor 2
            credor = txt_devedor2.Text

            ' Buscar id_conta do devedor 2
            sql = $"SELECT id_conta FROM cadastro_contas WHERE usuario='{credor}'"
            rs = db.Execute(sql)
            buscar_id_conta = rs.Fields("id_conta").Value
            rs.Close()

            ' Buscar o registro correto em despesas_divisoes para o devedor 2
            sql = $"SELECT id_divisoes FROM despesas_divisoes WHERE despesa_id='{id_despesa}' ORDER BY id_divisoes DESC LIMIT 1"
            rs = db.Execute(sql)
            id_divisoes = rs.Fields("id_divisoes").Value
            rs.Close()

            ' Atualizar dados do devedor 2
            sql = $"UPDATE despesas_divisoes SET usuario_id='{buscar_id_conta}',
                                    valor_individual='{Convert.ToDecimal(txt_valor_devedor2.Text).ToString(System.Globalization.CultureInfo.InvariantCulture)}',
                                    modo='{cmb_modo_divisao.SelectedItem.ToString()}' 
            WHERE id_divisoes='{id_divisoes}'"
            db.Execute(sql)

            ' -----------------------------
            ' Atualizar Devedor 1
            devedor = txt_devedor.Text

            ' Buscar id_conta do devedor 1
            sql = $"SELECT id_conta FROM cadastro_contas WHERE usuario='{devedor}'"
            rs = db.Execute(sql)
            buscar_id_conta = rs.Fields("id_conta").Value
            rs.Close()

            ' Buscar o registro correto em despesas_divisoes para o devedor 1
            sql = $"SELECT id_divisoes FROM despesas_divisoes WHERE despesa_id='{id_despesa}' ORDER BY id_divisoes ASC LIMIT 1"
            rs = db.Execute(sql)
            id_divisoes = rs.Fields("id_divisoes").Value
            rs.Close()

            ' Atualizar dados do devedor 1
            sql = $"UPDATE despesas_divisoes SET usuario_id='{buscar_id_conta}',
                                    valor_individual='{Convert.ToDecimal(txt_valor_devedor1.Text).ToString(System.Globalization.CultureInfo.InvariantCulture)}',
                                    modo='{cmb_modo_divisao.SelectedItem.ToString()}' 
            WHERE id_divisoes='{id_divisoes}'"
            db.Execute(sql)


            MsgBox("Despesa registrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
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
    Private Sub btn_buscar_usuario1_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario1.Click
        pesquisa_usuario.Show()
        dif_campo = 6
    End Sub
    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        pesquisa_usuario.Show()
        dif_campo = 7
    End Sub
End Class