Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosPedidosNoIngresadosPorDepositoCmd
    Inherits Comando(Of List(Of PedidoDeStock), ObtenerTodosLosPedidosNoIngresadosPorDepositoAccion)


    Public Overrides Function execute(accion As ObtenerTodosLosPedidosNoIngresadosPorDepositoAccion) As List(Of PedidoDeStock)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
            Dim listaFinal As New List(Of PedidoDeStock)
            For Each dep In accion.deposito
                Dim criteria As New GenericQueryCriteria
                criteria.integerCriteria = dep.id
                listaFinal.AddRange(dao.obtenerMuchos(criteria))
            Next
            Return listaFinal
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
