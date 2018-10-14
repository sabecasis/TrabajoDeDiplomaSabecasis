Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class LocalidadDao
    Inherits AbstractDao(Of Localidad)

    Public Overrides Function actualizar(oEntity As Localidad) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Localidad)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Localidad) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Localidad)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Localidad) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Localidad)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Localidad)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            'obtener todos
        Else
            If Not criteria.oObject Is Nothing Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODAS_LAS_LOCALIDADES_POR_PROVINCIA_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim localidades As List(Of Localidad) = New List(Of Localidad)
                    Dim localidad As Localidad

                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@provincia_id", DirectCast(criteria.oObject, Provincia).id)

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        localidad = New Localidad()
                        localidad.id = dataReader.GetValue(0)
                        localidad.localidad = dataReader.GetValue(1)
                        localidad.cp = dataReader.GetValue(2)
                        localidad.provincia = DirectCast(criteria.oObject, Provincia)
                        localidades.Add(localidad)
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return localidades
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODAS_LAS_LOCALIDADES_POR_PROVINCIA_SP)
                End Try

            End If
        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Localidad
        If Not queryCriteria Is Nothing Then
            Dim criteria As GenericQueryCriteria = queryCriteria
            If criteria.integerCriteria <> 0 Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_LOCALIDAD_POR_ID_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim localidad As Localidad = Nothing
                    Dim provDao As AbstractDao(Of Provincia) = DaoFactory(Of Provincia).obtenerInstancia().crear(GetType(Provincia))
                    Dim provCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@localidad_id", criteria.integerCriteria)

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        localidad = New Localidad()
                        localidad.id = dataReader.GetValue(0)
                        localidad.cp = dataReader.GetValue(1)
                        localidad.localidad = dataReader.GetValue(2)
                        provCriteria.integerCriteria = dataReader.GetValue(3)
                        localidad.provincia = provDao.obtenerUno(provCriteria)
                        Exit While
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return localidad
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_LOCALIDAD_POR_ID_SP)
                End Try
            End If
        End If
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
