Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarProveedorCmd
    Inherits Comando(Of String, EliminarProveedorAccion)


    Public Overrides Function execute(accion As EliminarProveedorAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of Proveedor) = DaoFactory(Of Proveedor).obtenerInstancia().crear(GetType(Proveedor))
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            If accion.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            Dim prov As New Proveedor
            prov.id = accion.id
            dao.eliminar(prov)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.PROVEEDOR_ELIMINADO_CORRECTAMENTE)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
