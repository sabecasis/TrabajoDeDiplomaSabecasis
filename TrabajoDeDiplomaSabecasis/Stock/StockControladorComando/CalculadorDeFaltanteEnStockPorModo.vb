Imports StockModelo
Imports StockDatos
Imports ElementosTransversales

Public Class CalculadorDeFaltanteEnStockPorModo

    'true si hay faltante
    Public Shared Function calcular(existencia As ExistenciaDeProductoEnStock, idDeposito As Integer) As Boolean
        existencia.deposito = New Deposito
        existencia.deposito.id = idDeposito
        If existencia.modoReposicion.id = ConstantesDeMetodoDeReposicion.PEDIDO_CICLICO Then
            Dim dao As New ExistenciaDeProductoEnStockDao
            Dim criteria As New ExistenciaQueryCriteria
            criteria.idProducto = existencia.idProducto
            criteria.idDeposito = idDeposito
            Dim fecha As Date = dao.obtenerUltimaFechaDeIngresoDeStock(criteria)
            If fecha = Nothing Then
                If existencia.pedidoAutomatico = True Then
                    generarPedidosDeStock(idDeposito, existencia)
                End If
                Return True
            Else
                If (Date.Now - fecha) < New TimeSpan(existencia.ciclo, 0, 0, 0) Then
                    If existencia.pedidoAutomatico = True Then
                        generarPedidosDeStock(idDeposito, existencia)
                    End If
                    Return True
                Else
                    Return False
                End If
            End If
        ElseIf existencia.modoReposicion.id = ConstantesDeMetodoDeReposicion.MIN_MAX Then
            If existencia.minStock >= existencia.cantidad Then
                If existencia.pedidoAutomatico = True Then
                    generarPedidosDeStock(idDeposito, existencia)
                End If
                Return True
            Else
                If existencia.pedidoAutomatico = True Then
                    If existencia.cantidad >= existencia.maxStock Or (existencia.maxStock = 0 And existencia.cantidad >= 20) Then
                        deshacerPedidosDeStock(idDeposito, existencia)
                    End If
                End If
                Return False
                End If
        Else  'Sistema ABC
                If existencia.cantidad = 0 Then
                    If existencia.pedidoAutomatico = True Then
                        generarPedidosDeStock(idDeposito, existencia)
                    End If
                    Return True
                Else
                If existencia.pedidoAutomatico = True Then
                    If existencia.cantidad >= existencia.maxStock Or (existencia.maxStock = 0 And existencia.cantidad >= 20) Then
                        deshacerPedidosDeStock(idDeposito, existencia)
                    End If
                End If
                    Return False
                End If
        End If
    End Function

    Private Shared Sub deshacerPedidosDeStock(idDeposito As Integer, existencia As ExistenciaDeProductoEnStock)
        Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
        Dim listaFinal As New List(Of PedidoDeStock)
        Dim criteria As New GenericQueryCriteria
        criteria.integerCriteria = idDeposito
        listaFinal = dao.obtenerMuchos(criteria)
        For Each pedido As PedidoDeStock In listaFinal
            If pedido.producto.id = existencia.idProducto Then
                dao.eliminar(pedido)
                Continue For
            End If
        Next
    End Sub

    Private Shared Sub generarPedidosDeStock(idDeposito As Integer, existencia As ExistenciaDeProductoEnStock)
        Dim debePedir As Boolean = True
        Dim dao As AbstractDao(Of PedidoDeStock) = DaoFactory(Of PedidoDeStock).obtenerInstancia().crear(GetType(PedidoDeStock))
        Dim listaFinal As New List(Of PedidoDeStock)
        Dim criteria As New GenericQueryCriteria
        criteria.integerCriteria = idDeposito
        listaFinal = dao.obtenerMuchos(criteria)
        For Each pedido As PedidoDeStock In listaFinal
            If pedido.producto.id = existencia.idProducto Then
                debePedir = False
            End If
        Next
        If debePedir = True Then
            If existencia.maxStock = 0 Then
                'stock maximo a pedir por defecto.
                existencia.maxStock = 20
            End If
                Dim oPedido As New PedidoDeStock
            Dim cant = (existencia.cantidad - existencia.minStock) + existencia.maxStock
                oPedido.cantidad = cant
                oPedido.fecha = Date.Now
                oPedido.deposito = New Deposito
                oPedido.deposito.id = idDeposito
                oPedido.empleado = Sesion.obtenerInstancia().usuarioActual.empleados.Item(0)
                oPedido.id = 0
                oPedido.ingresado = False
                oPedido.producto = New Producto
                oPedido.producto.id = existencia.idProducto
                dao.guardar(oPedido)
                GeneradorDeComprobantes.oGlobalWord.Documents.Close()
            End If
    End Sub
End Class
