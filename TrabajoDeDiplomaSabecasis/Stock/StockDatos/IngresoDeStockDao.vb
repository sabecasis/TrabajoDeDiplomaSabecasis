Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class IngresoDeStockDao
    Inherits AbstractDao(Of IngresoDeStock)

    Public Overrides Function actualizar(oEntity As IngresoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_FACTURA_PROVEEDOR_STOCK
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()


            query = ConstantesDeDatos.ACTUALIZAR_INGRESO_STOCK_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
            comando.Parameters.AddWithValue("@ingreso_id", oEntity.id)


            comando.ExecuteNonQuery()


            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of IngresoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As IngresoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_INGRESO_STOCK_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA))
            End If
            comando.Parameters.AddWithValue("@ingreso_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of IngresoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As IngresoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_INGRESO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            Dim reader As SqlDataReader

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@empleado_id", oEntity.empleado.id)
            comando.Parameters.AddWithValue("@cantidad", oEntity.cantidad)
            comando.Parameters.AddWithValue("@producto_id", oEntity.producto.id)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
            comando.Parameters.AddWithValue("@pedido_id", oEntity.pedidoDeReposicion.id)


            reader = comando.ExecuteReader()
            Dim idIngreso As Integer = 0
            While reader.Read()
                idIngreso = reader.GetValue(0)
                Exit While
            End While

            oEntity.id = idIngreso

            For Each instancia As InstanciaDeProducto In oEntity.instanciasDeProducto
                instancia.ingresoEnStock = oEntity
            Next
            reader.Close()

            Dim dao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            dao.guardarMuchos(oEntity.instanciasDeProducto)

            query = ConstantesDeDatos.GUARDAR_COMPROBANTE_INGRESO_STOCK
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@comprobante", GeneradorDeComprobantes.generarComprobanteDeIngresoAStock(oEntity.id, oEntity.fecha, oEntity.instanciasDeProducto, oEntity.deposito.nomber))
            comando.Parameters.AddWithValue("@ingreso_stock_id", oEntity.id)

            comando.ExecuteNonQuery()

            If oEntity.factura Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.DEBE_INGRESAR_LA_FACTURA))
            End If
            query = ConstantesDeDatos.GUARDAR_FACTURA_PROVEEDOR_STOCK_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@ingreso_id", oEntity.id)
            comando.Parameters.AddWithValue("@factura", oEntity.factura)
            comando.Parameters.AddWithValue("@proveedor_id", oEntity.proveedor.id)
            comando.Parameters.AddWithValue("@extension_archivo", oEntity.extensionFactura)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of IngresoDeStock)) As Boolean

        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of IngresoDeStock)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            If TypeOf queryCriteria Is PedidoDeStockQueryCriteria Then
                Dim criteria As PedidoDeStockQueryCriteria = queryCriteria
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_INGRESOS_DE_STOCK_POR_PEDIDO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oIngreso As IngresoDeStock = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of IngresoDeStock)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@pedido_de_stock_id", criteria.idPedidoDeStock)

                reader = comando.ExecuteReader()

                While reader.Read()
                    oIngreso = New IngresoDeStock()
                    oIngreso.id = reader.GetValue(0)
                    oIngreso.fecha = reader.GetValue(1)
                    oIngreso.empleado = New Empleado
                    oIngreso.empleado.id = reader.GetValue(2)
                    oIngreso.deposito = New Deposito
                    oIngreso.deposito.id = reader.GetValue(3)
                    oIngreso.cantidad = reader.GetValue(4)
                    oIngreso.producto = New Producto
                    oIngreso.producto.id = reader.GetValue(5)
                    lista.Add(oIngreso)
                End While
                conexion.Close()
                Return lista
            Else
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_INGRESOS_DE_STOCK_CON_FILTRO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oIngreso As IngresoDeStock = Nothing
                Dim reader As SqlDataReader
                Dim criteria As ConsultaMovimientosDeStockVariosQueryCriteria = queryCriteria
                Dim lista As New List(Of IngresoDeStock)
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


                reader = comando.ExecuteReader()

                Dim instCriteria As New InstanciaDeProductoQueryCriteria
                Dim instdao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
                While reader.Read()
                    oIngreso = New IngresoDeStock()
                    oIngreso.id = reader.GetValue(0)
                    oIngreso.fecha = reader.GetValue(1)
                    oIngreso.empleado = New Empleado
                    oIngreso.empleado.id = reader.GetValue(2)
                    oIngreso.deposito = New Deposito
                    oIngreso.deposito.id = reader.GetValue(3)
                    oIngreso.cantidad = reader.GetValue(5)
                    instCriteria.idIngreso = oIngreso.id
                    oIngreso.instanciasDeProducto = instdao.obtenerMuchos(instCriteria)
                    oIngreso.producto = New Producto
                    oIngreso.producto.id = reader.GetValue(4)
                    lista.Add(oIngreso)
                End While
                conexion.Close()
                Return lista
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As IngresoDeStock
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_INGRESO_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oIngreso As IngresoDeStock = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            If criteria.oObject Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If


            Dim obj As IngresoDeStock = criteria.oObject


            comando.Parameters.AddWithValue("@ingreso_id", obj.id)
            comando.Parameters.AddWithValue("@fecha", obj.fecha)
            comando.Parameters.AddWithValue("@producto_id", obj.producto.id)
            comando.Parameters.AddWithValue("@deposito_id", obj.deposito.id)


            reader = comando.ExecuteReader()

            Dim instCriteria As New InstanciaDeProductoQueryCriteria
            Dim instdao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            While reader.Read()
                oIngreso = New IngresoDeStock()
                oIngreso.id = reader.GetValue(0)
                oIngreso.fecha = reader.GetValue(1)
                oIngreso.factura = reader.GetValue(2)
                oIngreso.empleado = New Empleado
                oIngreso.empleado.id = reader.GetValue(3)
                oIngreso.deposito = New Deposito
                oIngreso.deposito.id = reader.GetValue(4)
                oIngreso.comprobante = reader.GetValue(5)
                instCriteria.idIngreso = oIngreso.id
                oIngreso.instanciasDeProducto = instdao.obtenerMuchos(instCriteria)
                oIngreso.producto = New Producto
                oIngreso.producto.id = reader.GetValue(6)
                oIngreso.proveedor = New Proveedor
                oIngreso.proveedor.id = reader.GetValue(7)
                oIngreso.extensionFactura = reader.GetValue(8)
                oIngreso.pedidoDeReposicion = New PedidoDeStock
                oIngreso.pedidoDeReposicion.id = reader.GetValue(9)
                Exit While
            End While

            conexion.Close()

            Return oIngreso
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
