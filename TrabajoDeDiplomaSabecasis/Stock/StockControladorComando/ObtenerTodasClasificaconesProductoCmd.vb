Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodasClasificaconesProductoCmd
    Inherits Comando(Of List(Of ClasificacionProducto), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of ClasificacionProducto)
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of ClasificacionProducto) = DaoFactory(Of ClasificacionProducto).obtenerInstancia().crear(GetType(ClasificacionProducto))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
