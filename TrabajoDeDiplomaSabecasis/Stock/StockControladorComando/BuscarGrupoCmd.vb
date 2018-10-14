Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class BuscarGrupoCmd
    Inherits Comando(Of Grupo, BuscarGrupoAccion)

    Public Overrides Function execute(accion As BuscarGrupoAccion) As Grupo
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Grupo) = DaoFactory(Of Grupo).obtenerInstancia().crear(GetType(Grupo))
        Dim queryCritera As GenericQueryCriteria = New GenericQueryCriteria()
        queryCritera.stringCriteria = Criptografia.ObtenerInstancia().CypherTripleDES(accion.grupo, Sesion.obtenerInstancia().DESSEED, True)
        Dim oGrupo As Grupo = dao.obtenerUno(queryCritera)
        If Not oGrupo Is Nothing Then
            oGrupo.nombre = Criptografia.ObtenerInstancia().DecypherTripleDES(oGrupo.nombre, Sesion.obtenerInstancia().DESSEED, True)
            If Not oGrupo.elementos Is Nothing Then
                For Each elemento As ElementoDeSeguridad In oGrupo.elementos
                    elemento.nombre = Criptografia.ObtenerInstancia().DecypherTripleDES(elemento.nombre, Sesion.obtenerInstancia().DESSEED, True)
                Next
            End If
        End If
        Return oGrupo
    End Function
End Class
