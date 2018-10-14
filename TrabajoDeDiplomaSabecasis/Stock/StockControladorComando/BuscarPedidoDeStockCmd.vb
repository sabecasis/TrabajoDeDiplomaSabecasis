Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarPedidoDeStockCmd
    Inherits Comando(Of PedidoDeStock, BuscarPedidoDeStockAccion)

    Public Overrides Function execute(accion As BuscarPedidoDeStockAccion) As PedidoDeStock
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
            Dim criteria As New GenericQueryCriteria
            criteria.integerCriteria = accion.id
            Return dao.obtenerUno(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
