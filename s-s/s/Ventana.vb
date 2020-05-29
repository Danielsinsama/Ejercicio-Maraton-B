Imports Basi
Imports Logica
Public Class Ventana
    'Dim mat(t.numFilas, t.numColumnas) As Label

    Private Sub Ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'predecir longitud
        container.Location = New System.Drawing.Point(20, 20)

        Dim t = New Tablero(mayorLongitud() * 3, mayorLongitud() * 3, container)

        ' Dim t = New Tablero(10, 10, container)

        container.Size = New Size(18 * t.numFilas + 40, 19 * t.numColumnas + 40)
        'predecir longitud frm
        Size = New Size(18 * t.numFilas + 160, 19 * t.numColumnas + 160)
        MaximumSize = New Size(Size.Width, Size.Height)
        MinimumSize = New Size(Size.Width, Size.Height)
        t.escribir(palabras(7))
        t.escribir(palabras(6))
        t.escribir(palabras(5))
        t.escribir(palabras(4))
        t.escribir(palabras(3))
        t.escribir(palabras(2))
        t.escribir(palabras(1))
        t.escribir(palabras(0))
    End Sub

    Private Sub container_Paint(sender As Object, e As PaintEventArgs) Handles container.Paint

    End Sub
End Class
