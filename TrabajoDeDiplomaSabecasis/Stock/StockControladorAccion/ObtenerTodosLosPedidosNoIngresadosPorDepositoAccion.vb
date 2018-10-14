Imports StockModelo

Public Class ObtenerTodosLosPedidosNoIngresadosPorDepositoAccion
	Implements Accion

    Public Sub New(dep As List(Of Deposito))
        Me.deposito = dep
    End Sub
    Property deposito As List(Of Deposito)

End Class
