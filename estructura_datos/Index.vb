Public Class Index
    Private Sub primeroBtn_Click(sender As Object, e As EventArgs) Handles primeroBtn.Click
        Dim f As New Form1()
        f.Show()
    End Sub

    Private Sub insertarOrdenadoBtn_Click(sender As Object, e As EventArgs) Handles insertarOrdenadoBtn.Click
        Dim f As New InsertarOrdenado()
        f.Show()
    End Sub

    Private Sub factorialBtn_Click(sender As Object, e As EventArgs) Handles factorialBtn.Click
        Dim f As New Factorial()
        f.Show()
    End Sub

    Private Sub fibbonacciBtn_Click(sender As Object, e As EventArgs) Handles fibbonacciBtn.Click
        Dim f As New Fibbonacci()
        f.Show()
    End Sub

    Private Sub conv_postfija_btn_Click(sender As Object, e As EventArgs) Handles conv_postfija_btn.Click
        Dim f As New ConvPostfija()
        f.Show()
    End Sub

    Private Sub pilaBtn_Click(sender As Object, e As EventArgs) Handles pilaBtn.Click
        Dim f As New Pila()
        f.Show()
    End Sub

    Private Sub ConvPrefija_Click(sender As Object, e As EventArgs) Handles ConvPrefija.Click
        Dim f As New ConvPrefija()
        f.Show()
    End Sub
End Class