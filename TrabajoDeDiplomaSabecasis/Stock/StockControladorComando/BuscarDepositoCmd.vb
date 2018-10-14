Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class BuscarDepositoCmd
    Inherits Comando(Of Deposito, BuscarDepositoAccion)

    Public Overrides Function execute(accion As BuscarDepositoAccion) As Deposito
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia.crear(GetType(Deposito))
            Dim criteria As New GenericQueryCriteria()
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            criteria.stringCriteria = accion.nombre
            criteria.integerCriteria = accion.id
            Dim oDeposito As Deposito = dao.obtenerUno(criteria)
            Return oDeposito
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
