Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosMovimientosDeStockNoAceptadosCmd
    Inherits Comando(Of List(Of MovimientoDeStock), ObtenerTodosLosMovimientosDeStockNoAceptadosAccion)

    Public Overrides Function execute(accion As ObtenerTodosLosMovimientosDeStockNoAceptadosAccion) As List(Of MovimientoDeStock)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of MovimientoDeStock) = DaoFactory(Of MovimientoDeStock).obtenerInstancia().crear(GetType(MovimientoDeStock))
            Dim listaFinal As New List(Of MovimientoDeStock)
            For Each dep In accion.depositos
                Dim criteria As New MovimientoDeStockQueryCriteria
                criteria.deposito_id = dep.id
                listaFinal.AddRange(dao.obtenerMuchos(criteria))
            Next
            Return listaFinal
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
