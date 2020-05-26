Imports System.Reflection.Emit

Public Class Tablero
    Private _numFilas As Integer
    Private _numColumnas As Integer
    Private _matriz(_numFilas, _numColumnas) As Label
    Public Sub New(ByVal nf As Integer, ByVal nc As Integer)
        _numColumnas = nc
        _numFilas = nf
        '_matriz(nf, nc) = New Label


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
