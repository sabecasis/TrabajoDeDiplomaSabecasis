Imports StockModelo
Imports ElementosTransversales
Imports System.Data.SqlClient

Public Class TipoDeExcepcionDao
    Inherits AbstractDao(Of TipoDeExcepcion)

    Public Overrides Function actualizar(oEntity As TipoDeExcepcion) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of TipoDeExcepcion)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As TipoDeExcepcion) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of TipoDeExcepcion)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As TipoDeExcepcion) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of TipoDeExcepcion)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of TipoDeExcepcion)
        Dim query As String = ""
        Try
            If queryCriteria Is Nothing Then
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_TIPOS_DE_EXCEPCION_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim listaTipos As List(Of TipoDeExcepcion) = New List(Of TipoDeExcepcion)
                Dim oTipo As TipoDeExcepcion

                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()

                dataReader = comando.ExecuteReader()
                While dataReader.Read
                    oTipo = New TipoDeExcepcion()
                    oTipo.id = dataReader.GetValue(0)
                    oTipo.tipo = dataReader.GetValue(1)
                    listaTipos.Add(oTipo)
                End While

                conexion.Close()
                comando.Dispose()

                Return listaTipos
            End If
        Catch ex As Exception
            Throw New ExcepcionDeDatos(ex, Me.GetType.ToString, query)
        End Try

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As TipoDeExcepcion
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
