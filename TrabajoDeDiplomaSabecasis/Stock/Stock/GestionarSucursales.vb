Imports StockModelo
Imports StockControlador
Imports StockControladorAccion
Imports StockControladorComando
Imports ElementosTransversales

Public Class GestionarSucursales

    Private Sub GestionarSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBPaisSucursal.DataSource = Dispatcher(Of List(Of Pais), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        CMBPaisSucursal.DisplayMember = "pais"
        Dim lista As List(Of Deposito) = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        For Each dp As Deposito In lista
            LSTDepositosNoAsignados.Items.Add(dp)
        Next
        LSTDepositosAsignados.DisplayMember = "nomber"
        LSTDepositosNoAsignados.DisplayMember = "nomber"
        CMBEstado.DataSource = Dispatcher(Of List(Of EstadoSucursal), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        CMBEstado.DisplayMember = "estado"
        TXTPisoSucursal.Text = 0
        TXTIdSucursal.Text = 0
    End Sub

    Private Sub LSTDepositosNoAsignados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSTDepositosNoAsignados.SelectedIndexChanged
        Try
            Dim oDeposito As Deposito = LSTDepositosNoAsignados.SelectedItem
            If Not oDeposito Is Nothing Then
                TXTCalleDeposito.Text = oDeposito.contacto.calle
                TXTDepartamentoDeposito.Text = oDeposito.contacto.departamento
                TXTLocalidadDeposito.Text = oDeposito.contacto.localidad.localidad
                TXTNroPuertaDeposito.Text = oDeposito.contacto.nroPuerta
                TXTPaisDeposito.Text = oDeposito.contacto.localidad.provincia.pais.pais
                TXTProvinciaDeposito.Text = oDeposito.contacto.localidad.provincia.provincia
                TXTPisoDeposito.Text = oDeposito.contacto.piso
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTNDesasignar_Click(sender As Object, e As EventArgs) Handles BTNDesasignar.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.DESASIGNAR)
            For Each item As Deposito In LSTDepositosAsignados.SelectedItems
                LSTDepositosNoAsignados.Items.Add(item)

            Next
            LSTDepositosNoAsignados.Refresh()
            LSTDepositosNoAsignados.Update()

            For Each item As Deposito In LSTDepositosNoAsignados.Items
                If LSTDepositosAsignados.Items.Contains(item) Then
                    LSTDepositosAsignados.Items.Remove(item)

                End If


            Next
            LSTDepositosAsignados.Refresh()
            LSTDepositosAsignados.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNAsignar_Click(sender As Object, e As EventArgs) Handles BTNAsignar.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ASIGNAR)
            For Each item As Deposito In LSTDepositosNoAsignados.SelectedItems
                LSTDepositosAsignados.Items.Add(item)

            Next
            LSTDepositosAsignados.Refresh()
            LSTDepositosAsignados.Update()

            For Each item As Deposito In LSTDepositosAsignados.Items
                If LSTDepositosNoAsignados.Items.Contains(item) Then
                    LSTDepositosNoAsignados.Items.Remove(item)

                End If


            Next
            LSTDepositosNoAsignados.Refresh()
            LSTDepositosNoAsignados.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub CMBPaisSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPaisSucursal.SelectedIndexChanged
        CMBProvinciaSucursal.DataSource = TryCast(CMBPaisSucursal.SelectedValue, Pais).provincias
        CMBProvinciaSucursal.DisplayMember = "provincia"
    End Sub

    Private Sub CMBProvinciaSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProvinciaSucursal.SelectedIndexChanged
        CMBLocalidadSucursal.DataSource = TryCast(CMBProvinciaSucursal.SelectedValue, Provincia).localidades
        CMBLocalidadSucursal.DisplayMember = "localidad"
    End Sub

    Private Sub BTNGuardarSucursal_Click(sender As Object, e As EventArgs) Handles BTNGuardarSucursal.Click
        Try
            Dim listaDepositos As New List(Of Deposito)
            For i As Integer = 0 To LSTDepositosAsignados.Items.Count - 1
                listaDepositos.Add(LSTDepositosAsignados.Items.Item(i))
            Next
            Dim mensaje As String = Dispatcher(Of String, GuardarSucursalAccion).execute(New GuardarSucursalAccion(CType(TXTIdSucursal.Text, Integer), TexTXTInicioAct.Text, TXTCierreAct.Text, TXTFechaApetura.Value, TXTFechaCierre.Value, CMBEstado.SelectedValue, TXTCalleSucursal.Text, TXTNroPuertaSucursal.Text, CType(TXTPisoSucursal.Text, Integer), TXTDepartamentoSucursal.Text, TXTEmailSucursal.Text, TXTTelefonoSucursal.Text, CMBLocalidadSucursal.SelectedValue, listaDepositos))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub BTNEliminarSucursal_Click(sender As Object, e As EventArgs) Handles BTNEliminarSucursal.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarSucursalAccion).execute(New EliminarSucursalAccion(CType(TXTIdSucursal.Text, Integer)))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub limpiar()
        TXTCalleDeposito.Text = ""
        TexTXTInicioAct.Text = ""
        TXTCalleSucursal.Text = ""
        TXTCierreAct.Text = ""
        TXTDepartamentoDeposito.Text = ""
        TXTDepartamentoSucursal.Text = ""
        TXTEmailSucursal.Text = ""
        TXTEmailSucursal.Text = ""
        TXTIdSucursal.Text = 0
        TXTLocalidadDeposito.Text = ""
        TXTNroPuertaDeposito.Text = ""
        TXTPaisDeposito.Text = ""
        TXTPisoDeposito.Text = ""
        TXTPisoSucursal.Text = 0
        TXTProvinciaDeposito.Text = ""
        TXTTelefonoSucursal.Text = ""
        CMBPaisSucursal.SelectedIndex = 0
        CMBProvinciaSucursal.DataSource = New List(Of Provincia)
        CMBLocalidadSucursal.DataSource = New List(Of Localidad)
        LSTDepositosAsignados.Items.Clear()
        LSTDepositosNoAsignados.Items.Clear()
        Dim lista As List(Of Deposito) = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        For Each dp As Deposito In lista
            LSTDepositosNoAsignados.Items.Add(dp)
        Next
        LSTDepositosAsignados.DisplayMember = "nomber"
        LSTDepositosNoAsignados.DisplayMember = "nomber"
    End Sub

    Private Sub BTNLimpiarSucursal_Click(sender As Object, e As EventArgs) Handles BTNLimpiarSucursal.Click
        limpiar()
    End Sub

    Private Sub BTNBuscarSucursal_Click(sender As Object, e As EventArgs) Handles BTNBuscarSucursal.Click
        Try
            Dim oSucursal As Sucursal = Dispatcher(Of Sucursal, BuscarSucursalAccion).execute(New BuscarSucursalAccion(TXTIdSucursal.Text))
            If oSucursal Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_SUCURSAL)), Me.GetType.ToString)
            End If
            TexTXTInicioAct.Text = oSucursal.horarioInicio
            TXTCalleSucursal.Text = oSucursal.contacto.calle
            TXTCierreAct.Text = oSucursal.horarioCierre
            TXTDepartamentoSucursal.Text = oSucursal.contacto.departamento
            TXTEmailSucursal.Text = oSucursal.contacto.email
            TXTFechaApetura.Value = oSucursal.fechaApertura
            TXTFechaCierre.Value = oSucursal.fechaCierre
            TXTIdSucursal.Text = oSucursal.id
            TXTPisoSucursal.Text = oSucursal.contacto.piso
            TXTTelefonoSucursal.Text = oSucursal.contacto.telefonos.Item(0).telefono
            TXTNroPuertaSucursal.Text = oSucursal.contacto.nroPuerta

            Dim cantPaises As Integer = CMBPaisSucursal.Items.Count
            Dim paisProvisorio As Pais
            For p As Integer = 0 To cantPaises
                paisProvisorio = CMBPaisSucursal.Items.Item(p)
                If paisProvisorio.id = oSucursal.contacto.localidad.provincia.pais.id Then
                    CMBPaisSucursal.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim cantProv As Integer = CMBProvinciaSucursal.Items.Count
            Dim provProvisoria As Provincia
            For p As Integer = 0 To cantProv
                provProvisoria = CMBProvinciaSucursal.Items.Item(p)
                If provProvisoria.id = oSucursal.contacto.localidad.provincia.id Then
                    CMBProvinciaSucursal.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim cantLoc As Integer = CMBLocalidadSucursal.Items.Count
            Dim locProvisoria As Localidad
            For p As Integer = 0 To cantLoc
                locProvisoria = CMBLocalidadSucursal.Items.Item(p)
                If locProvisoria.id = oSucursal.contacto.localidad.id Then
                    CMBLocalidadSucursal.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim elementosAEliminarDeLista As New List(Of Deposito)

            If Not oSucursal.depositos Is Nothing Then
                For Each oDeposito As Deposito In oSucursal.depositos
                    LSTDepositosAsignados.Items.Add(oDeposito)
                    For Each oElemento As Deposito In LSTDepositosNoAsignados.Items
                        If oElemento.id = oDeposito.id Then
                            elementosAEliminarDeLista.Add(oElemento)
                            Exit For
                        End If
                    Next
                Next

                For Each oDeposito As Deposito In elementosAEliminarDeLista
                    LSTDepositosNoAsignados.Items.Remove(oDeposito)
                Next
            End If
            LSTDepositosAsignados.DisplayMember = "nomber"
            LSTDepositosNoAsignados.DisplayMember = "nomber"
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub
End Class