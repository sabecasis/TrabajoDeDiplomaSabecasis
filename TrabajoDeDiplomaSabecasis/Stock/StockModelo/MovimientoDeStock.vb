Public Class MovimientoDeStock
    Property id As Integer
    Property producto As Producto
    Property depositoOrigen As Deposito
    Property depositoDestino As Deposito
    Property listaInstancias As List(Of InstanciaDeProducto) = New List(Of InstanciaDeProducto)
    Property fecha As Date
    Property cantidad As Integer
    Property motivo As String
    Property comprobante As Byte()
    Property fechaAceptacion As Date
    Property empleado As Empleado
End Class
