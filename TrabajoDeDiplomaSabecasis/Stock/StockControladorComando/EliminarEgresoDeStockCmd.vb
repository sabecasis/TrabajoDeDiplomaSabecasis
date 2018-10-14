Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarEgresoDeStockCmd
    Inherits Comando(Of String, EliminarEgresoDeStockAccion)


    Public Overrides Function execute(accion As EliminarEgresoDeStockAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of EgresoDeStock) = DaoFactory(Of EgresoDeStock).obtenerInstancia().crear(GetType(EgresoDeStock))
            Dim eCriteria As New GenericQueryCriteria
            eCriteria.integerCriteria = accion.idEgreso
            Dim oEgreso As EgresoDeStock = dao.obtenerUno(eCriteria)
            Dim instDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim criteria As New InstanciaDeProductoQueryCriteria
            criteria.idEgreso = oEgreso.id
            oEgreso.listaInstanciasDeProducto = instDao.obtenerMuchos(criteria)
            dao.eliminar(oEgreso)
            Dim calcularCmd As New CalcularFaltantesDeStockCmd()
            Dim listaExistencias As List(Of ExistenciaDeProductoEnStock) = calcularCmd.execute(New CalcularFaltantesDeStockAccion(oEgreso.deposito))
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.EGRESO_ELIMINADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
