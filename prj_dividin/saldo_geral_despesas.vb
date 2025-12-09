Public Class saldo_geral_despesas
    Private Sub saldo_geral_despesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()

        sql = $"SELECT 
        (
        SELECT COALESCE(SUM(dd.valor_individual), 0)
        FROM despesas_divisoes dd
        WHERE dd.usuario_id = {token}
        )
        +
        (
        SELECT COALESCE(SUM(dp.valor_pago), 0)
        FROM despesas_pagamentos dp
        WHERE dp.usuario_id = {token}
        )
        +
        (
        SELECT COALESCE(SUM(d.valor_total), 0)
        FROM despesas d
        WHERE d.pago_por = {token} 
          AND d.tipo = 'Pessoal'
        ) AS total_devido;"

        rs = db.Execute(sql)
        If Not rs.EOF Then
            Dim total_devido As Decimal = rs.Fields("total_devido").Value
            txt_valor_despesas.Text = total_devido.ToString("F2")
        End If
        rs.Close()

        sql = $"SELECT SUM(dp.valor_pago) AS total_a_receber
                FROM despesas_pagamentos dp
                INNER JOIN despesas d 
                ON d.id_despesa = dp.despesa_id
                WHERE dp.tipo_pagamento = 'devedor'
                AND dp.usuario_id <> {token}
                AND dp.pagador='{token}';"

        rs = db.Execute(sql)
        If Not rs.EOF Then
            Dim total_a_receber As Decimal
            If IsDBNull(rs.Fields("total_a_receber").Value) Then
                total_a_receber = 0D
            Else
                total_a_receber = CDec(rs.Fields("total_a_receber").Value)
            End If

            txt_receber_despesas.Text = total_a_receber.ToString("F2")
        End If
        rs.Close()


        sql = $"SELECT
        (
        (SELECT COUNT(*) FROM despesas_pagamentos WHERE usuario_id = {token})
        +
        (SELECT COUNT(*) FROM despesas_divisoes WHERE usuario_id = {token})
        +
        (SELECT COUNT(*) FROM despesas WHERE pago_por = {token})
        ) AS total_despesas"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            txt_total_despesas.Text = rs.Fields("total_despesas").Value
        End If
        rs.Close()


    End Sub

    Private Sub btn_quitar_despesas_Click(sender As Object, e As EventArgs) Handles btn_quitar_despesas.Click
        selecao_quitar_despesas.show()
    End Sub


End Class