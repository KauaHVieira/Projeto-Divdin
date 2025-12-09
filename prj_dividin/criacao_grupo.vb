Public Class criacao_grupo
    Private Sub btn_criar_grupo_Click(sender As Object, e As EventArgs) Handles btn_criar_grupo.Click
        If txt_nome_grupo.Text = "" Or
            txt_descricao.Text = "" Or
            txt_limiteM.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            Dim limiteM As Decimal

            If Not Decimal.TryParse(txt_limiteM.Text, limiteM) Then
                MsgBox("Valor da despesa inválido!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If limiteM > 10 Then
                MsgBox("O limite máximo de membros por grupo é 10!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                txt_limiteM.Clear()
                txt_limiteM.Focus()
                Exit Sub
            End If

            sql = $"insert into grupos (nome_grupo, descricao, limite_membros, criado_por, criado_em) values 
                                    ('{txt_nome_grupo.Text}', '{txt_descricao.Text}', '{txt_limiteM.Text}', '{token}', '{DateTime.Now}')"
            rs = db.Execute(sql)

            sql = "SELECT LAST_INSERT_ID()"
            rs = New ADODB.Recordset
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            id_gp = rs(0).Value
            rs.Close()

            sql = $"insert into usuarios_grupos (usuario_id, grupo_id, entrou_em) values ('{token}', '{id_gp}', '{DateTime.Now}')"
            rs = db.Execute(sql)


            grupo_usuario.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub criacao_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
    End Sub
End Class