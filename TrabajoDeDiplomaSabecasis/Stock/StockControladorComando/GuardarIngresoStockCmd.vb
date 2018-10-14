Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarIngresoStockCmd
    Inherits Comando(Of String, GuardarIngresoStockAccion)

    Public Overrides Function execute(accion As GuardarIngresoStockAccion) As String
        Try
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            Dim oAutorizador As Autorizador = Autorizador.obtenerInstancia()
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            If accion.oIngresoStock Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            If accion.oIngresoStock.pedidoDeReposicion.id = 0 Then
                Dim obtenerPedidosDeStockConFiltroCmd As New ObtenerPedidosDeStockConFiltroCmd
                Dim listaPedidos As List(Of PedidoDeStock) = obtenerPedidosDeStockConFiltroCmd.execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(accion.oIngresoStock.producto, accion.oIngresoStock.deposito, "", 0, Nothing, False))
                If Not listaPedidos Is Nothing Then
                    If listaPedidos.Count > 0 Then
                        accion.oIngresoStock.pedidoDeReposicion = listaPedidos.Item(0)
                    Else
                        Throw New ExcepcionDeComando(New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_PEDIDO_ASOCIADO)), Me.GetType.Name, accion)
                    End If
                Else
                    Throw New ExcepcionDeComando(oSesion.correlacionElementoIdioma.Item(New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_PEDIDO_ASOCIADO))), Me.GetType.Name, accion)
                End If
            End If

            Dim prodInstDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim dao As AbstractDao(Of IngresoDeStock) = DaoFactory(Of IngresoDeStock).obtenerInstancia().crear(GetType(IngresoDeStock))
            Dim prodnstCriteria As New InstanciaDeProductoQueryCriteria
            If accion.oIngresoStock.id = 0 Then
                oAutorizador.autorizar(ConstantesDePermisos.CREAR)
                Dim oProd As Producto = accion.oIngresoStock.producto
                If Not "".Equals(oProd.reglaDeComposicion) Then
                    Dim cmdEgr As New GenerarEgresoPorReglaDeComposicionCmd
                    cmdEgr.execute(New GenerarEgresoPorReglaDeComposicionAccion(oProd.reglaDeComposicion, accion.oIngresoStock.deposito, oProd.id))
                End If

                dao.guardar(accion.oIngresoStock)
                If oProd.metodoDeValoracion.id = ConstantesDeMetodoDeValoracion.PPP Then 'Si es PPP
                    prodnstCriteria.idProducto = oProd.id
                    Dim prodInstList As List(Of InstanciaDeProducto) = prodInstDao.obtenerMuchos(prodnstCriteria)
                    Dim cmd As New CalcularPrecioVentaCmd()
                    Dim precioVenta As Double = cmd.execute(New CalcularPrecioVentaAccion(oProd.metodoDeValoracion, oProd.precioCompra, oProd.precioCompra, oProd.precioCompra, oProd.descuento, oProd.porcentajeGanancia, oProd.precioCosteAdquisicion, oProd.costeDePosecion, oProd.costeFinanciero, prodInstList, prodInstList.Count))
                    For Each oProdInst In prodInstList
                        oProdInst.precioVenta = precioVenta
                    Next
                    prodInstDao.actualizarMuchos(prodInstList)
                End If
                oProd.precioUltimaCompra = accion.oIngresoStock.instanciasDeProducto.Item(0).precioCompra
                Dim prodDao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
                prodDao.actualizar(oProd)
            Else
                oAutorizador.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(accion.oIngresoStock)
            End If

            'Actualizar el pedido de stock asociado
            Dim buscarPedidoCmd As New BuscarPedidoDeStockCmd()
            Dim pedido As PedidoDeStock = buscarPedidoCmd.execute(New BuscarPedidoDeStockAccion(accion.oIngresoStock.pedidoDeReposicion.id))
            Dim ingresoPorPedidoCmd As New ObtenerTodosLosIngresosPorPedidoDeStockCmd()
            Dim listaIngresos As List(Of IngresoDeStock)
            listaIngresos = ingresoPorPedidoCmd.execute(New ObtenerTodosLosIngresosPorPedidoDeStockAccion(accion.oIngresoStock.pedidoDeReposicion.id))
            Dim total As Integer = 0
            For Each oIngreso As IngresoDeStock In listaIngresos
                total += oIngreso.cantidad
            Next
            Dim guardarPedidoCmd As New GuardarPedidoDeStockCmd()
            If total >= pedido.cantidad Then
                pedido.ingresado = True
            Else
                pedido.ingresado = False
            End If
            guardarPedidoCmd.execute(New GuardarPedidoDeStockAccion(pedido.id, pedido.cantidad, pedido.fecha, pedido.producto, pedido.deposito, pedido.ingresado))
            Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.INGRESO_CORRECTO) & accion.oIngresoStock.id
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
