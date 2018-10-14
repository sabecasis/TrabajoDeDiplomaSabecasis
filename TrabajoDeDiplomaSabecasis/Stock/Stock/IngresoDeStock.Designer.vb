<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoDeStock
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
        Me.LBLPrecioVentaIngreso = New System.Windows.Forms.Label()
        Me.LBLPrecioCompraIngreso = New System.Windows.Forms.Label()
        Me.TXTPrecioVenta = New System.Windows.Forms.TextBox()
        Me.TXTPrecioCompra = New System.Windows.Forms.TextBox()
        Me.LBLFechaIngreso = New System.Windows.Forms.Label()
        Me.LBLProductoIngreso = New System.Windows.Forms.Label()
        Me.CMBProducto = New System.Windows.Forms.ComboBox()
        Me.LBLDepositoIngreso = New System.Windows.Forms.Label()
        Me.CMBDeposito = New System.Windows.Forms.ComboBox()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.BTNBscarIngreso = New System.Windows.Forms.Button()
        Me.BTNEliminarIngreso = New System.Windows.Forms.Button()
        Me.BTNGuardarIngreso = New System.Windows.Forms.Button()
        Me.BTNLimpiarIngreso = New System.Windows.Forms.Button()
        Me.TXTFacturaProveedor = New System.Windows.Forms.TextBox()
        Me.LBLFacturaProveedorIngreso = New System.Windows.Forms.Label()
        Me.BTNExaminarIngreso = New System.Windows.Forms.Button()
        Me.LBLCantidadProducto = New System.Windows.Forms.Label()
        Me.TXTCantidad = New System.Windows.Forms.TextBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.OFDFacturaProveedor = New System.Windows.Forms.OpenFileDialog()
        Me.TXTId = New System.Windows.Forms.TextBox()
        Me.LBLIdIngreso = New System.Windows.Forms.Label()
        Me.LBLInstanciasDeProdAsocAIngreso = New System.Windows.Forms.Label()
        Me.DGVInstProdAssoc = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNDescargarComprobanteIngreso = New System.Windows.Forms.Button()
        Me.BTNDescargarFacturaProveedor = New System.Windows.Forms.Button()
        Me.LBLProveedorIngreso = New System.Windows.Forms.Label()
        Me.CMBProveedor = New System.Windows.Forms.ComboBox()
        Me.FBDDescargarFactura = New System.Windows.Forms.FolderBrowserDialog()
        Me.BTNGestionarPedidosDeReposicion = New System.Windows.Forms.Button()
        Me.LBLPedidoDeReposicionIdIngreso = New System.Windows.Forms.Label()
        Me.TXTPedidoDeReposicionId = New System.Windows.Forms.TextBox()
        CType(Me.DGVInstProdAssoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLPrecioVentaIngreso
        '
        Me.LBLPrecioVentaIngreso.AutoSize = True
        Me.LBLPrecioVentaIngreso.Location = New System.Drawing.Point(27, 190)
        Me.LBLPrecioVentaIngreso.Name = "LBLPrecioVentaIngreso"
        Me.LBLPrecioVentaIngreso.Size = New System.Drawing.Size(67, 13)
        Me.LBLPrecioVentaIngreso.TabIndex = 26
        Me.LBLPrecioVentaIngreso.Text = "Precio venta"
        '
        'LBLPrecioCompraIngreso
        '
        Me.LBLPrecioCompraIngreso.AutoSize = True
        Me.LBLPrecioCompraIngreso.Location = New System.Drawing.Point(27, 164)
        Me.LBLPrecioCompraIngreso.Name = "LBLPrecioCompraIngreso"
        Me.LBLPrecioCompraIngreso.Size = New System.Drawing.Size(75, 13)
        Me.LBLPrecioCompraIngreso.TabIndex = 25
        Me.LBLPrecioCompraIngreso.Text = "Precio compra"
        '
        'TXTPrecioVenta
        '
        Me.TXTPrecioVenta.Location = New System.Drawing.Point(194, 190)
        Me.TXTPrecioVenta.Name = "TXTPrecioVenta"
        Me.TXTPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrecioVenta.TabIndex = 22
        Me.TXTPrecioVenta.Text = "0"
        '
        'TXTPrecioCompra
        '
        Me.TXTPrecioCompra.Location = New System.Drawing.Point(194, 164)
        Me.TXTPrecioCompra.Name = "TXTPrecioCompra"
        Me.TXTPrecioCompra.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrecioCompra.TabIndex = 21
        Me.TXTPrecioCompra.Text = "0"
        '
        'LBLFechaIngreso
        '
        Me.LBLFechaIngreso.AutoSize = True
        Me.LBLFechaIngreso.Location = New System.Drawing.Point(27, 138)
        Me.LBLFechaIngreso.Name = "LBLFechaIngreso"
        Me.LBLFechaIngreso.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaIngreso.TabIndex = 31
        Me.LBLFechaIngreso.Text = "Fecha"
        '
        'LBLProductoIngreso
        '
        Me.LBLProductoIngreso.AutoSize = True
        Me.LBLProductoIngreso.Location = New System.Drawing.Point(27, 88)
        Me.LBLProductoIngreso.Name = "LBLProductoIngreso"
        Me.LBLProductoIngreso.Size = New System.Drawing.Size(50, 13)
        Me.LBLProductoIngreso.TabIndex = 33
        Me.LBLProductoIngreso.Text = "Producto"
        '
        'CMBProducto
        '
        Me.CMBProducto.FormattingEnabled = True
        Me.CMBProducto.Location = New System.Drawing.Point(194, 88)
        Me.CMBProducto.Name = "CMBProducto"
        Me.CMBProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBProducto.TabIndex = 32
        '
        'LBLDepositoIngreso
        '
        Me.LBLDepositoIngreso.AutoSize = True
        Me.LBLDepositoIngreso.Location = New System.Drawing.Point(27, 215)
        Me.LBLDepositoIngreso.Name = "LBLDepositoIngreso"
        Me.LBLDepositoIngreso.Size = New System.Drawing.Size(49, 13)
        Me.LBLDepositoIngreso.TabIndex = 35
        Me.LBLDepositoIngreso.Text = "Depósito"
        '
        'CMBDeposito
        '
        Me.CMBDeposito.FormattingEnabled = True
        Me.CMBDeposito.Location = New System.Drawing.Point(194, 215)
        Me.CMBDeposito.Name = "CMBDeposito"
        Me.CMBDeposito.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito.TabIndex = 34
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(27, 20)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 36
        '
        'BTNBscarIngreso
        '
        Me.BTNBscarIngreso.Location = New System.Drawing.Point(567, 146)
        Me.BTNBscarIngreso.Name = "BTNBscarIngreso"
        Me.BTNBscarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNBscarIngreso.TabIndex = 40
        Me.BTNBscarIngreso.Text = "Buscar"
        Me.BTNBscarIngreso.UseVisualStyleBackColor = True
        '
        'BTNEliminarIngreso
        '
        Me.BTNEliminarIngreso.Location = New System.Drawing.Point(444, 146)
        Me.BTNEliminarIngreso.Name = "BTNEliminarIngreso"
        Me.BTNEliminarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarIngreso.TabIndex = 39
        Me.BTNEliminarIngreso.Text = "Eliminar"
        Me.BTNEliminarIngreso.UseVisualStyleBackColor = True
        '
        'BTNGuardarIngreso
        '
        Me.BTNGuardarIngreso.Location = New System.Drawing.Point(567, 103)
        Me.BTNGuardarIngreso.Name = "BTNGuardarIngreso"
        Me.BTNGuardarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarIngreso.TabIndex = 38
        Me.BTNGuardarIngreso.Text = "Guardar"
        Me.BTNGuardarIngreso.UseVisualStyleBackColor = True
        '
        'BTNLimpiarIngreso
        '
        Me.BTNLimpiarIngreso.Location = New System.Drawing.Point(444, 103)
        Me.BTNLimpiarIngreso.Name = "BTNLimpiarIngreso"
        Me.BTNLimpiarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarIngreso.TabIndex = 37
        Me.BTNLimpiarIngreso.Text = "Limpiar"
        Me.BTNLimpiarIngreso.UseVisualStyleBackColor = True
        '
        'TXTFacturaProveedor
        '
        Me.TXTFacturaProveedor.Location = New System.Drawing.Point(194, 268)
        Me.TXTFacturaProveedor.Name = "TXTFacturaProveedor"
        Me.TXTFacturaProveedor.Size = New System.Drawing.Size(209, 20)
        Me.TXTFacturaProveedor.TabIndex = 41
        '
        'LBLFacturaProveedorIngreso
        '
        Me.LBLFacturaProveedorIngreso.AutoSize = True
        Me.LBLFacturaProveedorIngreso.Location = New System.Drawing.Point(20, 274)
        Me.LBLFacturaProveedorIngreso.Name = "LBLFacturaProveedorIngreso"
        Me.LBLFacturaProveedorIngreso.Size = New System.Drawing.Size(109, 13)
        Me.LBLFacturaProveedorIngreso.TabIndex = 42
        Me.LBLFacturaProveedorIngreso.Text = "Factura de proveedor"
        '
        'BTNExaminarIngreso
        '
        Me.BTNExaminarIngreso.Location = New System.Drawing.Point(433, 266)
        Me.BTNExaminarIngreso.Name = "BTNExaminarIngreso"
        Me.BTNExaminarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNExaminarIngreso.TabIndex = 43
        Me.BTNExaminarIngreso.Text = "Examinar"
        Me.BTNExaminarIngreso.UseVisualStyleBackColor = True
        '
        'LBLCantidadProducto
        '
        Me.LBLCantidadProducto.AutoSize = True
        Me.LBLCantidadProducto.Location = New System.Drawing.Point(27, 113)
        Me.LBLCantidadProducto.Name = "LBLCantidadProducto"
        Me.LBLCantidadProducto.Size = New System.Drawing.Size(49, 13)
        Me.LBLCantidadProducto.TabIndex = 50
        Me.LBLCantidadProducto.Text = "Cantidad"
        '
        'TXTCantidad
        '
        Me.TXTCantidad.Location = New System.Drawing.Point(194, 115)
        Me.TXTCantidad.Name = "TXTCantidad"
        Me.TXTCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TXTCantidad.TabIndex = 51
        Me.TXTCantidad.Text = "0"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(194, 138)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecha.TabIndex = 52
        '
        'OFDFacturaProveedor
        '
        Me.OFDFacturaProveedor.FileName = "default"
        '
        'TXTId
        '
        Me.TXTId.Location = New System.Drawing.Point(194, 62)
        Me.TXTId.Name = "TXTId"
        Me.TXTId.Size = New System.Drawing.Size(100, 20)
        Me.TXTId.TabIndex = 54
        Me.TXTId.Text = "0"
        '
        'LBLIdIngreso
        '
        Me.LBLIdIngreso.AutoSize = True
        Me.LBLIdIngreso.Location = New System.Drawing.Point(27, 60)
        Me.LBLIdIngreso.Name = "LBLIdIngreso"
        Me.LBLIdIngreso.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdIngreso.TabIndex = 53
        Me.LBLIdIngreso.Text = "Id"
        '
        'LBLInstanciasDeProdAsocAIngreso
        '
        Me.LBLInstanciasDeProdAsocAIngreso.AutoSize = True
        Me.LBLInstanciasDeProdAsocAIngreso.Location = New System.Drawing.Point(23, 353)
        Me.LBLInstanciasDeProdAsocAIngreso.Name = "LBLInstanciasDeProdAsocAIngreso"
        Me.LBLInstanciasDeProdAsocAIngreso.Size = New System.Drawing.Size(166, 13)
        Me.LBLInstanciasDeProdAsocAIngreso.TabIndex = 55
        Me.LBLInstanciasDeProdAsocAIngreso.Text = "Instancias de producto asociadas"
        '
        'DGVInstProdAssoc
        '
        Me.DGVInstProdAssoc.AllowUserToAddRows = False
        Me.DGVInstProdAssoc.AllowUserToDeleteRows = False
        Me.DGVInstProdAssoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInstProdAssoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.producto, Me.PrecioCompra, Me.PrecioVenta, Me.Deposito, Me.Estado, Me.FechaUltimaModificacion, Me.MotivoModificacion, Me.IngresoStock})
        Me.DGVInstProdAssoc.Location = New System.Drawing.Point(30, 378)
        Me.DGVInstProdAssoc.Name = "DGVInstProdAssoc"
        Me.DGVInstProdAssoc.ReadOnly = True
        Me.DGVInstProdAssoc.Size = New System.Drawing.Size(373, 150)
        Me.DGVInstProdAssoc.TabIndex = 56
        '
        'Id
        '
        Me.Id.DataPropertyName = "id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'producto
        '
        Me.producto.DataPropertyName = "producto"
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "precioCompra"
        Me.PrecioCompra.HeaderText = "Precio De Compra"
        Me.PrecioCompra.Name = "PrecioCompra"
        '
        'PrecioVenta
        '
        Me.PrecioVenta.DataPropertyName = "precioVenta"
        Me.PrecioVenta.HeaderText = "Precio De Venta"
        Me.PrecioVenta.Name = "PrecioVenta"
        '
        'Deposito
        '
        Me.Deposito.DataPropertyName = "deposito"
        Me.Deposito.HeaderText = "Deposito"
        Me.Deposito.Name = "Deposito"
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.FechaUltimaModificacion.HeaderText = "Fecha Última Modificación"
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        '
        'MotivoModificacion
        '
        Me.MotivoModificacion.DataPropertyName = "motivoModificacion"
        Me.MotivoModificacion.HeaderText = "Motivo"
        Me.MotivoModificacion.Name = "MotivoModificacion"
        '
        'IngresoStock
        '
        Me.IngresoStock.DataPropertyName = "ingresoEnStock"
        Me.IngresoStock.HeaderText = "Id Ingreso Stock"
        Me.IngresoStock.Name = "IngresoStock"
        '
        'BTNDescargarComprobanteIngreso
        '
        Me.BTNDescargarComprobanteIngreso.Location = New System.Drawing.Point(504, 378)
        Me.BTNDescargarComprobanteIngreso.Name = "BTNDescargarComprobanteIngreso"
        Me.BTNDescargarComprobanteIngreso.Size = New System.Drawing.Size(216, 23)
        Me.BTNDescargarComprobanteIngreso.TabIndex = 57
        Me.BTNDescargarComprobanteIngreso.Text = "Descargar Comprobante"
        Me.BTNDescargarComprobanteIngreso.UseVisualStyleBackColor = True
        '
        'BTNDescargarFacturaProveedor
        '
        Me.BTNDescargarFacturaProveedor.Location = New System.Drawing.Point(504, 420)
        Me.BTNDescargarFacturaProveedor.Name = "BTNDescargarFacturaProveedor"
        Me.BTNDescargarFacturaProveedor.Size = New System.Drawing.Size(216, 23)
        Me.BTNDescargarFacturaProveedor.TabIndex = 58
        Me.BTNDescargarFacturaProveedor.Text = "Descargar Factura de proveedor"
        Me.BTNDescargarFacturaProveedor.UseVisualStyleBackColor = True
        '
        'LBLProveedorIngreso
        '
        Me.LBLProveedorIngreso.AutoSize = True
        Me.LBLProveedorIngreso.Location = New System.Drawing.Point(27, 242)
        Me.LBLProveedorIngreso.Name = "LBLProveedorIngreso"
        Me.LBLProveedorIngreso.Size = New System.Drawing.Size(56, 13)
        Me.LBLProveedorIngreso.TabIndex = 45
        Me.LBLProveedorIngreso.Text = "Proveedor"
        '
        'CMBProveedor
        '
        Me.CMBProveedor.FormattingEnabled = True
        Me.CMBProveedor.Location = New System.Drawing.Point(194, 242)
        Me.CMBProveedor.Name = "CMBProveedor"
        Me.CMBProveedor.Size = New System.Drawing.Size(121, 21)
        Me.CMBProveedor.TabIndex = 44
        '
        'BTNGestionarPedidosDeReposicion
        '
        Me.BTNGestionarPedidosDeReposicion.Location = New System.Drawing.Point(444, 190)
        Me.BTNGestionarPedidosDeReposicion.Name = "BTNGestionarPedidosDeReposicion"
        Me.BTNGestionarPedidosDeReposicion.Size = New System.Drawing.Size(332, 23)
        Me.BTNGestionarPedidosDeReposicion.TabIndex = 59
        Me.BTNGestionarPedidosDeReposicion.Text = "Gestionar Pedidos De Reposicion De Stock"
        Me.BTNGestionarPedidosDeReposicion.UseVisualStyleBackColor = True
        '
        'LBLPedidoDeReposicionIdIngreso
        '
        Me.LBLPedidoDeReposicionIdIngreso.AutoSize = True
        Me.LBLPedidoDeReposicionIdIngreso.Location = New System.Drawing.Point(30, 306)
        Me.LBLPedidoDeReposicionIdIngreso.Name = "LBLPedidoDeReposicionIdIngreso"
        Me.LBLPedidoDeReposicionIdIngreso.Size = New System.Drawing.Size(52, 13)
        Me.LBLPedidoDeReposicionIdIngreso.TabIndex = 60
        Me.LBLPedidoDeReposicionIdIngreso.Text = "Id Pedido"
        '
        'TXTPedidoDeReposicionId
        '
        Me.TXTPedidoDeReposicionId.Location = New System.Drawing.Point(194, 299)
        Me.TXTPedidoDeReposicionId.Name = "TXTPedidoDeReposicionId"
        Me.TXTPedidoDeReposicionId.Size = New System.Drawing.Size(131, 20)
        Me.TXTPedidoDeReposicionId.TabIndex = 61
        Me.TXTPedidoDeReposicionId.Text = "0"
        '
        'IngresoDeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 575)
        Me.Controls.Add(Me.TXTPedidoDeReposicionId)
        Me.Controls.Add(Me.LBLPedidoDeReposicionIdIngreso)
        Me.Controls.Add(Me.BTNGestionarPedidosDeReposicion)
        Me.Controls.Add(Me.BTNDescargarFacturaProveedor)
        Me.Controls.Add(Me.BTNDescargarComprobanteIngreso)
        Me.Controls.Add(Me.DGVInstProdAssoc)
        Me.Controls.Add(Me.LBLInstanciasDeProdAsocAIngreso)
        Me.Controls.Add(Me.TXTId)
        Me.Controls.Add(Me.LBLIdIngreso)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.TXTCantidad)
        Me.Controls.Add(Me.LBLCantidadProducto)
        Me.Controls.Add(Me.LBLProveedorIngreso)
        Me.Controls.Add(Me.CMBProveedor)
        Me.Controls.Add(Me.BTNExaminarIngreso)
        Me.Controls.Add(Me.LBLFacturaProveedorIngreso)
        Me.Controls.Add(Me.TXTFacturaProveedor)
        Me.Controls.Add(Me.BTNBscarIngreso)
        Me.Controls.Add(Me.BTNEliminarIngreso)
        Me.Controls.Add(Me.BTNGuardarIngreso)
        Me.Controls.Add(Me.BTNLimpiarIngreso)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.LBLDepositoIngreso)
        Me.Controls.Add(Me.CMBDeposito)
        Me.Controls.Add(Me.LBLProductoIngreso)
        Me.Controls.Add(Me.CMBProducto)
        Me.Controls.Add(Me.LBLFechaIngreso)
        Me.Controls.Add(Me.LBLPrecioVentaIngreso)
        Me.Controls.Add(Me.LBLPrecioCompraIngreso)
        Me.Controls.Add(Me.TXTPrecioVenta)
        Me.Controls.Add(Me.TXTPrecioCompra)
        Me.Name = "IngresoDeStock"
        Me.Text = "IngresoDeStock"
        CType(Me.DGVInstProdAssoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLPrecioVentaIngreso As System.Windows.Forms.Label
    Friend WithEvents LBLPrecioCompraIngreso As System.Windows.Forms.Label
    Friend WithEvents TXTPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents TXTPrecioCompra As System.Windows.Forms.TextBox
    Friend WithEvents LBLFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents LBLProductoIngreso As System.Windows.Forms.Label
    Friend WithEvents CMBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDepositoIngreso As System.Windows.Forms.Label
    Friend WithEvents CMBDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents BTNBscarIngreso As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarIngreso As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarIngreso As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarIngreso As System.Windows.Forms.Button
    Friend WithEvents TXTFacturaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents LBLFacturaProveedorIngreso As System.Windows.Forms.Label
    Friend WithEvents BTNExaminarIngreso As System.Windows.Forms.Button
    Friend WithEvents LBLCantidadProducto As System.Windows.Forms.Label
    Friend WithEvents TXTCantidad As System.Windows.Forms.TextBox
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents OFDFacturaProveedor As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TXTId As System.Windows.Forms.TextBox
    Friend WithEvents LBLIdIngreso As System.Windows.Forms.Label
    Friend WithEvents LBLInstanciasDeProdAsocAIngreso As System.Windows.Forms.Label
    Friend WithEvents DGVInstProdAssoc As System.Windows.Forms.DataGridView
    Friend WithEvents BTNDescargarComprobanteIngreso As System.Windows.Forms.Button
    Friend WithEvents BTNDescargarFacturaProveedor As System.Windows.Forms.Button
    Friend WithEvents LBLProveedorIngreso As System.Windows.Forms.Label
    Friend WithEvents CMBProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotivoModificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngresoStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDDescargarFactura As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BTNGestionarPedidosDeReposicion As System.Windows.Forms.Button
    Friend WithEvents LBLPedidoDeReposicionIdIngreso As System.Windows.Forms.Label
    Friend WithEvents TXTPedidoDeReposicionId As System.Windows.Forms.TextBox
End Class
