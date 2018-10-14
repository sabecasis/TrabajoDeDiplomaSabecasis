<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarStockFaltante
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
        Me.LSTDepositos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLPedidosDeReposicion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVPedidoDeStock = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVExistenciasFaltantes = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciclo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modoReposicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVPedidoDeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVExistenciasFaltantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSTDepositos
        '
        Me.LSTDepositos.FormattingEnabled = True
        Me.LSTDepositos.Location = New System.Drawing.Point(64, 97)
        Me.LSTDepositos.Name = "LSTDepositos"
        Me.LSTDepositos.Size = New System.Drawing.Size(206, 225)
        Me.LSTDepositos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Depositos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Stock en faltante por producto"
        '
        'LBLPedidosDeReposicion
        '
        Me.LBLPedidosDeReposicion.AutoSize = True
        Me.LBLPedidosDeReposicion.Location = New System.Drawing.Point(61, 384)
        Me.LBLPedidosDeReposicion.Name = "LBLPedidosDeReposicion"
        Me.LBLPedidosDeReposicion.Size = New System.Drawing.Size(111, 13)
        Me.LBLPedidosDeReposicion.TabIndex = 5
        Me.LBLPedidosDeReposicion.Text = "Pedidos de reposición"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ingresar Stock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVPedidoDeStock
        '
        Me.DGVPedidoDeStock.AllowUserToAddRows = False
        Me.DGVPedidoDeStock.AllowUserToDeleteRows = False
        Me.DGVPedidoDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPedidoDeStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.IngresoId})
        Me.DGVPedidoDeStock.Location = New System.Drawing.Point(64, 418)
        Me.DGVPedidoDeStock.Name = "DGVPedidoDeStock"
        Me.DGVPedidoDeStock.ReadOnly = True
        Me.DGVPedidoDeStock.Size = New System.Drawing.Size(1144, 117)
        Me.DGVPedidoDeStock.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Deposito ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Empleado ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'IngresoId
        '
        Me.IngresoId.HeaderText = "Ingreso ID"
        Me.IngresoId.Name = "IngresoId"
        Me.IngresoId.ReadOnly = True
        '
        'DGVExistenciasFaltantes
        '
        Me.DGVExistenciasFaltantes.AllowUserToAddRows = False
        Me.DGVExistenciasFaltantes.AllowUserToDeleteRows = False
        Me.DGVExistenciasFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExistenciasFaltantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Producto, Me.Cantidad, Me.MinStock, Me.maxStock, Me.ciclo, Me.modoReposicion})
        Me.DGVExistenciasFaltantes.Location = New System.Drawing.Point(320, 97)
        Me.DGVExistenciasFaltantes.Name = "DGVExistenciasFaltantes"
        Me.DGVExistenciasFaltantes.ReadOnly = True
        Me.DGVExistenciasFaltantes.Size = New System.Drawing.Size(752, 225)
        Me.DGVExistenciasFaltantes.TabIndex = 25
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
        'ConsultarStockFaltante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 741)
        Me.Controls.Add(Me.DGVExistenciasFaltantes)
        Me.Controls.Add(Me.DGVPedidoDeStock)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLPedidosDeReposicion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LSTDepositos)
        Me.Name = "ConsultarStockFaltante"
        Me.Text = "ConsultarStockFaltante"
        CType(Me.DGVPedidoDeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVExistenciasFaltantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LSTDepositos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLPedidosDeReposicion As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVPedidoDeStock As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngresoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVExistenciasFaltantes As System.Windows.Forms.DataGridView
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents maxStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ciclo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modoReposicion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
