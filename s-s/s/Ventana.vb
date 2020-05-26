Imports Logica

Public Class Ventana
    Dim letras As String = "QWERTYUIOPASDFGHJKLÑZCVBNM"

    Dim t As Tablero
    Private Sub Ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        t = New Tablero(14, 14)
        Dim posX As Integer
        Dim posY As Integer

        Dim mat(t.numFilas, t.numColumnas) As Label

        'predecir longitud
        container.Location = New System.Drawing.Point(20, 20)
        container.Size = New Size(18 * t.numFilas + 40, 19 * t.numColumnas + 40)
        'predecir longitud frm
        Size = New Size(18 * t.numFilas + 160, 19 * t.numColumnas + 160)

        For i = 0 To t.numFilas - 1
            'VA DEL CERO AL CINCO-> ES DECIR LONGITUD DE 6
            If i = 0 Then
                posX = 20 + container.Location.X
            End If
            For j = 0 To t.numColumnas - 1
                If j = 0 Then
                    posY = 20 + container.Location.Y
                Else
                    posY += 19
                End If
                fijarLbl(mat(i, j), posX, posY)
                'fijarTextoLbl(mat(i, j))
            Next
            posX += 18
        Next
        MaximumSize = New Size(Size.Width, Size.Height)

        MinimumSize = New Size(Size.Width, Size.Height)
    End Sub

    Private Sub fijarLbl(ele As Label, x As Integer, y As Integer)
        ele = New Label()
        Dim n As Integer = Rnd() * 25
        ele.BackColor = Color.White
        ele.BorderStyle = BorderStyle.FixedSingle
        ele.Text = letras(n)
        ele.Margin = New Padding(0, 0, 0, 0)
        ele.Size = New Size(18, 19) 'PUEDE ESTAR MAL, CAMBIAR SI LO ESTÁ
        ele.Location = New System.Drawing.Point(x, y)
        container.Controls.Add(ele)
    End Sub

End Class
