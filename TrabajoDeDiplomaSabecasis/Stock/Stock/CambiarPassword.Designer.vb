<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarPassword
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
        Me.LBLPreuntaSecretaCambiar = New System.Windows.Forms.Label()
        Me.TXTPregunta = New System.Windows.Forms.TextBox()
        Me.TXTRespuesta = New System.Windows.Forms.TextBox()
        Me.LBLRespuestaSecretaCambiar = New System.Windows.Forms.Label()
        Me.TXTNueva = New System.Windows.Forms.TextBox()
        Me.LBLNuevaPasswordCambiar = New System.Windows.Forms.Label()
        Me.TXTRepetir = New System.Windows.Forms.TextBox()
        Me.LBLRepetirCambiar = New System.Windows.Forms.Label()
        Me.TXTUsuario = New System.Windows.Forms.TextBox()
        Me.LBLUsuarioCambiar = New System.Windows.Forms.Label()
        Me.BTNBuscarPregunta = New System.Windows.Forms.Button()
        Me.BTNCambiar = New System.Windows.Forms.Button()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLPreuntaSecretaCambiar
        '
        Me.LBLPreuntaSecretaCambiar.AutoSize = True
        Me.LBLPreuntaSecretaCambiar.Location = New System.Drawing.Point(44, 51)
        Me.LBLPreuntaSecretaCambiar.Name = "LBLPreuntaSecretaCambiar"
        Me.LBLPreuntaSecretaCambiar.Size = New System.Drawing.Size(50, 13)
        Me.LBLPreuntaSecretaCambiar.TabIndex = 0
        Me.LBLPreuntaSecretaCambiar.Text = "Pregunta"
        '
        'TXTPregunta
        '
        Me.TXTPregunta.Location = New System.Drawing.Point(195, 48)
        Me.TXTPregunta.Name = "TXTPregunta"
        Me.TXTPregunta.Size = New System.Drawing.Size(100, 20)
        Me.TXTPregunta.TabIndex = 1
        '
        'TXTRespuesta
        '
        Me.TXTRespuesta.Location = New System.Drawing.Point(195, 88)
        Me.TXTRespuesta.Name = "TXTRespuesta"
        Me.TXTRespuesta.Size = New System.Drawing.Size(100, 20)
        Me.TXTRespuesta.TabIndex = 3
        '
        'LBLRespuestaSecretaCambiar
        '
        Me.LBLRespuestaSecretaCambiar.AutoSize = True
        Me.LBLRespuestaSecretaCambiar.Location = New System.Drawing.Point(44, 91)
        Me.LBLRespuestaSecretaCambiar.Name = "LBLRespuestaSecretaCambiar"
        Me.LBLRespuestaSecretaCambiar.Size = New System.Drawing.Size(58, 13)
        Me.LBLRespuestaSecretaCambiar.TabIndex = 2
        Me.LBLRespuestaSecretaCambiar.Text = "Respuesta"
        '
        'TXTNueva
        '
        Me.TXTNueva.Location = New System.Drawing.Point(195, 171)
        Me.TXTNueva.Name = "TXTNueva"
        Me.TXTNueva.Size = New System.Drawing.Size(100, 20)
        Me.TXTNueva.TabIndex = 5
        '
        'LBLNuevaPasswordCambiar
        '
        Me.LBLNuevaPasswordCambiar.AutoSize = True
        Me.LBLNuevaPasswordCambiar.Location = New System.Drawing.Point(44, 174)
        Me.LBLNuevaPasswordCambiar.Name = "LBLNuevaPasswordCambiar"
        Me.LBLNuevaPasswordCambiar.Size = New System.Drawing.Size(88, 13)
        Me.LBLNuevaPasswordCambiar.TabIndex = 4
        Me.LBLNuevaPasswordCambiar.Text = "Nueva Password"
        '
        'TXTRepetir
        '
        Me.TXTRepetir.Location = New System.Drawing.Point(195, 211)
        Me.TXTRepetir.Name = "TXTRepetir"
        Me.TXTRepetir.Size = New System.Drawing.Size(100, 20)
        Me.TXTRepetir.TabIndex = 7
        '
        'LBLRepetirCambiar
        '
        Me.LBLRepetirCambiar.AutoSize = True
        Me.LBLRepetirCambiar.Location = New System.Drawing.Point(44, 214)
        Me.LBLRepetirCambiar.Name = "LBLRepetirCambiar"
        Me.LBLRepetirCambiar.Size = New System.Drawing.Size(89, 13)
        Me.LBLRepetirCambiar.TabIndex = 6
        Me.LBLRepetirCambiar.Text = "Repetir password"
        '
        'TXTUsuario
        '
        Me.TXTUsuario.Location = New System.Drawing.Point(195, 123)
        Me.TXTUsuario.Name = "TXTUsuario"
        Me.TXTUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TXTUsuario.TabIndex = 9
        '
        'LBLUsuarioCambiar
        '
        Me.LBLUsuarioCambiar.AutoSize = True
        Me.LBLUsuarioCambiar.Location = New System.Drawing.Point(44, 126)
        Me.LBLUsuarioCambiar.Name = "LBLUsuarioCambiar"
        Me.LBLUsuarioCambiar.Size = New System.Drawing.Size(43, 13)
        Me.LBLUsuarioCambiar.TabIndex = 8
        Me.LBLUsuarioCambiar.Text = "Usuario"
        '
        'BTNBuscarPregunta
        '
        Me.BTNBuscarPregunta.Location = New System.Drawing.Point(389, 48)
        Me.BTNBuscarPregunta.Name = "BTNBuscarPregunta"
        Me.BTNBuscarPregunta.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarPregunta.TabIndex = 10
        Me.BTNBuscarPregunta.Text = "Buscar"
        Me.BTNBuscarPregunta.UseVisualStyleBackColor = True
        '
        'BTNCambiar
        '
        Me.BTNCambiar.Location = New System.Drawing.Point(389, 88)
        Me.BTNCambiar.Name = "BTNCambiar"
        Me.BTNCambiar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCambiar.TabIndex = 11
        Me.BTNCambiar.Text = "Cambiar"
        Me.BTNCambiar.UseVisualStyleBackColor = True
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(47, 13)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 12
        '
        'CambiarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 261)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BTNCambiar)
        Me.Controls.Add(Me.BTNBuscarPregunta)
        Me.Controls.Add(Me.TXTUsuario)
        Me.Controls.Add(Me.LBLUsuarioCambiar)
        Me.Controls.Add(Me.TXTRepetir)
        Me.Controls.Add(Me.LBLRepetirCambiar)
        Me.Controls.Add(Me.TXTNueva)
        Me.Controls.Add(Me.LBLNuevaPasswordCambiar)
        Me.Controls.Add(Me.TXTRespuesta)
        Me.Controls.Add(Me.LBLRespuestaSecretaCambiar)
        Me.Controls.Add(Me.TXTPregunta)
        Me.Controls.Add(Me.LBLPreuntaSecretaCambiar)
        Me.Name = "CambiarPassword"
        Me.Text = "CambiarPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLPreuntaSecretaCambiar As System.Windows.Forms.Label
    Friend WithEvents TXTPregunta As System.Windows.Forms.TextBox
    Friend WithEvents TXTRespuesta As System.Windows.Forms.TextBox
    Friend WithEvents LBLRespuestaSecretaCambiar As System.Windows.Forms.Label
    Friend WithEvents TXTNueva As System.Windows.Forms.TextBox
    Friend WithEvents LBLNuevaPasswordCambiar As System.Windows.Forms.Label
    Friend WithEvents TXTRepetir As System.Windows.Forms.TextBox
    Friend WithEvents LBLRepetirCambiar As System.Windows.Forms.Label
    Friend WithEvents TXTUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LBLUsuarioCambiar As System.Windows.Forms.Label
    Friend WithEvents BTNBuscarPregunta As System.Windows.Forms.Button
    Friend WithEvents BTNCambiar As System.Windows.Forms.Button
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
End Class
