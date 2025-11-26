Imports System.Drawing.Drawing2D

Public Class RoundedLabel
    Inherits Label

    Public Property BorderRadius As Integer = 20
    Public Property BorderColor As Color = Color.Black
    Public Property BorderSize As Integer = 2

    Private Function GetRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedPath(rect, BorderRadius)

        Using pen As New Pen(BorderColor, BorderSize)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub
End Class
