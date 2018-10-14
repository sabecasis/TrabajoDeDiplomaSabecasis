Imports StockModelo

Public Class StockException
    Inherits Exception
    Property mensaje As String

    Public Sub New()

    End Sub

    Public Sub New(ex As Exception, clase As String)
        Me.Excepción = ex
        Me.Clase = clase
        Me.mensaje = ex.Message
        guardarEnLog()
    End Sub

    Private _ex As Exception
    Public Property Excepción() As Exception
        Get
            Return _ex
        End Get
        Set(ByVal value As Exception)
            _ex = value
        End Set
    End Property

    Private _clase As String
    Public Property Clase() As String
        Get
            Return _clase
        End Get
        Set(ByVal value As String)
            _clase = value
        End Set
    End Property

    Private Sub guardarEnLog()
        'Dim excepcionJson As String = JsonSerializer(Of Exception).serializarAJson(Me._ex)
        GuardarEnLogAccion.guardar(Nothing, Me.Clase, Nothing, 1, Me.Excepción.Message, DateTime.Now, Me.mensaje)
    End Sub

End Class
