<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EgresoDeStock
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
        Me.TXTCantidad = New System.Windows.Forms.TextBox()
        Me.LBLCantidadEgreso = New System.Windows.Forms.Label()
        Me.LBLProuctoEgreso = New System.Windows.Forms.Label()
        Me.CMBProducto = New System.Windows.Forms.ComboBox()
        Me.LBLFechaEgreso = New System.Windows.Forms.Label()
        Me.LBLDepositoEgreso = New System.Windows.Forms.Label()
        Me.CMBDeposito = New System.Windows.Forms.ComboBox()
        Me.LBLInstProdEgresar = New System.Windows.Forms.Label()
        Me.LSTInstanciaEgresar = New System.Windows.Forms.ListBox()
        Me.CHKSeleccionarEspecificas = New System.Windows.Forms.CheckBox()
        Me.LSTInstanciasASeleccionarEgreso = New System.Windows.Forms.ListBox()
        Me.BTNSeleccionarInstanciaEgreso = New System.Windows.Forms.Button()
        Me.BTNQuitarInstPRodEgresar = New System.Windows.Forms.Button()
        Me.BTNBuscarEgreso = New System.Windows.Forms.Button()
        Me.BTNGuardarEgreso = New System.Windows.Forms.Button()
        Me.BTNLimpiarEgreso = New System.Windows.Forms.Button()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.LBLMotivoEgreso = New System.Windows.Forms.Label()
        Me.TXTMotivo = New System.Windows.Forms.TextBox()
        Me.BTNEliminarEgreso = New System.Windows.Forms.Button()
        Me.BTNObtenerComproabanteEgreso = New System.Windows.Forms.Button()
        Me.DTPFechaEgreso = New System.Windows.Forms.DateTimePicker()
        Me.LBLIdEgreso = New System.Windows.Forms.Label()
        Me.TXTIdEgreso = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TXTCantidad
        '
        Me.TXTCantidad.Location = New System.Drawing.Point(281, 101)
        Me.TXTCantidad.Name = "TXTCantidad"
        Me.TXTCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TXTCantidad.TabIndex = 57
        '
        'LBLCantidadEgreso
        '
        Me.LBLCantidadEgreso.AutoSize = True
        Me.LBLCantidadEgreso.Location = New System.Drawing.Point(44, 99)
        Me.LBLCantidadEgreso.Name = "LBLCantidadEgreso"
        Me.LBLCantidadEgreso.Size = New System.Drawing.Size(49, 13)
        Me.LBLCantidadEgreso.TabIndex = 56
        Me.LBLCantidadEgreso.Text = "Cantidad"
        '
        'LBLProuctoEgreso
        '
        Me.LBLProuctoEgreso.AutoSize = True
        Me.LBLProuctoEgreso.Location = New System.Drawing.Point(44, 74)
        Me.LBLProuctoEgreso.Name = "LBLProuctoEgreso"
        Me.LBLProuctoEgreso.Size = New System.Drawing.Size(50, 13)
        Me.LBLProuctoEgreso.TabIndex = 55
        Me.LBLProuctoEgreso.Text = "Producto"
        '
        'CMBProducto
        '
        Me.CMBProducto.FormattingEnabled = True
        Me.CMBProducto.Location = New System.Drawing.Point(281, 74)
        Me.CMBProducto.Name = "CMBProducto"
        Me.CMBProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBProducto.TabIndex = 54
        '
        'LBLFechaEgreso
        '
        Me.LBLFechaEgreso.AutoSize = True
        Me.LBLFechaEgreso.Location = New System.Drawing.Point(44, 124)
        Me.LBLFechaEgreso.Name = "LBLFechaEgreso"
        Me.LBLFechaEgreso.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaEgreso.TabIndex = 53
        Me.LBLFechaEgreso.Text = "Fecha"
        '
        'LBLDepositoEgreso
        '
        Me.LBLDepositoEgreso.AutoSize = True
        Me.LBLDepositoEgreso.Location = New System.Drawing.Point(44, 150)
        Me.LBLDepositoEgreso.Name = "LBLDepositoEgreso"
        Me.LBLDepositoEgreso.Size = New System.Drawing.Size(49, 13)
        Me.LBLDepositoEgreso.TabIndex = 59
        Me.LBLDepositoEgreso.Text = "Depósito"
        '
        'CMBDeposito
        '
        Me.CMBDeposito.FormattingEnabled = True
        Me.CMBDeposito.Location = New System.Drawing.Point(281, 150)
        Me.CMBDeposito.Name = "CMBDeposito"
        Me.CMBDeposito.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito.TabIndex = 58
        '
        'LBLInstProdEgresar
        '
        Me.LBLInstProdEgresar.AutoSize = True
        Me.LBLInstProdEgresar.Location = New System.Drawing.Point(44, 265)
        Me.LBLInstProdEgresar.Name = "LBLInstProdEgresar"
        Me.LBLInstProdEgresar.Size = New System.Drawing.Size(162, 13)
        Me.LBLInstProdEgresar.TabIndex = 62
        Me.LBLInstProdEgresar.Text = "Instancias de producto a egresar"
        '
        'LSTInstanciaEgresar
        '
        Me.LSTInstanciaEgresar.FormattingEnabled = True
        Me.LSTInstanciaEgresar.Location = New System.Drawing.Point(281, 265)
        Me.LSTInstanciaEgresar.Name = "LSTInstanciaEgresar"
        Me.LSTInstanciaEgresar.Size = New System.Drawing.Size(121, 108)
        Me.LSTInstanciaEgresar.TabIndex = 63
        '
        'CHKSeleccionarEspecificas
        '
        Me.CHKSeleccionarEspecificas.AutoSize = True
        Me.CHKSeleccionarEspecificas.Location = New System.Drawing.Point(495, 69)
        Me.CHKSeleccionarEspecificas.Name = "CHKSeleccionarEspecificas"
        Me.CHKSeleccionarEspecificas.Size = New System.Drawing.Size(230, 17)
        Me.CHKSeleccionarEspecificas.TabIndex = 64
        Me.CHKSeleccionarEspecificas.Text = "Egresar instancias de producto específicas"
        Me.CHKSeleccionarEspecificas.UseVisualStyleBackColor = True
        '
        'LSTInstanciasASeleccionarEgreso
        '
        Me.LSTInstanciasASeleccionarEgreso.FormattingEnabled = True
        Me.LSTInstanciasASeleccionarEgreso.Location = New System.Drawing.Point(592, 99)
        Me.LSTInstanciasASeleccionarEgreso.Name = "LSTInstanciasASeleccionarEgreso"
        Me.LSTInstanciasASeleccionarEgreso.Size = New System.Drawing.Size(133, 108)
        Me.LSTInstanciasASeleccionarEgreso.TabIndex = 65
        '
        'BTNSeleccionarInstanciaEgreso
        '
        Me.BTNSeleccionarInstanciaEgreso.Location = New System.Drawing.Point(495, 101)
        Me.BTNSeleccionarInstanciaEgreso.Name = "BTNSeleccionarInstanciaEgreso"
        Me.BTNSeleccionarInstanciaEgreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNSeleccionarInstanciaEgreso.TabIndex = 66
        Me.BTNSeleccionarInstanciaEgreso.Text = "Seleccionar"
        Me.BTNSeleccionarInstanciaEgreso.UseVisualStyleBackColor = True
        '
        'BTNQuitarInstPRodEgresar
        '
        Me.BTNQuitarInstPRodEgresar.Location = New System.Drawing.Point(408, 265)
        Me.BTNQuitarInstPRodEgresar.Name = "BTNQuitarInstPRodEgresar"
        Me.BTNQuitarInstPRodEgresar.Size = New System.Drawing.Size(75, 23)
        Me.BTNQuitarInstPRodEgresar.TabIndex = 67
        Me.BTNQuitarInstPRodEgresar.Text = "Quitar"
        Me.BTNQuitarInstPRodEgresar.UseVisualStyleBackColor = True
        '
        'BTNBuscarEgreso
        '
        Me.BTNBuscarEgreso.Location = New System.Drawing.Point(650, 308)
        Me.BTNBuscarEgreso.Name = "BTNBuscarEgreso"
        Me.BTNBuscarEgreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarEgreso.TabIndex = 71
        Me.BTNBuscarEgreso.Text = "Buscar"
        Me.BTNBuscarEgreso.UseVisualStyleBackColor = True
        '
        'BTNGuardarEgreso
        '
        Me.BTNGuardarEgreso.Location = New System.Drawing.Point(650, 265)
        Me.BTNGuardarEgreso.Name = "BTNGuardarEgreso"
        Me.BTNGuardarEgreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarEgreso.TabIndex = 69
        Me.BTNGuardarEgreso.Text = "Guardar"
        Me.BTNGuardarEgreso.UseVisualStyleBackColor = True
        '
        'BTNLimpiarEgreso
        '
        Me.BTNLimpiarEgreso.Location = New System.Drawing.Point(527, 265)
        Me.BTNLimpiarEgreso.Name = "BTNLimpiarEgreso"
        Me.BTNLimpiarEgreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarEgreso.TabIndex = 68
        Me.BTNLimpiarEgreso.Text = "Limpiar"
        Me.BTNLimpiarEgreso.UseVisualStyleBackColor = True
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(66, 19)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 72
        '
        'LBLMotivoEgreso
        '
        Me.LBLMotivoEgreso.AutoSize = True
        Me.LBLMotivoEgreso.Location = New System.Drawing.Point(44, 180)
        Me.LBLMotivoEgreso.Name = "LBLMotivoEgreso"
        Me.LBLMotivoEgreso.Size = New System.Drawing.Size(39, 13)
        Me.LBLMotivoEgreso.TabIndex = 73
        Me.LBLMotivoEgreso.Text = "Motivo"
        '
        'TXTMotivo
        '
        Me.TXTMotivo.Location = New System.Drawing.Point(281, 177)
        Me.TXTMotivo.Name = "TXTMotivo"
        Me.TXTMotivo.Size = New System.Drawing.Size(121, 20)
        Me.TXTMotivo.TabIndex = 74
        '
        'BTNEliminarEgreso
        '
        Me.BTNEliminarEgreso.Location = New System.Drawing.Point(527, 308)
        Me.BTNEliminarEgreso.Name = "BTNEliminarEgreso"
        Me.BTNEliminarEgreso.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarEgreso.TabIndex = 75
        Me.BTNEliminarEgreso.Text = "Eliminar"
        Me.BTNEliminarEgreso.UseVisualStyleBackColor = True
        '
        'BTNObtenerComproabanteEgreso
        '
        Me.BTNObtenerComproabanteEgreso.Location = New System.Drawing.Point(516, 372)
        Me.BTNObtenerComproabanteEgreso.Name = "BTNObtenerComproabanteEgreso"
        Me.BTNObtenerComproabanteEgreso.Size = New System.Drawing.Size(289, 23)
        Me.BTNObtenerComproabanteEgreso.TabIndex = 76
        Me.BTNObtenerComproabanteEgreso.Text = "Obtener Comprobante De Egreso"
        Me.BTNObtenerComproabanteEgreso.UseVisualStyleBackColor = True
        '
        'DTPFechaEgreso
        '
        Me.DTPFechaEgreso.Location = New System.Drawing.Point(281, 124)
        Me.DTPFechaEgreso.Name = "DTPFechaEgreso"
        Me.DTPFechaEgreso.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaEgreso.TabIndex = 77
        '
        'LBLIdEgreso
        '
        Me.LBLIdEgreso.AutoSize = True
        Me.LBLIdEgreso.Location = New System.Drawing.Point(50, 51)
        Me.LBLIdEgreso.Name = "LBLIdEgreso"
        Me.LBLIdEgreso.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdEgreso.TabIndex = 78
        Me.LBLIdEgreso.Text = "Id"
        '
        'TXTIdEgreso
        '
        Me.TXTIdEgreso.Location = New System.Drawing.Point(281, 48)
        Me.TXTIdEgreso.Name = "TXTIdEgreso"
        Me.TXTIdEgreso.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdEgreso.TabIndex = 79
        Me.TXTIdEgreso.Text = "0"
        '
        'EgresoDeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 454)
        Me.Controls.Add(Me.TXTIdEgreso)
        Me.Controls.Add(Me.LBLIdEgreso)
        Me.Controls.Add(Me.DTPFechaEgreso)
        Me.Controls.Add(Me.BTNObtenerComproabanteEgreso)
        Me.Controls.Add(Me.BTNEliminarEgreso)
        Me.Controls.Add(Me.TXTMotivo)
        Me.Controls.Add(Me.LBLMotivoEgreso)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BTNBuscarEgreso)
        Me.Controls.Add(Me.BTNGuardarEgreso)
        Me.Controls.Add(Me.BTNLimpiarEgreso)
        Me.Controls.Add(Me.BTNQuitarInstPRodEgresar)
        Me.Controls.Add(Me.BTNSeleccionarInstanciaEgreso)
        Me.Controls.Add(Me.LSTInstanciasASeleccionarEgreso)
        Me.Controls.Add(Me.CHKSeleccionarEspecificas)
        Me.Controls.Add(Me.LSTInstanciaEgresar)
        Me.Controls.Add(Me.LBLInstProdEgresar)
        Me.Controls.Add(Me.LBLDepositoEgreso)
        Me.Controls.Add(Me.CMBDeposito)
        Me.Controls.Add(Me.TXTCantidad)
        Me.Controls.Add(Me.LBLCantidadEgreso)
        Me.Controls.Add(Me.LBLProuctoEgreso)
        Me.Controls.Add(Me.CMBProducto)
        Me.Controls.Add(Me.LBLFechaEgreso)
        Me.Name = "EgresoDeStock"
        Me.Text = "EgresoDeStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTCantidad As System.Windows.Forms.TextBox
    Friend WithEvents LBLCantidadEgreso As System.Windows.Forms.Label
    Friend WithEvents LBLProuctoEgreso As System.Windows.Forms.Label
    Friend WithEvents CMBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLFechaEgreso As System.Windows.Forms.Label
    Friend WithEvents LBLDepositoEgreso As System.Windows.Forms.Label
    Friend WithEvents CMBDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents LBLInstProdEgresar As System.Windows.Forms.Label
    Friend WithEvents LSTInstanciaEgresar As System.Windows.Forms.ListBox
    Friend WithEvents CHKSeleccionarEspecificas As System.Windows.Forms.CheckBox
    Friend WithEvents LSTInstanciasASeleccionarEgreso As System.Windows.Forms.ListBox
    Friend WithEvents BTNSeleccionarInstanciaEgreso As System.Windows.Forms.Button
    Friend WithEvents BTNQuitarInstPRodEgresar As System.Windows.Forms.Button
    Friend WithEvents BTNBuscarEgreso As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarEgreso As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarEgreso As System.Windows.Forms.Button
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents LBLMotivoEgreso As System.Windows.Forms.Label
    Friend WithEvents TXTMotivo As System.Windows.Forms.TextBox
    Friend WithEvents BTNEliminarEgreso As System.Windows.Forms.Button
    Friend WithEvents BTNObtenerComproabanteEgreso As System.Windows.Forms.Button
    Friend WithEvents DTPFechaEgreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLIdEgreso As System.Windows.Forms.Label
    Friend WithEvents TXTIdEgreso As System.Windows.Forms.TextBox
End Class
