<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        insertarOrdenadoBtn = New Button()
        primeroBtn = New Button()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Cursor = Cursors.Hand
        TabControl1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.ItemSize = New Size(95, 30)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(359, 457)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(insertarOrdenadoBtn)
        TabPage1.Controls.Add(primeroBtn)
        TabPage1.ForeColor = Color.Black
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(351, 419)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ev1"
        ' 
        ' insertarOrdenadoBtn
        ' 
        insertarOrdenadoBtn.FlatAppearance.BorderColor = Color.White
        insertarOrdenadoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        insertarOrdenadoBtn.ForeColor = Color.Black
        insertarOrdenadoBtn.Location = New Point(0, 55)
        insertarOrdenadoBtn.Name = "insertarOrdenadoBtn"
        insertarOrdenadoBtn.RightToLeft = RightToLeft.No
        insertarOrdenadoBtn.Size = New Size(351, 46)
        insertarOrdenadoBtn.TabIndex = 1
        insertarOrdenadoBtn.Text = "Insertar Ordenado"
        insertarOrdenadoBtn.TextAlign = ContentAlignment.MiddleLeft
        insertarOrdenadoBtn.UseVisualStyleBackColor = True
        ' 
        ' primeroBtn
        ' 
        primeroBtn.FlatAppearance.BorderColor = Color.White
        primeroBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        primeroBtn.ForeColor = Color.Black
        primeroBtn.Location = New Point(0, 3)
        primeroBtn.Name = "primeroBtn"
        primeroBtn.RightToLeft = RightToLeft.No
        primeroBtn.Size = New Size(351, 46)
        primeroBtn.TabIndex = 0
        primeroBtn.Text = "Primero"
        primeroBtn.TextAlign = ContentAlignment.MiddleLeft
        primeroBtn.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.ForeColor = Color.Black
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(351, 419)
        TabPage2.TabIndex = 1
        TabPage2.Text = "ev2"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Transparent
        TabPage3.ForeColor = Color.Black
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(351, 419)
        TabPage3.TabIndex = 2
        TabPage3.Text = "ev3"
        ' 
        ' Index
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(381, 481)
        Controls.Add(TabControl1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        Name = "Index"
        Text = "Index"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents primeroBtn As Button
    Friend WithEvents insertarOrdenadoBtn As Button
End Class
