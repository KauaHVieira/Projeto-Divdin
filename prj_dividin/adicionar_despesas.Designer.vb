<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adicionar_despesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adicionar_despesas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor_despesa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_devedor = New System.Windows.Forms.TextBox()
        Me.btn_registrar_despesa = New Guna.UI.WinForms.GunaButton()
        Me.btn_buscar_usuario = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome_despesa = New System.Windows.Forms.TextBox()
        Me.btn_buscar_usuario1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_credor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_data_despesa = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(331, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Valor da despesa"
        '
        'txt_valor_despesa
        '
        Me.txt_valor_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_despesa.Location = New System.Drawing.Point(336, 141)
        Me.txt_valor_despesa.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_valor_despesa.Name = "txt_valor_despesa"
        Me.txt_valor_despesa.Size = New System.Drawing.Size(206, 29)
        Me.txt_valor_despesa.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(31, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Devedor"
        '
        'txt_devedor
        '
        Me.txt_devedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_devedor.Location = New System.Drawing.Point(35, 219)
        Me.txt_devedor.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_devedor.Name = "txt_devedor"
        Me.txt_devedor.Size = New System.Drawing.Size(206, 29)
        Me.txt_devedor.TabIndex = 15
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
        Me.btn_registrar_despesa.Location = New System.Drawing.Point(520, 400)
        Me.btn_registrar_despesa.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_registrar_despesa.Name = "btn_registrar_despesa"
        Me.btn_registrar_despesa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrar_despesa.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrar_despesa.OnHoverImage = Nothing
        Me.btn_registrar_despesa.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrar_despesa.Size = New System.Drawing.Size(130, 31)
        Me.btn_registrar_despesa.TabIndex = 19
        Me.btn_registrar_despesa.Text = "Registrar"
        '
        'btn_buscar_usuario
        '
        Me.btn_buscar_usuario.Image = CType(resources.GetObject("btn_buscar_usuario.Image"), System.Drawing.Image)
        Me.btn_buscar_usuario.Location = New System.Drawing.Point(246, 221)
        Me.btn_buscar_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_buscar_usuario.Name = "btn_buscar_usuario"
        Me.btn_buscar_usuario.Size = New System.Drawing.Size(34, 29)
        Me.btn_buscar_usuario.TabIndex = 21
        Me.btn_buscar_usuario.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(31, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Descrição da despesa"
        '
        'txt_nome_despesa
        '
        Me.txt_nome_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_despesa.Location = New System.Drawing.Point(35, 141)
        Me.txt_nome_despesa.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_nome_despesa.Name = "txt_nome_despesa"
        Me.txt_nome_despesa.Size = New System.Drawing.Size(206, 29)
        Me.txt_nome_despesa.TabIndex = 23
        '
        'btn_buscar_usuario1
        '
        Me.btn_buscar_usuario1.Image = CType(resources.GetObject("btn_buscar_usuario1.Image"), System.Drawing.Image)
        Me.btn_buscar_usuario1.Location = New System.Drawing.Point(547, 221)
        Me.btn_buscar_usuario1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_buscar_usuario1.Name = "btn_buscar_usuario1"
        Me.btn_buscar_usuario1.Size = New System.Drawing.Size(34, 29)
        Me.btn_buscar_usuario1.TabIndex = 27
        Me.btn_buscar_usuario1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(330, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Credor"
        '
        'txt_credor
        '
        Me.txt_credor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_credor.Location = New System.Drawing.Point(336, 219)
        Me.txt_credor.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_credor.Name = "txt_credor"
        Me.txt_credor.Size = New System.Drawing.Size(206, 29)
        Me.txt_credor.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(331, 276)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Categoria"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(336, 305)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(206, 29)
        Me.cmb_categoria.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(32, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Data"
        '
        'cmb_data_despesa
        '
        Me.cmb_data_despesa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_despesa.Location = New System.Drawing.Point(35, 305)
        Me.cmb_data_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_data_despesa.Name = "cmb_data_despesa"
        Me.cmb_data_despesa.Size = New System.Drawing.Size(206, 29)
        Me.cmb_data_despesa.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 58)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.Text = "<Div>Din"
        '
        'adicionar_despesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmb_data_despesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscar_usuario1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_credor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nome_despesa)
        Me.Controls.Add(Me.btn_buscar_usuario)
        Me.Controls.Add(Me.btn_registrar_despesa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_devedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_valor_despesa)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "adicionar_despesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADICIONAR DESPESA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valor_despesa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_devedor As TextBox
    Friend WithEvents btn_registrar_despesa As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_buscar_usuario As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome_despesa As TextBox
    Friend WithEvents btn_buscar_usuario1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_credor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_data_despesa As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
End Class
