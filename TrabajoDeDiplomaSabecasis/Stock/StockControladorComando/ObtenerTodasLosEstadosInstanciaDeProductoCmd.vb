Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodasLosEstadosInstanciaDeProductoCmd
    Inherits Comando(Of List(Of EstadoInstanciaProducto), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of EstadoInstanciaProducto)
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of EstadoInstanciaProducto) = DaoFactory(Of EstadoInstanciaProducto).obtenerInstancia().crear(GetType(EstadoInstanciaProducto))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
