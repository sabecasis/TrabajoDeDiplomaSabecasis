<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarEmpleado
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
        Me.TXTNroEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.LBLEmpleadoId = New System.Windows.Forms.Label()
        Me.LBLEmpleadoNombre = New System.Windows.Forms.Label()
        Me.LBLEmpleadoApellido = New System.Windows.Forms.Label()
        Me.LBLNroDocumento = New System.Windows.Forms.Label()
        Me.LBLEmpleadoCalle = New System.Windows.Forms.Label()
        Me.LBLEmpleadoPuerta = New System.Windows.Forms.Label()
        Me.TXTNroDocumentoEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTCalleEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTNroPuertaEmpleado = New System.Windows.Forms.TextBox()
        Me.LBLEmpleadoTipoDoc = New System.Windows.Forms.Label()
        Me.CMBTipoDocEmpleado = New System.Windows.Forms.ComboBox()
        Me.LBLEmpleadoPiso = New System.Windows.Forms.Label()
        Me.TXTPisoEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTDepartamentoEmpleado = New System.Windows.Forms.TextBox()
        Me.LBLEmpleadoDepartamento = New System.Windows.Forms.Label()
        Me.CMBPaisEmpleado = New System.Windows.Forms.ComboBox()
        Me.CMBProvinciaEmpleado = New System.Windows.Forms.ComboBox()
        Me.CMBLocalidadEmpleado = New System.Windows.Forms.ComboBox()
        Me.LBLEmpleadoPais = New System.Windows.Forms.Label()
        Me.LBLEmpleadoProvincia = New System.Windows.Forms.Label()
        Me.LBLEmpleadoLocalidad = New System.Windows.Forms.Label()
        Me.TXTEmailEmpleado = New System.Windows.Forms.TextBox()
        Me.LBLEmpleadoEmail = New System.Windows.Forms.Label()
        Me.TXTTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.LBLEmpleadoTelefono = New System.Windows.Forms.Label()
        Me.BTNGuardarEmpleado = New System.Windows.Forms.Button()
        Me.DGVPuestoEmpleado = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BTNGuardarPuestos = New System.Windows.Forms.Button()
        Me.LBLMensajeEmpleado = New System.Windows.Forms.Label()
        Me.BTNBuscarEmpleado = New System.Windows.Forms.Button()
        Me.BTNLimpiarPantallaEmpleado = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLPaisDepEmpl = New System.Windows.Forms.Label()
        Me.TXTPaisDeposito = New System.Windows.Forms.TextBox()
        Me.LBLProvDepEmpl = New System.Windows.Forms.Label()
        Me.TXTProvinciaDeposito = New System.Windows.Forms.TextBox()
        Me.TXTLocalidadDeposito = New System.Windows.Forms.TextBox()
        Me.LBLLocDepEmpl = New System.Windows.Forms.Label()
        Me.LBLDeptoDepEmpl = New System.Windows.Forms.Label()
        Me.TXTDepartamentoDeposito = New System.Windows.Forms.TextBox()
        Me.TXTPisoDeposito = New System.Windows.Forms.TextBox()
        Me.LBLPisoDepEmpl = New System.Windows.Forms.Label()
        Me.TXTNroPuertaDeposito = New System.Windows.Forms.TextBox()
        Me.TXTCalleDeposito = New System.Windows.Forms.TextBox()
        Me.LBLNroPDepEmpl = New System.Windows.Forms.Label()
        Me.LBLCalleDepositoEmpl = New System.Windows.Forms.Label()
        Me.LSTDepositosAsignados = New System.Windows.Forms.ListBox()
        Me.LSTDepositosNoAsignados = New System.Windows.Forms.ListBox()
        Me.BTNDesasignar = New System.Windows.Forms.Button()
        Me.BTNAsignar = New System.Windows.Forms.Button()
        Me.LBLDepositosAsignados = New System.Windows.Forms.Label()
        Me.LBLDepositosNoAsignados = New System.Windows.Forms.Label()
        Me.LBLIdEmpleado = New System.Windows.Forms.Label()
        CType(Me.DGVPuestoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTNroEmpleado
        '
        Me.TXTNroEmpleado.Location = New System.Drawing.Point(150, 46)
        Me.TXTNroEmpleado.Name = "TXTNroEmpleado"
        Me.TXTNroEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroEmpleado.TabIndex = 0
        '
        'TXTNombreEmpleado
        '
        Me.TXTNombreEmpleado.Location = New System.Drawing.Point(150, 72)
        Me.TXTNombreEmpleado.Name = "TXTNombreEmpleado"
        Me.TXTNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombreEmpleado.TabIndex = 1
        '
        'TXTApellidoEmpleado
        '
        Me.TXTApellidoEmpleado.Location = New System.Drawing.Point(150, 98)
        Me.TXTApellidoEmpleado.Name = "TXTApellidoEmpleado"
        Me.TXTApellidoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTApellidoEmpleado.TabIndex = 2
        '
        'LBLEmpleadoId
        '
        Me.LBLEmpleadoId.AutoSize = True
        Me.LBLEmpleadoId.Location = New System.Drawing.Point(28, 46)
        Me.LBLEmpleadoId.Name = "LBLEmpleadoId"
        Me.LBLEmpleadoId.Size = New System.Drawing.Size(74, 13)
        Me.LBLEmpleadoId.TabIndex = 3
        Me.LBLEmpleadoId.Text = "Nro Empleado"
        '
        'LBLEmpleadoNombre
        '
        Me.LBLEmpleadoNombre.AutoSize = True
        Me.LBLEmpleadoNombre.Location = New System.Drawing.Point(27, 72)
        Me.LBLEmpleadoNombre.Name = "LBLEmpleadoNombre"
        Me.LBLEmpleadoNombre.Size = New System.Drawing.Size(44, 13)
        Me.LBLEmpleadoNombre.TabIndex = 4
        Me.LBLEmpleadoNombre.Text = "Nombre"
        '
        'LBLEmpleadoApellido
        '
        Me.LBLEmpleadoApellido.AutoSize = True
        Me.LBLEmpleadoApellido.Location = New System.Drawing.Point(27, 101)
        Me.LBLEmpleadoApellido.Name = "LBLEmpleadoApellido"
        Me.LBLEmpleadoApellido.Size = New System.Drawing.Size(44, 13)
        Me.LBLEmpleadoApellido.TabIndex = 5
        Me.LBLEmpleadoApellido.Text = "Apellido"
        '
        'LBLNroDocumento
        '
        Me.LBLNroDocumento.AutoSize = True
        Me.LBLNroDocumento.Location = New System.Drawing.Point(24, 128)
        Me.LBLNroDocumento.Name = "LBLNroDocumento"
        Me.LBLNroDocumento.Size = New System.Drawing.Size(82, 13)
        Me.LBLNroDocumento.TabIndex = 6
        Me.LBLNroDocumento.Text = "Nro Documento"
        '
        'LBLEmpleadoCalle
        '
        Me.LBLEmpleadoCalle.AutoSize = True
        Me.LBLEmpleadoCalle.Location = New System.Drawing.Point(30, 159)
        Me.LBLEmpleadoCalle.Name = "LBLEmpleadoCalle"
        Me.LBLEmpleadoCalle.Size = New System.Drawing.Size(30, 13)
        Me.LBLEmpleadoCalle.TabIndex = 7
        Me.LBLEmpleadoCalle.Text = "Calle"
        '
        'LBLEmpleadoPuerta
        '
        Me.LBLEmpleadoPuerta.AutoSize = True
        Me.LBLEmpleadoPuerta.Location = New System.Drawing.Point(30, 187)
        Me.LBLEmpleadoPuerta.Name = "LBLEmpleadoPuerta"
        Me.LBLEmpleadoPuerta.Size = New System.Drawing.Size(72, 13)
        Me.LBLEmpleadoPuerta.TabIndex = 8
        Me.LBLEmpleadoPuerta.Text = "Nro de puerta"
        '
        'TXTNroDocumentoEmpleado
        '
        Me.TXTNroDocumentoEmpleado.Location = New System.Drawing.Point(150, 124)
        Me.TXTNroDocumentoEmpleado.Name = "TXTNroDocumentoEmpleado"
        Me.TXTNroDocumentoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroDocumentoEmpleado.TabIndex = 9
        '
        'TXTCalleEmpleado
        '
        Me.TXTCalleEmpleado.Location = New System.Drawing.Point(150, 151)
        Me.TXTCalleEmpleado.Name = "TXTCalleEmpleado"
        Me.TXTCalleEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTCalleEmpleado.TabIndex = 10
        '
        'TXTNroPuertaEmpleado
        '
        Me.TXTNroPuertaEmpleado.Location = New System.Drawing.Point(150, 178)
        Me.TXTNroPuertaEmpleado.Name = "TXTNroPuertaEmpleado"
        Me.TXTNroPuertaEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroPuertaEmpleado.TabIndex = 11
        '
        'LBLEmpleadoTipoDoc
        '
        Me.LBLEmpleadoTipoDoc.AutoSize = True
        Me.LBLEmpleadoTipoDoc.Location = New System.Drawing.Point(324, 127)
        Me.LBLEmpleadoTipoDoc.Name = "LBLEmpleadoTipoDoc"
        Me.LBLEmpleadoTipoDoc.Size = New System.Drawing.Size(84, 13)
        Me.LBLEmpleadoTipoDoc.TabIndex = 12
        Me.LBLEmpleadoTipoDoc.Text = "Tipo documento"
        '
        'CMBTipoDocEmpleado
        '
        Me.CMBTipoDocEmpleado.FormattingEnabled = True
        Me.CMBTipoDocEmpleado.Location = New System.Drawing.Point(450, 120)
        Me.CMBTipoDocEmpleado.Name = "CMBTipoDocEmpleado"
        Me.CMBTipoDocEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.CMBTipoDocEmpleado.TabIndex = 13
        '
        'LBLEmpleadoPiso
        '
        Me.LBLEmpleadoPiso.AutoSize = True
        Me.LBLEmpleadoPiso.Location = New System.Drawing.Point(31, 216)
        Me.LBLEmpleadoPiso.Name = "LBLEmpleadoPiso"
        Me.LBLEmpleadoPiso.Size = New System.Drawing.Size(27, 13)
        Me.LBLEmpleadoPiso.TabIndex = 14
        Me.LBLEmpleadoPiso.Text = "Piso"
        '
        'TXTPisoEmpleado
        '
        Me.TXTPisoEmpleado.Location = New System.Drawing.Point(150, 208)
        Me.TXTPisoEmpleado.Name = "TXTPisoEmpleado"
        Me.TXTPisoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTPisoEmpleado.TabIndex = 15
        Me.TXTPisoEmpleado.Text = "0"
        '
        'TXTDepartamentoEmpleado
        '
        Me.TXTDepartamentoEmpleado.Location = New System.Drawing.Point(150, 235)
        Me.TXTDepartamentoEmpleado.Name = "TXTDepartamentoEmpleado"
        Me.TXTDepartamentoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTDepartamentoEmpleado.TabIndex = 16
        '
        'LBLEmpleadoDepartamento
        '
        Me.LBLEmpleadoDepartamento.AutoSize = True
        Me.LBLEmpleadoDepartamento.Location = New System.Drawing.Point(30, 241)
        Me.LBLEmpleadoDepartamento.Name = "LBLEmpleadoDepartamento"
        Me.LBLEmpleadoDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.LBLEmpleadoDepartamento.TabIndex = 17
        Me.LBLEmpleadoDepartamento.Text = "Departamento"
        '
        'CMBPaisEmpleado
        '
        Me.CMBPaisEmpleado.FormattingEnabled = True
        Me.CMBPaisEmpleado.Location = New System.Drawing.Point(450, 149)
        Me.CMBPaisEmpleado.Name = "CMBPaisEmpleado"
        Me.CMBPaisEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.CMBPaisEmpleado.TabIndex = 18
        '
        'CMBProvinciaEmpleado
        '
        Me.CMBProvinciaEmpleado.FormattingEnabled = True
        Me.CMBProvinciaEmpleado.Location = New System.Drawing.Point(450, 178)
        Me.CMBProvinciaEmpleado.Name = "CMBProvinciaEmpleado"
        Me.CMBProvinciaEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.CMBProvinciaEmpleado.TabIndex = 19
        '
        'CMBLocalidadEmpleado
        '
        Me.CMBLocalidadEmpleado.FormattingEnabled = True
        Me.CMBLocalidadEmpleado.Location = New System.Drawing.Point(450, 206)
        Me.CMBLocalidadEmpleado.Name = "CMBLocalidadEmpleado"
        Me.CMBLocalidadEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.CMBLocalidadEmpleado.TabIndex = 20
        '
        'LBLEmpleadoPais
        '
        Me.LBLEmpleadoPais.AutoSize = True
        Me.LBLEmpleadoPais.Location = New System.Drawing.Point(327, 151)
        Me.LBLEmpleadoPais.Name = "LBLEmpleadoPais"
        Me.LBLEmpleadoPais.Size = New System.Drawing.Size(27, 13)
        Me.LBLEmpleadoPais.TabIndex = 21
        Me.LBLEmpleadoPais.Text = "Pais"
        '
        'LBLEmpleadoProvincia
        '
        Me.LBLEmpleadoProvincia.AutoSize = True
        Me.LBLEmpleadoProvincia.Location = New System.Drawing.Point(327, 178)
        Me.LBLEmpleadoProvincia.Name = "LBLEmpleadoProvincia"
        Me.LBLEmpleadoProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LBLEmpleadoProvincia.TabIndex = 22
        Me.LBLEmpleadoProvincia.Text = "Provincia"
        '
        'LBLEmpleadoLocalidad
        '
        Me.LBLEmpleadoLocalidad.AutoSize = True
        Me.LBLEmpleadoLocalidad.Location = New System.Drawing.Point(328, 206)
        Me.LBLEmpleadoLocalidad.Name = "LBLEmpleadoLocalidad"
        Me.LBLEmpleadoLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LBLEmpleadoLocalidad.TabIndex = 23
        Me.LBLEmpleadoLocalidad.Text = "Localidad"
        '
        'TXTEmailEmpleado
        '
        Me.TXTEmailEmpleado.Location = New System.Drawing.Point(150, 261)
        Me.TXTEmailEmpleado.Name = "TXTEmailEmpleado"
        Me.TXTEmailEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTEmailEmpleado.TabIndex = 24
        '
        'LBLEmpleadoEmail
        '
        Me.LBLEmpleadoEmail.AutoSize = True
        Me.LBLEmpleadoEmail.Location = New System.Drawing.Point(30, 264)
        Me.LBLEmpleadoEmail.Name = "LBLEmpleadoEmail"
        Me.LBLEmpleadoEmail.Size = New System.Drawing.Size(32, 13)
        Me.LBLEmpleadoEmail.TabIndex = 25
        Me.LBLEmpleadoEmail.Text = "Email"
        '
        'TXTTelefonoEmpleado
        '
        Me.TXTTelefonoEmpleado.Location = New System.Drawing.Point(150, 288)
        Me.TXTTelefonoEmpleado.Name = "TXTTelefonoEmpleado"
        Me.TXTTelefonoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTTelefonoEmpleado.TabIndex = 26
        '
        'LBLEmpleadoTelefono
        '
        Me.LBLEmpleadoTelefono.AutoSize = True
        Me.LBLEmpleadoTelefono.Location = New System.Drawing.Point(31, 291)
        Me.LBLEmpleadoTelefono.Name = "LBLEmpleadoTelefono"
        Me.LBLEmpleadoTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LBLEmpleadoTelefono.TabIndex = 27
        Me.LBLEmpleadoTelefono.Text = "Teléfono"
        '
        'BTNGuardarEmpleado
        '
        Me.BTNGuardarEmpleado.Location = New System.Drawing.Point(34, 359)
        Me.BTNGuardarEmpleado.Name = "BTNGuardarEmpleado"
        Me.BTNGuardarEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarEmpleado.TabIndex = 28
        Me.BTNGuardarEmpleado.Text = "Guardar"
        Me.BTNGuardarEmpleado.UseVisualStyleBackColor = True
        '
        'DGVPuestoEmpleado
        '
        Me.DGVPuestoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPuestoEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.puesto, Me.codigo, Me.Seleccionar})
        Me.DGVPuestoEmpleado.Location = New System.Drawing.Point(331, 241)
        Me.DGVPuestoEmpleado.Name = "DGVPuestoEmpleado"
        Me.DGVPuestoEmpleado.Size = New System.Drawing.Size(403, 229)
        Me.DGVPuestoEmpleado.TabIndex = 29
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'puesto
        '
        Me.puesto.DataPropertyName = "puesto"
        Me.puesto.HeaderText = "puesto"
        Me.puesto.Name = "puesto"
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        '
        'BTNGuardarPuestos
        '
        Me.BTNGuardarPuestos.Location = New System.Drawing.Point(331, 476)
        Me.BTNGuardarPuestos.Name = "BTNGuardarPuestos"
        Me.BTNGuardarPuestos.Size = New System.Drawing.Size(289, 23)
        Me.BTNGuardarPuestos.TabIndex = 31
        Me.BTNGuardarPuestos.Text = "Guardar Puestos"
        Me.BTNGuardarPuestos.UseVisualStyleBackColor = True
        '
        'LBLMensajeEmpleado
        '
        Me.LBLMensajeEmpleado.AutoSize = True
        Me.LBLMensajeEmpleado.ForeColor = System.Drawing.Color.Red
        Me.LBLMensajeEmpleado.Location = New System.Drawing.Point(327, 53)
        Me.LBLMensajeEmpleado.Name = "LBLMensajeEmpleado"
        Me.LBLMensajeEmpleado.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensajeEmpleado.TabIndex = 32
        '
        'BTNBuscarEmpleado
        '
        Me.BTNBuscarEmpleado.Location = New System.Drawing.Point(135, 359)
        Me.BTNBuscarEmpleado.Name = "BTNBuscarEmpleado"
        Me.BTNBuscarEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarEmpleado.TabIndex = 33
        Me.BTNBuscarEmpleado.Text = "Buscar"
        Me.BTNBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'BTNLimpiarPantallaEmpleado
        '
        Me.BTNLimpiarPantallaEmpleado.Location = New System.Drawing.Point(34, 400)
        Me.BTNLimpiarPantallaEmpleado.Name = "BTNLimpiarPantallaEmpleado"
        Me.BTNLimpiarPantallaEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarPantallaEmpleado.TabIndex = 34
        Me.BTNLimpiarPantallaEmpleado.Text = "Limpiar"
        Me.BTNLimpiarPantallaEmpleado.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(135, 400)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminar.TabIndex = 36
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'LBLPaisDepEmpl
        '
        Me.LBLPaisDepEmpl.AutoSize = True
        Me.LBLPaisDepEmpl.Location = New System.Drawing.Point(47, 712)
        Me.LBLPaisDepEmpl.Name = "LBLPaisDepEmpl"
        Me.LBLPaisDepEmpl.Size = New System.Drawing.Size(27, 13)
        Me.LBLPaisDepEmpl.TabIndex = 88
        Me.LBLPaisDepEmpl.Text = "Pais"
        '
        'TXTPaisDeposito
        '
        Me.TXTPaisDeposito.Location = New System.Drawing.Point(200, 709)
        Me.TXTPaisDeposito.Name = "TXTPaisDeposito"
        Me.TXTPaisDeposito.ReadOnly = True
        Me.TXTPaisDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTPaisDeposito.TabIndex = 87
        '
        'LBLProvDepEmpl
        '
        Me.LBLProvDepEmpl.AutoSize = True
        Me.LBLProvDepEmpl.Location = New System.Drawing.Point(44, 686)
        Me.LBLProvDepEmpl.Name = "LBLProvDepEmpl"
        Me.LBLProvDepEmpl.Size = New System.Drawing.Size(51, 13)
        Me.LBLProvDepEmpl.TabIndex = 86
        Me.LBLProvDepEmpl.Text = "Provincia"
        '
        'TXTProvinciaDeposito
        '
        Me.TXTProvinciaDeposito.Location = New System.Drawing.Point(200, 680)
        Me.TXTProvinciaDeposito.Name = "TXTProvinciaDeposito"
        Me.TXTProvinciaDeposito.ReadOnly = True
        Me.TXTProvinciaDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTProvinciaDeposito.TabIndex = 85
        '
        'TXTLocalidadDeposito
        '
        Me.TXTLocalidadDeposito.Location = New System.Drawing.Point(200, 653)
        Me.TXTLocalidadDeposito.Name = "TXTLocalidadDeposito"
        Me.TXTLocalidadDeposito.ReadOnly = True
        Me.TXTLocalidadDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTLocalidadDeposito.TabIndex = 84
        '
        'LBLLocDepEmpl
        '
        Me.LBLLocDepEmpl.AutoSize = True
        Me.LBLLocDepEmpl.Location = New System.Drawing.Point(45, 661)
        Me.LBLLocDepEmpl.Name = "LBLLocDepEmpl"
        Me.LBLLocDepEmpl.Size = New System.Drawing.Size(53, 13)
        Me.LBLLocDepEmpl.TabIndex = 83
        Me.LBLLocDepEmpl.Text = "Localidad"
        '
        'LBLDeptoDepEmpl
        '
        Me.LBLDeptoDepEmpl.AutoSize = True
        Me.LBLDeptoDepEmpl.Location = New System.Drawing.Point(44, 633)
        Me.LBLDeptoDepEmpl.Name = "LBLDeptoDepEmpl"
        Me.LBLDeptoDepEmpl.Size = New System.Drawing.Size(74, 13)
        Me.LBLDeptoDepEmpl.TabIndex = 82
        Me.LBLDeptoDepEmpl.Text = "Departamento"
        '
        'TXTDepartamentoDeposito
        '
        Me.TXTDepartamentoDeposito.Location = New System.Drawing.Point(200, 627)
        Me.TXTDepartamentoDeposito.Name = "TXTDepartamentoDeposito"
        Me.TXTDepartamentoDeposito.ReadOnly = True
        Me.TXTDepartamentoDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTDepartamentoDeposito.TabIndex = 81
        '
        'TXTPisoDeposito
        '
        Me.TXTPisoDeposito.Location = New System.Drawing.Point(200, 600)
        Me.TXTPisoDeposito.Name = "TXTPisoDeposito"
        Me.TXTPisoDeposito.ReadOnly = True
        Me.TXTPisoDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTPisoDeposito.TabIndex = 80
        '
        'LBLPisoDepEmpl
        '
        Me.LBLPisoDepEmpl.AutoSize = True
        Me.LBLPisoDepEmpl.Location = New System.Drawing.Point(45, 608)
        Me.LBLPisoDepEmpl.Name = "LBLPisoDepEmpl"
        Me.LBLPisoDepEmpl.Size = New System.Drawing.Size(27, 13)
        Me.LBLPisoDepEmpl.TabIndex = 79
        Me.LBLPisoDepEmpl.Text = "Piso"
        '
        'TXTNroPuertaDeposito
        '
        Me.TXTNroPuertaDeposito.Location = New System.Drawing.Point(200, 570)
        Me.TXTNroPuertaDeposito.Name = "TXTNroPuertaDeposito"
        Me.TXTNroPuertaDeposito.ReadOnly = True
        Me.TXTNroPuertaDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroPuertaDeposito.TabIndex = 78
        '
        'TXTCalleDeposito
        '
        Me.TXTCalleDeposito.Location = New System.Drawing.Point(200, 543)
        Me.TXTCalleDeposito.Name = "TXTCalleDeposito"
        Me.TXTCalleDeposito.ReadOnly = True
        Me.TXTCalleDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTCalleDeposito.TabIndex = 77
        '
        'LBLNroPDepEmpl
        '
        Me.LBLNroPDepEmpl.AutoSize = True
        Me.LBLNroPDepEmpl.Location = New System.Drawing.Point(44, 579)
        Me.LBLNroPDepEmpl.Name = "LBLNroPDepEmpl"
        Me.LBLNroPDepEmpl.Size = New System.Drawing.Size(72, 13)
        Me.LBLNroPDepEmpl.TabIndex = 76
        Me.LBLNroPDepEmpl.Text = "Nro de puerta"
        '
        'LBLCalleDepositoEmpl
        '
        Me.LBLCalleDepositoEmpl.AutoSize = True
        Me.LBLCalleDepositoEmpl.Location = New System.Drawing.Point(44, 551)
        Me.LBLCalleDepositoEmpl.Name = "LBLCalleDepositoEmpl"
        Me.LBLCalleDepositoEmpl.Size = New System.Drawing.Size(30, 13)
        Me.LBLCalleDepositoEmpl.TabIndex = 75
        Me.LBLCalleDepositoEmpl.Text = "Calle"
        '
        'LSTDepositosAsignados
        '
        Me.LSTDepositosAsignados.FormattingEnabled = True
        Me.LSTDepositosAsignados.Location = New System.Drawing.Point(568, 543)
        Me.LSTDepositosAsignados.Name = "LSTDepositosAsignados"
        Me.LSTDepositosAsignados.Size = New System.Drawing.Size(207, 186)
        Me.LSTDepositosAsignados.TabIndex = 74
        '
        'LSTDepositosNoAsignados
        '
        Me.LSTDepositosNoAsignados.FormattingEnabled = True
        Me.LSTDepositosNoAsignados.Location = New System.Drawing.Point(306, 543)
        Me.LSTDepositosNoAsignados.Name = "LSTDepositosNoAsignados"
        Me.LSTDepositosNoAsignados.Size = New System.Drawing.Size(176, 186)
        Me.LSTDepositosNoAsignados.TabIndex = 73
        '
        'BTNDesasignar
        '
        Me.BTNDesasignar.Location = New System.Drawing.Point(488, 615)
        Me.BTNDesasignar.Name = "BTNDesasignar"
        Me.BTNDesasignar.Size = New System.Drawing.Size(75, 23)
        Me.BTNDesasignar.TabIndex = 72
        Me.BTNDesasignar.Text = "<<"
        Me.BTNDesasignar.UseVisualStyleBackColor = True
        '
        'BTNAsignar
        '
        Me.BTNAsignar.Location = New System.Drawing.Point(488, 569)
        Me.BTNAsignar.Name = "BTNAsignar"
        Me.BTNAsignar.Size = New System.Drawing.Size(75, 23)
        Me.BTNAsignar.TabIndex = 71
        Me.BTNAsignar.Text = ">>"
        Me.BTNAsignar.UseVisualStyleBackColor = True
        '
        'LBLDepositosAsignados
        '
        Me.LBLDepositosAsignados.AutoSize = True
        Me.LBLDepositosAsignados.Location = New System.Drawing.Point(565, 517)
        Me.LBLDepositosAsignados.Name = "LBLDepositosAsignados"
        Me.LBLDepositosAsignados.Size = New System.Drawing.Size(105, 13)
        Me.LBLDepositosAsignados.TabIndex = 70
        Me.LBLDepositosAsignados.Text = "Depositos asignados"
        '
        'LBLDepositosNoAsignados
        '
        Me.LBLDepositosNoAsignados.AutoSize = True
        Me.LBLDepositosNoAsignados.Location = New System.Drawing.Point(300, 517)
        Me.LBLDepositosNoAsignados.Name = "LBLDepositosNoAsignados"
        Me.LBLDepositosNoAsignados.Size = New System.Drawing.Size(114, 13)
        Me.LBLDepositosNoAsignados.TabIndex = 69
        Me.LBLDepositosNoAsignados.Text = "Dpositos no asignados"
        '
        'LBLIdEmpleado
        '
        Me.LBLIdEmpleado.AutoSize = True
        Me.LBLIdEmpleado.Location = New System.Drawing.Point(28, 457)
        Me.LBLIdEmpleado.Name = "LBLIdEmpleado"
        Me.LBLIdEmpleado.Size = New System.Drawing.Size(13, 13)
        Me.LBLIdEmpleado.TabIndex = 35
        Me.LBLIdEmpleado.Text = "0"
        Me.LBLIdEmpleado.Visible = False
        '
        'GestionarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 741)
        Me.Controls.Add(Me.LBLPaisDepEmpl)
        Me.Controls.Add(Me.TXTPaisDeposito)
        Me.Controls.Add(Me.LBLProvDepEmpl)
        Me.Controls.Add(Me.TXTProvinciaDeposito)
        Me.Controls.Add(Me.TXTLocalidadDeposito)
        Me.Controls.Add(Me.LBLLocDepEmpl)
        Me.Controls.Add(Me.LBLDeptoDepEmpl)
        Me.Controls.Add(Me.TXTDepartamentoDeposito)
        Me.Controls.Add(Me.TXTPisoDeposito)
        Me.Controls.Add(Me.LBLPisoDepEmpl)
        Me.Controls.Add(Me.TXTNroPuertaDeposito)
        Me.Controls.Add(Me.TXTCalleDeposito)
        Me.Controls.Add(Me.LBLNroPDepEmpl)
        Me.Controls.Add(Me.LBLCalleDepositoEmpl)
        Me.Controls.Add(Me.LSTDepositosAsignados)
        Me.Controls.Add(Me.LSTDepositosNoAsignados)
        Me.Controls.Add(Me.BTNDesasignar)
        Me.Controls.Add(Me.BTNAsignar)
        Me.Controls.Add(Me.LBLDepositosAsignados)
        Me.Controls.Add(Me.LBLDepositosNoAsignados)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.LBLIdEmpleado)
        Me.Controls.Add(Me.BTNLimpiarPantallaEmpleado)
        Me.Controls.Add(Me.BTNBuscarEmpleado)
        Me.Controls.Add(Me.LBLMensajeEmpleado)
        Me.Controls.Add(Me.BTNGuardarPuestos)
        Me.Controls.Add(Me.DGVPuestoEmpleado)
        Me.Controls.Add(Me.BTNGuardarEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoTelefono)
        Me.Controls.Add(Me.TXTTelefonoEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoEmail)
        Me.Controls.Add(Me.TXTEmailEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoLocalidad)
        Me.Controls.Add(Me.LBLEmpleadoProvincia)
        Me.Controls.Add(Me.LBLEmpleadoPais)
        Me.Controls.Add(Me.CMBLocalidadEmpleado)
        Me.Controls.Add(Me.CMBProvinciaEmpleado)
        Me.Controls.Add(Me.CMBPaisEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoDepartamento)
        Me.Controls.Add(Me.TXTDepartamentoEmpleado)
        Me.Controls.Add(Me.TXTPisoEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoPiso)
        Me.Controls.Add(Me.CMBTipoDocEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoTipoDoc)
        Me.Controls.Add(Me.TXTNroPuertaEmpleado)
        Me.Controls.Add(Me.TXTCalleEmpleado)
        Me.Controls.Add(Me.TXTNroDocumentoEmpleado)
        Me.Controls.Add(Me.LBLEmpleadoPuerta)
        Me.Controls.Add(Me.LBLEmpleadoCalle)
        Me.Controls.Add(Me.LBLNroDocumento)
        Me.Controls.Add(Me.LBLEmpleadoApellido)
        Me.Controls.Add(Me.LBLEmpleadoNombre)
        Me.Controls.Add(Me.LBLEmpleadoId)
        Me.Controls.Add(Me.TXTApellidoEmpleado)
        Me.Controls.Add(Me.TXTNombreEmpleado)
        Me.Controls.Add(Me.TXTNroEmpleado)
        Me.Name = "GestionarEmpleado"
        Me.Text = "Gestión de empleados"
        CType(Me.DGVPuestoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTNroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTApellidoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LBLEmpleadoId As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoNombre As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoApellido As System.Windows.Forms.Label
    Friend WithEvents LBLNroDocumento As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoCalle As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoPuerta As System.Windows.Forms.Label
    Friend WithEvents TXTNroDocumentoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTCalleEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTNroPuertaEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LBLEmpleadoTipoDoc As System.Windows.Forms.Label
    Friend WithEvents CMBTipoDocEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents LBLEmpleadoPiso As System.Windows.Forms.Label
    Friend WithEvents TXTPisoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTDepartamentoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LBLEmpleadoDepartamento As System.Windows.Forms.Label
    Friend WithEvents CMBPaisEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents CMBProvinciaEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents CMBLocalidadEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents LBLEmpleadoPais As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoProvincia As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoLocalidad As System.Windows.Forms.Label
    Friend WithEvents TXTEmailEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LBLEmpleadoEmail As System.Windows.Forms.Label
    Friend WithEvents TXTTelefonoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LBLEmpleadoTelefono As System.Windows.Forms.Label
    Friend WithEvents BTNGuardarEmpleado As System.Windows.Forms.Button
    Friend WithEvents DGVPuestoEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents BTNGuardarPuestos As System.Windows.Forms.Button
    Friend WithEvents LBLMensajeEmpleado As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents puesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BTNBuscarEmpleado As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarPantallaEmpleado As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLPaisDepEmpl As System.Windows.Forms.Label
    Friend WithEvents TXTPaisDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLProvDepEmpl As System.Windows.Forms.Label
    Friend WithEvents TXTProvinciaDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TXTLocalidadDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLLocDepEmpl As System.Windows.Forms.Label
    Friend WithEvents LBLDeptoDepEmpl As System.Windows.Forms.Label
    Friend WithEvents TXTDepartamentoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TXTPisoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLPisoDepEmpl As System.Windows.Forms.Label
    Friend WithEvents TXTNroPuertaDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TXTCalleDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLNroPDepEmpl As System.Windows.Forms.Label
    Friend WithEvents LBLCalleDepositoEmpl As System.Windows.Forms.Label
    Friend WithEvents LSTDepositosAsignados As System.Windows.Forms.ListBox
    Friend WithEvents LSTDepositosNoAsignados As System.Windows.Forms.ListBox
    Friend WithEvents BTNDesasignar As System.Windows.Forms.Button
    Friend WithEvents BTNAsignar As System.Windows.Forms.Button
    Friend WithEvents LBLDepositosAsignados As System.Windows.Forms.Label
    Friend WithEvents LBLDepositosNoAsignados As System.Windows.Forms.Label
    Friend WithEvents LBLIdEmpleado As System.Windows.Forms.Label
End Class
