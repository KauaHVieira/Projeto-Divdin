<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adicionar_despesas_pessoal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adicionar_despesas_pessoal))
        Me.cmb_data_despesa = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome_despesa = New System.Windows.Forms.TextBox()
        Me.btn_registrar_despesa = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor_despesa = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmb_data_despesa
        '
        Me.cmb_data_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_despesa.Location = New System.Drawing.Point(327, 227)
        Me.cmb_data_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_data_despesa.Name = "cmb_data_despesa"
        Me.cmb_data_despesa.Size = New System.Drawing.Size(243, 29)
        Me.cmb_data_despesa.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(324, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Data"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(327, 150)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(243, 29)
        Me.cmb_categoria.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(322, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(34, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 25)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Descrição da despesa"
        '
        'txt_nome_despesa
        '
        Me.txt_nome_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_despesa.Location = New System.Drawing.Point(39, 150)
        Me.txt_nome_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_despesa.Name = "txt_nome_despesa"
        Me.txt_nome_despesa.Size = New System.Drawing.Size(243, 29)
        Me.txt_nome_despesa.TabIndex = 63
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
        Me.btn_registrar_despesa.Location = New System.Drawing.Point(462, 325)
        Me.btn_registrar_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_registrar_despesa.Name = "btn_registrar_despesa"
        Me.btn_registrar_despesa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrar_despesa.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar_despesa.OnHoverImage = Nothing
        Me.btn_registrar_despesa.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.Size = New System.Drawing.Size(127, 30)
        Me.btn_registrar_despesa.TabIndex = 61
        Me.btn_registrar_despesa.Text = "Registrar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(36, 200)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Valor da despesa"
        '
        'txt_valor_despesa
        '
        Me.txt_valor_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_despesa.Location = New System.Drawing.Point(35, 227)
        Me.txt_valor_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_despesa.Name = "txt_valor_despesa"
        Me.txt_valor_despesa.Size = New System.Drawing.Size(243, 29)
        Me.txt_valor_despesa.TabIndex = 57
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 58)
        Me.TextBox1.TabIndex = 72
        Me.TextBox1.Text = "<Div>Din"
        '
        'adicionar_despesas_pessoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 381)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmb_data_despesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nome_despesa)
        Me.Controls.Add(Me.btn_registrar_despesa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_valor_despesa)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "adicionar_despesas_pessoal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADICIONAR DESPESAS - PESSOAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_data_despesa As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome_despesa As TextBox
    Friend WithEvents btn_registrar_despesa As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valor_despesa As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
