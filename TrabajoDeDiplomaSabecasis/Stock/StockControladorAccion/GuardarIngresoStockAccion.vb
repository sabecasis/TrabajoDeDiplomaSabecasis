Imports StockModelo

Public Class GuardarIngresoStockAccion
	Implements Accion

    Public Sub New(id As Integer, empleado As Empleado, deposito As Deposito, proveedor As Proveedor, prod As Producto, listaInstProds As List(Of InstanciaDeProducto), fecha As Date, precioCompra As Double, precioVenta As Double, facturaProveedor As Byte(), extension As String, pedidoReposicionId As Integer, cantidad As Integer)
        oIngresoStock = New IngresoDeStock
        oIngresoStock.id = id
        oIngresoStock.deposito = deposito
        oIngresoStock.empleado = empleado
        oIngresoStock.factura = facturaProveedor
        oIngresoStock.fecha = fecha
        oIngresoStock.instanciasDeProducto = listaInstProds
        oIngresoStock.producto = prod
        oIngresoStock.proveedor = proveedor
        oIngresoStock.extensionFactura = extension
        oIngresoStock.pedidoDeReposicion = New PedidoDeStock
        oIngresoStock.pedidoDeReposicion.id = pedidoReposicionId
        oIngresoStock.cantidad = cantidad
    End Sub

    Property oIngresoStock As IngresoDeStock

End Class
