<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarMoneda
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
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.BTNBuscarMoneda = New System.Windows.Forms.Button()
        Me.BTNEliminarMoneda = New System.Windows.Forms.Button()
        Me.BTNGuardarMoneda = New System.Windows.Forms.Button()
        Me.BTNLimpiarMoneda = New System.Windows.Forms.Button()
        Me.TXTMoneda = New System.Windows.Forms.TextBox()
        Me.LBLMoneda = New System.Windows.Forms.Label()
        Me.TXTIdMoneda = New System.Windows.Forms.TextBox()
        Me.LblIdMoneda = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(62, 18)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 17
        '
        'BTNBuscarMoneda
        '
        Me.BTNBuscarMoneda.Location = New System.Drawing.Point(168, 206)
        Me.BTNBuscarMoneda.Name = "BTNBuscarMoneda"
        Me.BTNBuscarMoneda.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarMoneda.TabIndex = 16
        Me.BTNBuscarMoneda.Text = "Buscar"
        Me.BTNBuscarMoneda.UseVisualStyleBackColor = True
        '
        'BTNEliminarMoneda
        '
        Me.BTNEliminarMoneda.Location = New System.Drawing.Point(65, 206)
        Me.BTNEliminarMoneda.Name = "BTNEliminarMoneda"
        Me.BTNEliminarMoneda.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarMoneda.TabIndex = 15
        Me.BTNEliminarMoneda.Text = "Eliminar"
        Me.BTNEliminarMoneda.UseVisualStyleBackColor = True
        '
        'BTNGuardarMoneda
        '
        Me.BTNGuardarMoneda.Location = New System.Drawing.Point(168, 158)
        Me.BTNGuardarMoneda.Name = "BTNGuardarMoneda"
        Me.BTNGuardarMoneda.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarMoneda.TabIndex = 14
        Me.BTNGuardarMoneda.Text = "Guardar"
        Me.BTNGuardarMoneda.UseVisualStyleBackColor = True
        '
        'BTNLimpiarMoneda
        '
        Me.BTNLimpiarMoneda.Location = New System.Drawing.Point(65, 158)
        Me.BTNLimpiarMoneda.Name = "BTNLimpiarMoneda"
        Me.BTNLimpiarMoneda.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarMoneda.TabIndex = 13
        Me.BTNLimpiarMoneda.Text = "Limpiar"
        Me.BTNLimpiarMoneda.UseVisualStyleBackColor = True
        '
        'TXTMoneda
        '
        Me.TXTMoneda.Location = New System.Drawing.Point(189, 104)
        Me.TXTMoneda.Name = "TXTMoneda"
        Me.TXTMoneda.Size = New System.Drawing.Size(100, 20)
        Me.TXTMoneda.TabIndex = 12
        '
        'LBLMoneda
        '
        Me.LBLMoneda.AutoSize = True
        Me.LBLMoneda.Location = New System.Drawing.Point(62, 107)
        Me.LBLMoneda.Name = "LBLMoneda"
        Me.LBLMoneda.Size = New System.Drawing.Size(45, 13)
        Me.LBLMoneda.TabIndex = 11
        Me.LBLMoneda.Text = "moneda"
        '
        'TXTIdMoneda
        '
        Me.TXTIdMoneda.Location = New System.Drawing.Point(189, 59)
        Me.TXTIdMoneda.Name = "TXTIdMoneda"
        Me.TXTIdMoneda.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdMoneda.TabIndex = 10
        '
        'LblIdMoneda
        '
        Me.LblIdMoneda.AutoSize = True
        Me.LblIdMoneda.Location = New System.Drawing.Point(62, 62)
        Me.LblIdMoneda.Name = "LblIdMoneda"
        Me.LblIdMoneda.Size = New System.Drawing.Size(57, 13)
        Me.LblIdMoneda.TabIndex = 9
        Me.LblIdMoneda.Text = "Id moneda"
        '
        'GestionarMoneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 261)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BTNBuscarMoneda)
        Me.Controls.Add(Me.BTNEliminarMoneda)
        Me.Controls.Add(Me.BTNGuardarMoneda)
        Me.Controls.Add(Me.BTNLimpiarMoneda)
        Me.Controls.Add(Me.TXTMoneda)
        Me.Controls.Add(Me.LBLMoneda)
        Me.Controls.Add(Me.TXTIdMoneda)
        Me.Controls.Add(Me.LblIdMoneda)
        Me.Name = "GestionarMoneda"
        Me.Text = "GestionarMoneda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents BTNBuscarMoneda As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarMoneda As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarMoneda As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarMoneda As System.Windows.Forms.Button
    Friend WithEvents TXTMoneda As System.Windows.Forms.TextBox
    Friend WithEvents LBLMoneda As System.Windows.Forms.Label
    Friend WithEvents TXTIdMoneda As System.Windows.Forms.TextBox
    Friend WithEvents LblIdMoneda As System.Windows.Forms.Label
End Class
