Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class ObtenerEmpleadoPorNroODNICmd
    Inherits Comando(Of Empleado, ObtenerEmpleadoPorNroODNIAccion)


    Public Overrides Function execute(accion As ObtenerEmpleadoPorNroODNIAccion) As Empleado
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
        Dim criteria As GenericQueryCriteria = New GenericQueryCriteria
        Dim empleado As Empleado = Nothing
        If Not accion Is Nothing Then
            If Not "".Equals(accion.documento) Then
                Dim per As Persona = New Persona()
                per.documento = accion.documento
                criteria.oObject = per
                empleado = dao.obtenerUno(criteria)
            ElseIf Not "".Equals(accion.nroEmpleado) Then
                criteria.stringCriteria = accion.nroEmpleado
                empleado = dao.obtenerUno(criteria)
            End If
        End If
        Return empleado

    End Function
End Class
