<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quitar_despesa_grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quitar_despesa_grupo))
        Me.txt_nomeU = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_valor_aserpago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome_despesa = New System.Windows.Forms.TextBox()
        Me.btn_registrar_despesa = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor_despesa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_nomeU
        '
        Me.txt_nomeU.AutoSize = True
        Me.txt_nomeU.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeU.ForeColor = System.Drawing.Color.Teal
        Me.txt_nomeU.Location = New System.Drawing.Point(689, 238)
        Me.txt_nomeU.Name = "txt_nomeU"
        Me.txt_nomeU.Size = New System.Drawing.Size(27, 32)
        Me.txt_nomeU.TabIndex = 112
        Me.txt_nomeU.Text = "a"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(47, 31)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 73)
        Me.TextBox1.TabIndex = 111
        Me.TextBox1.Text = "<Div>Din"
        '
        'txt_valor_aserpago
        '
        Me.txt_valor_aserpago.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_aserpago.Location = New System.Drawing.Point(448, 271)
        Me.txt_valor_aserpago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_valor_aserpago.Name = "txt_valor_aserpago"
        Me.txt_valor_aserpago.Size = New System.Drawing.Size(292, 34)
        Me.txt_valor_aserpago.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(440, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 32)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Valor a ser pago por"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(448, 175)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(292, 36)
        Me.cmb_categoria.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(441, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(41, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 32)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Descrição da despesa"
        '
        'txt_nome_despesa
        '
        Me.txt_nome_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_despesa.Location = New System.Drawing.Point(48, 175)
        Me.txt_nome_despesa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome_despesa.Name = "txt_nome_despesa"
        Me.txt_nome_despesa.Size = New System.Drawing.Size(292, 34)
        Me.txt_nome_despesa.TabIndex = 105
        '
        'btn_registrar_despesa
        '
        Me.btn_registrar_despesa.AnimationHoverSpeed = 0.07!
        Me.btn_registrar_despesa.AnimationSpeed = 0.03!
        Me.btn_registrar_despesa.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrar_despesa.BorderColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_registrar_despesa.FocusedColor = System.Drawing.Color.Empty
        Me.btn_registrar_despesa.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_despesa.ForeColor = System.Drawing.Color.White
        Me.btn_registrar_despesa.Image = CType(resources.GetObject("btn_registrar_despesa.Image"), System.Drawing.Image)
        Me.btn_registrar_despesa.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_registrar_despesa.Location = New System.Drawing.Point(560, 369)
        Me.btn_registrar_despesa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrar_despesa.Name = "btn_registrar_despesa"
        Me.btn_registrar_despesa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrar_despesa.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar_despesa.OnHoverImage = Nothing
        Me.btn_registrar_despesa.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.Size = New System.Drawing.Size(173, 38)
        Me.btn_registrar_despesa.TabIndex = 104
        Me.btn_registrar_despesa.Text = "Quitar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(41, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 32)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Valor da despesa"
        '
        'txt_valor_despesa
        '
        Me.txt_valor_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_despesa.Location = New System.Drawing.Point(48, 271)
        Me.txt_valor_despesa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_valor_despesa.Name = "txt_valor_despesa"
        Me.txt_valor_despesa.Size = New System.Drawing.Size(292, 34)
        Me.txt_valor_despesa.TabIndex = 102
        '
        'quitar_despesa_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 481)
        Me.Controls.Add(Me.txt_nomeU)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_valor_aserpago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nome_despesa)
        Me.Controls.Add(Me.btn_registrar_despesa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_valor_despesa)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "quitar_despesa_grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUITAR DESPESA - GRUPO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nomeU As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_valor_aserpago As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome_despesa As TextBox
    Friend WithEvents btn_registrar_despesa As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valor_despesa As TextBox
End Class
