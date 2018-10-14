<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarMarca
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
        Me.LBLIdMarca = New System.Windows.Forms.Label()
        Me.TXTIdMarca = New System.Windows.Forms.TextBox()
        Me.LBLMarca = New System.Windows.Forms.Label()
        Me.TXTMarca = New System.Windows.Forms.TextBox()
        Me.BTNLimpiarMarca = New System.Windows.Forms.Button()
        Me.BTNGuardarMarca = New System.Windows.Forms.Button()
        Me.BTNEliminarMarca = New System.Windows.Forms.Button()
        Me.BTNBuscarMarca = New System.Windows.Forms.Button()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLIdMarca
        '
        Me.LBLIdMarca.AutoSize = True
        Me.LBLIdMarca.Location = New System.Drawing.Point(43, 53)
        Me.LBLIdMarca.Name = "LBLIdMarca"
        Me.LBLIdMarca.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdMarca.TabIndex = 0
        Me.LBLIdMarca.Text = "Id"
        '
        'TXTIdMarca
        '
        Me.TXTIdMarca.Location = New System.Drawing.Point(170, 50)
        Me.TXTIdMarca.Name = "TXTIdMarca"
        Me.TXTIdMarca.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdMarca.TabIndex = 1
        '
        'LBLMarca
        '
        Me.LBLMarca.AutoSize = True
        Me.LBLMarca.Location = New System.Drawing.Point(43, 98)
        Me.LBLMarca.Name = "LBLMarca"
        Me.LBLMarca.Size = New System.Drawing.Size(37, 13)
        Me.LBLMarca.TabIndex = 2
        Me.LBLMarca.Text = "Marca"
        '
        'TXTMarca
        '
        Me.TXTMarca.Location = New System.Drawing.Point(170, 95)
        Me.TXTMarca.Name = "TXTMarca"
        Me.TXTMarca.Size = New System.Drawing.Size(100, 20)
        Me.TXTMarca.TabIndex = 3
        '
        'BTNLimpiarMarca
        '
        Me.BTNLimpiarMarca.Location = New System.Drawing.Point(46, 149)
        Me.BTNLimpiarMarca.Name = "BTNLimpiarMarca"
        Me.BTNLimpiarMarca.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarMarca.TabIndex = 4
        Me.BTNLimpiarMarca.Text = "Limpiar"
        Me.BTNLimpiarMarca.UseVisualStyleBackColor = True
        '
        'BTNGuardarMarca
        '
        Me.BTNGuardarMarca.Location = New System.Drawing.Point(149, 149)
        Me.BTNGuardarMarca.Name = "BTNGuardarMarca"
        Me.BTNGuardarMarca.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarMarca.TabIndex = 5
        Me.BTNGuardarMarca.Text = "Guardar"
        Me.BTNGuardarMarca.UseVisualStyleBackColor = True
        '
        'BTNEliminarMarca
        '
        Me.BTNEliminarMarca.Location = New System.Drawing.Point(46, 197)
        Me.BTNEliminarMarca.Name = "BTNEliminarMarca"
        Me.BTNEliminarMarca.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarMarca.TabIndex = 6
        Me.BTNEliminarMarca.Text = "Eliminar"
        Me.BTNEliminarMarca.UseVisualStyleBackColor = True
        '
        'BTNBuscarMarca
        '
        Me.BTNBuscarMarca.Location = New System.Drawing.Point(149, 197)
        Me.BTNBuscarMarca.Name = "BTNBuscarMarca"
        Me.BTNBuscarMarca.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarMarca.TabIndex = 7
        Me.BTNBuscarMarca.Text = "Buscar"
        Me.BTNBuscarMarca.UseVisualStyleBackColor = True
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(21, 9)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 8
        '
        'GestionarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 261)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BTNBuscarMarca)
        Me.Controls.Add(Me.BTNEliminarMarca)
        Me.Controls.Add(Me.BTNGuardarMarca)
        Me.Controls.Add(Me.BTNLimpiarMarca)
        Me.Controls.Add(Me.TXTMarca)
        Me.Controls.Add(Me.LBLMarca)
        Me.Controls.Add(Me.TXTIdMarca)
        Me.Controls.Add(Me.LBLIdMarca)
        Me.Name = "GestionarMarca"
        Me.Text = "GestionarMarca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIdMarca As System.Windows.Forms.Label
    Friend WithEvents TXTIdMarca As System.Windows.Forms.TextBox
    Friend WithEvents LBLMarca As System.Windows.Forms.Label
    Friend WithEvents TXTMarca As System.Windows.Forms.TextBox
    Friend WithEvents BTNLimpiarMarca As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarMarca As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarMarca As System.Windows.Forms.Button
    Friend WithEvents BTNBuscarMarca As System.Windows.Forms.Button
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
End Class
