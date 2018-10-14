<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitacoraDeUsuario
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
        Me.DTPFechaBitacora = New System.Windows.Forms.DateTimePicker()
        Me.LBLFechaBitacora = New System.Windows.Forms.Label()
        Me.DGVBitacora = New System.Windows.Forms.DataGridView()
        Me.LBLResultadoBitacora = New System.Windows.Forms.Label()
        Me.LBLUsuarioBitacora = New System.Windows.Forms.Label()
        Me.TXTUsuarioBitacora = New System.Windows.Forms.TextBox()
        Me.BTNFiltrarBitacora = New System.Windows.Forms.Button()
        Me.CMBEventoBitacora = New System.Windows.Forms.ComboBox()
        Me.LBLEventoBitacora = New System.Windows.Forms.Label()
        Me.BTNLimpiarBitacora = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFechaBitacora
        '
        Me.DTPFechaBitacora.Location = New System.Drawing.Point(184, 34)
        Me.DTPFechaBitacora.Name = "DTPFechaBitacora"
        Me.DTPFechaBitacora.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaBitacora.TabIndex = 0
        '
        'LBLFechaBitacora
        '
        Me.LBLFechaBitacora.AutoSize = True
        Me.LBLFechaBitacora.Location = New System.Drawing.Point(65, 37)
        Me.LBLFechaBitacora.Name = "LBLFechaBitacora"
        Me.LBLFechaBitacora.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaBitacora.TabIndex = 1
        Me.LBLFechaBitacora.Text = "Fecha"
        '
        'DGVBitacora
        '
        Me.DGVBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usuario, Me.Evento, Me.Fecha, Me.Hora})
        Me.DGVBitacora.Location = New System.Drawing.Point(133, 113)
        Me.DGVBitacora.Name = "DGVBitacora"
        Me.DGVBitacora.Size = New System.Drawing.Size(792, 311)
        Me.DGVBitacora.TabIndex = 2
        '
        'LBLResultadoBitacora
        '
        Me.LBLResultadoBitacora.AutoSize = True
        Me.LBLResultadoBitacora.Location = New System.Drawing.Point(130, 84)
        Me.LBLResultadoBitacora.Name = "LBLResultadoBitacora"
        Me.LBLResultadoBitacora.Size = New System.Drawing.Size(39, 13)
        Me.LBLResultadoBitacora.TabIndex = 3
        Me.LBLResultadoBitacora.Text = "Label2"
        '
        'LBLUsuarioBitacora
        '
        Me.LBLUsuarioBitacora.AutoSize = True
        Me.LBLUsuarioBitacora.Location = New System.Drawing.Point(445, 37)
        Me.LBLUsuarioBitacora.Name = "LBLUsuarioBitacora"
        Me.LBLUsuarioBitacora.Size = New System.Drawing.Size(43, 13)
        Me.LBLUsuarioBitacora.TabIndex = 4
        Me.LBLUsuarioBitacora.Text = "Usuario"
        '
        'TXTUsuarioBitacora
        '
        Me.TXTUsuarioBitacora.Location = New System.Drawing.Point(595, 34)
        Me.TXTUsuarioBitacora.Name = "TXTUsuarioBitacora"
        Me.TXTUsuarioBitacora.Size = New System.Drawing.Size(106, 20)
        Me.TXTUsuarioBitacora.TabIndex = 5
        '
        'BTNFiltrarBitacora
        '
        Me.BTNFiltrarBitacora.Location = New System.Drawing.Point(310, 79)
        Me.BTNFiltrarBitacora.Name = "BTNFiltrarBitacora"
        Me.BTNFiltrarBitacora.Size = New System.Drawing.Size(323, 23)
        Me.BTNFiltrarBitacora.TabIndex = 6
        Me.BTNFiltrarBitacora.Text = "Filtrar"
        Me.BTNFiltrarBitacora.UseVisualStyleBackColor = True
        '
        'CMBEventoBitacora
        '
        Me.CMBEventoBitacora.FormattingEnabled = True
        Me.CMBEventoBitacora.Location = New System.Drawing.Point(879, 33)
        Me.CMBEventoBitacora.Name = "CMBEventoBitacora"
        Me.CMBEventoBitacora.Size = New System.Drawing.Size(121, 21)
        Me.CMBEventoBitacora.TabIndex = 7
        '
        'LBLEventoBitacora
        '
        Me.LBLEventoBitacora.AutoSize = True
        Me.LBLEventoBitacora.Location = New System.Drawing.Point(738, 36)
        Me.LBLEventoBitacora.Name = "LBLEventoBitacora"
        Me.LBLEventoBitacora.Size = New System.Drawing.Size(41, 13)
        Me.LBLEventoBitacora.TabIndex = 8
        Me.LBLEventoBitacora.Text = "Evento"
        '
        'BTNLimpiarBitacora
        '
        Me.BTNLimpiarBitacora.Location = New System.Drawing.Point(682, 79)
        Me.BTNLimpiarBitacora.Name = "BTNLimpiarBitacora"
        Me.BTNLimpiarBitacora.Size = New System.Drawing.Size(243, 23)
        Me.BTNLimpiarBitacora.TabIndex = 9
        Me.BTNLimpiarBitacora.Text = "Limpiar"
        Me.BTNLimpiarBitacora.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "usuario"
        Me.Usuario.Frozen = True
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Evento
        '
        Me.Evento.DataPropertyName = "evento"
        Me.Evento.Frozen = True
        Me.Evento.HeaderText = "Evento"
        Me.Evento.Name = "Evento"
        Me.Evento.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "fecha"
        Me.Fecha.Frozen = True
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Hora
        '
        Me.Hora.DataPropertyName = "hora"
        Me.Hora.Frozen = True
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        '
        'BitacoraDeUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 590)
        Me.Controls.Add(Me.BTNLimpiarBitacora)
        Me.Controls.Add(Me.LBLEventoBitacora)
        Me.Controls.Add(Me.CMBEventoBitacora)
        Me.Controls.Add(Me.BTNFiltrarBitacora)
        Me.Controls.Add(Me.TXTUsuarioBitacora)
        Me.Controls.Add(Me.LBLUsuarioBitacora)
        Me.Controls.Add(Me.LBLResultadoBitacora)
        Me.Controls.Add(Me.DGVBitacora)
        Me.Controls.Add(Me.LBLFechaBitacora)
        Me.Controls.Add(Me.DTPFechaBitacora)
        Me.Name = "BitacoraDeUsuario"
        Me.Text = "BitacoraDeUsuario"
        CType(Me.DGVBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTPFechaBitacora As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLFechaBitacora As System.Windows.Forms.Label
    Friend WithEvents DGVBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents LBLResultadoBitacora As System.Windows.Forms.Label
    Friend WithEvents LBLUsuarioBitacora As System.Windows.Forms.Label
    Friend WithEvents TXTUsuarioBitacora As System.Windows.Forms.TextBox
    Friend WithEvents BTNFiltrarBitacora As System.Windows.Forms.Button
    Friend WithEvents CMBEventoBitacora As System.Windows.Forms.ComboBox
    Friend WithEvents LBLEventoBitacora As System.Windows.Forms.Label
    Friend WithEvents BTNLimpiarBitacora As System.Windows.Forms.Button
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
