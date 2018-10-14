Imports StockModelo
Imports StockControladorAccion
Imports StockControlador
Imports StockControladorComando
Imports ElementosTransversales

Public Class GestionarProducto

    Private instanciasDeProductos As New List(Of InstanciaDeProducto)

    Private Sub BTNGestionarMonedas_Click(sender As Object, e As EventArgs) Handles BTNGestionarMonedas.Click
        Dim gm As New GestionarMoneda
        gm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gm As New GestionarMarca
        gm.ShowDialog()
    End Sub

    Private Sub asignarPrecioVenta()
        Try
            TXTPrecioVenta.Text = Dispatcher(Of Double, CalcularPrecioVentaAccion).execute(New CalcularPrecioVentaAccion(CMBMetodoValoracion.SelectedValue, CType(Val(TXTPrecioCompra.Text), Double), CType(Val(TXTPrecioUltimaCompra.Text), Double), CType(Val(TXTCostoEstandar.Text), Double), CMBDescGlobal.SelectedValue, CType(Val(TXTporcentajeDeGanancia.Text), Double), CType(Val(TXTPrecioDeAdquisicion.Text), Double), CType(Val(TXTCostePosecion.Text), Double), CType(Val(TXTCosteFinanciero.Text), Double), Me.instanciasDeProductos, CType(Val(TXTCantStock.Text), Integer)))
        Catch e As Exception
        End Try

    End Sub

    Private Sub GestionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Try
                Dim otAccion As New ObtenerTodosAccion()
                CMBMetodoValoracion.DataSource = Dispatcher(Of List(Of ModoValoracionProducto), ObtenerTodosAccion).execute(otAccion)
                CMBMetodoValoracion.DisplayMember = "descripcion"
                CMBDescGlobal.DataSource = Dispatcher(Of List(Of Descuento), ObtenerTodosAccion).execute(otAccion)
                CMBDescGlobal.DisplayMember = "nombre"
                CMBMoneda.DataSource = Dispatcher(Of List(Of Moneda), ObtenerTodosAccion).execute(otAccion)
                CMBMoneda.DisplayMember = "moneda"
                CMBMarca.DataSource = Dispatcher(Of List(Of Marca), ObtenerTodosAccion).execute(otAccion)
                CMBMarca.DisplayMember = "marca"
                CMBClasificProd.DataSource = Dispatcher(Of List(Of ClasificacionProducto), ObtenerTodosAccion).execute(otAccion)
                CMBClasificProd.DisplayMember = "clasificacion"
                CMBEstadoProducto.DataSource = Dispatcher(Of List(Of EstadoProducto), ObtenerTodosAccion).execute(otAccion)
                CMBEstadoProducto.DisplayMember = "estado"
                CMBMEtodoDeReposicion.DataSource = Dispatcher(Of List(Of MetodoDeReposicion), ObtenerTodosAccion).execute(otAccion)
                CMBMEtodoDeReposicion.DisplayMember = "metodo"
                CMBFamilia.DataSource = Dispatcher(Of List(Of FamiliaDeProducto), ObtenerTodosAccion).execute(otAccion)
                CMBFamilia.DisplayMember = "familia"
                cargarListaProv()
                cargarListaMatPrimas()
                LSTProvAsig.DisplayMember = "nombre"
                CHKFamilia.Checked = True
                limpiar()
            Catch exe As Exception
                Throw New StockException(exe, Me.GetType.ToString)
            End Try
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub cargarListaProv()
        Dim lista As List(Of Proveedor) = Dispatcher(Of List(Of Proveedor), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        If Not lista Is Nothing Then
            For Each prov As Proveedor In lista
                LSTProvNoAsig.Items.Add(prov)
            Next
        End If

        LSTProvNoAsig.DisplayMember = "nombre"
    End Sub

    Private Sub cargarListaMatPrimas()
        LSTMateriasAsignadas.Items.Clear()
        Dim lista As List(Of Producto) = Dispatcher(Of List(Of Producto), ObtenerTodasMateriasPrimasAccion).execute(New ObtenerTodasMateriasPrimasAccion())
        If Not lista Is Nothing Then
            For Each prov As Producto In lista
                LSTMateriasAsignadas.Items.Add(prov)
            Next
        End If

        LSTMateriasAsignadas.DisplayMember = "nombre"
    End Sub

    Private Sub BTNAsignar_Click(sender As Object, e As EventArgs) Handles BTNAsignar.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ASIGNAR)
            For Each item As Proveedor In LSTProvNoAsig.SelectedItems
                LSTProvAsig.Items.Add(item)

            Next
            LSTProvAsig.Refresh()
            LSTProvAsig.Update()

            For Each item As Proveedor In LSTProvAsig.Items
                If LSTProvNoAsig.Items.Contains(item) Then
                    LSTProvNoAsig.Items.Remove(item)

                End If


            Next
            LSTProvNoAsig.Refresh()
            LSTProvNoAsig.Update()

        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNDesasignar_Click(sender As Object, e As EventArgs) Handles BTNDesasignar.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.DESASIGNAR)
            For Each item As Proveedor In LSTProvAsig.SelectedItems
                LSTProvNoAsig.Items.Add(item)

            Next
            LSTProvNoAsig.Refresh()
            LSTProvNoAsig.Update()

            For Each item As Proveedor In LSTProvNoAsig.Items
                If LSTProvAsig.Items.Contains(item) Then
                    LSTProvAsig.Items.Remove(item)

                End If


            Next
            LSTProvAsig.Refresh()
            LSTProvAsig.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BTNAgregarProdARegla_Click(sender As Object, e As EventArgs) Handles BTNAgregarProdARegla.Click
        Dim regla As String = TXTReglaDeComp.Text
        If regla = "" Then
            regla = "1*" & CType(LSTMateriasAsignadas.SelectedItems.Item(0), Producto).id
        Else
            regla = regla & " + 1*" & CType(LSTMateriasAsignadas.SelectedItems.Item(0), Producto).id
        End If

        TXTReglaDeComp.Text = regla
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Try
            Dim oProducto As Producto = Dispatcher(Of Producto, BuscarProductoAccion).execute(New BuscarProductoAccion(TXTIdProd.Text, TXTNombre.Text))
            If oProducto Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_PRODUCTO)), Me.GetType.ToString)
            End If

            TXTIdProd.Text = oProducto.id
            TXTCosteFinanciero.Text = oProducto.costeFinanciero
            TXTCostePosecion.Text = oProducto.costeDePosecion
            TXTDescr.Text = oProducto.descripcion
            TXTNombre.Text = oProducto.nombre
            TXTporcentajeDeGanancia.Text = oProducto.porcentajeGanancia
            TXTPrecioCompra.Text = oProducto.precioCompra
            TXTPrecioVenta.Text = oProducto.precioVenta
            TXTPrecioDeAdquisicion.Text = oProducto.precioCosteAdquisicion
            TXTReglaDeComp.Text = oProducto.reglaDeComposicion
            TXTUnidad.Text = oProducto.unidad
            CHKPedidoAutomatico.Checked = oProducto.pedidoAutomatico

            For Each estado As EstadoProducto In CMBEstadoProducto.Items
                If estado.id = oProducto.estado.id Then
                    CMBEstadoProducto.SelectedItem = estado
                End If
            Next

            For Each marca As Marca In CMBMarca.Items
                If marca.id = oProducto.marca.id Then
                    CMBMarca.SelectedItem = marca
                End If
            Next


            For Each moneda As Moneda In CMBMoneda.Items
                If moneda.id = oProducto.moneda.id Then
                    CMBMoneda.SelectedItem = moneda
                End If
            Next
            CMBClasificProd.SelectedIndex = oProducto.clasificacion.id - 1


            For Each metodo As ModoValoracionProducto In CMBMetodoValoracion.Items
                If oProducto.metodoDeValoracion.id = metodo.id Then
                    CMBMetodoValoracion.SelectedItem = metodo
                End If
            Next

            For i As Integer = 0 To CMBDescGlobal.Items.Count - 1
                If DirectCast(CMBDescGlobal.Items.Item(i), Descuento).id = oProducto.descuento.id Then
                    CMBDescGlobal.SelectedIndex = i
                    Exit For
                End If
            Next

            For Each prov As Proveedor In oProducto.proveedores
                LSTProvAsig.Items.Add(prov)
                For Each item As Proveedor In LSTProvNoAsig.Items
                    If item.id = prov.id Then
                        LSTProvNoAsig.Items.Remove(item)
                        Exit For
                    End If
                Next
            Next

            For i As Integer = 0 To CMBMEtodoDeReposicion.Items.Count - 1
                If DirectCast(CMBMEtodoDeReposicion.Items.Item(i), MetodoDeReposicion).id = oProducto.metodoDeReposicion.id Then
                    CMBMEtodoDeReposicion.SelectedIndex = i
                    Exit For
                End If
            Next

            For i As Integer = 0 To CMBFamilia.Items.Count - 1
                If DirectCast(CMBFamilia.Items.Item(i), FamiliaDeProducto).id = oProducto.familia.id Then
                    CMBFamilia.SelectedIndex = i
                    Exit For
                End If
            Next

            TXTPuntoMaxReposicion.Text = oProducto.maxStock
            TXTPuntoMinReposicion.Text = oProducto.minStock
            TXTClicloDeReposicion.Text = oProducto.ciclo

            TXTCantStock.Text = oProducto.instanciasDeProductoActivas.Count

            Me.instanciasDeProductos = oProducto.instanciasDeProductoActivas
       
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch excep As Exception
            Dim excepcion As New StockException(excep, Me.Name.ToString)
            MessageBox.Show(excep.Message)
        End Try
    End Sub

    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        Try
            Dim lista As New List(Of Proveedor)
            For i As Integer = 0 To LSTProvAsig.Items.Count - 1
                lista.Add(LSTProvAsig.Items.Item(i))
            Next
            Dim familia As New FamiliaDeProducto
            If CHKFamilia.Checked = False Then
                familia = CMBFamilia.SelectedValue
            End If
            Dim mensaje As String = Dispatcher(Of String, GuardarProductoAccion).execute(New GuardarProductoAccion(CType(Val(TXTPrecioUltimaCompra.Text), Double), TXTIdProd.Text, TXTNombre.Text, TXTDescr.Text, TXTPrecioCompra.Text, TXTPrecioVenta.Text, CMBMoneda.SelectedValue, CMBMarca.SelectedValue, CMBEstadoProducto.SelectedValue, CMBDescGlobal.SelectedValue, CMBClasificProd.SelectedValue, TXTReglaDeComp.Text, lista, TXTporcentajeDeGanancia.Text, TXTPrecioDeAdquisicion.Text, TXTCostePosecion.Text, TXTCosteFinanciero.Text, CMBMetodoValoracion.SelectedValue, CType(TXTPuntoMinReposicion.Text, Integer), CType(TXTPuntoMaxReposicion.Text, Integer), CMBMEtodoDeReposicion.SelectedValue, CType(TXTClicloDeReposicion.Text, Integer), familia, TXTUnidad.Text, CHKPedidoAutomatico.Checked))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarProductoAccion).execute(New EliminarProductoAccion(TXTIdProd.Text))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub limpiar()
        TXTCantStock.Text = 0
        TXTCosteFinanciero.Text = 0
        TXTCostePosecion.Text = 0
        TXTDescr.Text = ""
        TXTIdProd.Text = 0
        TXTNombre.Text = ""
        TXTporcentajeDeGanancia.Text = 0
        TXTPrecioCompra.Text = 0
        TXTPrecioDeAdquisicion.Text = 0
        TXTPrecioVenta.Text = 0
        TXTReglaDeComp.Text = ""
        TXTPrecioUltimaCompra.Text = 0
        TXTCostoEstandar.Text = 0
        LSTProvAsig.Items.Clear()
        LSTProvNoAsig.Items.Clear()
        cargarListaProv()
        CMBDescGlobal.SelectedIndex = 0
        CMBMEtodoDeReposicion.SelectedIndex = 0
        TXTPuntoMaxReposicion.Text = 0
        TXTPuntoMinReposicion.Text = 0
        TXTClicloDeReposicion.Text = 0
        TXTUnidad.Text = ""
        cargarListaMatPrimas()
    End Sub


    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiar.Click
        limpiar()
    End Sub

    Private Sub TXTPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles TXTPrecioCompra.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTCostoEstandar_TextChanged(sender As Object, e As EventArgs) Handles TXTCostoEstandar.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTCantStock_TextChanged(sender As Object, e As EventArgs) Handles TXTCantStock.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub CMBDescGlobal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDescGlobal.SelectedIndexChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTporcentajeDeGanancia_TextChanged(sender As Object, e As EventArgs) Handles TXTporcentajeDeGanancia.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTPrecioDeAdquisicion_TextChanged(sender As Object, e As EventArgs) Handles TXTPrecioDeAdquisicion.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTCostePosecion_TextChanged(sender As Object, e As EventArgs) Handles TXTCostePosecion.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTCosteFinanciero_TextChanged(sender As Object, e As EventArgs) Handles TXTCosteFinanciero.TextChanged
        asignarPrecioVenta()
    End Sub

    Private Sub CMBMetodoValoracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMetodoValoracion.SelectedIndexChanged
        asignarPrecioVenta()
    End Sub

    Private Sub TXTReglaDeComp_TextChanged(sender As Object, e As EventArgs) Handles TXTReglaDeComp.TextChanged
        Try
            Try
                If Not "".Equals(TXTReglaDeComp.Text) Then
                    TXTCostoEstandar.Text = Dispatcher(Of Double, CalcularCostoEstandarAccion).execute(New CalcularCostoEstandarAccion(TXTReglaDeComp.Text))
                    TXTPrecioCompra.Text = TXTCostoEstandar.Text
                Else
                    TXTCostoEstandar.Text = 0
                    TXTPrecioCompra.Text = 0
                End If
            Catch exe As Exception
                'No hacer nada, puede ser un estado intermedio
            End Try

        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub BTNCrearFamiliaDeProducto_Click(sender As Object, e As EventArgs) Handles BTNCrearFamiliaDeProducto.Click
        Dim famProd As New GestionarFamiliaDeProductos
        famProd.ShowDialog()
    End Sub

    Private Sub CHKFamilia_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFamilia.CheckedChanged
        If CHKFamilia.Checked = True Then
            CMBFamilia.Enabled = False
        Else
            CMBFamilia.Enabled = True
        End If
    End Sub


End Class