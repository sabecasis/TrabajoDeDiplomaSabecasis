Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class PuestoDao
    Inherits AbstractDao(Of Puesto)


    Public Overrides Function actualizar(oEntity As Puesto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Puesto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Puesto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Puesto)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Puesto) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Puesto)) As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.CREAR_PUESTO_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            For Each oEntity As Puesto In oEntityList
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@puesto", oEntity.puesto)
                comando.Parameters.AddWithValue("@codigo", oEntity.codigo)
            Next

            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()
            Return True
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.CREAR_PUESTO_SP)
        End Try

    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Puesto)
        Dim criteria As GenericQueryCriteria = queryCriteria
        Dim puestos As List(Of Puesto) = New List(Of Puesto)
        Try
            If criteria Is Nothing Then
                'obtener todos

                Dim puesto As Puesto
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_PUESTOS_SP, conexion)
                Dim dataReader As SqlDataReader
                conexion.Open()

                comando.CommandType = CommandType.StoredProcedure

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    puesto = New Puesto()
                    puesto.id = dataReader.GetValue(0)
                    puesto.codigo = dataReader.GetValue(1)
                    puesto.puesto = dataReader.GetValue(2)
                    puestos.Add(puesto)
                End While

                conexion.Close()
                comando.Dispose()

            End If
            Return puestos
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_PUESTOS_SP)
        End Try

    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Puesto
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
