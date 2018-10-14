Imports StockModelo
Imports StockControladorAccion
Imports StockDatos

Public Class ObtenerTodosLosEmpleadosCmd
    Inherits Comando(Of List(Of Empleado), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Empleado)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
        Return dao.obtenerMuchos(Nothing)
    End Function
End Class
