Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarProductoCmd
    Inherits Comando(Of String, EliminarProductoAccion)


    Public Overrides Function execute(accion As EliminarProductoAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            Dim dao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
            Dim instDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim oProd As New Producto
            oProd.id = accion.id
            Dim instcriteria As New InstanciaConFiltroQueryCriteria
            instcriteria.idProducto = oProd.id
            oProd.instanciasDeProductoActivas = instDao.obtenerMuchos(instcriteria)
            If oProd.instanciasDeProductoActivas.Count > 0 Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.PRODUCTO_EN_USO))
            End If
            dao.eliminar(oProd)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.PRODUCTO_ELIMINADO_CORRECTAMENTE)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
