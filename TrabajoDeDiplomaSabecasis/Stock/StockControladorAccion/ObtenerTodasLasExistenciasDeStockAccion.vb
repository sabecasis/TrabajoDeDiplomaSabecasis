Imports StockModelo

Public Class ObtenerTodasLasExistenciasDeStockAccion
    Implements Accion

    Public Sub New(iddep As Integer, idprod As Integer)
        Me.iddeposito = iddep
        Me.idproducto = idprod
    End Sub

    Property iddeposito As Integer = 0
    Property idproducto As Integer = 0
End Class
