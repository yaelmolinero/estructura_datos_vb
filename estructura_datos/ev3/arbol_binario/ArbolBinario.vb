Public Class ArbolBinario
    Dim root As Nodo
    Dim lblTree() As RoundedLabel
    Dim MAX = 31, Id As Integer

    Private Sub ArbolBinario_Load(sender As Object, ev As EventArgs) Handles MyBase.Load
        lblTree = {A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z, A2, B2, C2, D2, E2}
        input.Focus()

        For Each lbl In Me.Controls.OfType(Of RoundedLabel)
            lbl.Text = ""
            lbl.Visible = False
        Next
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim val = input.Text
        If val = "" Then Return

        AddNode(val)
        Id += 1
        input.Text = ""
    End Sub

    Private Sub input_KeyUp(sender As Object, e As KeyEventArgs) Handles input.KeyUp
        If e.KeyValue <> Keys.Enter Or input.Text = "" Then Return

        AddNode(input.Text)
        Id += 1
        input.Text = ""
    End Sub

    Private Sub AddNode(value As String)
        If Id >= MAX Then
            MsgBox("Arbol lleno")
            Return
        End If

        Dim nodo = New Nodo(value)

        If root Is Nothing Then
            root = nodo
            root.Lbl = A
            A.Text = value
            A.Visible = True
            Return
        End If

        Dim cola As New Queue(Of Nodo)
        cola.Enqueue(root)

        While cola.Count > 0
            Dim current = cola.Dequeue()

            If current.Izq Is Nothing Then
                current.Izq = nodo
                current.Izq.Lbl = lblTree(Id)
                Exit While
            Else
                cola.Enqueue(current.Izq)
            End If

            If current.Der Is Nothing Then
                current.Der = nodo
                current.Der.Lbl = lblTree(Id)
                Exit While
            Else
                cola.Enqueue(current.Der)
            End If
        End While

        PanelCanvas.Invalidate()
    End Sub

    Private Sub draw_tree(nodo As Nodo, g As Graphics)
        If nodo Is Nothing Then Return

        Dim lbl = nodo.Lbl
        lbl.Visible = True
        lbl.Text = nodo.Valor
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim lblPosX = lbl.Location.X + 25
        Dim lblPosY = lbl.Location.Y + 25

        If nodo.Izq IsNot Nothing Then
            Dim children = nodo.Izq.Lbl
            Dim childrenPosX = children.Location.X + 25
            Dim childrenPosY = children.Location.Y + 25

            g.DrawLine(Pens.Black, lblPosX, lblPosY, childrenPosX, childrenPosY)
            draw_tree(nodo.Izq, g)
        End If

        If nodo.Der IsNot Nothing Then
            Dim children = nodo.Der.Lbl
            Dim childrenPosX = children.Location.X + 25
            Dim childrenPosY = children.Location.Y + 25

            g.DrawLine(Pens.Black, lblPosX, lblPosY, childrenPosX, childrenPosY)
            draw_tree(nodo.Der, g)
        End If
    End Sub

    Private Sub PanelCanvas_Paint(sender As Object, e As PaintEventArgs) Handles PanelCanvas.Paint
        draw_tree(root, e.Graphics)
    End Sub

    Private Sub in_orden(nodo As Nodo, ByRef data As String)
        If nodo.Izq IsNot Nothing Then in_orden(nodo.Izq, data)
        data &= nodo.Valor + ", "
        If nodo.Der IsNot Nothing Then in_orden(nodo.Der, data)
    End Sub

    Private Sub pre_orden(nodo As Nodo, ByRef data As String)
        data &= nodo.Valor + ", "
        If nodo.Izq IsNot Nothing Then pre_orden(nodo.Izq, data)
        If nodo.Der IsNot Nothing Then pre_orden(nodo.Der, data)
    End Sub

    Private Sub post_orden(nodo As Nodo, ByRef data As String)
        If nodo.Izq IsNot Nothing Then post_orden(nodo.Izq, data)
        If nodo.Der IsNot Nothing Then post_orden(nodo.Der, data)
        data &= nodo.Valor + ", "
    End Sub

    Private Sub AnalizaBtn_Click(sender As Object, e As EventArgs) Handles AnalizaBtn.Click
        If root Is Nothing Then Return

        Dim padres = "", hijos = "", hermanos = "", hojas = ""
        Dim altura, anchura, peso As Integer
        Dim inorden = "", preorden = "", postorden = ""

        ' Primer recorrido para analizar el arbol binario
        Dim cola As New Queue(Of Nodo)
        cola.Enqueue(root)

        While cola.Count > 0
            Dim nodosNivelActual = cola.Count
            altura += 1
            If nodosNivelActual > anchura Then anchura = nodosNivelActual

            For it = 1 To nodosNivelActual
                Dim current = cola.Dequeue()
                peso += 1

                If current.Izq IsNot Nothing AndAlso current.Der IsNot Nothing Then
                    padres += current.Valor + "->(" + current.Izq.Valor + ", " + current.Der.Valor + "), "
                    hijos += "(" + current.Izq.Valor + ", " + current.Der.Valor + ")->" + current.Valor + ", "
                    hermanos += "(" + current.Izq.Valor + ", " + current.Der.Valor + "), "

                    cola.Enqueue(current.Izq)
                    cola.Enqueue(current.Der)
                ElseIf current.Izq IsNot Nothing Then
                    padres += current.Valor + "->(" + current.Izq.Valor + "), "
                    hijos += "(" + current.Izq.Valor + ")->" + current.Valor + ", "

                    cola.Enqueue(current.Izq)
                ElseIf current.Der IsNot Nothing Then
                    padres += current.Valor + "->(" + current.Der.Valor + "), "
                    hijos += "(" + current.Der.Valor + ")->" + current.Valor + ", "

                    cola.Enqueue(current.Der)
                Else
                    hojas += current.Valor + ", "
                End If
            Next
        End While

        in_orden(root, inorden)
        post_orden(root, postorden)
        pre_orden(root, preorden)

        RaizTxt.Text = root.Valor
        AlturaTxt.Text = altura
        AnchuraTxt.Text = anchura
        PesoTxt.Text = peso
        PadresTxt.Text = padres
        HijosTxt.Text = hijos
        HermanosTxt.Text = hermanos
        HojasTxt.Text = hojas
        InordenTxt.Text = inorden
        PostordenTxt.Text = postorden
        PreordenTxt.Text = preorden
    End Sub

    Private Sub limpiarBtn_Click(sender As Object, e As EventArgs) Handles limpiarBtn.Click
        For Each lbl In Me.Controls.OfType(Of RoundedLabel)
            lbl.Text = ""
            lbl.Visible = False
        Next

        For Each txtA In Me.Controls.OfType(Of TextBox)
            txtA.Text = ""
        Next

        PanelCanvas.Invalidate()
        Id = 0
        root = Nothing
    End Sub
End Class