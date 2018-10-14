Imports StockModelo

Public Class ObtenerEmpleadoPorNroAccion
	Implements Accion

    Public Sub New(nroEmpleado As String)
        Me.nroEmpleado = nroEmpleado
    End Sub

    Property nroEmpleado As String

End Class
