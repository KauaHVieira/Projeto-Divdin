Public Class visualizar_despesas
    Private Sub visualizar_despesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados_visualizar_despesas()
        carregar_tipos_dados_despesas()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgv_dados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

    End Sub

    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click
        With dgv_dados
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
            WHERE (d.pago_por = {token} OR dp.usuario_id = {token} OR dd.usuario_id = {token}) AND {cmb_campo.Text} LIKE '{txt_buscar.Text}%'
            
            ORDER BY d.data_despesa ASC"

            rs = db.Execute(sql)
            .Rows.Clear()
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont,
                  rs.Fields("descricao").Value,
                  rs.Fields("categoria").Value,
                  rs.Fields("valor_total").Value,
                  rs.Fields("tipo").Value,
                  rs.Fields("valor_pago").Value)
                rs.MoveNext()
                cont += 1
            Loop
        End With
    End Sub
End Class