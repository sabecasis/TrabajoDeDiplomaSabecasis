Imports StockModelo

Public Class CalculadorPrecioVentaPPP
    Inherits CalculadorPrecioVenta


    Public Overrides Function calcular(metodoValoracion As StockModelo.ModoValoracionProducto, precioCompra As Double, precioUltimaCompra As Double, descuentoGlobal As StockModelo.Descuento, porcentajeDeGanancia As Double, precioCosteAdquisicion As Double, costeDePosesión As Double, costeFinanciero As Double, listaInstanciasDeProducto As List(Of StockModelo.InstanciaDeProducto)) As Double
        Dim precioventa As Double = precioCompra + precioCosteAdquisicion + costeDePosesión + costeFinanciero
        Dim ganancia As Double = (precioventa * porcentajeDeGanancia) / 100
        precioventa = precioventa + ganancia

        Dim total As Double = 0
        Dim preciofinal As Double
        If listaInstanciasDeProducto.Count = 0 Then
            preciofinal = precioventa
        Else
            For Each prod As InstanciaDeProducto In listaInstanciasDeProducto
                total = total + prod.precioVenta
                preciofinal = total / listaInstanciasDeProducto.Count
            Next
        End If

        If Not descuentoGlobal Is Nothing Then
            If descuentoGlobal.monto <> 0 Then
                preciofinal = preciofinal - descuentoGlobal.monto
            ElseIf descuentoGlobal.porcentaje <> 0 Then
                Dim descuento As Double = 0
                descuento = (preciofinal * descuentoGlobal.porcentaje) / 100
                preciofinal = preciofinal - descuento
            End If
        End If


        If Not listaInstanciasDeProducto Is Nothing Then
            For Each prod As InstanciaDeProducto In listaInstanciasDeProducto
                prod.precioVenta = preciofinal
            Next
        End If

        Return Math.Round(preciofinal, 2)
    End Function
End Class
