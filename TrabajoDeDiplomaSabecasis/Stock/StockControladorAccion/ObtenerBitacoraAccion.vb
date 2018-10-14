Imports StockModelo

Public Class ObtenerBitacoraAccion
	Implements Accion

    Public Sub New()
        Me.evento = 0
        Me.fecha = New Date(1, 1, 1)
        Me.usuario = "Nada"
    End Sub

    Public Sub New(evento As Integer, usuario As String, fecha As Date)
        Me.evento = evento
        Me.usuario = usuario
        Me.fecha = fecha
    End Sub

    Private _evento As Integer
    Public Property evento() As Integer
        Get
            Return _evento
        End Get
        Set(ByVal value As Integer)
            _evento = value
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


    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property


End Class
