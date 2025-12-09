<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grupo_usuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grupo_usuario))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_criar_grupo = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nome_grupo = New System.Windows.Forms.Label()
        Me.txt_qtd_membros = New System.Windows.Forms.Label()
        Me.txt_criado_por = New System.Windows.Forms.Label()
        Me.txt_criado_em = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.Label()
        Me.btn_add_membro = New Guna.UI.WinForms.GunaButton()
        Me.btn_membros = New Guna.UI.WinForms.GunaButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_salgo_geral = New Guna.UI.WinForms.GunaButton()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 32)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Nome do grupo:"
        '
        'btn_criar_grupo
        '
        Me.btn_criar_grupo.AnimationHoverSpeed = 0.07!
        Me.btn_criar_grupo.AnimationSpeed = 0.03!
        Me.btn_criar_grupo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_criar_grupo.BorderColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_criar_grupo.FocusedColor = System.Drawing.Color.Empty
        Me.btn_criar_grupo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar_grupo.ForeColor = System.Drawing.Color.White
        Me.btn_criar_grupo.Image = CType(resources.GetObject("btn_criar_grupo.Image"), System.Drawing.Image)
        Me.btn_criar_grupo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_criar_grupo.Location = New System.Drawing.Point(792, 209)
        Me.btn_criar_grupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_criar_grupo.Name = "btn_criar_grupo"
        Me.btn_criar_grupo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_criar_grupo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_criar_grupo.OnHoverImage = Nothing
        Me.btn_criar_grupo.OnPressedColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.Size = New System.Drawing.Size(241, 37)
        Me.btn_criar_grupo.TabIndex = 44
        Me.btn_criar_grupo.Text = "Adicionar despesa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(391, 32)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Quantidade  máxima de membros:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 32)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Descrição de grupo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 37)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Despesas do grupo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 32)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Criado por:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(132, 32)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Criado em:"
        '
        'txt_nome_grupo
        '
        Me.txt_nome_grupo.AutoSize = True
        Me.txt_nome_grupo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_grupo.ForeColor = System.Drawing.Color.White
        Me.txt_nome_grupo.Location = New System.Drawing.Point(251, 32)
        Me.txt_nome_grupo.Name = "txt_nome_grupo"
        Me.txt_nome_grupo.Size = New System.Drawing.Size(69, 28)
        Me.txt_nome_grupo.TabIndex = 53
        Me.txt_nome_grupo.Text = "Label7"
        '
        'txt_qtd_membros
        '
        Me.txt_qtd_membros.AutoSize = True
        Me.txt_qtd_membros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_membros.ForeColor = System.Drawing.Color.White
        Me.txt_qtd_membros.Location = New System.Drawing.Point(437, 62)
        Me.txt_qtd_membros.Name = "txt_qtd_membros"
        Me.txt_qtd_membros.Size = New System.Drawing.Size(69, 28)
        Me.txt_qtd_membros.TabIndex = 54
        Me.txt_qtd_membros.Text = "Label8"
        '
        'txt_criado_por
        '
        Me.txt_criado_por.AutoSize = True
        Me.txt_criado_por.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_criado_por.ForeColor = System.Drawing.Color.White
        Me.txt_criado_por.Location = New System.Drawing.Point(201, 95)
        Me.txt_criado_por.Name = "txt_criado_por"
        Me.txt_criado_por.Size = New System.Drawing.Size(69, 28)
        Me.txt_criado_por.TabIndex = 55
        Me.txt_criado_por.Text = "Label9"
        '
        'txt_criado_em
        '
        Me.txt_criado_em.AutoSize = True
        Me.txt_criado_em.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_criado_em.ForeColor = System.Drawing.Color.White
        Me.txt_criado_em.Location = New System.Drawing.Point(201, 123)
        Me.txt_criado_em.Name = "txt_criado_em"
        Me.txt_criado_em.Size = New System.Drawing.Size(80, 28)
        Me.txt_criado_em.TabIndex = 56
        Me.txt_criado_em.Text = "Label10"
        '
        'txt_descricao
        '
        Me.txt_descricao.AutoSize = True
        Me.txt_descricao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.ForeColor = System.Drawing.Color.White
        Me.txt_descricao.Location = New System.Drawing.Point(301, 154)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(80, 28)
        Me.txt_descricao.TabIndex = 57
        Me.txt_descricao.Text = "Label11"
        '
        'btn_add_membro
        '
        Me.btn_add_membro.AnimationHoverSpeed = 0.07!
        Me.btn_add_membro.AnimationSpeed = 0.03!
        Me.btn_add_membro.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_membro.BorderColor = System.Drawing.Color.Black
        Me.btn_add_membro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_add_membro.FocusedColor = System.Drawing.Color.Empty
        Me.btn_add_membro.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_membro.ForeColor = System.Drawing.Color.White
        Me.btn_add_membro.Image = CType(resources.GetObject("btn_add_membro.Image"), System.Drawing.Image)
        Me.btn_add_membro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_add_membro.Location = New System.Drawing.Point(592, 66)
        Me.btn_add_membro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add_membro.Name = "btn_add_membro"
        Me.btn_add_membro.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_membro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_add_membro.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_add_membro.OnHoverImage = Nothing
        Me.btn_add_membro.OnPressedColor = System.Drawing.Color.Black
        Me.btn_add_membro.Size = New System.Drawing.Size(253, 32)
        Me.btn_add_membro.TabIndex = 58
        Me.btn_add_membro.Text = "Adicionar membro"
        '
        'btn_membros
        '
        Me.btn_membros.AnimationHoverSpeed = 0.07!
        Me.btn_membros.AnimationSpeed = 0.03!
        Me.btn_membros.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_membros.BorderColor = System.Drawing.Color.Black
        Me.btn_membros.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_membros.FocusedColor = System.Drawing.Color.Empty
        Me.btn_membros.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_membros.ForeColor = System.Drawing.Color.White
        Me.btn_membros.Image = CType(resources.GetObject("btn_membros.Image"), System.Drawing.Image)
        Me.btn_membros.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_membros.Location = New System.Drawing.Point(592, 23)
        Me.btn_membros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_membros.Name = "btn_membros"
        Me.btn_membros.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_membros.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_membros.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_membros.OnHoverImage = Nothing
        Me.btn_membros.OnPressedColor = System.Drawing.Color.Black
        Me.btn_membros.Size = New System.Drawing.Size(253, 37)
        Me.btn_membros.TabIndex = 59
        Me.btn_membros.Text = "Membros do grupo"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(1067, 25)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 73)
        Me.TextBox2.TabIndex = 61
        Me.TextBox2.Text = "<Div>Din"
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.TIPO, Me.CREDOR, Me.DataGridViewTextBoxColumn4, Me.DataGridViewImageColumn1, Me.Column1})
        Me.dgv_dados.Location = New System.Drawing.Point(45, 250)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(987, 166)
        Me.dgv_dados.TabIndex = 62
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRIÇÃO"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 114
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CATEGORIA"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 114
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "VALOR TOTAL"
        Me.TIPO.MinimumWidth = 8
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 118
        '
        'CREDOR
        '
        Me.CREDOR.HeaderText = "TIPO DE DESPESA"
        Me.CREDOR.MinimumWidth = 8
        Me.CREDOR.Name = "CREDOR"
        Me.CREDOR.ReadOnly = True
        Me.CREDOR.Width = 143
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "VALOR A SER PAGO"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 117
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 63
        '
        'Column1
        '
        Me.Column1.HeaderText = "REMOVER"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 81
        '
        'btn_salgo_geral
        '
        Me.btn_salgo_geral.AnimationHoverSpeed = 0.07!
        Me.btn_salgo_geral.AnimationSpeed = 0.03!
        Me.btn_salgo_geral.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_salgo_geral.BorderColor = System.Drawing.Color.Black
        Me.btn_salgo_geral.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_salgo_geral.FocusedColor = System.Drawing.Color.Empty
        Me.btn_salgo_geral.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salgo_geral.ForeColor = System.Drawing.Color.White
        Me.btn_salgo_geral.Image = CType(resources.GetObject("btn_salgo_geral.Image"), System.Drawing.Image)
        Me.btn_salgo_geral.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_salgo_geral.Location = New System.Drawing.Point(545, 209)
        Me.btn_salgo_geral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salgo_geral.Name = "btn_salgo_geral"
        Me.btn_salgo_geral.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_salgo_geral.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salgo_geral.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salgo_geral.OnHoverImage = Nothing
        Me.btn_salgo_geral.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salgo_geral.Size = New System.Drawing.Size(241, 37)
        Me.btn_salgo_geral.TabIndex = 64
        Me.btn_salgo_geral.Text = "Saldo geral"
        '
        'grupo_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1312, 444)
        Me.Controls.Add(Me.btn_salgo_geral)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btn_membros)
        Me.Controls.Add(Me.btn_add_membro)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.txt_criado_em)
        Me.Controls.Add(Me.txt_criado_por)
        Me.Controls.Add(Me.txt_qtd_membros)
        Me.Controls.Add(Me.txt_nome_grupo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_criar_grupo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "grupo_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESPESAS DO GRUPO"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btn_criar_grupo As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nome_grupo As Label
    Friend WithEvents txt_qtd_membros As Label
    Friend WithEvents txt_criado_por As Label
    Friend WithEvents txt_criado_em As Label
    Friend WithEvents txt_descricao As Label
    Friend WithEvents btn_add_membro As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_membros As Guna.UI.WinForms.GunaButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents CREDOR As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents btn_salgo_geral As Guna.UI.WinForms.GunaButton
End Class
