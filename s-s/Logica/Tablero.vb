Public Class Tablero
	Private _numFilas As Integer
	Private _numColumnas As Integer
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
