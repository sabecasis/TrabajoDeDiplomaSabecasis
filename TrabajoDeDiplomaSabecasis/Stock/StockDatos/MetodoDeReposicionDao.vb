Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class MetodoDeReposicionDao
    Inherits AbstractDao(Of MetodoDeReposicion)

    Public Overrides Function actualizar(oEntity As MetodoDeReposicion) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of MetodoDeReposicion)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As MetodoDeReposicion) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of MetodoDeReposicion)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As MetodoDeReposicion) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of MetodoDeReposicion)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of MetodoDeReposicion)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_METODOS_DE_REPOSICION_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As MetodoDeReposicion = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of MetodoDeReposicion)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New MetodoDeReposicion()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.metodo = reader.GetValue(1)
                    lista.Add(oEstSuc)
                End While
                conexion.Close()
                Return lista
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As MetodoDeReposicion

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
