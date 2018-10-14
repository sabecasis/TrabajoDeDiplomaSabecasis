Imports StockModelo
Imports StockDatos
Imports StockControladorAccion

Public Class ObtenerProximoNroEmpleadoCmd
    Inherits Comando(Of String, ObtenerProximoNroEmpleadoAccion)


    Public Overrides Function execute(accion As ObtenerProximoNroEmpleadoAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As EmpleadosDao = New EmpleadosDao()
        Dim nroEmpleado As String
        nroEmpleado = dao.obtenerProximoNroEmpleado(accion.idPuesto)
        Return nroEmpleado
    End Function
End Class
