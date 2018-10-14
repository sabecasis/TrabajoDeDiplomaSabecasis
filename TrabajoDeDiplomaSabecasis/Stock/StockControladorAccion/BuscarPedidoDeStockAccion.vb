Imports StockModelo

Public Class BuscarPedidoDeStockAccion
    Implements Accion

    Public Sub New(id As Integer)
        Me.id = id
    End Sub

    Property id As Integer
End Class
