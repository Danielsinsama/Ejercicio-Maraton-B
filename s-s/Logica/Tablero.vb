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

    Public Function escribirH(s As String) As Boolean

        Dim vector(s.Length) As Label
        Dim posX, posY As Integer
        posY = numeroAleatorio(0, numFilas - 1)
        posX = numeroAleatorio(0, numColumnas - s.Length)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX + i, posY, matriz(posX + i, posY)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX + i, posY, matriz(posX + i, posY))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX + i, posY) = vector(i)
            matriz(posX + i, posY).BackColor = Color.Aqua
        Next
        Return True
    End Function
    Public Function escribirHI(s As String) As Boolean
        Dim posX, posY As Integer
        Dim vector(s.Length) As Label
        posY = numeroAleatorio(0, numFilas - 1)
        posX = numeroAleatorio(s.Length - 1, (numColumnas - 1))
        For i = 0 To s.Length - 1
            If insertar(s(i), posX - i, posY, matriz(posX - i, posY)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX - i, posY, matriz(posX - i, posY))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX - i, posY) = vector(i)
            matriz(posX - i, posY).BackColor = Color.Aqua
        Next
        Return True
    End Function
    Public Function escribirV(s As String) As Boolean 'para MODIFICAR
        Dim vector(s.Length) As Label
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - 1)
        posY = numeroAleatorio(0, numFilas - s.Length)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX, posY + i, matriz(posX, posY + i)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX, posY + i, matriz(posX, posY + i))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX, posY + i) = vector(i)
            matriz(posX, posY + i).BackColor = Color.Aqua
        Next
        Return True
    End Function
    Public Function escribirVI(s As String) As Boolean
        Dim vector(s.Length) As Label
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - 1)
        posY = numeroAleatorio(s.Length, numFilas - s.Length - 1)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX, posY - i, matriz(posX, posY - i)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX, posY - i, matriz(posX, posY - i))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX, posY - i) = vector(i)
            matriz(posX, posY - i).BackColor = Color.Aqua
        Next
        Return True

    End Function
    Public Function escribirDD(s As String) As Boolean
        Dim posX, posY As Integer
        Dim vector(s.Length) As Label
        posX = numeroAleatorio(0, numColumnas - s.Length)
        posY = numeroAleatorio(0, numFilas - s.Length)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX + i, posY + i, matriz(posX + i, posY + i)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX + i, posY + i, matriz(posX + i, posY + i))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX + i, posY + i) = vector(i)
            matriz(posX + i, posY + i).BackColor = Color.Aqua
        Next
        Return True
    End Function

    Public Function escribirDDI(s As String) As Boolean
        Dim vector(s.Length) As Label
        Dim posX, posY As Integer
        posX = numeroAleatorio(s.Length - 1, numColumnas - 1)
        posY = numeroAleatorio(s.Length - 1, numFilas - 1)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX - i, posY - i, matriz(posX - i, posY - i)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX - i, posY - i, matriz(posX - i, posY - i))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX - i, posY - i) = vector(i)
            matriz(posX - i, posY - i).BackColor = Color.Aqua
        Next
        Return True

    End Function
    Public Function escribirDI(s As String) As Boolean
        Dim vector(s.Length) As Label
        Dim posX, posY As Integer
        posX = numeroAleatorio(s.Length - 1, numColumnas - 1)
        posY = numeroAleatorio(0, numFilas - s.Length)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX - i, posY + i, matriz(posX - i, posY + i)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX - i, posY + i, matriz(posX - i, posY + i))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX - i, posY + i) = vector(i)
            matriz(posX - i, posY + i).BackColor = Color.Aqua
        Next
        Return True
    End Function
    Public Function escribirDII(s As String) As Boolean
        Dim vector(s.Length) As Label
        Dim posX, posY As Integer
        posX = numeroAleatorio(0, numColumnas - s.Length)
        posY = numeroAleatorio(s.Length - 1, numFilas - 1)
        For i = 0 To s.Length - 1
            If insertar(s(i), posX + i, posY - i, matriz(posX + i, posY - i)).Equals(Nothing) Then
                Return False
            Else
                vector(i) = insertar(s(i), posX + i, posY - i, matriz(posX + i, posY - i))
            End If
        Next
        For i = 0 To s.Length - 1
            matriz(posX + i, posY - i) = vector(i)
            matriz(posX + i, posY - i).BackColor = Color.Aqua
        Next
        Return True
    End Function
    Public Sub escribir(s As String)
        Dim al As Integer
        Dim bandera As Boolean
        bandera = False
        While bandera = False
            al = numeroAleatorio(1, 8)
            If al = 1 Then
                If escribirH(s) Then
                    bandera = True
                End If
            ElseIf al = 2 Then
                If escribirHI(s) Then
                    bandera = True
                End If
            ElseIf al = 3 Then
                If escribirV(s) Then
                    bandera = True
                End If
            ElseIf al = 4 Then
                If escribirVI(s) Then
                    bandera = True
                End If
            ElseIf al = 5 Then
                If escribirDD(s) Then
                    bandera = True
                End If
            ElseIf al = 6 Then
                If escribirDDI(s) Then
                    bandera = True
                End If
            ElseIf al = 7 Then
                If escribirDI(s) Then
                    bandera = True
                End If
            Else
                If (escribirDII(s)) Then
                    bandera = True
                End If
            End If
        End While

    End Sub
    Public Function insertar(letrita As String, x As Integer, y As Integer, e As Label) As Label ' Nos da un label de la matriz con TEXTO
        If matriz(x, y).BackColor = Color.Aqua Then   'OBJETIVO DE ESTE ALGORITMO : DEVOLVER UN LABEL CON POSICION 
            e = Nothing
        Else
            e.Text = letrita.ToString()
            ' e.BackColor = Color.Aqua
        End If
        Return e
    End Function

End Class
