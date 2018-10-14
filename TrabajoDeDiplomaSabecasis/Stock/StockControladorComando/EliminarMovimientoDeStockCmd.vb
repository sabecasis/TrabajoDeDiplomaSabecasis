Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarMovimientoDeStockCmd
    Inherits Comando(Of String, EliminarMovimientoDeStockAccion)


    Public Overrides Function execute(accion As EliminarMovimientoDeStockAccion) As String
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ELIMINAR)
            Dim oSesion As Sesion = Sesion.obtenerInstancia
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of MovimientoDeStock) = DaoFactory(Of MovimientoDeStock).obtenerInstancia().crear(GetType(MovimientoDeStock))
            Dim oEntidad As New MovimientoDeStock
            oEntidad.id = accion.idMovimiento
            oEntidad.depositoOrigen = accion.depositoOrigen
            dao.eliminar(oEntidad)
            Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.MOVIMIENTO_ELIMINADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
