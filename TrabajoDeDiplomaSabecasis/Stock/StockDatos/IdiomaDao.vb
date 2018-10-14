Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class IdiomaDao
    Inherits AbstractDao(Of Idioma)

    Public Overrides Function actualizar(oEntity As Idioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Idioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Idioma) As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.ELIMINAR_IDIOMA_SP, conexion)

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idioma_id", oEntity.id)
            conexion.Open()

            comando.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, ConstantesDeDatos.ELIMINAR_IDIOMA_SP)
        End Try
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Idioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Idioma) As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.GUARDAR_IDIOMA_SP, conexion)
            Dim dataReader As SqlDataReader
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idioma", oEntity.cultura.DisplayName)
            comando.Parameters.AddWithValue("@cultura", oEntity.cultura.Name)
            comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)

            dataReader = comando.ExecuteReader()
            While dataReader.Read
                oEntity.id = Convert.ToInt32(dataReader.GetValue(0))
                Exit While
            End While

            conexion.Close()
            comando.Dispose()

            Return (Not oEntity.id.Equals(0))
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.GUARDAR_IDIOMA_SP)
        End Try

    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Idioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Idioma)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_IDIOMAS_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim idiomaList As List(Of Idioma) = New List(Of Idioma)
                Dim oIdioma As Idioma

                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    oIdioma = New Idioma()
                    oIdioma.id = Convert.ToInt32(dataReader.GetValue(0))
                    oIdioma.descripcion = dataReader.GetValue(1).ToString
                    oIdioma.cultura = New System.Globalization.CultureInfo(dataReader.GetValue(2).ToString)
                    idiomaList.Add(oIdioma)
                End While

                conexion.Close()
                comando.Dispose()
                Return idiomaList
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_IDIOMAS_SP)
            End Try

        Else
            'obtener segun criteria
        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Idioma
        Dim criteria As GenericQueryCriteria = queryCriteria
        If Not criteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_IDIOMA_POR_NOMBRE_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim idiomaList As List(Of Idioma) = New List(Of Idioma)
                Dim oIdioma As Idioma = Nothing

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre", criteria.stringCriteria)
                conexion.Open()

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    oIdioma = New Idioma()
                    oIdioma.id = Convert.ToInt32(dataReader.GetValue(0))
                    oIdioma.descripcion = dataReader.GetValue(1).ToString
                    oIdioma.cultura = New System.Globalization.CultureInfo(dataReader.GetValue(2).ToString)
                    Exit While
                End While

                conexion.Close()
                comando.Dispose()
                Return oIdioma
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_IDIOMAS_SP)
            End Try

        Else
            'obtener segun criteria
        End If
        Return Nothing
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
