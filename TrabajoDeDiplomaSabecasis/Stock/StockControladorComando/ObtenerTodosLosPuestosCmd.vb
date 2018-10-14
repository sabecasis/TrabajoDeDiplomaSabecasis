Imports StockModelo
Imports StockDatos
Imports StockControladorAccion

Public Class ObtenerTodosLosPuestosCmd
    Inherits Comando(Of List(Of Puesto), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Puesto)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Puesto) = DaoFactory(Of Puesto).obtenerInstancia().crear(GetType(Puesto))
        Return dao.obtenerMuchos(Nothing)
    End Function
End Class
