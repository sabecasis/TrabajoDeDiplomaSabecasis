Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarUsuarioCmd
    Inherits Comando(Of String, EliminarUsuarioAccion)


    Public Overrides Function execute(accion As EliminarUsuarioAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
        Dim dao As AbstractDao(Of Usuario) = DaoFactory(Of Usuario).obtenerInstancia().crear(GetType(Usuario))
        Dim usuario As Usuario = New Usuario()
        usuario.id = accion.idUsuario
        dao.eliminar(usuario)
        Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_ELIMINADO_EXITOSAMENTE)
    End Function
End Class
