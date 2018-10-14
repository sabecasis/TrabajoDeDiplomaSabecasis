Imports StockModelo

Public Class CalcularFaltantesDeStockAccion
    Implements Accion

    Public Sub New(dep As Deposito)
        Me.deposito = dep
    End Sub

    Property deposito As Deposito

End Class
