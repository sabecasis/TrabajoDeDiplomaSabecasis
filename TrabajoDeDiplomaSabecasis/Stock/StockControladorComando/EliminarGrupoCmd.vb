Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarGrupoCmd
    Inherits Comando(Of String, EliminarGrupoAccion)


    Public Overrides Function execute(accion As EliminarGrupoAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
        Dim dao As AbstractDao(Of Usuario) = DaoFactory(Of Usuario).obtenerInstancia().crear(GetType(Usuario))
        Dim usuario As Usuario = New Usuario()
        usuario.id = accion.idGrupo
        dao.eliminar(usuario)
        Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.GRUPO_ELIMINADO_EXITOSAMENTE)
    End Function
End Class
