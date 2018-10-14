Public Class CalculadorPrecioVentaGenerico
    Inherits CalculadorPrecioVenta

    Public Overrides Function calcular(metodoValoracion As StockModelo.ModoValoracionProducto, precioCompra As Double, precioUltimaCompra As Double, descuentoGlobal As StockModelo.Descuento, porcentajeDeGanancia As Double, precioCosteAdquisicion As Double, costeDePosesión As Double, costeFinanciero As Double, listaInstanciasDeProducto As List(Of StockModelo.InstanciaDeProducto)) As Double
        Dim total As Double = 0
        total = precioCompra + precioCosteAdquisicion + costeDePosesión + costeFinanciero
        Dim ganancia As Double = (total * porcentajeDeGanancia) / 100
        total = total + ganancia

        If Not descuentoGlobal Is Nothing Then
            If descuentoGlobal.monto <> 0 Then
                total = total - descuentoGlobal.monto
            ElseIf descuentoGlobal.porcentaje <> 0 Then
                Dim descuento As Double = 0
                descuento = (total * descuentoGlobal.porcentaje) / 100
                total = total - descuento
            End If
        End If

        Return Math.Round(total, 2)
    End Function
End Class
