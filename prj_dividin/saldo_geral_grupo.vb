Public Class saldo_geral_grupo
    Private Sub saldo_geral_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        sql = $"select nome_grupo from grupos where id_grupo='{id_gp}'"
        rs = db.Execute(sql)
        txt_nome_grupo.Text = rs.Fields("nome_grupo").Value.ToString()

        sql = $"SELECT COALESCE(SUM(dd.valor_individual), 0) AS total_devido
                FROM despesas_divisoes dd
                INNER JOIN despesas d ON d.id_despesa = dd.despesa_id
                WHERE dd.usuario_id = {token} 
                AND d.grupo_id = {id_gp};"

        rs = db.Execute(sql)
        If Not rs.EOF Then
            Dim total_devido As Decimal = rs.Fields("total_devido").Value
            txt_valor_despesas.Text = total_devido.ToString("F2")
        End If
        rs.Close()


        sql = $"SELECT COUNT(*) AS total_despesas
                FROM despesas_divisoes dd
                INNER JOIN despesas d ON d.id_despesa = dd.despesa_id
                WHERE dd.usuario_id = {token} 
                AND d.grupo_id = {id_gp};"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            txt_total_despesas.Text = rs.Fields("total_despesas").Value
        End If
        rs.Close()

    End Sub

    Private Sub btn_quitar_despesas_Click(sender As Object, e As EventArgs) Handles btn_quitar_despesas.Click
        selecao_quitar_despesas_grupo.show()
    End Sub

    Private Sub txt_nome_grupo_Click(sender As Object, e As EventArgs) Handles txt_nome_grupo.Click

    End Sub

    Private Sub txt_valor_despesas_Click(sender As Object, e As EventArgs) Handles txt_valor_despesas.Click

    End Sub
End Class