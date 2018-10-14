Imports StockControlador
Imports StockControladorAccion
Imports StockModelo
Imports ElementosTransversales

Public Class ConsultarStockFaltante

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ingreso As New IngresoDeStock
        ingreso.ShowDialog()
    End Sub

    Private Sub LSTDepositos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSTDepositos.SelectedIndexChanged
        Try
            Dim row As String()
            DGVPedidoDeStock.Rows.Clear()
            Dim listaPedidos As List(Of StockModelo.PedidoDeStock) = Dispatcher(Of List(Of StockModelo.PedidoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion).execute(New ObtenerTodosLosMovimientosDeStockConFiltroAccion(New Producto(), LSTDepositos.SelectedValue, "", 0, Nothing))
            For Each pedido As StockModelo.PedidoDeStock In listaPedidos
                row = New String() {pedido.id.ToString, pedido.producto.id.ToString, pedido.deposito.id.ToString, pedido.empleado.id.ToString, pedido.fecha, pedido.cantidad}
                DGVPedidoDeStock.Rows.Add(row)
            Next

            Dim listaExistencias As List(Of ExistenciaDeProductoEnStock) = Dispatcher(Of List(Of ExistenciaDeProductoEnStock), CalcularFaltantesDeStockAccion).execute(New CalcularFaltantesDeStockAccion(LSTDepositos.SelectedValue))
            DGVExistenciasFaltantes.DataSource = listaExistencias

        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch exep As Exception
            Dim log As New StockException(exep, Me.GetType.ToString)
        End Try

    End Sub

    Private Sub ConsultarStockFaltante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LSTDepositos.DataSource = Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).depositos
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try

    End Sub
End Class