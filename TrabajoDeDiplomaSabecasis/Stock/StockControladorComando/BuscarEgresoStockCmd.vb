Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarEgresoStockCmd
    Inherits Comando(Of EgresoDeStock, BuscarEgresoStockAccion)


    Public Overrides Function execute(accion As BuscarEgresoStockAccion) As EgresoDeStock
        Try
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of EgresoDeStock) = DaoFactory(Of EgresoDeStock).obtenerInstancia().crear(GetType(EgresoDeStock))
            Dim criteria As New GenericQueryCriteria
            criteria.integerCriteria = accion.idEgreso
            Return dao.obtenerUno(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
