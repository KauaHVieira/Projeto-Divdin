Public Class pesquisa_usuario
    Private Sub pesquisa_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados()
        carregar_tipos_dados()
    End Sub

    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click
        With dgv_dados
            sql = $"select * from cadastro_contas where {cmb_campo.Text} like '{txt_buscar.Text}%'"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    resp = MsgBox("Deseja adicionar esse usuário a sua despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        nome_selecionado = .CurrentRow.Cells(1).Value
                        If dif_campo = 1 Then
                            adicionar_despesas.txt_devedor.Text = nome_selecionado
                            Me.Close()
                        ElseIf dif_campo = 2 Then
                            adicionar_despesas.txt_credor.Text = nome_selecionado
                            Me.Close()
                        ElseIf dif_campo = 3 Then
                            sql = $"select id_conta from cadastro_contas where usuario='{nome_selecionado}'"
                            rs = db.Execute(sql)
                            aux = rs("id_conta").Value
                            rs.Close()
                        ElseIf dif_campo = 4 Then
                            editar_despesas_pagamento.txt_devedor.Text = nome_selecionado
                            Me.Close()
                        ElseIf dif_campo = 5 Then
                            editar_despesas_pagamento.txt_credor.Text = nome_selecionado
                            Me.Close()
                        ElseIf dif_campo = 6 Then
                            adicionar_despesas_divisao.txt_devedor2.Text = nome_selecionado
                            editar_despesas_divisao.txt_devedor2.Text = nome_selecionado
                            Me.Close()
                        ElseIf dif_campo = 7 Then
                            adicionar_despesas_divisao.txt_devedor.Text = nome_selecionado
                            editar_despesas_divisao.txt_devedor.Text = nome_selecionado
                            Me.Close()
                        ElseIf dif_campo = 8 Then
                            Dim limiteM As Decimal
                            sql = $"select limite_membros from grupos where id_grupo='{id_gp}'"
                            rs = db.Execute(sql)
                            limiteM = rs("limite_membros").Value
                            If limiteM > 10 Then
                                MsgBox("O limite máximo de membros por grupo é 10!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                                Me.Close()
                                Exit Sub
                            End If
                            rs.Close()
                            sql = $"select id_conta from cadastro_contas where usuario='{nome_selecionado}'"
                            rs = db.Execute(sql)
                            aux = rs("id_conta").Value
                            rs.Close()
                            sql = $"insert into usuarios_grupos (usuario_id, grupo_id, entrou_em) values ('{aux}', '{id_gp}', '{DateTime.Now}') "
                            rs = db.Execute(sql)
                            Me.Close()
                        Else
                            sql = $"insert into usuarios_grupos (usuario_id, grupo_id, entrou_em) values ('{aux}', '{id_gp}', '{DateTime.Now}') "
                            rs = db.Execute(sql)
                        End If
                        dif_campo = 0
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class