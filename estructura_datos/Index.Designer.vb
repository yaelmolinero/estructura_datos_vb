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
        fibbonacciBtn = New Button()
        factorialBtn = New Button()
        insertarOrdenadoBtn = New Button()
        primeroBtn = New Button()
        TabPage2 = New TabPage()
        ColaCircular = New Button()
        ColaSimple = New Button()
        ConvPrefija = New Button()
        pilaBtn = New Button()
        conv_postfija_btn = New Button()
        TabPage3 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage1)
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
        TabPage1.Controls.Add(fibbonacciBtn)
        TabPage1.Controls.Add(factorialBtn)
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
        ' fibbonacciBtn
        ' 
        fibbonacciBtn.FlatAppearance.BorderColor = Color.White
        fibbonacciBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        fibbonacciBtn.ForeColor = Color.Black
        fibbonacciBtn.Location = New Point(0, 159)
        fibbonacciBtn.Name = "fibbonacciBtn"
        fibbonacciBtn.RightToLeft = RightToLeft.No
        fibbonacciBtn.Size = New Size(351, 46)
        fibbonacciBtn.TabIndex = 3
        fibbonacciBtn.Text = "Fibbonacci"
        fibbonacciBtn.TextAlign = ContentAlignment.MiddleLeft
        fibbonacciBtn.UseVisualStyleBackColor = True
        ' 
        ' factorialBtn
        ' 
        factorialBtn.FlatAppearance.BorderColor = Color.White
        factorialBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        factorialBtn.ForeColor = Color.Black
        factorialBtn.Location = New Point(0, 107)
        factorialBtn.Name = "factorialBtn"
        factorialBtn.RightToLeft = RightToLeft.No
        factorialBtn.Size = New Size(351, 46)
        factorialBtn.TabIndex = 2
        factorialBtn.Text = "Factorial"
        factorialBtn.TextAlign = ContentAlignment.MiddleLeft
        factorialBtn.UseVisualStyleBackColor = True
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
        TabPage2.Controls.Add(ColaCircular)
        TabPage2.Controls.Add(ColaSimple)
        TabPage2.Controls.Add(ConvPrefija)
        TabPage2.Controls.Add(pilaBtn)
        TabPage2.Controls.Add(conv_postfija_btn)
        TabPage2.ForeColor = Color.Black
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(351, 419)
        TabPage2.TabIndex = 1
        TabPage2.Text = "ev2"
        ' 
        ' ColaCircular
        ' 
        ColaCircular.FlatAppearance.BorderColor = Color.White
        ColaCircular.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ColaCircular.ForeColor = Color.Black
        ColaCircular.Location = New Point(0, 211)
        ColaCircular.Name = "ColaCircular"
        ColaCircular.RightToLeft = RightToLeft.No
        ColaCircular.Size = New Size(351, 46)
        ColaCircular.TabIndex = 5
        ColaCircular.Text = "Cola Circular"
        ColaCircular.TextAlign = ContentAlignment.MiddleLeft
        ColaCircular.UseVisualStyleBackColor = True
        ' 
        ' ColaSimple
        ' 
        ColaSimple.FlatAppearance.BorderColor = Color.White
        ColaSimple.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ColaSimple.ForeColor = Color.Black
        ColaSimple.Location = New Point(0, 159)
        ColaSimple.Name = "ColaSimple"
        ColaSimple.RightToLeft = RightToLeft.No
        ColaSimple.Size = New Size(351, 46)
        ColaSimple.TabIndex = 4
        ColaSimple.Text = "Cola Simple"
        ColaSimple.TextAlign = ContentAlignment.MiddleLeft
        ColaSimple.UseVisualStyleBackColor = True
        ' 
        ' ConvPrefija
        ' 
        ConvPrefija.FlatAppearance.BorderColor = Color.White
        ConvPrefija.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConvPrefija.ForeColor = Color.Black
        ConvPrefija.Location = New Point(0, 107)
        ConvPrefija.Name = "ConvPrefija"
        ConvPrefija.RightToLeft = RightToLeft.No
        ConvPrefija.Size = New Size(351, 46)
        ConvPrefija.TabIndex = 3
        ConvPrefija.Text = "Conv Pre Fija"
        ConvPrefija.TextAlign = ContentAlignment.MiddleLeft
        ConvPrefija.UseVisualStyleBackColor = True
        ' 
        ' pilaBtn
        ' 
        pilaBtn.FlatAppearance.BorderColor = Color.White
        pilaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        pilaBtn.ForeColor = Color.Black
        pilaBtn.Location = New Point(0, 3)
        pilaBtn.Name = "pilaBtn"
        pilaBtn.RightToLeft = RightToLeft.No
        pilaBtn.Size = New Size(351, 46)
        pilaBtn.TabIndex = 2
        pilaBtn.Text = "Pila"
        pilaBtn.TextAlign = ContentAlignment.MiddleLeft
        pilaBtn.UseVisualStyleBackColor = True
        ' 
        ' conv_postfija_btn
        ' 
        conv_postfija_btn.FlatAppearance.BorderColor = Color.White
        conv_postfija_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        conv_postfija_btn.ForeColor = Color.Black
        conv_postfija_btn.Location = New Point(0, 55)
        conv_postfija_btn.Name = "conv_postfija_btn"
        conv_postfija_btn.RightToLeft = RightToLeft.No
        conv_postfija_btn.Size = New Size(351, 46)
        conv_postfija_btn.TabIndex = 1
        conv_postfija_btn.Text = "Conv Post Fija"
        conv_postfija_btn.TextAlign = ContentAlignment.MiddleLeft
        conv_postfija_btn.UseVisualStyleBackColor = True
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
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents primeroBtn As Button
    Friend WithEvents insertarOrdenadoBtn As Button
    Friend WithEvents fibbonacciBtn As Button
    Friend WithEvents factorialBtn As Button
    Friend WithEvents conv_postfija_btn As Button
    Friend WithEvents pilaBtn As Button
    Friend WithEvents ConvPrefija As Button
    Friend WithEvents ColaSimple As Button
    Friend WithEvents ColaCircular As Button
End Class
