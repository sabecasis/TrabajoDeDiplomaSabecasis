Imports StockModelo

Public Class BuscarMovimientoDeStockAccion
    Implements Accion

    Public Sub New(id As Integer)
        Me.idMovimiento = id
    End Sub

    Property idMovimiento As Integer

End Class
