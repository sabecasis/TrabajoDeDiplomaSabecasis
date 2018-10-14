Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class ProductoDao
    Inherits AbstractDao(Of Producto)

    Public Overrides Function actualizar(oEntity As Producto) As Boolean

        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            If oEntity.nombre Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            If "".Equals(oEntity.nombre) Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)
            comando.Parameters.AddWithValue("@precio_compra", oEntity.precioCompra)
            comando.Parameters.AddWithValue("@precio_venta", oEntity.precioVenta)
            comando.Parameters.AddWithValue("@moneda_id", oEntity.moneda.id)
            comando.Parameters.AddWithValue("@estado_id", oEntity.estado.id)
            comando.Parameters.AddWithValue("@marca_id", oEntity.marca.id)
            comando.Parameters.AddWithValue("@clasificacion_id", oEntity.clasificacion.id)
            comando.Parameters.AddWithValue("@regla_de_composicion", oEntity.reglaDeComposicion)
            comando.Parameters.AddWithValue("@porcentaje_de_ganancia", oEntity.porcentajeGanancia)
            comando.Parameters.AddWithValue("@metodo_de_valoracion_id", oEntity.metodoDeValoracion.id)
            comando.Parameters.AddWithValue("@precio_coste_adquisicion", oEntity.precioCosteAdquisicion)
            comando.Parameters.AddWithValue("@coste_de_posesion", oEntity.costeDePosecion)
            comando.Parameters.AddWithValue("@coste_financiero", oEntity.costeFinanciero)
            comando.Parameters.AddWithValue("@producto_id", oEntity.id)
            comando.Parameters.AddWithValue("@descuento_global_id", oEntity.descuento.id)
            comando.Parameters.AddWithValue("@precio_ultima_compra", oEntity.precioUltimaCompra)
            comando.Parameters.AddWithValue("@metodo_de_reposicion_id", oEntity.metodoDeReposicion.id)
            comando.Parameters.AddWithValue("@stock_minimo", oEntity.minStock)
            comando.Parameters.AddWithValue("@stock_maximo", oEntity.maxStock)
            comando.Parameters.AddWithValue("@ciclo", oEntity.ciclo)
            comando.Parameters.AddWithValue("@familia_id", oEntity.familia.id)
            comando.Parameters.AddWithValue("@unidad", oEntity.unidad)
            comando.Parameters.AddWithValue("@pedido_automatico", oEntity.pedidoAutomatico)

            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.ELIMINAR_RELACION_PRODUCTO_PROVEEDOR
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@producto_id", oEntity.id)
            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.CREAR_RELACION_PRODUCTO_PROVEEDOR
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            If Not oEntity.proveedores Is Nothing Then
                For Each oProv As Proveedor In oEntity.proveedores
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@producto_id", oEntity.id)
                    comando.Parameters.AddWithValue("@proveedor_id", oProv.id)

                    comando.ExecuteNonQuery()
                Next
            End If

            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Producto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Producto) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_PRODUCTO_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New ExcepcionDeDatos(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA)), Me.GetType.ToString, query)
            End If
            comando.Parameters.AddWithValue("@producto_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Producto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Producto) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader
            conexion.Open()

            If oEntity.nombre Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            If "".Equals(oEntity.nombre) Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)
            comando.Parameters.AddWithValue("@precio_compra", oEntity.precioCompra)
            comando.Parameters.AddWithValue("@precio_venta", oEntity.precioVenta)
            comando.Parameters.AddWithValue("@moneda_id", oEntity.moneda.id)
            comando.Parameters.AddWithValue("@estado_id", oEntity.estado.id)
            comando.Parameters.AddWithValue("@marca_id", oEntity.marca.id)
            comando.Parameters.AddWithValue("@clasificacion_id", oEntity.clasificacion.id)
            comando.Parameters.AddWithValue("@regla_de_composicion", oEntity.reglaDeComposicion)
            comando.Parameters.AddWithValue("@porcentaje_de_ganancia", oEntity.porcentajeGanancia)
            comando.Parameters.AddWithValue("@metodo_de_valoracion_id", oEntity.metodoDeValoracion.id)
            comando.Parameters.AddWithValue("@precio_coste_adquisicion", oEntity.precioCosteAdquisicion)
            comando.Parameters.AddWithValue("@coste_de_posesion", oEntity.costeDePosecion)
            comando.Parameters.AddWithValue("@coste_financiero", oEntity.costeFinanciero)
            comando.Parameters.AddWithValue("@descuento_global_id", oEntity.descuento.id)
            comando.Parameters.AddWithValue("@precio_ultima_compra", oEntity.precioUltimaCompra)
            comando.Parameters.AddWithValue("@metodo_de_reposicion_id", oEntity.metodoDeReposicion.id)
            comando.Parameters.AddWithValue("@stock_minimo", oEntity.minStock)
            comando.Parameters.AddWithValue("@stock_maximo", oEntity.maxStock)
            comando.Parameters.AddWithValue("@ciclo", oEntity.ciclo)
            comando.Parameters.AddWithValue("@familia_id", oEntity.familia.id)
            comando.Parameters.AddWithValue("@unidad", oEntity.unidad)
            comando.Parameters.AddWithValue("@pedido_automatico", oEntity.pedidoAutomatico)

            reader = comando.ExecuteReader()
            Dim idProducto As Integer = 0
            While reader.Read()
                idProducto = reader.GetValue(0)
            End While
            oEntity.id = idProducto

            reader.Close()


            If idProducto = 0 Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_CREAR_PRODUCTO))
            End If
            query = ConstantesDeDatos.CREAR_RELACION_PRODUCTO_PROVEEDOR
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            If Not oEntity.proveedores Is Nothing Then
                For Each oProv As Proveedor In oEntity.proveedores
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@producto_id", idProducto)
                    comando.Parameters.AddWithValue("@proveedor_id", oProv.id)

                    comando.ExecuteNonQuery()
                Next
            End If

            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Producto)) As Boolean

        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Producto)
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                Dim criteria As GenericQueryCriteria = queryCriteria
                If criteria.booleanCriteria = True Then 'obtener materias primas
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_TODAS_LAS_MATERIAS_PRIMAS_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oEstSuc As Producto = Nothing
                    Dim reader As SqlDataReader
                    Dim lista As New List(Of Producto)

                    comando.CommandType = CommandType.StoredProcedure

                    reader = comando.ExecuteReader()
                    While reader.Read()
                        oEstSuc = New Producto()
                        oEstSuc.id = reader.GetValue(0)
                        oEstSuc.nombre = reader.GetValue(1)
                        'solo nos interesan estos datos, porque son los que vamos a usar en la list view
                        lista.Add(oEstSuc)
                    End While
                    conexion.Close()
                    Return lista
                End If
            Else
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_PRODUCTOS_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oProducto As Producto = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of Producto)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                Dim provcriteria As New GenericQueryCriteria
                Dim instcriteria As New InstanciaDeProductoQueryCriteria
                Dim provDao As AbstractDao(Of Proveedor) = DaoFactory(Of Proveedor).obtenerInstancia().crear(GetType(Proveedor))
                Dim instDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))

                While reader.Read()
                    oProducto = New Producto()
                    oProducto.id = reader.GetValue(0)
                    oProducto.nombre = reader.GetValue(1)
                    oProducto.descripcion = reader.GetValue(2)
                    oProducto.precioCompra = reader.GetValue(3)
                    oProducto.precioVenta = reader.GetValue(4)
                    oProducto.clasificacion = New ClasificacionProducto
                    oProducto.clasificacion.id = reader.GetValue(5)
                    oProducto.costeDePosecion = reader.GetValue(6)
                    oProducto.costeFinanciero = reader.GetValue(7)
                    oProducto.descuento = New Descuento
                    oProducto.descuento.id = reader.GetValue(8)
                    oProducto.estado = New EstadoProducto
                    oProducto.estado.id = reader.GetValue(9)
                    instcriteria.idProducto = oProducto.id
                    oProducto.instanciasDeProductoActivas = instDao.obtenerMuchos(instcriteria)
                    oProducto.marca = New Marca
                    oProducto.marca.id = reader.GetValue(10)
                    oProducto.metodoDeValoracion = New ModoValoracionProducto
                    oProducto.metodoDeValoracion.id = reader.GetValue(11)
                    oProducto.moneda = New Moneda
                    oProducto.moneda.id = reader.GetValue(12)
                    oProducto.porcentajeGanancia = reader.GetValue(13)
                    oProducto.precioCosteAdquisicion = reader.GetValue(14)
                    oProducto.reglaDeComposicion = reader.GetValue(15)
                    oProducto.precioUltimaCompra = reader.GetValue(16)
                    oProducto.metodoDeReposicion = New MetodoDeReposicion
                    oProducto.metodoDeReposicion.id = reader.GetValue(17)
                    oProducto.metodoDeReposicion.metodo = reader.GetValue(18)
                    oProducto.minStock = reader.GetValue(19)
                    oProducto.maxStock = reader.GetValue(20)
                    oProducto.ciclo = reader.GetValue(21)
                    oProducto.familia = New FamiliaDeProducto
                    oProducto.familia.id = reader.GetValue(22)
                    oProducto.unidad = reader.GetValue(23)
                    oProducto.pedidoAutomatico = reader.GetValue(24)
                    provcriteria.oObject = oProducto
                    oProducto.proveedores = provDao.obtenerMuchos(provcriteria)
                    lista.Add(oProducto)
                End While
                conexion.Close()
                Return lista
            End If

        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Producto
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oProducto As Producto = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@producto_id", criteria.integerCriteria)
            comando.Parameters.AddWithValue("@nombre", criteria.stringCriteria)

            reader = comando.ExecuteReader()

            Dim provcriteria As New GenericQueryCriteria
            Dim provDao As AbstractDao(Of Proveedor) = DaoFactory(Of Proveedor).obtenerInstancia().crear(GetType(Proveedor))
            Dim instDao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim instcriteria As New InstanciaDeProductoQueryCriteria

            While reader.Read()
                oProducto = New Producto()
                oProducto.id = reader.GetValue(0)
                oProducto.nombre = reader.GetValue(1)
                oProducto.descripcion = reader.GetValue(2)
                oProducto.precioCompra = reader.GetValue(3)
                oProducto.precioVenta = reader.GetValue(4)
                oProducto.clasificacion = New ClasificacionProducto
                oProducto.clasificacion.id = reader.GetValue(5)
                oProducto.costeDePosecion = reader.GetValue(6)
                oProducto.costeFinanciero = reader.GetValue(7)
                oProducto.descuento = New Descuento
                oProducto.descuento.id = reader.GetValue(8)
                oProducto.estado = New EstadoProducto
                oProducto.estado.id = reader.GetValue(9)
                instcriteria.idProducto = oProducto.id
                oProducto.instanciasDeProductoActivas = instDao.obtenerMuchos(instcriteria)
                oProducto.marca = New Marca
                oProducto.marca.id = reader.GetValue(10)
                oProducto.metodoDeValoracion = New ModoValoracionProducto
                oProducto.metodoDeValoracion.id = reader.GetValue(11)
                oProducto.moneda = New Moneda
                oProducto.moneda.id = reader.GetValue(12)
                oProducto.porcentajeGanancia = reader.GetValue(13)
                oProducto.precioCosteAdquisicion = reader.GetValue(14)
                oProducto.reglaDeComposicion = reader.GetValue(15)
                oProducto.precioUltimaCompra = reader.GetValue(16)
                oProducto.metodoDeReposicion = New MetodoDeReposicion
                oProducto.metodoDeReposicion.id = reader.GetValue(17)
                oProducto.minStock = reader.GetValue(18)
                oProducto.maxStock = reader.GetValue(19)
                oProducto.ciclo = reader.GetValue(20)
                provcriteria.oObject = oProducto
                oProducto.proveedores = provDao.obtenerMuchos(provcriteria)
                oProducto.familia = New FamiliaDeProducto
                oProducto.familia.id = reader.GetValue(21)
                oProducto.unidad = reader.GetValue(22)
                oProducto.pedidoAutomatico = reader.GetValue(23)
                Exit While
            End While
            conexion.Close()
            Return oProducto
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try

    End Function

    Public Overrides Sub calcularVerificadorVertical()

    End Sub

    Public Overrides Function checkearVerificadorVertical() As Boolean
        Return True
    End Function

    Public Overrides Sub calcularVerificadorHoriontal()

    End Sub
End Class
