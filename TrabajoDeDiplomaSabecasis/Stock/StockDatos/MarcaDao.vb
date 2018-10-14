Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class MarcaDao
    Inherits AbstractDao(Of Marca)


    Public Overrides Function actualizar(oEntity As Marca) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_MARCA
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.marca Is Nothing Or "".Equals(oEntity.marca) Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.MARCA_NULA))
            End If
            If oEntity.id = 0 Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA))
            End If
            comando.Parameters.AddWithValue("@marca", oEntity.marca)
            comando.Parameters.AddWithValue("@marca_id", oEntity.id)

            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Marca)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Marca) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_MARCA_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New ExcepcionDeDatos(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA)), Me.GetType.ToString, query)
            End If
            comando.Parameters.AddWithValue("@marca_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Marca)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Marca) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_MARCA_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.marca Is Nothing Or "".Equals(oEntity.marca) Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.MARCA_NULA))
            End If
            comando.Parameters.AddWithValue("@marca", oEntity.marca)
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Marca)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Marca)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODAS_LAS_MARCAS_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As Marca = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of Marca)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New Marca()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.marca = reader.GetValue(1)
                    lista.Add(oEstSuc)
                End While
                conexion.Close()
                Return lista
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Marca
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_MARCA_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oMarca As Marca = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@marca_id", criteria.integerCriteria)
            comando.Parameters.AddWithValue("@marca", criteria.stringCriteria)

            reader = comando.ExecuteReader()
            While reader.Read()
                oMarca = New Marca()
                oMarca.id = reader.GetValue(0)
                oMarca.marca = reader.GetValue(1)
                Exit While
            End While
            conexion.Close()
            Return oMarca
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
