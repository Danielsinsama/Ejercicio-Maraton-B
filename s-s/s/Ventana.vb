Imports Basi
Imports Logica
Public Class Ventana
    'Dim mat(t.numFilas, t.numColumnas) As Label

    Private Sub Ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'predecir longitud
        container.Location = New System.Drawing.Point(20, 20)

        Dim t = New Tablero(11, 11, container)
        container.Size = New Size(18 * t.numFilas + 40, 19 * t.numColumnas + 40)
        'predecir longitud frm
        Size = New Size(18 * t.numFilas + 160, 19 * t.numColumnas + 160)
        MaximumSize = New Size(Size.Width, Size.Height)
        MinimumSize = New Size(Size.Width, Size.Height)
        t.escribirH(palabras(0))

        t.escribirH(palabras(4))
        t.escribirH(palabras(3))

    End Sub




End Class
