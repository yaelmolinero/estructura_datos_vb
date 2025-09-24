<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fibbonacci
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
        iterativoBtn = New Button()
        recurivoBtn = New Button()
        resultadoIterativo = New Label()
        Label = New Label()
        resultadoRecurivo = New Label()
        SuspendLayout()
        ' 
        ' iterativoBtn
        ' 
        iterativoBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        iterativoBtn.Location = New Point(142, 200)
        iterativoBtn.Name = "iterativoBtn"
        iterativoBtn.Size = New Size(94, 29)
        iterativoBtn.TabIndex = 0
        iterativoBtn.Text = "Iterativo"
        iterativoBtn.UseVisualStyleBackColor = True
        ' 
        ' recurivoBtn
        ' 
        recurivoBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        recurivoBtn.Location = New Point(321, 200)
        recurivoBtn.Name = "recurivoBtn"
        recurivoBtn.Size = New Size(94, 29)
        recurivoBtn.TabIndex = 1
        recurivoBtn.Text = "Recursivo"
        recurivoBtn.UseVisualStyleBackColor = True
        ' 
        ' resultadoIterativo
        ' 
        resultadoIterativo.AutoSize = True
        resultadoIterativo.BorderStyle = BorderStyle.FixedSingle
        resultadoIterativo.Location = New Point(142, 130)
        resultadoIterativo.Name = "resultadoIterativo"
        resultadoIterativo.Padding = New Padding(3, 6, 3, 6)
        resultadoIterativo.Size = New Size(83, 34)
        resultadoIterativo.TabIndex = 2
        resultadoIterativo.Text = "Resultado"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label.Location = New Point(193, 63)
        Label.Name = "Label"
        Label.Size = New Size(157, 38)
        Label.TabIndex = 3
        Label.Text = "Fibbonacci"
        ' 
        ' resultadoRecurivo
        ' 
        resultadoRecurivo.AutoSize = True
        resultadoRecurivo.BorderStyle = BorderStyle.FixedSingle
        resultadoRecurivo.Location = New Point(321, 130)
        resultadoRecurivo.Name = "resultadoRecurivo"
        resultadoRecurivo.Padding = New Padding(3, 6, 3, 6)
        resultadoRecurivo.Size = New Size(83, 34)
        resultadoRecurivo.TabIndex = 4
        resultadoRecurivo.Text = "Resultado"
        ' 
        ' Fibbonacci
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 330)
        Controls.Add(resultadoRecurivo)
        Controls.Add(Label)
        Controls.Add(resultadoIterativo)
        Controls.Add(recurivoBtn)
        Controls.Add(iterativoBtn)
        Name = "Fibbonacci"
        Text = "Fibbonacci"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents iterativoBtn As Button
    Friend WithEvents recurivoBtn As Button
    Friend WithEvents resultadoIterativo As Label
    Friend WithEvents Label As Label
    Friend WithEvents resultadoRecurivo As Label
End Class
