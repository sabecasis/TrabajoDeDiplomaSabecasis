Imports StockModelo

Public Class CalcularPrecioVentaAccion
    Implements Accion

    Public Sub New(modoValoracion As ModoValoracionProducto, precioCompra As Double, precioUltimaCompra As Double, costoEstandar As Double, descuentoGlobal As Descuento, porcentajeDeGanancia As Double, precioCosteAdquisicion As Double, costeDePosesión As Double, costeFinanciero As Double, listaInstanciasDeProducto As List(Of InstanciaDeProducto), cantidadDeProductos As Integer)
        Me.modoValoracion = modoValoracion
        Me.precioCompra = precioCompra
        Me.precioUltimaCompra = precioUltimaCompra
        Me.costoEstandar = costoEstandar
        Me.descuentoGlobal = descuentoGlobal
        Me.porcentajeDeGanancia = porcentajeDeGanancia
        Me.precioCosteAdquisicion = precioCosteAdquisicion
        Me.costeDePosesión = costeDePosesión
        Me.costeFinanciero = costeFinanciero
        Me.listaInstanciasDeProducto = listaInstanciasDeProducto
        Me.cantidadDeProductos = cantidadDeProductos
    End Sub

    Property modoValoracion As ModoValoracionProducto

    Property precioCompra As Double
    Property precioUltimaCompra As Double
    Property costoEstandar As Double
    Property descuentoGlobal As Descuento
    Property porcentajeDeGanancia As Double
    Property precioCosteAdquisicion As Double
    Property costeDePosesión As Double
    Property costeFinanciero As Double
    Property listaInstanciasDeProducto As List(Of InstanciaDeProducto)
    Property cantidadDeProductos As Integer

End Class
