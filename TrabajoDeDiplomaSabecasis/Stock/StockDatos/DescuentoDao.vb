Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class DescuentoDao
    Inherits AbstractDao(Of Descuento)

    Public Overrides Function actualizar(oEntity As Descuento) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ACTUALIZAR_DESCUENTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)
            comando.Parameters.AddWithValue("@monto", oEntity.monto)
            comando.Parameters.AddWithValue("@porcentaje", oEntity.porcentaje)
            comando.Parameters.AddWithValue("@descuento_id", oEntity.id)

            comando.ExecuteNonQuery()

            comando.Dispose()
            conexion.Close()
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try

        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Descuento)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Descuento) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.ELIMINAR_DESCUENTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@id", oEntity.id)
            comando.ExecuteNonQuery()

            comando.Dispose()
            conexion.Close()
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try

        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Descuento)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Descuento) As Boolean
        Dim query As String = ""
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            query = ConstantesDeDatos.CREAR_DESCUENTO_SP
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@descuento_nombre", oEntity.nombre)
            comando.Parameters.AddWithValue("@descripcion", oEntity.descripcion)
            comando.Parameters.AddWithValue("@monto", oEntity.monto)
            comando.Parameters.AddWithValue("@porcentaje", oEntity.porcentaje)

            comando.ExecuteNonQuery()

            comando.Dispose()
            conexion.Close()

        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try

        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Descuento)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Descuento)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_DESCUENTOS_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As Descuento = Nothing
                Dim reader As SqlDataReader
                Dim lista As New List(Of Descuento)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New Descuento()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.monto = reader.GetValue(1)
                    oEstSuc.porcentaje = reader.GetValue(2)
                    oEstSuc.descripcion = TryCast(reader.GetValue(3), String)
                    oEstSuc.nombre = reader.GetValue(4)
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

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Descuento
        Dim query As String = ""
        Try
            If Not queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_DESCUENTO_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As Descuento = Nothing
                Dim reader As SqlDataReader
                comando.CommandType = CommandType.StoredProcedure
                Dim criteria As GenericQueryCriteria = queryCriteria

                comando.Parameters.AddWithValue("@descuento_id", criteria.integerCriteria)
                comando.Parameters.AddWithValue("@nombre", criteria.stringCriteria)

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New Descuento()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.monto = reader.GetValue(1)
                    oEstSuc.porcentaje = reader.GetValue(2)
                    oEstSuc.descripcion = TryCast(reader.GetValue(3), String)
                    oEstSuc.nombre = reader.GetValue(4)
                    Exit While
                End While
                conexion.Close()

                Return oEstSuc
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
