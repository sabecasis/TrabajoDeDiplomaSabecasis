Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class ProvinciaDao
    Inherits AbstractDao(Of Provincia)

    Public Overrides Function actualizar(oEntity As Provincia) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Provincia)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Provincia) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Provincia)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Provincia) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Provincia)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Provincia)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            'obtener todos
        Else
            If Not criteria.oObject Is Nothing Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODAS_LAS_PROVINCIAS_POR_PAIS_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim provincias As List(Of Provincia) = New List(Of Provincia)
                    Dim provincia As Provincia
                    Dim dao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia().crear(GetType(Localidad))
                    Dim localidadQueryCriteria As GenericQueryCriteria = New GenericQueryCriteria()

                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@pais_id", DirectCast(criteria.oObject, Pais).id)

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        provincia = New Provincia()
                        provincia.id = dataReader.GetValue(0)
                        provincia.provincia = dataReader.GetValue(1)
                        provincia.pais = DirectCast(criteria.oObject, Pais)
                        localidadQueryCriteria.oObject = provincia
                        provincia.localidades = dao.obtenerMuchos(localidadQueryCriteria)
                        provincias.Add(provincia)
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return provincias
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODAS_LAS_PROVINCIAS_POR_PAIS_SP)
                End Try

            End If
        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Provincia
        If Not queryCriteria Is Nothing Then
            Dim criteria As GenericQueryCriteria = queryCriteria
            If criteria.integerCriteria <> 0 Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_PROVINCIA_POR_ID_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim provincia As Provincia = Nothing
                    Dim paisDao As AbstractDao(Of Pais) = DaoFactory(Of Pais).obtenerInstancia().crear(GetType(Pais))
                    Dim pCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@provincia_id", criteria.integerCriteria)

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        provincia = New Provincia()
                        provincia.id = dataReader.GetValue(0)
                        pCriteria.integerCriteria = dataReader.GetValue(1)
                        provincia.pais = paisDao.obtenerUno(pCriteria)
                        provincia.provincia = dataReader.GetValue(2)
                        Exit While
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return provincia
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_PROVINCIA_POR_ID_SP)
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
