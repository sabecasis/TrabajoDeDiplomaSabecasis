Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class RolDao
    Inherits AbstractDao(Of Rol)

    Private semilla As Integer = "Rol".Length
    Public Overrides Function actualizar(oEntity As Rol) As Boolean
        If Not oEntity Is Nothing Then
            Dim query As String = ""
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.ACTUALIZAR_ROL_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                comando.Parameters.AddWithValue("@nombre", oEntity.rol)
                comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)
                comando.Parameters.AddWithValue("@id_modulo", oEntity.modulo.id)
                comando.Parameters.AddWithValue("@id_rol", oEntity.id)

                comando.ExecuteNonQuery()


                comando.Dispose()

                query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_ROLES_DE_GRUPO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_rol", oEntity.id)
                comando.ExecuteNonQuery()
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_RELACION_GRUPO_ROL_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                For Each oElemento As ElementoDeSeguridad In oEntity.grupos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@rol_id", oEntity.id)
                    comando.Parameters.AddWithValue("@grupo_id", oElemento.id)

                    comando.ExecuteNonQuery()
                Next

                query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_PERMISOS_DE_ROL_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_rol", oEntity.id)
                comando.ExecuteNonQuery()
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_RELACION_PERMISO_ROL_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                For Each oElemento As Permiso In oEntity.permisos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@rol_id", oEntity.id)
                    comando.Parameters.AddWithValue("@permiso_id", oElemento.id)

                    comando.ExecuteNonQuery()
                Next

                comando.Dispose()


                Dim digito As Integer = calcularDigitoHorizontal(oEntity)
                query = ConstantesDeDatos.GUARDAR_DGV_HORIZONTAL_ROL
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@digito", digito)
                comando.Parameters.AddWithValue("@id_rol", oEntity.id)
                comando.ExecuteNonQuery()
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

        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Rol)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Rol) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_ROLES_DE_GRUPO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@id_rol", oEntity.id)
            comando.ExecuteNonQuery()
            comando.Dispose()

            query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_PERMISOS_DE_ROL_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@id_rol", oEntity.id)
            comando.ExecuteNonQuery()
            comando.Dispose()

            query = ConstantesDeDatos.ELIMINAR_ROL_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@id_rol", oEntity.id)
            comando.ExecuteNonQuery()
            comando.Dispose()

            conexion.Close()

            calcularVerificadorVertical()

            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Rol)) As Boolean

        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Rol) As Boolean
        If Not oEntity Is Nothing Then
            Dim query As String = ""
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.GUARDAR_ROL_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                comando.Parameters.AddWithValue("@nombre", oEntity.rol)
                comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)
                comando.Parameters.AddWithValue("@id_modulo", oEntity.modulo.id)
                comando.Parameters.Add("@rol_id", SqlDbType.Decimal)
                comando.Parameters("@rol_id").Direction = ParameterDirection.Output

                comando.ExecuteNonQuery()
                Dim idRol As Integer = comando.Parameters("@rol_id").Value

                oEntity.id = idRol

                comando.Dispose()

                query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_ROLES_DE_GRUPO_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_rol", idRol)
                comando.ExecuteNonQuery()
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_RELACION_GRUPO_ROL_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                For Each oElemento As ElementoDeSeguridad In oEntity.grupos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@rol_id", idRol)
                    comando.Parameters.AddWithValue("@grupo_id", oElemento.id)

                    comando.ExecuteNonQuery()
                Next

                comando.Dispose()

                query = ConstantesDeDatos.ELIMINAR_TODOS_LOS_PERMISOS_DE_ROL_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_rol", idRol)
                comando.ExecuteNonQuery()
                comando.Dispose()

                query = ConstantesDeDatos.GUARDAR_RELACION_PERMISO_ROL_SP
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                For Each oElemento As Permiso In oEntity.permisos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@rol_id", idRol)
                    comando.Parameters.AddWithValue("@permiso_id", oElemento.id)

                    comando.ExecuteNonQuery()
                Next

                comando.Dispose()



                Dim digito As Integer = calcularDigitoHorizontal(oEntity)
                query = ConstantesDeDatos.GUARDAR_DGV_HORIZONTAL_ROL
                comando = New SqlCommand(query, conexion)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@digito", digito)
                comando.Parameters.AddWithValue("@id_rol", oEntity.id)
                comando.ExecuteNonQuery()
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
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Rol)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Rol)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand
                comando = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_ROLES_SP, conexion)
                comando.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader
                Dim oRol As Rol
                Dim listaElementos As List(Of Rol) = New List(Of Rol)
                Dim criteriaModulo As GenericQueryCriteria = New GenericQueryCriteria()
                Dim moduloDao As AbstractDao(Of Modulo) = DaoFactory(Of Modulo).obtenerInstancia().crear(GetType(Modulo))
                Dim permisosDao As AbstractDao(Of Permiso) = DaoFactory(Of Permiso).obtenerInstancia().crear(GetType(Permiso))
                Dim permisoCriteria As GenericQueryCriteria = New GenericQueryCriteria()

                conexion.Open()

                reader = comando.ExecuteReader()
                criteria = New GenericQueryCriteria
                While reader.Read()
                    oRol = New Rol()
                    oRol.id = Convert.ToInt32(reader.GetValue(0))
                    oRol.rol = reader.GetValue(1)
                    oRol.descripcion = reader.GetValue(2)
                    criteria.oObject = oRol
                    oRol.modulo = moduloDao.obtenerUno(criteria)
                    permisoCriteria.oObject = oRol
                    oRol.permisos = permisosDao.obtenerMuchos(permisoCriteria)
                    oRol.digitoHorizontal = reader.GetValue(3)
                    listaElementos.Add(oRol)
                End While

                comando.Dispose()
                conexion.Close()

                Return listaElementos
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_ROLES_POR_GRUPO_SP)
            End Try

        Else
            If Not criteria.oObject Is Nothing Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand
                    comando = New SqlCommand(ConstantesDeDatos.OBTENER_ROLES_POR_GRUPO_SP, conexion)
                    comando.Parameters.AddWithValue("@id_grupo", DirectCast(criteria.oObject, ElementoDeSeguridad).id)
                    comando.CommandType = CommandType.StoredProcedure

                    Dim reader As SqlDataReader
                    Dim oRol As Rol
                    Dim listaElementos As List(Of Rol) = New List(Of Rol)
                    Dim criteriaModulo As GenericQueryCriteria = New GenericQueryCriteria()
                    Dim moduloDao As AbstractDao(Of Modulo) = DaoFactory(Of Modulo).obtenerInstancia().crear(GetType(Modulo))
                    Dim permisosDao As AbstractDao(Of Permiso) = DaoFactory(Of Permiso).obtenerInstancia().crear(GetType(Permiso))
                    Dim permisoCriteria As GenericQueryCriteria = New GenericQueryCriteria()

                    conexion.Open()

                    reader = comando.ExecuteReader()
                    Dim cmd As SqlCommand

                    While reader.Read()
                        oRol = New Rol()
                        oRol.id = Convert.ToInt32(reader.GetValue(0))
                        oRol.rol = reader.GetValue(1)
                        oRol.descripcion = reader.GetValue(2)
                        criteria.oObject = oRol
                        oRol.modulo = moduloDao.obtenerUno(criteria)
                        permisoCriteria.oObject = oRol
                        oRol.permisos = permisosDao.obtenerMuchos(permisoCriteria)
                        oRol.digitoHorizontal = reader.GetValue(3)
                        listaElementos.Add(oRol)
                        If Not oRol Is Nothing Then
                            Dim digito As Integer = calcularDigitoHorizontal(oRol)
                            'If oRol.digitoHorizontal <> digito Then
                            '    reader.Close()
                            '    Throw New DigitoVerificadorException("Rol", oRol.id, Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL))
                            'End If
                        End If
                    End While

                    comando.Dispose()
                    conexion.Close()

                    Return listaElementos
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_ROLES_POR_GRUPO_SP)
                End Try

            End If

        End If

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Rol
        If Not queryCriteria Is Nothing Then
            Dim criteria As GenericQueryCriteria = DirectCast(queryCriteria, GenericQueryCriteria)
            If Not criteria.stringCriteria Is Nothing Then
                Dim query As String = ""
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    query = ConstantesDeDatos.OBTENER_ROL_POR_NOMBRE_SP
                    Dim comando As SqlCommand = New SqlCommand(query, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    Dim moduloDao As AbstractDao(Of Modulo) = DaoFactory(Of Modulo).obtenerInstancia().crear(GetType(Modulo))
                    Dim moduloCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    Dim oRol As Rol = Nothing
                    Dim reader As SqlDataReader
                    Dim oGrupo As Grupo
                    Dim permisoDao As AbstractDao(Of Permiso) = DaoFactory(Of Permiso).obtenerInstancia().crear(GetType(Permiso))
                    Dim permisoCriteria As GenericQueryCriteria = New GenericQueryCriteria()

                    conexion.Open()

                    comando.Parameters.AddWithValue("@nombre", criteria.stringCriteria)

                    reader = comando.ExecuteReader()

                    While reader.Read()
                        oRol = New Rol()
                        oRol.id = reader.GetValue(0)
                        oRol.rol = reader.GetValue(1)
                        oRol.descripcion = reader.GetValue(2)
                        moduloCriteria.oObject = oRol
                        oRol.modulo = moduloDao.obtenerUno(moduloCriteria)
                        permisoCriteria.oObject = oRol
                        oRol.permisos = permisoDao.obtenerMuchos(permisoCriteria)
                        oRol.digitoHorizontal = reader.GetValue(4)
                        Exit While
                    End While
                    reader.Close()
                    comando.Dispose()

                    If Not oRol Is Nothing Then
                        query = ConstantesDeDatos.OBTENER_GRUPOS_POR_ROL_SP
                        comando = New SqlCommand(query, conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@rol_id", oRol.id)

                        reader = comando.ExecuteReader()
                        oRol.grupos = New List(Of ElementoDeSeguridad)

                        While reader.Read()
                            oGrupo = New Grupo()
                            oGrupo.id = Convert.ToInt32(reader.GetValue(0))
                            oGrupo.nombre = reader.GetValue(1)
                            oRol.grupos.Add(oGrupo)
                        End While

                        comando.Dispose()
                        reader.Close()
                        If Not oRol Is Nothing Then
                            Dim digito As Integer = calcularDigitoHorizontal(oRol)
                            If oRol.digitoHorizontal <> digito Then
                                query = ConstantesDeDatos.GUARDAR_DGV_HORIZONTAL_ROL
                                comando = New SqlCommand(query, conexion)
                                comando.CommandType = CommandType.StoredProcedure

                                comando.Parameters.AddWithValue("@digito", digito)
                                comando.Parameters.AddWithValue("@id_rol", oRol.id)
                                comando.ExecuteNonQuery()
                                comando.Dispose()
                                conexion.Close()
                                Throw New DigitoVerificadorException("Rol", oRol.id, Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL))
                            End If
                        End If
                    End If

                    conexion.Close()
                    Return oRol
                Catch ex As DigitoVerificadorException
                    Throw ex
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
                End Try

            End If
        End If

        Return Nothing
    End Function


    Private Function calcularDigitoHorizontal(oRol As Rol) As Integer
        Dim resultado As Integer = 0
        resultado = resultado + oRol.id + oRol.rol.Length + oRol.modulo.id + oRol.rol.GetHashCode
        Return resultado
    End Function


    Public Overrides Function checkearVerificadorVertical() As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.CHECKEAR_VERIFICADOR_VERTICAL_ROL_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            Dim ok As Integer = comando.ExecuteScalar()

            comando.Dispose()
            conexion.Close()

            Return ok > 0

        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.CHECKEAR_VERIFICADOR_VERTICAL_ROL_SP)
        End Try

    End Function

    Public Overrides Sub calcularVerificadorVertical()
        Dim query As String = ConstantesDeDatos.GUARDAR_DGV_VERTICAL_ROL
        Try

            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@semilla", semilla)
            comando.Parameters.AddWithValue("@entidad", "Rol")

            comando.ExecuteNonQuery()
            comando.Dispose()

            conexion.Close()
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.FullName, query)
        End Try

    End Sub

    Public Overrides Sub calcularVerificadorHoriontal()
        Dim query As String = ConstantesDeDatos.GUARDAR_DGV_HORIZONTAL_ROL
        Try
            Dim listaDeRoles As List(Of Rol)
            listaDeRoles = Me.obtenerMuchos(Nothing)
            Dim digito As Integer
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()
            If Not listaDeRoles Is Nothing Then
                For Each oRol In listaDeRoles
                    digito = calcularDigitoHorizontal(oRol)
                    oRol.digitoHorizontal = digito
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@digito", digito)
                    comando.Parameters.AddWithValue("@id_rol", oRol.id)
                    comando.ExecuteNonQuery()
                Next
                comando.Dispose()
                conexion.Close()
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.FullName, query)
        End Try

    End Sub
End Class
