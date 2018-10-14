Imports StockModelo

Public Class ExcepcionDeDatos
    Inherits ExcepcionDeComando
    Public Sub New()

    End Sub

    Public Sub New(ex As Exception, clase As String, query As String)
        Me.Excepción = ex
        Me.Clase = clase
        Me.Query = query
        If TypeOf ex Is StockException Then
            Dim excepcion As StockException = ex
            Me.mensaje = excepcion.mensaje
        Else
            Me.mensaje = ex.Message
        End If
        guardarEnLog()
    End Sub

    Private _query As String
    Public Property Query() As String
        Get
            Return _query
        End Get
        Set(ByVal value As String)
            _query = value
        End Set
    End Property

    Private Sub guardarEnLog()
        'Dim excepcionJson As String = JsonSerializer(Of Exception).serializarAJson(Excepción)
        'Dim accionJson As String = JsonSerializer(Of Accion).serializarAJson(oAccion)
        GuardarEnLogAccion.guardar(Nothing, Me.Clase, Me.Query, 3, Me.Excepción.Message, DateTime.Now, Me.mensaje)
    End Sub
End Class
