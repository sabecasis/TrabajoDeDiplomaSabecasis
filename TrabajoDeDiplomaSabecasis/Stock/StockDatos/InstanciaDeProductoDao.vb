Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class InstanciaDeProductoDao
    Inherits AbstractDao(Of InstanciaDeProducto)

    Public Overrides Function actualizar(oEntity As InstanciaDeProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of InstanciaDeProducto)) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_INSTANCIA_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure

            If oEntityList Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            For Each oEntity As InstanciaDeProducto In oEntityList
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
                comando.Parameters.AddWithValue("@estado_inst_producto_id", oEntity.estado.id)
                comando.Parameters.AddWithValue("@precio_compra", oEntity.precioCompra)
                comando.Parameters.AddWithValue("@precio_venta", oEntity.precioVenta)
                comando.Parameters.AddWithValue("@fecha_ultima_modificacion", oEntity.fechaUltimaModificacion)
                comando.Parameters.AddWithValue("@motivo_modificacion", oEntity.motivoModificacion)

                If Not oEntity.egresoDeStock Is Nothing Then
                    comando.Parameters.AddWithValue("@egreso_id", oEntity.egresoDeStock.id)
                Else
                    comando.Parameters.AddWithValue("@egreso_id", 0)
                End If
                comando.Parameters.AddWithValue("@inst_prod_id", oEntity.id)

                comando.ExecuteNonQuery()
            Next



            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
    End Function

    Public Overrides Function eliminar(oEntity As InstanciaDeProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of InstanciaDeProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As InstanciaDeProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of InstanciaDeProducto)) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_INSTANCIA_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure

            If oEntityList Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            For Each oEntity As InstanciaDeProducto In oEntityList
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@producto_id", oEntity.producto.id)
                comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
                comando.Parameters.AddWithValue("@estado_inst_producto_id", oEntity.estado.id)
                comando.Parameters.AddWithValue("@precio_compra", oEntity.precioCompra)
                comando.Parameters.AddWithValue("@precio_venta", oEntity.precioVenta)
                comando.Parameters.AddWithValue("@fecha_ultima_modificacion", oEntity.fechaUltimaModificacion)
                comando.Parameters.AddWithValue("@motivo_modificacion", oEntity.motivoModificacion)
                comando.Parameters.AddWithValue("@ingreso_id", oEntity.ingresoEnStock.id)

                oEntity.id = comando.ExecuteScalar()

            Next

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing

    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of InstanciaDeProducto)
        Dim query = ""
        Try
            If Not queryCriteria Is Nothing Then
                If TypeOf queryCriteria Is InstanciaConFiltroQueryCriteria Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_INSTANCIAS_DE_PRODUCTO_CON_FILTRO_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oEstSuc As InstanciaDeProducto = Nothing
                    Dim reader As SqlDataReader
                    Dim lista As New List(Of InstanciaDeProducto)

                    Dim criteria As InstanciaConFiltroQueryCriteria = queryCriteria

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@producto_id", criteria.idProducto)
                    comando.Parameters.AddWithValue("@deposito_id", criteria.idDeposito)
                    comando.Parameters.AddWithValue("@familia_id", criteria.idFamilia)
                    comando.Parameters.AddWithValue("@sucursal_id", criteria.idSucursal)

                    Dim generic As New GenericQueryCriteria
                    Dim prDao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia.crear(GetType(Producto))
                    Dim depDao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia.crear(GetType(Deposito))
                    reader = comando.ExecuteReader()
                    While reader.Read()
                        oEstSuc = New InstanciaDeProducto()
                        oEstSuc.id = reader.GetValue(0)
                        oEstSuc.estado = New EstadoInstanciaProducto
                        oEstSuc.estado.id = reader.GetValue(3)
                        oEstSuc.estado.estado = reader.GetValue(4)
                        oEstSuc.egresoDeStock = New EgresoDeStock
                        If Not Convert.IsDBNull(reader.GetValue(2)) Then
                            oEstSuc.egresoDeStock.id = reader.GetValue(2)
                        End If

                        generic.integerCriteria = reader.GetValue(1)
                        generic.stringCriteria = ""
                        oEstSuc.deposito = depDao.obtenerUno(generic)
                        oEstSuc.fechaUltimaModificacion = reader.GetValue(5)
                        oEstSuc.ingresoEnStock = New IngresoDeStock()
                        oEstSuc.ingresoEnStock.id = reader.GetValue(6)
                        oEstSuc.motivoModificacion = reader.GetValue(7)
                        oEstSuc.precioCompra = reader.GetValue(8)
                        oEstSuc.precioVenta = reader.GetValue(9)
                        generic.integerCriteria = reader.GetValue(10)
                        generic.stringCriteria = ""
                        oEstSuc.producto = prDao.obtenerUno(generic)
                        lista.Add(oEstSuc)
                    End While
                    conexion.Close()

                    Return lista
                Else
                    Dim mdao As AbstractDao(Of MovimientoDeStock) = DaoFactory(Of MovimientoDeStock).obtenerInstancia().crear(GetType(MovimientoDeStock))
                    Dim movCrit As New MovimientoDeStockQueryCriteria
                    Dim criteria As InstanciaDeProductoQueryCriteria = queryCriteria
                    If criteria.idIngreso <> 0 Then
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        query = ConstantesDeDatos.OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_INGRESO_SP
                        Dim comando As SqlCommand = New SqlCommand(query, conexion)
                        conexion.Open()
                        Dim oEstSuc As InstanciaDeProducto = Nothing
                        Dim reader As SqlDataReader
                        Dim lista As New List(Of InstanciaDeProducto)

                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@ingreso_id", criteria.idIngreso)

                        Dim prodDao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
                        Dim prodCrit As New GenericQueryCriteria
                        Dim depDao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia().crear(GetType(Deposito))
                        Dim depCrit As New GenericQueryCriteria

                        reader = comando.ExecuteReader()

                        While reader.Read()
                            oEstSuc = New InstanciaDeProducto()
                            oEstSuc.id = reader.GetValue(0)
                            prodCrit.integerCriteria = reader.GetValue(1)
                            prodCrit.stringCriteria = ""
                            oEstSuc.producto = prodDao.obtenerUno(prodCrit)
                            depCrit.integerCriteria = reader.GetValue(2)
                            depCrit.stringCriteria = ""
                            oEstSuc.deposito = depDao.obtenerUno(depCrit)
                            oEstSuc.fechaUltimaModificacion = reader.GetValue(7)
                            oEstSuc.ingresoEnStock = New IngresoDeStock
                            oEstSuc.ingresoEnStock.id = reader.GetValue(9)
                            oEstSuc.motivoModificacion = reader.GetValue(8)
                            oEstSuc.precioCompra = reader.GetValue(5)
                            oEstSuc.precioVenta = reader.GetValue(6)
                            oEstSuc.estado = New EstadoInstanciaProducto
                            oEstSuc.estado.id = reader.GetValue(3)
                            oEstSuc.estado.estado = reader.GetValue(4)
                            movCrit.idInstanciaProducto = oEstSuc.id
                            oEstSuc.movimientosDeStock = mdao.obtenerMuchos(movCrit)
                            lista.Add(oEstSuc)
                        End While
                        conexion.Close()
                        Return lista
                    Else
                        If criteria.idDeposito <> 0 Then
                            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                            query = ConstantesDeDatos.OBTENER_INSTANCIAS_DE_PRODUCTO_PARA_EGRESO_SP
                            Dim comando As SqlCommand = New SqlCommand(query, conexion)
                            conexion.Open()
                            Dim oEstSuc As InstanciaDeProducto = Nothing
                            Dim reader As SqlDataReader
                            Dim lista As New List(Of InstanciaDeProducto)

                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@producto_id", criteria.idProducto)
                            comando.Parameters.AddWithValue("@deposito_id", criteria.idDeposito)

                            reader = comando.ExecuteReader()
                            While reader.Read()
                                oEstSuc = New InstanciaDeProducto()
                                oEstSuc.id = reader.GetValue(0)
                                oEstSuc.estado = New EstadoInstanciaProducto
                                oEstSuc.estado.id = reader.GetValue(1)
                                oEstSuc.estado.estado = reader.GetValue(9)
                                oEstSuc.deposito = New Deposito
                                oEstSuc.deposito.id = reader.GetValue(2)
                                oEstSuc.fechaUltimaModificacion = reader.GetValue(3)
                                oEstSuc.ingresoEnStock = New IngresoDeStock
                                oEstSuc.ingresoEnStock.id = reader.GetValue(4)
                                oEstSuc.motivoModificacion = reader.GetValue(5)
                                oEstSuc.precioCompra = reader.GetValue(6)
                                oEstSuc.precioVenta = reader.GetValue(7)
                                oEstSuc.producto = New Producto
                                oEstSuc.producto.id = reader.GetValue(8)
                                movCrit.idInstanciaProducto = oEstSuc.id
                                oEstSuc.movimientosDeStock = mdao.obtenerMuchos(movCrit)
                                lista.Add(oEstSuc)
                            End While
                            conexion.Close()
                            Return lista
                        ElseIf criteria.idEgreso <> 0 Then
                            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                            query = ConstantesDeDatos.OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_EGRESO_SP
                            Dim comando As SqlCommand = New SqlCommand(query, conexion)
                            conexion.Open()
                            Dim oEstSuc As InstanciaDeProducto = Nothing
                            Dim reader As SqlDataReader
                            Dim lista As New List(Of InstanciaDeProducto)

                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@egreso_id", criteria.idEgreso)

                            reader = comando.ExecuteReader()
                            While reader.Read()
                                oEstSuc = New InstanciaDeProducto()
                                oEstSuc.id = reader.GetValue(0)
                                oEstSuc.producto = New Producto
                                oEstSuc.producto.id = reader.GetValue(1)
                                oEstSuc.fechaUltimaModificacion = reader.GetValue(6)
                                oEstSuc.ingresoEnStock = New IngresoDeStock
                                oEstSuc.ingresoEnStock.id = reader.GetValue(8)
                                oEstSuc.motivoModificacion = reader.GetValue(7)
                                oEstSuc.precioCompra = reader.GetValue(4)
                                oEstSuc.precioVenta = reader.GetValue(5)
                                oEstSuc.egresoDeStock = New EgresoDeStock
                                oEstSuc.egresoDeStock.id = reader.GetValue(9)
                                oEstSuc.deposito = New Deposito
                                oEstSuc.deposito.id = reader.GetValue(10)
                                oEstSuc.estado = New EstadoInstanciaProducto
                                oEstSuc.estado.id = reader.GetValue(3)
                                'Todavia no necesitamos el resto de los datos
                                movCrit.idInstanciaProducto = oEstSuc.id
                                oEstSuc.movimientosDeStock = mdao.obtenerMuchos(movCrit)
                                lista.Add(oEstSuc)
                            End While
                            conexion.Close()
                            Return lista

                        ElseIf criteria.idMovimiento <> 0 Then
                            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                            query = ConstantesDeDatos.OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_MOVIMIENTO_SP
                            Dim comando As SqlCommand = New SqlCommand(query, conexion)
                            conexion.Open()
                            Dim oEstSuc As InstanciaDeProducto = Nothing
                            Dim reader As SqlDataReader
                            Dim lista As New List(Of InstanciaDeProducto)

                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@movimiento_id", criteria.idMovimiento)

                            reader = comando.ExecuteReader()
                            While reader.Read()
                                oEstSuc = New InstanciaDeProducto()
                                oEstSuc.id = reader.GetValue(0)
                                oEstSuc.producto = New Producto
                                oEstSuc.producto.id = reader.GetValue(1)
                                oEstSuc.fechaUltimaModificacion = reader.GetValue(6)
                                oEstSuc.ingresoEnStock = New IngresoDeStock
                                oEstSuc.ingresoEnStock.id = reader.GetValue(8)
                                oEstSuc.motivoModificacion = reader.GetValue(7)
                                oEstSuc.precioCompra = reader.GetValue(4)
                                oEstSuc.precioVenta = reader.GetValue(5)
                                oEstSuc.egresoDeStock = New EgresoDeStock
                                oEstSuc.egresoDeStock.id = reader.GetValue(9)
                                oEstSuc.deposito = New Deposito
                                oEstSuc.deposito.id = reader.GetValue(10)
                                oEstSuc.estado = New EstadoInstanciaProducto
                                oEstSuc.estado.id = reader.GetValue(3)

                                lista.Add(oEstSuc)
                            End While
                            conexion.Close()
                            Return lista
                        Else
                            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                            query = ConstantesDeDatos.OBTENER_TODAS_LAS_INSTANCIAS_PRODUCTO_POR_PROD_SP
                            Dim comando As SqlCommand = New SqlCommand(query, conexion)
                            conexion.Open()
                            Dim oEstSuc As InstanciaDeProducto = Nothing
                            Dim reader As SqlDataReader
                            Dim lista As New List(Of InstanciaDeProducto)

                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@producto_id", criteria.idProducto)

                            reader = comando.ExecuteReader()
                            While reader.Read()
                                oEstSuc = New InstanciaDeProducto()
                                oEstSuc.id = reader.GetValue(0)
                                oEstSuc.producto = New Producto
                                oEstSuc.producto.id = reader.GetValue(1)
                                oEstSuc.fechaUltimaModificacion = reader.GetValue(6)
                                oEstSuc.ingresoEnStock = New IngresoDeStock
                                oEstSuc.ingresoEnStock.id = reader.GetValue(8)
                                oEstSuc.motivoModificacion = reader.GetValue(7)
                                oEstSuc.precioCompra = reader.GetValue(4)
                                oEstSuc.precioVenta = reader.GetValue(5)
                                oEstSuc.deposito = New Deposito
                                oEstSuc.deposito.id = reader.GetValue(9)
                                oEstSuc.estado = New EstadoInstanciaProducto
                                oEstSuc.estado.id = reader.GetValue(10)
                                movCrit.idInstanciaProducto = oEstSuc.id
                                oEstSuc.movimientosDeStock = mdao.obtenerMuchos(movCrit)
                                lista.Add(oEstSuc)
                            End While
                            conexion.Close()
                            Return lista
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As InstanciaDeProducto
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
