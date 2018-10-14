Imports StockModelo

Public Class LoginAccion
	Implements Accion


    Public Sub New(usuario As String, password As String)
        Me.usuario = usuario
        Me.password = password
    End Sub

    Private _password As String
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property


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
