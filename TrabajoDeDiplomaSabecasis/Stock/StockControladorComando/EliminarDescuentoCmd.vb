Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarDescuentoCmd
    Inherits Comando(Of String, EliminarDescuentoAccion)


    Public Overrides Function execute(accion As EliminarDescuentoAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            If accion.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            Dim dao As AbstractDao(Of Descuento) = DaoFactory(Of Descuento).obtenerInstancia().crear(GetType(Descuento))
            Dim oDescuento As New Descuento
            oDescuento.id = accion.id
            dao.eliminar(oDescuento)
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.DESCUENTO_ELIMINADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
