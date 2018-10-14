Imports StockModelo

Public Class BuscarUsuarioAccion
    Implements Accion
    Public Sub New(usuario As String)
        Me.usuario = usuario
    End Sub
    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

End Class
