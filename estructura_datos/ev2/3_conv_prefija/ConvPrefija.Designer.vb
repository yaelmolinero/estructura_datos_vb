<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvPrefija
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
        Label2 = New Label()
        output = New TextBox()
        Button1 = New Button()
        input = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(406, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 28)
        Label2.TabIndex = 10
        Label2.Text = "Prefija"
        ' 
        ' output
        ' 
        output.Location = New Point(406, 126)
        output.Name = "output"
        output.Size = New Size(150, 27)
        output.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(249, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 29)
        Button1.TabIndex = 8
        Button1.Text = "Transformar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' input
        ' 
        input.Location = New Point(60, 126)
        input.Name = "input"
        input.Size = New Size(150, 27)
        input.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 28)
        Label1.TabIndex = 6
        Label1.Text = "Infija"
        ' 
        ' ConvPrefija
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(620, 233)
        Controls.Add(Label2)
        Controls.Add(output)
        Controls.Add(Button1)
        Controls.Add(input)
        Controls.Add(Label1)
        Name = "ConvPrefija"
        Text = "ConvPrefija"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents output As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents input As TextBox
    Friend WithEvents Label1 As Label
End Class
