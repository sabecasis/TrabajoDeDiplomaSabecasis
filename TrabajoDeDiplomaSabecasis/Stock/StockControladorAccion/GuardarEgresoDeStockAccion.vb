Imports StockModelo

Public Class GuardarEgresoDeStockAccion
    Implements Accion

    Public Sub New(id As Integer, motivo As String, fecha As Date, cantidad As Integer, producto As Producto, deposito As Deposito, listaInsProd As List(Of InstanciaDeProducto), empleado As Empleado)
        Me.egresoDeStock = New EgresoDeStock
        Me.egresoDeStock.id = id
        Me.egresoDeStock.motivo = motivo
        Me.egresoDeStock.fecha = fecha
        Me.egresoDeStock.cantidad = cantidad
        Me.egresoDeStock.producto = producto
        Me.egresoDeStock.deposito = deposito
        Me.egresoDeStock.listaInstanciasDeProducto = listaInsProd
        Me.egresoDeStock.empleado = empleado
    End Sub

    Property egresoDeStock As EgresoDeStock

End Class
