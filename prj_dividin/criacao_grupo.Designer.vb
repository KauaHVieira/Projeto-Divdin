<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class criacao_grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(criacao_grupo))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome_grupo = New System.Windows.Forms.TextBox()
        Me.btn_criar_grupo = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_limiteM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(34, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nome do grupo"
        '
        'txt_nome_grupo
        '
        Me.txt_nome_grupo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_grupo.Location = New System.Drawing.Point(39, 150)
        Me.txt_nome_grupo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nome_grupo.Name = "txt_nome_grupo"
        Me.txt_nome_grupo.Size = New System.Drawing.Size(243, 29)
        Me.txt_nome_grupo.TabIndex = 37
        '
        'btn_criar_grupo
        '
        Me.btn_criar_grupo.AnimationHoverSpeed = 0.07!
        Me.btn_criar_grupo.AnimationSpeed = 0.03!
        Me.btn_criar_grupo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_criar_grupo.BorderColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_criar_grupo.FocusedColor = System.Drawing.Color.Empty
        Me.btn_criar_grupo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar_grupo.ForeColor = System.Drawing.Color.White
        Me.btn_criar_grupo.Image = CType(resources.GetObject("btn_criar_grupo.Image"), System.Drawing.Image)
        Me.btn_criar_grupo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_criar_grupo.Location = New System.Drawing.Point(442, 309)
        Me.btn_criar_grupo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_criar_grupo.Name = "btn_criar_grupo"
        Me.btn_criar_grupo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_criar_grupo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_criar_grupo.OnHoverImage = Nothing
        Me.btn_criar_grupo.OnPressedColor = System.Drawing.Color.Black
        Me.btn_criar_grupo.Size = New System.Drawing.Size(127, 30)
        Me.btn_criar_grupo.TabIndex = 34
        Me.btn_criar_grupo.Text = "Criar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(36, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Quantidade de membros"
        '
        'txt_limiteM
        '
        Me.txt_limiteM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_limiteM.Location = New System.Drawing.Point(41, 227)
        Me.txt_limiteM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_limiteM.Name = "txt_limiteM"
        Me.txt_limiteM.Size = New System.Drawing.Size(243, 29)
        Me.txt_limiteM.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(322, 123)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Descrição do grupo"
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(327, 150)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(243, 29)
        Me.txt_descricao.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 58)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = "<Div>Din"
        '
        'criacao_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 381)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nome_grupo)
        Me.Controls.Add(Me.btn_criar_grupo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_limiteM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_descricao)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "criacao_grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRIAR GRUPO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome_grupo As TextBox
    Friend WithEvents btn_criar_grupo As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_limiteM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
