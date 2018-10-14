Imports StockModelo

Public Class EliminarEmpleadoAccion
    Implements Accion

    Public Sub New(idEmpleado As Integer)
        Me.idEmpleado = idEmpleado
    End Sub

    Property idEmpleado As Integer

End Class
