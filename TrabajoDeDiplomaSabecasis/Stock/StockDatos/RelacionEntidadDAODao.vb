Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class RelacionEntidadDAODao
    Inherits AbstractDao(Of RelacionEntidadDAO)

    Private Shared odao As RelacionEntidadDAODao = New RelacionEntidadDAODao

    Public Shared Function obtenerInstancia() As RelacionEntidadDAODao
        Return odao
    End Function

    Private Sub New()

    End Sub

    Public Overrides Function actualizar(oEntity As RelacionEntidadDAO) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of RelacionEntidadDAO)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As RelacionEntidadDAO) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of RelacionEntidadDAO)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As RelacionEntidadDAO) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of RelacionEntidadDAO)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of RelacionEntidadDAO)
        Dim query As String = ConstantesDeDatos.OBTENER_TODOS_LOS_ENTIDAD_DAO_XREF_SP
        Try
            'If query criteria is nothing, bring them all
            If (queryCriteria Is Nothing) Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(query, conexion)
                Dim dataReader As SqlDataReader
                Dim listaResultado As List(Of RelacionEntidadDAO) = New List(Of RelacionEntidadDAO)
                Dim resultado As RelacionEntidadDAO
                conexion.Open()

                comando.CommandType = CommandType.StoredProcedure

                dataReader = comando.ExecuteReader()

                While dataReader.Read
                    resultado = New RelacionEntidadDAO(dataReader.GetValue(0), dataReader.GetValue(1))
                    listaResultado.Add(resultado)
                End While

                conexion.Close()
                comando.Dispose()
                dataReader.Close()

                Return listaResultado
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.FullName, query)
        End Try
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As RelacionEntidadDAO
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_ENTIDAD_DAO_XREF_SP, conexion)
            Dim dataReader As SqlDataReader
            Dim oFactory As RelacionEntidadDAO = Nothing
            Dim criteria As GenericQueryCriteria = CType(queryCriteria, GenericQueryCriteria)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@entidad", criteria.stringCriteria)

            dataReader = comando.ExecuteReader()

            While dataReader.Read
                oFactory = New RelacionEntidadDAO(dataReader.GetValue(0).ToString, criteria.stringCriteria)
                Exit While
            End While

            conexion.Close()
            comando.Dispose()
            dataReader.Close()

            Return oFactory
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_ENTIDAD_DAO_XREF_SP)
        End Try
    End Function

    Public Overrides Sub calcularVerificadorVertical()

    End Sub

    Public Overrides Function checkearVerificadorVertical() As Boolean
        Return True
    End Function

    Public Overrides Sub calcularVerificadorHoriontal()

    End Sub
End Class
