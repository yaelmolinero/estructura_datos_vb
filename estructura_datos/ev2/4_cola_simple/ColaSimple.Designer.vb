<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColaSimple
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
        insertarBtn = New Button()
        input = New TextBox()
        v1 = New TextBox()
        eliminarBtn = New Button()
        v2 = New TextBox()
        v3 = New TextBox()
        v4 = New TextBox()
        v5 = New TextBox()
        v6 = New TextBox()
        v7 = New TextBox()
        v8 = New TextBox()
        v9 = New TextBox()
        v10 = New TextBox()
        SuspendLayout()
        ' 
        ' insertarBtn
        ' 
        insertarBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        insertarBtn.Location = New Point(164, 137)
        insertarBtn.Name = "insertarBtn"
        insertarBtn.Size = New Size(100, 29)
        insertarBtn.TabIndex = 0
        insertarBtn.Text = "Insertar"
        insertarBtn.UseVisualStyleBackColor = True
        ' 
        ' input
        ' 
        input.Location = New Point(164, 90)
        input.Name = "input"
        input.Size = New Size(100, 27)
        input.TabIndex = 1
        ' 
        ' v1
        ' 
        v1.Location = New Point(41, 36)
        v1.Name = "v1"
        v1.Size = New Size(50, 27)
        v1.TabIndex = 2
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eliminarBtn.Location = New Point(326, 137)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(100, 29)
        eliminarBtn.TabIndex = 3
        eliminarBtn.Text = "Eliminar"
        eliminarBtn.UseVisualStyleBackColor = True
        ' 
        ' v2
        ' 
        v2.Location = New Point(102, 36)
        v2.Name = "v2"
        v2.Size = New Size(50, 27)
        v2.TabIndex = 4
        ' 
        ' v3
        ' 
        v3.Location = New Point(158, 36)
        v3.Name = "v3"
        v3.Size = New Size(50, 27)
        v3.TabIndex = 5
        ' 
        ' v4
        ' 
        v4.Location = New Point(214, 36)
        v4.Name = "v4"
        v4.Size = New Size(50, 27)
        v4.TabIndex = 6
        ' 
        ' v5
        ' 
        v5.Location = New Point(270, 36)
        v5.Name = "v5"
        v5.Size = New Size(50, 27)
        v5.TabIndex = 7
        ' 
        ' v6
        ' 
        v6.Location = New Point(326, 36)
        v6.Name = "v6"
        v6.Size = New Size(50, 27)
        v6.TabIndex = 8
        ' 
        ' v7
        ' 
        v7.Location = New Point(382, 36)
        v7.Name = "v7"
        v7.Size = New Size(50, 27)
        v7.TabIndex = 9
        ' 
        ' v8
        ' 
        v8.Location = New Point(438, 36)
        v8.Name = "v8"
        v8.Size = New Size(50, 27)
        v8.TabIndex = 10
        ' 
        ' v9
        ' 
        v9.Location = New Point(494, 36)
        v9.Name = "v9"
        v9.Size = New Size(50, 27)
        v9.TabIndex = 11
        ' 
        ' v10
        ' 
        v10.Location = New Point(550, 36)
        v10.Name = "v10"
        v10.Size = New Size(50, 27)
        v10.TabIndex = 12
        ' 
        ' ColaSimple
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 265)
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
        Name = "ColaSimple"
        Text = "ColaSimple"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents insertarBtn As Button
    Friend WithEvents input As TextBox
    Friend WithEvents v1 As TextBox
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents v2 As TextBox
    Friend WithEvents v3 As TextBox
    Friend WithEvents v4 As TextBox
    Friend WithEvents v5 As TextBox
    Friend WithEvents v6 As TextBox
    Friend WithEvents v7 As TextBox
    Friend WithEvents v8 As TextBox
    Friend WithEvents v9 As TextBox
    Friend WithEvents v10 As TextBox
End Class
