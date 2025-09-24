Public Class Fibbonacci
    Private Function GetNumber()
        Try
            Return Integer.Parse(InputBox("Ingrese un numero"))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub iterativoBtn_Click(sender As Object, e As EventArgs) Handles iterativoBtn.Click
        Dim num = GetNumber()

        If num <= 0 Then
            resultadoIterativo.Text = "0"
            Return
        End If

        If num = 1 Then
            resultadoIterativo.Text = "1"
            Return
        End If

        Dim a = 0, b = 1
        Dim resultado As Long

        For i = 2 To num
            resultado = a + b
            a = b
            b = resultado
        Next

        resultadoIterativo.Text = "Fibonacci de " & num & " = " & resultado
    End Sub

    Private Function fibonacci_recursivo(n As Integer)
        If n = 0 Then Return 0
        If n = 1 Then Return 1

        Return fibonacci_recursivo(n - 1) + fibonacci_recursivo(n - 2)
    End Function

    Private Sub recurivoBtn_Click(sender As Object, e As EventArgs) Handles recurivoBtn.Click
        Dim num = GetNumber()
        Dim result As Long = fibonacci_recursivo(num)
        resultadoRecurivo.Text = "Fibonacci de " & num & " = " & result
    End Sub
End Class