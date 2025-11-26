Public Class Nodo
    Public Property Valor As String
    Public Property Izq As Nodo
    Public Property Der As Nodo
    Public Property Lbl As RoundedLabel

    Public Sub New(valor As String)
        Me.Valor = valor
    End Sub
End Class
