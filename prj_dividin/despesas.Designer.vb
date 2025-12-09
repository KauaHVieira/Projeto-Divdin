<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class despesas
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
        Me.btn_visualizar = New System.Windows.Forms.Button()
        Me.btn_remover_despesas = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_adicionar_despesas = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_visualizar
        '
        Me.btn_visualizar.BackColor = System.Drawing.Color.Teal
        Me.btn_visualizar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_visualizar.ForeColor = System.Drawing.Color.White
        Me.btn_visualizar.Location = New System.Drawing.Point(320, 220)
        Me.btn_visualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.Size = New System.Drawing.Size(130, 65)
        Me.btn_visualizar.TabIndex = 8
        Me.btn_visualizar.Text = "Visualizar Despesas"
        Me.btn_visualizar.UseVisualStyleBackColor = False
        '
        'btn_remover_despesas
        '
        Me.btn_remover_despesas.BackColor = System.Drawing.Color.Teal
        Me.btn_remover_despesas.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remover_despesas.ForeColor = System.Drawing.Color.White
        Me.btn_remover_despesas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_remover_despesas.Location = New System.Drawing.Point(150, 220)
        Me.btn_remover_despesas.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_remover_despesas.Name = "btn_remover_despesas"
        Me.btn_remover_despesas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_remover_despesas.Size = New System.Drawing.Size(130, 65)
        Me.btn_remover_despesas.TabIndex = 7
        Me.btn_remover_despesas.Text = "Remover Despesas"
        Me.btn_remover_despesas.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Teal
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(320, 120)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(130, 65)
        Me.btn_editar.TabIndex = 6
        Me.btn_editar.Text = "Editar Despesas"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_adicionar_despesas
        '
        Me.btn_adicionar_despesas.BackColor = System.Drawing.Color.Teal
        Me.btn_adicionar_despesas.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar_despesas.ForeColor = System.Drawing.Color.White
        Me.btn_adicionar_despesas.Location = New System.Drawing.Point(150, 120)
        Me.btn_adicionar_despesas.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_adicionar_despesas.Name = "btn_adicionar_despesas"
        Me.btn_adicionar_despesas.Size = New System.Drawing.Size(130, 65)
        Me.btn_adicionar_despesas.TabIndex = 5
        Me.btn_adicionar_despesas.Text = "Adicionar Despesas"
        Me.btn_adicionar_despesas.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(220, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 58)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "<Div>Din"
        '
        'despesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_visualizar)
        Me.Controls.Add(Me.btn_remover_despesas)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_adicionar_despesas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "despesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESPESAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_visualizar As Button
    Friend WithEvents btn_remover_despesas As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_adicionar_despesas As Button
    Friend WithEvents TextBox1 As TextBox
End Class
