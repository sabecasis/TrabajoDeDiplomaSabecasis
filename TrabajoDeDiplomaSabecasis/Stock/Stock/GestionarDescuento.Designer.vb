<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarDescuento
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
        Me.LBLIdDescuento = New System.Windows.Forms.Label()
        Me.TXTIdDescuento = New System.Windows.Forms.TextBox()
        Me.TXTMontoDescuento = New System.Windows.Forms.TextBox()
        Me.LBLMontoDescuento = New System.Windows.Forms.Label()
        Me.TXTPorcentajeDescuento = New System.Windows.Forms.TextBox()
        Me.LBLPorcentajeDescuento = New System.Windows.Forms.Label()
        Me.TXTDescripcionDescuento = New System.Windows.Forms.TextBox()
        Me.LBLDescripcionDescuento = New System.Windows.Forms.Label()
        Me.LBLMonedaDescuento = New System.Windows.Forms.Label()
        Me.CMBMonedaDescuento = New System.Windows.Forms.ComboBox()
        Me.BTNBuscarDescuento = New System.Windows.Forms.Button()
        Me.BTNEliminarDescuento = New System.Windows.Forms.Button()
        Me.BTNGuardarDescuento = New System.Windows.Forms.Button()
        Me.BTNLimpiarDescuento = New System.Windows.Forms.Button()
        Me.TXTNombreDescuento = New System.Windows.Forms.TextBox()
        Me.LBLNombreDescuento = New System.Windows.Forms.Label()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLIdDescuento
        '
        Me.LBLIdDescuento.AutoSize = True
        Me.LBLIdDescuento.Location = New System.Drawing.Point(41, 56)
        Me.LBLIdDescuento.Name = "LBLIdDescuento"
        Me.LBLIdDescuento.Size = New System.Drawing.Size(69, 13)
        Me.LBLIdDescuento.TabIndex = 0
        Me.LBLIdDescuento.Text = "Id descuento"
        '
        'TXTIdDescuento
        '
        Me.TXTIdDescuento.Location = New System.Drawing.Point(204, 53)
        Me.TXTIdDescuento.Name = "TXTIdDescuento"
        Me.TXTIdDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdDescuento.TabIndex = 1
        Me.TXTIdDescuento.Text = "0"
        '
        'TXTMontoDescuento
        '
        Me.TXTMontoDescuento.Location = New System.Drawing.Point(204, 103)
        Me.TXTMontoDescuento.Name = "TXTMontoDescuento"
        Me.TXTMontoDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TXTMontoDescuento.TabIndex = 3
        Me.TXTMontoDescuento.Text = "0"
        '
        'LBLMontoDescuento
        '
        Me.LBLMontoDescuento.AutoSize = True
        Me.LBLMontoDescuento.Location = New System.Drawing.Point(41, 106)
        Me.LBLMontoDescuento.Name = "LBLMontoDescuento"
        Me.LBLMontoDescuento.Size = New System.Drawing.Size(37, 13)
        Me.LBLMontoDescuento.TabIndex = 2
        Me.LBLMontoDescuento.Text = "Monto"
        '
        'TXTPorcentajeDescuento
        '
        Me.TXTPorcentajeDescuento.Location = New System.Drawing.Point(204, 129)
        Me.TXTPorcentajeDescuento.Name = "TXTPorcentajeDescuento"
        Me.TXTPorcentajeDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TXTPorcentajeDescuento.TabIndex = 5
        Me.TXTPorcentajeDescuento.Text = "0"
        '
        'LBLPorcentajeDescuento
        '
        Me.LBLPorcentajeDescuento.AutoSize = True
        Me.LBLPorcentajeDescuento.Location = New System.Drawing.Point(41, 132)
        Me.LBLPorcentajeDescuento.Name = "LBLPorcentajeDescuento"
        Me.LBLPorcentajeDescuento.Size = New System.Drawing.Size(58, 13)
        Me.LBLPorcentajeDescuento.TabIndex = 4
        Me.LBLPorcentajeDescuento.Text = "Porcentaje"
        '
        'TXTDescripcionDescuento
        '
        Me.TXTDescripcionDescuento.Location = New System.Drawing.Point(204, 155)
        Me.TXTDescripcionDescuento.Name = "TXTDescripcionDescuento"
        Me.TXTDescripcionDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TXTDescripcionDescuento.TabIndex = 7
        '
        'LBLDescripcionDescuento
        '
        Me.LBLDescripcionDescuento.AutoSize = True
        Me.LBLDescripcionDescuento.Location = New System.Drawing.Point(41, 158)
        Me.LBLDescripcionDescuento.Name = "LBLDescripcionDescuento"
        Me.LBLDescripcionDescuento.Size = New System.Drawing.Size(60, 13)
        Me.LBLDescripcionDescuento.TabIndex = 6
        Me.LBLDescripcionDescuento.Text = "Descipcion"
        '
        'LBLMonedaDescuento
        '
        Me.LBLMonedaDescuento.AutoSize = True
        Me.LBLMonedaDescuento.Location = New System.Drawing.Point(41, 185)
        Me.LBLMonedaDescuento.Name = "LBLMonedaDescuento"
        Me.LBLMonedaDescuento.Size = New System.Drawing.Size(46, 13)
        Me.LBLMonedaDescuento.TabIndex = 8
        Me.LBLMonedaDescuento.Text = "Moneda"
        '
        'CMBMonedaDescuento
        '
        Me.CMBMonedaDescuento.FormattingEnabled = True
        Me.CMBMonedaDescuento.Location = New System.Drawing.Point(204, 182)
        Me.CMBMonedaDescuento.Name = "CMBMonedaDescuento"
        Me.CMBMonedaDescuento.Size = New System.Drawing.Size(121, 21)
        Me.CMBMonedaDescuento.TabIndex = 9
        '
        'BTNBuscarDescuento
        '
        Me.BTNBuscarDescuento.Location = New System.Drawing.Point(147, 305)
        Me.BTNBuscarDescuento.Name = "BTNBuscarDescuento"
        Me.BTNBuscarDescuento.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarDescuento.TabIndex = 13
        Me.BTNBuscarDescuento.Text = "Buscar"
        Me.BTNBuscarDescuento.UseVisualStyleBackColor = True
        '
        'BTNEliminarDescuento
        '
        Me.BTNEliminarDescuento.Location = New System.Drawing.Point(44, 305)
        Me.BTNEliminarDescuento.Name = "BTNEliminarDescuento"
        Me.BTNEliminarDescuento.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarDescuento.TabIndex = 12
        Me.BTNEliminarDescuento.Text = "Eliminar"
        Me.BTNEliminarDescuento.UseVisualStyleBackColor = True
        '
        'BTNGuardarDescuento
        '
        Me.BTNGuardarDescuento.Location = New System.Drawing.Point(147, 257)
        Me.BTNGuardarDescuento.Name = "BTNGuardarDescuento"
        Me.BTNGuardarDescuento.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarDescuento.TabIndex = 11
        Me.BTNGuardarDescuento.Text = "Guardar"
        Me.BTNGuardarDescuento.UseVisualStyleBackColor = True
        '
        'BTNLimpiarDescuento
        '
        Me.BTNLimpiarDescuento.Location = New System.Drawing.Point(44, 257)
        Me.BTNLimpiarDescuento.Name = "BTNLimpiarDescuento"
        Me.BTNLimpiarDescuento.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarDescuento.TabIndex = 10
        Me.BTNLimpiarDescuento.Text = "Limpiar"
        Me.BTNLimpiarDescuento.UseVisualStyleBackColor = True
        '
        'TXTNombreDescuento
        '
        Me.TXTNombreDescuento.Location = New System.Drawing.Point(204, 77)
        Me.TXTNombreDescuento.Name = "TXTNombreDescuento"
        Me.TXTNombreDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombreDescuento.TabIndex = 14
        '
        'LBLNombreDescuento
        '
        Me.LBLNombreDescuento.AutoSize = True
        Me.LBLNombreDescuento.Location = New System.Drawing.Point(41, 80)
        Me.LBLNombreDescuento.Name = "LBLNombreDescuento"
        Me.LBLNombreDescuento.Size = New System.Drawing.Size(44, 13)
        Me.LBLNombreDescuento.TabIndex = 15
        Me.LBLNombreDescuento.Text = "Nombre"
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(44, 13)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 16
        '
        'GestionarDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 368)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.LBLNombreDescuento)
        Me.Controls.Add(Me.TXTNombreDescuento)
        Me.Controls.Add(Me.BTNBuscarDescuento)
        Me.Controls.Add(Me.BTNEliminarDescuento)
        Me.Controls.Add(Me.BTNGuardarDescuento)
        Me.Controls.Add(Me.BTNLimpiarDescuento)
        Me.Controls.Add(Me.CMBMonedaDescuento)
        Me.Controls.Add(Me.LBLMonedaDescuento)
        Me.Controls.Add(Me.TXTDescripcionDescuento)
        Me.Controls.Add(Me.LBLDescripcionDescuento)
        Me.Controls.Add(Me.TXTPorcentajeDescuento)
        Me.Controls.Add(Me.LBLPorcentajeDescuento)
        Me.Controls.Add(Me.TXTMontoDescuento)
        Me.Controls.Add(Me.LBLMontoDescuento)
        Me.Controls.Add(Me.TXTIdDescuento)
        Me.Controls.Add(Me.LBLIdDescuento)
        Me.Name = "GestionarDescuento"
        Me.Text = "GestionarDescuento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIdDescuento As System.Windows.Forms.Label
    Friend WithEvents TXTIdDescuento As System.Windows.Forms.TextBox
    Friend WithEvents TXTMontoDescuento As System.Windows.Forms.TextBox
    Friend WithEvents LBLMontoDescuento As System.Windows.Forms.Label
    Friend WithEvents TXTPorcentajeDescuento As System.Windows.Forms.TextBox
    Friend WithEvents LBLPorcentajeDescuento As System.Windows.Forms.Label
    Friend WithEvents TXTDescripcionDescuento As System.Windows.Forms.TextBox
    Friend WithEvents LBLDescripcionDescuento As System.Windows.Forms.Label
    Friend WithEvents LBLMonedaDescuento As System.Windows.Forms.Label
    Friend WithEvents CMBMonedaDescuento As System.Windows.Forms.ComboBox
    Friend WithEvents BTNBuscarDescuento As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarDescuento As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarDescuento As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarDescuento As System.Windows.Forms.Button
    Friend WithEvents TXTNombreDescuento As System.Windows.Forms.TextBox
    Friend WithEvents LBLNombreDescuento As System.Windows.Forms.Label
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
End Class
