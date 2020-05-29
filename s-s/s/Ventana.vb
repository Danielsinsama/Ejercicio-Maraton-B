Imports Basi
Imports Logica
Imports System.IO
Public Class Ventana
    'Dim mat(t.numFilas, t.numColumnas) As Label

    Private Sub Ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lector As New StreamReader("F:\programas\reto-sopa\s-s\Basi\palabras.txt")
        Dim linea As String = ""

        Do
            linea = lector.ReadLine()
            If Not linea Is Nothing Then
                palabras.Add(linea)
            End If
        Loop Until linea Is Nothing
        lector.Close()

        'predecir longitud
        container.Location = New System.Drawing.Point(20, 20)

        Dim t = New Tablero(mayorLongitud() * 2, mayorLongitud() * 2, container)

        ' Dim t = New Tablero(10, 10, container)

        container.Size = New Size(18 * t.numFilas + 40, 19 * t.numColumnas + 40)
        'predecir longitud frm
        Size = New Size(18 * t.numFilas + 160, 19 * t.numColumnas + 160)
        MaximumSize = New Size(Size.Width, Size.Height)
        MinimumSize = New Size(Size.Width, Size.Height)
        For Each i As String In palabras
            t.escribir(i)
        Next
    End Sub

    Private Sub container_Paint(sender As Object, e As PaintEventArgs) Handles container.Paint

    End Sub
End Class
