<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarIdioma
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
        Me.LBLIdioma = New System.Windows.Forms.Label()
        Me.CMBCultura = New System.Windows.Forms.ComboBox()
        Me.DGVIdiomaElemento = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Texto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNGuardarIdioma = New System.Windows.Forms.Button()
        Me.LBLDescripcionIdioma = New System.Windows.Forms.Label()
        Me.TXTDescripcionIdioma = New System.Windows.Forms.TextBox()
        Me.LBLIdentificador = New System.Windows.Forms.Label()
        Me.TXTIdentificadorIdioma = New System.Windows.Forms.TextBox()
        Me.LBLErrorCrearIdioma = New System.Windows.Forms.Label()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        CType(Me.DGVIdiomaElemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLIdioma
        '
        Me.LBLIdioma.AutoSize = True
        Me.LBLIdioma.Location = New System.Drawing.Point(150, 83)
        Me.LBLIdioma.Name = "LBLIdioma"
        Me.LBLIdioma.Size = New System.Drawing.Size(38, 13)
        Me.LBLIdioma.TabIndex = 1
        Me.LBLIdioma.Text = "Idioma"
        '
        'CMBCultura
        '
        Me.CMBCultura.FormattingEnabled = True
        Me.CMBCultura.Location = New System.Drawing.Point(225, 80)
        Me.CMBCultura.Name = "CMBCultura"
        Me.CMBCultura.Size = New System.Drawing.Size(186, 21)
        Me.CMBCultura.TabIndex = 3
        '
        'DGVIdiomaElemento
        '
        Me.DGVIdiomaElemento.AllowUserToAddRows = False
        Me.DGVIdiomaElemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIdiomaElemento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Elemento, Me.Texto})
        Me.DGVIdiomaElemento.Location = New System.Drawing.Point(152, 156)
        Me.DGVIdiomaElemento.Name = "DGVIdiomaElemento"
        Me.DGVIdiomaElemento.Size = New System.Drawing.Size(430, 220)
        Me.DGVIdiomaElemento.TabIndex = 4
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'Elemento
        '
        Me.Elemento.DataPropertyName = "nombre"
        Me.Elemento.HeaderText = "Elemento"
        Me.Elemento.MinimumWidth = 100
        Me.Elemento.Name = "Elemento"
        Me.Elemento.ReadOnly = True
        '
        'Texto
        '
        Me.Texto.HeaderText = "Texto"
        Me.Texto.MinimumWidth = 100
        Me.Texto.Name = "Texto"
        '
        'BTNGuardarIdioma
        '
        Me.BTNGuardarIdioma.Location = New System.Drawing.Point(477, 69)
        Me.BTNGuardarIdioma.Name = "BTNGuardarIdioma"
        Me.BTNGuardarIdioma.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarIdioma.TabIndex = 5
        Me.BTNGuardarIdioma.Text = "Guardar"
        Me.BTNGuardarIdioma.UseVisualStyleBackColor = True
        '
        'LBLDescripcionIdioma
        '
        Me.LBLDescripcionIdioma.AutoSize = True
        Me.LBLDescripcionIdioma.Location = New System.Drawing.Point(150, 113)
        Me.LBLDescripcionIdioma.Name = "LBLDescripcionIdioma"
        Me.LBLDescripcionIdioma.Size = New System.Drawing.Size(63, 13)
        Me.LBLDescripcionIdioma.TabIndex = 6
        Me.LBLDescripcionIdioma.Text = "Descripción"
        '
        'TXTDescripcionIdioma
        '
        Me.TXTDescripcionIdioma.Location = New System.Drawing.Point(225, 106)
        Me.TXTDescripcionIdioma.Name = "TXTDescripcionIdioma"
        Me.TXTDescripcionIdioma.Size = New System.Drawing.Size(327, 20)
        Me.TXTDescripcionIdioma.TabIndex = 7
        '
        'LBLIdentificador
        '
        Me.LBLIdentificador.AutoSize = True
        Me.LBLIdentificador.Location = New System.Drawing.Point(151, 52)
        Me.LBLIdentificador.Name = "LBLIdentificador"
        Me.LBLIdentificador.Size = New System.Drawing.Size(65, 13)
        Me.LBLIdentificador.TabIndex = 8
        Me.LBLIdentificador.Text = "Identificador"
        '
        'TXTIdentificadorIdioma
        '
        Me.TXTIdentificadorIdioma.Location = New System.Drawing.Point(225, 52)
        Me.TXTIdentificadorIdioma.Name = "TXTIdentificadorIdioma"
        Me.TXTIdentificadorIdioma.ReadOnly = True
        Me.TXTIdentificadorIdioma.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdentificadorIdioma.TabIndex = 9
        '
        'LBLErrorCrearIdioma
        '
        Me.LBLErrorCrearIdioma.AutoSize = True
        Me.LBLErrorCrearIdioma.ForeColor = System.Drawing.Color.Red
        Me.LBLErrorCrearIdioma.Location = New System.Drawing.Point(152, 13)
        Me.LBLErrorCrearIdioma.Name = "LBLErrorCrearIdioma"
        Me.LBLErrorCrearIdioma.Size = New System.Drawing.Size(0, 13)
        Me.LBLErrorCrearIdioma.TabIndex = 10
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(558, 69)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminar.TabIndex = 11
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'GestionarIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 388)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.LBLErrorCrearIdioma)
        Me.Controls.Add(Me.TXTIdentificadorIdioma)
        Me.Controls.Add(Me.LBLIdentificador)
        Me.Controls.Add(Me.TXTDescripcionIdioma)
        Me.Controls.Add(Me.LBLDescripcionIdioma)
        Me.Controls.Add(Me.BTNGuardarIdioma)
        Me.Controls.Add(Me.DGVIdiomaElemento)
        Me.Controls.Add(Me.CMBCultura)
        Me.Controls.Add(Me.LBLIdioma)
        Me.Name = "GestionarIdioma"
        Me.Text = "Gestionar Idioma"
        CType(Me.DGVIdiomaElemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIdioma As System.Windows.Forms.Label
    Friend WithEvents CMBCultura As System.Windows.Forms.ComboBox
    Friend WithEvents DGVIdiomaElemento As System.Windows.Forms.DataGridView
    Friend WithEvents BTNGuardarIdioma As System.Windows.Forms.Button
    Friend WithEvents LBLDescripcionIdioma As System.Windows.Forms.Label
    Friend WithEvents TXTDescripcionIdioma As System.Windows.Forms.TextBox
    Friend WithEvents LBLIdentificador As System.Windows.Forms.Label
    Friend WithEvents TXTIdentificadorIdioma As System.Windows.Forms.TextBox
    Friend WithEvents LBLErrorCrearIdioma As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Elemento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Texto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
End Class
