Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class PermisoDao
    Inherits AbstractDao(Of Permiso)

    Public Overrides Function actualizar(oEntity As Permiso) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Permiso)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Permiso) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Permiso)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Permiso) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Permiso)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Permiso)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If Not criteria Is Nothing Then
            If Not criteria.oObject Is Nothing Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_PERMISOS_POR_ROL_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim permisos As List(Of Permiso) = New List(Of Permiso)
                    Dim oPermiso As Permiso

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@id_rol", DirectCast(criteria.oObject, Rol).id)
                    conexion.Open()

                    dataReader = comando.ExecuteReader()
                    While dataReader.Read
                        oPermiso = New Permiso()
                        oPermiso.id = dataReader.GetValue(0)
                        oPermiso.nombre = dataReader.GetValue(1)
                        oPermiso.descripcion = dataReader.GetValue(2)
                        permisos.Add(oPermiso)
                    End While

                    conexion.Close()
                    comando.Dispose()

                    Return permisos
                Catch e As Exception
                    Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_PERMISOS_POR_ROL_SP)
                End Try

            End If
        Else
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_PERMISOS_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim permisos As List(Of Permiso) = New List(Of Permiso)
                Dim oPermiso As Permiso

                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    oPermiso = New Permiso()
                    oPermiso.id = dataReader.GetValue(0)
                    oPermiso.nombre = dataReader.GetValue(1)
                    oPermiso.descripcion = dataReader.GetValue(2)
                    permisos.Add(oPermiso)
                End While

                conexion.Close()
                comando.Dispose()

                Return permisos
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_PERMISOS_SP)
            End Try
        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Permiso
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
