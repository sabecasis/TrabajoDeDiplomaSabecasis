Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarMonedaCmd
    Inherits Comando(Of String, EliminarMonedaAccion)


    Public Overrides Function execute(accion As EliminarMonedaAccion) As String
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of Moneda) = DaoFactory(Of Moneda).obtenerInstancia.crear(GetType(Moneda))
            If accion.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA))
            End If
            Dim oMoneda As New Moneda()
            oMoneda.id = accion.id
            dao.eliminar(oMoneda)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.MONEDA_ELIMINADA_CORRECTAMENTE) & accion.id.ToString
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class
