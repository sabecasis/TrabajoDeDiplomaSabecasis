Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarProductoCmd
    Inherits Comando(Of String, GuardarProductoAccion)


    Public Overrides Function execute(accion As GuardarProductoAccion) As String
        Try
            Dim oAutorizador As Autorizador = Autorizador.obtenerInstancia()
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            If accion Is Nothing Then
                Throw New Exception(oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
            If accion.oProducto.id = 0 Then
                oAutorizador.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(accion.oProducto)
                Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.PRODUCTO_GUARDADO_CON_EXITO) + accion.oProducto.id.ToString
            Else
                oAutorizador.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(accion.oProducto)
                Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.PRODUCTO_GUARDADO_CON_EXITO)
            End If
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
