Imports StockModelo

Public Class GuardarPedidoDeStockAccion
	Implements Accion

    Public Sub New(id As Integer, cantidad As Integer, fecha As Date, producto As Producto, deposito As Deposito, ingresado As Boolean)
        Me.id = id
        Me.fecha = fecha
        Me.cantidad = cantidad
        Me.deposito = deposito
        Me.producto = producto
        Me.ingresado = ingresado
    End Sub

    Property id As Integer
    Property cantidad As Integer
    Property fecha As Date
    Property producto As Producto
    Property deposito As Deposito
    Property ingresado As Boolean

End Class
