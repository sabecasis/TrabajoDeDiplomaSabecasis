Public Class ElementoDeBitacora

    Private _hora As String
    Public Property hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
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

    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _evento As String
    Public Property evento() As String
        Get
            Return _evento
        End Get
        Set(ByVal value As String)
            _evento = value
        End Set
    End Property


End Class
