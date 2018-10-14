Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class ExistenciaDeProductoEnStockDao
    Inherits AbstractDao(Of ExistenciaDeProductoEnStock)

    Public Overrides Function actualizar(oEntity As ExistenciaDeProductoEnStock) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ExistenciaDeProductoEnStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ExistenciaDeProductoEnStock) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ExistenciaDeProductoEnStock)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ExistenciaDeProductoEnStock) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ExistenciaDeProductoEnStock)) As Boolean

        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ExistenciaDeProductoEnStock)
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                Dim criteria As ExistenciaQueryCriteria = queryCriteria
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTNER_TODAS_LAS_EXISTENCIAS_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As ExistenciaDeProductoEnStock = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of ExistenciaDeProductoEnStock)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@producto", criteria.idProducto)
                comando.Parameters.AddWithValue("@deposito", criteria.idDeposito)

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New ExistenciaDeProductoEnStock()
                    oEstSuc.idProducto = reader.GetValue(0)
                    oEstSuc.cantidad = reader.GetValue(1)
                    oEstSuc.maxStock = reader.GetValue(2)
                    oEstSuc.minStock = reader.GetValue(3)
                    oEstSuc.modoReposicion = New MetodoDeReposicion
                    oEstSuc.modoReposicion.metodo = reader.GetValue(4)
                    oEstSuc.modoReposicion.id = reader.GetValue(7)
                    oEstSuc.producto = reader.GetValue(5)
                    oEstSuc.ciclo = reader.GetValue(6)
                    oEstSuc.pedidoAutomatico = reader.GetValue(8)
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

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ExistenciaDeProductoEnStock
        Return Nothing
    End Function

    Public Function obtenerUltimaFechaDeIngresoDeStock(criteria As ExistenciaQueryCriteria) As Date
        Dim query As String = ""
        Try
            If Not criteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_ULTIMA_FECHA_DE_INGRESO_EN_STOCK_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As ExistenciaDeProductoEnStock = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of ExistenciaDeProductoEnStock)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@producto_id", criteria.idProducto)
                comando.Parameters.AddWithValue("@deposito_id", criteria.idDeposito)

                reader = comando.ExecuteReader()
                While reader.Read()
                    If Convert.IsDBNull(reader.GetValue(0)) Then
                        conexion.Close()
                        Return Nothing
                    Else
                        conexion.Close()
                        Return CType(reader.GetValue(0), Date)
                    End If
                End While


            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try
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
