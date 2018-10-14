Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class BuscarRolCmd
    Inherits Comando(Of Rol, BuscarRolAccion)

    Public Overrides Function execute(accion As BuscarRolAccion) As Rol
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Rol) = DaoFactory(Of Rol).obtenerInstancia().crear(GetType(Rol))
        Dim queryCriteria As GenericQueryCriteria = New GenericQueryCriteria
        queryCriteria.stringCriteria = accion.nombre
        Dim oRol As Rol = dao.obtenerUno(queryCriteria)
        If Not oRol Is Nothing Then
            If Not oRol.grupos Is Nothing Then
                For Each oGrupo As Grupo In oRol.grupos
                    oGrupo.nombre = Criptografia.ObtenerInstancia().DecypherTripleDES(oGrupo.nombre, Sesion.obtenerInstancia().DESSEED, True)
                Next
            End If

        End If

        Return oRol
    End Function
End Class
