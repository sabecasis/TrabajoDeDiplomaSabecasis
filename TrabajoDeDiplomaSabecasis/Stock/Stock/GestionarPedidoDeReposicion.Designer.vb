<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarPedidoDeReposicion
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
        Me.LBLIdPedido = New System.Windows.Forms.Label()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.TXTId = New System.Windows.Forms.TextBox()
        Me.TXTCantidad = New System.Windows.Forms.TextBox()
        Me.LBLCantidadPedido = New System.Windows.Forms.Label()
        Me.TXTEmpleadoId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBProducto = New System.Windows.Forms.ComboBox()
        Me.LBLProductoPedido = New System.Windows.Forms.Label()
        Me.LBLDepositoPedido = New System.Windows.Forms.Label()
        Me.CMBDeposito = New System.Windows.Forms.ComboBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.LBLFechaPedido = New System.Windows.Forms.Label()
        Me.CHKAceptarPedido = New System.Windows.Forms.CheckBox()
        Me.BTNDescargarComprobantePedido = New System.Windows.Forms.Button()
        Me.BTNBscarPedido = New System.Windows.Forms.Button()
        Me.BTNEliminarPedido = New System.Windows.Forms.Button()
        Me.BTNGuardarPedido = New System.Windows.Forms.Button()
        Me.BTNLimpiarPedido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLIdPedido
        '
        Me.LBLIdPedido.AutoSize = True
        Me.LBLIdPedido.Location = New System.Drawing.Point(58, 66)
        Me.LBLIdPedido.Name = "LBLIdPedido"
        Me.LBLIdPedido.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdPedido.TabIndex = 0
        Me.LBLIdPedido.Text = "Id"
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(54, 23)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 1
        '
        'TXTId
        '
        Me.TXTId.Location = New System.Drawing.Point(226, 63)
        Me.TXTId.Name = "TXTId"
        Me.TXTId.Size = New System.Drawing.Size(100, 20)
        Me.TXTId.TabIndex = 2
        Me.TXTId.Text = "0"
        '
        'TXTCantidad
        '
        Me.TXTCantidad.Location = New System.Drawing.Point(226, 98)
        Me.TXTCantidad.Name = "TXTCantidad"
        Me.TXTCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TXTCantidad.TabIndex = 4
        Me.TXTCantidad.Text = "0"
        '
        'LBLCantidadPedido
        '
        Me.LBLCantidadPedido.AutoSize = True
        Me.LBLCantidadPedido.Location = New System.Drawing.Point(54, 101)
        Me.LBLCantidadPedido.Name = "LBLCantidadPedido"
        Me.LBLCantidadPedido.Size = New System.Drawing.Size(49, 13)
        Me.LBLCantidadPedido.TabIndex = 3
        Me.LBLCantidadPedido.Text = "Cantidad"
        '
        'TXTEmpleadoId
        '
        Me.TXTEmpleadoId.Enabled = False
        Me.TXTEmpleadoId.Location = New System.Drawing.Point(226, 136)
        Me.TXTEmpleadoId.Name = "TXTEmpleadoId"
        Me.TXTEmpleadoId.Size = New System.Drawing.Size(100, 20)
        Me.TXTEmpleadoId.TabIndex = 6
        Me.TXTEmpleadoId.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Id Empleado"
        '
        'CMBProducto
        '
        Me.CMBProducto.FormattingEnabled = True
        Me.CMBProducto.Location = New System.Drawing.Point(226, 175)
        Me.CMBProducto.Name = "CMBProducto"
        Me.CMBProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBProducto.TabIndex = 7
        '
        'LBLProductoPedido
        '
        Me.LBLProductoPedido.AutoSize = True
        Me.LBLProductoPedido.Location = New System.Drawing.Point(54, 183)
        Me.LBLProductoPedido.Name = "LBLProductoPedido"
        Me.LBLProductoPedido.Size = New System.Drawing.Size(50, 13)
        Me.LBLProductoPedido.TabIndex = 8
        Me.LBLProductoPedido.Text = "Producto"
        '
        'LBLDepositoPedido
        '
        Me.LBLDepositoPedido.AutoSize = True
        Me.LBLDepositoPedido.Location = New System.Drawing.Point(54, 222)
        Me.LBLDepositoPedido.Name = "LBLDepositoPedido"
        Me.LBLDepositoPedido.Size = New System.Drawing.Size(49, 13)
        Me.LBLDepositoPedido.TabIndex = 10
        Me.LBLDepositoPedido.Text = "Deposito"
        '
        'CMBDeposito
        '
        Me.CMBDeposito.FormattingEnabled = True
        Me.CMBDeposito.Location = New System.Drawing.Point(226, 214)
        Me.CMBDeposito.Name = "CMBDeposito"
        Me.CMBDeposito.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito.TabIndex = 9
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(226, 256)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecha.TabIndex = 11
        '
        'LBLFechaPedido
        '
        Me.LBLFechaPedido.AutoSize = True
        Me.LBLFechaPedido.Location = New System.Drawing.Point(54, 262)
        Me.LBLFechaPedido.Name = "LBLFechaPedido"
        Me.LBLFechaPedido.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaPedido.TabIndex = 12
        Me.LBLFechaPedido.Text = "Fecha"
        '
        'CHKAceptarPedido
        '
        Me.CHKAceptarPedido.AutoSize = True
        Me.CHKAceptarPedido.Location = New System.Drawing.Point(381, 63)
        Me.CHKAceptarPedido.Name = "CHKAceptarPedido"
        Me.CHKAceptarPedido.Size = New System.Drawing.Size(73, 17)
        Me.CHKAceptarPedido.TabIndex = 13
        Me.CHKAceptarPedido.Text = "Ingresado"
        Me.CHKAceptarPedido.UseVisualStyleBackColor = True
        '
        'BTNDescargarComprobantePedido
        '
        Me.BTNDescargarComprobantePedido.Location = New System.Drawing.Point(600, 143)
        Me.BTNDescargarComprobantePedido.Name = "BTNDescargarComprobantePedido"
        Me.BTNDescargarComprobantePedido.Size = New System.Drawing.Size(332, 23)
        Me.BTNDescargarComprobantePedido.TabIndex = 64
        Me.BTNDescargarComprobantePedido.Text = "Descargar Comprobante"
        Me.BTNDescargarComprobantePedido.UseVisualStyleBackColor = True
        '
        'BTNBscarPedido
        '
        Me.BTNBscarPedido.Location = New System.Drawing.Point(723, 99)
        Me.BTNBscarPedido.Name = "BTNBscarPedido"
        Me.BTNBscarPedido.Size = New System.Drawing.Size(75, 23)
        Me.BTNBscarPedido.TabIndex = 63
        Me.BTNBscarPedido.Text = "Buscar"
        Me.BTNBscarPedido.UseVisualStyleBackColor = True
        '
        'BTNEliminarPedido
        '
        Me.BTNEliminarPedido.Location = New System.Drawing.Point(600, 99)
        Me.BTNEliminarPedido.Name = "BTNEliminarPedido"
        Me.BTNEliminarPedido.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarPedido.TabIndex = 62
        Me.BTNEliminarPedido.Text = "Eliminar"
        Me.BTNEliminarPedido.UseVisualStyleBackColor = True
        '
        'BTNGuardarPedido
        '
        Me.BTNGuardarPedido.Location = New System.Drawing.Point(723, 56)
        Me.BTNGuardarPedido.Name = "BTNGuardarPedido"
        Me.BTNGuardarPedido.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarPedido.TabIndex = 61
        Me.BTNGuardarPedido.Text = "Guardar"
        Me.BTNGuardarPedido.UseVisualStyleBackColor = True
        '
        'BTNLimpiarPedido
        '
        Me.BTNLimpiarPedido.Location = New System.Drawing.Point(600, 56)
        Me.BTNLimpiarPedido.Name = "BTNLimpiarPedido"
        Me.BTNLimpiarPedido.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarPedido.TabIndex = 60
        Me.BTNLimpiarPedido.Text = "Limpiar"
        Me.BTNLimpiarPedido.UseVisualStyleBackColor = True
        '
        'GestionarPedidoDeReposicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 341)
        Me.Controls.Add(Me.BTNDescargarComprobantePedido)
        Me.Controls.Add(Me.BTNBscarPedido)
        Me.Controls.Add(Me.BTNEliminarPedido)
        Me.Controls.Add(Me.BTNGuardarPedido)
        Me.Controls.Add(Me.BTNLimpiarPedido)
        Me.Controls.Add(Me.CHKAceptarPedido)
        Me.Controls.Add(Me.LBLFechaPedido)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.LBLDepositoPedido)
        Me.Controls.Add(Me.CMBDeposito)
        Me.Controls.Add(Me.LBLProductoPedido)
        Me.Controls.Add(Me.CMBProducto)
        Me.Controls.Add(Me.TXTEmpleadoId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTCantidad)
        Me.Controls.Add(Me.LBLCantidadPedido)
        Me.Controls.Add(Me.TXTId)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.LBLIdPedido)
        Me.Name = "GestionarPedidoDeReposicion"
        Me.Text = "GestionarPedidoDeReposicion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIdPedido As System.Windows.Forms.Label
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents TXTId As System.Windows.Forms.TextBox
    Friend WithEvents TXTCantidad As System.Windows.Forms.TextBox
    Friend WithEvents LBLCantidadPedido As System.Windows.Forms.Label
    Friend WithEvents TXTEmpleadoId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLProductoPedido As System.Windows.Forms.Label
    Friend WithEvents LBLDepositoPedido As System.Windows.Forms.Label
    Friend WithEvents CMBDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLFechaPedido As System.Windows.Forms.Label
    Friend WithEvents CHKAceptarPedido As System.Windows.Forms.CheckBox
    Friend WithEvents BTNDescargarComprobantePedido As System.Windows.Forms.Button
    Friend WithEvents BTNBscarPedido As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarPedido As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarPedido As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarPedido As System.Windows.Forms.Button
End Class
