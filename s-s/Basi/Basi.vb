Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label

Public Module Basi

    Public letras As String = "QWERTYUIOPASDFGHJKLÑZCVBNM"
    Public palabras As String() = {"DIEGO", "PAN", "PELO", "JUAN", "MOCHE"}
    Public Function cadenaAleatoria() As String
        Randomize()
        Dim n As Integer = Rnd() * 25
        Return letras(n)
    End Function
    Public Function numeroAleatorio(limi As Integer) As Integer
        Randomize()
        Dim n As Integer = Rnd() * limi 'de cero a limi
        Return n
    End Function
    Public Function mayorLongitud()
        Dim mayor As Integer
        For i = 0 To palabras.Length - 1
            If i = 0 Then
                mayor = palabras(i).Length - 1
            Else
                If (palabras(i).Length > mayor) Then
                    mayor = palabras(i).Length
                End If

            End If
        Next
        Return mayor
    End Function

End Module
