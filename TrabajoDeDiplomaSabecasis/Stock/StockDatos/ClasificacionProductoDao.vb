Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class ClasificacionProductoDao
    Inherits AbstractDao(Of ClasificacionProducto)

    Public Overrides Function actualizar(oEntity As ClasificacionProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ClasificacionProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ClasificacionProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ClasificacionProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ClasificacionProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ClasificacionProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ClasificacionProducto)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODAS_LAS_CLASIFICACIONES_PRODUCTO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As ClasificacionProducto = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of ClasificacionProducto)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New ClasificacionProducto()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.clasificacion = reader.GetValue(1)
                    lista.Add(oEstSuc)
                End While
                conexion.Close()
                Return lista
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ClasificacionProducto
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
