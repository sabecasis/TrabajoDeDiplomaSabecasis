Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class EstadoSucursalDao
    Inherits AbstractDao(Of EstadoSucursal)

    Public Overrides Function actualizar(oEntity As EstadoSucursal) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of EstadoSucursal)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As EstadoSucursal) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of EstadoSucursal)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As EstadoSucursal) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of EstadoSucursal)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of EstadoSucursal)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                query = ConstantesDeDatos.OBTENER_TODOS_LOS_ESTADOS_SUCURSAL_SP
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                conexion.Open()
                Dim oEstSuc As EstadoSucursal = Nothing
                Dim reader As SqlDataReader
                Dim listaEstadosSucursal As New List(Of EstadoSucursal)

                comando.CommandType = CommandType.StoredProcedure

                reader = comando.ExecuteReader()
                While reader.Read()
                    oEstSuc = New EstadoSucursal()
                    oEstSuc.id = reader.GetValue(0)
                    oEstSuc.estado = reader.GetValue(1)
                    listaEstadosSucursal.Add(oEstSuc)
                End While
                conexion.Close()
                Return listaEstadosSucursal
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.ToString, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As EstadoSucursal

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
