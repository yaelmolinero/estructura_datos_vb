' Las lineas marcadas con "❌" no son necesarias para el funcionamiento, es algo extra
' que inclui para ver en donde esta el frente y final en la cola

Public Class ColaCircular
    Dim MAX = 10, FRENTE, FINAL As Integer
    Dim DATO, COLA(MAX) As String
    Dim msg() As TextBox
    Dim EMPTY = True

    Private Sub ColaSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msg = {v1, v2, v3, v4, v5, v6, v7, v8, v9, v10}
    End Sub

    Private Sub insertar_circular(dato As String)
        If (FINAL = MAX - 1 AndAlso FRENTE = 0) Or FINAL + 1 = FRENTE Then
            MsgBox("Desbordamiento - Cola llena")
        Else
            If FINAL = MAX - 1 Or EMPTY Then
                FINAL = 0
            Else
                FINAL += 1
            End If

            COLA(FINAL) = dato
            msg(FINAL).Text = dato
            EMPTY = False

            finalLabel.Location = New Point(msg(FINAL).Location.X, finalLabel.Location.Y) ' ❌
        End If
    End Sub

    Private Sub eliminar_circular()
        If FRENTE = 0 AndAlso FINAL = 0 Then
            MsgBox("Subdesbordamiento - Cola vacía")
        Else
            DATO = COLA(FRENTE)
            msg(FRENTE).Text = ""
            input.Text = DATO

            ' Si solo hay un elemento que eliminar
            If FRENTE = FINAL Then
                FRENTE = 0
                FINAL = 0
                EMPTY = True

                finalLabel.Location = New Point(msg(0).Location.X, finalLabel.Location.Y) ' ❌
            Else
                If FRENTE = MAX - 1 Then
                    FRENTE = 0
                Else
                    FRENTE += 1
                End If
            End If
        End If
        frenteLabel.Location = New Point(msg(FRENTE).Location.X, frenteLabel.Location.Y) ' ❌
    End Sub

    Private Sub insertarBtn_Click(sender As Object, e As EventArgs) Handles insertarBtn.Click
        DATO = input.Text
        input.Text = ""

        insertar_circular(DATO)
    End Sub

    ' ❌ Funcion no necesaria para el funcionamiento, se puede eliminar
    Private Sub input_KeyUp(sender As Object, e As KeyEventArgs) Handles input.KeyUp
        If e.KeyCode = Keys.Enter Then
            DATO = input.Text
            input.Text = ""

            insertar_circular(DATO)
        End If
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        eliminar_circular()
    End Sub
End Class