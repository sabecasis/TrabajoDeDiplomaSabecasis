Imports StockModelo
Imports StockControladorAccion
Imports StockDatos

Public Class ObtenerTodosLosModulosCmd
    Inherits Comando(Of List(Of Modulo), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Modulo)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Modulo) = DaoFactory(Of Modulo).obtenerInstancia().crear(GetType(Modulo))
        Return dao.obtenerMuchos(Nothing)
    End Function
End Class
