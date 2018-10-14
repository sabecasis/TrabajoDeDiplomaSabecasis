Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class TipoDocumentoDao
    Inherits AbstractDao(Of TipoDocumento)

    Public Overrides Function actualizar(oEntity As TipoDocumento) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of TipoDocumento)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As TipoDocumento) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of TipoDocumento)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As TipoDocumento) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of TipoDocumento)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of TipoDocumento)
        Dim criteria As GenericQueryCriteria = queryCriteria
        If criteria Is Nothing Then
            Try
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_TIPOS_DE_DOCUMENTO_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim listaTiposDocumentos As List(Of TipoDocumento) = New List(Of TipoDocumento)
                Dim oTipoDoc As TipoDocumento

                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    oTipoDoc = New TipoDocumento()
                    oTipoDoc.id = dataReader.GetValue(0)
                    oTipoDoc.tipoDocumento = dataReader.GetValue(1)
                    oTipoDoc.descripcion = dataReader.GetValue(2)
                    listaTiposDocumentos.Add(oTipoDoc)
                End While

                conexion.Close()
                comando.Dispose()

                Return listaTiposDocumentos
            Catch e As Exception
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_TIPOS_DE_DOCUMENTO_SP)
            End Try

        End If
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As TipoDocumento
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
