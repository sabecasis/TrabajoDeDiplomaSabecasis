Imports StockModelo

Public Class ObtenerInstanciasDeProductoConFiltroAccion
	Implements Accion

    Public Sub New(prod As Producto, dep As Deposito, suc As Sucursal, fam As FamiliaDeProducto)
        Me.deposito = dep
        Me.producto = prod
        Me.sucursal = suc
        Me.familia = fam

    End Sub

    Property producto As Producto
    Property deposito As Deposito
    Property sucursal As Sucursal
    Property familia As FamiliaDeProducto

End Class
