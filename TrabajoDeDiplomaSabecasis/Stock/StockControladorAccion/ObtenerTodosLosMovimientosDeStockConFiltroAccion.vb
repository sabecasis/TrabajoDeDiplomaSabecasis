Imports StockModelo

Public Class ObtenerTodosLosMovimientosDeStockConFiltroAccion
	Implements Accion


    Public Sub New(prod As Producto, dep As Deposito, nroE As String, inst As Integer, fecha As Date, ingresado As Boolean)
        Me.producto = prod
        Me.deposito = dep
        Me.nroEmpleado = nroE
        Me.instancia_id = inst
        Me.fecha = fecha
        Me.ingresado = ingresado
    End Sub

    Public Sub New(prod As Producto, dep As Deposito, nroE As String, inst As Integer, fecha As Date)
        Me.producto = prod
        Me.deposito = dep
        Me.nroEmpleado = nroE
        Me.instancia_id = inst
        Me.fecha = fecha
    End Sub

    Property producto As Producto
    Property deposito As Deposito
    Property nroEmpleado As String
    Property instancia_id As Integer
    Property fecha As Date
    Property ingresado As Boolean = True


End Class
