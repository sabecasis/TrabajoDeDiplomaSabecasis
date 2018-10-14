<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarUsuario
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
        Me.LBLUsuario = New System.Windows.Forms.Label()
        Me.LBLPasswordUno = New System.Windows.Forms.Label()
        Me.LBLPasswordDos = New System.Windows.Forms.Label()
        Me.LSTEmpleadosDeUsuario = New System.Windows.Forms.ListBox()
        Me.BTNGuardarUsuario = New System.Windows.Forms.Button()
        Me.TXTUsuarioCrearUsuario = New System.Windows.Forms.TextBox()
        Me.TXTPaswordCrearUsuario = New System.Windows.Forms.TextBox()
        Me.TXTRepetirPasswordCrearUsuario = New System.Windows.Forms.TextBox()
        Me.LBLPreguntaSecreta = New System.Windows.Forms.Label()
        Me.LBLRespuestaSecreta = New System.Windows.Forms.Label()
        Me.TXTCrearPreguntaSecreta = New System.Windows.Forms.TextBox()
        Me.TXTCrearRespuestaSecreta = New System.Windows.Forms.TextBox()
        Me.LBLMensajeGestionUsuarios = New System.Windows.Forms.Label()
        Me.BTNBuscarUsuario = New System.Windows.Forms.Button()
        Me.TXTIdUsuario = New System.Windows.Forms.TextBox()
        Me.LBLIdUsuario = New System.Windows.Forms.Label()
        Me.LBLContadorMalaPassUsuario = New System.Windows.Forms.Label()
        Me.TXTContadorMalaPassUsuario = New System.Windows.Forms.TextBox()
        Me.CHKBloqueado = New System.Windows.Forms.CheckBox()
        Me.BTNEliminarUsuario = New System.Windows.Forms.Button()
        Me.TXTNroDocumentoEmpleado = New System.Windows.Forms.TextBox()
        Me.LBLNroDocumento = New System.Windows.Forms.Label()
        Me.LBLEmpleadoApellido = New System.Windows.Forms.Label()
        Me.LBLEmpleadoNombre = New System.Windows.Forms.Label()
        Me.TXTApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.TXTNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.BTNLimpiarPantallaUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLUsuario
        '
        Me.LBLUsuario.AutoSize = True
        Me.LBLUsuario.Location = New System.Drawing.Point(67, 75)
        Me.LBLUsuario.Name = "LBLUsuario"
        Me.LBLUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LBLUsuario.TabIndex = 0
        Me.LBLUsuario.Text = "Usuario"
        '
        'LBLPasswordUno
        '
        Me.LBLPasswordUno.AutoSize = True
        Me.LBLPasswordUno.Location = New System.Drawing.Point(67, 105)
        Me.LBLPasswordUno.Name = "LBLPasswordUno"
        Me.LBLPasswordUno.Size = New System.Drawing.Size(61, 13)
        Me.LBLPasswordUno.TabIndex = 1
        Me.LBLPasswordUno.Text = "Contraseña"
        '
        'LBLPasswordDos
        '
        Me.LBLPasswordDos.AutoSize = True
        Me.LBLPasswordDos.Location = New System.Drawing.Point(67, 129)
        Me.LBLPasswordDos.Name = "LBLPasswordDos"
        Me.LBLPasswordDos.Size = New System.Drawing.Size(98, 13)
        Me.LBLPasswordDos.TabIndex = 2
        Me.LBLPasswordDos.Text = "Repetir Contraseña"
        '
        'LSTEmpleadosDeUsuario
        '
        Me.LSTEmpleadosDeUsuario.FormattingEnabled = True
        Me.LSTEmpleadosDeUsuario.Location = New System.Drawing.Point(70, 244)
        Me.LSTEmpleadosDeUsuario.Name = "LSTEmpleadosDeUsuario"
        Me.LSTEmpleadosDeUsuario.Size = New System.Drawing.Size(160, 173)
        Me.LSTEmpleadosDeUsuario.TabIndex = 3
        '
        'BTNGuardarUsuario
        '
        Me.BTNGuardarUsuario.Location = New System.Drawing.Point(407, 119)
        Me.BTNGuardarUsuario.Name = "BTNGuardarUsuario"
        Me.BTNGuardarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarUsuario.TabIndex = 6
        Me.BTNGuardarUsuario.Text = "Guardar"
        Me.BTNGuardarUsuario.UseVisualStyleBackColor = True
        '
        'TXTUsuarioCrearUsuario
        '
        Me.TXTUsuarioCrearUsuario.Location = New System.Drawing.Point(251, 72)
        Me.TXTUsuarioCrearUsuario.Name = "TXTUsuarioCrearUsuario"
        Me.TXTUsuarioCrearUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TXTUsuarioCrearUsuario.TabIndex = 7
        '
        'TXTPaswordCrearUsuario
        '
        Me.TXTPaswordCrearUsuario.Location = New System.Drawing.Point(251, 99)
        Me.TXTPaswordCrearUsuario.Name = "TXTPaswordCrearUsuario"
        Me.TXTPaswordCrearUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TXTPaswordCrearUsuario.TabIndex = 8
        Me.TXTPaswordCrearUsuario.UseSystemPasswordChar = True
        '
        'TXTRepetirPasswordCrearUsuario
        '
        Me.TXTRepetirPasswordCrearUsuario.Location = New System.Drawing.Point(251, 125)
        Me.TXTRepetirPasswordCrearUsuario.Name = "TXTRepetirPasswordCrearUsuario"
        Me.TXTRepetirPasswordCrearUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TXTRepetirPasswordCrearUsuario.TabIndex = 9
        Me.TXTRepetirPasswordCrearUsuario.UseSystemPasswordChar = True
        '
        'LBLPreguntaSecreta
        '
        Me.LBLPreguntaSecreta.AutoSize = True
        Me.LBLPreguntaSecreta.Location = New System.Drawing.Point(69, 157)
        Me.LBLPreguntaSecreta.Name = "LBLPreguntaSecreta"
        Me.LBLPreguntaSecreta.Size = New System.Drawing.Size(88, 13)
        Me.LBLPreguntaSecreta.TabIndex = 10
        Me.LBLPreguntaSecreta.Text = "Pregunta secreta"
        '
        'LBLRespuestaSecreta
        '
        Me.LBLRespuestaSecreta.AutoSize = True
        Me.LBLRespuestaSecreta.Location = New System.Drawing.Point(70, 185)
        Me.LBLRespuestaSecreta.Name = "LBLRespuestaSecreta"
        Me.LBLRespuestaSecreta.Size = New System.Drawing.Size(96, 13)
        Me.LBLRespuestaSecreta.TabIndex = 11
        Me.LBLRespuestaSecreta.Text = "Respuesta secreta"
        '
        'TXTCrearPreguntaSecreta
        '
        Me.TXTCrearPreguntaSecreta.Location = New System.Drawing.Point(251, 153)
        Me.TXTCrearPreguntaSecreta.Name = "TXTCrearPreguntaSecreta"
        Me.TXTCrearPreguntaSecreta.Size = New System.Drawing.Size(100, 20)
        Me.TXTCrearPreguntaSecreta.TabIndex = 12
        '
        'TXTCrearRespuestaSecreta
        '
        Me.TXTCrearRespuestaSecreta.Location = New System.Drawing.Point(251, 180)
        Me.TXTCrearRespuestaSecreta.Name = "TXTCrearRespuestaSecreta"
        Me.TXTCrearRespuestaSecreta.Size = New System.Drawing.Size(100, 20)
        Me.TXTCrearRespuestaSecreta.TabIndex = 13
        Me.TXTCrearRespuestaSecreta.UseSystemPasswordChar = True
        '
        'LBLMensajeGestionUsuarios
        '
        Me.LBLMensajeGestionUsuarios.AutoSize = True
        Me.LBLMensajeGestionUsuarios.ForeColor = System.Drawing.Color.Red
        Me.LBLMensajeGestionUsuarios.Location = New System.Drawing.Point(70, 32)
        Me.LBLMensajeGestionUsuarios.Name = "LBLMensajeGestionUsuarios"
        Me.LBLMensajeGestionUsuarios.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensajeGestionUsuarios.TabIndex = 14
        '
        'BTNBuscarUsuario
        '
        Me.BTNBuscarUsuario.Location = New System.Drawing.Point(407, 75)
        Me.BTNBuscarUsuario.Name = "BTNBuscarUsuario"
        Me.BTNBuscarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarUsuario.TabIndex = 15
        Me.BTNBuscarUsuario.Text = "Buscar"
        Me.BTNBuscarUsuario.UseVisualStyleBackColor = True
        '
        'TXTIdUsuario
        '
        Me.TXTIdUsuario.Location = New System.Drawing.Point(251, 46)
        Me.TXTIdUsuario.Name = "TXTIdUsuario"
        Me.TXTIdUsuario.ReadOnly = True
        Me.TXTIdUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdUsuario.TabIndex = 16
        '
        'LBLIdUsuario
        '
        Me.LBLIdUsuario.AutoSize = True
        Me.LBLIdUsuario.Location = New System.Drawing.Point(72, 52)
        Me.LBLIdUsuario.Name = "LBLIdUsuario"
        Me.LBLIdUsuario.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdUsuario.TabIndex = 17
        Me.LBLIdUsuario.Text = "Id"
        '
        'LBLContadorMalaPassUsuario
        '
        Me.LBLContadorMalaPassUsuario.AutoSize = True
        Me.LBLContadorMalaPassUsuario.Location = New System.Drawing.Point(73, 212)
        Me.LBLContadorMalaPassUsuario.Name = "LBLContadorMalaPassUsuario"
        Me.LBLContadorMalaPassUsuario.Size = New System.Drawing.Size(125, 13)
        Me.LBLContadorMalaPassUsuario.TabIndex = 18
        Me.LBLContadorMalaPassUsuario.Text = "Contador Mala Password"
        '
        'TXTContadorMalaPassUsuario
        '
        Me.TXTContadorMalaPassUsuario.Location = New System.Drawing.Point(251, 207)
        Me.TXTContadorMalaPassUsuario.Name = "TXTContadorMalaPassUsuario"
        Me.TXTContadorMalaPassUsuario.ReadOnly = True
        Me.TXTContadorMalaPassUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TXTContadorMalaPassUsuario.TabIndex = 19
        '
        'CHKBloqueado
        '
        Me.CHKBloqueado.AutoSize = True
        Me.CHKBloqueado.Location = New System.Drawing.Point(407, 46)
        Me.CHKBloqueado.Name = "CHKBloqueado"
        Me.CHKBloqueado.Size = New System.Drawing.Size(77, 17)
        Me.CHKBloqueado.TabIndex = 20
        Me.CHKBloqueado.Text = "Bloqueado"
        Me.CHKBloqueado.UseVisualStyleBackColor = True
        '
        'BTNEliminarUsuario
        '
        Me.BTNEliminarUsuario.Location = New System.Drawing.Point(507, 119)
        Me.BTNEliminarUsuario.Name = "BTNEliminarUsuario"
        Me.BTNEliminarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarUsuario.TabIndex = 21
        Me.BTNEliminarUsuario.Text = "Eliminar"
        Me.BTNEliminarUsuario.UseVisualStyleBackColor = True
        '
        'TXTNroDocumentoEmpleado
        '
        Me.TXTNroDocumentoEmpleado.Location = New System.Drawing.Point(434, 318)
        Me.TXTNroDocumentoEmpleado.Name = "TXTNroDocumentoEmpleado"
        Me.TXTNroDocumentoEmpleado.ReadOnly = True
        Me.TXTNroDocumentoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTNroDocumentoEmpleado.TabIndex = 27
        '
        'LBLNroDocumento
        '
        Me.LBLNroDocumento.AutoSize = True
        Me.LBLNroDocumento.Location = New System.Drawing.Point(308, 322)
        Me.LBLNroDocumento.Name = "LBLNroDocumento"
        Me.LBLNroDocumento.Size = New System.Drawing.Size(82, 13)
        Me.LBLNroDocumento.TabIndex = 26
        Me.LBLNroDocumento.Text = "Nro Documento"
        '
        'LBLEmpleadoApellido
        '
        Me.LBLEmpleadoApellido.AutoSize = True
        Me.LBLEmpleadoApellido.Location = New System.Drawing.Point(311, 295)
        Me.LBLEmpleadoApellido.Name = "LBLEmpleadoApellido"
        Me.LBLEmpleadoApellido.Size = New System.Drawing.Size(44, 13)
        Me.LBLEmpleadoApellido.TabIndex = 25
        Me.LBLEmpleadoApellido.Text = "Apellido"
        '
        'LBLEmpleadoNombre
        '
        Me.LBLEmpleadoNombre.AutoSize = True
        Me.LBLEmpleadoNombre.Location = New System.Drawing.Point(311, 266)
        Me.LBLEmpleadoNombre.Name = "LBLEmpleadoNombre"
        Me.LBLEmpleadoNombre.Size = New System.Drawing.Size(44, 13)
        Me.LBLEmpleadoNombre.TabIndex = 24
        Me.LBLEmpleadoNombre.Text = "Nombre"
        '
        'TXTApellidoEmpleado
        '
        Me.TXTApellidoEmpleado.Location = New System.Drawing.Point(434, 292)
        Me.TXTApellidoEmpleado.Name = "TXTApellidoEmpleado"
        Me.TXTApellidoEmpleado.ReadOnly = True
        Me.TXTApellidoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTApellidoEmpleado.TabIndex = 23
        '
        'TXTNombreEmpleado
        '
        Me.TXTNombreEmpleado.Location = New System.Drawing.Point(434, 266)
        Me.TXTNombreEmpleado.Name = "TXTNombreEmpleado"
        Me.TXTNombreEmpleado.ReadOnly = True
        Me.TXTNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombreEmpleado.TabIndex = 22
        '
        'BTNLimpiarPantallaUsuario
        '
        Me.BTNLimpiarPantallaUsuario.Location = New System.Drawing.Point(507, 75)
        Me.BTNLimpiarPantallaUsuario.Name = "BTNLimpiarPantallaUsuario"
        Me.BTNLimpiarPantallaUsuario.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarPantallaUsuario.TabIndex = 28
        Me.BTNLimpiarPantallaUsuario.Text = "Limpiar"
        Me.BTNLimpiarPantallaUsuario.UseVisualStyleBackColor = True
        '
        'GestionarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 589)
        Me.Controls.Add(Me.BTNLimpiarPantallaUsuario)
        Me.Controls.Add(Me.TXTNroDocumentoEmpleado)
        Me.Controls.Add(Me.LBLNroDocumento)
        Me.Controls.Add(Me.LBLEmpleadoApellido)
        Me.Controls.Add(Me.LBLEmpleadoNombre)
        Me.Controls.Add(Me.TXTApellidoEmpleado)
        Me.Controls.Add(Me.TXTNombreEmpleado)
        Me.Controls.Add(Me.BTNEliminarUsuario)
        Me.Controls.Add(Me.CHKBloqueado)
        Me.Controls.Add(Me.TXTContadorMalaPassUsuario)
        Me.Controls.Add(Me.LBLContadorMalaPassUsuario)
        Me.Controls.Add(Me.LBLIdUsuario)
        Me.Controls.Add(Me.TXTIdUsuario)
        Me.Controls.Add(Me.BTNBuscarUsuario)
        Me.Controls.Add(Me.LBLMensajeGestionUsuarios)
        Me.Controls.Add(Me.TXTCrearRespuestaSecreta)
        Me.Controls.Add(Me.TXTCrearPreguntaSecreta)
        Me.Controls.Add(Me.LBLRespuestaSecreta)
        Me.Controls.Add(Me.LBLPreguntaSecreta)
        Me.Controls.Add(Me.TXTRepetirPasswordCrearUsuario)
        Me.Controls.Add(Me.TXTPaswordCrearUsuario)
        Me.Controls.Add(Me.TXTUsuarioCrearUsuario)
        Me.Controls.Add(Me.BTNGuardarUsuario)
        Me.Controls.Add(Me.LSTEmpleadosDeUsuario)
        Me.Controls.Add(Me.LBLPasswordDos)
        Me.Controls.Add(Me.LBLPasswordUno)
        Me.Controls.Add(Me.LBLUsuario)
        Me.Name = "GestionarUsuario"
        Me.Text = ";"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents LBLUsuario As System.Windows.Forms.Label
    Friend WithEvents LBLPasswordUno As System.Windows.Forms.Label
    Friend WithEvents LBLPasswordDos As System.Windows.Forms.Label
    Friend WithEvents LSTEmpleadosDeUsuario As System.Windows.Forms.ListBox
    Friend WithEvents BTNGuardarUsuario As System.Windows.Forms.Button
    Friend WithEvents TXTUsuarioCrearUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TXTPaswordCrearUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TXTRepetirPasswordCrearUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LBLPreguntaSecreta As System.Windows.Forms.Label
    Friend WithEvents LBLRespuestaSecreta As System.Windows.Forms.Label
    Friend WithEvents TXTCrearPreguntaSecreta As System.Windows.Forms.TextBox
    Friend WithEvents TXTCrearRespuestaSecreta As System.Windows.Forms.TextBox
    Friend WithEvents LBLMensajeGestionUsuarios As System.Windows.Forms.Label
    Friend WithEvents BTNBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents TXTIdUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LBLIdUsuario As System.Windows.Forms.Label
    Friend WithEvents LBLContadorMalaPassUsuario As System.Windows.Forms.Label
    Friend WithEvents TXTContadorMalaPassUsuario As System.Windows.Forms.TextBox
    Friend WithEvents CHKBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents BTNEliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents TXTNroDocumentoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LBLNroDocumento As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoApellido As System.Windows.Forms.Label
    Friend WithEvents LBLEmpleadoNombre As System.Windows.Forms.Label
    Friend WithEvents TXTApellidoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents BTNLimpiarPantallaUsuario As System.Windows.Forms.Button
End Class
