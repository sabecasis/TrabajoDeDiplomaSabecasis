Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class GestionarPedidoDeReposicion

    Private comprobante As Byte()

    Private Sub BTNLimpiarPedido_Click(sender As Object, e As EventArgs) Handles BTNLimpiarPedido.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        Try
            TXTCantidad.Text = 0
            TXTEmpleadoId.Text = 0
            TXTId.Text = 0
            DTPFecha.Value = Date.Now
            CMBProducto.DataSource = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBProducto.DisplayMember = "nombre"
            CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBDeposito.DisplayMember = "nomber"
            CHKAceptarPedido.Checked = False
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try

    End Sub

    Private Sub GestionarPedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub


    Private Sub BTNGuardarPedido_Click(sender As Object, e As EventArgs) Handles BTNGuardarPedido.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, GuardarPedidoDeStockAccion).execute(New GuardarPedidoDeStockAccion(CType(TXTId.Text, Integer), CType(TXTCantidad.Text, Integer), DTPFecha.Value, CMBProducto.SelectedValue, CMBDeposito.SelectedValue, CHKAceptarPedido.Checked))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub TXTId_TextChanged(sender As Object, e As EventArgs) Handles TXTId.TextChanged
        Try
            If TXTId.Text.Equals("0") Then
                CHKAceptarPedido.Enabled = False
            Else
                CHKAceptarPedido.Enabled = True
            End If
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try

    End Sub

    Private Sub BTNBscarPedido_Click(sender As Object, e As EventArgs) Handles BTNBscarPedido.Click
        Try
            Dim oPedido As PedidoDeStock = Dispatcher(Of PedidoDeStock, BuscarPedidoDeStockAccion).execute(New BuscarPedidoDeStockAccion(CType(TXTId.Text, Integer)))
            If oPedido Is Nothing Then
                Throw New StockException(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_PEDIDO), Me.GetType.ToString)
            End If
            TXTId.Text = oPedido.id
            TXTEmpleadoId.Text = oPedido.empleado.id
            TXTCantidad.Text = oPedido.cantidad

            Dim elem As Producto
            For i As Integer = 0 To CMBProducto.Items.Count - 1
                elem = DirectCast(CMBProducto.Items.Item(i), Producto)
                If elem.id = oPedido.producto.id Then
                    CMBProducto.SelectedIndex = i
                    Exit For
                End If
            Next

            Dim delem As Deposito
            For i As Integer = 0 To CMBDeposito.Items.Count - 1
                delem = DirectCast(CMBDeposito.Items.Item(i), Deposito)
                If delem.id = oPedido.deposito.id Then
                    CMBDeposito.SelectedIndex = i
                    Exit For
                End If
            Next

            DTPFecha.Value = oPedido.fecha
            CHKAceptarPedido.Checked = oPedido.ingresado
            Me.comprobante = oPedido.comprobante
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNEliminarPedido_Click(sender As Object, e As EventArgs) Handles BTNEliminarPedido.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, EliminarPedidoDeStockAccion).execute(New EliminarPedidoDeStockAccion(CType(TXTId.Text, Integer)))
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNDescargarComprobantePedido_Click(sender As Object, e As EventArgs) Handles BTNDescargarComprobantePedido.Click
        Try
            Dispatcher(Of String, AbrirComprobanteIngresoAccion).execute(New AbrirComprobanteIngresoAccion(Me.comprobante))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub
End Class