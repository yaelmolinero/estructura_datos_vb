<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        addBtn = New Button()
        search = New Button()
        update = New Button()
        remove = New Button()
        val2 = New TextBox()
        val3 = New TextBox()
        val4 = New TextBox()
        val5 = New TextBox()
        val10 = New TextBox()
        val1 = New TextBox()
        val9 = New TextBox()
        val8 = New TextBox()
        val7 = New TextBox()
        val6 = New TextBox()
        SuspendLayout()
        ' 
        ' addBtn
        ' 
        addBtn.Location = New Point(162, 225)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(94, 29)
        addBtn.TabIndex = 0
        addBtn.Text = "Agregar"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' search
        ' 
        search.Location = New Point(294, 225)
        search.Name = "search"
        search.Size = New Size(94, 29)
        search.TabIndex = 1
        search.Text = "Buscar"
        search.UseVisualStyleBackColor = True
        ' 
        ' update
        ' 
        update.Location = New Point(425, 225)
        update.Name = "update"
        update.Size = New Size(94, 29)
        update.TabIndex = 2
        update.Text = "Modifica"
        update.UseVisualStyleBackColor = True
        ' 
        ' remove
        ' 
        remove.Location = New Point(552, 225)
        remove.Name = "remove"
        remove.Size = New Size(94, 29)
        remove.TabIndex = 3
        remove.Text = "Eliminar"
        remove.UseVisualStyleBackColor = True
        ' 
        ' val2
        ' 
        val2.Location = New Point(123, 112)
        val2.Name = "val2"
        val2.Size = New Size(55, 27)
        val2.TabIndex = 4
        ' 
        ' val3
        ' 
        val3.Location = New Point(219, 112)
        val3.Name = "val3"
        val3.Size = New Size(55, 27)
        val3.TabIndex = 5
        ' 
        ' val4
        ' 
        val4.Location = New Point(310, 112)
        val4.Name = "val4"
        val4.Size = New Size(55, 27)
        val4.TabIndex = 6
        ' 
        ' val5
        ' 
        val5.Location = New Point(382, 112)
        val5.Name = "val5"
        val5.Size = New Size(55, 27)
        val5.TabIndex = 7
        ' 
        ' val10
        ' 
        val10.Location = New Point(760, 112)
        val10.Name = "val10"
        val10.Size = New Size(55, 27)
        val10.TabIndex = 8
        ' 
        ' val1
        ' 
        val1.Location = New Point(49, 112)
        val1.Name = "val1"
        val1.Size = New Size(55, 27)
        val1.TabIndex = 9
        ' 
        ' val9
        ' 
        val9.Location = New Point(693, 112)
        val9.Name = "val9"
        val9.Size = New Size(55, 27)
        val9.TabIndex = 10
        ' 
        ' val8
        ' 
        val8.Location = New Point(617, 112)
        val8.Name = "val8"
        val8.Size = New Size(55, 27)
        val8.TabIndex = 11
        ' 
        ' val7
        ' 
        val7.Location = New Point(543, 112)
        val7.Name = "val7"
        val7.Size = New Size(55, 27)
        val7.TabIndex = 12
        ' 
        ' val6
        ' 
        val6.Location = New Point(460, 112)
        val6.Name = "val6"
        val6.Size = New Size(55, 27)
        val6.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(857, 463)
        Controls.Add(val6)
        Controls.Add(val7)
        Controls.Add(val8)
        Controls.Add(val9)
        Controls.Add(val1)
        Controls.Add(val10)
        Controls.Add(val5)
        Controls.Add(val4)
        Controls.Add(val3)
        Controls.Add(val2)
        Controls.Add(remove)
        Controls.Add(update)
        Controls.Add(search)
        Controls.Add(addBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents search As Button
    Friend WithEvents update As Button
    Friend WithEvents remove As Button
    Friend WithEvents val2 As TextBox
    Friend WithEvents val3 As TextBox
    Friend WithEvents val4 As TextBox
    Friend WithEvents val5 As TextBox
    Friend WithEvents val10 As TextBox
    Friend WithEvents val1 As TextBox
    Friend WithEvents val9 As TextBox
    Friend WithEvents val8 As TextBox
    Friend WithEvents val7 As TextBox
    Friend WithEvents val6 As TextBox

End Class
