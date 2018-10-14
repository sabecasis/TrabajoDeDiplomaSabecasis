Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class GestionarProveedores

    Private Sub GestionarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBEstadoProveedor.DataSource = Dispatcher(Of List(Of EstadoProveedor), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        CMBEstadoProveedor.DisplayMember = "estado"
        CMBPaisProveedor.DataSource = Dispatcher(Of List(Of Pais), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        CMBPaisProveedor.DisplayMember = "pais"
        TXTIdProveedor.Text = 0
        TXTPisoProveedor.Text = 0
    End Sub

    Private Sub BTNGuardarProveedor_Click(sender As Object, e As EventArgs) Handles BTNGuardarProveedor.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, GuardarProveedorAccion).execute(New GuardarProveedorAccion(TXTIdProveedor.Text, TXTNombreProveedor.Text, TXTCuitProveedor.Text, CMBEstadoProveedor.SelectedValue, TXTCalleProveedor.Text, TXTNroPuertaProveedor.Text, TXTPisoProveedor.Text, TXTDepartamentoProveedor.Text, TXTEmailProveedor.Text, CMBLocalidadProveedor.SelectedValue, TXTTelefonoProveedor.Text))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub limpiar()
        TXTCalleProveedor.Text = ""
        TXTCuitProveedor.Text = ""
        TXTDepartamentoProveedor.Text = ""
        TXTEmailProveedor.Text = ""
        TXTIdProveedor.Text = 0
        TXTNombreProveedor.Text = ""
        TXTNroPuertaProveedor.Text = ""
        TXTPisoProveedor.Text = 0
        TXTTelefonoProveedor.Text = ""
    End Sub

    Private Sub BTNLimpiarPantallaProveedor_Click(sender As Object, e As EventArgs) Handles BTNLimpiarPantallaProveedor.Click
        limpiar()
    End Sub

    Private Sub CMBPaisProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPaisProveedor.SelectedIndexChanged
        CMBProvinciaProveedor.DataSource = TryCast(CMBPaisProveedor.SelectedValue, Pais).provincias
        CMBProvinciaProveedor.DisplayMember = "provincia"
    End Sub

    Private Sub CMBProvinciaProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProvinciaProveedor.SelectedIndexChanged
        CMBLocalidadProveedor.DataSource = TryCast(CMBProvinciaProveedor.SelectedValue, Provincia).localidades
        CMBLocalidadProveedor.DisplayMember = "localidad"
    End Sub

    Private Sub BTNBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BTNBuscarProveedor.Click
        Try
            Dim oProveedor As Proveedor = Dispatcher(Of Proveedor, BuscarProveedorAccion).execute(New BuscarProveedorAccion(TXTIdProveedor.Text, TXTNombreProveedor.Text, TXTCuitProveedor.Text))
            If oProveedor Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_PROVEEDOR)), Me.GetType.ToString)
            End If
            TXTCalleProveedor.Text = oProveedor.contacto.calle
            TXTCuitProveedor.Text = oProveedor.cuit
            TXTDepartamentoProveedor.Text = oProveedor.contacto.departamento
            TXTEmailProveedor.Text = oProveedor.contacto.email
            TXTIdProveedor.Text = oProveedor.id
            TXTNombreProveedor.Text = oProveedor.nombre
            TXTNroPuertaProveedor.Text = oProveedor.contacto.nroPuerta
            TXTPisoProveedor.Text = oProveedor.contacto.piso
            TXTTelefonoProveedor.Text = oProveedor.contacto.telefonos.Item(0).telefono
            Dim estadoProv As EstadoProveedor
            For i As Integer = 0 To CMBEstadoProveedor.Items.Count
                estadoProv = CMBEstadoProveedor.Items.Item(i)
                If estadoProv.id = oProveedor.estado.id Then
                    CMBEstadoProveedor.SelectedIndex = i
                    Exit For
                End If
            Next

            Dim cantPaises As Integer = CMBPaisProveedor.Items.Count
            Dim paisProvisorio As Pais
            For p As Integer = 0 To cantPaises
                paisProvisorio = CMBPaisProveedor.Items.Item(p)
                If paisProvisorio.id = oProveedor.contacto.localidad.provincia.pais.id Then
                    CMBPaisProveedor.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim cantProv As Integer = CMBProvinciaProveedor.Items.Count
            Dim provProvisoria As Provincia
            For p As Integer = 0 To cantProv
                provProvisoria = CMBProvinciaProveedor.Items.Item(p)
                If provProvisoria.id = oProveedor.contacto.localidad.provincia.id Then
                    CMBProvinciaProveedor.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim cantLoc As Integer = CMBLocalidadProveedor.Items.Count
            Dim locProvisoria As Localidad
            For p As Integer = 0 To cantLoc
                locProvisoria = CMBLocalidadProveedor.Items.Item(p)
                If locProvisoria.id = oProveedor.contacto.localidad.id Then
                    CMBLocalidadProveedor.SelectedIndex = p
                    Exit For
                End If
            Next
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNEliminarProveedor_Click(sender As Object, e As EventArgs) Handles BTNEliminarProveedor.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarProveedorAccion).execute(New EliminarProveedorAccion(TXTIdProveedor.Text))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub
End Class