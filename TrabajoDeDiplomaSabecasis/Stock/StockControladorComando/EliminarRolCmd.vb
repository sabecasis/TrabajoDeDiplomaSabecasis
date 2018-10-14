Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarRolCmd
    Inherits Comando(Of String, EliminarRolAccion)


    Public Overrides Function execute(accion As EliminarRolAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
        Dim dao As AbstractDao(Of Rol) = DaoFactory(Of Rol).obtenerInstancia().crear(GetType(Rol))
        Dim rol As New Rol()
        rol.id = accion.idRol
        dao.eliminar(rol)
        Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ROL_ELIMINADO_CORRECTAMENTE)
    End Function
End Class
