Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerPedidosDeStockConFiltroCmd
    Inherits Comando(Of List(Of PedidoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion)

    Public Overrides Function execute(accion As ObtenerTodosLosMovimientosDeStockConFiltroAccion) As List(Of PedidoDeStock)
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
            Dim criteria As New ConsultaMovimientosDeStockVariosQueryCriteria
            criteria.deposito = accion.deposito
            criteria.fecha = accion.fecha
            criteria.instanciaId = accion.instancia_id
            criteria.nroEmpleado = accion.nroEmpleado
            criteria.producto = accion.producto
            criteria.ingresado = accion.ingresado
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
