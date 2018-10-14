Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class GrupoDao
    Inherits AbstractDao(Of Grupo)

    Private semilla As Integer = "Usuario".Length


    Public Overrides Function actualizar(oEntity As Grupo) As Boolean
        Dim query As String = ""
        Try
            query = ConstantesDeDatos.ACTUALIZAR_GRUPO_SP
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@id_grupo", oEntity.id)

            comando.ExecuteNonQuery()

            comando.Dispose()
            query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_GRUPOS_DE_USUARIO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@usuario_id", oEntity.id)

            comando.ExecuteNonQuery()

            comando.Dispose()
            query = ConstantesDeDatos.GUARDAR_RELACION_USUARIO_GRUPO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            For Each oElemento As Grupo In oEntity.elementos
                comando.Parameters.Clear()

                comando.Parameters.AddWithValue("@usuario_id", oElemento.id)
                comando.Parameters.AddWithValue("@grupo_id", oEntity.id)

                comando.ExecuteNonQuery()
            Next

            Dim digito As Integer = calcularDigitoVerificadorHorizontal(oEntity)
            query = ConstantesDeDatos.GUARDAR_DGV_USUARIO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@digito", digito)
            comando.Parameters.AddWithValue("@id_usuario", oEntity.id)
            comando.ExecuteNonQuery()
            comando.Dispose()

            query = ConstantesDeDatos.GUARDAR_DGV_VERTICAL_USUARIO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@semilla", semilla)
            comando.Parameters.AddWithValue("@entidad", "Usuario")

            comando.ExecuteNonQuery()
            comando.Dispose()

            comando.Dispose()
            conexion.Close()
            Return True

        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try

    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Grupo)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Grupo) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Grupo)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Grupo) As Boolean
        If Not oEntity Is Nothing Then
            Dim query As String = ""
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.GUARDAR_GRUPO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
                comando.Parameters.Add("@grupo_id", SqlDbType.Decimal)
                comando.Parameters("@grupo_id").Direction = ParameterDirection.Output

                comando.ExecuteNonQuery()
                Dim idGrupo As Integer = comando.Parameters("@grupo_id").Value

                oEntity.id = idGrupo

                comando.Dispose()
                query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_GRUPOS_DE_USUARIO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@usuario_id", idGrupo)
                comando.ExecuteNonQuery()
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_RELACION_USUARIO_GRUPO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                For Each oElemento As ElementoDeSeguridad In oEntity.elementos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@usuario_id", oElemento.id)
                    comando.Parameters.AddWithValue("@grupo_id", idGrupo)

                    comando.ExecuteNonQuery()
                Next
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_DGV_USUARIO_SP
                Dim digito As Integer = calcularDigitoVerificadorHorizontal(oEntity)
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@digito", digito)
                comando.Parameters.AddWithValue("@id_usuario", oEntity.id)
                comando.ExecuteNonQuery()
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_DGV_VERTICAL_USUARIO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@semilla", semilla)
                comando.Parameters.AddWithValue("@entidad", "Usuario")

                comando.ExecuteNonQuery()
                comando.Dispose()


                conexion.Close()

                Return True
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
            End Try

        Else
            Return False
        End If

        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Grupo)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Grupo)
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Grupo
        If Not queryCriteria Is Nothing Then
            Try
                Dim criteria As GenericQueryCriteria = DirectCast(queryCriteria, GenericQueryCriteria)
                If Not criteria.stringCriteria Is Nothing Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_USUARIO_POR_NOMBRE_SP, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim oGrupo As Grupo = Nothing
                    Dim reader As SqlDataReader
                    Dim elementosDao As AbstractDao(Of ElementoDeSeguridad) = DaoFactory(Of ElementoDeSeguridad).obtenerInstancia().crear(GetType(ElementoDeSeguridad))
                    Dim elementosCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    elementosCriteria.booleanCriteria = False 'obtener por orden descendente
                    conexion.Open()

                    comando.Parameters.AddWithValue("@usuario_nombre", criteria.stringCriteria.Trim)

                    reader = comando.ExecuteReader()

                    While reader.Read()
                        oGrupo = New Grupo()
                        oGrupo.id = Convert.ToInt32(reader.GetValue(0))
                        oGrupo.nombre = criteria.stringCriteria
                        oGrupo.digitoHorizontal = reader.GetValue(7)
                        elementosCriteria.oObject = oGrupo
                        elementosCriteria.booleanCriteria = True
                        oGrupo.elementos = elementosDao.obtenerMuchos(elementosCriteria)
                        Exit While
                    End While

                    If Not oGrupo Is Nothing Then
                        Dim digito As Integer = calcularDigitoVerificadorHorizontal(oGrupo)
                        If oGrupo.digitoHorizontal <> digito Then
                            Throw New DigitoVerificadorException("Grupo", oGrupo.id, Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL))
                        End If
                    End If


                    comando.Dispose()
                    conexion.Close()
                    Return oGrupo
                End If
            Catch ex As DigitoVerificadorException
                Throw ex
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_USUARIO_POR_NOMBRE_SP)
            End Try

        End If
        Return Nothing
    End Function

    Public Function calcularDigitoVerificadorHorizontal(oUsuario As Grupo) As Integer
        Dim result As Integer = 0
        result = result + oUsuario.id + oUsuario.nombre.Length
        result = result + oUsuario.nombre.GetHashCode
        Return result
    End Function

    Public Overrides Function checkearVerificadorVertical() As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.CHECKEAR_VERIFICADOR_VERTICAL_USUARIO_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            Dim ok As Integer = comando.ExecuteScalar()

            comando.Dispose()

            Return ok > 0
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.CHECKEAR_VERIFICADOR_VERTICAL_USUARIO_SP)
        End Try


    End Function

    Public Overrides Sub calcularVerificadorVertical()
    End Sub

    Public Overrides Sub calcularVerificadorHoriontal()
      
    End Sub
End Class
