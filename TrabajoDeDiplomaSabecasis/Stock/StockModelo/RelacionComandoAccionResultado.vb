Public Class RelacionComandoAccionResultado


    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _bitacoraActiva As Boolean
    Public Property bitacoraActiva() As Boolean
        Get
            Return _bitacoraActiva
        End Get
        Set(ByVal value As Boolean)
            _bitacoraActiva = value
        End Set
    End Property


    Private _comando As String
    Public Property comando() As String
        Get
            Return _comando
        End Get
        Set(ByVal value As String)
            _comando = value
        End Set
    End Property

    Private _accion As String
    Public Property accion() As String
        Get
            Return _accion
        End Get
        Set(ByVal value As String)
            _accion = value
        End Set
    End Property

    Private _resultado As String
    Public Property resultado() As String
        Get
            Return _resultado
        End Get
        Set(ByVal value As String)
            _resultado = value
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
