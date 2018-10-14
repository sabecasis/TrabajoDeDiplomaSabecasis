Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class FamiliaDeProductoDao
    Inherits AbstractDao(Of FamiliaDeProducto)

    Public Overrides Function actualizar(oEntity As FamiliaDeProducto) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_FAMILIA_DE_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure

            If oEntity.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA))
            End If
            comando.Parameters.AddWithValue("@familia", oEntity.familia)
            comando.Parameters.AddWithValue("@familia_id", oEntity.id)

            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of FamiliaDeProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As FamiliaDeProducto) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_FAMILIA_DE_PRODUCTO_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New ExcepcionDeDatos(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA)), Me.GetType.ToString, query)
            End If
            comando.Parameters.AddWithValue("@familia_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False

    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of FamiliaDeProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As FamiliaDeProducto) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_FAMILIA_DE_PRODUCTOS_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@familia", oEntity.familia)
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of FamiliaDeProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of FamiliaDeProducto)
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.OBTENER_TODAS_LAS_FAMILIAS_DE_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oFamilia As FamiliaDeProducto = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            reader = comando.ExecuteReader()
            Dim lista As New List(Of FamiliaDeProducto)
            While reader.Read()
                oFamilia = New FamiliaDeProducto()
                oFamilia.id = reader.GetValue(0)
                oFamilia.familia = reader.GetValue(1)
                lista.Add(oFamilia)
            End While
            conexion.Close()
            Return lista
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As FamiliaDeProducto
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_FAMILIA_DE_PRODUCTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oFamilia As FamiliaDeProducto = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@familia_id", criteria.integerCriteria)
            comando.Parameters.AddWithValue("@familia", criteria.stringCriteria)

            reader = comando.ExecuteReader()
            While reader.Read()
                oFamilia = New FamiliaDeProducto()
                oFamilia.id = reader.GetValue(0)
                oFamilia.familia = reader.GetValue(1)
                Exit While
            End While
            conexion.Close()
            Return oFamilia
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
