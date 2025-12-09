Public Class quitar_despesa
    Private Sub quitar_despesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        txt_nomeU.Text = nameU
        sql = $"SELECT 
               d.id_despesa,
               d.descricao,
               d.categoria,
               d.valor_total,
               d.tipo,
               CASE 
                   WHEN d.tipo = 'Pagamento' THEN dp.valor_pago
                   WHEN d.tipo = 'Divisao' THEN dd.valor_individual
                   WHEN d.tipo = 'Pessoal' THEN d.valor_total
               END AS valor_pago
            FROM despesas d
            LEFT JOIN despesas_pagamentos dp 
                ON dp.despesa_id = d.id_despesa 
                AND dp.usuario_id = {token} 
                AND d.tipo = 'Pagamento'
            LEFT JOIN despesas_divisoes dd 
                ON dd.despesa_id = d.id_despesa 
                AND dd.usuario_id = {token} 
                AND d.tipo = 'Divisao'
            WHERE (d.pago_por = {token} OR dp.usuario_id = {token} OR dd.usuario_id = {token})
              AND d.id_despesa = {id_despesa}
            ORDER BY d.data_despesa ASC;"

        rs = db.Execute(sql)
        txt_nome_despesa.Text = rs.Fields("descricao").Value.ToString()
        txt_valor_despesa.Text = rs.Fields("valor_total").Value.ToString()
        txt_valor_aserpago.Text = rs.Fields("valor_pago").Value.ToString()
        cmb_categoria.Text = rs.Fields("categoria").Value.ToString()

        txt_nome_despesa.ReadOnly = True
        txt_valor_despesa.ReadOnly = True
        cmb_categoria.Enabled = False
        txt_valor_aserpago.ReadOnly = True

    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If tipoQ_despesa = "Pagamento" Then
            sql = $"delete from despesas_pagamentos where despesa_id='{id_despesa}'"
            db.Execute(sql)

            sql = $"delete from despesas where id_despesa='{id_despesa}'"
            db.Execute(sql)
        ElseIf tipoQ_despesa = "Divisao" Then
            sql = $"delete from despesas_divisoes where usuario_id='{token}' and despesa_id='{id_despesa}'"
            db.Execute(sql)
            Dim novo_valor_total As New Decimal
            novo_valor_total = CDec(txt_valor_despesa.Text) - CDec(txt_valor_aserpago.Text)
            If novo_valor_total <= 0 Then
                sql = $"delete from despesas where id_despesa='{id_despesa}'"
                db.Execute(sql)
            Else
                sql = $"update despesas set valor_total='{novo_valor_total}' where id_despesa='{id_despesa}'"
                db.Execute(sql)
            End If
        ElseIf tipoQ_despesa = "Pessoal" Then
            sql = $"delete from despesas where id_despesa='{id_despesa}'"
            db.Execute(sql)
        End If

        MsgBox("Despesa quitada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        txt_valor_despesa.Clear()
        txt_nome_despesa.Clear()
        txt_nome_despesa.Focus()
        Me.Close()
    End Sub
End Class