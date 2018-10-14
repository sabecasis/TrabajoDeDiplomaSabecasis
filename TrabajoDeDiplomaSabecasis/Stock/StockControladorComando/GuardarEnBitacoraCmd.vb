Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class GuardarEnBitacoraCmd
    Inherits Comando(Of Boolean, GuardarEnBitacoraAccion)

    Public Overrides Function execute(accion As GuardarEnBitacoraAccion) As Boolean
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim relacionDao As AbstractDao(Of RelacionComandoAccionResultado) = DaoFactory(Of RelacionComandoAccionResultado).obtenerInstancia().crear(GetType(RelacionComandoAccionResultado))
            Dim criteria As New ComandoQueryCriteria()
            criteria.Accion = accion.accion
            criteria.Resultado = accion.resultado
            Dim oRelacion As RelacionComandoAccionResultado = relacionDao.obtenerUno(criteria)
            Dim entidad As New ElementoDeBitacora
            entidad.evento = oRelacion.id
            entidad.usuario = Sesion.obtenerInstancia.usuarioActual.nombre
            Dim dao As AbstractDao(Of ElementoDeBitacora) = DaoFactory(Of ElementoDeBitacora).obtenerInstancia.crear(GetType(ElementoDeBitacora))
            Return dao.guardar(entidad)
        Catch e As Exception
            Throw New ExcepcionDeComando(e, Me.GetType.ToString, accion)
        End Try

    End Function
End Class
