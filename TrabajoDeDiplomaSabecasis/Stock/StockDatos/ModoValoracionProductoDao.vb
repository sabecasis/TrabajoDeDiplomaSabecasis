Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class ModoValoracionProductoDao
    Inherits AbstractDao(Of ModoValoracionProducto)

    Public Overrides Function actualizar(oEntity As ModoValoracionProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ModoValoracionProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ModoValoracionProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ModoValoracionProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ModoValoracionProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ModoValoracionProducto)) As Boolean

        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ModoValoracionProducto)
        Dim query = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_MODOS_DE_VALORACION_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As ModoValoracionProducto = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of ModoValoracionProducto)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New ModoValoracionProducto()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.modo = reader.GetValue(1)
                    oEstSuc.descripcion = reader.GetValue(2)
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

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ModoValoracionProducto
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
