Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class ElementoDeIdiomaDao
    Inherits AbstractDao(Of ElementoDeIdioma)

    Public Overrides Function actualizar(oEntity As ElementoDeIdioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ElementoDeIdioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ElementoDeIdioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ElementoDeIdioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ElementoDeIdioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ElementoDeIdioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ElementoDeIdioma)
        Try
            Dim criteria As GenericQueryCriteria = TryCast(queryCriteria, GenericQueryCriteria)
            If Not criteria Is Nothing Then
                If criteria.oObject Is Nothing Then
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_ELEMENTOS_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim elementos As List(Of ElementoDeIdioma) = New List(Of ElementoDeIdioma)
                    Dim elemento As ElementoDeIdioma

                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        elemento = New ElementoDeIdioma(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString)
                        elementos.Add(elemento)
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return elementos
                End If
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_ELEMENTOS_SP)
        End Try
        Return Nothing
    End Function


    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ElementoDeIdioma
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
