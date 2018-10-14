Imports StockModelo
Imports StockControladorAccion
Imports StockDatos

Public Class ObtenerTodosLosPermisosCmd
    Inherits Comando(Of List(Of Permiso), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Permiso)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Permiso) = DaoFactory(Of Permiso).obtenerInstancia().crear(GetType(Permiso))
        Return dao.obtenerMuchos(Nothing)
    End Function
End Class
