Imports StockModelo

Public Class GuardarDescuentoAccion
    Implements Accion


    Public Sub New(id As Integer, nombre As String, descripcion As String, monto As Double, porcentaje As Double)
        Me.id = id
        Me.nombre = nombre
        Me.descripcion = descripcion
        Me.porcentaje = porcentaje
        Me.monto = monto
    End Sub

    Property id As Integer
    Property nombre As String
    Property descripcion As String
    Property monto As Double
    Property porcentaje As Double

End Class
