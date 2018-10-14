Imports StockModelo

Public Class ObtenerTodosLosMovimientosDeStockNoAceptadosAccion
	Implements Accion

    Public Sub New(dep As List(Of Deposito))
        Me.depositos = dep
    End Sub

    Property depositos As List(Of Deposito)

End Class
