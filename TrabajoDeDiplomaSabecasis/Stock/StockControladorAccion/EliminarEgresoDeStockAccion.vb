Imports StockModelo

Public Class EliminarEgresoDeStockAccion
    Implements Accion

    Public Sub New(id As Integer)
        Me.idEgreso = id
    End Sub

    Property idEgreso As Integer
End Class
