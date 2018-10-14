<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogDeErrores
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
        Me.BTNFiltrarLogDeErrores = New System.Windows.Forms.Button()
        Me.BTNLimpiarLogDeErrores = New System.Windows.Forms.Button()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.CMBTipoExcepcion = New System.Windows.Forms.ComboBox()
        Me.TXTQuery = New System.Windows.Forms.TextBox()
        Me.TXTClase = New System.Windows.Forms.TextBox()
        Me.TXTIdError = New System.Windows.Forms.TextBox()
        Me.LBLFechaLogErrores = New System.Windows.Forms.Label()
        Me.LBLTipoExcepcionLogErrores = New System.Windows.Forms.Label()
        Me.LBLQueryLogErrores = New System.Windows.Forms.Label()
        Me.LBLIdErrorLogDeErrores = New System.Windows.Forms.Label()
        Me.LBLClaseLogErrores = New System.Windows.Forms.Label()
        Me.CHKIgnorarFechaLogErrores = New System.Windows.Forms.CheckBox()
        Me.CHKIgnorarTipoDeExcepcion = New System.Windows.Forms.CheckBox()
        Me.DGVErrores = New System.Windows.Forms.DataGridView()
        CType(Me.DGVErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNFiltrarLogDeErrores
        '
        Me.BTNFiltrarLogDeErrores.Location = New System.Drawing.Point(670, 102)
        Me.BTNFiltrarLogDeErrores.Name = "BTNFiltrarLogDeErrores"
        Me.BTNFiltrarLogDeErrores.Size = New System.Drawing.Size(75, 23)
        Me.BTNFiltrarLogDeErrores.TabIndex = 0
        Me.BTNFiltrarLogDeErrores.Text = "Filtrar"
        Me.BTNFiltrarLogDeErrores.UseVisualStyleBackColor = True
        '
        'BTNLimpiarLogDeErrores
        '
        Me.BTNLimpiarLogDeErrores.Location = New System.Drawing.Point(802, 102)
        Me.BTNLimpiarLogDeErrores.Name = "BTNLimpiarLogDeErrores"
        Me.BTNLimpiarLogDeErrores.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarLogDeErrores.TabIndex = 1
        Me.BTNLimpiarLogDeErrores.Text = "Limpiar"
        Me.BTNLimpiarLogDeErrores.UseVisualStyleBackColor = True
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(106, 24)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecha.TabIndex = 2
        '
        'CMBTipoExcepcion
        '
        Me.CMBTipoExcepcion.FormattingEnabled = True
        Me.CMBTipoExcepcion.Location = New System.Drawing.Point(450, 23)
        Me.CMBTipoExcepcion.Name = "CMBTipoExcepcion"
        Me.CMBTipoExcepcion.Size = New System.Drawing.Size(121, 21)
        Me.CMBTipoExcepcion.TabIndex = 3
        '
        'TXTQuery
        '
        Me.TXTQuery.Location = New System.Drawing.Point(153, 95)
        Me.TXTQuery.Name = "TXTQuery"
        Me.TXTQuery.Size = New System.Drawing.Size(100, 20)
        Me.TXTQuery.TabIndex = 4
        '
        'TXTClase
        '
        Me.TXTClase.Location = New System.Drawing.Point(752, 23)
        Me.TXTClase.Name = "TXTClase"
        Me.TXTClase.Size = New System.Drawing.Size(100, 20)
        Me.TXTClase.TabIndex = 5
        '
        'TXTIdError
        '
        Me.TXTIdError.Location = New System.Drawing.Point(450, 95)
        Me.TXTIdError.Name = "TXTIdError"
        Me.TXTIdError.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdError.TabIndex = 6
        '
        'LBLFechaLogErrores
        '
        Me.LBLFechaLogErrores.AutoSize = True
        Me.LBLFechaLogErrores.Location = New System.Drawing.Point(29, 31)
        Me.LBLFechaLogErrores.Name = "LBLFechaLogErrores"
        Me.LBLFechaLogErrores.Size = New System.Drawing.Size(37, 13)
        Me.LBLFechaLogErrores.TabIndex = 7
        Me.LBLFechaLogErrores.Text = "Fecha"
        '
        'LBLTipoExcepcionLogErrores
        '
        Me.LBLTipoExcepcionLogErrores.AutoSize = True
        Me.LBLTipoExcepcionLogErrores.Location = New System.Drawing.Point(335, 31)
        Me.LBLTipoExcepcionLogErrores.Name = "LBLTipoExcepcionLogErrores"
        Me.LBLTipoExcepcionLogErrores.Size = New System.Drawing.Size(95, 13)
        Me.LBLTipoExcepcionLogErrores.TabIndex = 8
        Me.LBLTipoExcepcionLogErrores.Text = "Tipo de excepción"
        '
        'LBLQueryLogErrores
        '
        Me.LBLQueryLogErrores.AutoSize = True
        Me.LBLQueryLogErrores.Location = New System.Drawing.Point(46, 98)
        Me.LBLQueryLogErrores.Name = "LBLQueryLogErrores"
        Me.LBLQueryLogErrores.Size = New System.Drawing.Size(35, 13)
        Me.LBLQueryLogErrores.TabIndex = 9
        Me.LBLQueryLogErrores.Text = "Query"
        '
        'LBLIdErrorLogDeErrores
        '
        Me.LBLIdErrorLogDeErrores.AutoSize = True
        Me.LBLIdErrorLogDeErrores.Location = New System.Drawing.Point(335, 102)
        Me.LBLIdErrorLogDeErrores.Name = "LBLIdErrorLogDeErrores"
        Me.LBLIdErrorLogDeErrores.Size = New System.Drawing.Size(41, 13)
        Me.LBLIdErrorLogDeErrores.TabIndex = 10
        Me.LBLIdErrorLogDeErrores.Text = "Id Error"
        '
        'LBLClaseLogErrores
        '
        Me.LBLClaseLogErrores.AutoSize = True
        Me.LBLClaseLogErrores.Location = New System.Drawing.Point(650, 26)
        Me.LBLClaseLogErrores.Name = "LBLClaseLogErrores"
        Me.LBLClaseLogErrores.Size = New System.Drawing.Size(33, 13)
        Me.LBLClaseLogErrores.TabIndex = 11
        Me.LBLClaseLogErrores.Text = "Clase"
        '
        'CHKIgnorarFechaLogErrores
        '
        Me.CHKIgnorarFechaLogErrores.AutoSize = True
        Me.CHKIgnorarFechaLogErrores.Location = New System.Drawing.Point(106, 61)
        Me.CHKIgnorarFechaLogErrores.Name = "CHKIgnorarFechaLogErrores"
        Me.CHKIgnorarFechaLogErrores.Size = New System.Drawing.Size(154, 17)
        Me.CHKIgnorarFechaLogErrores.TabIndex = 12
        Me.CHKIgnorarFechaLogErrores.Text = "Ignorar fecha en búsqueda"
        Me.CHKIgnorarFechaLogErrores.UseVisualStyleBackColor = True
        '
        'CHKIgnorarTipoDeExcepcion
        '
        Me.CHKIgnorarTipoDeExcepcion.AutoSize = True
        Me.CHKIgnorarTipoDeExcepcion.Location = New System.Drawing.Point(450, 61)
        Me.CHKIgnorarTipoDeExcepcion.Name = "CHKIgnorarTipoDeExcepcion"
        Me.CHKIgnorarTipoDeExcepcion.Size = New System.Drawing.Size(144, 17)
        Me.CHKIgnorarTipoDeExcepcion.TabIndex = 13
        Me.CHKIgnorarTipoDeExcepcion.Text = "Ignorar tipo en búsqueda"
        Me.CHKIgnorarTipoDeExcepcion.UseVisualStyleBackColor = True
        '
        'DGVErrores
        '
        Me.DGVErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVErrores.Location = New System.Drawing.Point(49, 191)
        Me.DGVErrores.Name = "DGVErrores"
        Me.DGVErrores.Size = New System.Drawing.Size(929, 343)
        Me.DGVErrores.TabIndex = 14
        '
        'LogDeErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 606)
        Me.Controls.Add(Me.DGVErrores)
        Me.Controls.Add(Me.CHKIgnorarTipoDeExcepcion)
        Me.Controls.Add(Me.CHKIgnorarFechaLogErrores)
        Me.Controls.Add(Me.LBLClaseLogErrores)
        Me.Controls.Add(Me.LBLIdErrorLogDeErrores)
        Me.Controls.Add(Me.LBLQueryLogErrores)
        Me.Controls.Add(Me.LBLTipoExcepcionLogErrores)
        Me.Controls.Add(Me.LBLFechaLogErrores)
        Me.Controls.Add(Me.TXTIdError)
        Me.Controls.Add(Me.TXTClase)
        Me.Controls.Add(Me.TXTQuery)
        Me.Controls.Add(Me.CMBTipoExcepcion)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.BTNLimpiarLogDeErrores)
        Me.Controls.Add(Me.BTNFiltrarLogDeErrores)
        Me.Name = "LogDeErrores"
        Me.Text = "LogDeErrores"
        CType(Me.DGVErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNFiltrarLogDeErrores As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarLogDeErrores As System.Windows.Forms.Button
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBTipoExcepcion As System.Windows.Forms.ComboBox
    Friend WithEvents TXTQuery As System.Windows.Forms.TextBox
    Friend WithEvents TXTClase As System.Windows.Forms.TextBox
    Friend WithEvents TXTIdError As System.Windows.Forms.TextBox
    Friend WithEvents LBLFechaLogErrores As System.Windows.Forms.Label
    Friend WithEvents LBLTipoExcepcionLogErrores As System.Windows.Forms.Label
    Friend WithEvents LBLQueryLogErrores As System.Windows.Forms.Label
    Friend WithEvents LBLIdErrorLogDeErrores As System.Windows.Forms.Label
    Friend WithEvents LBLClaseLogErrores As System.Windows.Forms.Label
    Friend WithEvents CHKIgnorarFechaLogErrores As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIgnorarTipoDeExcepcion As System.Windows.Forms.CheckBox
    Friend WithEvents DGVErrores As System.Windows.Forms.DataGridView
End Class
