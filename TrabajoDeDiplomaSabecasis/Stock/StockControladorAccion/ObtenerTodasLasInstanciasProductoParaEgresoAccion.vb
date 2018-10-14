Imports StockModelo

Public Class ObtenerTodasLasInstanciasProductoParaEgresoAccion
	Implements Accion

    Public Sub New(idProd As Integer, idDep As Integer)
        Me.idDeposito = idDep
        Me.idProducto = idProd
    End Sub

    Property idProducto As Integer
    Property idDeposito As Integer

End Class
