Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class EliminarMarcaCmd
    Inherits Comando(Of String, EliminarMarcaAccion)



    Public Overrides Function execute(accion As EliminarMarcaAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)

            Dim dao As AbstractDao(Of Marca) = DaoFactory(Of Marca).obtenerInstancia().crear(GetType(Marca))
            If accion.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA))
            End If
            Dim oMarca As New Marca()
            oMarca.id = accion.id
            dao.eliminar(oMarca)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.MARCA_ELIMINADA_CORRECTAMENTE) & accion.id.ToString
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class
