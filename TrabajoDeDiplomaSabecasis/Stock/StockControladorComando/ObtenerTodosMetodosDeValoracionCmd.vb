Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosMetodosDeValoracionCmd
    Inherits Comando(Of List(Of ModoValoracionProducto), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of ModoValoracionProducto)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of ModoValoracionProducto) = DaoFactory(Of ModoValoracionProducto).obtenerInstancia().crear(GetType(ModoValoracionProducto))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
