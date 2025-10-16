<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColaCircular
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
        v10 = New TextBox()
        v9 = New TextBox()
        v8 = New TextBox()
        v7 = New TextBox()
        v6 = New TextBox()
        v5 = New TextBox()
        v4 = New TextBox()
        v3 = New TextBox()
        v2 = New TextBox()
        eliminarBtn = New Button()
        v1 = New TextBox()
        input = New TextBox()
        insertarBtn = New Button()
        frenteLabel = New Label()
        finalLabel = New Label()
        SuspendLayout()
        ' 
        ' v10
        ' 
        v10.Location = New Point(560, 53)
        v10.Name = "v10"
        v10.Size = New Size(50, 27)
        v10.TabIndex = 25
        ' 
        ' v9
        ' 
        v9.Location = New Point(500, 53)
        v9.Name = "v9"
        v9.Size = New Size(50, 27)
        v9.TabIndex = 24
        ' 
        ' v8
        ' 
        v8.Location = New Point(440, 53)
        v8.Name = "v8"
        v8.Size = New Size(50, 27)
        v8.TabIndex = 23
        ' 
        ' v7
        ' 
        v7.Location = New Point(380, 53)
        v7.Name = "v7"
        v7.Size = New Size(50, 27)
        v7.TabIndex = 22
        ' 
        ' v6
        ' 
        v6.Location = New Point(320, 53)
        v6.Name = "v6"
        v6.Size = New Size(50, 27)
        v6.TabIndex = 21
        ' 
        ' v5
        ' 
        v5.Location = New Point(260, 53)
        v5.Name = "v5"
        v5.Size = New Size(50, 27)
        v5.TabIndex = 20
        ' 
        ' v4
        ' 
        v4.Location = New Point(200, 53)
        v4.Name = "v4"
        v4.Size = New Size(50, 27)
        v4.TabIndex = 19
        ' 
        ' v3
        ' 
        v3.Location = New Point(140, 53)
        v3.Name = "v3"
        v3.Size = New Size(50, 27)
        v3.TabIndex = 18
        ' 
        ' v2
        ' 
        v2.Location = New Point(80, 53)
        v2.Name = "v2"
        v2.Size = New Size(50, 27)
        v2.TabIndex = 17
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eliminarBtn.Location = New Point(326, 189)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(100, 29)
        eliminarBtn.TabIndex = 16
        eliminarBtn.Text = "Eliminar"
        eliminarBtn.UseVisualStyleBackColor = True
        ' 
        ' v1
        ' 
        v1.Location = New Point(20, 53)
        v1.Name = "v1"
        v1.Size = New Size(50, 27)
        v1.TabIndex = 15
        ' 
        ' input
        ' 
        input.Location = New Point(164, 142)
        input.Name = "input"
        input.Size = New Size(100, 27)
        input.TabIndex = 14
        ' 
        ' insertarBtn
        ' 
        insertarBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        insertarBtn.Location = New Point(164, 189)
        insertarBtn.Name = "insertarBtn"
        insertarBtn.Size = New Size(100, 29)
        insertarBtn.TabIndex = 13
        insertarBtn.Text = "Insertar"
        insertarBtn.UseVisualStyleBackColor = True
        ' 
        ' frenteLabel
        ' 
        frenteLabel.AutoSize = True
        frenteLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        frenteLabel.Location = New Point(20, 20)
        frenteLabel.Name = "frenteLabel"
        frenteLabel.Size = New Size(53, 20)
        frenteLabel.TabIndex = 26
        frenteLabel.Text = "Frente"
        ' 
        ' finalLabel
        ' 
        finalLabel.AutoSize = True
        finalLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        finalLabel.Location = New Point(20, 100)
        finalLabel.Name = "finalLabel"
        finalLabel.Size = New Size(42, 20)
        finalLabel.TabIndex = 27
        finalLabel.Text = "Final"
        ' 
        ' ColaCircular
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(632, 257)
        Controls.Add(finalLabel)
        Controls.Add(frenteLabel)
        Controls.Add(v10)
        Controls.Add(v9)
        Controls.Add(v8)
        Controls.Add(v7)
        Controls.Add(v6)
        Controls.Add(v5)
        Controls.Add(v4)
        Controls.Add(v3)
        Controls.Add(v2)
        Controls.Add(eliminarBtn)
        Controls.Add(v1)
        Controls.Add(input)
        Controls.Add(insertarBtn)
        Name = "ColaCircular"
        Text = "ColaCircular"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents v10 As TextBox
    Friend WithEvents v9 As TextBox
    Friend WithEvents v8 As TextBox
    Friend WithEvents v7 As TextBox
    Friend WithEvents v6 As TextBox
    Friend WithEvents v5 As TextBox
    Friend WithEvents v4 As TextBox
    Friend WithEvents v3 As TextBox
    Friend WithEvents v2 As TextBox
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents v1 As TextBox
    Friend WithEvents input As TextBox
    Friend WithEvents insertarBtn As Button
    Friend WithEvents frenteLabel As Label
    Friend WithEvents finalLabel As Label
End Class
