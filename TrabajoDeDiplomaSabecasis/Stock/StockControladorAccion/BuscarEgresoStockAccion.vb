Imports StockModelo

Public Class BuscarEgresoStockAccion
    Implements Accion

    Public Sub New(idEgreso As Integer)
        Me.idEgreso = idEgreso
    End Sub

    Property idEgreso As Integer
End Class
