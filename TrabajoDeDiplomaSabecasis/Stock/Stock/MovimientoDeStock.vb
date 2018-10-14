Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class MovimientoDeStock

    Private listaInstanciasFiltradas As New List(Of InstanciaDeProducto)
    Private listaIntermedias As New List(Of InstanciaDeProducto)
    Private comprobante As Byte()
    Private Sub MovimientoDeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub limpiar()
        Try
            Dim oAccion As New ObtenerTodosAccion()
            CMBProducto.DataSource = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(oAccion)
            CMBProducto.DisplayMember = "nombre"
            CMBDeposito1.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(oAccion)
            CMBDeposito1.DisplayMember = "nomber"
            CMBDeposito2.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(oAccion)
            CMBDeposito2.DisplayMember = "nomber"
            LSTInstanciaAMover.Items.Clear()
            CHKAceptarMovimiento.Checked = False
            CHKMoverInstanciaEspecifica.Checked = False
            CMBEstadoMovimiento.DataSource = Dispatcher(Of List(Of EstadoInstanciaProducto), ObtenerTodosAccion).execute(oAccion)
            CMBEstadoMovimiento.DisplayMember = "estado"
            For i As Integer = 0 To CMBEstadoMovimiento.Items.Count - 1
                If DirectCast(CMBEstadoMovimiento.Items.Item(i), EstadoInstanciaProducto).id = 5 Then
                    CMBEstadoMovimiento.SelectedIndex = i
                End If
            Next
            TXTCantidad.Text = 0
            TXTId.Text = 0
            TXTMotivo.Text = ""
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        End Try

    End Sub

    Private Sub llenarListInstancias()
        Try
            If TXTCantidad.Text.Equals("0") Then
                listaInstanciasFiltradas = Dispatcher(Of List(Of InstanciaDeProducto), ObtenerTodasLasInstanciasProductoParaEgresoAccion).execute(New ObtenerTodasLasInstanciasProductoParaEgresoAccion(DirectCast(CMBProducto.SelectedValue, Producto).id, DirectCast(CMBDeposito1.SelectedValue, Deposito).id))
            End If

            If CHKMoverInstanciaEspecifica.Checked = False Then
                If Not TXTCantidad.Text.Equals("0") Then
                    If listaInstanciasFiltradas.Count <= CType(TXTCantidad.Text, Integer) And CType(TXTId.Text, Integer) = 0 Then
                        MessageBox.Show(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_HAY_SUFICIENTES_ARTICULOS))
                    End If
                    LSTInstanciaAMover.Items.Clear()
                    listaIntermedias = listaInstanciasFiltradas.GetRange(0, CType(TXTCantidad.Text, Integer))
                    For Each item As InstanciaDeProducto In listaIntermedias
                        LSTInstanciaAMover.Items.Add(item)
                    Next
                End If
            Else
                LSTInstanciaAMover.Items.Clear()
                For Each item As InstanciaDeProducto In listaInstanciasFiltradas
                    LSTInstanciaAMover.Items.Add(item)
                Next
            End If

        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            'no hacer nada, es error de modificacion
        End Try

    End Sub

    Private Sub CMBProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProducto.SelectedIndexChanged
        llenarListInstancias()

     
    End Sub

    Private Sub CMBDeposito1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDeposito1.SelectedIndexChanged
        llenarListInstancias()
    End Sub


    Private Sub TXTCantidad_TextChanged(sender As Object, e As EventArgs) Handles TXTCantidad.TextChanged
        llenarListInstancias()
    End Sub

    Private Sub CHKMoverInstanciaEspecifica_CheckedChanged(sender As Object, e As EventArgs) Handles CHKMoverInstanciaEspecifica.CheckedChanged
        llenarListInstancias()
    End Sub

    Private Sub CHKAceptarMovimiento_CheckedChanged(sender As Object, e As EventArgs) Handles CHKAceptarMovimiento.CheckedChanged
        Try
            If CHKAceptarMovimiento.Checked = True Then
                If DirectCast(CMBEstadoMovimiento.SelectedValue, EstadoInstanciaProducto).id = 5 And Not TXTId.Text.Equals("0") Then
                    For i As Integer = 0 To CMBEstadoMovimiento.Items.Count - 1
                        If DirectCast(CMBEstadoMovimiento.Items.Item(i), EstadoInstanciaProducto).id = 1 Then
                            CMBEstadoMovimiento.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
            Else
                If listaIntermedias.Count > 0 Then
                    If listaIntermedias.Item(0).estado.id = 5 Then
                        For i As Integer = 0 To CMBEstadoMovimiento.Items.Count - 1
                            If DirectCast(CMBEstadoMovimiento.Items.Item(i), EstadoInstanciaProducto).id = 5 Then
                                CMBEstadoMovimiento.SelectedIndex = i
                                Exit For
                            End If
                        Next
                    End If
                End If
            End If


                DTPFechaAceptacion.Value = Date.Now
        Catch ex As Exception
            Dim excepcion As New StockException(ex, Me.GetType.ToString)
        End Try


    End Sub

    Private Sub BTNLimpiarMovimiento_Click(sender As Object, e As EventArgs) Handles BTNLimpiarMovimiento.Click
        limpiar()
    End Sub

    Private Sub BTNGuardarMovimiento_Click(sender As Object, e As EventArgs) Handles BTNGuardarMovimiento.Click
        Try
            If CHKMoverInstanciaEspecifica.Checked = True Then
                listaIntermedias = New List(Of InstanciaDeProducto)
                listaIntermedias.Add(LSTInstanciaAMover.SelectedValue)
            End If
            Dim fechaAceptacion As Date
            If CHKAceptarMovimiento.Checked = True Then
                fechaAceptacion = DTPFechaAceptacion.Value
                For Each inst As InstanciaDeProducto In listaIntermedias
                    inst.deposito.id = CType(CMBDeposito2.SelectedValue, Deposito).id
                    inst.estado.id = 1
                Next
            Else
                fechaAceptacion = Nothing
            End If
            LBLMensaje.Text = Dispatcher(Of String, GuardarMovimientoDeStockAccion).execute(New GuardarMovimientoDeStockAccion(CType(TXTId.Text, Integer), TXTMotivo.Text, CType(TXTCantidad.Text, Integer), DTPFecha.Value, CMBProducto.SelectedValue, CMBDeposito1.SelectedValue, CMBDeposito2.SelectedValue, listaIntermedias, fechaAceptacion))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNBuscarMovimiento_Click(sender As Object, e As EventArgs) Handles BTNBuscarMovimiento.Click
        Try
            Dim oMovimiento As StockModelo.MovimientoDeStock = Dispatcher(Of StockModelo.MovimientoDeStock, BuscarMovimientoDeStockAccion).execute(New BuscarMovimientoDeStockAccion(CType(TXTId.Text, Integer)))
            If oMovimiento Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_MOVIMIENTO)), Me.GetType.ToString)
            End If
            TXTId.Text = oMovimiento.id
            DTPFecha.Value = oMovimiento.fecha
            TXTMotivo.Text = oMovimiento.motivo
            Me.comprobante = oMovimiento.comprobante
            Me.listaInstanciasFiltradas = oMovimiento.listaInstancias
            Me.listaIntermedias = oMovimiento.listaInstancias
            TXTCantidad.Text = oMovimiento.cantidad

            For i As Integer = 0 To CMBProducto.Items.Count - 1
                If DirectCast(CMBProducto.Items.Item(i), Producto).id = oMovimiento.producto.id Then
                    CMBProducto.SelectedIndex = i
                    Exit For
                End If
            Next

            For i As Integer = 0 To CMBDeposito1.Items.Count - 1
                If DirectCast(CMBDeposito1.Items.Item(i), Deposito).id = oMovimiento.depositoOrigen.id Then
                    CMBDeposito1.SelectedIndex = i
                    Exit For
                End If
            Next

            For i As Integer = 0 To CMBDeposito2.Items.Count - 1
                If DirectCast(CMBDeposito2.Items.Item(i), Deposito).id = oMovimiento.depositoDestino.id Then
                    CMBDeposito2.SelectedIndex = i
                    Exit For
                End If
            Next

            If Me.listaIntermedias.Count > 0 Then
                If Me.listaIntermedias.Item(0).estado.id = 1 Then
                    For i As Integer = 0 To CMBEstadoMovimiento.Items.Count - 1
                        If DirectCast(CMBEstadoMovimiento.Items.Item(i), EstadoInstanciaProducto).id = Me.listaIntermedias.Item(0).estado.id Then
                            CMBEstadoMovimiento.SelectedIndex = i
                            Exit For
                        End If
                    Next
                    DTPFechaAceptacion.Value = oMovimiento.fechaAceptacion
                End If
            End If
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNDescargarComprobanteDeMovimiento_Click(sender As Object, e As EventArgs) Handles BTNDescargarComprobanteDeMovimiento.Click
        Try
            Dispatcher(Of String, AbrirComprobanteIngresoAccion).execute(New AbrirComprobanteIngresoAccion(Me.comprobante))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNEliminarMovimiento_Click(sender As Object, e As EventArgs) Handles BTNEliminarMovimiento.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, EliminarMovimientoDeStockAccion).execute(New EliminarMovimientoDeStockAccion(CType(TXTId.Text, Integer), CMBDeposito1.SelectedValue))
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try

    End Sub
End Class