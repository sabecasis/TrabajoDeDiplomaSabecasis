Public Class ComandoQueryCriteria
    Implements QueryCriteria

    Private _accion As String
    Public Property Accion() As String
        Get
            Return _accion
        End Get
        Set(ByVal value As String)
            _accion = value
        End Set
    End Property

    Private _resultado As String
    Public Property Resultado() As String
        Get
            Return _resultado
        End Get
        Set(ByVal value As String)
            _resultado = value
        End Set
    End Property




End Class
