<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class grupos_criados_usuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grupos_criados_usuario))
        Me.btn_meus_grupos = New Guna.UI.WinForms.GunaButton()
        Me.btn_criar_grupo = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.txt_nomeU = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_meus_grupos
        '
        Me.btn_meus_grupos.AnimationHoverSpeed = 0.07!
        Me.btn_meus_grupos.AnimationSpeed = 0.03!
        Me.btn_meus_grupos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_meus_grupos.BorderColor = System.Drawing.Color.Black
        Me.btn_meus_grupos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_meus_grupos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_meus_grupos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_meus_grupos.ForeColor = System.Drawing.Color.White
        Me.btn_meus_grupos.Image = CType(resources.GetObject("btn_meus_grupos.Image"), System.Drawing.Image)
        Me.btn_meus_grupos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_meus_grupos.Location = New System.Drawing.Point(847, 116)
        Me.btn_meus_grupos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_meus_grupos.Name = "btn_meus_grupos"
        Me.btn_meus_grupos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_meus_grupos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_meus_grupos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_meus_grupos.OnHoverImage = Nothing
        Me.btn_meus_grupos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_meus_grupos.Size = New System.Drawing.Size(187, 37)
        Me.btn_meus_grupos.TabIndex = 45
        Me.btn_meus_grupos.Text = "Grupos"
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
        Me.btn_criar_grupo.Location = New System.Drawing.Point(847, 158)
        Me.btn_criar_grupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_criar_grupo.Name = "btn_criar_grupo"
        Me.btn_criar_grupo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_criar_grupo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_criar_grupo.OnHoverImage = Nothing
        Me.btn_criar_grupo.OnPressedColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.Size = New System.Drawing.Size(187, 37)
        Me.btn_criar_grupo.TabIndex = 43
        Me.btn_criar_grupo.Text = "Criar grupo"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(40, 160)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(347, 37)
        Me.GunaLabel1.TabIndex = 42
        Me.GunaLabel1.Text = "Lista de grupos criados por"
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 69
        '
        'Column4
        '
        Me.Column4.HeaderText = "EDITAR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 63
        '
        'Column7
        '
        Me.Column7.HeaderText = "CRIADO EM"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 110
        '
        'Column6
        '
        Me.Column6.HeaderText = "CRIADO POR"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 119
        '
        'Column3
        '
        Me.Column3.HeaderText = "DESCRIÇÃO"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 114
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 76
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
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
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column7, Me.Column4, Me.Column5})
        Me.dgv_dados.Location = New System.Drawing.Point(47, 199)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(987, 135)
        Me.dgv_dados.TabIndex = 40
        '
        'cmb_campo
        '
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(108, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(142, 28)
        Me.ToolStripLabel2.Text = "Selecione o campo:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(89, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(246, 28)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa:"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(29, 28)
        Me.btn_gravar.Text = "ToolStripButton1"
        Me.btn_gravar.ToolTipText = "GRAVAR"
        '
        'txt_nomeU
        '
        Me.txt_nomeU.AutoSize = True
        Me.txt_nomeU.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeU.ForeColor = System.Drawing.SystemColors.Control
        Me.txt_nomeU.Location = New System.Drawing.Point(406, 165)
        Me.txt_nomeU.Name = "txt_nomeU"
        Me.txt_nomeU.Size = New System.Drawing.Size(30, 32)
        Me.txt_nomeU.TabIndex = 44
        Me.txt_nomeU.Text = "a"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripLabel1, Me.txt_buscar, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1312, 28)
        Me.ToolStrip1.TabIndex = 39
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(40, 49)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 73)
        Me.TextBox2.TabIndex = 50
        Me.TextBox2.Text = "<Div>Din"
        '
        'grupos_criados_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1312, 444)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btn_meus_grupos)
        Me.Controls.Add(Me.btn_criar_grupo)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.txt_nomeU)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "grupos_criados_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPOS CRIADOS "
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_meus_grupos As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_criar_grupo As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents cmb_campo As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents txt_nomeU As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TextBox2 As TextBox
End Class
