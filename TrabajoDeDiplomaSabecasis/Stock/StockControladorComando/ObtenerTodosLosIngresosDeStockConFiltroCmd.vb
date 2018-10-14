Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosIngresosDeStockConFiltroCmd
    Inherits Comando(Of List(Of IngresoDeStock), ObtenerTodosLosMovimientosDeStockConFiltroAccion)


    Public Overrides Function execute(accion As ObtenerTodosLosMovimientosDeStockConFiltroAccion) As List(Of IngresoDeStock)
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of IngresoDeStock) = DaoFactory(Of IngresoDeStock).obtenerInstancia().crear(GetType(IngresoDeStock))
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
