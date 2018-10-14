Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarIngresoStockCmd
    Inherits Comando(Of String, EliminarIngresoStockAccion)


    Public Overrides Function execute(accion As EliminarIngresoStockAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If

            Dim dao As AbstractDao(Of IngresoDeStock) = DaoFactory(Of IngresoDeStock).obtenerInstancia().crear(GetType(IngresoDeStock))
            Dim criteria As New GenericQueryCriteria
            Dim ingreso As New IngresoDeStock
            ingreso.id = accion.id
            ingreso.fecha = Date.Now
            ingreso.producto = New Producto
            ingreso.producto.id = 0
            ingreso.deposito = New Deposito
            ingreso.deposito.id = 0
            criteria.oObject = ingreso
            Dim igs As IngresoDeStock = dao.obtenerUno(criteria)
            dao.eliminar(igs)

            'Actualizar el pedido de stock asociado
            Dim buscarPedidoCmd As New BuscarPedidoDeStockCmd()
            Dim pedido As PedidoDeStock = buscarPedidoCmd.execute(New BuscarPedidoDeStockAccion(igs.pedidoDeReposicion.id))
            Dim ingresoPorPedidoCmd As New ObtenerTodosLosIngresosPorPedidoDeStockCmd()
            Dim listaIngresos As List(Of IngresoDeStock)
            listaIngresos = ingresoPorPedidoCmd.execute(New ObtenerTodosLosIngresosPorPedidoDeStockAccion(igs.pedidoDeReposicion.id))
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
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.INGRESO_ELIMINADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
