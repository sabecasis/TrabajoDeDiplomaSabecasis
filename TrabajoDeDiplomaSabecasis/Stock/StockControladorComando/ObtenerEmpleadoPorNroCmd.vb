Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerEmpleadoPorNroCmd
    Inherits Comando(Of Empleado, ObtenerEmpleadoPorNroAccion)


    Public Overrides Function execute(accion As ObtenerEmpleadoPorNroAccion) As Empleado
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
        Dim empleado As Empleado
        Dim criteria As GenericQueryCriteria = New GenericQueryCriteria()
        If Not accion Is Nothing And Not accion.nroEmpleado Is Nothing Then
            criteria.stringCriteria = accion.nroEmpleado
            empleado = dao.obtenerUno(criteria)
            Return empleado
        End If
        Return Nothing
    End Function
End Class
