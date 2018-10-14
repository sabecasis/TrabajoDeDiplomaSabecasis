Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class ObtenerTodasLasFamiliasDeProductoCmd
    Inherits Comando(Of List(Of FamiliaDeProducto), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of FamiliaDeProducto)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of FamiliaDeProducto) = DaoFactory(Of FamiliaDeProducto).obtenerInstancia.crear(GetType(FamiliaDeProducto))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
