Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class BuscarMonedaCmd
    Inherits Comando(Of Moneda, BuscarMonedaAccion)

    Public Overrides Function execute(accion As BuscarMonedaAccion) As Moneda
        Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of Moneda) = DaoFactory(Of Moneda).obtenerInstancia.crear(GetType(Moneda))
        Dim criteria As New GenericQueryCriteria()
        If accion Is Nothing Then
            Throw New ExcepcionDeComando(New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA)), Me.GetType.ToString, accion)
        End If
        criteria.integerCriteria = accion.id
        criteria.stringCriteria = accion.moneda
        Dim oMoneda As Moneda = dao.obtenerUno(criteria)
        Return oMoneda
    End Function
End Class
