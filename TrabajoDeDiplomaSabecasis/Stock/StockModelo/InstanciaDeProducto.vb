Public Class InstanciaDeProducto
    Property id As Integer
    Property producto As Producto
    Property precioCompra As Double
    Property precioVenta As Double
    Property deposito As Deposito
    Property estado As EstadoInstanciaProducto
    Property fechaUltimaModificacion As Date
    Property motivoModificacion As String
    Property ingresoEnStock As IngresoDeStock
    Property movimientosDeStock As List(Of MovimientoDeStock)
    Property descuentos As List(Of Descuento)
    Property egresoDeStock As EgresoDeStock

    Public Overrides Function ToString() As String
        Return id.ToString
    End Function
End Class
