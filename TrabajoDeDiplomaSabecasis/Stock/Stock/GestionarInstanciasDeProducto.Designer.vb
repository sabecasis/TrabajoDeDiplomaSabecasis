<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarInstanciasDeProducto
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
        Me.DGVInstanciasDeProducto = New System.Windows.Forms.DataGridView()
        Me.CMBProducto = New System.Windows.Forms.ComboBox()
        Me.LBLProductoInstancia = New System.Windows.Forms.Label()
        Me.LBLDepositoInstancia = New System.Windows.Forms.Label()
        Me.CMBDeposito = New System.Windows.Forms.ComboBox()
        Me.LBLFamiliaDeProductoInstancia = New System.Windows.Forms.Label()
        Me.CMBFamiliaDeProducto = New System.Windows.Forms.ComboBox()
        Me.LBLSucursalInstancia = New System.Windows.Forms.Label()
        Me.CMBSucursal = New System.Windows.Forms.ComboBox()
        Me.CHKIgnorarProdInstancia = New System.Windows.Forms.CheckBox()
        Me.CHKIgnorarDepInstancia = New System.Windows.Forms.CheckBox()
        Me.CHKIgnorarFamiliaInstancia = New System.Windows.Forms.CheckBox()
        Me.CHKIgnorarSucursalInstancia = New System.Windows.Forms.CheckBox()
        Me.BTNLimpiarInstancias = New System.Windows.Forms.Button()
        Me.BTNFiltrarInstancias = New System.Windows.Forms.Button()
        CType(Me.DGVInstanciasDeProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVInstanciasDeProducto
        '
        Me.DGVInstanciasDeProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInstanciasDeProducto.Location = New System.Drawing.Point(46, 152)
        Me.DGVInstanciasDeProducto.Name = "DGVInstanciasDeProducto"
        Me.DGVInstanciasDeProducto.Size = New System.Drawing.Size(919, 294)
        Me.DGVInstanciasDeProducto.TabIndex = 0
        '
        'CMBProducto
        '
        Me.CMBProducto.FormattingEnabled = True
        Me.CMBProducto.Location = New System.Drawing.Point(141, 30)
        Me.CMBProducto.Name = "CMBProducto"
        Me.CMBProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBProducto.TabIndex = 1
        '
        'LBLProductoInstancia
        '
        Me.LBLProductoInstancia.AutoSize = True
        Me.LBLProductoInstancia.Location = New System.Drawing.Point(43, 33)
        Me.LBLProductoInstancia.Name = "LBLProductoInstancia"
        Me.LBLProductoInstancia.Size = New System.Drawing.Size(50, 13)
        Me.LBLProductoInstancia.TabIndex = 2
        Me.LBLProductoInstancia.Text = "Producto"
        '
        'LBLDepositoInstancia
        '
        Me.LBLDepositoInstancia.AutoSize = True
        Me.LBLDepositoInstancia.Location = New System.Drawing.Point(324, 33)
        Me.LBLDepositoInstancia.Name = "LBLDepositoInstancia"
        Me.LBLDepositoInstancia.Size = New System.Drawing.Size(49, 13)
        Me.LBLDepositoInstancia.TabIndex = 3
        Me.LBLDepositoInstancia.Text = "Deposito"
        '
        'CMBDeposito
        '
        Me.CMBDeposito.FormattingEnabled = True
        Me.CMBDeposito.Location = New System.Drawing.Point(441, 25)
        Me.CMBDeposito.Name = "CMBDeposito"
        Me.CMBDeposito.Size = New System.Drawing.Size(121, 21)
        Me.CMBDeposito.TabIndex = 4
        '
        'LBLFamiliaDeProductoInstancia
        '
        Me.LBLFamiliaDeProductoInstancia.AutoSize = True
        Me.LBLFamiliaDeProductoInstancia.Location = New System.Drawing.Point(656, 30)
        Me.LBLFamiliaDeProductoInstancia.Name = "LBLFamiliaDeProductoInstancia"
        Me.LBLFamiliaDeProductoInstancia.Size = New System.Drawing.Size(99, 13)
        Me.LBLFamiliaDeProductoInstancia.TabIndex = 5
        Me.LBLFamiliaDeProductoInstancia.Text = "Familia de producto"
        '
        'CMBFamiliaDeProducto
        '
        Me.CMBFamiliaDeProducto.FormattingEnabled = True
        Me.CMBFamiliaDeProducto.Location = New System.Drawing.Point(784, 23)
        Me.CMBFamiliaDeProducto.Name = "CMBFamiliaDeProducto"
        Me.CMBFamiliaDeProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBFamiliaDeProducto.TabIndex = 6
        '
        'LBLSucursalInstancia
        '
        Me.LBLSucursalInstancia.AutoSize = True
        Me.LBLSucursalInstancia.Location = New System.Drawing.Point(46, 100)
        Me.LBLSucursalInstancia.Name = "LBLSucursalInstancia"
        Me.LBLSucursalInstancia.Size = New System.Drawing.Size(48, 13)
        Me.LBLSucursalInstancia.TabIndex = 7
        Me.LBLSucursalInstancia.Text = "Sucursal"
        '
        'CMBSucursal
        '
        Me.CMBSucursal.FormattingEnabled = True
        Me.CMBSucursal.Location = New System.Drawing.Point(141, 91)
        Me.CMBSucursal.Name = "CMBSucursal"
        Me.CMBSucursal.Size = New System.Drawing.Size(121, 21)
        Me.CMBSucursal.TabIndex = 8
        '
        'CHKIgnorarProdInstancia
        '
        Me.CHKIgnorarProdInstancia.AutoSize = True
        Me.CHKIgnorarProdInstancia.Location = New System.Drawing.Point(141, 57)
        Me.CHKIgnorarProdInstancia.Name = "CHKIgnorarProdInstancia"
        Me.CHKIgnorarProdInstancia.Size = New System.Drawing.Size(104, 17)
        Me.CHKIgnorarProdInstancia.TabIndex = 9
        Me.CHKIgnorarProdInstancia.Text = "Ignorar producto"
        Me.CHKIgnorarProdInstancia.UseVisualStyleBackColor = True
        '
        'CHKIgnorarDepInstancia
        '
        Me.CHKIgnorarDepInstancia.AutoSize = True
        Me.CHKIgnorarDepInstancia.Location = New System.Drawing.Point(441, 52)
        Me.CHKIgnorarDepInstancia.Name = "CHKIgnorarDepInstancia"
        Me.CHKIgnorarDepInstancia.Size = New System.Drawing.Size(102, 17)
        Me.CHKIgnorarDepInstancia.TabIndex = 10
        Me.CHKIgnorarDepInstancia.Text = "Ignorar deposito"
        Me.CHKIgnorarDepInstancia.UseVisualStyleBackColor = True
        '
        'CHKIgnorarFamiliaInstancia
        '
        Me.CHKIgnorarFamiliaInstancia.AutoSize = True
        Me.CHKIgnorarFamiliaInstancia.Location = New System.Drawing.Point(784, 52)
        Me.CHKIgnorarFamiliaInstancia.Name = "CHKIgnorarFamiliaInstancia"
        Me.CHKIgnorarFamiliaInstancia.Size = New System.Drawing.Size(94, 17)
        Me.CHKIgnorarFamiliaInstancia.TabIndex = 11
        Me.CHKIgnorarFamiliaInstancia.Text = "Ignorar Familia"
        Me.CHKIgnorarFamiliaInstancia.UseVisualStyleBackColor = True
        '
        'CHKIgnorarSucursalInstancia
        '
        Me.CHKIgnorarSucursalInstancia.AutoSize = True
        Me.CHKIgnorarSucursalInstancia.Location = New System.Drawing.Point(141, 118)
        Me.CHKIgnorarSucursalInstancia.Name = "CHKIgnorarSucursalInstancia"
        Me.CHKIgnorarSucursalInstancia.Size = New System.Drawing.Size(101, 17)
        Me.CHKIgnorarSucursalInstancia.TabIndex = 12
        Me.CHKIgnorarSucursalInstancia.Text = "Ignorar sucursal"
        Me.CHKIgnorarSucursalInstancia.UseVisualStyleBackColor = True
        '
        'BTNLimpiarInstancias
        '
        Me.BTNLimpiarInstancias.Location = New System.Drawing.Point(371, 89)
        Me.BTNLimpiarInstancias.Name = "BTNLimpiarInstancias"
        Me.BTNLimpiarInstancias.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarInstancias.TabIndex = 13
        Me.BTNLimpiarInstancias.Text = "Limpiar"
        Me.BTNLimpiarInstancias.UseVisualStyleBackColor = True
        '
        'BTNFiltrarInstancias
        '
        Me.BTNFiltrarInstancias.Location = New System.Drawing.Point(528, 89)
        Me.BTNFiltrarInstancias.Name = "BTNFiltrarInstancias"
        Me.BTNFiltrarInstancias.Size = New System.Drawing.Size(75, 23)
        Me.BTNFiltrarInstancias.TabIndex = 14
        Me.BTNFiltrarInstancias.Text = "Filtrar"
        Me.BTNFiltrarInstancias.UseVisualStyleBackColor = True
        '
        'GestionarInstanciasDeProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 632)
        Me.Controls.Add(Me.BTNFiltrarInstancias)
        Me.Controls.Add(Me.BTNLimpiarInstancias)
        Me.Controls.Add(Me.CHKIgnorarSucursalInstancia)
        Me.Controls.Add(Me.CHKIgnorarFamiliaInstancia)
        Me.Controls.Add(Me.CHKIgnorarDepInstancia)
        Me.Controls.Add(Me.CHKIgnorarProdInstancia)
        Me.Controls.Add(Me.CMBSucursal)
        Me.Controls.Add(Me.LBLSucursalInstancia)
        Me.Controls.Add(Me.CMBFamiliaDeProducto)
        Me.Controls.Add(Me.LBLFamiliaDeProductoInstancia)
        Me.Controls.Add(Me.CMBDeposito)
        Me.Controls.Add(Me.LBLDepositoInstancia)
        Me.Controls.Add(Me.LBLProductoInstancia)
        Me.Controls.Add(Me.CMBProducto)
        Me.Controls.Add(Me.DGVInstanciasDeProducto)
        Me.Name = "GestionarInstanciasDeProducto"
        Me.Text = "GestionarInstanciasDeProducto"
        CType(Me.DGVInstanciasDeProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVInstanciasDeProducto As System.Windows.Forms.DataGridView
    Friend WithEvents CMBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLProductoInstancia As System.Windows.Forms.Label
    Friend WithEvents LBLDepositoInstancia As System.Windows.Forms.Label
    Friend WithEvents CMBDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents LBLFamiliaDeProductoInstancia As System.Windows.Forms.Label
    Friend WithEvents CMBFamiliaDeProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLSucursalInstancia As System.Windows.Forms.Label
    Friend WithEvents CMBSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents CHKIgnorarProdInstancia As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIgnorarDepInstancia As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIgnorarFamiliaInstancia As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIgnorarSucursalInstancia As System.Windows.Forms.CheckBox
    Friend WithEvents BTNLimpiarInstancias As System.Windows.Forms.Button
    Friend WithEvents BTNFiltrarInstancias As System.Windows.Forms.Button
End Class
