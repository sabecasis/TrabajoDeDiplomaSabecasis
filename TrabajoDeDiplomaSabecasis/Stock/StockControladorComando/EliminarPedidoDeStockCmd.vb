Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarPedidoDeStockCmd
    Inherits Comando(Of String, EliminarPedidoDeStockAccion)

    Public Overrides Function execute(accion As EliminarPedidoDeStockAccion) As String
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ELIMINAR)
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
            Dim oPedido As New PedidoDeStock
            oPedido.id = accion.id
            dao.eliminar(oPedido)
            Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.PEDIDO_ELIMINADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
