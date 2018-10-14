Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockControladorComando

Public Class EgresoDeStock

    Private instanciasDeProductoFiltradas As New List(Of InstanciaDeProducto)
    Private instanciasIntermedias As New List(Of InstanciaDeProducto)
    Private comprobante As Byte()

    Private Sub EgresoDeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Public Sub limpiar()
        Try
            Dim oTodos As New ObtenerTodosAccion()
            TXTIdEgreso.Text = 0
            TXTCantidad.Text = 0
            TXTMotivo.Text = ""
            DTPFechaEgreso.Value = Date.Now
            LSTInstanciasASeleccionarEgreso.Enabled = False
            BTNSeleccionarInstanciaEgreso.Enabled = False
            Dim listaProductos As List(Of Producto) = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(oTodos)
            CMBProducto.DataSource = listaProductos
            CMBProducto.DisplayMember = "nombre"
            CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(oTodos)
            CMBDeposito.DisplayMember = "nomber"
            LSTInstanciaEgresar.Items.Clear()
            LSTInstanciasASeleccionarEgreso.Items.Clear()
            Me.instanciasDeProductoFiltradas = New List(Of InstanciaDeProducto)
            Me.instanciasIntermedias = New List(Of InstanciaDeProducto)
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub CHKSeleccionarEspecificas_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSeleccionarEspecificas.CheckedChanged
        Try
            If CHKSeleccionarEspecificas.Checked Then
                LSTInstanciasASeleccionarEgreso.Enabled = True
                BTNSeleccionarInstanciaEgreso.Enabled = True
                llenarListInstanciasAEgresar()
            Else
                LSTInstanciasASeleccionarEgreso.Enabled = False
                BTNSeleccionarInstanciaEgreso.Enabled = False
                instanciasDeProductoFiltradas = New List(Of InstanciaDeProducto)
                instanciasIntermedias = New List(Of InstanciaDeProducto)
                LSTInstanciasASeleccionarEgreso.Items.Clear()
                LSTInstanciaEgresar.Items.Clear()
                TXTCantidad.Text = 0

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub llenarListInstanciasAEgresar()
        Try
            CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerDepositosPorProductoAccion).execute(New ObtenerDepositosPorProductoAccion(DirectCast(CMBProducto.SelectedValue, Producto).id))
            CMBDeposito.DisplayMember = "nomber"
            Try
                If instanciasDeProductoFiltradas.Count = 0 And instanciasIntermedias.Count = 0 Then
                    instanciasDeProductoFiltradas = Dispatcher(Of List(Of InstanciaDeProducto), ObtenerTodasLasInstanciasProductoParaEgresoAccion).execute(New ObtenerTodasLasInstanciasProductoParaEgresoAccion(DirectCast(CMBProducto.SelectedValue, Producto).id, DirectCast(CMBDeposito.SelectedValue, Deposito).id))
                End If

            Catch ex As Exception
                'No hacer nada, puede ser un estado intermedio
            End Try

            If CHKSeleccionarEspecificas.Checked Then
                LSTInstanciasASeleccionarEgreso.Items.Clear()
                For Each item As InstanciaDeProducto In instanciasDeProductoFiltradas
                    LSTInstanciasASeleccionarEgreso.Items.Add(item)
                Next

            Else
                If CType(TXTCantidad.Text, Integer) <> 0 Then
                    If instanciasDeProductoFiltradas.Count >= CType(TXTCantidad.Text, Integer) Then
                        instanciasIntermedias = CalculadorInstanciasAEgresar.calcular(instanciasDeProductoFiltradas, DirectCast(CMBProducto.SelectedValue, Producto).metodoDeValoracion, CType(TXTCantidad.Text, Integer))
                        LSTInstanciaEgresar.Items.Clear()
                        For Each inst As InstanciaDeProducto In instanciasIntermedias
                            LSTInstanciaEgresar.Items.Add(inst)
                        Next

                    Else
                        MessageBox.Show(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_HAY_SUFICIENTES_ARTICULOS))
                    End If

                End If
            End If
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch exe1 As Exception
            'puede ocurrir durante la inicializacion del formulario
        End Try

    End Sub

    Private Sub CMBProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProducto.SelectedIndexChanged
        Try
            llenarListInstanciasAEgresar()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BTNLimpiarEgreso_Click(sender As Object, e As EventArgs) Handles BTNLimpiarEgreso.Click
        limpiar()
    End Sub

    Private Sub TXTCantidad_TextChanged(sender As Object, e As EventArgs) Handles TXTCantidad.TextChanged
        Try
            llenarListInstanciasAEgresar()
            If TXTCantidad.Text.Equals("0") Then
                LSTInstanciaEgresar.Items.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CMBDeposito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDeposito.SelectedIndexChanged
        Try
            llenarListInstanciasAEgresar()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BTNSeleccionarInstanciaEgreso_Click(sender As Object, e As EventArgs) Handles BTNSeleccionarInstanciaEgreso.Click
        Try
            Dim item As InstanciaDeProducto = LSTInstanciasASeleccionarEgreso.SelectedItem
            Dim posicion As Integer = 0
            For i As Integer = 0 To instanciasDeProductoFiltradas.Count - 1
                If item.id = instanciasDeProductoFiltradas.Item(i).id Then
                    posicion = i
                    Exit For
                End If
            Next
            instanciasDeProductoFiltradas.RemoveAt(posicion)
            instanciasIntermedias.Add(item)
            LSTInstanciaEgresar.Items.Clear()
            For Each inst As InstanciaDeProducto In instanciasIntermedias
                LSTInstanciaEgresar.Items.Add(inst)
            Next
            LSTInstanciaEgresar.Update()
            LSTInstanciaEgresar.Refresh()
            LSTInstanciasASeleccionarEgreso.Items.Clear()
            For Each inst As InstanciaDeProducto In instanciasDeProductoFiltradas
                LSTInstanciasASeleccionarEgreso.Items.Add(inst)
            Next

            LSTInstanciasASeleccionarEgreso.Update()
            LSTInstanciasASeleccionarEgreso.Refresh()
            TXTCantidad.Text = CType(TXTCantidad.Text, Integer) + 1
        Catch exe As Exception
            MessageBox.Show(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
        End Try

    End Sub

    Private Sub BTNQuitarInstPRodEgresar_Click(sender As Object, e As EventArgs) Handles BTNQuitarInstPRodEgresar.Click
        Try
            Dim item As InstanciaDeProducto = LSTInstanciaEgresar.SelectedItem
            Dim posicion As Integer = 0
            For i As Integer = 0 To instanciasIntermedias.Count - 1
                If item.id = instanciasIntermedias.Item(i).id Then
                    posicion = i
                    Exit For
                End If
            Next
            instanciasIntermedias.RemoveAt(posicion)
            instanciasDeProductoFiltradas.Add(item)

            LSTInstanciaEgresar.Items.Clear()
            For Each inst As InstanciaDeProducto In instanciasIntermedias
                LSTInstanciaEgresar.Items.Add(inst)
            Next
            LSTInstanciaEgresar.Update()
            LSTInstanciasASeleccionarEgreso.Items.Clear()
            For Each inst As InstanciaDeProducto In instanciasDeProductoFiltradas
                LSTInstanciasASeleccionarEgreso.Items.Add(inst)
            Next

            LSTInstanciasASeleccionarEgreso.Update()
            TXTCantidad.Text = CType(TXTCantidad.Text, Integer) - 1
        Catch exe As Exception
            MessageBox.Show(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
        End Try

    End Sub

    Private Sub BTNGuardarEgreso_Click(sender As Object, e As EventArgs) Handles BTNGuardarEgreso.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, GuardarEgresoDeStockAccion).execute(New GuardarEgresoDeStockAccion(CType(TXTIdEgreso.Text, Integer), TXTMotivo.Text, DTPFechaEgreso.Value, CType(TXTCantidad.Text, Integer), CMBProducto.SelectedValue, CMBDeposito.SelectedValue, instanciasIntermedias, Sesion.obtenerInstancia.usuarioActual.empleados.Item(0)))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNBuscarEgreso_Click(sender As Object, e As EventArgs) Handles BTNBuscarEgreso.Click
        Try
            Dim oEgreso As StockModelo.EgresoDeStock = Dispatcher(Of StockModelo.EgresoDeStock, BuscarEgresoStockAccion).execute(New BuscarEgresoStockAccion(CType(TXTIdEgreso.Text, Integer)))
            If oEgreso Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_EGRESO)), Me.GetType.ToString)
            End If
            Me.instanciasIntermedias = oEgreso.listaInstanciasDeProducto
            Me.instanciasDeProductoFiltradas = oEgreso.listaInstanciasDeProducto
            TXTIdEgreso.Text = oEgreso.id
            TXTCantidad.Text = oEgreso.cantidad
            TXTMotivo.Text = oEgreso.motivo
            DTPFechaEgreso.Value = oEgreso.fecha

            For i As Integer = 0 To CMBProducto.Items.Count - 1
                If DirectCast(CMBProducto.Items.Item(i), Producto).id = oEgreso.producto.id Then
                    CMBProducto.SelectedIndex = i
                    Exit For
                End If
            Next

            For i As Integer = 0 To CMBDeposito.Items.Count - 1
                If DirectCast(CMBDeposito.Items.Item(i), Deposito).id = oEgreso.deposito.id Then
                    CMBDeposito.SelectedIndex = i
                    Exit For
                End If
            Next

            Me.comprobante = oEgreso.comprobante

        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNEliminarEgreso_Click(sender As Object, e As EventArgs) Handles BTNEliminarEgreso.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, EliminarEgresoDeStockAccion).execute(New EliminarEgresoDeStockAccion(CType(TXTIdEgreso.Text, Integer)))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNObtenerComproabanteEgreso_Click(sender As Object, e As EventArgs) Handles BTNObtenerComproabanteEgreso.Click
        Try
            Dispatcher(Of String, AbrirComprobanteIngresoAccion).execute(New AbrirComprobanteIngresoAccion(Me.comprobante))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub
End Class