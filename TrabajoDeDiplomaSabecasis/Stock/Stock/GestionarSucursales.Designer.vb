<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarSucursales
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
        Me.TXTIdSucursal = New System.Windows.Forms.TextBox()
        Me.TXTCierreAct = New System.Windows.Forms.TextBox()
        Me.TexTXTInicioAct = New System.Windows.Forms.TextBox()
        Me.CMBEstado = New System.Windows.Forms.ComboBox()
        Me.LBLSucursalLocalidad = New System.Windows.Forms.Label()
        Me.LBLSucursalProvincia = New System.Windows.Forms.Label()
        Me.LBLSucursalPais = New System.Windows.Forms.Label()
        Me.CMBLocalidadSucursal = New System.Windows.Forms.ComboBox()
        Me.CMBProvinciaSucursal = New System.Windows.Forms.ComboBox()
        Me.CMBPaisSucursal = New System.Windows.Forms.ComboBox()
        Me.LBLSucursalTelefono = New System.Windows.Forms.Label()
        Me.TXTTelefonoSucursal = New System.Windows.Forms.TextBox()
        Me.LBLSucursalEmail = New System.Windows.Forms.Label()
        Me.TXTEmailSucursal = New System.Windows.Forms.TextBox()
        Me.LBLSucursalDepartamento = New System.Windows.Forms.Label()
        Me.TXTDepartamentoSucursal = New System.Windows.Forms.TextBox()
        Me.TXTPisoSucursal = New System.Windows.Forms.TextBox()
        Me.LBLSucursalPiso = New System.Windows.Forms.Label()
        Me.TXTNroPuertaSucursal = New System.Windows.Forms.TextBox()
        Me.TXTCalleSucursal = New System.Windows.Forms.TextBox()
        Me.LBLESucursalPuerta = New System.Windows.Forms.Label()
        Me.LBLSurusalCalle = New System.Windows.Forms.Label()
        Me.LBLIdSucursal = New System.Windows.Forms.Label()
        Me.LBLHorarioInicio = New System.Windows.Forms.Label()
        Me.LBLHorarioCierre = New System.Windows.Forms.Label()
        Me.LBLFechaApertura = New System.Windows.Forms.Label()
        Me.LBLFechaCierre = New System.Windows.Forms.Label()
        Me.LBLEstadoSucursal = New System.Windows.Forms.Label()
        Me.LSTDepositosAsignados = New System.Windows.Forms.ListBox()
        Me.LSTDepositosNoAsignados = New System.Windows.Forms.ListBox()
        Me.BTNDesasignar = New System.Windows.Forms.Button()
        Me.BTNAsignar = New System.Windows.Forms.Button()
        Me.LBLDepositosAsignados = New System.Windows.Forms.Label()
        Me.LBLDepositosNoAsignados = New System.Windows.Forms.Label()
        Me.LBLDeptoDepSuc = New System.Windows.Forms.Label()
        Me.TXTDepartamentoDeposito = New System.Windows.Forms.TextBox()
        Me.TXTPisoDeposito = New System.Windows.Forms.TextBox()
        Me.LBLPisoDepSuc = New System.Windows.Forms.Label()
        Me.TXTNroPuertaDeposito = New System.Windows.Forms.TextBox()
        Me.TXTCalleDeposito = New System.Windows.Forms.TextBox()
        Me.LBLNroPDepSuc = New System.Windows.Forms.Label()
        Me.LBLCalleDepositoSuc = New System.Windows.Forms.Label()
        Me.LBLProvDepSuc = New System.Windows.Forms.Label()
        Me.TXTProvinciaDeposito = New System.Windows.Forms.TextBox()
        Me.TXTLocalidadDeposito = New System.Windows.Forms.TextBox()
        Me.LBLLocDepSuc = New System.Windows.Forms.Label()
        Me.LBLPaisDepSuc = New System.Windows.Forms.Label()
        Me.TXTPaisDeposito = New System.Windows.Forms.TextBox()
        Me.BTNGuardarSucursal = New System.Windows.Forms.Button()
        Me.BTNBuscarSucursal = New System.Windows.Forms.Button()
        Me.BTNEliminarSucursal = New System.Windows.Forms.Button()
        Me.BTNLimpiarSucursal = New System.Windows.Forms.Button()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.TXTFechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.TXTFechaApetura = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TXTIdSucursal
        '
        Me.TXTIdSucursal.Location = New System.Drawing.Point(164, 44)
        Me.TXTIdSucursal.Name = "TXTIdSucursal"
        Me.TXTIdSucursal.Size = New System.Drawing.Size(74, 20)
        Me.TXTIdSucursal.TabIndex = 0
        Me.TXTIdSucursal.Text = "0"
        '
        'TXTCierreAct
        '
        Me.TXTCierreAct.Location = New System.Drawing.Point(164, 96)
        Me.TXTCierreAct.Name = "TXTCierreAct"
        Me.TXTCierreAct.Size = New System.Drawing.Size(121, 20)
        Me.TXTCierreAct.TabIndex = 4
        '
        'TexTXTInicioAct
        '
        Me.TexTXTInicioAct.Location = New System.Drawing.Point(164, 70)
        Me.TexTXTInicioAct.Name = "TexTXTInicioAct"
        Me.TexTXTInicioAct.Size = New System.Drawing.Size(121, 20)
        Me.TexTXTInicioAct.TabIndex = 5
        '
        'CMBEstado
        '
        Me.CMBEstado.FormattingEnabled = True
        Me.CMBEstado.Location = New System.Drawing.Point(164, 177)
        Me.CMBEstado.Name = "CMBEstado"
        Me.CMBEstado.Size = New System.Drawing.Size(121, 21)
        Me.CMBEstado.TabIndex = 6
        '
        'LBLSucursalLocalidad
        '
        Me.LBLSucursalLocalidad.AutoSize = True
        Me.LBLSucursalLocalidad.Location = New System.Drawing.Point(341, 260)
        Me.LBLSucursalLocalidad.Name = "LBLSucursalLocalidad"
        Me.LBLSucursalLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LBLSucursalLocalidad.TabIndex = 29
        Me.LBLSucursalLocalidad.Text = "Localidad"
        '
        'LBLSucursalProvincia
        '
        Me.LBLSucursalProvincia.AutoSize = True
        Me.LBLSucursalProvincia.Location = New System.Drawing.Point(340, 232)
        Me.LBLSucursalProvincia.Name = "LBLSucursalProvincia"
        Me.LBLSucursalProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LBLSucursalProvincia.TabIndex = 28
        Me.LBLSucursalProvincia.Text = "Provincia"
        '
        'LBLSucursalPais
        '
        Me.LBLSucursalPais.AutoSize = True
        Me.LBLSucursalPais.Location = New System.Drawing.Point(340, 205)
        Me.LBLSucursalPais.Name = "LBLSucursalPais"
        Me.LBLSucursalPais.Size = New System.Drawing.Size(27, 13)
        Me.LBLSucursalPais.TabIndex = 27
        Me.LBLSucursalPais.Text = "Pais"
        '
        'CMBLocalidadSucursal
        '
        Me.CMBLocalidadSucursal.FormattingEnabled = True
        Me.CMBLocalidadSucursal.Location = New System.Drawing.Point(459, 260)
        Me.CMBLocalidadSucursal.Name = "CMBLocalidadSucursal"
        Me.CMBLocalidadSucursal.Size = New System.Drawing.Size(121, 21)
        Me.CMBLocalidadSucursal.TabIndex = 26
        '
        'CMBProvinciaSucursal
        '
        Me.CMBProvinciaSucursal.FormattingEnabled = True
        Me.CMBProvinciaSucursal.Location = New System.Drawing.Point(459, 232)
        Me.CMBProvinciaSucursal.Name = "CMBProvinciaSucursal"
        Me.CMBProvinciaSucursal.Size = New System.Drawing.Size(121, 21)
        Me.CMBProvinciaSucursal.TabIndex = 25
        '
        'CMBPaisSucursal
        '
        Me.CMBPaisSucursal.FormattingEnabled = True
        Me.CMBPaisSucursal.Location = New System.Drawing.Point(459, 203)
        Me.CMBPaisSucursal.Name = "CMBPaisSucursal"
        Me.CMBPaisSucursal.Size = New System.Drawing.Size(121, 21)
        Me.CMBPaisSucursal.TabIndex = 24
        '
        'LBLSucursalTelefono
        '
        Me.LBLSucursalTelefono.AutoSize = True
        Me.LBLSucursalTelefono.Location = New System.Drawing.Point(339, 180)
        Me.LBLSucursalTelefono.Name = "LBLSucursalTelefono"
        Me.LBLSucursalTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LBLSucursalTelefono.TabIndex = 41
        Me.LBLSucursalTelefono.Text = "Teléfono"
        '
        'TXTTelefonoSucursal
        '
        Me.TXTTelefonoSucursal.Location = New System.Drawing.Point(459, 177)
        Me.TXTTelefonoSucursal.Name = "TXTTelefonoSucursal"
        Me.TXTTelefonoSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TXTTelefonoSucursal.TabIndex = 40
        '
        'LBLSucursalEmail
        '
        Me.LBLSucursalEmail.AutoSize = True
        Me.LBLSucursalEmail.Location = New System.Drawing.Point(339, 153)
        Me.LBLSucursalEmail.Name = "LBLSucursalEmail"
        Me.LBLSucursalEmail.Size = New System.Drawing.Size(32, 13)
        Me.LBLSucursalEmail.TabIndex = 39
        Me.LBLSucursalEmail.Text = "Email"
        '
        'TXTEmailSucursal
        '
        Me.TXTEmailSucursal.Location = New System.Drawing.Point(459, 150)
        Me.TXTEmailSucursal.Name = "TXTEmailSucursal"
        Me.TXTEmailSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TXTEmailSucursal.TabIndex = 38
        '
        'LBLSucursalDepartamento
        '
        Me.LBLSucursalDepartamento.AutoSize = True
        Me.LBLSucursalDepartamento.Location = New System.Drawing.Point(339, 130)
        Me.LBLSucursalDepartamento.Name = "LBLSucursalDepartamento"
        Me.LBLSucursalDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.LBLSucursalDepartamento.TabIndex = 37
        Me.LBLSucursalDepartamento.Text = "Departamento"
        '
        'TXTDepartamentoSucursal
        '
        Me.TXTDepartamentoSucursal.Location = New System.Drawing.Point(459, 124)
        Me.TXTDepartamentoSucursal.Name = "TXTDepartamentoSucursal"
        Me.TXTDepartamentoSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TXTDepartamentoSucursal.TabIndex = 36
        '
        'TXTPisoSucursal
        '
        Me.TXTPisoSucursal.Location = New System.Drawing.Point(459, 97)
        Me.TXTPisoSucursal.Name = "TXTPisoSucursal"
        Me.TXTPisoSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TXTPisoSucursal.TabIndex = 35
        '
        'LBLSucursalPiso
        '
        Me.LBLSucursalPiso.AutoSize = True
        Me.LBLSucursalPiso.Location = New System.Drawing.Point(340, 105)
        Me.LBLSucursalPiso.Name = "LBLSucursalPiso"
        Me.LBLSucursalPiso.Size = New System.Drawing.Size(27, 13)
        Me.LBLSucursalPiso.TabIndex = 34
        Me.LBLSucursalPiso.Text = "Piso"
        '
        'TXTNroPuertaSucursal
        '
        Me.TXTNroPuertaSucursal.Location = New System.Drawing.Point(459, 67)
        Me.TXTNroPuertaSucursal.Name = "TXTNroPuertaSucursal"
        Me.TXTNroPuertaSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroPuertaSucursal.TabIndex = 33
        '
        'TXTCalleSucursal
        '
        Me.TXTCalleSucursal.Location = New System.Drawing.Point(459, 40)
        Me.TXTCalleSucursal.Name = "TXTCalleSucursal"
        Me.TXTCalleSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TXTCalleSucursal.TabIndex = 32
        '
        'LBLESucursalPuerta
        '
        Me.LBLESucursalPuerta.AutoSize = True
        Me.LBLESucursalPuerta.Location = New System.Drawing.Point(339, 76)
        Me.LBLESucursalPuerta.Name = "LBLESucursalPuerta"
        Me.LBLESucursalPuerta.Size = New System.Drawing.Size(72, 13)
        Me.LBLESucursalPuerta.TabIndex = 31
        Me.LBLESucursalPuerta.Text = "Nro de puerta"
        '
        'LBLSurusalCalle
        '
        Me.LBLSurusalCalle.AutoSize = True
        Me.LBLSurusalCalle.Location = New System.Drawing.Point(339, 48)
        Me.LBLSurusalCalle.Name = "LBLSurusalCalle"
        Me.LBLSurusalCalle.Size = New System.Drawing.Size(30, 13)
        Me.LBLSurusalCalle.TabIndex = 30
        Me.LBLSurusalCalle.Text = "Calle"
        '
        'LBLIdSucursal
        '
        Me.LBLIdSucursal.AutoSize = True
        Me.LBLIdSucursal.Location = New System.Drawing.Point(42, 48)
        Me.LBLIdSucursal.Name = "LBLIdSucursal"
        Me.LBLIdSucursal.Size = New System.Drawing.Size(15, 13)
        Me.LBLIdSucursal.TabIndex = 42
        Me.LBLIdSucursal.Text = "id"
        '
        'LBLHorarioInicio
        '
        Me.LBLHorarioInicio.AutoSize = True
        Me.LBLHorarioInicio.Location = New System.Drawing.Point(42, 73)
        Me.LBLHorarioInicio.Name = "LBLHorarioInicio"
        Me.LBLHorarioInicio.Size = New System.Drawing.Size(112, 13)
        Me.LBLHorarioInicio.TabIndex = 43
        Me.LBLHorarioInicio.Text = "horario inicio actividad"
        '
        'LBLHorarioCierre
        '
        Me.LBLHorarioCierre.AutoSize = True
        Me.LBLHorarioCierre.Location = New System.Drawing.Point(41, 100)
        Me.LBLHorarioCierre.Name = "LBLHorarioCierre"
        Me.LBLHorarioCierre.Size = New System.Drawing.Size(114, 13)
        Me.LBLHorarioCierre.TabIndex = 44
        Me.LBLHorarioCierre.Text = "horario cierre actividad"
        '
        'LBLFechaApertura
        '
        Me.LBLFechaApertura.AutoSize = True
        Me.LBLFechaApertura.Location = New System.Drawing.Point(41, 127)
        Me.LBLFechaApertura.Name = "LBLFechaApertura"
        Me.LBLFechaApertura.Size = New System.Drawing.Size(76, 13)
        Me.LBLFechaApertura.TabIndex = 45
        Me.LBLFechaApertura.Text = "fecha apertura"
        '
        'LBLFechaCierre
        '
        Me.LBLFechaCierre.AutoSize = True
        Me.LBLFechaCierre.Location = New System.Drawing.Point(41, 151)
        Me.LBLFechaCierre.Name = "LBLFechaCierre"
        Me.LBLFechaCierre.Size = New System.Drawing.Size(63, 13)
        Me.LBLFechaCierre.TabIndex = 46
        Me.LBLFechaCierre.Text = "fecha cierre"
        '
        'LBLEstadoSucursal
        '
        Me.LBLEstadoSucursal.AutoSize = True
        Me.LBLEstadoSucursal.Location = New System.Drawing.Point(41, 180)
        Me.LBLEstadoSucursal.Name = "LBLEstadoSucursal"
        Me.LBLEstadoSucursal.Size = New System.Drawing.Size(40, 13)
        Me.LBLEstadoSucursal.TabIndex = 48
        Me.LBLEstadoSucursal.Text = "Estado"
        '
        'LSTDepositosAsignados
        '
        Me.LSTDepositosAsignados.FormattingEnabled = True
        Me.LSTDepositosAsignados.Location = New System.Drawing.Point(584, 335)
        Me.LSTDepositosAsignados.Name = "LSTDepositosAsignados"
        Me.LSTDepositosAsignados.Size = New System.Drawing.Size(207, 186)
        Me.LSTDepositosAsignados.TabIndex = 54
        '
        'LSTDepositosNoAsignados
        '
        Me.LSTDepositosNoAsignados.FormattingEnabled = True
        Me.LSTDepositosNoAsignados.Location = New System.Drawing.Point(322, 335)
        Me.LSTDepositosNoAsignados.Name = "LSTDepositosNoAsignados"
        Me.LSTDepositosNoAsignados.Size = New System.Drawing.Size(176, 186)
        Me.LSTDepositosNoAsignados.TabIndex = 53
        '
        'BTNDesasignar
        '
        Me.BTNDesasignar.Location = New System.Drawing.Point(504, 407)
        Me.BTNDesasignar.Name = "BTNDesasignar"
        Me.BTNDesasignar.Size = New System.Drawing.Size(75, 23)
        Me.BTNDesasignar.TabIndex = 52
        Me.BTNDesasignar.Text = "<<"
        Me.BTNDesasignar.UseVisualStyleBackColor = True
        '
        'BTNAsignar
        '
        Me.BTNAsignar.Location = New System.Drawing.Point(504, 361)
        Me.BTNAsignar.Name = "BTNAsignar"
        Me.BTNAsignar.Size = New System.Drawing.Size(75, 23)
        Me.BTNAsignar.TabIndex = 51
        Me.BTNAsignar.Text = ">>"
        Me.BTNAsignar.UseVisualStyleBackColor = True
        '
        'LBLDepositosAsignados
        '
        Me.LBLDepositosAsignados.AutoSize = True
        Me.LBLDepositosAsignados.Location = New System.Drawing.Point(581, 309)
        Me.LBLDepositosAsignados.Name = "LBLDepositosAsignados"
        Me.LBLDepositosAsignados.Size = New System.Drawing.Size(105, 13)
        Me.LBLDepositosAsignados.TabIndex = 50
        Me.LBLDepositosAsignados.Text = "Depositos asignados"
        '
        'LBLDepositosNoAsignados
        '
        Me.LBLDepositosNoAsignados.AutoSize = True
        Me.LBLDepositosNoAsignados.Location = New System.Drawing.Point(316, 309)
        Me.LBLDepositosNoAsignados.Name = "LBLDepositosNoAsignados"
        Me.LBLDepositosNoAsignados.Size = New System.Drawing.Size(114, 13)
        Me.LBLDepositosNoAsignados.TabIndex = 49
        Me.LBLDepositosNoAsignados.Text = "Dpositos no asignados"
        '
        'LBLDeptoDepSuc
        '
        Me.LBLDeptoDepSuc.AutoSize = True
        Me.LBLDeptoDepSuc.Location = New System.Drawing.Point(60, 425)
        Me.LBLDeptoDepSuc.Name = "LBLDeptoDepSuc"
        Me.LBLDeptoDepSuc.Size = New System.Drawing.Size(74, 13)
        Me.LBLDeptoDepSuc.TabIndex = 62
        Me.LBLDeptoDepSuc.Text = "Departamento"
        '
        'TXTDepartamentoDeposito
        '
        Me.TXTDepartamentoDeposito.Location = New System.Drawing.Point(216, 419)
        Me.TXTDepartamentoDeposito.Name = "TXTDepartamentoDeposito"
        Me.TXTDepartamentoDeposito.ReadOnly = True
        Me.TXTDepartamentoDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTDepartamentoDeposito.TabIndex = 61
        '
        'TXTPisoDeposito
        '
        Me.TXTPisoDeposito.Location = New System.Drawing.Point(216, 392)
        Me.TXTPisoDeposito.Name = "TXTPisoDeposito"
        Me.TXTPisoDeposito.ReadOnly = True
        Me.TXTPisoDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTPisoDeposito.TabIndex = 60
        '
        'LBLPisoDepSuc
        '
        Me.LBLPisoDepSuc.AutoSize = True
        Me.LBLPisoDepSuc.Location = New System.Drawing.Point(61, 400)
        Me.LBLPisoDepSuc.Name = "LBLPisoDepSuc"
        Me.LBLPisoDepSuc.Size = New System.Drawing.Size(27, 13)
        Me.LBLPisoDepSuc.TabIndex = 59
        Me.LBLPisoDepSuc.Text = "Piso"
        '
        'TXTNroPuertaDeposito
        '
        Me.TXTNroPuertaDeposito.Location = New System.Drawing.Point(216, 362)
        Me.TXTNroPuertaDeposito.Name = "TXTNroPuertaDeposito"
        Me.TXTNroPuertaDeposito.ReadOnly = True
        Me.TXTNroPuertaDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroPuertaDeposito.TabIndex = 58
        '
        'TXTCalleDeposito
        '
        Me.TXTCalleDeposito.Location = New System.Drawing.Point(216, 335)
        Me.TXTCalleDeposito.Name = "TXTCalleDeposito"
        Me.TXTCalleDeposito.ReadOnly = True
        Me.TXTCalleDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTCalleDeposito.TabIndex = 57
        '
        'LBLNroPDepSuc
        '
        Me.LBLNroPDepSuc.AutoSize = True
        Me.LBLNroPDepSuc.Location = New System.Drawing.Point(60, 371)
        Me.LBLNroPDepSuc.Name = "LBLNroPDepSuc"
        Me.LBLNroPDepSuc.Size = New System.Drawing.Size(72, 13)
        Me.LBLNroPDepSuc.TabIndex = 56
        Me.LBLNroPDepSuc.Text = "Nro de puerta"
        '
        'LBLCalleDepositoSuc
        '
        Me.LBLCalleDepositoSuc.AutoSize = True
        Me.LBLCalleDepositoSuc.Location = New System.Drawing.Point(60, 343)
        Me.LBLCalleDepositoSuc.Name = "LBLCalleDepositoSuc"
        Me.LBLCalleDepositoSuc.Size = New System.Drawing.Size(30, 13)
        Me.LBLCalleDepositoSuc.TabIndex = 55
        Me.LBLCalleDepositoSuc.Text = "Calle"
        '
        'LBLProvDepSuc
        '
        Me.LBLProvDepSuc.AutoSize = True
        Me.LBLProvDepSuc.Location = New System.Drawing.Point(60, 478)
        Me.LBLProvDepSuc.Name = "LBLProvDepSuc"
        Me.LBLProvDepSuc.Size = New System.Drawing.Size(51, 13)
        Me.LBLProvDepSuc.TabIndex = 66
        Me.LBLProvDepSuc.Text = "Provincia"
        '
        'TXTProvinciaDeposito
        '
        Me.TXTProvinciaDeposito.Location = New System.Drawing.Point(216, 472)
        Me.TXTProvinciaDeposito.Name = "TXTProvinciaDeposito"
        Me.TXTProvinciaDeposito.ReadOnly = True
        Me.TXTProvinciaDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTProvinciaDeposito.TabIndex = 65
        '
        'TXTLocalidadDeposito
        '
        Me.TXTLocalidadDeposito.Location = New System.Drawing.Point(216, 445)
        Me.TXTLocalidadDeposito.Name = "TXTLocalidadDeposito"
        Me.TXTLocalidadDeposito.ReadOnly = True
        Me.TXTLocalidadDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTLocalidadDeposito.TabIndex = 64
        '
        'LBLLocDepSuc
        '
        Me.LBLLocDepSuc.AutoSize = True
        Me.LBLLocDepSuc.Location = New System.Drawing.Point(61, 453)
        Me.LBLLocDepSuc.Name = "LBLLocDepSuc"
        Me.LBLLocDepSuc.Size = New System.Drawing.Size(53, 13)
        Me.LBLLocDepSuc.TabIndex = 63
        Me.LBLLocDepSuc.Text = "Localidad"
        '
        'LBLPaisDepSuc
        '
        Me.LBLPaisDepSuc.AutoSize = True
        Me.LBLPaisDepSuc.Location = New System.Drawing.Point(63, 504)
        Me.LBLPaisDepSuc.Name = "LBLPaisDepSuc"
        Me.LBLPaisDepSuc.Size = New System.Drawing.Size(27, 13)
        Me.LBLPaisDepSuc.TabIndex = 68
        Me.LBLPaisDepSuc.Text = "Pais"
        '
        'TXTPaisDeposito
        '
        Me.TXTPaisDeposito.Location = New System.Drawing.Point(216, 501)
        Me.TXTPaisDeposito.Name = "TXTPaisDeposito"
        Me.TXTPaisDeposito.ReadOnly = True
        Me.TXTPaisDeposito.Size = New System.Drawing.Size(100, 20)
        Me.TXTPaisDeposito.TabIndex = 67
        '
        'BTNGuardarSucursal
        '
        Me.BTNGuardarSucursal.Location = New System.Drawing.Point(632, 130)
        Me.BTNGuardarSucursal.Name = "BTNGuardarSucursal"
        Me.BTNGuardarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarSucursal.TabIndex = 69
        Me.BTNGuardarSucursal.Text = "Guardar"
        Me.BTNGuardarSucursal.UseVisualStyleBackColor = True
        '
        'BTNBuscarSucursal
        '
        Me.BTNBuscarSucursal.Location = New System.Drawing.Point(735, 130)
        Me.BTNBuscarSucursal.Name = "BTNBuscarSucursal"
        Me.BTNBuscarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarSucursal.TabIndex = 70
        Me.BTNBuscarSucursal.Text = "Buscar"
        Me.BTNBuscarSucursal.UseVisualStyleBackColor = True
        '
        'BTNEliminarSucursal
        '
        Me.BTNEliminarSucursal.Location = New System.Drawing.Point(632, 169)
        Me.BTNEliminarSucursal.Name = "BTNEliminarSucursal"
        Me.BTNEliminarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarSucursal.TabIndex = 71
        Me.BTNEliminarSucursal.Text = "Eliminar"
        Me.BTNEliminarSucursal.UseVisualStyleBackColor = True
        '
        'BTNLimpiarSucursal
        '
        Me.BTNLimpiarSucursal.Location = New System.Drawing.Point(735, 169)
        Me.BTNLimpiarSucursal.Name = "BTNLimpiarSucursal"
        Me.BTNLimpiarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarSucursal.TabIndex = 72
        Me.BTNLimpiarSucursal.Text = "Limpiar"
        Me.BTNLimpiarSucursal.UseVisualStyleBackColor = True
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(164, 13)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 73
        '
        'TXTFechaCierre
        '
        Me.TXTFechaCierre.Location = New System.Drawing.Point(164, 150)
        Me.TXTFechaCierre.Name = "TXTFechaCierre"
        Me.TXTFechaCierre.Size = New System.Drawing.Size(121, 20)
        Me.TXTFechaCierre.TabIndex = 74
        '
        'TXTFechaApetura
        '
        Me.TXTFechaApetura.Location = New System.Drawing.Point(164, 121)
        Me.TXTFechaApetura.Name = "TXTFechaApetura"
        Me.TXTFechaApetura.Size = New System.Drawing.Size(121, 20)
        Me.TXTFechaApetura.TabIndex = 75
        '
        'GestionarSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 543)
        Me.Controls.Add(Me.TXTFechaApetura)
        Me.Controls.Add(Me.TXTFechaCierre)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BTNLimpiarSucursal)
        Me.Controls.Add(Me.BTNEliminarSucursal)
        Me.Controls.Add(Me.BTNBuscarSucursal)
        Me.Controls.Add(Me.BTNGuardarSucursal)
        Me.Controls.Add(Me.LBLPaisDepSuc)
        Me.Controls.Add(Me.TXTPaisDeposito)
        Me.Controls.Add(Me.LBLProvDepSuc)
        Me.Controls.Add(Me.TXTProvinciaDeposito)
        Me.Controls.Add(Me.TXTLocalidadDeposito)
        Me.Controls.Add(Me.LBLLocDepSuc)
        Me.Controls.Add(Me.LBLDeptoDepSuc)
        Me.Controls.Add(Me.TXTDepartamentoDeposito)
        Me.Controls.Add(Me.TXTPisoDeposito)
        Me.Controls.Add(Me.LBLPisoDepSuc)
        Me.Controls.Add(Me.TXTNroPuertaDeposito)
        Me.Controls.Add(Me.TXTCalleDeposito)
        Me.Controls.Add(Me.LBLNroPDepSuc)
        Me.Controls.Add(Me.LBLCalleDepositoSuc)
        Me.Controls.Add(Me.LSTDepositosAsignados)
        Me.Controls.Add(Me.LSTDepositosNoAsignados)
        Me.Controls.Add(Me.BTNDesasignar)
        Me.Controls.Add(Me.BTNAsignar)
        Me.Controls.Add(Me.LBLDepositosAsignados)
        Me.Controls.Add(Me.LBLDepositosNoAsignados)
        Me.Controls.Add(Me.LBLEstadoSucursal)
        Me.Controls.Add(Me.LBLFechaCierre)
        Me.Controls.Add(Me.LBLFechaApertura)
        Me.Controls.Add(Me.LBLHorarioCierre)
        Me.Controls.Add(Me.LBLHorarioInicio)
        Me.Controls.Add(Me.LBLIdSucursal)
        Me.Controls.Add(Me.LBLSucursalTelefono)
        Me.Controls.Add(Me.TXTTelefonoSucursal)
        Me.Controls.Add(Me.LBLSucursalEmail)
        Me.Controls.Add(Me.TXTEmailSucursal)
        Me.Controls.Add(Me.LBLSucursalDepartamento)
        Me.Controls.Add(Me.TXTDepartamentoSucursal)
        Me.Controls.Add(Me.TXTPisoSucursal)
        Me.Controls.Add(Me.LBLSucursalPiso)
        Me.Controls.Add(Me.TXTNroPuertaSucursal)
        Me.Controls.Add(Me.TXTCalleSucursal)
        Me.Controls.Add(Me.LBLESucursalPuerta)
        Me.Controls.Add(Me.LBLSurusalCalle)
        Me.Controls.Add(Me.LBLSucursalLocalidad)
        Me.Controls.Add(Me.LBLSucursalProvincia)
        Me.Controls.Add(Me.LBLSucursalPais)
        Me.Controls.Add(Me.CMBLocalidadSucursal)
        Me.Controls.Add(Me.CMBProvinciaSucursal)
        Me.Controls.Add(Me.CMBPaisSucursal)
        Me.Controls.Add(Me.CMBEstado)
        Me.Controls.Add(Me.TexTXTInicioAct)
        Me.Controls.Add(Me.TXTCierreAct)
        Me.Controls.Add(Me.TXTIdSucursal)
        Me.Name = "GestionarSucursales"
        Me.Text = "GestionarSucursales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTIdSucursal As System.Windows.Forms.TextBox
    Friend WithEvents TXTCierreAct As System.Windows.Forms.TextBox
    Friend WithEvents TexTXTInicioAct As System.Windows.Forms.TextBox
    Friend WithEvents CMBEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LBLSucursalLocalidad As System.Windows.Forms.Label
    Friend WithEvents LBLSucursalProvincia As System.Windows.Forms.Label
    Friend WithEvents LBLSucursalPais As System.Windows.Forms.Label
    Friend WithEvents CMBLocalidadSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents CMBProvinciaSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents CMBPaisSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents LBLSucursalTelefono As System.Windows.Forms.Label
    Friend WithEvents TXTTelefonoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents LBLSucursalEmail As System.Windows.Forms.Label
    Friend WithEvents TXTEmailSucursal As System.Windows.Forms.TextBox
    Friend WithEvents LBLSucursalDepartamento As System.Windows.Forms.Label
    Friend WithEvents TXTDepartamentoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents TXTPisoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents LBLSucursalPiso As System.Windows.Forms.Label
    Friend WithEvents TXTNroPuertaSucursal As System.Windows.Forms.TextBox
    Friend WithEvents TXTCalleSucursal As System.Windows.Forms.TextBox
    Friend WithEvents LBLESucursalPuerta As System.Windows.Forms.Label
    Friend WithEvents LBLSurusalCalle As System.Windows.Forms.Label
    Friend WithEvents LBLIdSucursal As System.Windows.Forms.Label
    Friend WithEvents LBLHorarioInicio As System.Windows.Forms.Label
    Friend WithEvents LBLHorarioCierre As System.Windows.Forms.Label
    Friend WithEvents LBLFechaApertura As System.Windows.Forms.Label
    Friend WithEvents LBLFechaCierre As System.Windows.Forms.Label
    Friend WithEvents LBLEstadoSucursal As System.Windows.Forms.Label
    Friend WithEvents LSTDepositosAsignados As System.Windows.Forms.ListBox
    Friend WithEvents LSTDepositosNoAsignados As System.Windows.Forms.ListBox
    Friend WithEvents BTNDesasignar As System.Windows.Forms.Button
    Friend WithEvents BTNAsignar As System.Windows.Forms.Button
    Friend WithEvents LBLDepositosAsignados As System.Windows.Forms.Label
    Friend WithEvents LBLDepositosNoAsignados As System.Windows.Forms.Label
    Friend WithEvents LBLDeptoDepSuc As System.Windows.Forms.Label
    Friend WithEvents TXTDepartamentoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TXTPisoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLPisoDepSuc As System.Windows.Forms.Label
    Friend WithEvents TXTNroPuertaDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TXTCalleDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLNroPDepSuc As System.Windows.Forms.Label
    Friend WithEvents LBLCalleDepositoSuc As System.Windows.Forms.Label
    Friend WithEvents LBLProvDepSuc As System.Windows.Forms.Label
    Friend WithEvents TXTProvinciaDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TXTLocalidadDeposito As System.Windows.Forms.TextBox
    Friend WithEvents LBLLocDepSuc As System.Windows.Forms.Label
    Friend WithEvents LBLPaisDepSuc As System.Windows.Forms.Label
    Friend WithEvents TXTPaisDeposito As System.Windows.Forms.TextBox
    Friend WithEvents BTNGuardarSucursal As System.Windows.Forms.Button
    Friend WithEvents BTNBuscarSucursal As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarSucursal As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarSucursal As System.Windows.Forms.Button
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents TXTFechaCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTFechaApetura As System.Windows.Forms.DateTimePicker
End Class
