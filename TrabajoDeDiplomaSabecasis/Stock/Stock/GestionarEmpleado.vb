Imports StockControlador
Imports StockModelo
Imports ElementosTransversales
Imports StockControladorAccion
Imports StockControladorComando


Public Class GestionarEmpleado
    Implements PantallaMultiIdioma

    Private puestos As List(Of Puesto)

    Private Sub BTNGuardarEmpleado_Click(sender As Object, e As EventArgs) Handles BTNGuardarEmpleado.Click
        Try
            Dim empleado As Empleado = New Empleado()
            empleado.nroEmpleado = TXTNroEmpleado.Text
            Dim filaSeleccionada As Integer = -1
            Dim cantFilas As Integer = DGVPuestoEmpleado.Rows.Count - 1
            For i As Integer = 0 To cantFilas
                If DGVPuestoEmpleado.Rows(i).Cells(3).Value = True Then
                    filaSeleccionada = i
                    Exit For
                End If
            Next
            Dim listaDepositos As New List(Of Deposito)
            For i As Integer = 0 To LSTDepositosAsignados.Items.Count - 1
                listaDepositos.Add(LSTDepositosAsignados.Items.Item(i))
            Next

            empleado.depositos = listaDepositos

            If filaSeleccionada > -1 And Not DGVPuestoEmpleado.Rows.Item(filaSeleccionada).Cells(0).Value Is Nothing Then
                empleado.puesto = New Puesto()
                Try
                    empleado.puesto.id = DGVPuestoEmpleado.Rows(filaSeleccionada).Cells(0).Value
                Catch ex As Exception
                    MessageBox.Show(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
                End Try

                empleado.persona = New Persona()
                empleado.persona.nombre = TXTNombreEmpleado.Text
                empleado.persona.apellido = TXTApellidoEmpleado.Text
                empleado.persona.documento = TXTNroDocumentoEmpleado.Text
                empleado.persona.tipoDocumento = New TipoDocumento()
                empleado.persona.tipoDocumento.id = CMBTipoDocEmpleado.SelectedValue
                empleado.persona.contacto = New Contacto()
                empleado.persona.contacto.calle = TXTCalleEmpleado.Text
                empleado.persona.contacto.nroPuerta = TXTNroPuertaEmpleado.Text
                If Not TXTPisoEmpleado.Text.Equals("") Then
                    empleado.persona.contacto.piso = Convert.ToInt32(TXTPisoEmpleado.Text)
                    empleado.persona.contacto.departamento = TXTDepartamentoEmpleado.Text
                End If
                empleado.persona.contacto.email = TXTEmailEmpleado.Text
                empleado.persona.contacto.localidad = DirectCast(CMBLocalidadEmpleado.SelectedValue, Localidad)

                Dim telefono As Telefono = New Telefono
                telefono.telefono = TXTTelefonoEmpleado.Text
                telefono.tipoTelefono = New TipoTelefono()
                telefono.tipoTelefono.id = 1
                empleado.persona.contacto.telefonos = New List(Of Telefono)
                empleado.persona.contacto.telefonos.Add(telefono)
                Dim mensaje As String = ""

                If LBLIdEmpleado.Text = 0 Then
                    mensaje = Dispatcher(Of String, CrearEmpleadoAccion).execute(New CrearEmpleadoAccion(empleado))
                Else
                    'actualizar
                    'falta agregar funcionalidad para actualizar telefonos
                    empleado.id = LBLIdEmpleado.Text
                    mensaje = Dispatcher(Of String, ActualizarEmpleadoAccion).execute(New ActualizarEmpleadoAccion(empleado))
                End If

                LBLMensajeEmpleado.Text = mensaje
                clear()

            Else
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma().Item(ConstantesDeMensaje.ERROR_MAS_DE_UN_PUESTO_POR_EMPLEADO)), Me.GetType.ToString)
            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try
    End Sub

    Private Sub GestionarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarDGV()
            CMBTipoDocEmpleado.DataSource = Dispatcher(Of List(Of TipoDocumento), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBTipoDocEmpleado.ValueMember = "id"
            CMBTipoDocEmpleado.DisplayMember = "tipoDocumento"
            CMBPaisEmpleado.DataSource = Dispatcher(Of List(Of Pais), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBPaisEmpleado.DisplayMember = "pais"

            Dim lista As List(Of Deposito) = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            For Each dp As Deposito In lista
                LSTDepositosNoAsignados.Items.Add(dp)
            Next
            LSTDepositosAsignados.DisplayMember = "nomber"
            LSTDepositosNoAsignados.DisplayMember = "nomber"



            DGVPuestoEmpleado.SelectionMode = DataGridViewSelectionMode.CellSelect
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub llenarDGV()
        DGVPuestoEmpleado.Rows.Clear()
        Me.puestos = Dispatcher(Of List(Of Puesto), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        Dim dgvRow As DataGridViewRow
        Dim dgvCell As DataGridViewCell

        For count As Integer = 0 To Me.puestos.Count - 1
            dgvRow = New DataGridViewRow()
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.puestos.Item(count).id
            dgvRow.Cells.Add(dgvCell)
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.puestos.Item(count).puesto
            dgvRow.Cells.Add(dgvCell)
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.puestos.Item(count).codigo
            dgvRow.Cells.Add(dgvCell)
            DGVPuestoEmpleado.Rows.Add(dgvRow)
        Next
    End Sub
    Public Sub establecerParametrosDeIdiomaDePantalla() Implements PantallaMultiIdioma.establecerParametrosDeIdiomaDePantalla

    End Sub

    Private Sub BTNGuardarPuestos_Click(sender As Object, e As EventArgs) Handles BTNGuardarPuestos.Click
        Try
            'guardar nuevos empleados
            Dim listaPuestos As List(Of Puesto) = New List(Of Puesto)
            Dim puesto As Puesto
            For count As Integer = 0 To DGVPuestoEmpleado.Rows.Count - 2
                If DGVPuestoEmpleado.Rows(count).Cells(0).Value Is Nothing Then
                    puesto = New Puesto()
                    puesto.puesto = DGVPuestoEmpleado.Rows(count).Cells(1).Value
                    puesto.codigo = DGVPuestoEmpleado.Rows(count).Cells(2).Value
                    puestos.Add(puesto)
                End If
            Next
            LBLMensajeEmpleado.Text = Dispatcher(Of String, GuardarPuestosAccion).execute(New GuardarPuestosAccion(puestos))
            llenarDGV()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub CMBPaisEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPaisEmpleado.SelectedIndexChanged
        CMBProvinciaEmpleado.DataSource = TryCast(CMBPaisEmpleado.SelectedValue, Pais).provincias
        CMBProvinciaEmpleado.DisplayMember = "provincia"
    End Sub


    Private Sub CMBProvinciaEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProvinciaEmpleado.SelectedIndexChanged
        CMBLocalidadEmpleado.DataSource = TryCast(CMBProvinciaEmpleado.SelectedValue, Provincia).localidades
        CMBLocalidadEmpleado.DisplayMember = "localidad"
    End Sub

    Private Sub DGVPuestoEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPuestoEmpleado.CellContentClick
        Try
            For Each oRow As DataGridViewRow In DGVPuestoEmpleado.Rows
                If Not oRow.Cells(0) Is Nothing Then
                    If oRow.Cells(3).Selected = True Then
                        TXTNroEmpleado.Text = Dispatcher(Of String, ObtenerProximoNroEmpleadoAccion).execute(New ObtenerProximoNroEmpleadoAccion(oRow.Cells(0).Value))
                        Exit For
                    End If
                End If

            Next
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub clear()
        LBLIdEmpleado.Text = 0
        TXTApellidoEmpleado.Text = ""
        TXTCalleEmpleado.Text = ""
        TXTDepartamentoEmpleado.Text = ""
        TXTEmailEmpleado.Text = ""
        TXTNombreEmpleado.Text = ""
        TXTNroDocumentoEmpleado.Text = ""
        TXTNroEmpleado.Text = ""
        TXTNroPuertaEmpleado.Text = ""
        TXTPisoEmpleado.Text = ""
        TXTTelefonoEmpleado.Text = ""
        CMBPaisEmpleado.SelectedIndex = 0
        CMBProvinciaEmpleado.DataSource = New List(Of Provincia)
        CMBLocalidadEmpleado.DataSource = New List(Of Localidad)

        CMBTipoDocEmpleado.SelectedIndex = 0
        Dim cantFilas As Integer = DGVPuestoEmpleado.Rows.Count - 1
        For i As Integer = 0 To cantFilas
            DGVPuestoEmpleado.Rows(i).Cells(3).Value = False
        Next

        LSTDepositosAsignados.Items.Clear()
        LSTDepositosNoAsignados.Items.Clear()
        Dim lista As List(Of Deposito) = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        For Each dp As Deposito In lista
            LSTDepositosNoAsignados.Items.Add(dp)
        Next
        LSTDepositosAsignados.DisplayMember = "nomber"
        LSTDepositosNoAsignados.DisplayMember = "nomber"

    End Sub

    Private Sub BTNBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles BTNBuscarEmpleado.Click
        Try
            Dim empleado As Empleado = Dispatcher(Of Empleado, ObtenerEmpleadoPorNroODNIAccion).execute(New ObtenerEmpleadoPorNroODNIAccion(TXTNroDocumentoEmpleado.Text, TXTNroEmpleado.Text))
            If Not empleado Is Nothing Then
                LBLIdEmpleado.Text = empleado.id
                TXTApellidoEmpleado.Text = empleado.persona.apellido
                TXTNombreEmpleado.Text = empleado.persona.nombre
                TXTCalleEmpleado.Text = empleado.persona.contacto.calle
                TXTDepartamentoEmpleado.Text = empleado.persona.contacto.departamento
                TXTEmailEmpleado.Text = empleado.persona.contacto.email
                TXTNroDocumentoEmpleado.Text = empleado.persona.documento
                TXTNroEmpleado.Text = empleado.nroEmpleado
                TXTNroPuertaEmpleado.Text = empleado.persona.contacto.nroPuerta
                TXTPisoEmpleado.Text = empleado.persona.contacto.piso
                Dim cantPaises As Integer = CMBPaisEmpleado.Items.Count
                Dim paisProvisorio As Pais
                For p As Integer = 0 To cantPaises
                    paisProvisorio = CMBPaisEmpleado.Items.Item(p)
                    If paisProvisorio.id = empleado.persona.contacto.localidad.provincia.pais.id Then
                        CMBPaisEmpleado.SelectedIndex = p
                        Exit For
                    End If
                Next

                Dim cantProv As Integer = CMBProvinciaEmpleado.Items.Count
                Dim provProvisoria As Provincia
                For p As Integer = 0 To cantProv
                    provProvisoria = CMBProvinciaEmpleado.Items.Item(p)
                    If provProvisoria.id = empleado.persona.contacto.localidad.provincia.id Then
                        CMBProvinciaEmpleado.SelectedIndex = p
                        Exit For
                    End If
                Next

                LSTDepositosAsignados.Items.Clear()
                LSTDepositosNoAsignados.Items.Clear()
                Dim elementosAEliminarDeLista As New List(Of Deposito)
                If Not empleado.depositos Is Nothing Then
                    For Each oDeposito As Deposito In empleado.depositos
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

                Dim cantLoc As Integer = CMBLocalidadEmpleado.Items.Count
                Dim locProvisoria As Localidad
                For p As Integer = 0 To cantLoc
                    locProvisoria = CMBLocalidadEmpleado.Items.Item(p)
                    If locProvisoria.id = empleado.persona.contacto.localidad.id Then
                        CMBLocalidadEmpleado.SelectedIndex = p
                        Exit For
                    End If
                Next

                Dim cantfilas As Integer = DGVPuestoEmpleado.Rows.Count - 1
                For i As Integer = 0 To cantfilas
                    If DGVPuestoEmpleado.Rows(i).Cells(0).Value = empleado.puesto.id Then
                        DGVPuestoEmpleado.Rows(i).Cells(3).Value = True
                        Exit For
                    End If
                Next
            Else
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_EMPLEADO) + TXTNroDocumentoEmpleado.Text + TXTNroEmpleado.Text), Me.GetType.ToString)
            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNLimpiarPantallaEmpleado_Click(sender As Object, e As EventArgs) Handles BTNLimpiarPantallaEmpleado.Click
        clear()
    End Sub

    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        Try
            Dim idEmpleado As Integer = CType(LBLIdEmpleado.Text, Integer)
            Dim mensaje As String = Dispatcher(Of String, EliminarEmpleadoAccion).execute(New EliminarEmpleadoAccion(idEmpleado))
            LBLMensajeEmpleado.Text = mensaje + idEmpleado.ToString()
            clear()
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
End Class