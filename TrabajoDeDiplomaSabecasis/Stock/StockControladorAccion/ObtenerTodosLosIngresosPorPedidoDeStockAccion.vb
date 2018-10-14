Imports StockModelo

Public Class ObtenerTodosLosIngresosPorPedidoDeStockAccion
    Implements Accion

    Public Sub New(_idPedidoDeStock)
        Me.idPedidoDeStock = _idPedidoDeStock
    End Sub
    Public Sub New()

    End Sub

    Property idPedidoDeStock As Integer
End Class
