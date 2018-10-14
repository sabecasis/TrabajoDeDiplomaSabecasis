Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class ErrorLogDao
    Inherits AbstractDao(Of ErrorLog)

    Public Overrides Function actualizar(oEntity As ErrorLog) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ErrorLog)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ErrorLog) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ErrorLog)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ErrorLog) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ErrorLog)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ErrorLog)
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.CONSULTAR_LOG_DE_ERRORES_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As ErrorLog = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of ErrorLog)

                Dim criteria As LogErroresQueryCriteria = queryCriteria


                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@id_error", criteria.idError)
                comando.Parameters.AddWithValue("@clase", criteria.clase)
                comando.Parameters.AddWithValue("@query", criteria.query)
                comando.Parameters.AddWithValue("@tipo_excepcion_id", criteria.tipoExcepcion)
                If criteria.fecha = Nothing Then
                    comando.Parameters.AddWithValue("@fecha", "")
                Else
                    comando.Parameters.AddWithValue("@fecha", criteria.fecha.ToString("yyyy-MM-dd"))
                End If

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New ErrorLog()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.fecha = reader.GetValue(1)
                    oEstSuc.mensaje_error = reader.GetValue(2)
                    oEstSuc.excepcion = reader.GetValue(3)
                    oEstSuc.tipoDeExcepcion = New TipoDeExcepcion
                    oEstSuc.tipoDeExcepcion.id = reader.GetValue(4)
                    oEstSuc.tipoDeExcepcion.tipo = reader.GetValue(5)
                    oEstSuc.clase = reader.GetValue(6)
                    oEstSuc.accion = reader.GetValue(7)
                    oEstSuc.query = reader.GetValue(8)
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

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ErrorLog
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
