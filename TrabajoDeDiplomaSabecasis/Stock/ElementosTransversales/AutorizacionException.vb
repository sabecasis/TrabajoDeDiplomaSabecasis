Public Class AutorizacionException
    Inherits StockException

    Property ex As Exception
    Property permiso As String

    Public Sub New(e As Exception)
        Me.ex = e
        Me.mensaje = e.Message & " " & permiso
        guardarEnLog()
    End Sub

    Public Sub New(e As Exception, perm As String)
        Me.ex = e
        Me.permiso = perm
        Me.mensaje = e.Message
        guardarEnLog()
    End Sub

    Public Sub New(message As String, perm As String)
        Me.ex = New Exception(message)
        Me.permiso = perm
        Me.mensaje = message
        guardarEnLog()
    End Sub

    Public Sub New(perm As String)
        Me.ex = New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma().Item(ConstantesDeMensaje.NO_TIENE_PERMISO))
        Me.permiso = perm
        Me.mensaje = ex.Message
        guardarEnLog()
    End Sub

    Private Sub guardarEnLog()
        'Dim excepcionJson As String = JsonSerializer(Of Exception).serializarAJson(Excepción)
        GuardarEnLogAccion.guardar(Nothing, Me.Clase, Nothing, 5, Me.ex.Message, DateTime.Now, Me.mensaje)
    End Sub
End Class
