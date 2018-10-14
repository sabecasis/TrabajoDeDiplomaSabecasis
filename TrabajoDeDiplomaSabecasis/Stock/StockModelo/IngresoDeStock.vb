Public Class IngresoDeStock
    Property id As Integer
    Property instanciasDeProducto As List(Of InstanciaDeProducto)
    Property comprobante As Byte()
    Property fecha As Date
    Property empleado As Empleado
    Property cantidad As Integer
    Property producto As Producto
    Property proveedor As Proveedor
    Property factura As Byte()
    Property deposito As Deposito
    Property extensionFactura As String
    Property pedidoDeReposicion As PedidoDeStock

    Public Overrides Function ToString() As String
        Return Me.id
    End Function
End Class
