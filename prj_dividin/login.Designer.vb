<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.link_cadastro = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_ver_senha = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(405, 151)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(273, 34)
        Me.txt_usuario.TabIndex = 0
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(404, 234)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(273, 34)
        Me.txt_senha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(400, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Email/usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(400, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(396, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 50)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Login"
        '
        'btn_entrar
        '
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.Location = New System.Drawing.Point(624, 373)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(140, 68)
        Me.btn_entrar.TabIndex = 6
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'link_cadastro
        '
        Me.link_cadastro.AutoSize = True
        Me.link_cadastro.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_cadastro.Location = New System.Drawing.Point(399, 335)
        Me.link_cadastro.Name = "link_cadastro"
        Me.link_cadastro.Size = New System.Drawing.Size(120, 28)
        Me.link_cadastro.TabIndex = 7
        Me.link_cadastro.TabStop = True
        Me.link_cadastro.Text = "cadastrar-se"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Não tem uma conta?"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(67, 37)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 73)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "<Div>Din"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 460)
        Me.Panel1.TabIndex = 36
        '
        'btn_ver_senha
        '
        Me.btn_ver_senha.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_senha.Image = CType(resources.GetObject("btn_ver_senha.Image"), System.Drawing.Image)
        Me.btn_ver_senha.Location = New System.Drawing.Point(683, 234)
        Me.btn_ver_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ver_senha.Name = "btn_ver_senha"
        Me.btn_ver_senha.Size = New System.Drawing.Size(51, 36)
        Me.btn_ver_senha.TabIndex = 37
        Me.btn_ver_senha.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 454)
        Me.Controls.Add(Me.btn_ver_senha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.link_cadastro)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_entrar As Button
    Friend WithEvents link_cadastro As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_ver_senha As Button
End Class
