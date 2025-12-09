<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tipo_despesa
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
        Me.btn_pagamento_despesa = New System.Windows.Forms.Button()
        Me.btn_divisao_despesa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_despesa_pessoal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_pagamento_despesa
        '
        Me.btn_pagamento_despesa.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_pagamento_despesa.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pagamento_despesa.ForeColor = System.Drawing.Color.White
        Me.btn_pagamento_despesa.Location = New System.Drawing.Point(67, 140)
        Me.btn_pagamento_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pagamento_despesa.Name = "btn_pagamento_despesa"
        Me.btn_pagamento_despesa.Size = New System.Drawing.Size(180, 50)
        Me.btn_pagamento_despesa.TabIndex = 0
        Me.btn_pagamento_despesa.Text = "Pagamento de despesa"
        Me.btn_pagamento_despesa.UseVisualStyleBackColor = False
        '
        'btn_divisao_despesa
        '
        Me.btn_divisao_despesa.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_divisao_despesa.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divisao_despesa.ForeColor = System.Drawing.Color.White
        Me.btn_divisao_despesa.Location = New System.Drawing.Point(251, 140)
        Me.btn_divisao_despesa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_divisao_despesa.Name = "btn_divisao_despesa"
        Me.btn_divisao_despesa.Size = New System.Drawing.Size(180, 50)
        Me.btn_divisao_despesa.TabIndex = 1
        Me.btn_divisao_despesa.Text = "Divisão de despesa"
        Me.btn_divisao_despesa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecione o tipo de despesa que você deseja adicionar"
        '
        'btn_despesa_pessoal
        '
        Me.btn_despesa_pessoal.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_despesa_pessoal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_despesa_pessoal.ForeColor = System.Drawing.Color.White
        Me.btn_despesa_pessoal.Location = New System.Drawing.Point(435, 140)
        Me.btn_despesa_pessoal.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_despesa_pessoal.Name = "btn_despesa_pessoal"
        Me.btn_despesa_pessoal.Size = New System.Drawing.Size(180, 50)
        Me.btn_despesa_pessoal.TabIndex = 3
        Me.btn_despesa_pessoal.Text = "Despesa pessoal"
        Me.btn_despesa_pessoal.UseVisualStyleBackColor = False
        '
        'tipo_despesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(684, 261)
        Me.Controls.Add(Me.btn_despesa_pessoal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_divisao_despesa)
        Me.Controls.Add(Me.btn_pagamento_despesa)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "tipo_despesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECIONAR TIPO DESPESA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pagamento_despesa As Button
    Friend WithEvents btn_divisao_despesa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_despesa_pessoal As Button
End Class
