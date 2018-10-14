<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarProducto
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
        Me.TXTIdProd = New System.Windows.Forms.TextBox()
        Me.TXTNombre = New System.Windows.Forms.TextBox()
        Me.TXTDescr = New System.Windows.Forms.TextBox()
        Me.TXTPrecioCompra = New System.Windows.Forms.TextBox()
        Me.TXTPrecioVenta = New System.Windows.Forms.TextBox()
        Me.CMBMoneda = New System.Windows.Forms.ComboBox()
        Me.CMBEstadoProducto = New System.Windows.Forms.ComboBox()
        Me.LBLIdProducto = New System.Windows.Forms.Label()
        Me.LBLNombrePrducto = New System.Windows.Forms.Label()
        Me.LBLDescripcion = New System.Windows.Forms.Label()
        Me.LBLPrecioCompraProd = New System.Windows.Forms.Label()
        Me.LBLPrecioVentaProd = New System.Windows.Forms.Label()
        Me.LBLMonedaProducto = New System.Windows.Forms.Label()
        Me.LBLEstadoProducto = New System.Windows.Forms.Label()
        Me.LBLMarcaProd = New System.Windows.Forms.Label()
        Me.CMBMarca = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNGestionarMonedas = New System.Windows.Forms.Button()
        Me.LSTProvNoAsig = New System.Windows.Forms.ListBox()
        Me.LSTProvAsig = New System.Windows.Forms.ListBox()
        Me.LBLProveedoresNoAsg = New System.Windows.Forms.Label()
        Me.LBLProveedoresAsg = New System.Windows.Forms.Label()
        Me.BTNAsignar = New System.Windows.Forms.Button()
        Me.BTNDesasignar = New System.Windows.Forms.Button()
        Me.LBLCantidadEnsStock = New System.Windows.Forms.Label()
        Me.TXTCantStock = New System.Windows.Forms.TextBox()
        Me.BTNLimpiar = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNBuscar = New System.Windows.Forms.Button()
        Me.CMBDescGlobal = New System.Windows.Forms.ComboBox()
        Me.LBLDescGlobal = New System.Windows.Forms.Label()
        Me.LBLMensaje = New System.Windows.Forms.Label()
        Me.CMBClasificProd = New System.Windows.Forms.ComboBox()
        Me.LBLClasificacionProd = New System.Windows.Forms.Label()
        Me.LBLReglaComposicion = New System.Windows.Forms.Label()
        Me.TXTReglaDeComp = New System.Windows.Forms.TextBox()
        Me.BTNAgregarProdARegla = New System.Windows.Forms.Button()
        Me.LBLListaDeMatPri = New System.Windows.Forms.Label()
        Me.LBLPorcentajeGananciaProd = New System.Windows.Forms.Label()
        Me.TXTporcentajeDeGanancia = New System.Windows.Forms.TextBox()
        Me.LBLModoValoracion = New System.Windows.Forms.Label()
        Me.CMBMetodoValoracion = New System.Windows.Forms.ComboBox()
        Me.LBLPRecioCosteAdq = New System.Windows.Forms.Label()
        Me.TXTPrecioDeAdquisicion = New System.Windows.Forms.TextBox()
        Me.TXTCostePosecion = New System.Windows.Forms.TextBox()
        Me.LBLCosteRep = New System.Windows.Forms.Label()
        Me.TXTCosteFinanciero = New System.Windows.Forms.TextBox()
        Me.LBLCosteFinanciero = New System.Windows.Forms.Label()
        Me.LSTMateriasAsignadas = New System.Windows.Forms.ListBox()
        Me.LBLCostoEstandar = New System.Windows.Forms.Label()
        Me.TXTCostoEstandar = New System.Windows.Forms.TextBox()
        Me.LBLPrecioUltimaCompra = New System.Windows.Forms.Label()
        Me.TXTPrecioUltimaCompra = New System.Windows.Forms.TextBox()
        Me.CMBMEtodoDeReposicion = New System.Windows.Forms.ComboBox()
        Me.LBLMetodoReposicionProducto = New System.Windows.Forms.Label()
        Me.LBLPuntoMinimoReposicion = New System.Windows.Forms.Label()
        Me.LBLPuntoMaximoReposicion = New System.Windows.Forms.Label()
        Me.TXTPuntoMinReposicion = New System.Windows.Forms.TextBox()
        Me.TXTPuntoMaxReposicion = New System.Windows.Forms.TextBox()
        Me.TXTClicloDeReposicion = New System.Windows.Forms.TextBox()
        Me.LBLCicloReposicionProducto = New System.Windows.Forms.Label()
        Me.BTNCrearFamiliaDeProducto = New System.Windows.Forms.Button()
        Me.LBLFmiliaDeProductoProd = New System.Windows.Forms.Label()
        Me.CMBFamilia = New System.Windows.Forms.ComboBox()
        Me.CHKFamilia = New System.Windows.Forms.CheckBox()
        Me.TXTUnidad = New System.Windows.Forms.TextBox()
        Me.LBLUnidadProducto = New System.Windows.Forms.Label()
        Me.CHKPedidoAutomatico = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TXTIdProd
        '
        Me.TXTIdProd.Location = New System.Drawing.Point(236, 25)
        Me.TXTIdProd.Name = "TXTIdProd"
        Me.TXTIdProd.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdProd.TabIndex = 0
        Me.TXTIdProd.Text = "0"
        '
        'TXTNombre
        '
        Me.TXTNombre.Location = New System.Drawing.Point(236, 51)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombre.TabIndex = 1
        '
        'TXTDescr
        '
        Me.TXTDescr.Location = New System.Drawing.Point(236, 77)
        Me.TXTDescr.Name = "TXTDescr"
        Me.TXTDescr.Size = New System.Drawing.Size(277, 20)
        Me.TXTDescr.TabIndex = 2
        '
        'TXTPrecioCompra
        '
        Me.TXTPrecioCompra.Location = New System.Drawing.Point(236, 101)
        Me.TXTPrecioCompra.Name = "TXTPrecioCompra"
        Me.TXTPrecioCompra.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrecioCompra.TabIndex = 3
        Me.TXTPrecioCompra.Text = "0"
        '
        'TXTPrecioVenta
        '
        Me.TXTPrecioVenta.Location = New System.Drawing.Point(236, 149)
        Me.TXTPrecioVenta.Name = "TXTPrecioVenta"
        Me.TXTPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrecioVenta.TabIndex = 4
        Me.TXTPrecioVenta.Text = "0"
        '
        'CMBMoneda
        '
        Me.CMBMoneda.FormattingEnabled = True
        Me.CMBMoneda.Location = New System.Drawing.Point(236, 201)
        Me.CMBMoneda.Name = "CMBMoneda"
        Me.CMBMoneda.Size = New System.Drawing.Size(121, 21)
        Me.CMBMoneda.TabIndex = 5
        '
        'CMBEstadoProducto
        '
        Me.CMBEstadoProducto.FormattingEnabled = True
        Me.CMBEstadoProducto.Location = New System.Drawing.Point(236, 228)
        Me.CMBEstadoProducto.Name = "CMBEstadoProducto"
        Me.CMBEstadoProducto.Size = New System.Drawing.Size(121, 21)
        Me.CMBEstadoProducto.TabIndex = 6
        '
        'LBLIdProducto
        '
        Me.LBLIdProducto.AutoSize = True
        Me.LBLIdProducto.Location = New System.Drawing.Point(69, 28)
        Me.LBLIdProducto.Name = "LBLIdProducto"
        Me.LBLIdProducto.Size = New System.Drawing.Size(61, 13)
        Me.LBLIdProducto.TabIndex = 7
        Me.LBLIdProducto.Text = "Id producto"
        '
        'LBLNombrePrducto
        '
        Me.LBLNombrePrducto.AutoSize = True
        Me.LBLNombrePrducto.Location = New System.Drawing.Point(69, 51)
        Me.LBLNombrePrducto.Name = "LBLNombrePrducto"
        Me.LBLNombrePrducto.Size = New System.Drawing.Size(44, 13)
        Me.LBLNombrePrducto.TabIndex = 8
        Me.LBLNombrePrducto.Text = "Nombre"
        '
        'LBLDescripcion
        '
        Me.LBLDescripcion.AutoSize = True
        Me.LBLDescripcion.Location = New System.Drawing.Point(69, 77)
        Me.LBLDescripcion.Name = "LBLDescripcion"
        Me.LBLDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LBLDescripcion.TabIndex = 9
        Me.LBLDescripcion.Text = "Descripción"
        '
        'LBLPrecioCompraProd
        '
        Me.LBLPrecioCompraProd.AutoSize = True
        Me.LBLPrecioCompraProd.Location = New System.Drawing.Point(69, 101)
        Me.LBLPrecioCompraProd.Name = "LBLPrecioCompraProd"
        Me.LBLPrecioCompraProd.Size = New System.Drawing.Size(75, 13)
        Me.LBLPrecioCompraProd.TabIndex = 10
        Me.LBLPrecioCompraProd.Text = "Precio compra"
        '
        'LBLPrecioVentaProd
        '
        Me.LBLPrecioVentaProd.AutoSize = True
        Me.LBLPrecioVentaProd.Location = New System.Drawing.Point(69, 149)
        Me.LBLPrecioVentaProd.Name = "LBLPrecioVentaProd"
        Me.LBLPrecioVentaProd.Size = New System.Drawing.Size(67, 13)
        Me.LBLPrecioVentaProd.TabIndex = 11
        Me.LBLPrecioVentaProd.Text = "Precio venta"
        '
        'LBLMonedaProducto
        '
        Me.LBLMonedaProducto.AutoSize = True
        Me.LBLMonedaProducto.Location = New System.Drawing.Point(69, 201)
        Me.LBLMonedaProducto.Name = "LBLMonedaProducto"
        Me.LBLMonedaProducto.Size = New System.Drawing.Size(46, 13)
        Me.LBLMonedaProducto.TabIndex = 12
        Me.LBLMonedaProducto.Text = "Moneda"
        '
        'LBLEstadoProducto
        '
        Me.LBLEstadoProducto.AutoSize = True
        Me.LBLEstadoProducto.Location = New System.Drawing.Point(69, 228)
        Me.LBLEstadoProducto.Name = "LBLEstadoProducto"
        Me.LBLEstadoProducto.Size = New System.Drawing.Size(40, 13)
        Me.LBLEstadoProducto.TabIndex = 13
        Me.LBLEstadoProducto.Text = "Estado"
        '
        'LBLMarcaProd
        '
        Me.LBLMarcaProd.AutoSize = True
        Me.LBLMarcaProd.Location = New System.Drawing.Point(69, 258)
        Me.LBLMarcaProd.Name = "LBLMarcaProd"
        Me.LBLMarcaProd.Size = New System.Drawing.Size(37, 13)
        Me.LBLMarcaProd.TabIndex = 15
        Me.LBLMarcaProd.Text = "Marca"
        '
        'CMBMarca
        '
        Me.CMBMarca.FormattingEnabled = True
        Me.CMBMarca.Location = New System.Drawing.Point(236, 258)
        Me.CMBMarca.Name = "CMBMarca"
        Me.CMBMarca.Size = New System.Drawing.Size(121, 21)
        Me.CMBMarca.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(383, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Gestionar marcas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNGestionarMonedas
        '
        Me.BTNGestionarMonedas.Location = New System.Drawing.Point(383, 200)
        Me.BTNGestionarMonedas.Name = "BTNGestionarMonedas"
        Me.BTNGestionarMonedas.Size = New System.Drawing.Size(130, 23)
        Me.BTNGestionarMonedas.TabIndex = 19
        Me.BTNGestionarMonedas.Text = "Gestionar monedas"
        Me.BTNGestionarMonedas.UseVisualStyleBackColor = True
        '
        'LSTProvNoAsig
        '
        Me.LSTProvNoAsig.FormattingEnabled = True
        Me.LSTProvNoAsig.Location = New System.Drawing.Point(72, 323)
        Me.LSTProvNoAsig.Name = "LSTProvNoAsig"
        Me.LSTProvNoAsig.Size = New System.Drawing.Size(185, 160)
        Me.LSTProvNoAsig.TabIndex = 20
        '
        'LSTProvAsig
        '
        Me.LSTProvAsig.FormattingEnabled = True
        Me.LSTProvAsig.Location = New System.Drawing.Point(328, 323)
        Me.LSTProvAsig.Name = "LSTProvAsig"
        Me.LSTProvAsig.Size = New System.Drawing.Size(185, 160)
        Me.LSTProvAsig.TabIndex = 21
        '
        'LBLProveedoresNoAsg
        '
        Me.LBLProveedoresNoAsg.AutoSize = True
        Me.LBLProveedoresNoAsg.Location = New System.Drawing.Point(76, 297)
        Me.LBLProveedoresNoAsg.Name = "LBLProveedoresNoAsg"
        Me.LBLProveedoresNoAsg.Size = New System.Drawing.Size(133, 13)
        Me.LBLProveedoresNoAsg.TabIndex = 22
        Me.LBLProveedoresNoAsg.Text = "Proveedores no asignados"
        '
        'LBLProveedoresAsg
        '
        Me.LBLProveedoresAsg.AutoSize = True
        Me.LBLProveedoresAsg.Location = New System.Drawing.Point(336, 297)
        Me.LBLProveedoresAsg.Name = "LBLProveedoresAsg"
        Me.LBLProveedoresAsg.Size = New System.Drawing.Size(118, 13)
        Me.LBLProveedoresAsg.TabIndex = 23
        Me.LBLProveedoresAsg.Text = "Proveedores asignados"
        '
        'BTNAsignar
        '
        Me.BTNAsignar.Location = New System.Drawing.Point(263, 350)
        Me.BTNAsignar.Name = "BTNAsignar"
        Me.BTNAsignar.Size = New System.Drawing.Size(59, 23)
        Me.BTNAsignar.TabIndex = 24
        Me.BTNAsignar.Text = ">>"
        Me.BTNAsignar.UseVisualStyleBackColor = True
        '
        'BTNDesasignar
        '
        Me.BTNDesasignar.Location = New System.Drawing.Point(263, 379)
        Me.BTNDesasignar.Name = "BTNDesasignar"
        Me.BTNDesasignar.Size = New System.Drawing.Size(59, 23)
        Me.BTNDesasignar.TabIndex = 25
        Me.BTNDesasignar.Text = "<<"
        Me.BTNDesasignar.UseVisualStyleBackColor = True
        '
        'LBLCantidadEnsStock
        '
        Me.LBLCantidadEnsStock.AutoSize = True
        Me.LBLCantidadEnsStock.Location = New System.Drawing.Point(605, 70)
        Me.LBLCantidadEnsStock.Name = "LBLCantidadEnsStock"
        Me.LBLCantidadEnsStock.Size = New System.Drawing.Size(171, 13)
        Me.LBLCantidadEnsStock.TabIndex = 26
        Me.LBLCantidadEnsStock.Text = "Cantidad en stock toda la empresa"
        '
        'TXTCantStock
        '
        Me.TXTCantStock.Location = New System.Drawing.Point(819, 66)
        Me.TXTCantStock.Name = "TXTCantStock"
        Me.TXTCantStock.ReadOnly = True
        Me.TXTCantStock.Size = New System.Drawing.Size(100, 20)
        Me.TXTCantStock.TabIndex = 27
        Me.TXTCantStock.Text = "0"
        '
        'BTNLimpiar
        '
        Me.BTNLimpiar.Location = New System.Drawing.Point(72, 650)
        Me.BTNLimpiar.Name = "BTNLimpiar"
        Me.BTNLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiar.TabIndex = 28
        Me.BTNLimpiar.Text = "Limpiar"
        Me.BTNLimpiar.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Location = New System.Drawing.Point(195, 650)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 29
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(72, 693)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminar.TabIndex = 30
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BTNBuscar
        '
        Me.BTNBuscar.Location = New System.Drawing.Point(195, 693)
        Me.BTNBuscar.Name = "BTNBuscar"
        Me.BTNBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscar.TabIndex = 31
        Me.BTNBuscar.Text = "Buscar"
        Me.BTNBuscar.UseVisualStyleBackColor = True
        '
        'CMBDescGlobal
        '
        Me.CMBDescGlobal.FormattingEnabled = True
        Me.CMBDescGlobal.Location = New System.Drawing.Point(819, 119)
        Me.CMBDescGlobal.Name = "CMBDescGlobal"
        Me.CMBDescGlobal.Size = New System.Drawing.Size(160, 21)
        Me.CMBDescGlobal.TabIndex = 32
        '
        'LBLDescGlobal
        '
        Me.LBLDescGlobal.AutoSize = True
        Me.LBLDescGlobal.Location = New System.Drawing.Point(605, 125)
        Me.LBLDescGlobal.Name = "LBLDescGlobal"
        Me.LBLDescGlobal.Size = New System.Drawing.Size(90, 13)
        Me.LBLDescGlobal.TabIndex = 33
        Me.LBLDescGlobal.Text = "Descuento global"
        '
        'LBLMensaje
        '
        Me.LBLMensaje.AutoSize = True
        Me.LBLMensaje.ForeColor = System.Drawing.Color.Red
        Me.LBLMensaje.Location = New System.Drawing.Point(605, 9)
        Me.LBLMensaje.Name = "LBLMensaje"
        Me.LBLMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensaje.TabIndex = 36
        '
        'CMBClasificProd
        '
        Me.CMBClasificProd.FormattingEnabled = True
        Me.CMBClasificProd.Location = New System.Drawing.Point(819, 162)
        Me.CMBClasificProd.Name = "CMBClasificProd"
        Me.CMBClasificProd.Size = New System.Drawing.Size(121, 21)
        Me.CMBClasificProd.TabIndex = 39
        '
        'LBLClasificacionProd
        '
        Me.LBLClasificacionProd.AutoSize = True
        Me.LBLClasificacionProd.Location = New System.Drawing.Point(608, 165)
        Me.LBLClasificacionProd.Name = "LBLClasificacionProd"
        Me.LBLClasificacionProd.Size = New System.Drawing.Size(126, 13)
        Me.LBLClasificacionProd.TabIndex = 38
        Me.LBLClasificacionProd.Text = "Clasificacion de producto"
        '
        'LBLReglaComposicion
        '
        Me.LBLReglaComposicion.AutoSize = True
        Me.LBLReglaComposicion.Location = New System.Drawing.Point(611, 210)
        Me.LBLReglaComposicion.Name = "LBLReglaComposicion"
        Me.LBLReglaComposicion.Size = New System.Drawing.Size(112, 13)
        Me.LBLReglaComposicion.TabIndex = 40
        Me.LBLReglaComposicion.Text = "Regla de composición"
        '
        'TXTReglaDeComp
        '
        Me.TXTReglaDeComp.Location = New System.Drawing.Point(819, 202)
        Me.TXTReglaDeComp.Name = "TXTReglaDeComp"
        Me.TXTReglaDeComp.Size = New System.Drawing.Size(160, 20)
        Me.TXTReglaDeComp.TabIndex = 41
        '
        'BTNAgregarProdARegla
        '
        Me.BTNAgregarProdARegla.Location = New System.Drawing.Point(608, 247)
        Me.BTNAgregarProdARegla.Name = "BTNAgregarProdARegla"
        Me.BTNAgregarProdARegla.Size = New System.Drawing.Size(178, 23)
        Me.BTNAgregarProdARegla.TabIndex = 42
        Me.BTNAgregarProdARegla.Text = "Agregar producto a regla"
        Me.BTNAgregarProdARegla.UseVisualStyleBackColor = True
        '
        'LBLListaDeMatPri
        '
        Me.LBLListaDeMatPri.AutoSize = True
        Me.LBLListaDeMatPri.Location = New System.Drawing.Point(816, 247)
        Me.LBLListaDeMatPri.Name = "LBLListaDeMatPri"
        Me.LBLListaDeMatPri.Size = New System.Drawing.Size(215, 13)
        Me.LBLListaDeMatPri.TabIndex = 44
        Me.LBLListaDeMatPri.Text = "Lista de materias primas para asignar a regla"
        '
        'LBLPorcentajeGananciaProd
        '
        Me.LBLPorcentajeGananciaProd.AutoSize = True
        Me.LBLPorcentajeGananciaProd.Location = New System.Drawing.Point(611, 422)
        Me.LBLPorcentajeGananciaProd.Name = "LBLPorcentajeGananciaProd"
        Me.LBLPorcentajeGananciaProd.Size = New System.Drawing.Size(120, 13)
        Me.LBLPorcentajeGananciaProd.TabIndex = 45
        Me.LBLPorcentajeGananciaProd.Text = "Porcentaje de ganancia"
        '
        'TXTporcentajeDeGanancia
        '
        Me.TXTporcentajeDeGanancia.Location = New System.Drawing.Point(819, 415)
        Me.TXTporcentajeDeGanancia.Name = "TXTporcentajeDeGanancia"
        Me.TXTporcentajeDeGanancia.Size = New System.Drawing.Size(100, 20)
        Me.TXTporcentajeDeGanancia.TabIndex = 46
        Me.TXTporcentajeDeGanancia.Text = "0"
        '
        'LBLModoValoracion
        '
        Me.LBLModoValoracion.AutoSize = True
        Me.LBLModoValoracion.Location = New System.Drawing.Point(72, 513)
        Me.LBLModoValoracion.Name = "LBLModoValoracion"
        Me.LBLModoValoracion.Size = New System.Drawing.Size(110, 13)
        Me.LBLModoValoracion.TabIndex = 47
        Me.LBLModoValoracion.Text = "Metodo de valoración"
        '
        'CMBMetodoValoracion
        '
        Me.CMBMetodoValoracion.FormattingEnabled = True
        Me.CMBMetodoValoracion.Location = New System.Drawing.Point(215, 505)
        Me.CMBMetodoValoracion.Name = "CMBMetodoValoracion"
        Me.CMBMetodoValoracion.Size = New System.Drawing.Size(298, 21)
        Me.CMBMetodoValoracion.TabIndex = 48
        '
        'LBLPRecioCosteAdq
        '
        Me.LBLPRecioCosteAdq.AutoSize = True
        Me.LBLPRecioCosteAdq.Location = New System.Drawing.Point(611, 448)
        Me.LBLPRecioCosteAdq.Name = "LBLPRecioCosteAdq"
        Me.LBLPRecioCosteAdq.Size = New System.Drawing.Size(152, 13)
        Me.LBLPRecioCosteAdq.TabIndex = 49
        Me.LBLPRecioCosteAdq.Text = "Precio de coste de adquisición"
        '
        'TXTPrecioDeAdquisicion
        '
        Me.TXTPrecioDeAdquisicion.Location = New System.Drawing.Point(819, 441)
        Me.TXTPrecioDeAdquisicion.Name = "TXTPrecioDeAdquisicion"
        Me.TXTPrecioDeAdquisicion.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrecioDeAdquisicion.TabIndex = 50
        Me.TXTPrecioDeAdquisicion.Text = "0"
        '
        'TXTCostePosecion
        '
        Me.TXTCostePosecion.Location = New System.Drawing.Point(819, 468)
        Me.TXTCostePosecion.Name = "TXTCostePosecion"
        Me.TXTCostePosecion.Size = New System.Drawing.Size(100, 20)
        Me.TXTCostePosecion.TabIndex = 52
        Me.TXTCostePosecion.Text = "0"
        '
        'LBLCosteRep
        '
        Me.LBLCosteRep.AutoSize = True
        Me.LBLCosteRep.Location = New System.Drawing.Point(611, 475)
        Me.LBLCosteRep.Name = "LBLCosteRep"
        Me.LBLCosteRep.Size = New System.Drawing.Size(93, 13)
        Me.LBLCosteRep.TabIndex = 51
        Me.LBLCosteRep.Text = "coste de posesión"
        '
        'TXTCosteFinanciero
        '
        Me.TXTCosteFinanciero.Location = New System.Drawing.Point(819, 494)
        Me.TXTCosteFinanciero.Name = "TXTCosteFinanciero"
        Me.TXTCosteFinanciero.Size = New System.Drawing.Size(100, 20)
        Me.TXTCosteFinanciero.TabIndex = 54
        Me.TXTCosteFinanciero.Text = "0"
        '
        'LBLCosteFinanciero
        '
        Me.LBLCosteFinanciero.AutoSize = True
        Me.LBLCosteFinanciero.Location = New System.Drawing.Point(611, 501)
        Me.LBLCosteFinanciero.Name = "LBLCosteFinanciero"
        Me.LBLCosteFinanciero.Size = New System.Drawing.Size(83, 13)
        Me.LBLCosteFinanciero.TabIndex = 53
        Me.LBLCosteFinanciero.Text = "Coste financiero"
        '
        'LSTMateriasAsignadas
        '
        Me.LSTMateriasAsignadas.FormattingEnabled = True
        Me.LSTMateriasAsignadas.Location = New System.Drawing.Point(819, 281)
        Me.LSTMateriasAsignadas.Name = "LSTMateriasAsignadas"
        Me.LSTMateriasAsignadas.Size = New System.Drawing.Size(185, 121)
        Me.LSTMateriasAsignadas.TabIndex = 55
        '
        'LBLCostoEstandar
        '
        Me.LBLCostoEstandar.AutoSize = True
        Me.LBLCostoEstandar.Location = New System.Drawing.Point(69, 175)
        Me.LBLCostoEstandar.Name = "LBLCostoEstandar"
        Me.LBLCostoEstandar.Size = New System.Drawing.Size(78, 13)
        Me.LBLCostoEstandar.TabIndex = 57
        Me.LBLCostoEstandar.Text = "Costo estandar"
        '
        'TXTCostoEstandar
        '
        Me.TXTCostoEstandar.Location = New System.Drawing.Point(236, 175)
        Me.TXTCostoEstandar.Name = "TXTCostoEstandar"
        Me.TXTCostoEstandar.Size = New System.Drawing.Size(100, 20)
        Me.TXTCostoEstandar.TabIndex = 56
        Me.TXTCostoEstandar.Text = "0"
        '
        'LBLPrecioUltimaCompra
        '
        Me.LBLPrecioUltimaCompra.AutoSize = True
        Me.LBLPrecioUltimaCompra.Location = New System.Drawing.Point(69, 125)
        Me.LBLPrecioUltimaCompra.Name = "LBLPrecioUltimaCompra"
        Me.LBLPrecioUltimaCompra.Size = New System.Drawing.Size(120, 13)
        Me.LBLPrecioUltimaCompra.TabIndex = 59
        Me.LBLPrecioUltimaCompra.Text = "Precio de última compra"
        '
        'TXTPrecioUltimaCompra
        '
        Me.TXTPrecioUltimaCompra.Location = New System.Drawing.Point(236, 125)
        Me.TXTPrecioUltimaCompra.Name = "TXTPrecioUltimaCompra"
        Me.TXTPrecioUltimaCompra.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrecioUltimaCompra.TabIndex = 60
        Me.TXTPrecioUltimaCompra.Text = "0"
        '
        'CMBMEtodoDeReposicion
        '
        Me.CMBMEtodoDeReposicion.FormattingEnabled = True
        Me.CMBMEtodoDeReposicion.Location = New System.Drawing.Point(215, 547)
        Me.CMBMEtodoDeReposicion.Name = "CMBMEtodoDeReposicion"
        Me.CMBMEtodoDeReposicion.Size = New System.Drawing.Size(298, 21)
        Me.CMBMEtodoDeReposicion.TabIndex = 62
        '
        'LBLMetodoReposicionProducto
        '
        Me.LBLMetodoReposicionProducto.AutoSize = True
        Me.LBLMetodoReposicionProducto.Location = New System.Drawing.Point(72, 551)
        Me.LBLMetodoReposicionProducto.Name = "LBLMetodoReposicionProducto"
        Me.LBLMetodoReposicionProducto.Size = New System.Drawing.Size(109, 13)
        Me.LBLMetodoReposicionProducto.TabIndex = 61
        Me.LBLMetodoReposicionProducto.Text = "Metodo de reposición"
        '
        'LBLPuntoMinimoReposicion
        '
        Me.LBLPuntoMinimoReposicion.AutoSize = True
        Me.LBLPuntoMinimoReposicion.Location = New System.Drawing.Point(74, 582)
        Me.LBLPuntoMinimoReposicion.Name = "LBLPuntoMinimoReposicion"
        Me.LBLPuntoMinimoReposicion.Size = New System.Drawing.Size(111, 13)
        Me.LBLPuntoMinimoReposicion.TabIndex = 63
        Me.LBLPuntoMinimoReposicion.Text = "Punto Min Reposición"
        '
        'LBLPuntoMaximoReposicion
        '
        Me.LBLPuntoMaximoReposicion.AutoSize = True
        Me.LBLPuntoMaximoReposicion.Location = New System.Drawing.Point(74, 609)
        Me.LBLPuntoMaximoReposicion.Name = "LBLPuntoMaximoReposicion"
        Me.LBLPuntoMaximoReposicion.Size = New System.Drawing.Size(114, 13)
        Me.LBLPuntoMaximoReposicion.TabIndex = 64
        Me.LBLPuntoMaximoReposicion.Text = "Punto Max Reposición"
        '
        'TXTPuntoMinReposicion
        '
        Me.TXTPuntoMinReposicion.Location = New System.Drawing.Point(282, 579)
        Me.TXTPuntoMinReposicion.Name = "TXTPuntoMinReposicion"
        Me.TXTPuntoMinReposicion.Size = New System.Drawing.Size(75, 20)
        Me.TXTPuntoMinReposicion.TabIndex = 65
        Me.TXTPuntoMinReposicion.Text = "0"
        '
        'TXTPuntoMaxReposicion
        '
        Me.TXTPuntoMaxReposicion.Location = New System.Drawing.Point(282, 605)
        Me.TXTPuntoMaxReposicion.Name = "TXTPuntoMaxReposicion"
        Me.TXTPuntoMaxReposicion.Size = New System.Drawing.Size(75, 20)
        Me.TXTPuntoMaxReposicion.TabIndex = 66
        Me.TXTPuntoMaxReposicion.Text = "0"
        '
        'TXTClicloDeReposicion
        '
        Me.TXTClicloDeReposicion.Location = New System.Drawing.Point(629, 602)
        Me.TXTClicloDeReposicion.Name = "TXTClicloDeReposicion"
        Me.TXTClicloDeReposicion.Size = New System.Drawing.Size(75, 20)
        Me.TXTClicloDeReposicion.TabIndex = 68
        Me.TXTClicloDeReposicion.Text = "0"
        '
        'LBLCicloReposicionProducto
        '
        Me.LBLCicloReposicionProducto.AutoSize = True
        Me.LBLCicloReposicionProducto.Location = New System.Drawing.Point(421, 606)
        Me.LBLCicloReposicionProducto.Name = "LBLCicloReposicionProducto"
        Me.LBLCicloReposicionProducto.Size = New System.Drawing.Size(142, 13)
        Me.LBLCicloReposicionProducto.TabIndex = 67
        Me.LBLCicloReposicionProducto.Text = "Ciclo de reposición (En días)"
        '
        'BTNCrearFamiliaDeProducto
        '
        Me.BTNCrearFamiliaDeProducto.Location = New System.Drawing.Point(406, 650)
        Me.BTNCrearFamiliaDeProducto.Name = "BTNCrearFamiliaDeProducto"
        Me.BTNCrearFamiliaDeProducto.Size = New System.Drawing.Size(298, 24)
        Me.BTNCrearFamiliaDeProducto.TabIndex = 69
        Me.BTNCrearFamiliaDeProducto.Text = "Crear Familia de productos"
        Me.BTNCrearFamiliaDeProducto.UseVisualStyleBackColor = True
        '
        'LBLFmiliaDeProductoProd
        '
        Me.LBLFmiliaDeProductoProd.AutoSize = True
        Me.LBLFmiliaDeProductoProd.Location = New System.Drawing.Point(611, 526)
        Me.LBLFmiliaDeProductoProd.Name = "LBLFmiliaDeProductoProd"
        Me.LBLFmiliaDeProductoProd.Size = New System.Drawing.Size(102, 13)
        Me.LBLFmiliaDeProductoProd.TabIndex = 70
        Me.LBLFmiliaDeProductoProd.Text = "Familia De Producto"
        '
        'CMBFamilia
        '
        Me.CMBFamilia.FormattingEnabled = True
        Me.CMBFamilia.Location = New System.Drawing.Point(819, 523)
        Me.CMBFamilia.Name = "CMBFamilia"
        Me.CMBFamilia.Size = New System.Drawing.Size(121, 21)
        Me.CMBFamilia.TabIndex = 71
        '
        'CHKFamilia
        '
        Me.CHKFamilia.AutoSize = True
        Me.CHKFamilia.Location = New System.Drawing.Point(819, 588)
        Me.CHKFamilia.Name = "CHKFamilia"
        Me.CHKFamilia.Size = New System.Drawing.Size(153, 17)
        Me.CHKFamilia.TabIndex = 72
        Me.CHKFamilia.Text = "No pertenece a una familia"
        Me.CHKFamilia.UseVisualStyleBackColor = True
        '
        'TXTUnidad
        '
        Me.TXTUnidad.Location = New System.Drawing.Point(819, 551)
        Me.TXTUnidad.Name = "TXTUnidad"
        Me.TXTUnidad.Size = New System.Drawing.Size(100, 20)
        Me.TXTUnidad.TabIndex = 74
        '
        'LBLUnidadProducto
        '
        Me.LBLUnidadProducto.AutoSize = True
        Me.LBLUnidadProducto.Location = New System.Drawing.Point(613, 556)
        Me.LBLUnidadProducto.Name = "LBLUnidadProducto"
        Me.LBLUnidadProducto.Size = New System.Drawing.Size(41, 13)
        Me.LBLUnidadProducto.TabIndex = 73
        Me.LBLUnidadProducto.Text = "Unidad"
        '
        'CHKPedidoAutomatico
        '
        Me.CHKPedidoAutomatico.AutoSize = True
        Me.CHKPedidoAutomatico.Location = New System.Drawing.Point(424, 577)
        Me.CHKPedidoAutomatico.Name = "CHKPedidoAutomatico"
        Me.CHKPedidoAutomatico.Size = New System.Drawing.Size(115, 17)
        Me.CHKPedidoAutomatico.TabIndex = 75
        Me.CHKPedidoAutomatico.Text = "Pedido Automático"
        Me.CHKPedidoAutomatico.UseVisualStyleBackColor = True
        '
        'GestionarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 733)
        Me.Controls.Add(Me.CHKPedidoAutomatico)
        Me.Controls.Add(Me.TXTUnidad)
        Me.Controls.Add(Me.LBLUnidadProducto)
        Me.Controls.Add(Me.CHKFamilia)
        Me.Controls.Add(Me.CMBFamilia)
        Me.Controls.Add(Me.LBLFmiliaDeProductoProd)
        Me.Controls.Add(Me.BTNCrearFamiliaDeProducto)
        Me.Controls.Add(Me.TXTClicloDeReposicion)
        Me.Controls.Add(Me.LBLCicloReposicionProducto)
        Me.Controls.Add(Me.TXTPuntoMaxReposicion)
        Me.Controls.Add(Me.TXTPuntoMinReposicion)
        Me.Controls.Add(Me.LBLPuntoMaximoReposicion)
        Me.Controls.Add(Me.LBLPuntoMinimoReposicion)
        Me.Controls.Add(Me.CMBMEtodoDeReposicion)
        Me.Controls.Add(Me.LBLMetodoReposicionProducto)
        Me.Controls.Add(Me.TXTPrecioUltimaCompra)
        Me.Controls.Add(Me.LBLPrecioUltimaCompra)
        Me.Controls.Add(Me.LBLCostoEstandar)
        Me.Controls.Add(Me.TXTCostoEstandar)
        Me.Controls.Add(Me.LSTMateriasAsignadas)
        Me.Controls.Add(Me.TXTCosteFinanciero)
        Me.Controls.Add(Me.LBLCosteFinanciero)
        Me.Controls.Add(Me.TXTCostePosecion)
        Me.Controls.Add(Me.LBLCosteRep)
        Me.Controls.Add(Me.TXTPrecioDeAdquisicion)
        Me.Controls.Add(Me.LBLPRecioCosteAdq)
        Me.Controls.Add(Me.CMBMetodoValoracion)
        Me.Controls.Add(Me.LBLModoValoracion)
        Me.Controls.Add(Me.TXTporcentajeDeGanancia)
        Me.Controls.Add(Me.LBLPorcentajeGananciaProd)
        Me.Controls.Add(Me.LBLListaDeMatPri)
        Me.Controls.Add(Me.BTNAgregarProdARegla)
        Me.Controls.Add(Me.TXTReglaDeComp)
        Me.Controls.Add(Me.LBLReglaComposicion)
        Me.Controls.Add(Me.CMBClasificProd)
        Me.Controls.Add(Me.LBLClasificacionProd)
        Me.Controls.Add(Me.LBLMensaje)
        Me.Controls.Add(Me.LBLDescGlobal)
        Me.Controls.Add(Me.CMBDescGlobal)
        Me.Controls.Add(Me.BTNBuscar)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.BTNGuardar)
        Me.Controls.Add(Me.BTNLimpiar)
        Me.Controls.Add(Me.TXTCantStock)
        Me.Controls.Add(Me.LBLCantidadEnsStock)
        Me.Controls.Add(Me.BTNDesasignar)
        Me.Controls.Add(Me.BTNAsignar)
        Me.Controls.Add(Me.LBLProveedoresAsg)
        Me.Controls.Add(Me.LBLProveedoresNoAsg)
        Me.Controls.Add(Me.LSTProvAsig)
        Me.Controls.Add(Me.LSTProvNoAsig)
        Me.Controls.Add(Me.BTNGestionarMonedas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CMBMarca)
        Me.Controls.Add(Me.LBLMarcaProd)
        Me.Controls.Add(Me.LBLEstadoProducto)
        Me.Controls.Add(Me.LBLMonedaProducto)
        Me.Controls.Add(Me.LBLPrecioVentaProd)
        Me.Controls.Add(Me.LBLPrecioCompraProd)
        Me.Controls.Add(Me.LBLDescripcion)
        Me.Controls.Add(Me.LBLNombrePrducto)
        Me.Controls.Add(Me.LBLIdProducto)
        Me.Controls.Add(Me.CMBEstadoProducto)
        Me.Controls.Add(Me.CMBMoneda)
        Me.Controls.Add(Me.TXTPrecioVenta)
        Me.Controls.Add(Me.TXTPrecioCompra)
        Me.Controls.Add(Me.TXTDescr)
        Me.Controls.Add(Me.TXTNombre)
        Me.Controls.Add(Me.TXTIdProd)
        Me.Name = "GestionarProducto"
        Me.Text = "GestionarProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTIdProd As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombre As System.Windows.Forms.TextBox
    Friend WithEvents TXTDescr As System.Windows.Forms.TextBox
    Friend WithEvents TXTPrecioCompra As System.Windows.Forms.TextBox
    Friend WithEvents TXTPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents CMBMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents CMBEstadoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LBLIdProducto As System.Windows.Forms.Label
    Friend WithEvents LBLNombrePrducto As System.Windows.Forms.Label
    Friend WithEvents LBLDescripcion As System.Windows.Forms.Label
    Friend WithEvents LBLPrecioCompraProd As System.Windows.Forms.Label
    Friend WithEvents LBLPrecioVentaProd As System.Windows.Forms.Label
    Friend WithEvents LBLMonedaProducto As System.Windows.Forms.Label
    Friend WithEvents LBLEstadoProducto As System.Windows.Forms.Label
    Friend WithEvents LBLMarcaProd As System.Windows.Forms.Label
    Friend WithEvents CMBMarca As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNGestionarMonedas As System.Windows.Forms.Button
    Friend WithEvents LSTProvNoAsig As System.Windows.Forms.ListBox
    Friend WithEvents LSTProvAsig As System.Windows.Forms.ListBox
    Friend WithEvents LBLProveedoresNoAsg As System.Windows.Forms.Label
    Friend WithEvents LBLProveedoresAsg As System.Windows.Forms.Label
    Friend WithEvents BTNAsignar As System.Windows.Forms.Button
    Friend WithEvents BTNDesasignar As System.Windows.Forms.Button
    Friend WithEvents LBLCantidadEnsStock As System.Windows.Forms.Label
    Friend WithEvents TXTCantStock As System.Windows.Forms.TextBox
    Friend WithEvents BTNLimpiar As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents BTNBuscar As System.Windows.Forms.Button
    Friend WithEvents CMBDescGlobal As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDescGlobal As System.Windows.Forms.Label
    Friend WithEvents LBLMensaje As System.Windows.Forms.Label
    Friend WithEvents CMBClasificProd As System.Windows.Forms.ComboBox
    Friend WithEvents LBLClasificacionProd As System.Windows.Forms.Label
    Friend WithEvents LBLReglaComposicion As System.Windows.Forms.Label
    Friend WithEvents TXTReglaDeComp As System.Windows.Forms.TextBox
    Friend WithEvents BTNAgregarProdARegla As System.Windows.Forms.Button
    Friend WithEvents LBLListaDeMatPri As System.Windows.Forms.Label
    Friend WithEvents LBLPorcentajeGananciaProd As System.Windows.Forms.Label
    Friend WithEvents TXTporcentajeDeGanancia As System.Windows.Forms.TextBox
    Friend WithEvents LBLModoValoracion As System.Windows.Forms.Label
    Friend WithEvents CMBMetodoValoracion As System.Windows.Forms.ComboBox
    Friend WithEvents LBLPRecioCosteAdq As System.Windows.Forms.Label
    Friend WithEvents TXTPrecioDeAdquisicion As System.Windows.Forms.TextBox
    Friend WithEvents TXTCostePosecion As System.Windows.Forms.TextBox
    Friend WithEvents LBLCosteRep As System.Windows.Forms.Label
    Friend WithEvents TXTCosteFinanciero As System.Windows.Forms.TextBox
    Friend WithEvents LBLCosteFinanciero As System.Windows.Forms.Label
    Friend WithEvents LSTMateriasAsignadas As System.Windows.Forms.ListBox
    Friend WithEvents LBLCostoEstandar As System.Windows.Forms.Label
    Friend WithEvents TXTCostoEstandar As System.Windows.Forms.TextBox
    Friend WithEvents LBLPrecioUltimaCompra As System.Windows.Forms.Label
    Friend WithEvents TXTPrecioUltimaCompra As System.Windows.Forms.TextBox
    Friend WithEvents CMBMEtodoDeReposicion As System.Windows.Forms.ComboBox
    Friend WithEvents LBLMetodoReposicionProducto As System.Windows.Forms.Label
    Friend WithEvents LBLPuntoMinimoReposicion As System.Windows.Forms.Label
    Friend WithEvents LBLPuntoMaximoReposicion As System.Windows.Forms.Label
    Friend WithEvents TXTPuntoMinReposicion As System.Windows.Forms.TextBox
    Friend WithEvents TXTPuntoMaxReposicion As System.Windows.Forms.TextBox
    Friend WithEvents TXTClicloDeReposicion As System.Windows.Forms.TextBox
    Friend WithEvents LBLCicloReposicionProducto As System.Windows.Forms.Label
    Friend WithEvents BTNCrearFamiliaDeProducto As System.Windows.Forms.Button
    Friend WithEvents LBLFmiliaDeProductoProd As System.Windows.Forms.Label
    Friend WithEvents CMBFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents CHKFamilia As System.Windows.Forms.CheckBox
    Friend WithEvents TXTUnidad As System.Windows.Forms.TextBox
    Friend WithEvents LBLUnidadProducto As System.Windows.Forms.Label
    Friend WithEvents CHKPedidoAutomatico As System.Windows.Forms.CheckBox
End Class
