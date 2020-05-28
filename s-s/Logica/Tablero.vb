Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label
Imports Basi
Public Class Tablero
    Private _numFilas As Integer
    Private _numColumnas As Integer
    Private _matriz(,) As Label

    Public Sub New(ByVal nf As Integer, ByVal nc As Integer, ByVal cont As Panel)
        _numColumnas = nc
        _numFilas = nf
        _matriz = obtenerMatriz(nf, nc, cont)
    End Sub
    Public Property matriz() As Label(,)
        Get
            Return _matriz
        End Get
        Set(ByVal m As Label(,)) 'en verdad no lo necesito XD
            _matriz = m
        End Set
    End Property

    Public Property numFilas() As Integer
        Get
            Return _numFilas
        End Get
        Set(ByVal v As Integer)
            _numFilas = v
        End Set
    End Property
    Public Property numColumnas() As Integer
        Get
            Return _numColumnas
        End Get
        Set(ByVal v As Integer)
            _numColumnas = v
        End Set
    End Property
    Private Function obtenerLbl(ele As Label, x As Integer, y As Integer, container As Panel, cadena As String) As Label
        ele = New Label()
        ele.BackColor = Color.White
        ele.BorderStyle = BorderStyle.FixedSingle
        ele.Text = cadena
        ele.Margin = New Padding(0, 0, 0, 0)
        ele.Size = New Size(18, 19) 'PUEDE ESTAR MAL, CAMBIAR SI LO ESTÁ
        ele.Location = New System.Drawing.Point(x, y)

        Return ele
    End Function

    Public Function obtenerMatriz(filas As Integer, columnas As Integer, container As Panel) As Label(,)
        Dim eme(filas, columnas) As Label
        Dim posX As Integer
        Dim posY As Integer
        For i = 0 To filas
            'VA DEL CERO AL CINCO-> ES DECIR LONGITUD DE 6
            If i = 0 Then
                posX = 20 + container.Location.X
            End If
            For j = 0 To columnas
                If j = 0 Then
                    posY = 20 + container.Location.Y
                Else
                    posY += 19
                End If
                eme(i, j) = obtenerLbl(eme(i, j), posX, posY, container, cadenaAleatoria)
                container.Controls.Add(eme(i, j))
            Next
            posX += 18
        Next

        Return eme
    End Function
    Public Sub escribirH(s As String)
        Dim posX, posY As Integer
        posY = numeroAleatorio(0, numFilas - 1)
        posX = numeroAleatorio(0, numColumnas - s.Length)
        For i = 0 To s.Length - 1
            insertar(s(i), posX + i, posY - i)
        Next
    End Sub
    Public Sub escribirHI(s As String)
        Dim posX, posY As Integer
        posY = numeroAleatorio(0, numFilas - 1)
        posX = numeroAleatorio(s.Length - 1, (numColumnas - 1))
        For i = 0 To s.Length - 1
            insertar(s(i), posX - i, posY)
        Next
    End Sub
    Public Sub escribirV(s As String) 'para MODIFICAR
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - 1)
        posY = numeroAleatorio(0, numFilas - s.Length)
        For i = 0 To s.Length - 1
            insertar(s(i), posX, posY + i)
        Next
    End Sub
    Public Sub escribirVI(s As String)
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - 1)
        posY = numeroAleatorio(s.Length, numFilas - s.Length - 1)
        For i = 0 To s.Length - 1
            insertar(s(i), posX, posY - i)
        Next
    End Sub
    Public Sub escribirDD(s As String)
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - s.Length)
        posY = numeroAleatorio(0, numFilas - s.Length)
        For i = 0 To s.Length - 1
            insertar(s(i), posX + i, posY + i)
        Next
    End Sub

    Public Sub escribirDDI(s As String)
        Dim posX, posY As Integer
        posX = numeroAleatorio(s.Length - 1, numColumnas - 1)
        posY = numeroAleatorio(s.Length - 1, numFilas - 1)
        For i = 0 To s.Length - 1
            insertar(s(i), posX - i, posY - i)
        Next
    End Sub
    Public Sub escribirDI(s As String)
        Dim posX, posY As Integer
        posX = numeroAleatorio(s.Length - 1, numColumnas - 1)
        posY = numeroAleatorio(0, numFilas - s.Length)
        For i = 0 To s.Length - 1
            insertar(s(i), posX - i, posY + i)
        Next
    End Sub
    Public Sub escribirDII(s As String)
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - s.Length)
        posY = numeroAleatorio(s.Length - 1, numFilas - 1)
        For i = 0 To s.Length - 1
            insertar(s(i), posX + i, posY - i)
        Next
    End Sub
    Public Sub insertar(letrita As String, x As Integer, y As Integer) ' AL LLAMARLO, SE ESPECIFICARÁ :letrita es el s(i)
        matriz(x, y).Text = letrita.ToString()
        matriz(x, y).BackColor = Color.Aqua
    End Sub
End Class
