Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class PedidoDeStockDao
    Inherits AbstractDao(Of PedidoDeStock)

    Public Overrides Function actualizar(oEntity As PedidoDeStock) As Boolean
        Dim query As String = ""
        Try

            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            query = ConstantesDeDatos.ACTUALIZAR_PEDIDO_STOCK_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
            comando.Parameters.AddWithValue("@pedido_id", oEntity.id)
            comando.Parameters.AddWithValue("@producto_id", oEntity.producto.id)
            comando.Parameters.AddWithValue("@cantidad", oEntity.cantidad)
            comando.Parameters.AddWithValue("@empleado_id", oEntity.empleado.id)

            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.ACEPTAR_INGRESO_PEDIDO_DE_STOCK_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@pedido_id", oEntity.id)
            comando.Parameters.AddWithValue("@empleado_id", oEntity.empleado.id)
            comando.Parameters.AddWithValue("@estado", oEntity.ingresado)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of PedidoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As PedidoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_PEDIDO_STOCK_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA))
            End If
            comando.Parameters.AddWithValue("@pedido_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of PedidoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As PedidoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_PEDIDO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            Dim reader As SqlDataReader

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
            comando.Parameters.AddWithValue("@producto_id", oEntity.producto.id)
            comando.Parameters.AddWithValue("@cantidad", oEntity.cantidad)
            comando.Parameters.AddWithValue("@empleado_id", oEntity.empleado.id)



            reader = comando.ExecuteReader()
            Dim idPedido As Integer = 0
            While reader.Read()
                idPedido = reader.GetValue(0)
                Exit While
            End While

            oEntity.id = idPedido
            reader.Close()

            query = ConstantesDeDatos.GUARDAR_COMPROBANTE_PEDIDO_STOCK
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@comprobante", GeneradorDeComprobantes.generarComprobanteDePedidoAStock(oEntity.id, oEntity.fecha, oEntity.deposito.nomber, oEntity.cantidad, oEntity.producto.nombre, oEntity.producto.id))
            comando.Parameters.AddWithValue("@pedido_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of PedidoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of PedidoDeStock)
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                If TypeOf queryCriteria Is ConsultaMovimientosDeStockVariosQueryCriteria Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_TODOS_LOS_PEDIDOS_DE_STOCK_CON_FILTRO_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oPedido As PedidoDeStock = Nothing
                    Dim reader As SqlDataReader
                    Dim criteria As ConsultaMovimientosDeStockVariosQueryCriteria = queryCriteria
                    Dim lista As New List(Of PedidoDeStock)
                    comando.CommandType = CommandType.StoredProcedure

                    If criteria.fecha = Nothing Then
                        comando.Parameters.AddWithValue("@fecha", "")
                    Else
                        comando.Parameters.AddWithValue("@fecha", criteria.fecha.ToString)
                    End If

                    comando.Parameters.AddWithValue("@producto_id", criteria.producto.id)
                    comando.Parameters.AddWithValue("@deposito_id", criteria.deposito.id)
                    comando.Parameters.AddWithValue("@instancia_id", criteria.instanciaId)
                    comando.Parameters.AddWithValue("@nro_empleado", criteria.nroEmpleado)
                    If criteria.ingresado = True Then
                        comando.Parameters.AddWithValue("@ingresado", 1)
                    Else
                        comando.Parameters.AddWithValue("@ingresado", 0)
                    End If



                    reader = comando.ExecuteReader()
                    While reader.Read()
                        oPedido = New PedidoDeStock()
                        oPedido.id = reader.GetValue(0)
                        oPedido.fecha = reader.GetValue(4)
                        oPedido.empleado = New Empleado
                        oPedido.empleado.id = reader.GetValue(6)
                        oPedido.deposito = New Deposito
                        oPedido.deposito.id = reader.GetValue(2)
                        oPedido.producto = New Producto
                        oPedido.producto.id = reader.GetValue(1)
                        oPedido.cantidad = reader.GetValue(3)
                        oPedido.ingresado = reader.GetValue(5)
                        lista.Add(oPedido)
                    End While
                    conexion.Close()
                    Return lista
                Else
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_TODOS_LOS_PEDIDOS_DE_STOCK_NO_INGRESADOS_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oPedido As PedidoDeStock = Nothing
                    Dim reader As SqlDataReader
                    Dim criteria As GenericQueryCriteria = queryCriteria
                    Dim lista As New List(Of PedidoDeStock)
                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@deposito_id", criteria.integerCriteria)

                    reader = comando.ExecuteReader()
                    While reader.Read()
                        oPedido = New PedidoDeStock()
                        oPedido.id = reader.GetValue(0)
                        oPedido.fecha = reader.GetValue(4)
                        oPedido.empleado = New Empleado
                        oPedido.empleado.id = reader.GetValue(6)
                        oPedido.deposito = New Deposito
                        oPedido.deposito.id = reader.GetValue(2)
                        oPedido.producto = New Producto
                        oPedido.producto.id = reader.GetValue(1)
                        oPedido.cantidad = reader.GetValue(3)
                        oPedido.ingresado = reader.GetValue(5)
                        lista.Add(oPedido)
                    End While
                    conexion.Close()
                    Return lista

                End If
                End If

        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As PedidoDeStock
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_PEDIDO_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oPedido As PedidoDeStock = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@id_pedido", criteria.integerCriteria)

            reader = comando.ExecuteReader()

            While reader.Read()
                oPedido = New PedidoDeStock()
                oPedido.id = reader.GetValue(0)
                oPedido.fecha = reader.GetValue(4)
                oPedido.empleado = New Empleado
                oPedido.empleado.id = reader.GetValue(7)
                oPedido.deposito = New Deposito
                oPedido.deposito.id = reader.GetValue(2)
                oPedido.comprobante = reader.GetValue(6)
                oPedido.producto = New Producto
                oPedido.producto.id = reader.GetValue(1)
                oPedido.cantidad = reader.GetValue(3)
                oPedido.ingresado = reader.GetValue(5)
                Exit While
            End While
            conexion.Close()
            Return oPedido
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Sub calcularVerificadorVertical()

    End Sub

    Public Overrides Function checkearVerificadorVertical() As Boolean
        Return True
    End Function

    Public Overrides Sub calcularVerificadorHoriontal()

    End Sub
End Class
