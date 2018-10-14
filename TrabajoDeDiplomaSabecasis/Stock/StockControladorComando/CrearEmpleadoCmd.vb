Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class CrearEmpleadoCmd
    Inherits Comando(Of String, CrearEmpleadoAccion)

    Public Overrides Function execute(accion As CrearEmpleadoAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
        Dim dao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
        Dim esExitoso As Boolean
        esExitoso = dao.guardar(accion.empleado)
        If esExitoso Then
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.EMPLEADO_CREADO_CON_EXITO) & " id " & accion.empleado.id
        Else
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_CREAR_EMPLEADO)
        End If
    End Function
End Class
