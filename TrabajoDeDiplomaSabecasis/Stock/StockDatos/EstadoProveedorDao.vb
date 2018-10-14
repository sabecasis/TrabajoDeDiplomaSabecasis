Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class EstadoProveedorDao
    Inherits AbstractDao(Of EstadoProveedor)


    Public Overrides Function actualizar(oEntity As EstadoProveedor) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of EstadoProveedor)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As EstadoProveedor) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of EstadoProveedor)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As EstadoProveedor) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of EstadoProveedor)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of EstadoProveedor)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_ESTADOS_DE_PROVEEDOR_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As EstadoProveedor = Nothing
                Dim reader As SqlDataReader
                Dim listaEstados As New List(Of EstadoProveedor)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New EstadoProveedor()
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

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As EstadoProveedor
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
