Imports StockModelo
Imports StockDatos
Imports StockControladorAccion

Public Class ObtenerTodosLosPaisesCmd
    Inherits Comando(Of List(Of Pais), ObtenerTodosAccion)



    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Pais)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Pais) = DaoFactory(Of Pais).obtenerInstancia().crear(GetType(Pais))
        Return dao.obtenerMuchos(Nothing)
    End Function
End Class
