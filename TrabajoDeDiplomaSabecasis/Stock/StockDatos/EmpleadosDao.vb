Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class EmpleadosDao
    Inherits AbstractDao(Of Empleado)

    Public Overrides Function actualizar(oEntity As Empleado) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_EMPLEADO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim telefonos As String
            telefonos = oEntity.persona.contacto.telefonos.Item(0).telefono & ","
            Dim idsTipoTelefono As String
            idsTipoTelefono = oEntity.persona.contacto.telefonos.Item(0).tipoTelefono.id & ","

            conexion.Open()

            comando.Parameters.AddWithValue("@calle", oEntity.persona.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.persona.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.persona.contacto.piso)

            If Not oEntity.persona.contacto.departamento Is Nothing Then
                comando.Parameters.AddWithValue("@departamento", oEntity.persona.contacto.departamento)
            Else
                comando.Parameters.AddWithValue("@departamento", " ")
            End If

            comando.Parameters.AddWithValue("@localidad_id", oEntity.persona.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.persona.contacto.email)
            comando.Parameters.AddWithValue("@telefonos", telefonos)
            comando.Parameters.AddWithValue("@ids_tipo_telefono", idsTipoTelefono)
            comando.Parameters.AddWithValue("@nro_empleado", oEntity.nroEmpleado)
            comando.Parameters.AddWithValue("@puesto_empleado_id", oEntity.puesto.id)
            comando.Parameters.AddWithValue("@nombre", oEntity.persona.nombre)
            comando.Parameters.AddWithValue("@apellido", oEntity.persona.apellido)
            comando.Parameters.AddWithValue("@nro_documento", oEntity.persona.documento)
            comando.Parameters.AddWithValue("@tipo_documento_id", oEntity.persona.tipoDocumento.id)
            comando.Parameters.AddWithValue("@id_empleado", oEntity.id)

            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.ELIMINAR_DEPOSITO_POR_EMPLEADO
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@empleado_id", oEntity.id)

            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.CREAR_RELACION_EMPLEADO_DEPOSITO
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            For Each dep As Deposito In oEntity.depositos
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@empleado_id", oEntity.id)
                comando.Parameters.AddWithValue("@deposito_id", dep.id)
                comando.ExecuteNonQuery()
            Next


            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Empleado)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Empleado) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_EMPLEADO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            comando.Parameters.AddWithValue("@id_empleado", oEntity.id)

            comando.ExecuteNonQuery()
            comando.Dispose()

            query = ConstantesDeDatos.OBTENER_USUARIOS_DE_EMPLEADO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@id_empleado", oEntity.id)

            Dim reader As SqlDataReader
            reader = comando.ExecuteReader()
            Dim listaUsuarios As List(Of Integer) = New List(Of Integer)

            While reader.Read()
                listaUsuarios.Add(reader.GetValue(0))
            End While

            comando.Dispose()
            reader.Close()

            query = ConstantesDeDatos.ELIMINAR_USUARIO_SP
            comando = New SqlCommand(query, conexion)

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add(New SqlParameter("@id_usuario", System.Data.SqlDbType.Decimal))
            For Each id In listaUsuarios
                comando.Parameters(0).Value = id
                comando.ExecuteNonQuery()
            Next


            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try
        Return False
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Empleado)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Empleado) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_EMPLEADO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim telefonos As String
            telefonos = oEntity.persona.contacto.telefonos.Item(0).telefono & ","
            Dim idsTipoTelefono As String
            idsTipoTelefono = oEntity.persona.contacto.telefonos.Item(0).tipoTelefono.id & ","

            conexion.Open()

            comando.Parameters.AddWithValue("@calle", oEntity.persona.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.persona.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.persona.contacto.piso)

            If Not oEntity.persona.contacto.departamento Is Nothing Then
                comando.Parameters.AddWithValue("@departamento", oEntity.persona.contacto.departamento)
            Else
                comando.Parameters.AddWithValue("@departamento", " ")
            End If

            comando.Parameters.AddWithValue("@localidad_id", oEntity.persona.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.persona.contacto.email)
            comando.Parameters.AddWithValue("@telefonos", telefonos)
            comando.Parameters.AddWithValue("@ids_tipo_telefono", idsTipoTelefono)
            comando.Parameters.AddWithValue("@nro_empleado", oEntity.nroEmpleado)
            comando.Parameters.AddWithValue("@puesto_empleado_id", oEntity.puesto.id)
            comando.Parameters.AddWithValue("@nombre", oEntity.persona.nombre)
            comando.Parameters.AddWithValue("@apellido", oEntity.persona.apellido)
            comando.Parameters.AddWithValue("@nro_documento", oEntity.persona.documento)
            comando.Parameters.AddWithValue("@tipo_documento_id", oEntity.persona.tipoDocumento.id)
            comando.Parameters.Add("@id_empleado", SqlDbType.Decimal)
            comando.Parameters("@id_empleado").Direction = ParameterDirection.Output

            comando.ExecuteNonQuery()

            Dim idEmpleado As Integer = Convert.ToInt32(comando.Parameters("@id_empleado").Value)
            oEntity.id = idEmpleado

            query = ConstantesDeDatos.ELIMINAR_DEPOSITO_POR_EMPLEADO
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@empleado_id", oEntity.id)

            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.CREAR_RELACION_EMPLEADO_DEPOSITO
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            For Each dep As Deposito In oEntity.depositos
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@empleado_id", oEntity.id)
                comando.Parameters.AddWithValue("@deposito_id", dep.id)
                comando.ExecuteNonQuery()
            Next

            conexion.Close()
            comando.Dispose()
            Return (idEmpleado > 0)
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try

    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Empleado)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Empleado)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_EMPLEADOS_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim empleados As List(Of Empleado) = New List(Of Empleado)
                Dim empleado As Empleado

                conexion.Open()

                comando.CommandType = CommandType.StoredProcedure

                dataReader = comando.ExecuteReader()

                While dataReader.Read
                    empleado = New Empleado()
                    If Not IsDBNull(empleado.id) Then
                        empleado.id = dataReader.GetValue(0)
                    Else
                        empleado.id = 0
                    End If
                    If Not IsDBNull(dataReader.GetValue(1)) Then
                        empleado.nroEmpleado = dataReader.GetValue(1)
                    Else
                        empleado.nroEmpleado = ""
                    End If

                    'persona y demases se llaman a sus respectivos dao. TODO
                    empleados.Add(empleado)
                End While

                conexion.Close()
                comando.Dispose()
                dataReader.Close()

                Return empleados
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_EMPLEADOS_SP)
            End Try
        Else
            Try
                If Not criteria.oObject Is Nothing Then
                    Dim oUsuario As Usuario = DirectCast(criteria.oObject, Usuario)
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_EMPLEADOS_POR_USUARIO_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim empleados As List(Of Empleado) = New List(Of Empleado)
                    Dim empleado As Empleado

                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@id_usuario", oUsuario.id)

                    dataReader = comando.ExecuteReader()

                    Dim depDao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia().crear(GetType(Deposito))
                    Dim depCriteria As New GenericQueryCriteria
                    While dataReader.Read
                        empleado = New Empleado()
                        empleado.id = dataReader.GetValue(0)
                        empleado.nroEmpleado = dataReader.GetValue(1)
                        depCriteria.integerCriteria = empleado.id
                        depCriteria.booleanCriteria = True
                        depCriteria.stringCriteria = "E"
                        empleado.depositos = depDao.obtenerMuchos(depCriteria)
                        'persona y demases se llaman a sus respectivos dao. TODO
                        empleados.Add(empleado)
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()
                    Return empleados
                End If
            Catch ex As Exception
                Throw New ExcepcionDeDatos(ex, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_EMPLEADOS_POR_USUARIO_SP)
            End Try
        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Empleado
        If Not queryCriteria Is Nothing Then
            Dim criteria As GenericQueryCriteria = queryCriteria
            Try
                If Not criteria.oObject Is Nothing Then
                    If Not DirectCast(criteria.oObject, Persona).documento.Equals("") Then
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_NRO_EMPLEADO_POR_DNI_SP, conexion)
                        Dim dataReader As SqlDataReader

                        conexion.Open()

                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@nro_documento", DirectCast(criteria.oObject, Persona).documento.Trim)

                        dataReader = comando.ExecuteReader()

                        While dataReader.Read
                            criteria.stringCriteria = dataReader.GetValue(0)
                            Exit While
                        End While

                        conexion.Close()
                        comando.Dispose()
                        dataReader.Close()
                    End If

                End If
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_NRO_EMPLEADO_POR_DNI_SP)
            End Try

            If Not criteria.stringCriteria Is Nothing Then
                If Not criteria.stringCriteria.Equals("") Then
                    Try
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_EMPLEADO_POR_NRO_EMPLEADO_SP, conexion)
                        Dim dataReader As SqlDataReader
                        Dim empleado As Empleado = Nothing
                        Dim personDao As AbstractDao(Of Persona) = DaoFactory(Of Persona).obtenerInstancia().crear(GetType(Persona))
                        Dim personCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                        conexion.Open()

                        comando.CommandType = CommandType.StoredProcedure

                        comando.Parameters.AddWithValue("@nro_empleado", criteria.stringCriteria)

                        dataReader = comando.ExecuteReader()
                        Dim depDao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia().crear(GetType(Deposito))
                        Dim depCriteria As New GenericQueryCriteria

                        While dataReader.Read
                            empleado = New Empleado()
                            empleado.id = dataReader.GetValue(0)
                            empleado.nroEmpleado = dataReader.GetValue(1)
                            personCriteria.integerCriteria = dataReader.GetValue(2)
                            empleado.persona = personDao.obtenerUno(personCriteria)
                            empleado.puesto = New Puesto()
                            empleado.puesto.id = dataReader.GetValue(3)
                            depCriteria.integerCriteria = empleado.id
                            depCriteria.booleanCriteria = True
                            depCriteria.stringCriteria = "E"
                            empleado.depositos = depDao.obtenerMuchos(depCriteria)
                            Exit While
                        End While

                        conexion.Close()
                        comando.Dispose()
                        dataReader.Close()

                        Return empleado
                    Catch e As Exception
                        Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_EMPLEADO_POR_NRO_EMPLEADO_SP)
                    End Try
                End If

            End If

        End If

        Return Nothing
    End Function

    Public Function obtenerProximoNroEmpleado(idPuesto As Integer) As String
        Try
            Dim nroEmpleado As String

            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_PROXIMO_NRO_EMPLEADO_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            comando.Parameters.AddWithValue("@id_puesto", idPuesto)
            comando.Parameters.Add("@nro_empleado", SqlDbType.VarChar)
            comando.Parameters("@nro_empleado").Direction = ParameterDirection.Output
            comando.Parameters("@nro_empleado").Size = 50

            comando.ExecuteNonQuery()
            nroEmpleado = comando.Parameters("@nro_empleado").Value

            conexion.Close()
            comando.Dispose()

            Return nroEmpleado
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_PROXIMO_NRO_EMPLEADO_SP)
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
