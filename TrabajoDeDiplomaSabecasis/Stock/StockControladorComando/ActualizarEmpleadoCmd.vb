Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class ActualizarEmpleadoCmd
    Inherits Comando(Of String, ActualizarEmpleadoAccion)


    Public Overrides Function execute(accion As ActualizarEmpleadoAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ACTUALIZAR)
        Dim dao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
        dao.actualizar(accion.oEmpleado)
        Dim mensaje As String = Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.EMPLEADO_ACTUALIZADO_CORRECTAMENTE)
        Return mensaje
    End Function
End Class
