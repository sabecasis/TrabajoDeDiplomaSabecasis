Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class EstadoInstanciaProductoDao
    Inherits AbstractDao(Of EstadoInstanciaProducto)

    Public Overrides Function actualizar(oEntity As EstadoInstanciaProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of EstadoInstanciaProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As EstadoInstanciaProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of EstadoInstanciaProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As EstadoInstanciaProducto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of EstadoInstanciaProducto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of EstadoInstanciaProducto)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_ESTADOS_INST_PROD_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As EstadoInstanciaProducto = Nothing
                Dim reader As SqlDataReader
                Dim listaEstados As New List(Of EstadoInstanciaProducto)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New EstadoInstanciaProducto()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.estado = reader.GetValue(1)
                    listaEstados.Add(oEstSuc)
                End While
                conexion.Close()
                Return listaEstados
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As EstadoInstanciaProducto
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
