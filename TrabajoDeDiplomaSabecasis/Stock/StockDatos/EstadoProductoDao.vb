Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class EstadoProductoDao
    Inherits AbstractDao(Of EstadoProducto)

    Public Overrides Function actualizar(oEntity As EstadoProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of EstadoProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As EstadoProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of EstadoProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As EstadoProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of EstadoProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of EstadoProducto)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_ESTADOS_DE_PRODUCTO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As EstadoProducto = Nothing
                Dim reader As SqlDataReader
                Dim listaEstados As New List(Of EstadoProducto)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New EstadoProducto()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.estado = reader.GetValue(1)
                    listaEstados.Add(oEstSuc)
                End While
                conexion.Close()
                Return listaEstados
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As EstadoProducto
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
