Public Class InsertarOrdenado
    Dim V(5), Y, N, I, POS As Integer
    Dim Msg() As TextBox

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Msg = {val1, val2, val3, val4, val5}
    End Sub

    Public Sub buscar_secuencial_ordenado()
        If N = 0 Then Return

        I = 0
        While I < N And V(I) < Y
            I += 1
        End While

        If I >= N Or V(I) > Y Then
            POS = -I
        Else
            POS = I
        End If
    End Sub

    Private Sub insertarBtn_Click(sender As Object, e As EventArgs) Handles insertarBtn.Click
        Y = Integer.Parse(InputBox("Ingresa un numero"))

        If N > 5 Then
            MessageBox.Show("No hay espacio en el arreglo.")
            Return
        End If

        buscar_secuencial_ordenado()

        If POS > 0 Then
            MessageBox.Show("El elemento ya existe.")
            Return
        End If

        'N += 1
        POS *= -1

        For I = N To POS + 1 Step -1
            V(I) = V(I - 1)
            Msg(I).Text = V(I - 1)
        Next

        N += 1


        V(POS) = Y
        Msg(POS).Text = Y
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        Y = Integer.Parse(InputBox("Valor a eliminar."))

        If N <= 0 Then
            MessageBox.Show("El arreglo esta vacío")
            Return
        End If

        buscar_secuencial_ordenado()

        If (POS < 0) Then
            MessageBox.Show("El elemento no existe.")
        End If

        N -= 1

        For I = POS To N
            V(I) = V(I + 1)
            Msg(I).Text = V(I + 1)
            Msg(N).Text = ""
        Next
    End Sub
End Class