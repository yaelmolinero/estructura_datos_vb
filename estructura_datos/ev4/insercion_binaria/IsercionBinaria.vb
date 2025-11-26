Public Class IsercionBinaria
    Dim N = 10, I, AUX, IZQ, DER, M, J, POS As Integer
    Dim A(N) As Integer
    Dim lbl() As Label

    Private Sub IsercionBinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl = {v1, v2, v3, v4, v5, v6, v7, v8, v9, v10}
        input.Focus()
    End Sub

    Private Sub run_Click(sender As Object, e As EventArgs) Handles run.Click
        For I = 1 To POS - 1
            AUX = A(I)
            IZQ = 0
            DER = I - 1

            While IZQ <= DER
                M = Math.Floor((IZQ + DER) / 2)
                If AUX <= A(M) Then
                    DER = M - 1
                Else
                    IZQ = M + 1
                End If
            End While

            J = I - 1
            While J >= IZQ
                A(J + 1) = A(J)
                lbl(J + 1).Text = A(J)
                J = J - 1
            End While
            A(IZQ) = AUX
            lbl(IZQ).Text = AUX
        Next
    End Sub

    Private Sub add_value(val As String)
        If val = "" Then Return

        If POS = N Then
            MsgBox("Arreglo lleno")
            Return
        End If

        Try
            Dim numberParsed = Integer.Parse(val)
            A(POS) = numberParsed
            lbl(POS).Text = val
            POS += 1

        Catch ex As Exception
            MsgBox("Solo se aceptan numeros")
        End Try
    End Sub

    Private Sub input_KeyUp(sender As Object, e As KeyEventArgs) Handles input.KeyUp
        If e.KeyValue <> Keys.Enter Then Return

        Dim val = input.Text
        add_value(val)
        input.Text = ""
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim val = input.Text
        add_value(val)
        input.Text = ""
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        For I = 0 To POS - 1
            A(I) = 0
            lbl(I).Text = ""
        Next
        input.Text = ""
        POS = 0
    End Sub
End Class