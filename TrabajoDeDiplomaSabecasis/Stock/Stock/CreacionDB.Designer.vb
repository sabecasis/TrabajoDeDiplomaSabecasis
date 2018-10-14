<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreacionDB
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
        Me.LBLstringConn = New System.Windows.Forms.Label()
        Me.TXTStringDeConexion = New System.Windows.Forms.TextBox()
        Me.BTNCambiarConn = New System.Windows.Forms.Button()
        Me.CHKAutenticacion = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTUsuario = New System.Windows.Forms.TextBox()
        Me.TXTPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LBLstringConn
        '
        Me.LBLstringConn.AutoSize = True
        Me.LBLstringConn.Location = New System.Drawing.Point(47, 33)
        Me.LBLstringConn.Name = "LBLstringConn"
        Me.LBLstringConn.Size = New System.Drawing.Size(117, 13)
        Me.LBLstringConn.TabIndex = 0
        Me.LBLstringConn.Text = "Nombre del servidor sql"
        '
        'TXTStringDeConexion
        '
        Me.TXTStringDeConexion.Location = New System.Drawing.Point(228, 26)
        Me.TXTStringDeConexion.Name = "TXTStringDeConexion"
        Me.TXTStringDeConexion.Size = New System.Drawing.Size(289, 20)
        Me.TXTStringDeConexion.TabIndex = 1
        '
        'BTNCambiarConn
        '
        Me.BTNCambiarConn.Location = New System.Drawing.Point(228, 167)
        Me.BTNCambiarConn.Name = "BTNCambiarConn"
        Me.BTNCambiarConn.Size = New System.Drawing.Size(75, 23)
        Me.BTNCambiarConn.TabIndex = 2
        Me.BTNCambiarConn.Text = "Cambiar"
        Me.BTNCambiarConn.UseVisualStyleBackColor = True
        '
        'CHKAutenticacion
        '
        Me.CHKAutenticacion.AutoSize = True
        Me.CHKAutenticacion.Location = New System.Drawing.Point(228, 130)
        Me.CHKAutenticacion.Name = "CHKAutenticacion"
        Me.CHKAutenticacion.Size = New System.Drawing.Size(150, 17)
        Me.CHKAutenticacion.TabIndex = 5
        Me.CHKAutenticacion.Text = "Autenticación de windows"
        Me.CHKAutenticacion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "password"
        '
        'TXTUsuario
        '
        Me.TXTUsuario.Location = New System.Drawing.Point(228, 61)
        Me.TXTUsuario.Name = "TXTUsuario"
        Me.TXTUsuario.Size = New System.Drawing.Size(289, 20)
        Me.TXTUsuario.TabIndex = 8
        '
        'TXTPass
        '
        Me.TXTPass.Location = New System.Drawing.Point(228, 87)
        Me.TXTPass.Name = "TXTPass"
        Me.TXTPass.Size = New System.Drawing.Size(289, 20)
        Me.TXTPass.TabIndex = 9
        '
        'CreacionDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 261)
        Me.Controls.Add(Me.TXTPass)
        Me.Controls.Add(Me.TXTUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CHKAutenticacion)
        Me.Controls.Add(Me.BTNCambiarConn)
        Me.Controls.Add(Me.TXTStringDeConexion)
        Me.Controls.Add(Me.LBLstringConn)
        Me.Name = "CreacionDB"
        Me.Text = "CreacionDB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLstringConn As System.Windows.Forms.Label
    Friend WithEvents TXTStringDeConexion As System.Windows.Forms.TextBox
    Friend WithEvents BTNCambiarConn As System.Windows.Forms.Button
    Friend WithEvents CHKAutenticacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TXTPass As System.Windows.Forms.TextBox
End Class
