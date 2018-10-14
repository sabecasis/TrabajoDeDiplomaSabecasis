Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class DepositoDao
    Inherits AbstractDao(Of Deposito)

    Public Overrides Function actualizar(oEntity As Deposito) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_DEPOSITO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()



            comando.CommandType = CommandType.StoredProcedure
            If oEntity.nomber Is Nothing Or oEntity.contacto.calle Is Nothing Or oEntity.contacto.nroPuerta Is Nothing Or oEntity.contacto.localidad Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            If oEntity.id = 0 Or "".Equals(oEntity.nomber) Or "".Equals(oEntity.contacto.calle) Or "".Equals(oEntity.contacto.nroPuerta) Or "".Equals(oEntity.contacto.localidad) Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@nombre_deposito", oEntity.nomber)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.id)
            comando.Parameters.AddWithValue("@calle", oEntity.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.contacto.piso)
            comando.Parameters.AddWithValue("@departamento", oEntity.contacto.departamento)
            comando.Parameters.AddWithValue("@localidad_id", oEntity.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.contacto.email)
            comando.Parameters.AddWithValue("@telefono", oEntity.contacto.telefonos.Item(0).telefono)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Deposito)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Deposito) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_DEPOSITO_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New ExcepcionDeDatos(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA)), Me.GetType.ToString, query)
            End If
            comando.Parameters.AddWithValue("@deposito_id", oEntity.id)

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Deposito)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Deposito) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_DEPOSITO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim reader As SqlDataReader


            comando.CommandType = CommandType.StoredProcedure
            If oEntity.nomber Is Nothing Or oEntity.contacto.calle Is Nothing Or oEntity.contacto.nroPuerta Is Nothing Or oEntity.contacto.localidad Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            If "".Equals(oEntity.nomber) Or "".Equals(oEntity.contacto.calle) Or "".Equals(oEntity.contacto.nroPuerta) Or "".Equals(oEntity.contacto.localidad) Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@nombre_deposito", oEntity.nomber)
            comando.Parameters.AddWithValue("@calle", oEntity.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.contacto.piso)
            comando.Parameters.AddWithValue("@departamento", oEntity.contacto.departamento)
            comando.Parameters.AddWithValue("@localidad_id", oEntity.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.contacto.email)
            comando.Parameters.AddWithValue("@telefono", oEntity.contacto.telefonos.Item(0).telefono)

            reader = comando.ExecuteReader()
            While reader.Read()
                oEntity.id = reader.GetValue(0)
                Exit While
            End While

            reader.Close()

            query = ConstantesDeDatos.CREAR_RELACION_EMPLEADO_DEPOSITO
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            'crear la relación con SuperAdmin por defecto
            comando.Parameters.AddWithValue("@empleado_id", 1)
            comando.Parameters.AddWithValue("@deposito_id", oEntity.id)
            comando.ExecuteNonQuery()


            conexion.Close()
            comando.Dispose()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Deposito)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Deposito)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_DEPOSITOS_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oDeposito As Deposito = Nothing
                Dim reader As SqlDataReader
                Dim listaDepositos As New List(Of Deposito)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
                Dim loccriteria As New GenericQueryCriteria
                While reader.Read()
                    oDeposito = New Deposito()
                    If Not Convert.IsDBNull(reader.GetValue(0)) Then
                        oDeposito.id = reader.GetValue(0)
                    End If

                    oDeposito.nomber = TryCast(reader.GetValue(1), String)
                    oDeposito.contacto = New Contacto()
                    If Not Convert.IsDBNull(reader.GetValue(2)) Then
                        oDeposito.contacto.id = reader.GetValue(2)
                    End If

                    oDeposito.contacto.calle = TryCast(reader.GetValue(3), String)
                    oDeposito.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                    oDeposito.contacto.departamento = TryCast(reader.GetValue(5), String)
                    If Not Convert.IsDBNull(reader.GetValue(6)) Then
                        oDeposito.contacto.piso = reader.GetValue(6)
                    Else
                        oDeposito.contacto.piso = 0
                    End If

                    If Not Convert.IsDBNull(reader.GetValue(7)) Then
                        loccriteria.integerCriteria = reader.GetValue(7)
                        oDeposito.contacto.localidad = locdao.obtenerUno(loccriteria)
                    Else
                        oDeposito.contacto.localidad = New Localidad
                    End If

                    oDeposito.contacto.email = TryCast(reader.GetValue(8), String)
                    oDeposito.contacto.telefonos = New List(Of Telefono)
                    Dim tel As New Telefono
                    tel.telefono = TryCast(reader.GetValue(9), String)
                    tel.tipoTelefono = New TipoTelefono
                    If Not Convert.IsDBNull(reader.GetValue(10)) Then
                        tel.tipoTelefono.id = reader.GetValue(10)
                    End If
                    oDeposito.contacto.telefonos.Add(tel)
                    listaDepositos.Add(oDeposito)
                End While
                conexion.Close()
                Return listaDepositos
            Else
                Dim criteria As GenericQueryCriteria = queryCriteria
                If criteria.integerCriteria <> 0 Then
                    If criteria.booleanCriteria = True And Not "E".Equals(criteria.stringCriteria) Then ' Obtiene por sucursal
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        query = ConstantesDeDatos.OBTENER_TODOS_LOS_DEPOSITOS_POR_SUCURSAL_SP
                        Dim comando As SqlCommand = New SqlCommand(query, conexion)
                        conexion.Open()
                        Dim oDeposito As Deposito = Nothing
                        Dim reader As SqlDataReader
                        Dim listaDepositos As New List(Of Deposito)

                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@sucursal_id", criteria.integerCriteria)

                        reader = comando.ExecuteReader()
                        Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
                        Dim loccriteria As New GenericQueryCriteria
                        While reader.Read()
                            oDeposito = New Deposito()
                            If Not Convert.IsDBNull(reader.GetValue(0)) Then
                                oDeposito.id = reader.GetValue(0)
                            End If

                            oDeposito.nomber = TryCast(reader.GetValue(1), String)
                            oDeposito.contacto = New Contacto()
                            If Not Convert.IsDBNull(reader.GetValue(2)) Then
                                oDeposito.contacto.id = reader.GetValue(2)
                            End If

                            oDeposito.contacto.calle = TryCast(reader.GetValue(3), String)
                            oDeposito.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                            oDeposito.contacto.departamento = TryCast(reader.GetValue(5), String)
                            If Not Convert.IsDBNull(reader.GetValue(6)) Then
                                oDeposito.contacto.piso = reader.GetValue(6)
                            End If

                            If Not Convert.IsDBNull(reader.GetValue(7)) Then
                                loccriteria.integerCriteria = reader.GetValue(7)
                                oDeposito.contacto.localidad = locdao.obtenerUno(loccriteria)
                            End If

                            oDeposito.contacto.email = TryCast(reader.GetValue(8), String)
                            oDeposito.contacto.telefonos = New List(Of Telefono)
                            Dim tel As New Telefono
                            tel.telefono = TryCast(reader.GetValue(9), String)
                            tel.tipoTelefono = New TipoTelefono
                            If Not Convert.IsDBNull(reader.GetValue(10)) Then
                                tel.tipoTelefono.id = reader.GetValue(10)
                            Else
                                tel.tipoTelefono.id = 0
                            End If
                            oDeposito.contacto.telefonos.Add(tel)
                            listaDepositos.Add(oDeposito)
                        End While
                        conexion.Close()
                        Return listaDepositos
                    ElseIf criteria.integerCriteria <> 0 And criteria.booleanCriteria = True And "E".Equals(criteria.stringCriteria) Then 'obtener por empleado
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        query = ConstantesDeDatos.OBTENER_TODOS_LOS_DEPOSITOS_POR_EMPLEADO_SP
                        Dim comando As SqlCommand = New SqlCommand(query, conexion)
                        conexion.Open()
                        Dim oDeposito As Deposito = Nothing
                        Dim reader As SqlDataReader
                        Dim listaDepositos As New List(Of Deposito)

                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@empleado_id", criteria.integerCriteria)

                        reader = comando.ExecuteReader()
                        Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
                        Dim loccriteria As New GenericQueryCriteria
                        While reader.Read()
                            oDeposito = New Deposito()
                            If Not Convert.IsDBNull(reader.GetValue(0)) Then
                                oDeposito.id = reader.GetValue(0)
                            End If

                            oDeposito.nomber = TryCast(reader.GetValue(1), String)
                            oDeposito.contacto = New Contacto()
                            If Not Convert.IsDBNull(reader.GetValue(2)) Then
                                oDeposito.contacto.id = reader.GetValue(2)
                            End If

                            oDeposito.contacto.calle = TryCast(reader.GetValue(3), String)
                            oDeposito.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                            oDeposito.contacto.departamento = TryCast(reader.GetValue(5), String)
                            If Not Convert.IsDBNull(reader.GetValue(6)) Then
                                oDeposito.contacto.piso = reader.GetValue(6)
                            End If

                            If Not Convert.IsDBNull(reader.GetValue(7)) Then
                                loccriteria.integerCriteria = reader.GetValue(7)
                                oDeposito.contacto.localidad = locdao.obtenerUno(loccriteria)
                            End If

                            oDeposito.contacto.email = TryCast(reader.GetValue(8), String)
                            oDeposito.contacto.telefonos = New List(Of Telefono)
                            Dim tel As New Telefono
                            tel.telefono = TryCast(reader.GetValue(9), String)
                            tel.tipoTelefono = New TipoTelefono
                            If Not Convert.IsDBNull(reader.GetValue(10)) Then
                                tel.tipoTelefono.id = reader.GetValue(10)
                            End If
                            oDeposito.contacto.telefonos.Add(tel)
                            listaDepositos.Add(oDeposito)
                        End While
                        conexion.Close()
                        Return listaDepositos
                    Else 'obtiene por producto
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        query = ConstantesDeDatos.OBTENER_TODOS_LOS_DEPOSITOS_POR_PRODUCTO_SP
                        Dim comando As SqlCommand = New SqlCommand(query, conexion)
                        conexion.Open()
                        Dim oDeposito As Deposito = Nothing
                        Dim reader As SqlDataReader
                        Dim listaDepositos As New List(Of Deposito)

                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@producto_id", criteria.integerCriteria)

                        reader = comando.ExecuteReader()
                        Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
                        Dim loccriteria As New GenericQueryCriteria
                        While reader.Read()
                            oDeposito = New Deposito()
                            If Not Convert.IsDBNull(reader.GetValue(0)) Then
                                oDeposito.id = reader.GetValue(0)
                            End If

                            oDeposito.nomber = TryCast(reader.GetValue(1), String)
                            oDeposito.contacto = New Contacto()
                            If Not Convert.IsDBNull(reader.GetValue(2)) Then
                                oDeposito.contacto.id = reader.GetValue(2)
                            End If

                            oDeposito.contacto.calle = TryCast(reader.GetValue(3), String)
                            oDeposito.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                            oDeposito.contacto.departamento = TryCast(reader.GetValue(5), String)
                            If Not Convert.IsDBNull(reader.GetValue(6)) Then
                                oDeposito.contacto.piso = reader.GetValue(6)
                            End If

                            If Not Convert.IsDBNull(reader.GetValue(7)) Then
                                loccriteria.integerCriteria = reader.GetValue(7)
                                oDeposito.contacto.localidad = locdao.obtenerUno(loccriteria)
                            End If

                            oDeposito.contacto.email = TryCast(reader.GetValue(8), String)
                            oDeposito.contacto.telefonos = New List(Of Telefono)
                            Dim tel As New Telefono
                            tel.telefono = TryCast(reader.GetValue(9), String)
                            tel.tipoTelefono = New TipoTelefono
                            If Not Convert.IsDBNull(reader.GetValue(10)) Then
                                tel.tipoTelefono.id = reader.GetValue(10)
                            End If
                            oDeposito.contacto.telefonos.Add(tel)
                            listaDepositos.Add(oDeposito)
                        End While
                        conexion.Close()
                        Return listaDepositos

                    End If

                End If
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.ToString, query)
        End Try

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Deposito
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_DEPOSITO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oDeposito As Deposito = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@deposito_id", criteria.integerCriteria)
            comando.Parameters.AddWithValue("@nombre_deposito", criteria.stringCriteria)

            reader = comando.ExecuteReader()
            Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
            Dim critLoc As New GenericQueryCriteria
            While reader.Read()
                oDeposito = New Deposito()
                oDeposito.id = reader.GetValue(0)
                oDeposito.nomber = reader.GetValue(1)
                oDeposito.contacto = New Contacto()
                If Not Convert.IsDBNull(reader.GetValue(2)) Then
                    oDeposito.contacto.id = reader.GetValue(2)
                End If

                oDeposito.contacto.calle = TryCast(reader.GetValue(3), String)
                oDeposito.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                oDeposito.contacto.departamento = TryCast(reader.GetValue(5), String)
                If Not Convert.IsDBNull(reader.GetValue(6)) Then
                    oDeposito.contacto.piso = reader.GetValue(6)
                End If

                If Not Convert.IsDBNull(reader.GetValue(7)) Then
                    critLoc.integerCriteria = reader.GetValue(7)
                    oDeposito.contacto.localidad = locdao.obtenerUno(critLoc)
                End If

                oDeposito.contacto.email = TryCast(reader.GetValue(8), String)
                oDeposito.contacto.telefonos = New List(Of Telefono)
                Dim tel As New Telefono
                tel.telefono = TryCast(reader.GetValue(9), String)
                tel.tipoTelefono = New TipoTelefono
                If Not Convert.IsDBNull(reader.GetValue(10)) Then
                    tel.tipoTelefono.id = reader.GetValue(10)
                End If
                oDeposito.contacto.telefonos.Add(tel)
                Exit While
            End While
            conexion.Close()
            Return oDeposito
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
