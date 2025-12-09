<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saldo_geral_grupo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nome_grupo = New System.Windows.Forms.Label()
        Me.btn_quitar_despesas = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_total_despesas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_valor_despesas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txt_nome_grupo)
        Me.Panel1.Controls.Add(Me.btn_quitar_despesas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_total_despesas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_valor_despesas)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-10, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 351)
        Me.Panel1.TabIndex = 45
        '
        'txt_nome_grupo
        '
        Me.txt_nome_grupo.AutoSize = True
        Me.txt_nome_grupo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_grupo.Location = New System.Drawing.Point(329, 30)
        Me.txt_nome_grupo.Name = "txt_nome_grupo"
        Me.txt_nome_grupo.Size = New System.Drawing.Size(32, 40)
        Me.txt_nome_grupo.TabIndex = 8
        Me.txt_nome_grupo.Text = "a"
        '
        'btn_quitar_despesas
        '
        Me.btn_quitar_despesas.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_quitar_despesas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitar_despesas.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_despesas.ForeColor = System.Drawing.Color.White
        Me.btn_quitar_despesas.Location = New System.Drawing.Point(519, 261)
        Me.btn_quitar_despesas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_quitar_despesas.Name = "btn_quitar_despesas"
        Me.btn_quitar_despesas.Size = New System.Drawing.Size(164, 40)
        Me.btn_quitar_despesas.TabIndex = 7
        Me.btn_quitar_despesas.Text = "Quitar Despesas"
        Me.btn_quitar_despesas.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(30, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(331, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantas despesas você participa:"
        '
        'txt_total_despesas
        '
        Me.txt_total_despesas.AutoSize = True
        Me.txt_total_despesas.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_despesas.Location = New System.Drawing.Point(367, 150)
        Me.txt_total_despesas.Name = "txt_total_despesas"
        Me.txt_total_despesas.Size = New System.Drawing.Size(24, 30)
        Me.txt_total_despesas.TabIndex = 5
        Me.txt_total_despesas.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(30, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 30)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Valor devido em despesas:"
        '
        'txt_valor_despesas
        '
        Me.txt_valor_despesas.AutoSize = True
        Me.txt_valor_despesas.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_despesas.Location = New System.Drawing.Point(302, 100)
        Me.txt_valor_despesas.Name = "txt_valor_despesas"
        Me.txt_valor_despesas.Size = New System.Drawing.Size(24, 30)
        Me.txt_valor_despesas.TabIndex = 1
        Me.txt_valor_despesas.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Saldo geral do grupo"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(524, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 58)
        Me.TextBox1.TabIndex = 112
        Me.TextBox1.Text = "<Div>Din"
        '
        'saldo_geral_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "saldo_geral_grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALDO GERAL - GRUPO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_nome_grupo As Label
    Friend WithEvents btn_quitar_despesas As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_total_despesas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_valor_despesas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
