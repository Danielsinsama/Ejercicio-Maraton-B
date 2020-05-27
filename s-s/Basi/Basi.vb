Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label

Public Module Basi

    Public letras As String = "QWERTYUIOPASDFGHJKLÑZCVBNM"
    Public palabras As String() = {New String("DIEGO"), New String("PAN"), New String("JUAN"), New String("PELO")}
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
    Private Function fijarLbl(ele As Label, x As Integer, y As Integer, container As Panel) As Label
        ele = New Label()
        ele.BackColor = Color.White
        ele.BorderStyle = BorderStyle.FixedSingle
        ele.Text = cadenaAleatoria()
        ele.Margin = New Padding(0, 0, 0, 0)
        ele.Size = New Size(18, 19) 'PUEDE ESTAR MAL, CAMBIAR SI LO ESTÁ
        ele.Location = New System.Drawing.Point(x, y)
        container.Controls.Add(ele)
        Return ele
    End Function
    Public Function obtenerMatriz(filas As Integer, columnas As Integer, container As Panel) As Label(,)
        Dim eme(filas, columnas) As Label
        Dim posX As Integer
        Dim posY As Integer
        For i = 0 To filas - 1
            'VA DEL CERO AL CINCO-> ES DECIR LONGITUD DE 6
            If i = 0 Then
                posX = 20 + container.Location.X
            End If
            For j = 0 To columnas - 1
                If j = 0 Then
                    posY = 20 + container.Location.Y
                Else
                    posY += 19
                End If
                fijarLbl(eme(i, j), posX, posY, container)
            Next
            posX += 18
        Next
        Return eme
    End Function
End Module
