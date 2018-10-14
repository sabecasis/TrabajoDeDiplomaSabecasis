Imports StockControladorAccion
Imports StockControlador
Imports StockModelo
Imports ElementosTransversales

Public Class ConsultarMovimientosDeStock

    Private Sub ConsultarMovimientosDeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            limpiar()
            Dim row As String()
            Dim listaIngreso As List(Of StockModelo.IngresoDeStock) = Dispatcher(Of List(Of StockModelo.IngresoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(New Producto, New Deposito, "", 0, Nothing))
            For Each ingreso As StockModelo.IngresoDeStock In listaIngreso
                row = New String() {ingreso.id.ToString, ingreso.producto.id.ToString, ingreso.deposito.id.ToString, ingreso.empleado.id.ToString, ingreso.fecha, ingreso.cantidad}
                DGVIngresoDeStock.Rows.Add(row)
            Next
            Dim listaEgreso As List(Of StockModelo.EgresoDeStock) = Dispatcher(Of List(Of StockModelo.EgresoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(New Producto, New Deposito, "", 0, Nothing))
            For Each egreso As StockModelo.EgresoDeStock In listaEgreso
                row = New String() {egreso.id.ToString, egreso.producto.id.ToString, egreso.deposito.id.ToString, egreso.empleado.id.ToString, egreso.fecha, egreso.cantidad, egreso.motivo}
                DGVEgresosDeStock.Rows.Add(row)
            Next

            Dim listaMovimiento As List(Of StockModelo.MovimientoDeStock) = Dispatcher(Of List(Of StockModelo.MovimientoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(New Producto, New Deposito, "", 0, Nothing))
            For Each movimiento As StockModelo.MovimientoDeStock In listaMovimiento
                row = New String() {movimiento.id.ToString, movimiento.cantidad, movimiento.fecha, movimiento.depositoOrigen.id.ToString, movimiento.depositoDestino.id.ToString, movimiento.producto.id.ToString, movimiento.motivo, movimiento.fechaAceptacion.ToString, movimiento.empleado.id.ToString}
                DGVMovimientosDeStock.Rows.Add(row)
            Next
            Dim listaPedidos As List(Of StockModelo.PedidoDeStock) = Dispatcher(Of List(Of StockModelo.PedidoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(New Producto, New Deposito, "", 0, Nothing))
            For Each pedido As StockModelo.PedidoDeStock In listaPedidos
                Dim esIngresado As String
                If pedido.ingresado = True Then
                    esIngresado = "True"
                Else
                    esIngresado = "False"
                End If
                row = New String() {pedido.id.ToString, pedido.producto.id.ToString, pedido.deposito.id.ToString, pedido.empleado.id.ToString, pedido.fecha, pedido.cantidad, esIngresado}
                DGVPedidoDeStock.Rows.Add(row)
            Next
        Catch ex As Exception
            Dim excepcion As New StockException(ex, Me.GetType.ToString)
        End Try

    End Sub

    Private Sub limpiar()
        TXTIdInstancia.Text = 0
        TXTNroEmpleado.Text = ""
        CMBProducto.DataSource = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        CMBProducto.DisplayMember = "nombre"
        CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        CMBDeposito.DisplayMember = "nomber"
        CHKNoConsiderarDeposito.Checked = True
        CHKNoConsiderarElProducto.Checked = True
        CHKNoConsiderarFechaEnBusqueda.Checked = True
        DTPFecha.Value = Date.Now
        DGVIngresoDeStock.Rows.Clear()
        DGVEgresosDeStock.Rows.Clear()
        DGVMovimientosDeStock.Rows.Clear()
        DGVPedidoDeStock.Rows.Clear()
    End Sub

    Private Sub BTNFiltrarConsultaMovimientos_Click(sender As Object, e As EventArgs) Handles BTNFiltrarConsultaMovimientos.Click
        Try
            Dim depositoAEnviar As Deposito = CMBDeposito.SelectedValue
            If CHKNoConsiderarDeposito.Checked = True Then
                depositoAEnviar.id = 0
            End If
            Dim productoAEnviar As Producto = CMBProducto.SelectedValue
            If CHKNoConsiderarElProducto.Checked = True Then
                productoAEnviar.id = 0
            End If
            Dim fecha As Date = Nothing
            If CHKNoConsiderarFechaEnBusqueda.Checked = False Then
                fecha = DTPFecha.Value
            End If
            Dim row As String()
            DGVIngresoDeStock.Rows.Clear()
            Dim listaIngreso As List(Of StockModelo.IngresoDeStock) = Dispatcher(Of List(Of StockModelo.IngresoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(productoAEnviar, depositoAEnviar, TXTNroEmpleado.Text, CType(TXTIdInstancia.Text, Integer), fecha))
            For Each ingreso As StockModelo.IngresoDeStock In listaIngreso
                row = New String() {ingreso.id.ToString, ingreso.producto.id.ToString, ingreso.deposito.id.ToString, ingreso.empleado.id.ToString, ingreso.fecha, ingreso.cantidad}
                DGVIngresoDeStock.Rows.Add(row)
            Next
            DGVEgresosDeStock.Rows.Clear()
            Dim listaEgreso As List(Of StockModelo.EgresoDeStock) = Dispatcher(Of List(Of StockModelo.EgresoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(productoAEnviar, depositoAEnviar, TXTNroEmpleado.Text, CType(TXTIdInstancia.Text, Integer), fecha))
            For Each egreso As StockModelo.EgresoDeStock In listaEgreso
                row = New String() {egreso.id.ToString, egreso.producto.id.ToString, egreso.deposito.id.ToString, egreso.empleado.id.ToString, egreso.fecha, egreso.cantidad, egreso.motivo}
                DGVEgresosDeStock.Rows.Add(row)
            Next
            DGVMovimientosDeStock.Rows.Clear()
            Dim listaMovimiento As List(Of StockModelo.MovimientoDeStock) = Dispatcher(Of List(Of StockModelo.MovimientoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(New Producto, New Deposito, "", 0, Nothing))
            For Each movimiento As StockModelo.MovimientoDeStock In listaMovimiento
                row = New String() {movimiento.id.ToString, movimiento.cantidad, movimiento.fecha, movimiento.depositoOrigen.id.ToString, movimiento.depositoDestino.id.ToString, movimiento.producto.id.ToString, movimiento.motivo, movimiento.fechaAceptacion.ToString, movimiento.empleado.id.ToString}
                DGVMovimientosDeStock.Rows.Add(row)
            Next

            DGVPedidoDeStock.Rows.Clear()
            Dim listaPedido As List(Of StockModelo.PedidoDeStock) = Dispatcher(Of List(Of StockModelo.PedidoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(productoAEnviar, depositoAEnviar, TXTNroEmpleado.Text, CType(TXTIdInstancia.Text, Integer), fecha))
            For Each pedido As StockModelo.PedidoDeStock In listaPedido
                row = New String() {pedido.id.ToString, pedido.producto.id.ToString, pedido.deposito.id.ToString, pedido.empleado.id.ToString, pedido.fecha, pedido.cantidad}
                DGVPedidoDeStock.Rows.Add(row)
            Next
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

End Class