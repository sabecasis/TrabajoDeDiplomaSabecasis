Imports StockModelo

Public Class ExcepcionDeComando
    Inherits StockException

    Public Sub New()

    End Sub

    Public Sub New(ex As Exception, clase As String, accion As Accion)
        Me.Excepción = ex
        Me.Clase = clase
        Me.oAccion = accion
        If TypeOf ex Is StockException Then
            Dim excepcion As StockException = ex
            Me.mensaje = excepcion.mensaje
        Else
            Me.mensaje = ex.Message
        End If
        guardarEnLog()
    End Sub


    Private _accion As Accion
    Public Property oAccion() As Accion
        Get
            Return _accion
        End Get
        Set(ByVal value As Accion)
            _accion = value
        End Set
    End Property

    Private Sub guardarEnLog()
        'Dim excepcionJson As String = JsonSerializer(Of Exception).serializarAJson(Excepción)
        'Dim accionJson As String = JsonSerializer(Of Accion).serializarAJson(_accion)
        GuardarEnLogAccion.guardar(oAccion.GetType.ToString, Me.Clase, Nothing, 2, Me.Excepción.Message, DateTime.Now, Me.mensaje)
    End Sub

End Class
