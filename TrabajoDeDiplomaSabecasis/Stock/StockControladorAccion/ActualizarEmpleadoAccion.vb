Imports StockModelo

Public Class ActualizarEmpleadoAccion
    Implements Accion

    Public Sub New(empleado As Empleado)
        Me.oEmpleado = empleado
    End Sub

    Property oEmpleado As Empleado
End Class
