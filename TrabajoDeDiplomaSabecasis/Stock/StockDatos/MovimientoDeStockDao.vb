Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class MovimientoDeStockDao
    Inherits AbstractDao(Of MovimientoDeStock)

    Public Overrides Function actualizar(oEntity As MovimientoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_MOVIMIENTO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@deposito_dest_id", oEntity.depositoDestino.id)
            comando.Parameters.AddWithValue("@motivo", oEntity.motivo)
            If oEntity.fechaAceptacion = Nothing Then
                comando.Parameters.AddWithValue("@fecha_aceptacion", Convert.DBNull)
            Else
                comando.Parameters.AddWithValue("@fecha_aceptacion", oEntity.fechaAceptacion)
            End If

            comando.Parameters.AddWithValue("@movimiento_id", oEntity.id)
            comando.Parameters.AddWithValue("@empleado_id", Sesion.obtenerInstancia.usuarioActual.empleados.Item(0).id)

            comando.ExecuteNonQuery()

            Dim dao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            dao.actualizarMuchos(oEntity.listaInstancias)

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of MovimientoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As MovimientoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            conexion.Open()
            Dim crit As New InstanciaDeProductoQueryCriteria
            crit.idMovimiento = oEntity.id
            Dim instDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))

            oEntity.listaInstancias = instDao.obtenerMuchos(crit)

            For Each inst As InstanciaDeProducto In oEntity.listaInstancias
                inst.estado = New EstadoInstanciaProducto
                inst.estado.id = 1
                inst.deposito = New Deposito
                inst.deposito.id = oEntity.depositoOrigen.id
                inst.motivoModificacion = "EM"
            Next

            Dim prodInstDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            prodInstDao.actualizarMuchos(oEntity.listaInstancias)


            query = ConstantesDeDatos.ELIMINAR_MOVIMIENTO_DE_STOCK
            Dim comando As SqlCommand = New SqlCommand(query, conexion)



            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@movimiento_id", oEntity.id)

            comando.ExecuteNonQuery()


            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of MovimientoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As MovimientoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_MOVIMIENTO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            Dim reader As SqlDataReader

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@cantidad", oEntity.cantidad)
            comando.Parameters.AddWithValue("@producto_id", oEntity.producto.id)
            comando.Parameters.AddWithValue("@deposito_orig_id", oEntity.depositoOrigen.id)
            comando.Parameters.AddWithValue("@deposito_dest_id", oEntity.depositoDestino.id)
            comando.Parameters.AddWithValue("@motivo", oEntity.motivo)
            comando.Parameters.AddWithValue("@empleado_id", Sesion.obtenerInstancia.usuarioActual.empleados.Item(0).id)


            reader = comando.ExecuteReader()
            Dim id As Integer = 0
            While reader.Read()
                id = reader.GetValue(0)
                Exit While
            End While

            oEntity.id = id

            For Each instancia As InstanciaDeProducto In oEntity.listaInstancias
                instancia.movimientosDeStock = New List(Of MovimientoDeStock)
                instancia.movimientosDeStock.Add(oEntity)
                instancia.estado = New EstadoInstanciaProducto
                instancia.estado.id = 5
                instancia.motivoModificacion = oEntity.motivo
            Next
            reader.Close()

            Dim dao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            dao.actualizarMuchos(oEntity.listaInstancias)

            query = ConstantesDeDatos.GUARDAR_RELACION_INSTANCIA_MOVIMIENTO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            For Each instancia As InstanciaDeProducto In oEntity.listaInstancias
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@instancia_id", instancia.id)
                comando.Parameters.AddWithValue("@movimiento_id", oEntity.id)

                comando.ExecuteNonQuery()
            Next

            query = ConstantesDeDatos.GUARDAR_COMPROBANTE_DE_MOVIMIENTO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@comprobante", GeneradorDeComprobantes.generarComprobanteDeMovimientoDeStock(oEntity.id, oEntity.fecha, oEntity.listaInstancias, oEntity.depositoOrigen.nomber, oEntity.depositoDestino.nomber, oEntity.motivo))
            comando.Parameters.AddWithValue("@movimiento_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of MovimientoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of MovimientoDeStock)
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                If TypeOf queryCriteria Is ConsultaMovimientosDeStockVariosQueryCriteria Then
                    Dim criteria As ConsultaMovimientosDeStockVariosQueryCriteria = queryCriteria
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_TODOS_LOS_MOVIMIENTOS_DE_STOCK_CON_FILTRO
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oEstSuc As MovimientoDeStock = Nothing
                    Dim reader As SqlDataReader
                    Dim lista As New List(Of MovimientoDeStock)

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
                    While reader.Read()
                        oEstSuc = New MovimientoDeStock()
                        oEstSuc.id = reader.GetValue(0)
                        oEstSuc.cantidad = reader.GetValue(1)
                        oEstSuc.depositoDestino = New Deposito
                        oEstSuc.depositoDestino.id = reader.GetValue(4)
                        oEstSuc.depositoOrigen = New Deposito
                        oEstSuc.depositoOrigen.id = reader.GetValue(3)
                        oEstSuc.fecha = reader.GetValue(2)
                        oEstSuc.motivo = TryCast(reader.GetValue(6), String)
                        oEstSuc.producto = New Producto
                        oEstSuc.producto.id = reader.GetValue(5)
                        If Not Convert.IsDBNull(reader.GetValue(7)) Then
                            oEstSuc.fechaAceptacion = reader.GetValue(7)
                        End If
                        oEstSuc.empleado = New Empleado
                        oEstSuc.empleado.id = reader.GetValue(8)
                        lista.Add(oEstSuc)
                    End While
                    conexion.Close()
                    Return lista
                Else
                    Dim criteria As MovimientoDeStockQueryCriteria = queryCriteria
                    If criteria.idInstanciaProducto <> 0 Then
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        query = ConstantesDeDatos.OBTENER_TODOS_LOS_MOVIMIENTOS_DE_STOCK_POR_INSTANCIA_SP
                        Dim comando As SqlCommand = New SqlCommand(query, conexion)
                        conexion.Open()
                        Dim oEstSuc As MovimientoDeStock = Nothing
                        Dim reader As SqlDataReader
                        Dim lista As New List(Of MovimientoDeStock)

                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@instancia_id", criteria.idInstanciaProducto)

                        reader = comando.ExecuteReader()
                        While reader.Read()
                            oEstSuc = New MovimientoDeStock()
                            oEstSuc.id = reader.GetValue(0)
                            oEstSuc.cantidad = reader.GetValue(1)
                            If Not Convert.IsDBNull(reader.GetValue(2)) Then
                                oEstSuc.comprobante = reader.GetValue(2)
                            End If
                            oEstSuc.depositoDestino = New Deposito
                            oEstSuc.depositoDestino.id = reader.GetValue(3)
                            oEstSuc.depositoOrigen = New Deposito
                            oEstSuc.depositoOrigen.id = reader.GetValue(4)
                            oEstSuc.fecha = reader.GetValue(5)
                            oEstSuc.motivo = TryCast(reader.GetValue(6), String)
                            oEstSuc.producto = New Producto
                            oEstSuc.producto.id = reader.GetValue(7)
                            lista.Add(oEstSuc)
                        End While
                        conexion.Close()
                        Return lista

                    ElseIf criteria.deposito_id <> 0 Then
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        query = ConstantesDeDatos.OBTENER_TODOS_LOS_MOVIMIENTOS_DE_STOCK_PENDIENTES_POR_DEPOSITO_SP
                        Dim comando As SqlCommand = New SqlCommand(query, conexion)
                        conexion.Open()
                        Dim oEstSuc As MovimientoDeStock = Nothing
                        Dim reader As SqlDataReader
                        Dim lista As New List(Of MovimientoDeStock)

                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@deposito_destino_id", criteria.deposito_id)

                        reader = comando.ExecuteReader()
                        While reader.Read()
                            oEstSuc = New MovimientoDeStock()
                            oEstSuc.id = reader.GetValue(0)
                            oEstSuc.cantidad = reader.GetValue(1)
                            oEstSuc.depositoDestino = New Deposito
                            oEstSuc.depositoDestino.id = reader.GetValue(4)
                            oEstSuc.depositoOrigen = New Deposito
                            oEstSuc.depositoOrigen.id = reader.GetValue(3)
                            oEstSuc.fecha = reader.GetValue(2)
                            oEstSuc.motivo = TryCast(reader.GetValue(6), String)
                            oEstSuc.producto = New Producto
                            oEstSuc.producto.id = reader.GetValue(5)
                            lista.Add(oEstSuc)
                        End While
                        conexion.Close()
                        Return lista
                    End If
                End If
            End If

        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As MovimientoDeStock
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                Dim criteria As MovimientoDeStockQueryCriteria = queryCriteria
                If criteria.idMovimiento <> 0 Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_MOVIMIENTO_DE_STOCK_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oEstSuc As MovimientoDeStock = Nothing
                    Dim reader As SqlDataReader

                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@movimiento_id", criteria.idMovimiento)
                    Dim instDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
                    Dim cirt As New InstanciaDeProductoQueryCriteria
                    reader = comando.ExecuteReader()
                    While reader.Read()
                        oEstSuc = New MovimientoDeStock()
                        oEstSuc.id = reader.GetValue(0)
                        oEstSuc.cantidad = reader.GetValue(1)
                        If Not Convert.IsDBNull(reader.GetValue(6)) Then
                            oEstSuc.comprobante = reader.GetValue(6)
                        End If
                        oEstSuc.depositoDestino = New Deposito
                        oEstSuc.depositoDestino.id = reader.GetValue(4)
                        oEstSuc.depositoOrigen = New Deposito
                        oEstSuc.depositoOrigen.id = reader.GetValue(3)
                        oEstSuc.fecha = reader.GetValue(2)
                        oEstSuc.motivo = TryCast(reader.GetValue(7), String)
                        oEstSuc.producto = New Producto
                        oEstSuc.producto.id = reader.GetValue(5)
                        If Not Convert.IsDBNull(reader.GetValue(8)) Then
                            oEstSuc.fechaAceptacion = reader.GetValue(8)
                        End If
                        cirt.idMovimiento = oEstSuc.id
                        oEstSuc.listaInstancias = instDao.obtenerMuchos(cirt)
                        Exit While
                    End While
                    conexion.Close()
                    Return oEstSuc
                End If
            End If
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
