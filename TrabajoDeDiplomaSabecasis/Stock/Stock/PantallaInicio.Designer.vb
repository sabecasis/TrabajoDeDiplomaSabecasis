<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaInicio))
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.MNNegocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarDepositos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarSucursales = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarMarcas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarMonedas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNBitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNBitacoraLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNConsultarLogDeErrores = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarGrupos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarRoles = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNSeguridad = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAgregarIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarDígitoVerificadorVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarDígitosHorizontalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNIngresarStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNEgresoDeStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNTransferenciaDeStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdminstrarProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNConsultarStockFaltante = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNConsultarStockPorProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNConsultarMovimientosDeStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarInstanciasDeProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNAdministrarDescuentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLogout = New System.Windows.Forms.Button()
        Me.LBLPedidoDeReposicionInicio = New System.Windows.Forms.Label()
        Me.DGVPedidoDeStock = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLMovimientoDeStockPendientes = New System.Windows.Forms.Label()
        Me.DGVMovimientosDeStock = New System.Windows.Forms.DataGridView()
        Me.idMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadinst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depositoOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depositoDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProdMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivoMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAceptacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleadoMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLIdioma = New System.Windows.Forms.Label()
        Me.CMBIdioma = New System.Windows.Forms.ComboBox()
        Me.LBLGrillaFaltantesDeStock = New System.Windows.Forms.Label()
        Me.DGVFaltantesDeStock = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciclo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pedidoAutomatico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.metodoReposicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AyudaEnLinea = New System.Windows.Forms.HelpProvider()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal.SuspendLayout()
        CType(Me.DGVPedidoDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMovimientosDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVFaltantesDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNNegocio, Me.MNBitacora, Me.MNUsuarios, Me.MNSeguridad, Me.MNStock, Me.AyudaToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(1073, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'MNNegocio
        '
        Me.MNNegocio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNAdministrarEmpleados, Me.MNAdministrarDepositos, Me.MNAdministrarSucursales, Me.MNAdministrarMarcas, Me.MNAdministrarMonedas, Me.MNAdministrarProveedores})
        Me.MNNegocio.Name = "MNNegocio"
        Me.MNNegocio.Size = New System.Drawing.Size(64, 20)
        Me.MNNegocio.Text = "Negocio"
        '
        'MNAdministrarEmpleados
        '
        Me.MNAdministrarEmpleados.Name = "MNAdministrarEmpleados"
        Me.MNAdministrarEmpleados.Size = New System.Drawing.Size(201, 22)
        Me.MNAdministrarEmpleados.Text = "Administrar empleados"
        '
        'MNAdministrarDepositos
        '
        Me.MNAdministrarDepositos.Name = "MNAdministrarDepositos"
        Me.MNAdministrarDepositos.Size = New System.Drawing.Size(201, 22)
        Me.MNAdministrarDepositos.Text = "Administrar depósitos"
        '
        'MNAdministrarSucursales
        '
        Me.MNAdministrarSucursales.Name = "MNAdministrarSucursales"
        Me.MNAdministrarSucursales.Size = New System.Drawing.Size(201, 22)
        Me.MNAdministrarSucursales.Text = "Administrar sucursales"
        '
        'MNAdministrarMarcas
        '
        Me.MNAdministrarMarcas.Name = "MNAdministrarMarcas"
        Me.MNAdministrarMarcas.Size = New System.Drawing.Size(201, 22)
        Me.MNAdministrarMarcas.Text = "Administrar marcas"
        '
        'MNAdministrarMonedas
        '
        Me.MNAdministrarMonedas.Name = "MNAdministrarMonedas"
        Me.MNAdministrarMonedas.Size = New System.Drawing.Size(201, 22)
        Me.MNAdministrarMonedas.Text = "Administrar monedas"
        '
        'MNAdministrarProveedores
        '
        Me.MNAdministrarProveedores.Name = "MNAdministrarProveedores"
        Me.MNAdministrarProveedores.Size = New System.Drawing.Size(201, 22)
        Me.MNAdministrarProveedores.Text = "Admnistrar proveedores"
        '
        'MNBitacora
        '
        Me.MNBitacora.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNBitacoraLogin, Me.MNConsultarLogDeErrores})
        Me.MNBitacora.Name = "MNBitacora"
        Me.MNBitacora.Size = New System.Drawing.Size(62, 20)
        Me.MNBitacora.Text = "Bitácora"
        '
        'MNBitacoraLogin
        '
        Me.MNBitacoraLogin.Name = "MNBitacoraLogin"
        Me.MNBitacoraLogin.Size = New System.Drawing.Size(200, 22)
        Me.MNBitacoraLogin.Text = "Consultar Bitácora"
        '
        'MNConsultarLogDeErrores
        '
        Me.MNConsultarLogDeErrores.Name = "MNConsultarLogDeErrores"
        Me.MNConsultarLogDeErrores.Size = New System.Drawing.Size(200, 22)
        Me.MNConsultarLogDeErrores.Text = "Consultar log de errores"
        '
        'MNUsuarios
        '
        Me.MNUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNAdministrarUsuarios, Me.MNAdministrarGrupos, Me.MNAdministrarRoles})
        Me.MNUsuarios.Name = "MNUsuarios"
        Me.MNUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.MNUsuarios.Text = "Usuarios"
        '
        'MNAdministrarUsuarios
        '
        Me.MNAdministrarUsuarios.Name = "MNAdministrarUsuarios"
        Me.MNAdministrarUsuarios.Size = New System.Drawing.Size(183, 22)
        Me.MNAdministrarUsuarios.Text = "Administrar usuarios"
        '
        'MNAdministrarGrupos
        '
        Me.MNAdministrarGrupos.Name = "MNAdministrarGrupos"
        Me.MNAdministrarGrupos.Size = New System.Drawing.Size(183, 22)
        Me.MNAdministrarGrupos.Text = "Administrar grupos"
        '
        'MNAdministrarRoles
        '
        Me.MNAdministrarRoles.Name = "MNAdministrarRoles"
        Me.MNAdministrarRoles.Size = New System.Drawing.Size(183, 22)
        Me.MNAdministrarRoles.Text = "Administrar roles"
        '
        'MNSeguridad
        '
        Me.MNSeguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNBackup, Me.MNAgregarIdioma, Me.ReiniciarDígitoVerificadorVerticalToolStripMenuItem, Me.ReiniciarDígitosHorizontalesToolStripMenuItem})
        Me.MNSeguridad.Name = "MNSeguridad"
        Me.MNSeguridad.Size = New System.Drawing.Size(72, 20)
        Me.MNSeguridad.Text = "Seguridad"
        '
        'MNBackup
        '
        Me.MNBackup.Name = "MNBackup"
        Me.MNBackup.Size = New System.Drawing.Size(299, 22)
        Me.MNBackup.Text = "Backup"
        '
        'MNAgregarIdioma
        '
        Me.MNAgregarIdioma.Name = "MNAgregarIdioma"
        Me.MNAgregarIdioma.Size = New System.Drawing.Size(299, 22)
        Me.MNAgregarIdioma.Text = "Agregar Idioma"
        '
        'ReiniciarDígitoVerificadorVerticalToolStripMenuItem
        '
        Me.ReiniciarDígitoVerificadorVerticalToolStripMenuItem.Name = "ReiniciarDígitoVerificadorVerticalToolStripMenuItem"
        Me.ReiniciarDígitoVerificadorVerticalToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ReiniciarDígitoVerificadorVerticalToolStripMenuItem.Text = "Reiniciar Dígito Verificador Vertical"
        '
        'ReiniciarDígitosHorizontalesToolStripMenuItem
        '
        Me.ReiniciarDígitosHorizontalesToolStripMenuItem.Name = "ReiniciarDígitosHorizontalesToolStripMenuItem"
        Me.ReiniciarDígitosHorizontalesToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ReiniciarDígitosHorizontalesToolStripMenuItem.Text = "Reiniciar Dígitos Verificadores Horizontales"
        '
        'MNStock
        '
        Me.MNStock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNIngresarStock, Me.MNEgresoDeStock, Me.MNTransferenciaDeStock, Me.MNAdminstrarProductos, Me.MNConsultarStockFaltante, Me.MNConsultarStockPorProducto, Me.MNConsultarMovimientosDeStock, Me.MNAdministrarInstanciasDeProducto, Me.MNAdministrarDescuentos})
        Me.MNStock.Name = "MNStock"
        Me.MNStock.Size = New System.Drawing.Size(48, 20)
        Me.MNStock.Text = "Stock"
        '
        'MNIngresarStock
        '
        Me.MNIngresarStock.Name = "MNIngresarStock"
        Me.MNIngresarStock.Size = New System.Drawing.Size(259, 22)
        Me.MNIngresarStock.Text = "Ingreso de stock"
        '
        'MNEgresoDeStock
        '
        Me.MNEgresoDeStock.Name = "MNEgresoDeStock"
        Me.MNEgresoDeStock.Size = New System.Drawing.Size(259, 22)
        Me.MNEgresoDeStock.Text = "Egreso de stock"
        '
        'MNTransferenciaDeStock
        '
        Me.MNTransferenciaDeStock.Name = "MNTransferenciaDeStock"
        Me.MNTransferenciaDeStock.Size = New System.Drawing.Size(259, 22)
        Me.MNTransferenciaDeStock.Text = "Transferencia de stock"
        '
        'MNAdminstrarProductos
        '
        Me.MNAdminstrarProductos.Name = "MNAdminstrarProductos"
        Me.MNAdminstrarProductos.Size = New System.Drawing.Size(259, 22)
        Me.MNAdminstrarProductos.Text = "Administrar Productos"
        '
        'MNConsultarStockFaltante
        '
        Me.MNConsultarStockFaltante.Name = "MNConsultarStockFaltante"
        Me.MNConsultarStockFaltante.Size = New System.Drawing.Size(259, 22)
        Me.MNConsultarStockFaltante.Text = "Consultar stock faltante"
        '
        'MNConsultarStockPorProducto
        '
        Me.MNConsultarStockPorProducto.Name = "MNConsultarStockPorProducto"
        Me.MNConsultarStockPorProducto.Size = New System.Drawing.Size(259, 22)
        Me.MNConsultarStockPorProducto.Text = "Consultar stock por producto"
        '
        'MNConsultarMovimientosDeStock
        '
        Me.MNConsultarMovimientosDeStock.Name = "MNConsultarMovimientosDeStock"
        Me.MNConsultarMovimientosDeStock.Size = New System.Drawing.Size(259, 22)
        Me.MNConsultarMovimientosDeStock.Text = "Consultar movimientos de stock"
        '
        'MNAdministrarInstanciasDeProducto
        '
        Me.MNAdministrarInstanciasDeProducto.Name = "MNAdministrarInstanciasDeProducto"
        Me.MNAdministrarInstanciasDeProducto.Size = New System.Drawing.Size(259, 22)
        Me.MNAdministrarInstanciasDeProducto.Text = "Administrar instancias de producto"
        '
        'MNAdministrarDescuentos
        '
        Me.MNAdministrarDescuentos.Name = "MNAdministrarDescuentos"
        Me.MNAdministrarDescuentos.Size = New System.Drawing.Size(259, 22)
        Me.MNAdministrarDescuentos.Text = "Administrar descuentos"
        '
        'BTNLogout
        '
        Me.BTNLogout.Location = New System.Drawing.Point(30, 53)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.Size = New System.Drawing.Size(339, 23)
        Me.BTNLogout.TabIndex = 1
        Me.BTNLogout.Text = "Cerrar Sesión"
        Me.BTNLogout.UseVisualStyleBackColor = True
        '
        'LBLPedidoDeReposicionInicio
        '
        Me.LBLPedidoDeReposicionInicio.AutoSize = True
        Me.LBLPedidoDeReposicionInicio.Location = New System.Drawing.Point(30, 138)
        Me.LBLPedidoDeReposicionInicio.Name = "LBLPedidoDeReposicionInicio"
        Me.LBLPedidoDeReposicionInicio.Size = New System.Drawing.Size(210, 13)
        Me.LBLPedidoDeReposicionInicio.TabIndex = 26
        Me.LBLPedidoDeReposicionInicio.Text = "Pedidos de reposición de stock pendientes"
        '
        'DGVPedidoDeStock
        '
        Me.DGVPedidoDeStock.AllowUserToAddRows = False
        Me.DGVPedidoDeStock.AllowUserToDeleteRows = False
        Me.DGVPedidoDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPedidoDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DGVPedidoDeStock.Location = New System.Drawing.Point(30, 157)
        Me.DGVPedidoDeStock.Name = "DGVPedidoDeStock"
        Me.DGVPedidoDeStock.ReadOnly = True
        Me.DGVPedidoDeStock.Size = New System.Drawing.Size(1144, 117)
        Me.DGVPedidoDeStock.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Deposito ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Empleado ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'LBLMovimientoDeStockPendientes
        '
        Me.LBLMovimientoDeStockPendientes.AutoSize = True
        Me.LBLMovimientoDeStockPendientes.Location = New System.Drawing.Point(33, 330)
        Me.LBLMovimientoDeStockPendientes.Name = "LBLMovimientoDeStockPendientes"
        Me.LBLMovimientoDeStockPendientes.Size = New System.Drawing.Size(236, 13)
        Me.LBLMovimientoDeStockPendientes.TabIndex = 28
        Me.LBLMovimientoDeStockPendientes.Text = "Movimientos de stock pendientes de aceptación"
        '
        'DGVMovimientosDeStock
        '
        Me.DGVMovimientosDeStock.AllowUserToAddRows = False
        Me.DGVMovimientosDeStock.AllowUserToDeleteRows = False
        Me.DGVMovimientosDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovimientosDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMovimiento, Me.cantidadinst, Me.fechaMovimiento, Me.depositoOrigen, Me.depositoDestino, Me.idProdMov, Me.motivoMov, Me.fechaAceptacion, Me.idEmpleadoMov})
        Me.DGVMovimientosDeStock.Location = New System.Drawing.Point(33, 349)
        Me.DGVMovimientosDeStock.Name = "DGVMovimientosDeStock"
        Me.DGVMovimientosDeStock.ReadOnly = True
        Me.DGVMovimientosDeStock.Size = New System.Drawing.Size(1144, 112)
        Me.DGVMovimientosDeStock.TabIndex = 27
        '
        'idMovimiento
        '
        Me.idMovimiento.HeaderText = "Movimiento ID"
        Me.idMovimiento.Name = "idMovimiento"
        Me.idMovimiento.ReadOnly = True
        '
        'cantidadinst
        '
        Me.cantidadinst.HeaderText = "Cantidad"
        Me.cantidadinst.Name = "cantidadinst"
        Me.cantidadinst.ReadOnly = True
        '
        'fechaMovimiento
        '
        Me.fechaMovimiento.HeaderText = "Fecha Solicitud"
        Me.fechaMovimiento.Name = "fechaMovimiento"
        Me.fechaMovimiento.ReadOnly = True
        '
        'depositoOrigen
        '
        Me.depositoOrigen.HeaderText = "Deposito De Origen ID"
        Me.depositoOrigen.Name = "depositoOrigen"
        Me.depositoOrigen.ReadOnly = True
        '
        'depositoDestino
        '
        Me.depositoDestino.HeaderText = "Deposito De Destino ID"
        Me.depositoDestino.Name = "depositoDestino"
        Me.depositoDestino.ReadOnly = True
        '
        'idProdMov
        '
        Me.idProdMov.HeaderText = "Producto ID"
        Me.idProdMov.Name = "idProdMov"
        Me.idProdMov.ReadOnly = True
        '
        'motivoMov
        '
        Me.motivoMov.HeaderText = "Motivo"
        Me.motivoMov.Name = "motivoMov"
        Me.motivoMov.ReadOnly = True
        '
        'fechaAceptacion
        '
        Me.fechaAceptacion.HeaderText = "Fecha De Aceptación"
        Me.fechaAceptacion.Name = "fechaAceptacion"
        Me.fechaAceptacion.ReadOnly = True
        '
        'idEmpleadoMov
        '
        Me.idEmpleadoMov.HeaderText = "Empleado ID"
        Me.idEmpleadoMov.Name = "idEmpleadoMov"
        Me.idEmpleadoMov.ReadOnly = True
        '
        'LBLIdioma
        '
        Me.LBLIdioma.AutoSize = True
        Me.LBLIdioma.Location = New System.Drawing.Point(867, 60)
        Me.LBLIdioma.Name = "LBLIdioma"
        Me.LBLIdioma.Size = New System.Drawing.Size(0, 13)
        Me.LBLIdioma.TabIndex = 30
        '
        'CMBIdioma
        '
        Me.CMBIdioma.FormattingEnabled = True
        Me.CMBIdioma.Location = New System.Drawing.Point(940, 53)
        Me.CMBIdioma.Name = "CMBIdioma"
        Me.CMBIdioma.Size = New System.Drawing.Size(121, 21)
        Me.CMBIdioma.TabIndex = 29
        '
        'LBLGrillaFaltantesDeStock
        '
        Me.LBLGrillaFaltantesDeStock.AutoSize = True
        Me.LBLGrillaFaltantesDeStock.Location = New System.Drawing.Point(30, 492)
        Me.LBLGrillaFaltantesDeStock.Name = "LBLGrillaFaltantesDeStock"
        Me.LBLGrillaFaltantesDeStock.Size = New System.Drawing.Size(94, 13)
        Me.LBLGrillaFaltantesDeStock.TabIndex = 32
        Me.LBLGrillaFaltantesDeStock.Text = "Faltantes de stock"
        '
        'DGVFaltantesDeStock
        '
        Me.DGVFaltantesDeStock.AllowUserToAddRows = False
        Me.DGVFaltantesDeStock.AllowUserToDeleteRows = False
        Me.DGVFaltantesDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFaltantesDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.maxStock, Me.minStock, Me.ciclo, Me.DataGridViewTextBoxColumn9, Me.pedidoAutomatico, Me.metodoReposicion})
        Me.DGVFaltantesDeStock.Location = New System.Drawing.Point(30, 511)
        Me.DGVFaltantesDeStock.Name = "DGVFaltantesDeStock"
        Me.DGVFaltantesDeStock.ReadOnly = True
        Me.DGVFaltantesDeStock.Size = New System.Drawing.Size(1144, 117)
        Me.DGVFaltantesDeStock.TabIndex = 31
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Producto ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'maxStock
        '
        Me.maxStock.HeaderText = "Stock máximo"
        Me.maxStock.Name = "maxStock"
        Me.maxStock.ReadOnly = True
        '
        'minStock
        '
        Me.minStock.HeaderText = "Stock mínimo"
        Me.minStock.Name = "minStock"
        Me.minStock.ReadOnly = True
        '
        'ciclo
        '
        Me.ciclo.HeaderText = "Ciclo de reposición"
        Me.ciclo.Name = "ciclo"
        Me.ciclo.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Deposito ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'pedidoAutomatico
        '
        Me.pedidoAutomatico.HeaderText = "Es pedido automático?"
        Me.pedidoAutomatico.Name = "pedidoAutomatico"
        Me.pedidoAutomatico.ReadOnly = True
        '
        'metodoReposicion
        '
        Me.metodoReposicion.HeaderText = "Metodo de reposición"
        Me.metodoReposicion.Name = "metodoReposicion"
        Me.metodoReposicion.ReadOnly = True
        '
        'AyudaEnLinea
        '
        Me.AyudaEnLinea.HelpNamespace = "Ayudaenlnea.html"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(24, 20)
        Me.AyudaToolStripMenuItem.Text = "?"
        '
        'PantallaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLGrillaFaltantesDeStock)
        Me.Controls.Add(Me.DGVFaltantesDeStock)
        Me.Controls.Add(Me.LBLIdioma)
        Me.Controls.Add(Me.CMBIdioma)
        Me.Controls.Add(Me.LBLMovimientoDeStockPendientes)
        Me.Controls.Add(Me.DGVMovimientosDeStock)
        Me.Controls.Add(Me.LBLPedidoDeReposicionInicio)
        Me.Controls.Add(Me.DGVPedidoDeStock)
        Me.Controls.Add(Me.BTNLogout)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "PantallaInicio"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        CType(Me.DGVPedidoDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMovimientosDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVFaltantesDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents MNNegocio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNBitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNBitacoraLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarGrupos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarRoles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNSeguridad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAgregarIdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTNLogout As System.Windows.Forms.Button
    Friend WithEvents MNStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarDepositos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarSucursales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarMarcas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarMonedas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNIngresarStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNEgresoDeStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNTransferenciaDeStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdminstrarProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNConsultarStockFaltante As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNConsultarStockPorProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNConsultarMovimientosDeStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarInstanciasDeProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNConsultarLogDeErrores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNAdministrarDescuentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBLPedidoDeReposicionInicio As System.Windows.Forms.Label
    Friend WithEvents DGVPedidoDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents LBLMovimientoDeStockPendientes As System.Windows.Forms.Label
    Friend WithEvents DGVMovimientosDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents idMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidadinst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depositoOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depositoDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProdMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivoMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAceptacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEmpleadoMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReiniciarDígitoVerificadorVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReiniciarDígitosHorizontalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBLIdioma As System.Windows.Forms.Label
    Friend WithEvents CMBIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBLGrillaFaltantesDeStock As System.Windows.Forms.Label
    Friend WithEvents DGVFaltantesDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents maxStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ciclo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pedidoAutomatico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents metodoReposicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaEnLinea As System.Windows.Forms.HelpProvider

End Class
