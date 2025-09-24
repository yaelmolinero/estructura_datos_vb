Public Class Factorial
    Public Function GetNumber()
        Try
            Return Integer.Parse(InputBox("Ingresa un numero"))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub btnIterativo_Click(sender As Object, e As EventArgs) Handles btnIterativo.Click
        Dim num = GetNumber()
        Dim result As Long = 1

        For fact = num To 2 Step -1
            result *= fact
        Next

        resultadoIterativo.Text = "Factorial de " & num & " = " & result
    End Sub

    Public Function factorial_recursivo(n As Integer)
        If n < 3 Then Return 2

        Return n * factorial_recursivo(n - 1)
    End Function

    Private Sub btnRecursivo_Click(sender As Object, e As EventArgs) Handles btnRecursivo.Click
        Dim num = GetNumber()
        Dim result As Long = factorial_recursivo(num)

        resultadoRecursivo.Text = "Factorial de " & num & " = " & result
    End Sub
End Class