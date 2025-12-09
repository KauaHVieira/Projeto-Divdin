Public Class grupo_usuario
    Private Sub grupo_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_despesas_grupos()
        sql = $"select * from grupos where id_grupo ='{id_gp}'"
        rs = db.Execute(sql)
        Dim id_criador As String
        id_criador = rs.Fields("criado_por").Value.ToString()
        rs.Close()
        Dim criadorGP As String
        sql = $"select usuario from cadastro_contas where id_conta ='{id_criador}'"
        rs = db.Execute(sql)
        criadorGP = rs.Fields("usuario").Value.ToString()
        rs.Close()
        sql = $"select * from grupos where id_grupo ='{id_gp}'"
        rs = db.Execute(sql)
        txt_nome_grupo.Text = rs.Fields("nome_grupo").Value.ToString()
        txt_descricao.Text = rs.Fields("descricao").Value.ToString()
        txt_qtd_membros.Text = rs.Fields("limite_membros").Value.ToString()
        txt_criado_por.Text = criadorGP
        txt_criado_em.Text = rs.Fields("criado_em").Value.ToString()



    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        With dgv_dados

        End With
    End Sub

    Private Sub btn_membros_Click(sender As Object, e As EventArgs) Handles btn_membros.Click
        membros_grupo.Show()
    End Sub

    Private Sub btn_add_membro_Click(sender As Object, e As EventArgs) Handles btn_add_membro.Click
        pesquisa_usuario.Show()
        dif_campo = 8
    End Sub

    Private Sub btn_criar_grupo_Click(sender As Object, e As EventArgs) Handles btn_criar_grupo.Click
        adicionar_despesas_grupo.Show()
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            Try
                If .CurrentRow.Cells(6).Selected Then
                    resp = MsgBox("Deseja editar a despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        aux = .CurrentRow.Cells(1).Value
                        sql = $"select id_despesa from despesas where descricao='{aux}'"
                        rs = db.Execute(sql)
                        id_despesa = rs.Fields("id_despesa").Value
                        editar_despesas_grupo.Show()
                        Me.Close()
                    End If
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    resp = MsgBox("Deseja excluir a despesa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        aux = .CurrentRow.Cells(1).Value
                        sql = $"select id_despesa from despesas where descricao='{aux}'"
                        rs = db.Execute(sql)
                        id_despesa = rs.Fields("id_despesa").Value
                        rs.Close()

                        sql = $"delete from despesas_divisoes where despesa_id='{id_despesa}'"
                        db.Execute(sql)

                        sql = $"delete from despesas where id_despesa='{id_despesa}'"
                        db.Execute(sql)

                        carregar_despesas_grupos()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End With
    End Sub

    Private Sub btn_salgo_geral_Click(sender As Object, e As EventArgs) Handles btn_salgo_geral.Click
        saldo_geral_grupo.show()
    End Sub


End Class