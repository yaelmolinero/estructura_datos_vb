Public Class ConvPrefija
    ' Variables
    Dim EI, EPRE As String
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
        {"(", 0},
        {")", 0}
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
        EPRE = ""
        EI = input.Text
        TOPE = 0

        While EI <> ""
            SIM = EI.Last
            EI = EI.Substring(0, EI.Length - 1)

            If SIM = ")" Then
                pone(SIM) ' Pone simbolo en pila
            Else
                If SIM = "(" Then
                    While PILA(TOPE - 1) <> ")"
                        quita()
                        EPRE += DATO
                    End While
                    quita() ' Saca ")" y no lo agrega a EPRE
                Else
                    If IsNumeric(SIM) Then
                        EPRE += SIM
                    Else
                        ' Es un operador (+, -, *, /, ^)
                        pila_vacia()
                        While BAND = False AndAlso operadores(SIM) < operadores(PILA(TOPE - 1))
                            quita()
                            EPRE += DATO
                            pila_vacia()
                        End While

                        pone(SIM)
                    End If
                End If
            End If
        End While

        pila_vacia()
        While BAND = False
            quita()
            EPRE += DATO
            pila_vacia()
        End While

        ' Muestra el resultado
        output.Text = StrReverse(EPRE)
    End Sub
End Class