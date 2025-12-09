<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.link_login = New System.Windows.Forms.LinkLabel()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_csenha = New System.Windows.Forms.MaskedTextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_ver_senha1 = New System.Windows.Forms.Button()
        Me.btn_versenha2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(60, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Já tem uma conta?"
        '
        'link_login
        '
        Me.link_login.AutoSize = True
        Me.link_login.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.link_login.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.link_login.Location = New System.Drawing.Point(60, 52)
        Me.link_login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.link_login.Name = "link_login"
        Me.link_login.Size = New System.Drawing.Size(80, 32)
        Me.link_login.TabIndex = 15
        Me.link_login.TabStop = True
        Me.link_login.Text = "Entrar"
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.Transparent
        Me.btn_criar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar.Location = New System.Drawing.Point(771, 27)
        Me.btn_criar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(139, 50)
        Me.btn_criar.TabIndex = 14
        Me.btn_criar.Text = "Criar conta"
        Me.btn_criar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(740, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 50)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cadastro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(62, 207)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(60, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuário"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(66, 236)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(374, 34)
        Me.txt_senha.TabIndex = 10
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(65, 131)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(374, 34)
        Me.txt_usuario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(529, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 32)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Confirmar senha"
        '
        'txt_csenha
        '
        Me.txt_csenha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_csenha.Location = New System.Drawing.Point(536, 236)
        Me.txt_csenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_csenha.Name = "txt_csenha"
        Me.txt_csenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_csenha.Size = New System.Drawing.Size(374, 34)
        Me.txt_csenha.TabIndex = 17
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Teal
        Me.label.Location = New System.Drawing.Point(531, 102)
        Me.label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(72, 32)
        Me.label.TabIndex = 24
        Me.label.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(536, 131)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(374, 34)
        Me.txt_email.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(46, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 73)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "<Div>Din"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.btn_criar)
        Me.Panel1.Controls.Add(Me.link_login)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 348)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 117)
        Me.Panel1.TabIndex = 36
        '
        'btn_ver_senha1
        '
        Me.btn_ver_senha1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_senha1.Image = CType(resources.GetObject("btn_ver_senha1.Image"), System.Drawing.Image)
        Me.btn_ver_senha1.Location = New System.Drawing.Point(447, 234)
        Me.btn_ver_senha1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ver_senha1.Name = "btn_ver_senha1"
        Me.btn_ver_senha1.Size = New System.Drawing.Size(51, 36)
        Me.btn_ver_senha1.TabIndex = 38
        Me.btn_ver_senha1.UseVisualStyleBackColor = True
        '
        'btn_versenha2
        '
        Me.btn_versenha2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_versenha2.Image = CType(resources.GetObject("btn_versenha2.Image"), System.Drawing.Image)
        Me.btn_versenha2.Location = New System.Drawing.Point(913, 236)
        Me.btn_versenha2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_versenha2.Name = "btn_versenha2"
        Me.btn_versenha2.Size = New System.Drawing.Size(51, 36)
        Me.btn_versenha2.TabIndex = 39
        Me.btn_versenha2.UseVisualStyleBackColor = True
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(976, 459)
        Me.Controls.Add(Me.btn_versenha2)
        Me.Controls.Add(Me.btn_ver_senha1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_csenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents link_login As LinkLabel
    Friend WithEvents btn_criar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_csenha As MaskedTextBox
    Friend WithEvents label As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_ver_senha1 As Button
    Friend WithEvents btn_versenha2 As Button
End Class
