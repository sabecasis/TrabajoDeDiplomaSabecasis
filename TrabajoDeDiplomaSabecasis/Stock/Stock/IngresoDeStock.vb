Imports StockModelo
Imports StockControladorAccion
Imports StockControlador
Imports ElementosTransversales

Public Class IngresoDeStock

    Private factura As Byte()
    Private comprobante As Byte()
    Private extension As String

    Private Sub IngresoDeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim obtenerTodos As New ObtenerTodosAccion()
            CMBProducto.DataSource = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(obtenerTodos)
            CMBProducto.DisplayMember = "nombre"
            CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(obtenerTodos)
            CMBDeposito.DisplayMember = "nomber"
            CMBProveedor.DataSource = Dispatcher(Of List(Of Proveedor), ObtenerTodosAccion).execute(obtenerTodos)
            CMBProveedor.DisplayMember = "nombre"
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub BTNExaminarIngreso_Click(sender As Object, e As EventArgs) Handles BTNExaminarIngreso.Click
        OFDFacturaProveedor.ShowDialog()
        TXTFacturaProveedor.Text = OFDFacturaProveedor.FileName
    End Sub

    Private Sub BTNGuardarIngreso_Click(sender As Object, e As EventArgs) Handles BTNGuardarIngreso.Click
        Try
            Dim file As System.IO.Stream = Nothing
            Dim buffer As Byte()
            Try
                file = OFDFacturaProveedor.OpenFile()
                Dim tempbuffer(file.Length) As Byte
                file.Read(tempbuffer, 0, file.Length - 1)
                buffer = tempbuffer
                Me.extension = OFDFacturaProveedor.FileName.Substring(OFDFacturaProveedor.FileName.LastIndexOf("."))
                file.Close()
            Catch eee As Exception
                MessageBox.Show(eee.Message)
            End Try


            Dim listaInstProds As New List(Of InstanciaDeProducto)
            Dim instProd As InstanciaDeProducto
            For i As Integer = 0 To CType(TXTCantidad.Text, Integer) - 1
                instProd = New InstanciaDeProducto()
                instProd.fechaUltimaModificacion = Date.Now
                instProd.estado = New EstadoInstanciaProducto()
                instProd.estado.id = 1

                instProd.motivoModificacion = ""
                instProd.precioCompra = TXTPrecioCompra.Text
                instProd.precioVenta = TXTPrecioVenta.Text
                instProd.producto = CMBProducto.SelectedValue
                instProd.deposito = CMBDeposito.SelectedValue
                listaInstProds.Add(instProd)
            Next

            Dim mensaje = Dispatcher(Of String, GuardarIngresoStockAccion).execute(New GuardarIngresoStockAccion(CType(TXTId.Text, Integer), Sesion.obtenerInstancia().usuarioActual.empleados.Item(0), CMBDeposito.SelectedValue, CMBProveedor.SelectedValue, CMBProducto.SelectedValue, listaInstProds, DTPFecha.Value, TXTPrecioCompra.Text, TXTPrecioVenta.Text, buffer, extension, CType(TXTPedidoDeReposicionId.Text, Integer), CType(TXTCantidad.Text, Integer)))
            LBLMensaje.Text = mensaje

        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim exepcion As New StockException(exe, Me.GetType.ToString)
            MessageBox.Show(exepcion.mensaje)
        End Try

    End Sub

    Private Sub CMBProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProducto.SelectedIndexChanged
        Try
            Dim prod As Producto = DirectCast(CMBProducto.SelectedValue, Producto)
            CMBProveedor.DataSource = prod.proveedores
            CMBProveedor.DisplayMember = "nombre"

            TXTPrecioCompra.Text = prod.precioCompra
            TXTPrecioVenta.Text = prod.precioVenta
        Catch ex As Exception
            Dim exe As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(exe.mensaje)
        End Try

    End Sub

    Private Sub BTNEliminarIngreso_Click(sender As Object, e As EventArgs) Handles BTNEliminarIngreso.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarIngresoStockAccion).execute(New EliminarIngresoStockAccion(TXTId.Text))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNBscarIngreso_Click(sender As Object, e As EventArgs) Handles BTNBscarIngreso.Click
        Try
            Dim ingreso As StockModelo.IngresoDeStock = Dispatcher(Of StockModelo.IngresoDeStock, BuscarIngresoDeStockAccion).execute(New BuscarIngresoDeStockAccion(TXTId.Text, CMBDeposito.SelectedValue, DTPFecha.Value, CMBProducto.SelectedValue))
            If ingreso Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_INGRESO)), Me.GetType.ToString)
            End If
            DGVInstProdAssoc.DataSource = ingreso.instanciasDeProducto
            TXTCantidad.Text = ingreso.instanciasDeProducto.Count
            TXTId.Text = ingreso.id
            If ingreso.instanciasDeProducto.Count > 0 Then
                TXTPrecioCompra.Text = ingreso.instanciasDeProducto.Item(0).precioCompra
                TXTPrecioVenta.Text = ingreso.instanciasDeProducto.Item(0).precioVenta
            End If

            Dim elem As Producto
            For i As Integer = 0 To CMBProducto.Items.Count - 1
                elem = DirectCast(CMBProducto.Items.Item(i), Producto)
                If elem.id = ingreso.producto.id Then
                    CMBProducto.SelectedIndex = i
                    Exit For
                End If
            Next

            Dim delem As Deposito
            For i As Integer = 0 To CMBDeposito.Items.Count - 1
                delem = DirectCast(CMBDeposito.Items.Item(i), Deposito)
                If delem.id = ingreso.deposito.id Then
                    CMBDeposito.SelectedIndex = i
                    Exit For
                End If
            Next

            Dim prov As Proveedor
            For i As Integer = 0 To CMBProveedor.Items.Count - 1
                prov = DirectCast(CMBProveedor.Items.Item(i), Proveedor)
                If prov.id = ingreso.proveedor.id Then
                    CMBProveedor.SelectedIndex = i
                    Exit For
                End If
            Next

            Me.factura = ingreso.factura
            Me.extension = ingreso.extensionFactura
            Me.comprobante = ingreso.comprobante

            DTPFecha.Value = ingreso.fecha
            TXTPedidoDeReposicionId.Text = ingreso.pedidoDeReposicion.id
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub BTNDescargarComprobanteIngreso_Click(sender As Object, e As EventArgs) Handles BTNDescargarComprobanteIngreso.Click
        Try
            Dispatcher(Of String, AbrirComprobanteIngresoAccion).execute(New AbrirComprobanteIngresoAccion(Me.comprobante))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub BTNDescargarFacturaProveedor_Click(sender As Object, e As EventArgs) Handles BTNDescargarFacturaProveedor.Click
        If FBDDescargarFactura.ShowDialog() = DialogResult.OK Then
            Dim path As String = FBDDescargarFactura.SelectedPath & "/factura" & extension
            Dispatcher(Of String, DescargarArchivoAccion).execute(New DescargarArchivoAccion(path, Me.factura))
        End If
    End Sub

    Private Sub BTNLimpiarIngreso_Click(sender As Object, e As EventArgs) Handles BTNLimpiarIngreso.Click
        LBLMensaje.Text = ""
        TXTCantidad.Text = 0
        TXTFacturaProveedor.Text = ""
        TXTId.Text = 0
        DTPFecha.Value = Date.Now
        DGVInstProdAssoc.DataSource = New List(Of InstanciaDeProducto)
        Try
            CMBProducto.DataSource = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBProducto.DisplayMember = "nombre"
            CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBDeposito.DisplayMember = "nomber"
            CMBProveedor.DataSource = Dispatcher(Of List(Of Proveedor), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBProveedor.DisplayMember = "nombre"
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNGestionarPedidosDeReposicion_Click(sender As Object, e As EventArgs) Handles BTNGestionarPedidosDeReposicion.Click
        Dim pedidos As New GestionarPedidoDeReposicion
        pedidos.ShowDialog()
    End Sub
End Class