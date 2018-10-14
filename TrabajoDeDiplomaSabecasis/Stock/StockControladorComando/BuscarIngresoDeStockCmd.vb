Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarIngresoDeStockCmd
    Inherits Comando(Of IngresoDeStock, BuscarIngresoDeStockAccion)


    Public Overrides Function execute(accion As BuscarIngresoDeStockAccion) As IngresoDeStock
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of IngresoDeStock) = DaoFactory(Of IngresoDeStock).obtenerInstancia().crear(GetType(IngresoDeStock))
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim criteria As New GenericQueryCriteria()
            Dim obj As New IngresoDeStock
            obj.id = accion.id
            obj.fecha = accion.fecha
            obj.producto = accion.producto
            obj.deposito = accion.deposito
            criteria.oObject = obj
            Return dao.obtenerUno(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
