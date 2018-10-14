Imports StockModelo

Public Class GuardarProductoAccion
    Implements Accion

    Public Sub New(precioUltimaCompra As Double, id As Integer, nombre As String, desc As String, precioCompas As Double, precioVenta As Double, moneda As Moneda, marca As Marca, estado As EstadoProducto, descuento As Descuento, clasif As ClasificacionProducto, regla As String, proveedores As List(Of Proveedor), porcentajeGan As Double, precioCosteAdq As Double, precioCostePosesio As Double, costeFinanciero As Double, modoValoracion As ModoValoracionProducto, minStock As Integer, maxStock As Integer, metodoDeReposicion As MetodoDeReposicion, ciclo As Integer, familia As FamiliaDeProducto, unidad As String, pedidoAutomatico As Boolean)
        oProducto.id = id
        oProducto.nombre = nombre
        oProducto.descripcion = desc
        oProducto.costeDePosecion = precioCostePosesio
        oProducto.clasificacion = clasif
        oProducto.costeFinanciero = costeFinanciero
        oProducto.descuento = descuento
        oProducto.estado = estado
        oProducto.marca = marca
        oProducto.metodoDeValoracion = modoValoracion
        oProducto.moneda = moneda
        oProducto.porcentajeGanancia = porcentajeGan
        oProducto.precioCompra = precioCompas
        oProducto.precioCosteAdquisicion = precioCosteAdq
        oProducto.precioVenta = precioVenta
        oProducto.proveedores = proveedores
        oProducto.reglaDeComposicion = regla
        oProducto.precioUltimaCompra = precioUltimaCompra
        oProducto.minStock = minStock
        oProducto.maxStock = maxStock
        oProducto.ciclo = ciclo
        oProducto.metodoDeReposicion = metodoDeReposicion
        oProducto.familia = familia
        oProducto.unidad = unidad
        oProducto.pedidoAutomatico = pedidoAutomatico
    End Sub

    Property oProducto As Producto = New Producto()

End Class
