Imports StockModelo

Public Class BuscarIngresoDeStockAccion
    Implements Accion

    Public Sub New(id As Integer, deposito As Deposito, fecha As Date, producto As Producto)
        Me.id = id
        Me.deposito = deposito
        Me.producto = producto
        Me.fecha = fecha
    End Sub

    Property id As Integer
    Property fecha As Date
    Property producto As Producto
    Property deposito As Deposito

End Class
