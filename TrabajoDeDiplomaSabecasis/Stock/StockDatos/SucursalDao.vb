Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class SucursalDao
    Inherits AbstractDao(Of Sucursal)


    Public Overrides Function actualizar(oEntity As Sucursal) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_SUCURSAL_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()


            comando.CommandType = CommandType.StoredProcedure
            If oEntity.estado Is Nothing Or oEntity.contacto.calle Is Nothing Or oEntity.contacto.nroPuerta Is Nothing Or oEntity.contacto.localidad Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            If "".Equals(oEntity.contacto.calle) Or "".Equals(oEntity.contacto.nroPuerta) Or "".Equals(oEntity.contacto.localidad) Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@estado_sucursal_id", oEntity.estado.id)
            comando.Parameters.AddWithValue("@horario_inicio_actividad", oEntity.horarioInicio)
            comando.Parameters.AddWithValue("@horario_cierre_actividad", oEntity.horarioCierre)
            comando.Parameters.AddWithValue("@fecha_apertura", oEntity.fechaApertura)
            comando.Parameters.AddWithValue("@fecha_cierre", oEntity.fechaCierre)
            comando.Parameters.AddWithValue("@calle", oEntity.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.contacto.piso)
            comando.Parameters.AddWithValue("@departamento", oEntity.contacto.departamento)
            comando.Parameters.AddWithValue("@localidad_id", oEntity.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.contacto.email)
            comando.Parameters.AddWithValue("@telefono", oEntity.contacto.telefonos.Item(0).telefono)
            comando.Parameters.AddWithValue("@id_sucursal", oEntity.id)

            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.ELIMINAR_RELACION_SUCURSAL_DEPOSITO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@id_sucursal", oEntity.id)
            comando.ExecuteNonQuery()

            query = ConstantesDeDatos.CREAR_RELACION_SUCURSAL_DEPOSITO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            If Not oEntity.depositos Is Nothing Then
                For Each oElemento As Deposito In oEntity.depositos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@id_sucursal", oEntity.id)
                    comando.Parameters.AddWithValue("@id_deposito", oElemento.id)

                    comando.ExecuteNonQuery()
                Next
            End If


            comando.Dispose()
            conexion.Close()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Sucursal)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Sucursal) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_SUCURSAL_SP

            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            If oEntity.id = 0 Then
                Throw New ExcepcionDeDatos(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ID_NULA)), Me.GetType.ToString, query)
            End If
            comando.Parameters.AddWithValue("@sucursal_id", oEntity.id)

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

    Public Overrides Function elminarMuchos(oEntityList As List(Of Sucursal)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Sucursal) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_SUCURSAL_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            Dim reader As SqlDataReader


            comando.CommandType = CommandType.StoredProcedure
            If oEntity.estado Is Nothing Or oEntity.contacto.calle Is Nothing Or oEntity.contacto.nroPuerta Is Nothing Or oEntity.contacto.localidad Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If
            If "".Equals(oEntity.contacto.calle) Or "".Equals(oEntity.contacto.nroPuerta) Or "".Equals(oEntity.contacto.localidad) Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ELEMENTOS_NULOS))
            End If

            comando.Parameters.AddWithValue("@estado_sucursal_id", oEntity.estado.id)
            comando.Parameters.AddWithValue("@horario_inicio_actividad", oEntity.horarioInicio)
            comando.Parameters.AddWithValue("@horario_cierre_actividad", oEntity.horarioCierre)
            comando.Parameters.AddWithValue("@fecha_apertura", oEntity.fechaApertura)
            comando.Parameters.AddWithValue("@fecha_cierre", oEntity.fechaCierre)
            comando.Parameters.AddWithValue("@calle", oEntity.contacto.calle)
            comando.Parameters.AddWithValue("@nro_puerta", oEntity.contacto.nroPuerta)
            comando.Parameters.AddWithValue("@piso", oEntity.contacto.piso)
            comando.Parameters.AddWithValue("@departamento", oEntity.contacto.departamento)
            comando.Parameters.AddWithValue("@localidad_id", oEntity.contacto.localidad.id)
            comando.Parameters.AddWithValue("@email", oEntity.contacto.email)
            comando.Parameters.AddWithValue("@telefono", oEntity.contacto.telefonos.Item(0).telefono)

            reader = comando.ExecuteReader()
            Dim idSucursal As Integer = 0
            While reader.Read()
                idSucursal = reader.GetValue(0)
                Exit While
            End While

            If idSucursal = 0 Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_CREAR_SUCURSAL))
            End If
            reader.Close()
            comando.Dispose()

            query = ConstantesDeDatos.CREAR_RELACION_SUCURSAL_DEPOSITO_SP
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.StoredProcedure

            If Not oEntity.depositos Is Nothing Then
                For Each oElemento As Deposito In oEntity.depositos
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@id_sucursal", idSucursal)
                    comando.Parameters.AddWithValue("@id_deposito", oElemento.id)

                    comando.ExecuteNonQuery()
                Next
            End If


            comando.Dispose()
            conexion.Close()

            Return True
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return False
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Sucursal)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Sucursal)
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.OBTENER_TODAS_LAS_SUCURSALES_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oSucursal As Sucursal = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            reader = comando.ExecuteReader()
            Dim lista As New List(Of Sucursal)
            While reader.Read()
                oSucursal = New Sucursal()
                oSucursal.id = reader.GetValue(0)
                oSucursal.estado = New EstadoSucursal()
                If Not Convert.IsDBNull(reader.GetValue(1)) Then
                    oSucursal.estado.id = reader.GetValue(1)
                End If
                oSucursal.contacto = New Contacto()

                If Not Convert.IsDBNull(reader.GetValue(2)) Then
                    oSucursal.fechaApertura = reader.GetValue(2)
                End If
                If Not Convert.IsDBNull(reader.GetValue(3)) Then
                    oSucursal.fechaCierre = reader.GetValue(3)
                End If

                oSucursal.horarioInicio = TryCast(reader.GetValue(4), String)
                oSucursal.horarioCierre = TryCast(reader.GetValue(5), String)

                lista.Add(oSucursal)
            End While
            conexion.Close()
            Return lista
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing

    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Sucursal
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.CRITERIO_DE_BUSQUEDA_NULO))
            End If
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.BUSCAR_SUCURSAL_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()
            Dim oSucursal As Sucursal = Nothing
            Dim reader As SqlDataReader
            Dim criteria As GenericQueryCriteria = queryCriteria

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@sucursal_id", criteria.integerCriteria)

            reader = comando.ExecuteReader()
            Dim locdao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia.crear(GetType(Localidad))
            Dim depdao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia.crear(GetType(Deposito))
            Dim depDaoCriteria As New GenericQueryCriteria
            Dim locCriteria As New GenericQueryCriteria()
            While reader.Read()
                oSucursal = New Sucursal()
                oSucursal.id = reader.GetValue(0)
                oSucursal.estado = New EstadoSucursal()
                If Not Convert.IsDBNull(reader.GetValue(1)) Then
                    oSucursal.estado.id = reader.GetValue(1)
                End If
                oSucursal.contacto = New Contacto()
                If Convert.IsDBNull(reader.GetValue(2)) Then
                    oSucursal = Nothing
                    Exit While
                End If
                oSucursal.contacto.id = reader.GetValue(2)
                oSucursal.contacto.calle = TryCast(reader.GetValue(3), String)
                oSucursal.contacto.nroPuerta = TryCast(reader.GetValue(4), String)
                oSucursal.contacto.departamento = TryCast(reader.GetValue(5), String)
                If Not Convert.IsDBNull(reader.GetValue(6)) Then
                    oSucursal.contacto.piso = reader.GetValue(6)
                End If
                If Not Convert.IsDBNull(reader.GetValue(7)) Then
                    locCriteria.integerCriteria = reader.GetValue(7)
                    oSucursal.contacto.localidad = locdao.obtenerUno(locCriteria)
                End If

                oSucursal.contacto.email = TryCast(reader.GetValue(8), String)
                oSucursal.contacto.telefonos = New List(Of Telefono)
                Dim tel As New Telefono
                tel.telefono = TryCast(reader.GetValue(9), String)
                tel.tipoTelefono = New TipoTelefono
                If Not Convert.IsDBNull(reader.GetValue(10)) Then
                    tel.tipoTelefono.id = reader.GetValue(10)
                End If

                oSucursal.contacto.telefonos.Add(tel)
                If Not Convert.IsDBNull(reader.GetValue(11)) Then
                    oSucursal.fechaApertura = reader.GetValue(11)
                End If
                If Not Convert.IsDBNull(reader.GetValue(12)) Then
                    oSucursal.fechaCierre = reader.GetValue(12)
                End If

                oSucursal.horarioInicio = TryCast(reader.GetValue(13), String)
                oSucursal.horarioCierre = TryCast(reader.GetValue(14), String)
                If Not Convert.IsDBNull(reader.GetValue(10)) Then
                    depDaoCriteria.integerCriteria = oSucursal.id
                    depDaoCriteria.booleanCriteria = True
                    depDaoCriteria.stringCriteria = ""
                    oSucursal.depositos = depdao.obtenerMuchos(depDaoCriteria)
                End If

                Exit While
            End While
            conexion.Close()
            Return oSucursal
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
