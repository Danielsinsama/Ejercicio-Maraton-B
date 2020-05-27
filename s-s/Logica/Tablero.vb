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
End Class
