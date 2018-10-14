Imports StockModelo

Public Class BuscarRolAccion
    Implements Accion

    Public Sub New(nombre As String)
        Me.nombre = nombre
    End Sub

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

End Class
