Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class PaisDao
    Inherits AbstractDao(Of Pais)

    Public Overrides Function actualizar(oEntity As Pais) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Pais)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Pais) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Pais)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Pais) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Pais)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Pais)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_PAISES_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim paises As List(Of Pais) = New List(Of Pais)
                Dim pais As Pais
                Dim dao As AbstractDao(Of Provincia) = DaoFactory(Of Provincia).obtenerInstancia().crear(GetType(Provincia))
                Dim provinciaQueryCriteria As GenericQueryCriteria = New GenericQueryCriteria()

                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    pais = New Pais()
                    pais.id = dataReader.GetValue(0)
                    pais.pais = dataReader.GetValue(1)
                    provinciaQueryCriteria.oObject = pais
                    pais.provincias = dao.obtenerMuchos(provinciaQueryCriteria)
                    paises.Add(pais)
                End While

                conexion.Close()
                comando.Dispose()

                Return paises
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_PAISES_SP)
            End Try

        End If

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Pais
        If Not queryCriteria Is Nothing Then
            Dim criteria As GenericQueryCriteria = queryCriteria
            If criteria.integerCriteria <> 0 Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_PAIS_POR_ID_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim pais As Pais = Nothing

                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@pais_id", criteria.integerCriteria)

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        pais = New Pais()
                        pais.id = dataReader.GetValue(0)
                        pais.pais = dataReader.GetValue(1)
                        Exit While
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return pais
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_PAIS_POR_ID_SP)
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
