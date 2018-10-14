Public Class Producto

    Property id As Integer = 0
    Property nombre As String
    Property descripcion As String
    Property precioCompra As Double
    Property precioVenta As Double
    Property moneda As Moneda
    Property marca As Marca
    Property proveedores As List(Of Proveedor)
    Property cantStock As Integer
    Property reglaDeComposicion As String
    Property porcentajeGanancia As Double
    Property descuento As Descuento
    Property precioCosteAdquisicion As Double
    Property costeDePosecion As Double
    Property costeFinanciero As Double
    Property instanciasDeProductoActivas As List(Of InstanciaDeProducto)
    Property estado As EstadoProducto
    Property clasificacion As ClasificacionProducto
    Property metodoDeValoracion As ModoValoracionProducto
    Property precioUltimaCompra As Double
    Property metodoDeReposicion As MetodoDeReposicion
    Property ciclo As Integer
    Property minStock As Integer
    Property maxStock As Integer
    Property familia As FamiliaDeProducto
    Property unidad As String
    Property pedidoAutomatico As Boolean

    Public Overrides Function ToString() As String
        Return Me.nombre
    End Function

End Class
