Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class RelacionComandoAccionResultadoDao
    Inherits AbstractDao(Of RelacionComandoAccionResultado)


    Public Overrides Function actualizar(oEntity As RelacionComandoAccionResultado) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of RelacionComandoAccionResultado)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As RelacionComandoAccionResultado) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of RelacionComandoAccionResultado)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As RelacionComandoAccionResultado) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of RelacionComandoAccionResultado)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of RelacionComandoAccionResultado)
        If Not queryCriteria Is Nothing Then
            Try
                Dim criteria As GenericQueryCriteria = DirectCast(queryCriteria, GenericQueryCriteria)
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand
                Dim reader As SqlDataReader
                Dim elemento As RelacionComandoAccionResultado
                Dim listaElementos As List(Of RelacionComandoAccionResultado) = New List(Of RelacionComandoAccionResultado)

                'Si estoy buscando los habilitados por bitacora
                If criteria.booleanCriteria = True Then
                    comando = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_EVENTOS_DE_BITACORA_SP, conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    conexion.Open()

                    reader = comando.ExecuteReader()
                    While reader.Read()
                        elemento = New RelacionComandoAccionResultado()
                        elemento.id = reader.GetValue(0)
                        elemento.comando = reader.GetValue(1)
                        elemento.accion = reader.GetValue(2)
                        elemento.bitacoraActiva = reader.GetValue(3)
                        elemento.evento = reader.GetValue(4)
                        elemento.resultado = reader.GetValue(5)
                        listaElementos.Add(elemento)
                    End While

                    conexion.Close()
                    comando.Dispose()
                    reader.Close()

                    Return listaElementos
                End If
            Catch e As ExcepcionDeComando
                Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_EVENTOS_DE_BITACORA_SP)
            End Try

        End If

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As RelacionComandoAccionResultado
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_COMANDO_ACCION_RESULTADO_XREF_SP, conexion)
            Dim dataReader As SqlDataReader
            Dim oFactory As RelacionComandoAccionResultado = Nothing
            Dim criteria As ComandoQueryCriteria = CType(queryCriteria, ComandoQueryCriteria)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@accion", criteria.Accion)
            comando.Parameters.AddWithValue("@resultado", criteria.Resultado)


            dataReader = comando.ExecuteReader()

            While dataReader.Read
                oFactory = New RelacionComandoAccionResultado()
                oFactory.comando = dataReader.GetValue(0)
                oFactory.accion = criteria.Accion
                oFactory.resultado = criteria.Resultado
                oFactory.id = dataReader.GetValue(1)
                Exit While
            End While

            conexion.Close()
            comando.Dispose()
            dataReader.Close()

            Return oFactory
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_COMANDO_ACCION_RESULTADO_XREF_SP)
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
