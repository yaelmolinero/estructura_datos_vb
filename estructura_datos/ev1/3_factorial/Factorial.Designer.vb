<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factorial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnIterativo = New Button()
        btnRecursivo = New Button()
        Label1 = New Label()
        resultadoIterativo = New Label()
        resultadoRecursivo = New Label()
        SuspendLayout()
        ' 
        ' btnIterativo
        ' 
        btnIterativo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIterativo.Location = New Point(141, 188)
        btnIterativo.Name = "btnIterativo"
        btnIterativo.Size = New Size(94, 29)
        btnIterativo.TabIndex = 0
        btnIterativo.Text = "Iterativo"
        btnIterativo.UseVisualStyleBackColor = True
        ' 
        ' btnRecursivo
        ' 
        btnRecursivo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRecursivo.Location = New Point(293, 188)
        btnRecursivo.Name = "btnRecursivo"
        btnRecursivo.Size = New Size(94, 29)
        btnRecursivo.TabIndex = 1
        btnRecursivo.Text = "Recursivo"
        btnRecursivo.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(200, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 38)
        Label1.TabIndex = 4
        Label1.Text = "Factorial"
        ' 
        ' resultadoIterativo
        ' 
        resultadoIterativo.AutoSize = True
        resultadoIterativo.BackColor = Color.White
        resultadoIterativo.BorderStyle = BorderStyle.FixedSingle
        resultadoIterativo.Location = New Point(141, 130)
        resultadoIterativo.Margin = New Padding(6, 3, 6, 3)
        resultadoIterativo.Name = "resultadoIterativo"
        resultadoIterativo.Padding = New Padding(6, 3, 6, 3)
        resultadoIterativo.Size = New Size(89, 28)
        resultadoIterativo.TabIndex = 5
        resultadoIterativo.Text = "Resultado"
        ' 
        ' resultadoRecursivo
        ' 
        resultadoRecursivo.AutoSize = True
        resultadoRecursivo.BackColor = Color.White
        resultadoRecursivo.BorderStyle = BorderStyle.FixedSingle
        resultadoRecursivo.Location = New Point(293, 130)
        resultadoRecursivo.Margin = New Padding(6, 3, 6, 3)
        resultadoRecursivo.Name = "resultadoRecursivo"
        resultadoRecursivo.Padding = New Padding(6, 3, 6, 3)
        resultadoRecursivo.Size = New Size(89, 28)
        resultadoRecursivo.TabIndex = 6
        resultadoRecursivo.Text = "Resultado"
        ' 
        ' Factorial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(536, 328)
        Controls.Add(resultadoRecursivo)
        Controls.Add(resultadoIterativo)
        Controls.Add(Label1)
        Controls.Add(btnRecursivo)
        Controls.Add(btnIterativo)
        Name = "Factorial"
        Text = "Factorial"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnIterativo As Button
    Friend WithEvents btnRecursivo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resultadoIterativo As Label
    Friend WithEvents resultadoRecursivo As Label
End Class
