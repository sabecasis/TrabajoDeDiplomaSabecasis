Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarEgresoDeStockCmd
    Inherits Comando(Of String, GuardarEgresoDeStockAccion)

    Public Overrides Function execute(accion As GuardarEgresoDeStockAccion) As String
        Try
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            Dim oAutorizador As Autorizador = Autorizador.obtenerInstancia()
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of EgresoDeStock) = DaoFactory(Of EgresoDeStock).obtenerInstancia().crear(GetType(EgresoDeStock))
            If accion.egresoDeStock.id = 0 Then
                oAutorizador.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(accion.egresoDeStock)
                Dim oProd As Producto = accion.egresoDeStock.producto
                Dim prodnstCriteria As New InstanciaDeProductoQueryCriteria
                Dim prodInstDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
                If oProd.metodoDeValoracion.id = ConstantesDeMetodoDeValoracion.PPP Then
                    prodnstCriteria.idProducto = oProd.id
                    Dim prodInstList As List(Of InstanciaDeProducto) = prodInstDao.obtenerMuchos(prodnstCriteria)
                    Dim cmd As New CalcularPrecioVentaCmd()
                    Dim precioVenta As Integer = cmd.execute(New CalcularPrecioVentaAccion(oProd.metodoDeValoracion, oProd.precioCompra, oProd.precioCompra, oProd.precioCompra, oProd.descuento, oProd.porcentajeGanancia, oProd.precioCosteAdquisicion, oProd.costeDePosecion, oProd.costeFinanciero, prodInstList, prodInstList.Count))
                    For Each oProdInst In prodInstList
                        oProdInst.precioVenta = precioVenta
                    Next
                    prodInstDao.actualizarMuchos(prodInstList)
                End If
            Else
                oAutorizador.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(accion.egresoDeStock)
            End If
            Dim calcularCmd As New CalcularFaltantesDeStockCmd()
            Dim listaExistencias As List(Of ExistenciaDeProductoEnStock) = calcularCmd.execute(New CalcularFaltantesDeStockAccion(accion.egresoDeStock.deposito))
           
            Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.EGRESO_STOCK_GUARDADO) + accion.egresoDeStock.id.ToString
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
