Public Class ConvPostfija
    ' Variables
    Dim EI, EPOS As String
    Dim SIM, DATO As Char
    Dim MAX = 20, TOPE As Integer
    Dim BAND As Integer
    Dim PILA(MAX) As String

    ' Prioridad de los operadores
    Dim operadores As New Dictionary(Of Char, Integer) From {
        {"^", 3},
        {"*"c, 2},
        {"/"c, 2},
        {"+"c, 1},
        {"-"c, 1},
        {"(", 0}
    }

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

    Private Sub pone(dato As Char)
        pila_llena()

        If BAND Then
            MessageBox.Show("Debordamiento - Pila llena")
        Else
            PILA(TOPE) = dato
            TOPE += 1
        End If
    End Sub

    Private Sub quita()
        pila_vacia()

        If BAND Then
            MessageBox.Show("Subdesbordamiento - Pila vacía")
        Else
            TOPE -= 1
            DATO = PILA(TOPE)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EPOS = ""
        EI = input.Text
        ' 1
        TOPE = 0

        ' 2
        While EI <> ""
            SIM = EI.First
            EI = EI.Substring(1)

            ' 2.1
            If SIM = "(" Then
                pone(SIM)
            Else
                ' 2.1.1
                If SIM = ")" Then
                    ' 2.1.1.1
                    While PILA(TOPE - 1) <> "("
                        quita()
                        EPOS += DATO
                    End While

                    ' 2.1.1.2
                    quita()  ' Quita el parentesis "(" de la PILA
                Else
                    ' 2.1.1.3
                    If IsNumeric(SIM) = True Then
                        EPOS += SIM
                    Else
                        pila_vacia()
                        ' 2.1.1.3A
                        While BAND = False AndAlso operadores(SIM) <= operadores(PILA(TOPE - 1))
                            quita()
                            EPOS += DATO
                            pila_vacia()
                        End While

                        ' 2.1.1.3B
                        pone(SIM)
                    End If ' 2.1.1.4
                End If ' 2.1.2
            End If ' 2.2
        End While ' 3

        ' 4
        pila_vacia()
        ' 5
        While BAND = False And TOPE > 0
            quita()
            EPOS += DATO
            pila_vacia()
        End While ' 6

        ' 7
        output.Text = EPOS
    End Sub
End Class