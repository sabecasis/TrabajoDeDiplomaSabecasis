Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class ElementoDeSeguridadDao
    Inherits AbstractDao(Of ElementoDeSeguridad)


    Public Overrides Function actualizar(oEntity As ElementoDeSeguridad) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ElementoDeSeguridad)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ElementoDeSeguridad) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ElementoDeSeguridad)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ElementoDeSeguridad) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ElementoDeSeguridad)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ElementoDeSeguridad)

        If queryCriteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_USUARIOS, conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim reader As SqlDataReader
                Dim oSeguridad As ElementoDeSeguridad
                Dim listaElementos As List(Of ElementoDeSeguridad) = New List(Of ElementoDeSeguridad)
                Dim rolDao As AbstractDao(Of Rol) = DaoFactory(Of Rol).obtenerInstancia().crear(GetType(Rol))
                Dim rolCriteria As GenericQueryCriteria = New GenericQueryCriteria()

                conexion.Open()

                reader = comando.ExecuteReader()

                While reader.Read()
                    oSeguridad = New Grupo()
                    oSeguridad.id = reader.GetValue(0)
                    oSeguridad.nombre = reader.GetValue(1)
                    rolCriteria.oObject = oSeguridad
                    DirectCast(oSeguridad, Grupo).roles = rolDao.obtenerMuchos(rolCriteria)
                    listaElementos.Add(oSeguridad)
                End While

                comando.Dispose()
                conexion.Close()

                Return listaElementos
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_USUARIOS)
            End Try

        Else
            Dim query As String = ""
            Try
                Dim criteria As GenericQueryCriteria = queryCriteria
                If Not criteria.oObject Is Nothing Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand
                    If criteria.booleanCriteria Then
                        query = ConstantesDeDatos.OBTENER_GRUPOS_USUARIOS_POR_GRUPO_SP
                        comando = New SqlCommand(query, conexion)
                        comando.Parameters.AddWithValue("@id_grupo", DirectCast(criteria.oObject, ElementoDeSeguridad).id)
                    Else
                        query = ConstantesDeDatos.OBTENER_GRUPOS_USARIOS_POR_USUARIO_SP
                        comando = New SqlCommand(query, conexion)
                        comando.Parameters.AddWithValue("@usuario_id", DirectCast(criteria.oObject, ElementoDeSeguridad).id)
                    End If

                    comando.CommandType = CommandType.StoredProcedure
                    Dim reader As SqlDataReader
                    Dim oSeguridad As ElementoDeSeguridad
                    Dim listaElementos As List(Of ElementoDeSeguridad) = New List(Of ElementoDeSeguridad)
                    Dim rolDao As AbstractDao(Of Rol) = DaoFactory(Of Rol).obtenerInstancia().crear(GetType(Rol))
                    Dim rolCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    conexion.Open()

                    reader = comando.ExecuteReader()

                    While reader.Read()
                        oSeguridad = New Grupo()
                        oSeguridad.id = reader.GetValue(0)
                        oSeguridad.nombre = reader.GetValue(1)
                        rolCriteria.oObject = oSeguridad
                        DirectCast(oSeguridad, Grupo).roles = rolDao.obtenerMuchos(rolCriteria)
                        listaElementos.Add(oSeguridad)
                    End While

                    comando.Dispose()
                    conexion.Close()

                    Return listaElementos

                End If
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
            End Try
        End If

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ElementoDeSeguridad
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
