Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class UsuarioDao
    Inherits AbstractDao(Of Usuario)

    Private semilla As Integer = "Usuario".Length

    Public Overrides Function actualizar(oEntity As Usuario) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_USUARIO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            comando.Parameters.AddWithValue("@usuario_nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@pregunta", oEntity.preguntaSecreta)
            comando.Parameters.AddWithValue("@respuesta", oEntity.respuestaSecreta)
            comando.Parameters.AddWithValue("@bloqueado", Convert.ToByte(oEntity.bloqueado))
            comando.Parameters.AddWithValue("@contador", oEntity.contadorMalaPassword)
            comando.Parameters.AddWithValue("@usuario_id", oEntity.id)
            comando.Parameters.AddWithValue("@password", oEntity.password)
            comando.Parameters.AddWithValue("@cambiar_password", oEntity.esCambioDePassword)



            comando.ExecuteNonQuery()

            comando.Dispose()

            query = ConstantesDeDatos.ELMINAR_RELACION_EMPLEADO_USUARIO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@id_usuario", oEntity.id)

            comando.ExecuteNonQuery()

            comando.Dispose()

            query = ConstantesDeDatos.GUARDAR_RELACION_USUARIO_EMPLEADOS_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            For Each oEmpleado As Empleado In oEntity.empleados
                comando.Parameters.Clear()

                comando.Parameters.AddWithValue("@id_usuario", oEntity.id)
                comando.Parameters.AddWithValue("@id_empleado", oEmpleado.id)

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

            comando.Dispose()
            conexion.Close()

            calcularVerificadorVertical()

            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Usuario)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Usuario) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_USUARIO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@id_usuario", oEntity.id)
            conexion.Open()

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True

        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
        Return False
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Usuario)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Usuario) As Boolean
        If Not oEntity Is Nothing Then
            Dim query As String = ""
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.GUARDAR_USUARIO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim idUsuario As Integer

                conexion.Open()


                comando.Parameters.AddWithValue("@usuario_nombre", oEntity.nombre)
                comando.Parameters.AddWithValue("@password", oEntity.password)
                comando.Parameters.AddWithValue("@pregunta", oEntity.preguntaSecreta)
                comando.Parameters.AddWithValue("@respuesta", oEntity.respuestaSecreta)
                comando.Parameters.Add("@usuario_id", SqlDbType.Decimal)
                comando.Parameters("@usuario_id").Direction = ParameterDirection.Output

                comando.ExecuteNonQuery()
                idUsuario = comando.Parameters("@usuario_id").Value
                oEntity.id = idUsuario
                comando.Dispose()

                If idUsuario <> 0 Then
                    query = ConstantesDeDatos.GUARDAR_RELACION_USUARIO_EMPLEADOS_SP
                    comando = New SqlCommand(query, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    For Each oEmpleado As Empleado In oEntity.empleados
                        comando.Parameters.Clear()

                        comando.Parameters.AddWithValue("@id_usuario", idUsuario)
                        comando.Parameters.AddWithValue("@id_empleado", oEmpleado.id)

                        comando.ExecuteNonQuery()
                    Next
                    comando.Dispose()
                End If

                query = ConstantesDeDatos.GUARDAR_RELACION_USUARIO_GRUPO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@usuario_id", idUsuario)
                comando.Parameters.AddWithValue("@grupo_id", 1)
                comando.ExecuteNonQuery()
                comando.Dispose()

                Dim digito As Integer = calcularDigitoVerificadorHorizontal(oEntity)

                query = ConstantesDeDatos.GUARDAR_DGV_USUARIO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@digito", digito)
                comando.Parameters.AddWithValue("@id_usuario", oEntity.id)
                comando.ExecuteNonQuery()
                comando.Dispose()

                comando.Dispose()

                conexion.Close()

                calcularVerificadorVertical()

                Return True
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
            End Try

        Else
            Return False
        End If

    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Usuario)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Usuario)
        If queryCriteria Is Nothing Then
            Try
                Dim listaUsuarios As New List(Of Usuario)
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_USUARIOS_GRUPOS_SP, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim oUsuario As Usuario = Nothing
                    Dim reader As SqlDataReader
                    conexion.Open()

                    reader = comando.ExecuteReader()

                    While reader.Read()
                    oUsuario = New Usuario()
                    If Not IsDBNull(reader.GetValue(0)) Then
                        oUsuario.id = Convert.ToInt32(reader.GetValue(0))
                    Else
                        oUsuario.id = 0
                    End If
                    If Not IsDBNull(reader.GetValue(1)) Then
                        oUsuario.nombre = reader.GetValue(1)
                    Else
                        oUsuario.nombre = ""
                    End If
                    If Not IsDBNull(reader.GetValue(4)) Then
                        oUsuario.contadorMalaPassword = Convert.ToInt32(reader.GetValue(4))
                    Else
                        oUsuario.contadorMalaPassword = 0
                    End If
                    If Not IsDBNull(reader.GetValue(5)) Then
                        oUsuario.bloqueado = Convert.ToBoolean(reader.GetValue(5))
                    Else
                        oUsuario.bloqueado = False
                    End If
                    If Not IsDBNull(reader.GetValue(2)) Then
                        oUsuario.preguntaSecreta = reader.GetValue(2)
                    Else
                        oUsuario.preguntaSecreta = ""
                    End If
                    If Not IsDBNull(reader.GetValue(3)) Then
                        oUsuario.respuestaSecreta = reader.GetValue(3)
                    Else
                        oUsuario.respuestaSecreta = ""
                    End If
                    If Not IsDBNull(reader.GetValue(7)) Then
                        oUsuario.password = reader.GetValue(7)
                    Else
                        oUsuario.password = ""
                    End If
                    If Not IsDBNull(reader.GetValue(7)) Then
                        oUsuario.digitoHorizontal = reader.GetValue(6)
                    Else
                        oUsuario.digitoHorizontal = 0
                    End If
                    listaUsuarios.Add(oUsuario)
                End While

                    comando.Dispose()
                    conexion.Close()
                    Return listaUsuarios
            Catch ex As DigitoVerificadorException
                Throw ex
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_USUARIOS_GRUPOS_SP)
            End Try

        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Usuario
        If Not queryCriteria Is Nothing Then
            Try
                Dim criteria As GenericQueryCriteria = DirectCast(queryCriteria, GenericQueryCriteria)
                If Not criteria.stringCriteria Is Nothing Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_USUARIO_POR_NOMBRE_SP, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim oUsuario As Usuario = Nothing
                    Dim reader As SqlDataReader
                    Dim empleadosDao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
                    Dim empleadosCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    conexion.Open()

                    comando.Parameters.AddWithValue("@usuario_nombre", criteria.stringCriteria)

                    reader = comando.ExecuteReader()

                    While reader.Read()
                        oUsuario = New Usuario()
                        oUsuario.id = Convert.ToInt32(reader.GetValue(0))
                        oUsuario.nombre = reader.GetValue(6)
                        oUsuario.contadorMalaPassword = Convert.ToInt32(reader.GetValue(1))
                        oUsuario.bloqueado = Convert.ToBoolean(reader.GetValue(2))
                        oUsuario.preguntaSecreta = reader.GetValue(3)
                        oUsuario.respuestaSecreta = reader.GetValue(4)
                        oUsuario.password = reader.GetValue(5)
                        oUsuario.digitoHorizontal = reader.GetValue(7)
                        oUsuario = obtenerUsuariosGrups(oUsuario)
                        empleadosCriteria.oObject = oUsuario
                        oUsuario.empleados = empleadosDao.obtenerMuchos(empleadosCriteria)
                        Exit While
                    End While

                    If Not oUsuario Is Nothing Then
                        Dim digito As Integer = calcularDigitoVerificadorHorizontal(oUsuario)
                        If oUsuario.digitoHorizontal <> digito Then
                            Throw New DigitoVerificadorException("Usuario", oUsuario.id, Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL))
                        End If
                    End If

                    comando.Dispose()
                    conexion.Close()
                    Return oUsuario
                End If
            Catch ex As DigitoVerificadorException
                Throw ex
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_USUARIO_POR_NOMBRE_SP)
            End Try

        End If
        Return Nothing
    End Function

    Private Function obtenerUsuariosGrups(oElemento As ElementoDeSeguridad) As ElementoDeSeguridad
        Try
            Dim dao As AbstractDao(Of ElementoDeSeguridad) = DaoFactory(Of ElementoDeSeguridad).obtenerInstancia().crear(GetType(ElementoDeSeguridad))
            Dim queryCriteria As GenericQueryCriteria = New GenericQueryCriteria()
            queryCriteria.oObject = oElemento
            queryCriteria.booleanCriteria = False 'buscar por orden ascendente en el arbol TODO: Agregar profundidad de arbol por defecto
            Dim listaElementos As List(Of ElementoDeSeguridad) = dao.obtenerMuchos(queryCriteria)
            If Not listaElementos Is Nothing And listaElementos.Count > 0 Then
                oElemento.elementos = listaElementos
                For Each elemento As ElementoDeSeguridad In listaElementos
                    obtenerUsuariosGrups(elemento)
                Next
            End If

            Return oElemento
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, "obtenerUsuariosGrups")
        End Try
    End Function

    Public Function calcularDigitoVerificadorHorizontal(oUsuario As Usuario) As Integer
        Dim result As Integer = 0
        result = result + oUsuario.id + oUsuario.nombre.Length + oUsuario.password.Length + oUsuario.preguntaSecreta.Length
        result = result + oUsuario.respuestaSecreta.Length
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
            conexion.Close()

            Return ok > 0
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.CHECKEAR_VERIFICADOR_VERTICAL_USUARIO_SP)
        End Try


    End Function

    Public Overrides Sub calcularVerificadorVertical()
        Dim query As String = ConstantesDeDatos.GUARDAR_DGV_VERTICAL_USUARIO_SP
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@semilla", semilla)
            comando.Parameters.AddWithValue("@entidad", "Usuario")

            comando.ExecuteNonQuery()
            comando.Dispose()

            conexion.Close()
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.FullName, query)
        End Try
    End Sub

    Public Overrides Sub calcularVerificadorHoriontal()
        Dim query As String = ConstantesDeDatos.GUARDAR_DGV_HORIZONTAL_USUARIO_SP
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            Dim listaUsuario As List(Of Usuario)
            listaUsuario = Me.obtenerMuchos(Nothing)
            Dim digito As Integer
            Dim grupoDao As New GrupoDao()
            Dim oGrupo As Grupo
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            If Not listaUsuario Is Nothing Then
                For Each oUsuario In listaUsuario
                    If "".Equals(oUsuario.password) Then
                        oGrupo = New Grupo
                        oGrupo.nombre = oUsuario.nombre
                        digito = grupoDao.calcularDigitoVerificadorHorizontal(oGrupo)
                    Else
                        digito = calcularDigitoVerificadorHorizontal(oUsuario)
                    End If
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@digito", digito)
                    comando.Parameters.AddWithValue("@id_usuario", oUsuario.id)
                    comando.ExecuteNonQuery()
                Next
            End If
            comando.Dispose()
            conexion.Close()
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.FullName, query)
        End Try
    End Sub
End Class
