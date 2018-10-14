Public Class EgresoDeStock

    Property id As Integer
    Property motivo As String
    Property fecha As Date
    Property producto As Producto
    Property deposito As Deposito
    Property comprobante As Byte()
    Property cantidad As Integer
    Property listaInstanciasDeProducto As List(Of InstanciaDeProducto)
    Property empleado As Empleado
End Class
