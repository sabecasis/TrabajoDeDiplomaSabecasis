Imports StockModelo

Public Class ObtenerDepositosPorProductoAccion
	Implements Accion

    Public Sub New(id As Integer)
        Me.productoId = id
    End Sub

    Property productoId As Integer

End Class
