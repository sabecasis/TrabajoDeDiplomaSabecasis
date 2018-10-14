Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarPedidoDeStockCmd
    Inherits Comando(Of String, GuardarPedidoDeStockAccion)

    Public Overrides Function execute(accion As GuardarPedidoDeStockAccion) As String
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            Dim oAutorizador As Autorizador = Autorizador.obtenerInstancia()
            Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
            Dim oPedido As New PedidoDeStock
            oPedido.id = accion.id
            oPedido.fecha = accion.fecha
            oPedido.empleado = oSesion.usuarioActual.empleados.Item(0)
            oPedido.deposito = accion.deposito
            oPedido.producto = accion.producto
            oPedido.ingresado = accion.ingresado
            oPedido.cantidad = accion.cantidad
            Dim mensaje As String
            If accion.id = 0 Then
                oAutorizador.autorizar(ConstantesDePermisos.CREAR)
                dao.guardar(oPedido)
                mensaje = oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.PEDIDO_GUARDADO) & oPedido.id.ToString
            Else
                oAutorizador.autorizar(ConstantesDePermisos.ACTUALIZAR)
                dao.actualizar(oPedido)
                mensaje = oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.PEDIDO_GUARDADO) & oPedido.id.ToString
            End If
            Return mensaje
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
