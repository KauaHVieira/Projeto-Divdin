<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selecao_quitar_despesas_grupo
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TextBox2.TabIndex = 52
        Me.TextBox2.Text = "<Div>Din"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(29, 25)
        Me.btn_gravar.Text = "ToolStripButton1"
        Me.btn_gravar.ToolTipText = "GRAVAR"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(246, 25)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(89, 28)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(142, 25)
        Me.ToolStripLabel2.Text = "Selecione o campo:"
        '
        'cmb_campo
        '
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(108, 28)
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.TIPO, Me.CREDOR, Me.Column5, Me.Column7})
        Me.dgv_dados.Location = New System.Drawing.Point(47, 199)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(987, 135)
        Me.dgv_dados.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "DESCRIÇÃO"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 114
        '
        'Column3
        '
        Me.Column3.HeaderText = "CATEGORIA"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 114
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
        'Column5
        '
        Me.Column5.HeaderText = "VALOR A SER PAGO"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 117
        '
        'Column7
        '
        Me.Column7.HeaderText = "SELECIONAR"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 98
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripLabel1, Me.txt_buscar, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1312, 28)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(40, 160)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(423, 37)
        Me.GunaLabel1.TabIndex = 50
        Me.GunaLabel1.Text = "Selecione a despesa a ser quitada"
        '
        'selecao_quitar_despesas_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1312, 444)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "selecao_quitar_despesas_grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECIONAR DESPESA - QUITAR"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_campo As ToolStripComboBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents CREDOR As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
