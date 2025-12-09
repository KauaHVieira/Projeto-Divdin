Imports Google.Protobuf.WellKnownTypes

Public Class editar_despesas_grupo
    Private Sub editar_despesas_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_editar_Dgrupo()
        btn_buscar_usuario.Enabled = False
        txt_valor_devedor1.ReadOnly = True
        txt_devedor.ReadOnly = True

        sql = $"Select d.id_despesa, d.descricao, d.valor_total, d.categoria, d.data_despesa, 
        GROUP_CONCAT(c.usuario SEPARATOR ', ') AS devedores, dd.valor_individual AS valor_individual 
        FROM despesas d 
        INNER JOIN despesas_divisoes dd ON dd.despesa_id = d.id_despesa 
        INNER JOIN cadastro_contas c ON c.id_conta = dd.usuario_id 
        WHERE d.id_despesa = {id_despesa} 
        GROUP BY d.id_despesa, d.descricao, d.valor_total, d.categoria, d.data_despesa;" 
        rs = db.Execute(sql)
        If Not rs.EOF Then
            txt_nome_despesa.Text = rs.Fields("descricao").Value.ToString()
            txt_valor_despesa.Text = rs.Fields("valor_total").Value.ToString()
            cmb_categoria.Text = rs.Fields("categoria").Value.ToString()
            cmb_data_despesa.Text = rs.Fields("data_despesa").Value.ToString()
            txt_valor_devedor1.Text = rs.Fields("valor_individual").Value.ToString()
            txt_devedor.Text = rs.Fields("devedores").Value.ToString()
        End If

    End Sub

    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If txt_nome_despesa.Text = "" Or
        txt_valor_despesa.Text = "" Or
        txt_devedor.Text = "" Or
        cmb_categoria.SelectedItem Is Nothing Or
        cmb_data_despesa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = $"update despesas set descricao ='{txt_nome_despesa.Text}', 
                    valor_total='{txt_valor_despesa.Text.Replace(",", ".")}', 
                    tipo='Divisao', 
                    data_despesa='{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}', 
                    categoria='{cmb_categoria.SelectedItem.ToString()}' where id_despesa='{id_despesa}'"
            db.Execute(sql)

            For Each usuario In lista_devedores_grupo
                sql = $"Select id_conta from cadastro_contas where id_conta ='{usuario}'"
                rs = db.Execute(sql)
                buscar_id_conta = rs.Fields("id_conta").Value
                rs.Close()
                sql = $"update despesas_divisoes Set usuario_id='{buscar_id_conta}', 
                        valor_individual='{Decimal.Parse(txt_valor_devedor1.Text).ToString("F2")}' 
                        where despesa_id='{id_despesa}' and usuario_id='{buscar_id_conta}'"
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

    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        adicionar_membro.Show()
        dif_campo = 10
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        btn_buscar_usuario.Enabled = True
        txt_devedor.Text = ""
        txt_valor_devedor1.Text = 0
        lista_devedores_grupo.Clear()
    End Sub

    Private Sub txt_devedor_TextChanged(sender As Object, e As EventArgs) Handles txt_devedor.TextChanged
        txt_valor_devedor1.ReadOnly = True
        If Decimal.TryParse(txt_valor_despesa.Text, valor) Then
        Else
        End If

        If lista_devedores_grupo.Count > 0 Then
            Dim numerodeitens As Integer = lista_devedores_grupo.Count
            valor = valor / numerodeitens
            txt_valor_devedor1.Text = valor
        Else
            sql = $"SELECT COUNT(*) AS total_devedores FROM despesas_divisoes WHERE despesa_id = {id_despesa}"
            rs = db.Execute(sql)
            Dim totalDevedores As Integer
            totalDevedores = rs.Fields("total_devedores").Value
            valor = valor / totalDevedores
            txt_valor_devedor1.Text = valor
        End If

    End Sub
End Class