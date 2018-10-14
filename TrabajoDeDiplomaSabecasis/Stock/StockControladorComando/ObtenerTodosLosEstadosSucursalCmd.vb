Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosEstadosSucursalCmd
    Inherits Comando(Of List(Of EstadoSucursal), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of EstadoSucursal)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of EstadoSucursal) = DaoFactory(Of EstadoSucursal).obtenerInstancia.crear(GetType(EstadoSucursal))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
