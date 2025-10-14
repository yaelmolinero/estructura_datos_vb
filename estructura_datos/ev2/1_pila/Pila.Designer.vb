<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pila
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
        v5 = New TextBox()
        v3 = New TextBox()
        v4 = New TextBox()
        v2 = New TextBox()
        v1 = New TextBox()
        eliminarBtn = New Button()
        SuspendLayout()
        ' 
        ' insertarBtn
        ' 
        insertarBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        insertarBtn.Location = New Point(64, 168)
        insertarBtn.Name = "insertarBtn"
        insertarBtn.Size = New Size(125, 29)
        insertarBtn.TabIndex = 0
        insertarBtn.Text = "Insertar"
        insertarBtn.UseVisualStyleBackColor = True
        ' 
        ' input
        ' 
        input.Location = New Point(64, 119)
        input.Name = "input"
        input.Size = New Size(125, 27)
        input.TabIndex = 1
        ' 
        ' v5
        ' 
        v5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        v5.Location = New Point(307, 43)
        v5.Name = "v5"
        v5.ReadOnly = True
        v5.Size = New Size(75, 27)
        v5.TabIndex = 2
        v5.TextAlign = HorizontalAlignment.Center
        ' 
        ' v3
        ' 
        v3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        v3.Location = New Point(307, 138)
        v3.Name = "v3"
        v3.ReadOnly = True
        v3.Size = New Size(75, 27)
        v3.TabIndex = 3
        v3.TextAlign = HorizontalAlignment.Center
        ' 
        ' v4
        ' 
        v4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        v4.Location = New Point(307, 92)
        v4.Name = "v4"
        v4.ReadOnly = True
        v4.Size = New Size(75, 27)
        v4.TabIndex = 4
        v4.TextAlign = HorizontalAlignment.Center
        ' 
        ' v2
        ' 
        v2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        v2.Location = New Point(307, 188)
        v2.Name = "v2"
        v2.ReadOnly = True
        v2.Size = New Size(75, 27)
        v2.TabIndex = 5
        v2.TextAlign = HorizontalAlignment.Center
        ' 
        ' v1
        ' 
        v1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        v1.Location = New Point(307, 240)
        v1.Name = "v1"
        v1.ReadOnly = True
        v1.Size = New Size(75, 27)
        v1.TabIndex = 6
        v1.TextAlign = HorizontalAlignment.Center
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eliminarBtn.Location = New Point(64, 238)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(125, 29)
        eliminarBtn.TabIndex = 7
        eliminarBtn.Text = "Eliminar"
        eliminarBtn.UseVisualStyleBackColor = True
        ' 
        ' Pila
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(465, 331)
        Controls.Add(eliminarBtn)
        Controls.Add(v1)
        Controls.Add(v2)
        Controls.Add(v4)
        Controls.Add(v3)
        Controls.Add(v5)
        Controls.Add(input)
        Controls.Add(insertarBtn)
        Name = "Pila"
        Text = "Pila"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents insertarBtn As Button
    Friend WithEvents input As TextBox
    Friend WithEvents v5 As TextBox
    Friend WithEvents v3 As TextBox
    Friend WithEvents v4 As TextBox
    Friend WithEvents v2 As TextBox
    Friend WithEvents v1 As TextBox
    Friend WithEvents eliminarBtn As Button
End Class
