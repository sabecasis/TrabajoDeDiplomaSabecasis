
Imports ElementosTransversales
Imports StockControlador
Imports StockControladorComando
Imports StockControladorAccion
Imports StockModelo

Public Class PantallaInicio
    Implements PantallaMultiIdioma

    Public Sub establecerIdioma(idIdioma As Integer)
        CMBIdioma.SelectedIndex = idIdioma
    End Sub

    Private Sub AgregarIdiomaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MNAgregarIdioma.Click
        Dim gi As GestionarIdioma = New GestionarIdioma()
        Autorizador.obtenerInstancia.moduloActual = MNAgregarIdioma.Name
        gi.ShowDialog()
    End Sub

    Private Sub AdministrarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MNAdministrarEmpleados.Click
        Dim ge As GestionarEmpleado = New GestionarEmpleado()
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarEmpleados.Name
        ge.ShowDialog()
    End Sub

    Private Sub AdministrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MNAdministrarUsuarios.Click
        Dim gu As GestionarUsuario = New GestionarUsuario()
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarUsuarios.Name
        gu.ShowDialog()
    End Sub

    Private Sub AdministrarGruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MNAdministrarGrupos.Click
        Dim gg As GestionarGrupo = New GestionarGrupo()
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarGrupos.Name
        gg.ShowDialog()
    End Sub

    Private Sub AdministrarRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MNAdministrarRoles.Click
        Dim gestionRoles As FormGestionRoles = New FormGestionRoles()
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarRoles.Name
        gestionRoles.ShowDialog()
    End Sub

    Private Sub verificarRoles()
        Dim deshabiltar As Boolean = True
        Dim listaOpciones As List(Of String) = Autorizador.obtenerInstancia().retornarOpcionesDisponibles()
        If listaOpciones.Count > 0 Then
            For Each item As ToolStripMenuItem In MenuPrincipal.Items
                item.Visible = False
                For Each mItem As ToolStripMenuItem In item.DropDownItems
                    mItem.Visible = False
                Next
            Next
            For Each item As ToolStripMenuItem In MenuPrincipal.Items
                deshabiltar = True
                For Each opcion As String In listaOpciones
                    If item.Name.Trim.Equals(opcion.Trim) Then
                        item.Visible = True
                    End If
                    For Each mItem As ToolStripMenuItem In item.DropDownItems
                        If opcion.Trim.Equals(mItem.Name.Trim) Then
                            mItem.Visible = True
                            item.Visible = True
                            deshabiltar = False
                            Exit For
                        End If
                    Next

                Next
            Next
        End If
    End Sub

    Private Sub PantallaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        establecerParametrosDeIdiomaDePantalla()

        Try
            If Not Sesion.obtenerInstancia().usuarioActual.nombre.Equals("SuperAdmin") Then
                verificarRoles()
            End If

            llenarDGV()
            Dim listaDeIdiomas As List(Of Idioma) = Dispatcher(Of List(Of Idioma), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBIdioma.DataSource = listaDeIdiomas
            CMBIdioma.DisplayMember = "cultura"
            CMBIdioma.ValueMember = "id"
            CMBIdioma.SelectedValue = 0
            Dispatcher(Of Object, GestionarIdiomaYCulturaActualAccion).execute(New GestionarIdiomaYCulturaActualAccion(CMBIdioma.SelectedValue))
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try

    End Sub

    Private Sub llenarDGV()
        Try
            Dim row As String()
            DGVMovimientosDeStock.Rows.Clear()
            Dim listaMovimiento As List(Of StockModelo.MovimientoDeStock) = Dispatcher(Of List(Of StockModelo.MovimientoDeStock), ObtenerTodosLosMovimientosDeStockNoAceptadosAccion).execute(New ObtenerTodosLosMovimientosDeStockNoAceptadosAccion(Sesion.obtenerInstancia.usuarioActual.empleados.Item(0).depositos))
            For Each movimiento As StockModelo.MovimientoDeStock In listaMovimiento
                row = New String() {movimiento.id.ToString, movimiento.cantidad, movimiento.fecha, movimiento.depositoOrigen.id.ToString, movimiento.depositoDestino.id.ToString, movimiento.producto.id.ToString, movimiento.motivo, movimiento.fechaAceptacion.ToString}
                DGVMovimientosDeStock.Rows.Add(row)
            Next

            DGVFaltantesDeStock.Rows.Clear()
            Dim listaExistencias As New List(Of ExistenciaDeProductoEnStock)
            For Each dep As Deposito In Sesion.obtenerInstancia.usuarioActual.empleados.Item(0).depositos
                'Calculamos el stock faltante porque si hay que autogenerar pedidos, queremos que se genere y se listen al inicio de sesión
                listaExistencias = Dispatcher(Of List(Of ExistenciaDeProductoEnStock), CalcularFaltantesDeStockAccion).execute(New CalcularFaltantesDeStockAccion(dep))
            Next

            For Each existencia As ExistenciaDeProductoEnStock In listaExistencias
                Dim pedidoAuto As String
                If existencia.pedidoAutomatico = True Then
                    pedidoAuto = "True"
                Else
                    pedidoAuto = "False"
                End If
                row = New String() {existencia.idProducto, existencia.maxStock, existencia.minStock, existencia.ciclo, existencia.deposito.id, pedidoAuto, existencia.modoReposicion.id}
                DGVFaltantesDeStock.Rows.Add(row)
            Next

            DGVPedidoDeStock.Rows.Clear()
            Dim listaPedidos As List(Of StockModelo.PedidoDeStock) = Dispatcher(Of List(Of StockModelo.PedidoDeStock), ObtenerTodosLosPedidosNoIngresadosPorDepositoAccion).execute(New ObtenerTodosLosPedidosNoIngresadosPorDepositoAccion(Sesion.obtenerInstancia.usuarioActual.empleados.Item(0).depositos))
            For Each pedido As StockModelo.PedidoDeStock In listaPedidos
                row = New String() {pedido.id.ToString, pedido.producto.id.ToString, pedido.deposito.id.ToString, pedido.empleado.id.ToString, pedido.fecha, pedido.cantidad}
                DGVPedidoDeStock.Rows.Add(row)
            Next
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub MNBitacoraLogin_Click(sender As Object, e As EventArgs) Handles MNBitacoraLogin.Click
        Dim bdu As BitacoraDeUsuario = New BitacoraDeUsuario()
        Autorizador.obtenerInstancia.moduloActual = MNBitacoraLogin.Name
        bdu.ShowDialog()
    End Sub

    Private Sub MNBackup_Click(sender As Object, e As EventArgs) Handles MNBackup.Click
        Dim br As BackupRestore = New BackupRestore()
        Autorizador.obtenerInstancia.moduloActual = MNBackup.Name
        br.ShowDialog()
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Login.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MNAdministrarDepositos_Click(sender As Object, e As EventArgs) Handles MNAdministrarDepositos.Click
        Dim gd As New GestionarDepositos
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarDepositos.Name
        gd.ShowDialog()
    End Sub

    Private Sub MNAdministrarSucursales_Click(sender As Object, e As EventArgs) Handles MNAdministrarSucursales.Click
        Dim gs As New GestionarSucursales
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarSucursales.Name
        gs.ShowDialog()
    End Sub

    Private Sub MNAdministrarMarcas_Click(sender As Object, e As EventArgs) Handles MNAdministrarMarcas.Click
        Dim pantallaMarca As New GestionarMarca()
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarMarcas.Name
        pantallaMarca.ShowDialog()
    End Sub

    Private Sub MNAdministrarMonedas_Click(sender As Object, e As EventArgs) Handles MNAdministrarMonedas.Click
        Dim pm As New GestionarMoneda
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarMonedas.Name
        pm.ShowDialog()
    End Sub

    Private Sub MNAdministrarProveedores_Click(sender As Object, e As EventArgs) Handles MNAdministrarProveedores.Click
        Dim gp As New GestionarProveedores
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarProveedores.Name
        gp.ShowDialog()
    End Sub

    Private Sub MNConsultarLogDeErrores_Click(sender As Object, e As EventArgs) Handles MNConsultarLogDeErrores.Click
        Dim log As New LogDeErrores
        Autorizador.obtenerInstancia.moduloActual = MNConsultarLogDeErrores.Name
        log.ShowDialog()
    End Sub

    Private Sub MNIngresarStock_Click(sender As Object, e As EventArgs) Handles MNIngresarStock.Click
        Dim ing As New IngresoDeStock
        Autorizador.obtenerInstancia.moduloActual = MNIngresarStock.Name
        ing.ShowDialog()

    End Sub

    Private Sub MNEgresoDeStock_Click(sender As Object, e As EventArgs) Handles MNEgresoDeStock.Click
        Dim egreso As New EgresoDeStock
        Autorizador.obtenerInstancia.moduloActual = MNEgresoDeStock.Name
        egreso.ShowDialog()
    End Sub

    Private Sub MNTransferenciaDeStock_Click(sender As Object, e As EventArgs) Handles MNTransferenciaDeStock.Click
        Dim movimiento As New MovimientoDeStock
        Autorizador.obtenerInstancia.moduloActual = MNTransferenciaDeStock.Name
        movimiento.ShowDialog()
    End Sub

    Private Sub MNAdminstrarProductos_Click(sender As Object, e As EventArgs) Handles MNAdminstrarProductos.Click
        Dim pr As New GestionarProducto
        Autorizador.obtenerInstancia.moduloActual = MNAdminstrarProductos.Name
        pr.ShowDialog()
    End Sub

    Private Sub MNConsultarStockFaltante_Click(sender As Object, e As EventArgs) Handles MNConsultarStockFaltante.Click
        Dim faltante As New ConsultarStockFaltante
        Autorizador.obtenerInstancia.moduloActual = MNConsultarStockFaltante.Name
        faltante.ShowDialog()
    End Sub

    Private Sub MNConsultarStockPorProducto_Click(sender As Object, e As EventArgs) Handles MNConsultarStockPorProducto.Click
        Dim consultar As New ConsultarStockPorProducto
        Autorizador.obtenerInstancia.moduloActual = MNConsultarStockPorProducto.Name
        consultar.ShowDialog()
    End Sub

    Private Sub MNConsultarMovimientosDeStock_Click(sender As Object, e As EventArgs) Handles MNConsultarMovimientosDeStock.Click
        Dim cons As New ConsultarMovimientosDeStock
        Autorizador.obtenerInstancia.moduloActual = MNConsultarMovimientosDeStock.Name
        cons.ShowDialog()

    End Sub

    Private Sub MNAdministrarInstanciasDeProducto_Click(sender As Object, e As EventArgs) Handles MNAdministrarInstanciasDeProducto.Click
        Dim instancias As New GestionarInstanciasDeProducto
        Autorizador.obtenerInstancia.moduloActual = MNAdministrarInstanciasDeProducto.Name
        instancias.ShowDialog()
    End Sub

   

    Private Sub MNAdministrarDescuentos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MNAdministrarDescuentos_Click_1(sender As Object, e As EventArgs) Handles MNAdministrarDescuentos.Click
        Dim des As New GestionarDescuento
        des.ShowDialog()
    End Sub

    Private Sub CMBIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBIdioma.SelectedIndexChanged
        Try
            If Not TypeOf CMBIdioma.SelectedValue Is Idioma Then
                Dispatcher(Of Object, GestionarIdiomaYCulturaActualAccion).execute(New GestionarIdiomaYCulturaActualAccion(Convert.ToInt32(CMBIdioma.SelectedValue)))
                establecerParametrosDeIdiomaDePantalla()
            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Public Sub establecerParametrosDeIdiomaDePantalla() Implements PantallaMultiIdioma.establecerParametrosDeIdiomaDePantalla
        Me.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.TITULOINICIO)
        LBLIdioma.Text = Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeIdioma.LBLIdioma)
        LBLPedidoDeReposicionInicio.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.LBLPedidoDeReposicionInicio)
        BTNLogout.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.BTNCerrarSesion)
        LBLMovimientoDeStockPendientes.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.LBLMovimientoDeStockPendientes)
        MNBackup.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNBackup)
        MNAdministrarDescuentos.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarDescuentos)
        MNAdministrarDepositos.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarDepositos)
        MNAdministrarEmpleados.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarEmpleados)
        MNAdministrarGrupos.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarGrupos)
        MNAdministrarInstanciasDeProducto.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarInstanciasDeProducto)
        MNAdministrarMarcas.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarMarcas)
        MNAdministrarMonedas.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarMonedas)
        MNAdministrarProveedores.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarProveedores)
        MNAdministrarRoles.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdmininistrarRoles)
        MNAdministrarSucursales.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarSucursales)
        MNAdministrarUsuarios.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdministrarUsuarios)
        MNAdminstrarProductos.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAdminstrarProductos)
        MNAgregarIdioma.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNAgregarIdioma)
        MNBitacora.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNBitacora)
        MNBitacoraLogin.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNBitacoraLogin)
        MNConsultarLogDeErrores.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNConsultarLogDeErrores)
        MNConsultarMovimientosDeStock.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNConsultarMovimientosDeStock)
        MNConsultarStockFaltante.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNConsultarStockFaltante)
        MNConsultarStockPorProducto.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNConsultarStockPorProducto)
        MNEgresoDeStock.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNEgresoDeStock)
        MNIngresarStock.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNIngresarStock)
        MNNegocio.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNNegocio)
        MNSeguridad.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNSeguridad)
        MNTransferenciaDeStock.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNTransferenciaDeStock)
        MNUsuarios.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNUsuarios)
        MNStock.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeIdioma.MNStock)
    End Sub

   
    Private Sub ReiniciarDígitoVerificadorVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarDígitoVerificadorVerticalToolStripMenuItem.Click
        Try
            Dispatcher(Of Boolean, GenerarVerificadoresVerticalesAccion).execute(New GenerarVerificadoresVerticalesAccion())
            MessageBox.Show(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.VERIFICADORES_VERTICALES_GENERADOS))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub ReiniciarDígitosHorizontalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarDígitosHorizontalesToolStripMenuItem.Click
        Dispatcher(Of Boolean, GenerarVerificadoresHorizontalesAccion).execute(New GenerarVerificadoresHorizontalesAccion())
        MessageBox.Show(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.VERIFICADORES_HORIZONTALES_GENERADOS))
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Help.ShowHelp(BTNLogout, "https://docs.google.com/document/d/1PQxcf7zoXrn_f7jtxrhyEbKQgGc8mZRVcoUNNBFkkUs/edit?usp=sharing")
    End Sub
End Class
