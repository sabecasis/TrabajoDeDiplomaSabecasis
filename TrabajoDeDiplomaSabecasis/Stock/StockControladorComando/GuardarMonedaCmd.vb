Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarMonedaCmd
    Inherits Comando(Of String, GuardarMonedaAccion)


    Public Overrides Function execute(accion As GuardarMonedaAccion) As String
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim oMoneda As New Moneda()
            oMoneda.id = accion.id
            oMoneda.moneda = accion.moneda
            Dim dao As AbstractDao(Of Moneda) = DaoFactory(Of Moneda).obtenerInstancia.crear(GetType(Moneda))
            If accion.id = 0 Then
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(oMoneda)
            Else
                Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(oMoneda)
            End If
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.MONEDA_GUARDADA_CON_EXITO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class
