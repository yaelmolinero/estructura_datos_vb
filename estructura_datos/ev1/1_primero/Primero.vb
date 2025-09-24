Imports System.Numerics

Public Class Form1
    Dim X, Y, N, I As Integer
    Dim V(10) As Integer
    Dim Msg() As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Msg = {val1, val2, val3, val4, val5, val6, val7, val8, val9, val10}
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Y = InputBox("Ingresa un numero")
        V(N) = Integer.Parse(Y)
        Msg(N).Text = Y
        N += 1
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Y = Integer.Parse(InputBox("Valor a buscar"))

        For I = 0 To N
            If V(I) = Y Then
                MessageBox.Show("Se encontro " & Y & " en la lista")
                Return
            End If
        Next

        MessageBox.Show("El numero " & Y & " no existe")
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        X = InputBox("Escribe el valor que quiere modificar: ")
        Y = InputBox("Escribe el nuevo valor: ")
        I = 1

        While I <= N And Not X = V(I)
            I += 1
        End While

        If I > N Then
            MessageBox.Show("El valor " & X & " no existe en el arreglo")
        Else
            V(I) = Y
            Msg(I).Text = Y
        End If
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        X = InputBox("Escribe el valor que quieres eliminar")
        I = 1

        While I <= N And Not X = V(I)
            I += 1
        End While

        If I > N Then
            MessageBox.Show("El valor " & X & " no existe en el arreglo")
        Else
            V(I) = 0
            Msg(I).Text = ""
        End If
    End Sub
End Class
