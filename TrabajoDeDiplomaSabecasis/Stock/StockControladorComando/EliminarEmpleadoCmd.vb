Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarEmpleadoCmd
    Inherits Comando(Of String, EliminarEmpleadoAccion)


    Public Overrides Function execute(accion As EliminarEmpleadoAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
        Dim dao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
        Dim empleado As Empleado = New Empleado()
        empleado.id = accion.idEmpleado
        dao.eliminar(empleado)
        Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.EMPLEADO_ELIMINADO_CORRECTAMENTE)
    End Function
End Class
