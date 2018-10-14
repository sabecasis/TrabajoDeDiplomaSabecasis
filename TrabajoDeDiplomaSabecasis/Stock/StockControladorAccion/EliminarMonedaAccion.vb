Imports StockModelo

Public Class EliminarMonedaAccion
    Implements Accion

    Public Sub New(pid As Integer)
        Me.id = pid
    End Sub
    Property id As Integer
End Class
