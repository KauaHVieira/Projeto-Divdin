Imports Google.Protobuf.WellKnownTypes
Imports System.Globalization

Public Class adicionar_despesas
    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        pesquisa_usuario.Show()
        dif_campo = 1
    End Sub
    Private Sub btn_registrar_despesa_Click(sender As Object, e As EventArgs) Handles btn_registrar_despesa.Click
        If txt_nome_despesa.Text = "" Or
            txt_valor_despesa.Text = "" Or
            txt_devedor.Text = "" Or
            txt_credor.Text = "" Or
            cmb_categoria.SelectedItem Is Nothing Or
            cmb_data_despesa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ElseIf txt_credor.Text <> nameU AndAlso txt_devedor.Text <> nameU Then
            MsgBox("O usuário precisa ser um participante da despesa!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_devedor.Clear()
            txt_credor.Clear()
            txt_devedor.Focus()
        Else
            sql = $"insert into despesas (grupo_id, descricao, valor_total, pago_por, tipo, data_despesa, criado_em, categoria) values 
                                            (NULL, '{txt_nome_despesa.Text}', {txt_valor_despesa.Text.Replace(",", ".")}, NULL, 'Pagamento', '{cmb_data_despesa.Value.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{cmb_categoria.SelectedItem.ToString()}')"
            db.Execute(sql)
            rs = db.Execute("SELECT LAST_INSERT_ID()")
            id_despesa = rs.Fields(0).Value
            rs.Close()
            credor = txt_credor.Text

            'registro do credor
            sql = $"select id_conta from cadastro_contas where usuario='{credor}'"
            rs = db.Execute(sql)
            buscar_id_conta = rs.Fields("id_conta").Value
            aux = buscar_id_conta
            rs.Close()

            sql = $"INSERT INTO despesas_pagamentos (despesa_id, usuario_id, tipo_pagamento, valor_pago, criado_em)
            VALUES ('{id_despesa}', '{buscar_id_conta}', 'credor', '0', '{DateTime.Now}')"
            db.Execute(sql)



            devedor = txt_devedor.Text
            'registro do devedor
            sql = $"select id_conta from cadastro_contas where usuario='{devedor}'"
            rs = db.Execute(sql)
            buscar_id_conta = rs.Fields("id_conta").Value
            rs.Close()

            sql = $"INSERT INTO despesas_pagamentos (despesa_id, usuario_id, tipo_pagamento, valor_pago, criado_em, pagador)
            VALUES ('{id_despesa}', '{buscar_id_conta}', 'devedor', '{txt_valor_despesa.Text.Replace(",", ".")}', '{DateTime.Now}', '{aux}')"
            db.Execute(sql)


            MsgBox("Despesa registrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_valor_despesa.Clear()
            txt_nome_despesa.Clear()
            cmb_data_despesa.Value = DateTime.Today
            txt_devedor.Clear()
            txt_credor.Clear()
            cmb_categoria.SelectedIndex = -1
            txt_nome_despesa.Focus()
            Me.Close()
        End If
    End Sub


    Private Sub adicionar_despesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_categorias()
    End Sub

    Private Sub btn_buscar_usuario1_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario1.Click
        pesquisa_usuario.Show()
        dif_campo = 2
    End Sub


End Class