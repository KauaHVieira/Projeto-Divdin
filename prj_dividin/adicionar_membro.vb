Public Class adicionar_membro
    Private Sub adicionar_membro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados()
        carregar_tipos_dados()
        carregar_dados_membros_grupo()
        carregar_tipos_dados_add_membros()

    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            Try
                With dgv_dados
                    If .CurrentRow.Cells(3).Selected = True Then
                        If dif_campo = 9 Then
                            resp = MsgBox("Deseja adicionar esse membro a despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                nome_selecionado = .CurrentRow.Cells(1).Value
                                sql = $"select id_conta from cadastro_contas where usuario='{nome_selecionado}'"
                                rs = db.Execute(sql)
                                aux = rs("id_conta").Value
                                rs.Close()
                                lista_devedores_grupo.Add(aux)
                                With adicionar_despesas_grupo.txt_devedor
                                    If .Text = "" Then
                                        .Text = nome_selecionado
                                    Else
                                        .Text &= ", " & nome_selecionado  ' separa por vírgula
                                    End If
                                End With
                                Me.Close()
                            End If
                        ElseIf dif_campo = 10 Then
                            resp = MsgBox("Deseja adicionar esse membro a despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                nome_selecionado = .CurrentRow.Cells(1).Value
                                sql = $"select id_conta from cadastro_contas where usuario='{nome_selecionado}'"
                                rs = db.Execute(sql)
                                aux = rs("id_conta").Value
                                rs.Close()
                                lista_devedores_grupo.Add(aux)
                                With editar_despesas_grupo.txt_devedor
                                    If .Text = "" Then
                                        .Text = nome_selecionado
                                    Else
                                        .Text &= ", " & nome_selecionado  ' separa por vírgula
                                    End If
                                End With
                                Me.Close()
                            End If
                        End If
                    End If
                End With
            Catch ex As Exception
                MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End With
    End Sub

    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click

    End Sub
End Class