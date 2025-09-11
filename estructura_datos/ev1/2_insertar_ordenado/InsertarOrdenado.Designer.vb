<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarOrdenado
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
        val1 = New TextBox()
        val5 = New TextBox()
        val4 = New TextBox()
        val3 = New TextBox()
        val2 = New TextBox()
        insertarBtn = New Button()
        eliminarBtn = New Button()
        SuspendLayout()
        ' 
        ' val1
        ' 
        val1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        val1.Enabled = False
        val1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        val1.Location = New Point(39, 61)
        val1.Name = "val1"
        val1.Size = New Size(51, 30)
        val1.TabIndex = 0
        ' 
        ' val5
        ' 
        val5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        val5.Enabled = False
        val5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        val5.Location = New Point(267, 61)
        val5.Name = "val5"
        val5.Size = New Size(51, 30)
        val5.TabIndex = 1
        ' 
        ' val4
        ' 
        val4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        val4.Enabled = False
        val4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        val4.Location = New Point(210, 61)
        val4.Name = "val4"
        val4.Size = New Size(51, 30)
        val4.TabIndex = 2
        ' 
        ' val3
        ' 
        val3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        val3.Enabled = False
        val3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        val3.Location = New Point(153, 61)
        val3.Name = "val3"
        val3.Size = New Size(51, 30)
        val3.TabIndex = 3
        ' 
        ' val2
        ' 
        val2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        val2.Enabled = False
        val2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        val2.Location = New Point(96, 61)
        val2.Name = "val2"
        val2.Size = New Size(51, 30)
        val2.TabIndex = 4
        ' 
        ' insertarBtn
        ' 
        insertarBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        insertarBtn.Location = New Point(53, 131)
        insertarBtn.Name = "insertarBtn"
        insertarBtn.Size = New Size(94, 29)
        insertarBtn.TabIndex = 5
        insertarBtn.Text = "Insertar"
        insertarBtn.UseVisualStyleBackColor = True
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eliminarBtn.Location = New Point(210, 131)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(94, 29)
        eliminarBtn.TabIndex = 6
        eliminarBtn.Text = "Eliminar"
        eliminarBtn.UseVisualStyleBackColor = True
        ' 
        ' InsertarOrdenado
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 232)
        Controls.Add(eliminarBtn)
        Controls.Add(insertarBtn)
        Controls.Add(val2)
        Controls.Add(val3)
        Controls.Add(val4)
        Controls.Add(val5)
        Controls.Add(val1)
        Name = "InsertarOrdenado"
        Text = "InsertarOrdenado"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents val1 As TextBox
    Friend WithEvents val5 As TextBox
    Friend WithEvents val4 As TextBox
    Friend WithEvents val3 As TextBox
    Friend WithEvents val2 As TextBox
    Friend WithEvents insertarBtn As Button
    Friend WithEvents eliminarBtn As Button
End Class
