<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TXTUsuario = New System.Windows.Forms.TextBox()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.LBLUsuario = New System.Windows.Forms.Label()
        Me.LBLPassword = New System.Windows.Forms.Label()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.BTNOlvidarPassword = New System.Windows.Forms.Button()
        Me.CMBIdioma = New System.Windows.Forms.ComboBox()
        Me.LBLIdioma = New System.Windows.Forms.Label()
        Me.LBLRazon = New System.Windows.Forms.Label()
        Me.BTNCambiarConexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTUsuario
        '
        Me.TXTUsuario.Location = New System.Drawing.Point(92, 49)
        Me.TXTUsuario.Name = "TXTUsuario"
        Me.TXTUsuario.Size = New System.Drawing.Size(205, 20)
        Me.TXTUsuario.TabIndex = 0
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(92, 87)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPassword.Size = New System.Drawing.Size(205, 20)
        Me.TXTPassword.TabIndex = 1
        Me.TXTPassword.UseSystemPasswordChar = True
        '
        'LBLUsuario
        '
        Me.LBLUsuario.AutoSize = True
        Me.LBLUsuario.Location = New System.Drawing.Point(16, 49)
        Me.LBLUsuario.Name = "LBLUsuario"
        Me.LBLUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LBLUsuario.TabIndex = 5
        '
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = True
        Me.LBLPassword.Location = New System.Drawing.Point(16, 93)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(0, 13)
        Me.LBLPassword.TabIndex = 6
        '
        'BTNLogin
        '
        Me.BTNLogin.Location = New System.Drawing.Point(92, 198)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(294, 23)
        Me.BTNLogin.TabIndex = 3
        Me.BTNLogin.UseVisualStyleBackColor = True
        '
        'BTNOlvidarPassword
        '
        Me.BTNOlvidarPassword.Location = New System.Drawing.Point(92, 237)
        Me.BTNOlvidarPassword.Name = "BTNOlvidarPassword"
        Me.BTNOlvidarPassword.Size = New System.Drawing.Size(294, 23)
        Me.BTNOlvidarPassword.TabIndex = 4
        Me.BTNOlvidarPassword.UseVisualStyleBackColor = True
        '
        'CMBIdioma
        '
        Me.CMBIdioma.FormattingEnabled = True
        Me.CMBIdioma.Location = New System.Drawing.Point(92, 123)
        Me.CMBIdioma.Name = "CMBIdioma"
        Me.CMBIdioma.Size = New System.Drawing.Size(121, 21)
        Me.CMBIdioma.TabIndex = 2
        '
        'LBLIdioma
        '
        Me.LBLIdioma.AutoSize = True
        Me.LBLIdioma.Location = New System.Drawing.Point(19, 130)
        Me.LBLIdioma.Name = "LBLIdioma"
        Me.LBLIdioma.Size = New System.Drawing.Size(0, 13)
        Me.LBLIdioma.TabIndex = 7
        '
        'LBLRazon
        '
        Me.LBLRazon.AutoSize = True
        Me.LBLRazon.ForeColor = System.Drawing.Color.Red
        Me.LBLRazon.Location = New System.Drawing.Point(20, 182)
        Me.LBLRazon.Name = "LBLRazon"
        Me.LBLRazon.Size = New System.Drawing.Size(0, 13)
        Me.LBLRazon.TabIndex = 8
        '
        'BTNCambiarConexion
        '
        Me.BTNCambiarConexion.Location = New System.Drawing.Point(92, 266)
        Me.BTNCambiarConexion.Name = "BTNCambiarConexion"
        Me.BTNCambiarConexion.Size = New System.Drawing.Size(294, 23)
        Me.BTNCambiarConexion.TabIndex = 9
        Me.BTNCambiarConexion.Text = "Cambiar Conexion"
        Me.BTNCambiarConexion.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 302)
        Me.Controls.Add(Me.BTNCambiarConexion)
        Me.Controls.Add(Me.LBLRazon)
        Me.Controls.Add(Me.LBLIdioma)
        Me.Controls.Add(Me.CMBIdioma)
        Me.Controls.Add(Me.BTNOlvidarPassword)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.LBLPassword)
        Me.Controls.Add(Me.LBLUsuario)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.TXTUsuario)
        Me.Name = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TXTPassword As System.Windows.Forms.TextBox
    Friend WithEvents LBLUsuario As System.Windows.Forms.Label
    Friend WithEvents LBLPassword As System.Windows.Forms.Label
    Friend WithEvents BTNLogin As System.Windows.Forms.Button
    Friend WithEvents BTNOlvidarPassword As System.Windows.Forms.Button
    Friend WithEvents CMBIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents LBLIdioma As System.Windows.Forms.Label
    Friend WithEvents LBLRazon As System.Windows.Forms.Label
    Friend WithEvents BTNCambiarConexion As System.Windows.Forms.Button
End Class
