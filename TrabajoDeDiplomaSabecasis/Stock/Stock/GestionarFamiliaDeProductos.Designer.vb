<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarFamiliaDeProductos
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
        Me.LBLIdFamilia = New System.Windows.Forms.Label()
        Me.LBLFmiliaProd = New System.Windows.Forms.Label()
        Me.TXTIdFamilia = New System.Windows.Forms.TextBox()
        Me.TXTFamilia = New System.Windows.Forms.TextBox()
        Me.BTNBuscarFamilia = New System.Windows.Forms.Button()
        Me.BTNEliminarFamilia = New System.Windows.Forms.Button()
        Me.BTNGuardarFamilia = New System.Windows.Forms.Button()
        Me.BTNLimpiarFamilia = New System.Windows.Forms.Button()
        Me.BLMensaje = New System.Windows.Forms.Label()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLIdFamilia
        '
        Me.LBLIdFamilia.AutoSize = True
        Me.LBLIdFamilia.Location = New System.Drawing.Point(62, 57)
        Me.LBLIdFamilia.Name = "LBLIdFamilia"
        Me.LBLIdFamilia.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdFamilia.TabIndex = 0
        Me.LBLIdFamilia.Text = "Id"
        '
        'LBLFmiliaProd
        '
        Me.LBLFmiliaProd.AutoSize = True
        Me.LBLFmiliaProd.Location = New System.Drawing.Point(62, 88)
        Me.LBLFmiliaProd.Name = "LBLFmiliaProd"
        Me.LBLFmiliaProd.Size = New System.Drawing.Size(39, 13)
        Me.LBLFmiliaProd.TabIndex = 1
        Me.LBLFmiliaProd.Text = "Familia"
        '
        'TXTIdFamilia
        '
        Me.TXTIdFamilia.Location = New System.Drawing.Point(214, 49)
        Me.TXTIdFamilia.Name = "TXTIdFamilia"
        Me.TXTIdFamilia.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdFamilia.TabIndex = 2
        Me.TXTIdFamilia.Text = "0"
        '
        'TXTFamilia
        '
        Me.TXTFamilia.Location = New System.Drawing.Point(214, 81)
        Me.TXTFamilia.Name = "TXTFamilia"
        Me.TXTFamilia.Size = New System.Drawing.Size(100, 20)
        Me.TXTFamilia.TabIndex = 3
        '
        'BTNBuscarFamilia
        '
        Me.BTNBuscarFamilia.Location = New System.Drawing.Point(214, 198)
        Me.BTNBuscarFamilia.Name = "BTNBuscarFamilia"
        Me.BTNBuscarFamilia.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarFamilia.TabIndex = 35
        Me.BTNBuscarFamilia.Text = "Buscar"
        Me.BTNBuscarFamilia.UseVisualStyleBackColor = True
        '
        'BTNEliminarFamilia
        '
        Me.BTNEliminarFamilia.Location = New System.Drawing.Point(91, 198)
        Me.BTNEliminarFamilia.Name = "BTNEliminarFamilia"
        Me.BTNEliminarFamilia.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarFamilia.TabIndex = 34
        Me.BTNEliminarFamilia.Text = "Eliminar"
        Me.BTNEliminarFamilia.UseVisualStyleBackColor = True
        '
        'BTNGuardarFamilia
        '
        Me.BTNGuardarFamilia.Location = New System.Drawing.Point(214, 155)
        Me.BTNGuardarFamilia.Name = "BTNGuardarFamilia"
        Me.BTNGuardarFamilia.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarFamilia.TabIndex = 33
        Me.BTNGuardarFamilia.Text = "Guardar"
        Me.BTNGuardarFamilia.UseVisualStyleBackColor = True
        '
        'BTNLimpiarFamilia
        '
        Me.BTNLimpiarFamilia.Location = New System.Drawing.Point(91, 155)
        Me.BTNLimpiarFamilia.Name = "BTNLimpiarFamilia"
        Me.BTNLimpiarFamilia.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarFamilia.TabIndex = 32
        Me.BTNLimpiarFamilia.Text = "Limpiar"
        Me.BTNLimpiarFamilia.UseVisualStyleBackColor = True
        '
        'BLMensaje
        '
        Me.BLMensaje.AutoSize = True
        Me.BLMensaje.ForeColor = System.Drawing.Color.Red
        Me.BLMensaje.Location = New System.Drawing.Point(65, 13)
        Me.BLMensaje.Name = "BLMensaje"
        Me.BLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.BLMensaje.TabIndex = 36
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(65, 13)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 37
        '
        'GestionarFamiliaDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 261)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.BLMensaje)
        Me.Controls.Add(Me.BTNBuscarFamilia)
        Me.Controls.Add(Me.BTNEliminarFamilia)
        Me.Controls.Add(Me.BTNGuardarFamilia)
        Me.Controls.Add(Me.BTNLimpiarFamilia)
        Me.Controls.Add(Me.TXTFamilia)
        Me.Controls.Add(Me.TXTIdFamilia)
        Me.Controls.Add(Me.LBLFmiliaProd)
        Me.Controls.Add(Me.LBLIdFamilia)
        Me.Name = "GestionarFamiliaDeProductos"
        Me.Text = "GestionarFamiliaDeProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIdFamilia As System.Windows.Forms.Label
    Friend WithEvents LBLFmiliaProd As System.Windows.Forms.Label
    Friend WithEvents TXTIdFamilia As System.Windows.Forms.TextBox
    Friend WithEvents TXTFamilia As System.Windows.Forms.TextBox
    Friend WithEvents BTNBuscarFamilia As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarFamilia As System.Windows.Forms.Button
    Friend WithEvents BTNGuardarFamilia As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarFamilia As System.Windows.Forms.Button
    Friend WithEvents BLMensaje As System.Windows.Forms.Label
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
End Class
