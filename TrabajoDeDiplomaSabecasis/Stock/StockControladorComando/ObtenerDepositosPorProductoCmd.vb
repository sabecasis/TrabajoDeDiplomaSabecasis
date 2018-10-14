Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerDepositosPorProductoCmd
    Inherits Comando(Of List(Of Deposito), ObtenerDepositosPorProductoAccion)


    Public Overrides Function execute(accion As ObtenerDepositosPorProductoAccion) As List(Of Deposito)
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia().crear(GetType(Deposito))
            Dim criteria As New GenericQueryCriteria
            criteria.booleanCriteria = False
            criteria.integerCriteria = accion.productoId
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
