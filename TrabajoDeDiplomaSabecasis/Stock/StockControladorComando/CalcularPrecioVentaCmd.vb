Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class CalcularPrecioVentaCmd
    Inherits Comando(Of Double, CalcularPrecioVentaAccion)

    Public Overrides Function execute(accion As CalcularPrecioVentaAccion) As Double
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim metodoValoracion As ModoValoracionProducto = accion.modoValoracion
            Dim calculador As CalculadorPrecioVenta = CalculadorPrecioVentaFactory.obtenerInstancia().crear(metodoValoracion)
            Return calculador.calcular(accion.modoValoracion, accion.precioCompra, accion.precioUltimaCompra, accion.descuentoGlobal, accion.porcentajeDeGanancia, accion.precioCosteAdquisicion, accion.costeDePosesión, accion.costeFinanciero, accion.listaInstanciasDeProducto)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class
