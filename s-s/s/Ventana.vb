Public Class Ventana
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim posX As Integer
        Dim posY As Integer

        Dim mat(5, 5) As Label
        For i = 0 To 5  'VA DEL CERO AL CINCO-> ES DECIR LONGITUD DE 6
            If i = 0 Then
                posX = 20 + container.Location.X
            End If

            For j = 0 To 5
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

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub container_Paint(sender As Object, e As PaintEventArgs) Handles container.Paint

    End Sub
End Class
