Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosIngresosPorPedidoDeStockCmd
    Inherits Comando(Of List(Of IngresoDeStock), ObtenerTodosLosIngresosPorPedidoDeStockAccion)

    Public Overrides Function execute(accion As ObtenerTodosLosIngresosPorPedidoDeStockAccion) As List(Of IngresoDeStock)
        Try
            Dim oAutorizador As Autorizador = Autorizador.obtenerInstancia()
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            oAutorizador.autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of IngresoDeStock) = DaoFactory(Of IngresoDeStock).obtenerInstancia().crear(GetType(IngresoDeStock))
            Dim criteria As New PedidoDeStockQueryCriteria
            criteria.idPedidoDeStock = accion.idPedidoDeStock
            Dim listaIngresos As List(Of IngresoDeStock) = dao.obtenerMuchos(criteria)
            Return listaIngresos
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.Name, accion.GetType.Name)
        End Try
    End Function
End Class
