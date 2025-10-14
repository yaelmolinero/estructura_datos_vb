Public Class Pila
    Dim MAX = 5, TOPE, DATO As Integer
    Dim BAND As Boolean
    Dim PILA(MAX) As String
    Dim txtBoxPila() As TextBox

    Private Sub form_load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxPila = {v1, v2, v3, v4, v5}
    End Sub

    Private Sub pila_vacia()
        If TOPE = 0 Then
            BAND = True
        Else
            BAND = False
        End If
    End Sub

    Private Sub pila_llena()
        If TOPE = MAX Then
            BAND = True
        Else
            BAND = False
        End If
    End Sub

    Private Sub pone()
        DATO = input.Text
        pila_llena()

        If BAND Then
            MessageBox.Show("Desbordamiento - Pila llena")
        Else
            PILA(TOPE) = DATO

            txtBoxPila(TOPE).Text = DATO
            input.Text = ""

            TOPE += 1
        End If
    End Sub

    Private Sub insertarBtn_Click(sender As Object, e As EventArgs) Handles insertarBtn.Click
        pone()
    End Sub

    Private Sub input_TextChanged(sender As Object, e As KeyEventArgs) Handles input.KeyUp
        If e.KeyCode = Keys.Enter Then pone()
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        pila_vacia()

        If BAND Then
            MessageBox.Show("Subdesbordamiento - Pila vacia")
        Else
            TOPE -= 1
            DATO = PILA(TOPE)

            txtBoxPila(TOPE).Text = ""
            input.Text = DATO
        End If
    End Sub
End Class