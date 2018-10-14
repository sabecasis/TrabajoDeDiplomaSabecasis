Imports StockModelo

Public Class ConsultaMovimientosDeStockVariosQueryCriteria
    Implements QueryCriteria

    Property deposito As Deposito = New Deposito
    Property producto As Producto = New Producto
    Property fecha As Date = Nothing
    Property nroEmpleado As String = ""
    Property instanciaId As Integer = 0
    Property ingresado As Boolean = False
End Class
