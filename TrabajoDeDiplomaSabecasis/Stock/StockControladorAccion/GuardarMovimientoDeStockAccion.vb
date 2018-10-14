Imports StockModelo

Public Class GuardarMovimientoDeStockAccion
	Implements Accion

    Public Sub New(id As Integer, motivo As String, cantidad As Integer, fecha As Date, producto As Producto, depositoOrigen As Deposito, depositoDestino As Deposito, instanciasDeProducto As List(Of InstanciaDeProducto), fechaAceptacion As Date)
        Me.oMovimiento = New MovimientoDeStock
        Me.oMovimiento.id = id
        Me.oMovimiento.motivo = motivo
        Me.oMovimiento.cantidad = cantidad
        Me.oMovimiento.fecha = fecha
        Me.oMovimiento.producto = producto
        Me.oMovimiento.depositoDestino = depositoDestino
        Me.oMovimiento.depositoOrigen = depositoOrigen
        Me.oMovimiento.listaInstancias = instanciasDeProducto
        Me.oMovimiento.fechaAceptacion = fechaAceptacion
    End Sub
    Property oMovimiento As MovimientoDeStock
End Class
