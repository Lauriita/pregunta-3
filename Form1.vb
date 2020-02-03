Public Class Form1

    Dim a(5, 5) As Integer
    Dim random As New Random
    Dim i, j As Integer
    Dim cadena As String
    Dim suma As Integer
    Dim total As Integer
    Dim mayor As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        For i = 0 To 4
            For j = 0 To 4
                a(i, j) = random.Next(0, 9)
                cadena = cadena & a(i, j)
                suma = suma + a(i, j)
            Next
            cadena = cadena & " " & suma & vbNewLine
            If mayor < total Then

                mayor = total

            ElseIf mayor > total Then

                mayor = mayor
            End If
            total = suma
            suma = 0
        Next

        cadena = cadena & vbNewLine & "El mayor es = " & mayor


        TextBox1.Text = cadena

    End Sub
End Class
