Public Class Tablero
	Private _numFilas As Integer
	Private _numColumnas As Integer
	Private v1 As Integer
	Private v2 As Integer



	Public Sub New(ByVal nf As Integer, ByVal nc As Integer)
		_numColumnas = nc
		_numFilas = nf
	End Sub
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
