Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class ProveedorDao
    Inherits AbstractDao(Of Proveedor)

    Public Overrides Function actualizar(oEntity As Proveedor) As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.ACTUALIZAR_PROVEEDOR_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            If oEntity.nombre Is Nothing Or oEntity.estado Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            If "".Equals(oEntity.nombre) Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@calle", oEntity.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.contacto.piso)
            comando.Parameters.AddWithValue("@departamento", oEntity.contacto.departamento)
            comando.Parameters.AddWithValue("@localidad_id", oEntity.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.contacto.email)
            comando.Parameters.AddWithValue("@telefonos", oEntity.contacto.telefonos.Item(0).telefono)
            comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@cuit", oEntity.cuit)
            comando.Parameters.AddWithValue("@estado_id", oEntity.estado.id)
            comando.Parameters.AddWithValue("@proveedor_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.ACTUALIZAR_PROVEEDOR_SP)
        End Try

        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Proveedor)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Proveedor) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_PROVEEDOR_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New ExcepcionDeDatos(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA)), Me.GetType.ToString, query)
            End If
            comando.Parameters.AddWithValue("@proveedor_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Proveedor)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Proveedor) As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.CREAR_PROVEEDOR_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            If oEntity.nombre Is Nothing Or oEntity.estado Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            If "".Equals(oEntity.nombre) Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@calle", oEntity.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.contacto.piso)
            comando.Parameters.AddWithValue("@departamento", oEntity.contacto.departamento)
            comando.Parameters.AddWithValue("@localidad_id", oEntity.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.contacto.email)
            comando.Parameters.AddWithValue("@telefonos", oEntity.contacto.telefonos.Item(0).telefono)
            comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@cuit", oEntity.cuit)
            comando.Parameters.AddWithValue("@estado_id", oEntity.estado.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.CREAR_PROVEEDOR_SP)
        End Try

        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Proveedor)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Proveedor)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_PROVEEDOR_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oProveedor As Proveedor = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of Proveedor)
                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
                Dim loccriteria As New GenericQueryCriteria
                While reader.Read()
                    oProveedor = New Proveedor()
                    oProveedor.id = reader.GetValue(0)
                    oProveedor.nombre = reader.GetValue(1)
                    oProveedor.contacto = New Contacto()
                    oProveedor.contacto.calle = reader.GetValue(2)
                    oProveedor.contacto.nroPuerta = reader.GetValue(3)
                    oProveedor.contacto.departamento = reader.GetValue(4)
                    oProveedor.contacto.piso = reader.GetValue(5)
                    loccriteria.integerCriteria = reader.GetValue(6)
                    oProveedor.contacto.localidad = locdao.obtenerUno(loccriteria)
                    oProveedor.contacto.email = reader.GetValue(7)
                    oProveedor.contacto.telefonos = New List(Of Telefono)
                    Dim tel As New Telefono
                    tel.telefono = reader.GetValue(8)
                    oProveedor.contacto.telefonos.Add(tel)
                    oProveedor.cuit = reader.GetValue(9)
                    oProveedor.estado = New EstadoProveedor()
                    oProveedor.estado.id = reader.GetValue(10)
                    lista.Add(oProveedor)
                End While
                conexion.Close()
                Return lista
            Else
                Dim criteria As GenericQueryCriteria = queryCriteria
                If Not criteria.oObject Is Nothing Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_TODOS_PROVEEDORES_POR_PRODUCTO_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim oProveedor As Proveedor = Nothing
                    Dim reader As SqlDataReader
                    Dim lista As New List(Of Proveedor)
                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@producto_id", DirectCast(criteria.oObject, Producto).id)

                    reader = comando.ExecuteReader()
                    Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
                    While reader.Read()
                        oProveedor = New Proveedor()
                        oProveedor.id = reader.GetValue(0)
                        oProveedor.nombre = reader.GetValue(1)
                        'No necesitamos el resto de la informacion en esta query
                        lista.Add(oProveedor)
                    End While
                    conexion.Close()
                    Return lista
                End If
            End If

        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Proveedor
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_PROVEEDOR_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oProveedor As Proveedor = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            Dim oProv As Proveedor = criteria.oObject

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@proveedor_id", oProv.id)
            comando.Parameters.AddWithValue("@cuit", oProv.cuit)
            comando.Parameters.AddWithValue("@nombre", oProv.nombre)

            reader = comando.ExecuteReader()
            Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
            Dim loccriteria As New GenericQueryCriteria
            While reader.Read()
                oProveedor = New Proveedor()
                oProveedor.id = reader.GetValue(0)
                oProveedor.nombre = TryCast(reader.GetValue(1), String)
                oProveedor.contacto = New Contacto()
                oProveedor.contacto.id = reader.GetValue(2)
                oProveedor.contacto.calle = TryCast(reader.GetValue(3), String)
                oProveedor.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                oProveedor.contacto.departamento = TryCast(reader.GetValue(5), String)
                oProveedor.contacto.piso = reader.GetValue(6)
                loccriteria.integerCriteria = reader.GetValue(7)
                oProveedor.contacto.localidad = locdao.obtenerUno(loccriteria)
                oProveedor.contacto.email = TryCast(reader.GetValue(8), String)
                oProveedor.contacto.telefonos = New List(Of Telefono)
                Dim tel As New Telefono
                tel.telefono = TryCast(reader.GetValue(9), String)
                oProveedor.contacto.telefonos.Add(tel)
                oProveedor.cuit = TryCast(reader.GetValue(10), String)
                oProveedor.estado = New EstadoProveedor()
                oProveedor.estado.id = reader.GetValue(11)
                Exit While
            End While
            conexion.Close()
            Return oProveedor
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
