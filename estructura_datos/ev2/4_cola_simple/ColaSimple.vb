Public Class ColaSimple
    Dim MAX = 10, FRENTE, FINAL As Integer
    Dim DATO, COLA(MAX) As String
    Dim BAND As Boolean
    Dim msg() As TextBox
    Private Sub ColaSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msg = {v1, v2, v3, v4, v5, v6, v7, v8, v9, v10}
    End Sub

    Private Sub inserta_cola(dato As String)
        If FINAL < MAX Then
            COLA(FINAL) = dato
            msg(FINAL).Text = dato

            FINAL += 1
        Else
            MsgBox("Desbordamiento - Cola llena")
        End If
    End Sub

    Private Sub elimina_cola()
        If FINAL <> 0 Then
            DATO = COLA(FRENTE)
            msg(FRENTE).Text = ""

            If FRENTE = FINAL - 1 Then
                FRENTE = 0
                FINAL = 0
            Else
                FRENTE += 1
            End If

            input.Text = DATO
        Else
            MsgBox("Subdesbordamiento - Cola vacía")
        End If
    End Sub

    Private Sub insertarBtn_Click(sender As Object, e As EventArgs) Handles insertarBtn.Click
        DATO = input.Text
        input.Text = ""

        inserta_cola(DATO)
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        elimina_cola()
    End Sub

    ' ❌ Funcion no necesaria para el funcionamiento, se puede eliminar
    Private Sub input_KeyUp(sender As Object, e As KeyEventArgs) Handles input.KeyUp
        If e.KeyCode = Keys.Enter Then
            DATO = input.Text
            input.Text = ""

            inserta_cola(DATO)
        End If
    End Sub
End Class