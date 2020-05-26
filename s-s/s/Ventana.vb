Public Class Ventana
    Private Sub Ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim posX As Integer
        Dim posY As Integer

        Dim mat(5, 5) As Label
        'predecir longitud
        container.Location = New System.Drawing.Point(20, 20)
        container.Size = New Size(18 * 5 + 40, 19 * 5 + 40)
        'predecir longitud frm
        Size = New Size(18 * 5 + 160, 19 * 5 + 160)


        For i = 0 To 4  'VA DEL CERO AL CINCO-> ES DECIR LONGITUD DE 6
            If i = 0 Then
                posX = 20 + container.Location.X
            End If

            For j = 0 To 4
                If j = 0 Then
                    posY = 20 + container.Location.Y
                Else
                    posY += 19
                End If
                fijarLbl(mat(i, j), posX, posY)
            Next
            posX += 18
        Next
    End Sub
    Private Sub fijarLbl(ele As Label, x As Integer, y As Integer)
        ele = New Label()
        ele.BackColor = Color.White
        ele.BorderStyle = BorderStyle.FixedSingle
        ele.Margin = New Padding(0, 0, 0, 0)
        ele.Text = "A"
        ele.Size = New Size(18, 19) 'PUEDE ESTAR MAL, CAMBIAR SI LO ESTÁ
        ele.Location = New System.Drawing.Point(x, y)
        container.Controls.Add(ele)
    End Sub

End Class
