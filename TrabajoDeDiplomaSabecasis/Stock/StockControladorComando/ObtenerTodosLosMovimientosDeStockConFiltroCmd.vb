Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosMovimientosDeStockConFiltroCmd
    Inherits Comando(Of List(Of MovimientoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion)


    Public Overrides Function execute(accion As ObtenerTodosLosMovimientosDeStockConFiltroAccion) As List(Of MovimientoDeStock)
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of MovimientoDeStock) = DaoFactory(Of MovimientoDeStock).obtenerInstancia().crear(GetType(MovimientoDeStock))
            Dim criteria As New ConsultaMovimientosDeStockVariosQueryCriteria
            criteria.deposito = accion.deposito
            criteria.producto = accion.producto
            criteria.fecha = accion.fecha
            criteria.instanciaId = accion.instancia_id
            criteria.nroEmpleado = accion.nroEmpleado
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
