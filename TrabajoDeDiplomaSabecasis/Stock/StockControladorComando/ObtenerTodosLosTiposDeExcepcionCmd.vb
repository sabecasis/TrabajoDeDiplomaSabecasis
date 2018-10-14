Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosTiposDeExcepcionCmd
    Inherits Comando(Of List(Of TipoDeExcepcion), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of TipoDeExcepcion)
        Try
            Dim dao As AbstractDao(Of TipoDeExcepcion) = DaoFactory(Of TipoDeExcepcion).obtenerInstancia.crear(GetType(TipoDeExcepcion))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
