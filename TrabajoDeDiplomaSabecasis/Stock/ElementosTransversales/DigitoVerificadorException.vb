Public Class DigitoVerificadorException
    Inherits StockException

    Private id_fila As Integer
    Private entidad As String


    Public Property IdFila() As Integer
        Get
            Return id_fila
        End Get
        Set(ByVal value As Integer)
            id_fila = value
        End Set
    End Property


    Public Property NombreEntidad() As String
        Get
            Return Me.entidad
        End Get
        Set(ByVal value As String)
            Me.entidad = value
        End Set
    End Property



    Public Sub New(entidad As String, id As Integer, mensaje As String)
        id_fila = id
        Me.entidad = entidad
        Me.mensaje = mensaje & entidad & ", " & id
        Me.Excepción = New Exception()
        Sesion.obtenerInstancia().bloqueado = True
        guardarEnLog()
    End Sub

    Public Sub New()
        Me.mensaje = Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL)
        Sesion.obtenerInstancia().bloqueado = True
        Me.Excepción = New Exception()
        guardarEnLog()
    End Sub

    Private Sub guardarEnLog()
        'Dim excepcionJson As String = JsonSerializer(Of Exception).serializarAJson(Excepción)
        GuardarEnLogAccion.guardar(Nothing, Me.Clase, Nothing, 4, Me.Excepción.Message, DateTime.Now, Me.mensaje)
    End Sub
End Class
