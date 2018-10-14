<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarMovimientosDeStock
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
        Me.LBLFechaConsultarMovimiento = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.LBLProductoConsultarMovimiento = New System.Windows.Forms.Label()
        Me.CMBProducto = New System.Windows.Forms.ComboBox()
        Me.CMBDeposito = New System.Windows.Forms.ComboBox()
        Me.LBLDepositoConsultarMovimiento = New System.Windows.Forms.Label()
        Me.LBLEmpleadoConsultarMovimiento = New System.Windows.Forms.Label()
        Me.LBLInstanciaConsultarMovimientos = New System.Windows.Forms.Label()
        Me.TXTNroEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTIdInstancia = New System.Windows.Forms.TextBox()
        Me.DGVIngresoDeStock = New System.Windows.Forms.DataGridView()
        Me.idIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLIngresoStockConsultar = New System.Windows.Forms.Label()
        Me.LBLMovimientoDeStockConsultar = New System.Windows.Forms.Label()
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
        Me.LBLEgresosDeStockConsultar = New System.Windows.Forms.Label()
        Me.DGVEgresosDeStock = New System.Windows.Forms.DataGridView()
        Me.idEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHKNoConsiderarFechaEnBusqueda = New System.Windows.Forms.CheckBox()
        Me.CHKNoConsiderarDeposito = New System.Windows.Forms.CheckBox()
        Me.CHKNoConsiderarElProducto = New System.Windows.Forms.CheckBox()
        Me.BTNFiltrarConsultaMovimientos = New System.Windows.Forms.Button()
        Me.BTNLimpiarConsultaMovimientos = New System.Windows.Forms.Button()
        Me.LBLPedidoDeReposicionConsultar = New System.Windows.Forms.Label()
        Me.DGVPedidoDeStock = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVIngresoDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMovimientosDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVEgresosDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPedidoDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLFechaConsultarMovimiento
        '
        Me.LBLFechaConsultarMovimiento.AutoSize = True
        Me.LBLFechaConsultarMovimiento.Location = New System.Drawing.Point(54, 28)
        Me.LBLFechaConsultarMovimiento.Name = "LBLFechaConsultarMovimiento"
        Me.LBLFechaConsultarMovimiento.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaConsultarMovimiento.TabIndex = 0
        Me.LBLFechaConsultarMovimiento.Text = "Fecha"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(133, 23)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecha.TabIndex = 1
        '
        'LBLProductoConsultarMovimiento
        '
        Me.LBLProductoConsultarMovimiento.AutoSize = True
        Me.LBLProductoConsultarMovimiento.Location = New System.Drawing.Point(434, 23)
        Me.LBLProductoConsultarMovimiento.Name = "LBLProductoConsultarMovimiento"
        Me.LBLProductoConsultarMovimiento.Size = New System.Drawing.Size(50, 13)
        Me.LBLProductoConsultarMovimiento.TabIndex = 2
        Me.LBLProductoConsultarMovimiento.Text = "Producto"
        '
        'CMBProducto
        '
        Me.CMBProducto.FormattingEnabled = True
        Me.CMBProducto.Location = New System.Drawing.Point(502, 20)
        Me.CMBProducto.Name = "CMBProducto"
        Me.CMBProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBProducto.TabIndex = 3
        '
        'CMBDeposito
        '
        Me.CMBDeposito.FormattingEnabled = True
        Me.CMBDeposito.Location = New System.Drawing.Point(776, 20)
        Me.CMBDeposito.Name = "CMBDeposito"
        Me.CMBDeposito.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito.TabIndex = 5
        '
        'LBLDepositoConsultarMovimiento
        '
        Me.LBLDepositoConsultarMovimiento.AutoSize = True
        Me.LBLDepositoConsultarMovimiento.Location = New System.Drawing.Point(708, 23)
        Me.LBLDepositoConsultarMovimiento.Name = "LBLDepositoConsultarMovimiento"
        Me.LBLDepositoConsultarMovimiento.Size = New System.Drawing.Size(49, 13)
        Me.LBLDepositoConsultarMovimiento.TabIndex = 4
        Me.LBLDepositoConsultarMovimiento.Text = "Deposito"
        '
        'LBLEmpleadoConsultarMovimiento
        '
        Me.LBLEmpleadoConsultarMovimiento.AutoSize = True
        Me.LBLEmpleadoConsultarMovimiento.Location = New System.Drawing.Point(990, 23)
        Me.LBLEmpleadoConsultarMovimiento.Name = "LBLEmpleadoConsultarMovimiento"
        Me.LBLEmpleadoConsultarMovimiento.Size = New System.Drawing.Size(77, 13)
        Me.LBLEmpleadoConsultarMovimiento.TabIndex = 6
        Me.LBLEmpleadoConsultarMovimiento.Text = "Nro. Empleado"
        '
        'LBLInstanciaConsultarMovimientos
        '
        Me.LBLInstanciaConsultarMovimientos.AutoSize = True
        Me.LBLInstanciaConsultarMovimientos.Location = New System.Drawing.Point(52, 89)
        Me.LBLInstanciaConsultarMovimientos.Name = "LBLInstanciaConsultarMovimientos"
        Me.LBLInstanciaConsultarMovimientos.Size = New System.Drawing.Size(122, 13)
        Me.LBLInstanciaConsultarMovimientos.TabIndex = 8
        Me.LBLInstanciaConsultarMovimientos.Text = "Id Instancia de producto"
        '
        'TXTNroEmpleado
        '
        Me.TXTNroEmpleado.Location = New System.Drawing.Point(1082, 21)
        Me.TXTNroEmpleado.Name = "TXTNroEmpleado"
        Me.TXTNroEmpleado.Size = New System.Drawing.Size(128, 20)
        Me.TXTNroEmpleado.TabIndex = 10
        '
        'TXTIdInstancia
        '
        Me.TXTIdInstancia.Location = New System.Drawing.Point(275, 82)
        Me.TXTIdInstancia.Name = "TXTIdInstancia"
        Me.TXTIdInstancia.Size = New System.Drawing.Size(167, 20)
        Me.TXTIdInstancia.TabIndex = 11
        '
        'DGVIngresoDeStock
        '
        Me.DGVIngresoDeStock.AllowUserToAddRows = False
        Me.DGVIngresoDeStock.AllowUserToDeleteRows = False
        Me.DGVIngresoDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngresoDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idIngreso, Me.IdProducto, Me.idDeposito, Me.idEmpleado, Me.fecha, Me.cantidad})
        Me.DGVIngresoDeStock.Location = New System.Drawing.Point(66, 146)
        Me.DGVIngresoDeStock.Name = "DGVIngresoDeStock"
        Me.DGVIngresoDeStock.ReadOnly = True
        Me.DGVIngresoDeStock.Size = New System.Drawing.Size(1144, 90)
        Me.DGVIngresoDeStock.TabIndex = 12
        '
        'idIngreso
        '
        Me.idIngreso.HeaderText = "ID"
        Me.idIngreso.Name = "idIngreso"
        Me.idIngreso.ReadOnly = True
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "Producto ID"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        '
        'idDeposito
        '
        Me.idDeposito.HeaderText = "Deposito ID"
        Me.idDeposito.Name = "idDeposito"
        Me.idDeposito.ReadOnly = True
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Empleado ID"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'LBLIngresoStockConsultar
        '
        Me.LBLIngresoStockConsultar.AutoSize = True
        Me.LBLIngresoStockConsultar.Location = New System.Drawing.Point(66, 127)
        Me.LBLIngresoStockConsultar.Name = "LBLIngresoStockConsultar"
        Me.LBLIngresoStockConsultar.Size = New System.Drawing.Size(91, 13)
        Me.LBLIngresoStockConsultar.TabIndex = 13
        Me.LBLIngresoStockConsultar.Text = "Ingresos de stock"
        '
        'LBLMovimientoDeStockConsultar
        '
        Me.LBLMovimientoDeStockConsultar.AutoSize = True
        Me.LBLMovimientoDeStockConsultar.Location = New System.Drawing.Point(69, 250)
        Me.LBLMovimientoDeStockConsultar.Name = "LBLMovimientoDeStockConsultar"
        Me.LBLMovimientoDeStockConsultar.Size = New System.Drawing.Size(110, 13)
        Me.LBLMovimientoDeStockConsultar.TabIndex = 15
        Me.LBLMovimientoDeStockConsultar.Text = "Movimientos de stock"
        '
        'DGVMovimientosDeStock
        '
        Me.DGVMovimientosDeStock.AllowUserToAddRows = False
        Me.DGVMovimientosDeStock.AllowUserToDeleteRows = False
        Me.DGVMovimientosDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovimientosDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMovimiento, Me.cantidadinst, Me.fechaMovimiento, Me.depositoOrigen, Me.depositoDestino, Me.idProdMov, Me.motivoMov, Me.fechaAceptacion, Me.idEmpleadoMov})
        Me.DGVMovimientosDeStock.Location = New System.Drawing.Point(69, 269)
        Me.DGVMovimientosDeStock.Name = "DGVMovimientosDeStock"
        Me.DGVMovimientosDeStock.ReadOnly = True
        Me.DGVMovimientosDeStock.Size = New System.Drawing.Size(1144, 112)
        Me.DGVMovimientosDeStock.TabIndex = 14
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
        'LBLEgresosDeStockConsultar
        '
        Me.LBLEgresosDeStockConsultar.AutoSize = True
        Me.LBLEgresosDeStockConsultar.Location = New System.Drawing.Point(66, 398)
        Me.LBLEgresosDeStockConsultar.Name = "LBLEgresosDeStockConsultar"
        Me.LBLEgresosDeStockConsultar.Size = New System.Drawing.Size(89, 13)
        Me.LBLEgresosDeStockConsultar.TabIndex = 17
        Me.LBLEgresosDeStockConsultar.Text = "Egresos de stock"
        '
        'DGVEgresosDeStock
        '
        Me.DGVEgresosDeStock.AllowUserToAddRows = False
        Me.DGVEgresosDeStock.AllowUserToDeleteRows = False
        Me.DGVEgresosDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEgresosDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEgreso, Me.idProd, Me.idDep, Me.idEmple, Me.fechaEgreso, Me.cantidadEgreso, Me.motivo})
        Me.DGVEgresosDeStock.Location = New System.Drawing.Point(66, 417)
        Me.DGVEgresosDeStock.Name = "DGVEgresosDeStock"
        Me.DGVEgresosDeStock.ReadOnly = True
        Me.DGVEgresosDeStock.Size = New System.Drawing.Size(1144, 113)
        Me.DGVEgresosDeStock.TabIndex = 16
        '
        'idEgreso
        '
        Me.idEgreso.HeaderText = "Egreso ID"
        Me.idEgreso.Name = "idEgreso"
        Me.idEgreso.ReadOnly = True
        '
        'idProd
        '
        Me.idProd.HeaderText = "Producto ID"
        Me.idProd.Name = "idProd"
        Me.idProd.ReadOnly = True
        '
        'idDep
        '
        Me.idDep.HeaderText = "Deposito ID"
        Me.idDep.Name = "idDep"
        Me.idDep.ReadOnly = True
        '
        'idEmple
        '
        Me.idEmple.HeaderText = "Empleado ID"
        Me.idEmple.Name = "idEmple"
        Me.idEmple.ReadOnly = True
        '
        'fechaEgreso
        '
        Me.fechaEgreso.HeaderText = "Fecha"
        Me.fechaEgreso.Name = "fechaEgreso"
        Me.fechaEgreso.ReadOnly = True
        '
        'cantidadEgreso
        '
        Me.cantidadEgreso.HeaderText = "Cantidad"
        Me.cantidadEgreso.Name = "cantidadEgreso"
        Me.cantidadEgreso.ReadOnly = True
        '
        'motivo
        '
        Me.motivo.HeaderText = "Motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        '
        'CHKNoConsiderarFechaEnBusqueda
        '
        Me.CHKNoConsiderarFechaEnBusqueda.AutoSize = True
        Me.CHKNoConsiderarFechaEnBusqueda.Location = New System.Drawing.Point(55, 49)
        Me.CHKNoConsiderarFechaEnBusqueda.Name = "CHKNoConsiderarFechaEnBusqueda"
        Me.CHKNoConsiderarFechaEnBusqueda.Size = New System.Drawing.Size(258, 17)
        Me.CHKNoConsiderarFechaEnBusqueda.TabIndex = 18
        Me.CHKNoConsiderarFechaEnBusqueda.Text = "No considerar la fecha en el criterio de búsqueda"
        Me.CHKNoConsiderarFechaEnBusqueda.UseVisualStyleBackColor = True
        '
        'CHKNoConsiderarDeposito
        '
        Me.CHKNoConsiderarDeposito.AutoSize = True
        Me.CHKNoConsiderarDeposito.Location = New System.Drawing.Point(711, 49)
        Me.CHKNoConsiderarDeposito.Name = "CHKNoConsiderarDeposito"
        Me.CHKNoConsiderarDeposito.Size = New System.Drawing.Size(222, 17)
        Me.CHKNoConsiderarDeposito.TabIndex = 19
        Me.CHKNoConsiderarDeposito.Text = "No considerar el depósito en la búsqueda"
        Me.CHKNoConsiderarDeposito.UseVisualStyleBackColor = True
        '
        'CHKNoConsiderarElProducto
        '
        Me.CHKNoConsiderarElProducto.AutoSize = True
        Me.CHKNoConsiderarElProducto.Location = New System.Drawing.Point(437, 49)
        Me.CHKNoConsiderarElProducto.Name = "CHKNoConsiderarElProducto"
        Me.CHKNoConsiderarElProducto.Size = New System.Drawing.Size(224, 17)
        Me.CHKNoConsiderarElProducto.TabIndex = 20
        Me.CHKNoConsiderarElProducto.Text = "No considerar el producto en la búsqueda"
        Me.CHKNoConsiderarElProducto.UseVisualStyleBackColor = True
        '
        'BTNFiltrarConsultaMovimientos
        '
        Me.BTNFiltrarConsultaMovimientos.Location = New System.Drawing.Point(502, 82)
        Me.BTNFiltrarConsultaMovimientos.Name = "BTNFiltrarConsultaMovimientos"
        Me.BTNFiltrarConsultaMovimientos.Size = New System.Drawing.Size(75, 23)
        Me.BTNFiltrarConsultaMovimientos.TabIndex = 21
        Me.BTNFiltrarConsultaMovimientos.Text = "Filtrar"
        Me.BTNFiltrarConsultaMovimientos.UseVisualStyleBackColor = True
        '
        'BTNLimpiarConsultaMovimientos
        '
        Me.BTNLimpiarConsultaMovimientos.Location = New System.Drawing.Point(636, 82)
        Me.BTNLimpiarConsultaMovimientos.Name = "BTNLimpiarConsultaMovimientos"
        Me.BTNLimpiarConsultaMovimientos.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarConsultaMovimientos.TabIndex = 22
        Me.BTNLimpiarConsultaMovimientos.Text = "Limpiar"
        Me.BTNLimpiarConsultaMovimientos.UseVisualStyleBackColor = True
        '
        'LBLPedidoDeReposicionConsultar
        '
        Me.LBLPedidoDeReposicionConsultar.AutoSize = True
        Me.LBLPedidoDeReposicionConsultar.Location = New System.Drawing.Point(66, 551)
        Me.LBLPedidoDeReposicionConsultar.Name = "LBLPedidoDeReposicionConsultar"
        Me.LBLPedidoDeReposicionConsultar.Size = New System.Drawing.Size(154, 13)
        Me.LBLPedidoDeReposicionConsultar.TabIndex = 24
        Me.LBLPedidoDeReposicionConsultar.Text = "pedidos de reposición de stock"
        '
        'DGVPedidoDeStock
        '
        Me.DGVPedidoDeStock.AllowUserToAddRows = False
        Me.DGVPedidoDeStock.AllowUserToDeleteRows = False
        Me.DGVPedidoDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPedidoDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.estado})
        Me.DGVPedidoDeStock.Location = New System.Drawing.Point(66, 570)
        Me.DGVPedidoDeStock.Name = "DGVPedidoDeStock"
        Me.DGVPedidoDeStock.ReadOnly = True
        Me.DGVPedidoDeStock.Size = New System.Drawing.Size(1144, 117)
        Me.DGVPedidoDeStock.TabIndex = 23
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
        'estado
        '
        Me.estado.HeaderText = "Está ingresado?"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'ConsultarMovimientosDeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 733)
        Me.Controls.Add(Me.LBLPedidoDeReposicionConsultar)
        Me.Controls.Add(Me.DGVPedidoDeStock)
        Me.Controls.Add(Me.BTNLimpiarConsultaMovimientos)
        Me.Controls.Add(Me.BTNFiltrarConsultaMovimientos)
        Me.Controls.Add(Me.CHKNoConsiderarElProducto)
        Me.Controls.Add(Me.CHKNoConsiderarDeposito)
        Me.Controls.Add(Me.CHKNoConsiderarFechaEnBusqueda)
        Me.Controls.Add(Me.LBLEgresosDeStockConsultar)
        Me.Controls.Add(Me.DGVEgresosDeStock)
        Me.Controls.Add(Me.LBLMovimientoDeStockConsultar)
        Me.Controls.Add(Me.DGVMovimientosDeStock)
        Me.Controls.Add(Me.LBLIngresoStockConsultar)
        Me.Controls.Add(Me.DGVIngresoDeStock)
        Me.Controls.Add(Me.TXTIdInstancia)
        Me.Controls.Add(Me.TXTNroEmpleado)
        Me.Controls.Add(Me.LBLInstanciaConsultarMovimientos)
        Me.Controls.Add(Me.LBLEmpleadoConsultarMovimiento)
        Me.Controls.Add(Me.CMBDeposito)
        Me.Controls.Add(Me.LBLDepositoConsultarMovimiento)
        Me.Controls.Add(Me.CMBProducto)
        Me.Controls.Add(Me.LBLProductoConsultarMovimiento)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.LBLFechaConsultarMovimiento)
        Me.Name = "ConsultarMovimientosDeStock"
        Me.Text = "ConsultarMovimientosDeStock"
        CType(Me.DGVIngresoDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMovimientosDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVEgresosDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPedidoDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLFechaConsultarMovimiento As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLProductoConsultarMovimiento As System.Windows.Forms.Label
    Friend WithEvents CMBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents CMBDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDepositoConsultarMovimiento As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoConsultarMovimiento As System.Windows.Forms.Label
    Friend WithEvents LBLInstanciaConsultarMovimientos As System.Windows.Forms.Label
    Friend WithEvents TXTNroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTIdInstancia As System.Windows.Forms.TextBox
    Friend WithEvents DGVIngresoDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents LBLIngresoStockConsultar As System.Windows.Forms.Label
    Friend WithEvents LBLMovimientoDeStockConsultar As System.Windows.Forms.Label
    Friend WithEvents DGVMovimientosDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents LBLEgresosDeStockConsultar As System.Windows.Forms.Label
    Friend WithEvents DGVEgresosDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents CHKNoConsiderarFechaEnBusqueda As System.Windows.Forms.CheckBox
    Friend WithEvents CHKNoConsiderarDeposito As System.Windows.Forms.CheckBox
    Friend WithEvents CHKNoConsiderarElProducto As System.Windows.Forms.CheckBox
    Friend WithEvents BTNFiltrarConsultaMovimientos As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarConsultaMovimientos As System.Windows.Forms.Button
    Friend WithEvents idIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEgreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEmple As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaEgreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidadEgreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidadinst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depositoOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depositoDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProdMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivoMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAceptacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEmpleadoMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBLPedidoDeReposicionConsultar As System.Windows.Forms.Label
    Friend WithEvents DGVPedidoDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
