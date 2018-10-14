Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarDepositoCmd
    Inherits Comando(Of String, EliminarDepositoAccion)

    Public Overrides Function execute(accion As EliminarDepositoAccion) As String
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia.crear(GetType(Deposito))
            Dim oDeposito As New Deposito
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            oDeposito.id = accion.id
            dao.eliminar(oDeposito)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.DEPOSITO_ELIMINADO_CON_EXITO) & accion.id
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
