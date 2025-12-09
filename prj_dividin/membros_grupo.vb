Public Class membros_grupo

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(3).Selected = True Then
                resp = MsgBox("Deseja adicionar um membro ao grupo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    pesquisa_usuario.Show()
                    dif_campo = 3
                End If
            ElseIf .CurrentRow.Cells(4).Selected = True Then
                resp = MsgBox("Deseja remover este membro do grupo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            End If
        End With
    End Sub

    Private Sub membros_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        carregar_dados_membros_grupo()
        carregar_tipos_dados_membros()
    End Sub

    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click
        With dgv_dados
            sql = $"select c.usuario, c.email from cadastro_contas c inner join usuarios_grupos ug on c.id_conta = ug.usuario_id
            where (ug.grupo_id ='{id_gp}') AND {cmb_campo.Text} LIKE '{txt_buscar.Text}%' order by c.id_conta asc"

            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields("usuario").Value, rs.Fields("email").Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With

    End Sub
End Class