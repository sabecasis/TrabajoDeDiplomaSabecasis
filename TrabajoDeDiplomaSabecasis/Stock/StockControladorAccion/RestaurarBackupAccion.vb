Imports StockModelo

Public Class RestaurarBackupAccion
	Implements Accion

    Public Sub New(ruta As String)
        Me.ruta = ruta
    End Sub

    Private _ruta As String
    Public Property ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property


End Class
