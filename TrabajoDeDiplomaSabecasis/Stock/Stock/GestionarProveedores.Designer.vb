<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarProveedores
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
        Me.BTNEliminarProveedor = New System.Windows.Forms.Button()
        Me.BTNLimpiarPantallaProveedor = New System.Windows.Forms.Button()
        Me.BTNBuscarProveedor = New System.Windows.Forms.Button()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.BTNGuardarProveedor = New System.Windows.Forms.Button()
        Me.LBLProveedorTelefono = New System.Windows.Forms.Label()
        Me.TXTTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.LBLProveedorEmail = New System.Windows.Forms.Label()
        Me.TXTEmailProveedor = New System.Windows.Forms.TextBox()
        Me.LBLProveedorLocalidad = New System.Windows.Forms.Label()
        Me.LBLProveedorProvincia = New System.Windows.Forms.Label()
        Me.LBLProveedorPais = New System.Windows.Forms.Label()
        Me.CMBLocalidadProveedor = New System.Windows.Forms.ComboBox()
        Me.CMBProvinciaProveedor = New System.Windows.Forms.ComboBox()
        Me.CMBPaisProveedor = New System.Windows.Forms.ComboBox()
        Me.LBLProveedorDepartamento = New System.Windows.Forms.Label()
        Me.TXTDepartamentoProveedor = New System.Windows.Forms.TextBox()
        Me.TXTPisoProveedor = New System.Windows.Forms.TextBox()
        Me.LBLProveedorPiso = New System.Windows.Forms.Label()
        Me.TXTNroPuertaProveedor = New System.Windows.Forms.TextBox()
        Me.TXTCalleProveedor = New System.Windows.Forms.TextBox()
        Me.TXTCuitProveedor = New System.Windows.Forms.TextBox()
        Me.LBLProveedorPuerta = New System.Windows.Forms.Label()
        Me.LBLProveedorCalle = New System.Windows.Forms.Label()
        Me.LBLCUITProveedor = New System.Windows.Forms.Label()
        Me.LBLNombreProveedor = New System.Windows.Forms.Label()
        Me.LBLIdProveedor = New System.Windows.Forms.Label()
        Me.TXTNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TXTIdProveedor = New System.Windows.Forms.TextBox()
        Me.LBLEstadoProveedor = New System.Windows.Forms.Label()
        Me.CMBEstadoProveedor = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTNEliminarProveedor
        '
        Me.BTNEliminarProveedor.Location = New System.Drawing.Point(170, 399)
        Me.BTNEliminarProveedor.Name = "BTNEliminarProveedor"
        Me.BTNEliminarProveedor.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarProveedor.TabIndex = 69
        Me.BTNEliminarProveedor.Text = "Eliminar"
        Me.BTNEliminarProveedor.UseVisualStyleBackColor = True
        '
        'BTNLimpiarPantallaProveedor
        '
        Me.BTNLimpiarPantallaProveedor.Location = New System.Drawing.Point(69, 399)
        Me.BTNLimpiarPantallaProveedor.Name = "BTNLimpiarPantallaProveedor"
        Me.BTNLimpiarPantallaProveedor.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarPantallaProveedor.TabIndex = 68
        Me.BTNLimpiarPantallaProveedor.Text = "Limpiar"
        Me.BTNLimpiarPantallaProveedor.UseVisualStyleBackColor = True
        '
        'BTNBuscarProveedor
        '
        Me.BTNBuscarProveedor.Location = New System.Drawing.Point(170, 358)
        Me.BTNBuscarProveedor.Name = "BTNBuscarProveedor"
        Me.BTNBuscarProveedor.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarProveedor.TabIndex = 67
        Me.BTNBuscarProveedor.Text = "Buscar"
        Me.BTNBuscarProveedor.UseVisualStyleBackColor = True
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(362, 52)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 66
        '
        'BTNGuardarProveedor
        '
        Me.BTNGuardarProveedor.Location = New System.Drawing.Point(69, 358)
        Me.BTNGuardarProveedor.Name = "BTNGuardarProveedor"
        Me.BTNGuardarProveedor.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarProveedor.TabIndex = 65
        Me.BTNGuardarProveedor.Text = "Guardar"
        Me.BTNGuardarProveedor.UseVisualStyleBackColor = True
        '
        'LBLProveedorTelefono
        '
        Me.LBLProveedorTelefono.AutoSize = True
        Me.LBLProveedorTelefono.Location = New System.Drawing.Point(63, 264)
        Me.LBLProveedorTelefono.Name = "LBLProveedorTelefono"
        Me.LBLProveedorTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LBLProveedorTelefono.TabIndex = 64
        Me.LBLProveedorTelefono.Text = "Teléfono"
        '
        'TXTTelefonoProveedor
        '
        Me.TXTTelefonoProveedor.Location = New System.Drawing.Point(185, 261)
        Me.TXTTelefonoProveedor.Name = "TXTTelefonoProveedor"
        Me.TXTTelefonoProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTTelefonoProveedor.TabIndex = 63
        '
        'LBLProveedorEmail
        '
        Me.LBLProveedorEmail.AutoSize = True
        Me.LBLProveedorEmail.Location = New System.Drawing.Point(65, 237)
        Me.LBLProveedorEmail.Name = "LBLProveedorEmail"
        Me.LBLProveedorEmail.Size = New System.Drawing.Size(32, 13)
        Me.LBLProveedorEmail.TabIndex = 62
        Me.LBLProveedorEmail.Text = "Email"
        '
        'TXTEmailProveedor
        '
        Me.TXTEmailProveedor.Location = New System.Drawing.Point(185, 234)
        Me.TXTEmailProveedor.Name = "TXTEmailProveedor"
        Me.TXTEmailProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTEmailProveedor.TabIndex = 61
        '
        'LBLProveedorLocalidad
        '
        Me.LBLProveedorLocalidad.AutoSize = True
        Me.LBLProveedorLocalidad.Location = New System.Drawing.Point(358, 265)
        Me.LBLProveedorLocalidad.Name = "LBLProveedorLocalidad"
        Me.LBLProveedorLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LBLProveedorLocalidad.TabIndex = 60
        Me.LBLProveedorLocalidad.Text = "Localidad"
        '
        'LBLProveedorProvincia
        '
        Me.LBLProveedorProvincia.AutoSize = True
        Me.LBLProveedorProvincia.Location = New System.Drawing.Point(357, 237)
        Me.LBLProveedorProvincia.Name = "LBLProveedorProvincia"
        Me.LBLProveedorProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LBLProveedorProvincia.TabIndex = 59
        Me.LBLProveedorProvincia.Text = "Provincia"
        '
        'LBLProveedorPais
        '
        Me.LBLProveedorPais.AutoSize = True
        Me.LBLProveedorPais.Location = New System.Drawing.Point(357, 210)
        Me.LBLProveedorPais.Name = "LBLProveedorPais"
        Me.LBLProveedorPais.Size = New System.Drawing.Size(27, 13)
        Me.LBLProveedorPais.TabIndex = 58
        Me.LBLProveedorPais.Text = "Pais"
        '
        'CMBLocalidadProveedor
        '
        Me.CMBLocalidadProveedor.FormattingEnabled = True
        Me.CMBLocalidadProveedor.Location = New System.Drawing.Point(480, 265)
        Me.CMBLocalidadProveedor.Name = "CMBLocalidadProveedor"
        Me.CMBLocalidadProveedor.Size = New System.Drawing.Size(121, 21)
        Me.CMBLocalidadProveedor.TabIndex = 57
        '
        'CMBProvinciaProveedor
        '
        Me.CMBProvinciaProveedor.FormattingEnabled = True
        Me.CMBProvinciaProveedor.Location = New System.Drawing.Point(480, 237)
        Me.CMBProvinciaProveedor.Name = "CMBProvinciaProveedor"
        Me.CMBProvinciaProveedor.Size = New System.Drawing.Size(121, 21)
        Me.CMBProvinciaProveedor.TabIndex = 56
        '
        'CMBPaisProveedor
        '
        Me.CMBPaisProveedor.FormattingEnabled = True
        Me.CMBPaisProveedor.Location = New System.Drawing.Point(480, 208)
        Me.CMBPaisProveedor.Name = "CMBPaisProveedor"
        Me.CMBPaisProveedor.Size = New System.Drawing.Size(121, 21)
        Me.CMBPaisProveedor.TabIndex = 55
        '
        'LBLProveedorDepartamento
        '
        Me.LBLProveedorDepartamento.AutoSize = True
        Me.LBLProveedorDepartamento.Location = New System.Drawing.Point(65, 214)
        Me.LBLProveedorDepartamento.Name = "LBLProveedorDepartamento"
        Me.LBLProveedorDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.LBLProveedorDepartamento.TabIndex = 54
        Me.LBLProveedorDepartamento.Text = "Departamento"
        '
        'TXTDepartamentoProveedor
        '
        Me.TXTDepartamentoProveedor.Location = New System.Drawing.Point(185, 208)
        Me.TXTDepartamentoProveedor.Name = "TXTDepartamentoProveedor"
        Me.TXTDepartamentoProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTDepartamentoProveedor.TabIndex = 53
        '
        'TXTPisoProveedor
        '
        Me.TXTPisoProveedor.Location = New System.Drawing.Point(185, 181)
        Me.TXTPisoProveedor.Name = "TXTPisoProveedor"
        Me.TXTPisoProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTPisoProveedor.TabIndex = 52
        '
        'LBLProveedorPiso
        '
        Me.LBLProveedorPiso.AutoSize = True
        Me.LBLProveedorPiso.Location = New System.Drawing.Point(66, 189)
        Me.LBLProveedorPiso.Name = "LBLProveedorPiso"
        Me.LBLProveedorPiso.Size = New System.Drawing.Size(27, 13)
        Me.LBLProveedorPiso.TabIndex = 51
        Me.LBLProveedorPiso.Text = "Piso"
        '
        'TXTNroPuertaProveedor
        '
        Me.TXTNroPuertaProveedor.Location = New System.Drawing.Point(185, 151)
        Me.TXTNroPuertaProveedor.Name = "TXTNroPuertaProveedor"
        Me.TXTNroPuertaProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroPuertaProveedor.TabIndex = 48
        '
        'TXTCalleProveedor
        '
        Me.TXTCalleProveedor.Location = New System.Drawing.Point(185, 124)
        Me.TXTCalleProveedor.Name = "TXTCalleProveedor"
        Me.TXTCalleProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTCalleProveedor.TabIndex = 47
        '
        'TXTCuitProveedor
        '
        Me.TXTCuitProveedor.Location = New System.Drawing.Point(185, 97)
        Me.TXTCuitProveedor.Name = "TXTCuitProveedor"
        Me.TXTCuitProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTCuitProveedor.TabIndex = 46
        '
        'LBLProveedorPuerta
        '
        Me.LBLProveedorPuerta.AutoSize = True
        Me.LBLProveedorPuerta.Location = New System.Drawing.Point(65, 160)
        Me.LBLProveedorPuerta.Name = "LBLProveedorPuerta"
        Me.LBLProveedorPuerta.Size = New System.Drawing.Size(72, 13)
        Me.LBLProveedorPuerta.TabIndex = 45
        Me.LBLProveedorPuerta.Text = "Nro de puerta"
        '
        'LBLProveedorCalle
        '
        Me.LBLProveedorCalle.AutoSize = True
        Me.LBLProveedorCalle.Location = New System.Drawing.Point(65, 132)
        Me.LBLProveedorCalle.Name = "LBLProveedorCalle"
        Me.LBLProveedorCalle.Size = New System.Drawing.Size(30, 13)
        Me.LBLProveedorCalle.TabIndex = 44
        Me.LBLProveedorCalle.Text = "Calle"
        '
        'LBLCUITProveedor
        '
        Me.LBLCUITProveedor.AutoSize = True
        Me.LBLCUITProveedor.Location = New System.Drawing.Point(66, 100)
        Me.LBLCUITProveedor.Name = "LBLCUITProveedor"
        Me.LBLCUITProveedor.Size = New System.Drawing.Size(32, 13)
        Me.LBLCUITProveedor.TabIndex = 43
        Me.LBLCUITProveedor.Text = "CUIT"
        '
        'LBLNombreProveedor
        '
        Me.LBLNombreProveedor.AutoSize = True
        Me.LBLNombreProveedor.Location = New System.Drawing.Point(62, 71)
        Me.LBLNombreProveedor.Name = "LBLNombreProveedor"
        Me.LBLNombreProveedor.Size = New System.Drawing.Size(44, 13)
        Me.LBLNombreProveedor.TabIndex = 41
        Me.LBLNombreProveedor.Text = "Nombre"
        '
        'LBLIdProveedor
        '
        Me.LBLIdProveedor.AutoSize = True
        Me.LBLIdProveedor.Location = New System.Drawing.Point(67, 45)
        Me.LBLIdProveedor.Name = "LBLIdProveedor"
        Me.LBLIdProveedor.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdProveedor.TabIndex = 40
        Me.LBLIdProveedor.Text = "Id"
        '
        'TXTNombreProveedor
        '
        Me.TXTNombreProveedor.Location = New System.Drawing.Point(185, 71)
        Me.TXTNombreProveedor.Name = "TXTNombreProveedor"
        Me.TXTNombreProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombreProveedor.TabIndex = 38
        '
        'TXTIdProveedor
        '
        Me.TXTIdProveedor.Location = New System.Drawing.Point(185, 45)
        Me.TXTIdProveedor.Name = "TXTIdProveedor"
        Me.TXTIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdProveedor.TabIndex = 37
        '
        'LBLEstadoProveedor
        '
        Me.LBLEstadoProveedor.AutoSize = True
        Me.LBLEstadoProveedor.Location = New System.Drawing.Point(357, 182)
        Me.LBLEstadoProveedor.Name = "LBLEstadoProveedor"
        Me.LBLEstadoProveedor.Size = New System.Drawing.Size(40, 13)
        Me.LBLEstadoProveedor.TabIndex = 71
        Me.LBLEstadoProveedor.Text = "Estado"
        '
        'CMBEstadoProveedor
        '
        Me.CMBEstadoProveedor.FormattingEnabled = True
        Me.CMBEstadoProveedor.Location = New System.Drawing.Point(480, 180)
        Me.CMBEstadoProveedor.Name = "CMBEstadoProveedor"
        Me.CMBEstadoProveedor.Size = New System.Drawing.Size(121, 21)
        Me.CMBEstadoProveedor.TabIndex = 70
        '
        'GestionarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 469)
        Me.Controls.Add(Me.LBLEstadoProveedor)
        Me.Controls.Add(Me.CMBEstadoProveedor)
        Me.Controls.Add(Me.BTNEliminarProveedor)
        Me.Controls.Add(Me.BTNLimpiarPantallaProveedor)
        Me.Controls.Add(Me.BTNBuscarProveedor)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BTNGuardarProveedor)
        Me.Controls.Add(Me.LBLProveedorTelefono)
        Me.Controls.Add(Me.TXTTelefonoProveedor)
        Me.Controls.Add(Me.LBLProveedorEmail)
        Me.Controls.Add(Me.TXTEmailProveedor)
        Me.Controls.Add(Me.LBLProveedorLocalidad)
        Me.Controls.Add(Me.LBLProveedorProvincia)
        Me.Controls.Add(Me.LBLProveedorPais)
        Me.Controls.Add(Me.CMBLocalidadProveedor)
        Me.Controls.Add(Me.CMBProvinciaProveedor)
        Me.Controls.Add(Me.CMBPaisProveedor)
        Me.Controls.Add(Me.LBLProveedorDepartamento)
        Me.Controls.Add(Me.TXTDepartamentoProveedor)
        Me.Controls.Add(Me.TXTPisoProveedor)
        Me.Controls.Add(Me.LBLProveedorPiso)
        Me.Controls.Add(Me.TXTNroPuertaProveedor)
        Me.Controls.Add(Me.TXTCalleProveedor)
        Me.Controls.Add(Me.TXTCuitProveedor)
        Me.Controls.Add(Me.LBLProveedorPuerta)
        Me.Controls.Add(Me.LBLProveedorCalle)
        Me.Controls.Add(Me.LBLCUITProveedor)
        Me.Controls.Add(Me.LBLNombreProveedor)
        Me.Controls.Add(Me.LBLIdProveedor)
        Me.Controls.Add(Me.TXTNombreProveedor)
        Me.Controls.Add(Me.TXTIdProveedor)
        Me.Name = "GestionarProveedores"
        Me.Text = "GestionarProveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNEliminarProveedor As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarPantallaProveedor As System.Windows.Forms.Button
    Friend WithEvents BTNBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents BTNGuardarProveedor As System.Windows.Forms.Button
    Friend WithEvents LBLProveedorTelefono As System.Windows.Forms.Label
    Friend WithEvents TXTTelefonoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents LBLProveedorEmail As System.Windows.Forms.Label
    Friend WithEvents TXTEmailProveedor As System.Windows.Forms.TextBox
    Friend WithEvents LBLProveedorLocalidad As System.Windows.Forms.Label
    Friend WithEvents LBLProveedorProvincia As System.Windows.Forms.Label
    Friend WithEvents LBLProveedorPais As System.Windows.Forms.Label
    Friend WithEvents CMBLocalidadProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents CMBProvinciaProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents CMBPaisProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents LBLProveedorDepartamento As System.Windows.Forms.Label
    Friend WithEvents TXTDepartamentoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TXTPisoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents LBLProveedorPiso As System.Windows.Forms.Label
    Friend WithEvents TXTNroPuertaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TXTCalleProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TXTCuitProveedor As System.Windows.Forms.TextBox
    Friend WithEvents LBLProveedorPuerta As System.Windows.Forms.Label
    Friend WithEvents LBLProveedorCalle As System.Windows.Forms.Label
    Friend WithEvents LBLCUITProveedor As System.Windows.Forms.Label
    Friend WithEvents LBLNombreProveedor As System.Windows.Forms.Label
    Friend WithEvents LBLIdProveedor As System.Windows.Forms.Label
    Friend WithEvents TXTNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TXTIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents LBLEstadoProveedor As System.Windows.Forms.Label
    Friend WithEvents CMBEstadoProveedor As System.Windows.Forms.ComboBox
End Class
