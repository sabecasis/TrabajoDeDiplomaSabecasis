Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarSucursalCmd
    Inherits Comando(Of String, EliminarSucursalAccion)

    Public Overrides Function execute(accion As EliminarSucursalAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of Sucursal) = DaoFactory(Of Sucursal).obtenerInstancia.crear(GetType(Sucursal))
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim iSuc As New Sucursal()
            iSuc.id = accion.id
            dao.eliminar(iSuc)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.SUCURSAL_ELIMINADA_CORRECTAMENTE)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
