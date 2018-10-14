Imports StockModelo

Public Class ObtenerEmpleadoPorNroODNIAccion
	Implements Accion

    Public Sub New(documento As String, nroEmpleado As String)
        Me.documento = documento
        Me.nroEmpleado = nroEmpleado
    End Sub

    Property nroEmpleado As String
    Property documento As String

End Class
