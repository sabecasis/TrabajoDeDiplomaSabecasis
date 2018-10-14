Public Class ElementoDeBitacoraQueryCriteria
    Implements QueryCriteria


    Private _booleanCriteria As Boolean
    Public Property booleanCriteria() As Boolean
        Get
            Return _booleanCriteria
        End Get
        Set(ByVal value As Boolean)
            _booleanCriteria = value
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


End Class
