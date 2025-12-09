<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adicionar_despesas_divisao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adicionar_despesas_divisao))
        Me.cmb_data_despesa = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar_usuario1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_devedor2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome_despesa = New System.Windows.Forms.TextBox()
        Me.btn_buscar_usuario = New System.Windows.Forms.Button()
        Me.btn_registrar_despesa = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_devedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor_despesa = New System.Windows.Forms.TextBox()
        Me.cmb_modo_divisao = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_valor_devedor1 = New System.Windows.Forms.TextBox()
        Me.txt_valor_devedor2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmb_data_despesa
        '
        Me.cmb_data_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_despesa.Location = New System.Drawing.Point(635, 144)
        Me.cmb_data_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_data_despesa.Name = "cmb_data_despesa"
        Me.cmb_data_despesa.Size = New System.Drawing.Size(220, 29)
        Me.cmb_data_despesa.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(630, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Data"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(335, 144)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(220, 29)
        Me.cmb_categoria.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(330, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Categoria"
        '
        'btn_buscar_usuario1
        '
        Me.btn_buscar_usuario1.Image = CType(resources.GetObject("btn_buscar_usuario1.Image"), System.Drawing.Image)
        Me.btn_buscar_usuario1.Location = New System.Drawing.Point(259, 360)
        Me.btn_buscar_usuario1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar_usuario1.Name = "btn_buscar_usuario1"
        Me.btn_buscar_usuario1.Size = New System.Drawing.Size(34, 29)
        Me.btn_buscar_usuario1.TabIndex = 45
        Me.btn_buscar_usuario1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(30, 335)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "2º devedor"
        '
        'txt_devedor2
        '
        Me.txt_devedor2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_devedor2.Location = New System.Drawing.Point(35, 362)
        Me.txt_devedor2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_devedor2.Name = "txt_devedor2"
        Me.txt_devedor2.Size = New System.Drawing.Size(220, 29)
        Me.txt_devedor2.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(30, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Descrição da despesa"
        '
        'txt_nome_despesa
        '
        Me.txt_nome_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_despesa.Location = New System.Drawing.Point(35, 144)
        Me.txt_nome_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_despesa.Name = "txt_nome_despesa"
        Me.txt_nome_despesa.Size = New System.Drawing.Size(220, 29)
        Me.txt_nome_despesa.TabIndex = 41
        '
        'btn_buscar_usuario
        '
        Me.btn_buscar_usuario.Image = CType(resources.GetObject("btn_buscar_usuario.Image"), System.Drawing.Image)
        Me.btn_buscar_usuario.Location = New System.Drawing.Point(259, 279)
        Me.btn_buscar_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar_usuario.Name = "btn_buscar_usuario"
        Me.btn_buscar_usuario.Size = New System.Drawing.Size(34, 29)
        Me.btn_buscar_usuario.TabIndex = 40
        Me.btn_buscar_usuario.UseVisualStyleBackColor = True
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
        Me.btn_registrar_despesa.Location = New System.Drawing.Point(725, 360)
        Me.btn_registrar_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_registrar_despesa.Name = "btn_registrar_despesa"
        Me.btn_registrar_despesa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrar_despesa.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar_despesa.OnHoverImage = Nothing
        Me.btn_registrar_despesa.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.Size = New System.Drawing.Size(130, 31)
        Me.btn_registrar_despesa.TabIndex = 39
        Me.btn_registrar_despesa.Text = "Registrar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(30, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "1º devedor"
        '
        'txt_devedor
        '
        Me.txt_devedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_devedor.Location = New System.Drawing.Point(35, 279)
        Me.txt_devedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_devedor.Name = "txt_devedor"
        Me.txt_devedor.Size = New System.Drawing.Size(220, 29)
        Me.txt_devedor.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(30, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Valor da despesa"
        '
        'txt_valor_despesa
        '
        Me.txt_valor_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_despesa.Location = New System.Drawing.Point(35, 213)
        Me.txt_valor_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_despesa.Name = "txt_valor_despesa"
        Me.txt_valor_despesa.Size = New System.Drawing.Size(220, 29)
        Me.txt_valor_despesa.TabIndex = 35
        '
        'cmb_modo_divisao
        '
        Me.cmb_modo_divisao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_modo_divisao.FormattingEnabled = True
        Me.cmb_modo_divisao.Location = New System.Drawing.Point(335, 213)
        Me.cmb_modo_divisao.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_modo_divisao.Name = "cmb_modo_divisao"
        Me.cmb_modo_divisao.Size = New System.Drawing.Size(220, 29)
        Me.cmb_modo_divisao.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(330, 186)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 25)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Modo de divisão"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(330, 255)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 25)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Valor a ser pago pelo 1º devedor"
        '
        'txt_valor_devedor1
        '
        Me.txt_valor_devedor1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_devedor1.Location = New System.Drawing.Point(335, 285)
        Me.txt_valor_devedor1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_devedor1.Name = "txt_valor_devedor1"
        Me.txt_valor_devedor1.Size = New System.Drawing.Size(220, 29)
        Me.txt_valor_devedor1.TabIndex = 53
        '
        'txt_valor_devedor2
        '
        Me.txt_valor_devedor2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_devedor2.Location = New System.Drawing.Point(335, 362)
        Me.txt_valor_devedor2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_devedor2.Name = "txt_valor_devedor2"
        Me.txt_valor_devedor2.Size = New System.Drawing.Size(220, 29)
        Me.txt_valor_devedor2.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(330, 332)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(290, 25)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Valor a ser pago pelo 2º devedor"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 58)
        Me.TextBox1.TabIndex = 56
        Me.TextBox1.Text = "<Div>Din"
        '
        'adicionar_despesas_divisao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 461)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_valor_devedor2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_valor_devedor1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_modo_divisao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_data_despesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscar_usuario1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_devedor2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nome_despesa)
        Me.Controls.Add(Me.btn_buscar_usuario)
        Me.Controls.Add(Me.btn_registrar_despesa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_devedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_valor_despesa)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "adicionar_despesas_divisao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADICIONAR DESPESAS - DIVISÃO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_data_despesa As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar_usuario1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_devedor2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome_despesa As TextBox
    Friend WithEvents btn_buscar_usuario As Button
    Friend WithEvents btn_registrar_despesa As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_devedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valor_despesa As TextBox
    Friend WithEvents cmb_modo_divisao As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_valor_devedor1 As TextBox
    Friend WithEvents txt_valor_devedor2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
