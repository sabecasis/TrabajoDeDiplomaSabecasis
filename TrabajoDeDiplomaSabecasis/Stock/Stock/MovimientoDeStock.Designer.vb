<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientoDeStock
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
        Me.LBLDepositoOrigen = New System.Windows.Forms.Label()
        Me.CMBDeposito1 = New System.Windows.Forms.ComboBox()
        Me.CMBDeposito2 = New System.Windows.Forms.ComboBox()
        Me.LBLDepositoDestino = New System.Windows.Forms.Label()
        Me.CMBProducto = New System.Windows.Forms.ComboBox()
        Me.LBLProductoMovimiento = New System.Windows.Forms.Label()
        Me.LBLCantidadMovimiento = New System.Windows.Forms.Label()
        Me.TXTCantidad = New System.Windows.Forms.TextBox()
        Me.LBLInstanciasMovimineto = New System.Windows.Forms.Label()
        Me.LSTInstanciaAMover = New System.Windows.Forms.ListBox()
        Me.CHKMoverInstanciaEspecifica = New System.Windows.Forms.CheckBox()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.BTNBuscarMovimiento = New System.Windows.Forms.Button()
        Me.BTNEliminarMovimiento = New System.Windows.Forms.Button()
        Me.BTNGuardarMovimiento = New System.Windows.Forms.Button()
        Me.BTNLimpiarMovimiento = New System.Windows.Forms.Button()
        Me.LBLMotivoMovimiento = New System.Windows.Forms.Label()
        Me.TXTMotivo = New System.Windows.Forms.TextBox()
        Me.LBLFechaMovimiento = New System.Windows.Forms.Label()
        Me.LBLIdMovimiento = New System.Windows.Forms.Label()
        Me.TXTId = New System.Windows.Forms.TextBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.CHKAceptarMovimiento = New System.Windows.Forms.CheckBox()
        Me.CMBEstadoMovimiento = New System.Windows.Forms.ComboBox()
        Me.LBLEstadoMovimiento = New System.Windows.Forms.Label()
        Me.BTNDescargarComprobanteDeMovimiento = New System.Windows.Forms.Button()
        Me.DTPFechaAceptacion = New System.Windows.Forms.DateTimePicker()
        Me.LBLFechaAceptacionMovimiento = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLDepositoOrigen
        '
        Me.LBLDepositoOrigen.AutoSize = True
        Me.LBLDepositoOrigen.Location = New System.Drawing.Point(57, 97)
        Me.LBLDepositoOrigen.Name = "LBLDepositoOrigen"
        Me.LBLDepositoOrigen.Size = New System.Drawing.Size(96, 13)
        Me.LBLDepositoOrigen.TabIndex = 0
        Me.LBLDepositoOrigen.Text = "Depósito de origen"
        '
        'CMBDeposito1
        '
        Me.CMBDeposito1.FormattingEnabled = True
        Me.CMBDeposito1.Location = New System.Drawing.Point(201, 89)
        Me.CMBDeposito1.Name = "CMBDeposito1"
        Me.CMBDeposito1.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito1.TabIndex = 1
        '
        'CMBDeposito2
        '
        Me.CMBDeposito2.FormattingEnabled = True
        Me.CMBDeposito2.Location = New System.Drawing.Point(201, 116)
        Me.CMBDeposito2.Name = "CMBDeposito2"
        Me.CMBDeposito2.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito2.TabIndex = 3
        '
        'LBLDepositoDestino
        '
        Me.LBLDepositoDestino.AutoSize = True
        Me.LBLDepositoDestino.Location = New System.Drawing.Point(57, 124)
        Me.LBLDepositoDestino.Name = "LBLDepositoDestino"
        Me.LBLDepositoDestino.Size = New System.Drawing.Size(101, 13)
        Me.LBLDepositoDestino.TabIndex = 2
        Me.LBLDepositoDestino.Text = "Depósito de destino"
        '
        'CMBProducto
        '
        Me.CMBProducto.FormattingEnabled = True
        Me.CMBProducto.Location = New System.Drawing.Point(201, 62)
        Me.CMBProducto.Name = "CMBProducto"
        Me.CMBProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBProducto.TabIndex = 4
        '
        'LBLProductoMovimiento
        '
        Me.LBLProductoMovimiento.AutoSize = True
        Me.LBLProductoMovimiento.Location = New System.Drawing.Point(57, 70)
        Me.LBLProductoMovimiento.Name = "LBLProductoMovimiento"
        Me.LBLProductoMovimiento.Size = New System.Drawing.Size(50, 13)
        Me.LBLProductoMovimiento.TabIndex = 5
        Me.LBLProductoMovimiento.Text = "Producto"
        '
        'LBLCantidadMovimiento
        '
        Me.LBLCantidadMovimiento.AutoSize = True
        Me.LBLCantidadMovimiento.Location = New System.Drawing.Point(60, 150)
        Me.LBLCantidadMovimiento.Name = "LBLCantidadMovimiento"
        Me.LBLCantidadMovimiento.Size = New System.Drawing.Size(49, 13)
        Me.LBLCantidadMovimiento.TabIndex = 6
        Me.LBLCantidadMovimiento.Text = "Cantidad"
        '
        'TXTCantidad
        '
        Me.TXTCantidad.Location = New System.Drawing.Point(201, 147)
        Me.TXTCantidad.Name = "TXTCantidad"
        Me.TXTCantidad.Size = New System.Drawing.Size(121, 20)
        Me.TXTCantidad.TabIndex = 7
        Me.TXTCantidad.Text = "0"
        '
        'LBLInstanciasMovimineto
        '
        Me.LBLInstanciasMovimineto.AutoSize = True
        Me.LBLInstanciasMovimineto.Location = New System.Drawing.Point(63, 267)
        Me.LBLInstanciasMovimineto.Name = "LBLInstanciasMovimineto"
        Me.LBLInstanciasMovimineto.Size = New System.Drawing.Size(173, 13)
        Me.LBLInstanciasMovimineto.TabIndex = 8
        Me.LBLInstanciasMovimineto.Text = "Instancias de producto específicas"
        '
        'LSTInstanciaAMover
        '
        Me.LSTInstanciaAMover.FormattingEnabled = True
        Me.LSTInstanciaAMover.Location = New System.Drawing.Point(66, 293)
        Me.LSTInstanciaAMover.Name = "LSTInstanciaAMover"
        Me.LSTInstanciaAMover.Size = New System.Drawing.Size(155, 147)
        Me.LSTInstanciaAMover.TabIndex = 9
        '
        'CHKMoverInstanciaEspecifica
        '
        Me.CHKMoverInstanciaEspecifica.AutoSize = True
        Me.CHKMoverInstanciaEspecifica.Location = New System.Drawing.Point(286, 267)
        Me.CHKMoverInstanciaEspecifica.Name = "CHKMoverInstanciaEspecifica"
        Me.CHKMoverInstanciaEspecifica.Size = New System.Drawing.Size(233, 17)
        Me.CHKMoverInstanciaEspecifica.TabIndex = 10
        Me.CHKMoverInstanciaEspecifica.Text = "Mover una instancia de producto especifica"
        Me.CHKMoverInstanciaEspecifica.UseVisualStyleBackColor = True
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(60, 9)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 11
        '
        'BTNBuscarMovimiento
        '
        Me.BTNBuscarMovimiento.Location = New System.Drawing.Point(412, 359)
        Me.BTNBuscarMovimiento.Name = "BTNBuscarMovimiento"
        Me.BTNBuscarMovimiento.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarMovimiento.TabIndex = 35
        Me.BTNBuscarMovimiento.Text = "Buscar"
        Me.BTNBuscarMovimiento.UseVisualStyleBackColor = True
        '
        'BTNEliminarMovimiento
        '
        Me.BTNEliminarMovimiento.Location = New System.Drawing.Point(289, 359)
        Me.BTNEliminarMovimiento.Name = "BTNEliminarMovimiento"
        Me.BTNEliminarMovimiento.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarMovimiento.TabIndex = 34
        Me.BTNEliminarMovimiento.Text = "Eliminar"
        Me.BTNEliminarMovimiento.UseVisualStyleBackColor = True
        '
        'BTNGuardarMovimiento
        '
        Me.BTNGuardarMovimiento.Location = New System.Drawing.Point(412, 316)
        Me.BTNGuardarMovimiento.Name = "BTNGuardarMovimiento"
        Me.BTNGuardarMovimiento.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarMovimiento.TabIndex = 33
        Me.BTNGuardarMovimiento.Text = "Guardar"
        Me.BTNGuardarMovimiento.UseVisualStyleBackColor = True
        '
        'BTNLimpiarMovimiento
        '
        Me.BTNLimpiarMovimiento.Location = New System.Drawing.Point(289, 316)
        Me.BTNLimpiarMovimiento.Name = "BTNLimpiarMovimiento"
        Me.BTNLimpiarMovimiento.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarMovimiento.TabIndex = 32
        Me.BTNLimpiarMovimiento.Text = "Limpiar"
        Me.BTNLimpiarMovimiento.UseVisualStyleBackColor = True
        '
        'LBLMotivoMovimiento
        '
        Me.LBLMotivoMovimiento.AutoSize = True
        Me.LBLMotivoMovimiento.Location = New System.Drawing.Point(57, 202)
        Me.LBLMotivoMovimiento.Name = "LBLMotivoMovimiento"
        Me.LBLMotivoMovimiento.Size = New System.Drawing.Size(39, 13)
        Me.LBLMotivoMovimiento.TabIndex = 36
        Me.LBLMotivoMovimiento.Text = "Motivo"
        '
        'TXTMotivo
        '
        Me.TXTMotivo.Location = New System.Drawing.Point(201, 199)
        Me.TXTMotivo.Name = "TXTMotivo"
        Me.TXTMotivo.Size = New System.Drawing.Size(121, 20)
        Me.TXTMotivo.TabIndex = 37
        '
        'LBLFechaMovimiento
        '
        Me.LBLFechaMovimiento.AutoSize = True
        Me.LBLFechaMovimiento.Location = New System.Drawing.Point(60, 176)
        Me.LBLFechaMovimiento.Name = "LBLFechaMovimiento"
        Me.LBLFechaMovimiento.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaMovimiento.TabIndex = 38
        Me.LBLFechaMovimiento.Text = "Fecha"
        '
        'LBLIdMovimiento
        '
        Me.LBLIdMovimiento.AutoSize = True
        Me.LBLIdMovimiento.Location = New System.Drawing.Point(57, 43)
        Me.LBLIdMovimiento.Name = "LBLIdMovimiento"
        Me.LBLIdMovimiento.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdMovimiento.TabIndex = 42
        Me.LBLIdMovimiento.Text = "Id"
        '
        'TXTId
        '
        Me.TXTId.Location = New System.Drawing.Point(201, 36)
        Me.TXTId.Name = "TXTId"
        Me.TXTId.Size = New System.Drawing.Size(121, 20)
        Me.TXTId.TabIndex = 43
        Me.TXTId.Text = "0"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(201, 173)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecha.TabIndex = 44
        '
        'CHKAceptarMovimiento
        '
        Me.CHKAceptarMovimiento.AutoSize = True
        Me.CHKAceptarMovimiento.Location = New System.Drawing.Point(457, 36)
        Me.CHKAceptarMovimiento.Name = "CHKAceptarMovimiento"
        Me.CHKAceptarMovimiento.Size = New System.Drawing.Size(237, 17)
        Me.CHKAceptarMovimiento.TabIndex = 45
        Me.CHKAceptarMovimiento.Text = "Aceptar Movimiento En Deposito De Destino"
        Me.CHKAceptarMovimiento.UseVisualStyleBackColor = True
        '
        'CMBEstadoMovimiento
        '
        Me.CMBEstadoMovimiento.Enabled = False
        Me.CMBEstadoMovimiento.FormattingEnabled = True
        Me.CMBEstadoMovimiento.Location = New System.Drawing.Point(515, 70)
        Me.CMBEstadoMovimiento.Name = "CMBEstadoMovimiento"
        Me.CMBEstadoMovimiento.Size = New System.Drawing.Size(198, 21)
        Me.CMBEstadoMovimiento.TabIndex = 46
        '
        'LBLEstadoMovimiento
        '
        Me.LBLEstadoMovimiento.AutoSize = True
        Me.LBLEstadoMovimiento.Location = New System.Drawing.Point(409, 73)
        Me.LBLEstadoMovimiento.Name = "LBLEstadoMovimiento"
        Me.LBLEstadoMovimiento.Size = New System.Drawing.Size(40, 13)
        Me.LBLEstadoMovimiento.TabIndex = 47
        Me.LBLEstadoMovimiento.Text = "Estado"
        '
        'BTNDescargarComprobanteDeMovimiento
        '
        Me.BTNDescargarComprobanteDeMovimiento.Location = New System.Drawing.Point(276, 417)
        Me.BTNDescargarComprobanteDeMovimiento.Name = "BTNDescargarComprobanteDeMovimiento"
        Me.BTNDescargarComprobanteDeMovimiento.Size = New System.Drawing.Size(418, 23)
        Me.BTNDescargarComprobanteDeMovimiento.TabIndex = 48
        Me.BTNDescargarComprobanteDeMovimiento.Text = "Descargar Comprobante"
        Me.BTNDescargarComprobanteDeMovimiento.UseVisualStyleBackColor = True
        '
        'DTPFechaAceptacion
        '
        Me.DTPFechaAceptacion.Enabled = False
        Me.DTPFechaAceptacion.Location = New System.Drawing.Point(201, 225)
        Me.DTPFechaAceptacion.Name = "DTPFechaAceptacion"
        Me.DTPFechaAceptacion.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaAceptacion.TabIndex = 50
        '
        'LBLFechaAceptacionMovimiento
        '
        Me.LBLFechaAceptacionMovimiento.AutoSize = True
        Me.LBLFechaAceptacionMovimiento.Location = New System.Drawing.Point(57, 231)
        Me.LBLFechaAceptacionMovimiento.Name = "LBLFechaAceptacionMovimiento"
        Me.LBLFechaAceptacionMovimiento.Size = New System.Drawing.Size(90, 13)
        Me.LBLFechaAceptacionMovimiento.TabIndex = 49
        Me.LBLFechaAceptacionMovimiento.Text = "fecha aceptación"
        '
        'MovimientoDeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 564)
        Me.Controls.Add(Me.DTPFechaAceptacion)
        Me.Controls.Add(Me.LBLFechaAceptacionMovimiento)
        Me.Controls.Add(Me.BTNDescargarComprobanteDeMovimiento)
        Me.Controls.Add(Me.LBLEstadoMovimiento)
        Me.Controls.Add(Me.CMBEstadoMovimiento)
        Me.Controls.Add(Me.CHKAceptarMovimiento)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.TXTId)
        Me.Controls.Add(Me.LBLIdMovimiento)
        Me.Controls.Add(Me.LBLFechaMovimiento)
        Me.Controls.Add(Me.TXTMotivo)
        Me.Controls.Add(Me.LBLMotivoMovimiento)
        Me.Controls.Add(Me.BTNBuscarMovimiento)
        Me.Controls.Add(Me.BTNEliminarMovimiento)
        Me.Controls.Add(Me.BTNGuardarMovimiento)
        Me.Controls.Add(Me.BTNLimpiarMovimiento)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.CHKMoverInstanciaEspecifica)
        Me.Controls.Add(Me.LSTInstanciaAMover)
        Me.Controls.Add(Me.LBLInstanciasMovimineto)
        Me.Controls.Add(Me.TXTCantidad)
        Me.Controls.Add(Me.LBLCantidadMovimiento)
        Me.Controls.Add(Me.LBLProductoMovimiento)
        Me.Controls.Add(Me.CMBProducto)
        Me.Controls.Add(Me.CMBDeposito2)
        Me.Controls.Add(Me.LBLDepositoDestino)
        Me.Controls.Add(Me.CMBDeposito1)
        Me.Controls.Add(Me.LBLDepositoOrigen)
        Me.Name = "MovimientoDeStock"
        Me.Text = "MovimientoDeStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLDepositoOrigen As System.Windows.Forms.Label
    Friend WithEvents CMBDeposito1 As System.Windows.Forms.ComboBox
    Friend WithEvents CMBDeposito2 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDepositoDestino As System.Windows.Forms.Label
    Friend WithEvents CMBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLProductoMovimiento As System.Windows.Forms.Label
    Friend WithEvents LBLCantidadMovimiento As System.Windows.Forms.Label
    Friend WithEvents TXTCantidad As System.Windows.Forms.TextBox
    Friend WithEvents LBLInstanciasMovimineto As System.Windows.Forms.Label
    Friend WithEvents LSTInstanciaAMover As System.Windows.Forms.ListBox
    Friend WithEvents CHKMoverInstanciaEspecifica As System.Windows.Forms.CheckBox
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents BTNBuscarMovimiento As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarMovimiento As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarMovimiento As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarMovimiento As System.Windows.Forms.Button
    Friend WithEvents LBLMotivoMovimiento As System.Windows.Forms.Label
    Friend WithEvents TXTMotivo As System.Windows.Forms.TextBox
    Friend WithEvents LBLFechaMovimiento As System.Windows.Forms.Label
    Friend WithEvents LBLIdMovimiento As System.Windows.Forms.Label
    Friend WithEvents TXTId As System.Windows.Forms.TextBox
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CHKAceptarMovimiento As System.Windows.Forms.CheckBox
    Friend WithEvents CMBEstadoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents LBLEstadoMovimiento As System.Windows.Forms.Label
    Friend WithEvents BTNDescargarComprobanteDeMovimiento As System.Windows.Forms.Button
    Friend WithEvents DTPFechaAceptacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLFechaAceptacionMovimiento As System.Windows.Forms.Label
End Class
