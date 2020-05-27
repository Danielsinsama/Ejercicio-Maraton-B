Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label

Public Module Basi

    Public letras As String = "QWERTYUIOPASDFGHJKLÑZCVBNM"
    Public palabras As String() = {"DIEGO", "PAN", "PELO", "JUAN"}
    Public Function cadenaAleatoria() As String
        Randomize()
        Dim n As Integer = Rnd() * 25
        Return letras(n)
    End Function
    Public Function numeroAleatorio(ByVal limi As Integer) As Integer
        Randomize()
        Dim n As Integer = Rnd() * limi 'sin contar el 25 creo
        Return n
    End Function


End Module
