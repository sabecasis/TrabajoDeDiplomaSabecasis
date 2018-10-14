Imports StockModelo

Public Class EliminarMovimientoDeStockAccion
    Implements Accion

    Public Sub New(id As Integer, deposito As Deposito)
        Me.idMovimiento = id
        Me.depositoOrigen = deposito
    End Sub

    Property depositoOrigen As Deposito
    Property idMovimiento As Integer


End Class
