<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarStockPorProducto
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
        Me.DGVExistencias = New System.Windows.Forms.DataGridView()
        Me.LBLProductoListaProductos = New System.Windows.Forms.Label()
        Me.LBLDepositoListaProductos = New System.Windows.Forms.Label()
        Me.BTNFiltrarListaProductos = New System.Windows.Forms.Button()
        Me.BTNLimpiarFiltroProductos = New System.Windows.Forms.Button()
        Me.TXTProducto = New System.Windows.Forms.TextBox()
        Me.TXTDeposito = New System.Windows.Forms.TextBox()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciclo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modoReposicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVExistencias
        '
        Me.DGVExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Producto, Me.Cantidad, Me.MinStock, Me.maxStock, Me.ciclo, Me.modoReposicion})
        Me.DGVExistencias.Location = New System.Drawing.Point(43, 145)
        Me.DGVExistencias.Name = "DGVExistencias"
        Me.DGVExistencias.Size = New System.Drawing.Size(752, 382)
        Me.DGVExistencias.TabIndex = 0
        '
        'LBLProductoListaProductos
        '
        Me.LBLProductoListaProductos.AutoSize = True
        Me.LBLProductoListaProductos.Location = New System.Drawing.Point(90, 54)
        Me.LBLProductoListaProductos.Name = "LBLProductoListaProductos"
        Me.LBLProductoListaProductos.Size = New System.Drawing.Size(62, 13)
        Me.LBLProductoListaProductos.TabIndex = 3
        Me.LBLProductoListaProductos.Text = "Producto Id"
        '
        'LBLDepositoListaProductos
        '
        Me.LBLDepositoListaProductos.AutoSize = True
        Me.LBLDepositoListaProductos.Location = New System.Drawing.Point(494, 50)
        Me.LBLDepositoListaProductos.Name = "LBLDepositoListaProductos"
        Me.LBLDepositoListaProductos.Size = New System.Drawing.Size(61, 13)
        Me.LBLDepositoListaProductos.TabIndex = 4
        Me.LBLDepositoListaProductos.Text = "Deposito Id"
        '
        'BTNFiltrarListaProductos
        '
        Me.BTNFiltrarListaProductos.Location = New System.Drawing.Point(835, 31)
        Me.BTNFiltrarListaProductos.Name = "BTNFiltrarListaProductos"
        Me.BTNFiltrarListaProductos.Size = New System.Drawing.Size(75, 23)
        Me.BTNFiltrarListaProductos.TabIndex = 5
        Me.BTNFiltrarListaProductos.Text = "Filtrar"
        Me.BTNFiltrarListaProductos.UseVisualStyleBackColor = True
        '
        'BTNLimpiarFiltroProductos
        '
        Me.BTNLimpiarFiltroProductos.Location = New System.Drawing.Point(835, 74)
        Me.BTNLimpiarFiltroProductos.Name = "BTNLimpiarFiltroProductos"
        Me.BTNLimpiarFiltroProductos.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiarFiltroProductos.TabIndex = 6
        Me.BTNLimpiarFiltroProductos.Text = "Limpiar"
        Me.BTNLimpiarFiltroProductos.UseVisualStyleBackColor = True
        '
        'TXTProducto
        '
        Me.TXTProducto.Location = New System.Drawing.Point(182, 47)
        Me.TXTProducto.Name = "TXTProducto"
        Me.TXTProducto.Size = New System.Drawing.Size(149, 20)
        Me.TXTProducto.TabIndex = 7
        Me.TXTProducto.Text = "0"
        '
        'TXTDeposito
        '
        Me.TXTDeposito.Location = New System.Drawing.Point(589, 43)
        Me.TXTDeposito.Name = "TXTDeposito"
        Me.TXTDeposito.Size = New System.Drawing.Size(152, 20)
        Me.TXTDeposito.TabIndex = 8
        Me.TXTDeposito.Text = "0"
        '
        'IdProducto
        '
        Me.IdProducto.DataPropertyName = "idProducto"
        Me.IdProducto.HeaderText = "Id Producto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'MinStock
        '
        Me.MinStock.DataPropertyName = "minStock"
        Me.MinStock.HeaderText = "Punto mínimo de reposición"
        Me.MinStock.Name = "MinStock"
        Me.MinStock.ReadOnly = True
        '
        'maxStock
        '
        Me.maxStock.DataPropertyName = "maxStock"
        Me.maxStock.HeaderText = "Punto máximo de reposición"
        Me.maxStock.Name = "maxStock"
        Me.maxStock.ReadOnly = True
        '
        'ciclo
        '
        Me.ciclo.DataPropertyName = "ciclo"
        Me.ciclo.HeaderText = "Ciclo de reposición"
        Me.ciclo.Name = "ciclo"
        Me.ciclo.ReadOnly = True
        '
        'modoReposicion
        '
        Me.modoReposicion.DataPropertyName = "modoReposicion"
        Me.modoReposicion.HeaderText = "Modo de reposición"
        Me.modoReposicion.Name = "modoReposicion"
        Me.modoReposicion.ReadOnly = True
        '
        'ConsultarStockPorProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 528)
        Me.Controls.Add(Me.TXTDeposito)
        Me.Controls.Add(Me.TXTProducto)
        Me.Controls.Add(Me.BTNLimpiarFiltroProductos)
        Me.Controls.Add(Me.BTNFiltrarListaProductos)
        Me.Controls.Add(Me.LBLDepositoListaProductos)
        Me.Controls.Add(Me.LBLProductoListaProductos)
        Me.Controls.Add(Me.DGVExistencias)
        Me.Name = "ConsultarStockPorProducto"
        Me.Text = "ConsultarStockPorProducto"
        CType(Me.DGVExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVExistencias As System.Windows.Forms.DataGridView
    Friend WithEvents LBLProductoListaProductos As System.Windows.Forms.Label
    Friend WithEvents LBLDepositoListaProductos As System.Windows.Forms.Label
    Friend WithEvents BTNFiltrarListaProductos As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiarFiltroProductos As System.Windows.Forms.Button
    Friend WithEvents TXTProducto As System.Windows.Forms.TextBox
    Friend WithEvents TXTDeposito As System.Windows.Forms.TextBox
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents maxStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ciclo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modoReposicion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
