Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarMovimientoDeStockCmd
    Inherits Comando(Of MovimientoDeStock, BuscarMovimientoDeStockAccion)

    Public Overrides Function execute(accion As BuscarMovimientoDeStockAccion) As MovimientoDeStock
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of MovimientoDeStock) = DaoFactory(Of MovimientoDeStock).obtenerInstancia().crear(GetType(MovimientoDeStock))
            Dim criteria As New MovimientoDeStockQueryCriteria
            criteria.idMovimiento = accion.idMovimiento
            Return dao.obtenerUno(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
