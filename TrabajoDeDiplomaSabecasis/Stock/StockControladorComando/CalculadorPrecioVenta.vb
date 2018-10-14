Imports StockModelo
Imports ElementosTransversales

Public MustInherit Class CalculadorPrecioVenta

    Public MustOverride Function calcular(metodoValoracion As ModoValoracionProducto, precioCompra As Double, precioUltimaCompra As Double, descuentoGlobal As Descuento, porcentajeDeGanancia As Double, precioCosteAdquisicion As Double, costeDePosesión As Double, costeFinanciero As Double, listaInstanciasDeProducto As List(Of InstanciaDeProducto)) As Double

End Class
