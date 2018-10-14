Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarFamiliaProductoCmd
    Inherits Comando(Of String, EliminarFamiliaProductoAccion)


    Public Overrides Function execute(accion As EliminarFamiliaProductoAccion) As String
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of FamiliaDeProducto) = DaoFactory(Of FamiliaDeProducto).obtenerInstancia.crear(GetType(FamiliaDeProducto))
            Dim oFamilia As New FamiliaDeProducto
            oFamilia.id = accion.id
            dao.eliminar(oFamilia)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.FAMILIA_PROD_ELIMINADA)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
