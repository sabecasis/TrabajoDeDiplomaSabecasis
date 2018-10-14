Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class EgresoDeStockDao
    Inherits AbstractDao(Of EgresoDeStock)


    Public Overrides Function actualizar(oEntity As EgresoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_EGRESO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@empleado_id", oEntity.empleado.id)
            comando.Parameters.AddWithValue("@motivo", oEntity.motivo)
            comando.Parameters.AddWithValue("@egreso_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of EgresoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As EgresoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_EGRESO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@egreso_id", oEntity.id)

            comando.ExecuteNonQuery()

            For Each inst As InstanciaDeProducto In oEntity.listaInstanciasDeProducto
                inst.estado = New EstadoInstanciaProducto
                inst.estado.id = 1
                inst.egresoDeStock = New EgresoDeStock
                inst.egresoDeStock.id = 0
                inst.motivoModificacion = "Eliminación Egreso"
            Next

            Dim prodInstDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            prodInstDao.actualizarMuchos(oEntity.listaInstanciasDeProducto)

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing

    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of EgresoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As EgresoDeStock) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_EGRESO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            Dim reader As SqlDataReader

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha", oEntity.fecha)
            comando.Parameters.AddWithValue("@empleado_id", oEntity.empleado.id)
            comando.Parameters.AddWithValue("@cantidad", oEntity.cantidad)
            comando.Parameters.AddWithValue("@producto_id", oEntity.producto.id)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.deposito.id)
            comando.Parameters.AddWithValue("@motivo", oEntity.motivo)


            reader = comando.ExecuteReader()
            Dim idEgreso As Integer = 0
            While reader.Read()
                idEgreso = reader.GetValue(0)
                Exit While
            End While

            oEntity.id = idEgreso

            For Each instancia As InstanciaDeProducto In oEntity.listaInstanciasDeProducto
                instancia.egresoDeStock = oEntity
                instancia.estado.id = 3
            Next
            reader.Close()

            Dim dao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            dao.actualizarMuchos(oEntity.listaInstanciasDeProducto)

            query = ConstantesDeDatos.GUARDAR_COMPROBANTE_EGRESO_STOCK_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@comprobante", GeneradorDeComprobantes.generarComprobanteDeEgresoDeStock(oEntity.id, oEntity.fecha, oEntity.listaInstanciasDeProducto, oEntity.deposito.nomber, oEntity.motivo))
            comando.Parameters.AddWithValue("@egreso_de_stock_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of EgresoDeStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of EgresoDeStock)
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.OBTENER_TODOS_LOS_EGRESOS_DE_STOCK_CON_FILTRO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oEgreso As EgresoDeStock
            Dim reader As SqlDataReader
            Dim lista As New List(Of EgresoDeStock)
            comando.CommandType = CommandType.StoredProcedure
            Dim criteria As ConsultaMovimientosDeStockVariosQueryCriteria = queryCriteria

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
            Dim prodInstDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim prodInstCrit As New InstanciaDeProductoQueryCriteria
            While reader.Read()
                oEgreso = New EgresoDeStock
                oEgreso.id = reader.GetValue(0)
                oEgreso.producto = New Producto
                oEgreso.producto.id = reader.GetValue(1)
                oEgreso.cantidad = reader.GetValue(2)
                oEgreso.fecha = reader.GetValue(3)
                oEgreso.deposito = New Deposito
                oEgreso.deposito.id = reader.GetValue(4)
                oEgreso.motivo = reader.GetValue(5)
                oEgreso.empleado = New Empleado
                oEgreso.empleado.id = reader.GetValue(6)
                prodInstCrit.idEgreso = oEgreso.id
                oEgreso.listaInstanciasDeProducto = prodInstDao.obtenerMuchos(prodInstCrit)
                lista.Add(oEgreso)
            End While

            conexion.Close()
            comando.Dispose()

            Return lista
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As EgresoDeStock
        Dim query As String = ""
        Dim criteria As GenericQueryCriteria = queryCriteria
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_EGRESO_DE_STOCK_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oEgreso As EgresoDeStock = Nothing
            Dim reader As SqlDataReader

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@egreso_id", criteria.integerCriteria)


            reader = comando.ExecuteReader()
            Dim prodInstDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim prodInstCrit As New InstanciaDeProductoQueryCriteria
            While reader.Read()
                oEgreso = New EgresoDeStock
                oEgreso.id = reader.GetValue(0)
                oEgreso.producto = New Producto
                oEgreso.producto.id = reader.GetValue(1)
                oEgreso.cantidad = reader.GetValue(2)
                oEgreso.fecha = reader.GetValue(3)
                oEgreso.deposito = New Deposito
                oEgreso.deposito.id = reader.GetValue(4)
                oEgreso.motivo = reader.GetValue(5)
                oEgreso.empleado = New Empleado
                oEgreso.empleado.id = reader.GetValue(6)
                If Not Convert.IsDBNull(reader.GetValue(7)) Then
                    oEgreso.comprobante = reader.GetValue(7)
                End If

                prodInstCrit.idEgreso = oEgreso.id
                oEgreso.listaInstanciasDeProducto = prodInstDao.obtenerMuchos(prodInstCrit)
                Exit While
            End While

            conexion.Close()
            comando.Dispose()

            Return oEgreso
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
