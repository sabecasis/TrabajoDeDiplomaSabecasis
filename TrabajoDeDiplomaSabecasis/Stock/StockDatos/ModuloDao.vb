Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class ModuloDao
    Inherits AbstractDao(Of Modulo)

    Public Overrides Function actualizar(oEntity As Modulo) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Modulo)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Modulo) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Modulo)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Modulo) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Modulo)) As Boolean

        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Modulo)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If queryCriteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand
                comando = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_MODULOS_SP, conexion)

                comando.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader
                Dim oModulo As Modulo
                Dim listaModulos As List(Of Modulo) = New List(Of Modulo)

                conexion.Open()

                reader = comando.ExecuteReader()

                While reader.Read()
                    oModulo = New Modulo()
                    oModulo.id = reader.GetValue(0)
                    oModulo.nombre = reader.GetValue(1)
                    oModulo.descripcion = reader.GetValue(2)
                    oModulo.url = reader.GetValue(3)
                    listaModulos.Add(oModulo)
                End While

                comando.Dispose()
                conexion.Close()

                Return listaModulos
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_MODULOS_SP)
            End Try

        End If

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Modulo
        Dim criteria As GenericQueryCriteria = queryCriteria
        If Not queryCriteria Is Nothing Then
            If Not criteria.oObject Is Nothing Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand
                    comando = New SqlCommand(ConstantesDeDatos.OBTENER_MODULO_POR_ROL_SP, conexion)

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@id_rol", DirectCast(criteria.oObject, Rol).id)

                    Dim reader As SqlDataReader
                    Dim oModulo As Modulo = Nothing

                    conexion.Open()

                    reader = comando.ExecuteReader()

                    While reader.Read()
                        oModulo = New Modulo()
                        oModulo.id = reader.GetValue(0)
                        oModulo.nombre = reader.GetValue(1)
                        oModulo.descripcion = reader.GetValue(2)
                        oModulo.url = reader.GetValue(3)
                        Exit While

                    End While

                    comando.Dispose()
                    conexion.Close()

                    Return oModulo
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_MODULO_POR_ROL_SP)
                End Try

            End If
        End If

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
