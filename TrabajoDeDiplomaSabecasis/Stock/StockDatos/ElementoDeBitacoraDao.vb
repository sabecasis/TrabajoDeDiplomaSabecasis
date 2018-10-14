Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class ElementoDeBitacoraDao
    Inherits AbstractDao(Of ElementoDeBitacora)

    Public Overrides Function actualizar(oEntity As ElementoDeBitacora) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of ElementoDeBitacora)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As ElementoDeBitacora) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of ElementoDeBitacora)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As ElementoDeBitacora) As Boolean
        Try
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand

            'Si estoy buscando los habilitados por bitacora
            comando = New SqlCommand(ConstantesDeDatos.GUARDAR_EN_BITACORA_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idEvento", oEntity.evento)

            Dim nombreUsuario = Sesion.obtenerInstancia().usuarioActual.nombre
            If Not nombreUsuario Is Nothing Then
                nombreUsuario = Criptografia.ObtenerInstancia.CypherTripleDES(nombreUsuario, Sesion.obtenerInstancia().DESSEED, True)
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            Else
                comando.Parameters.AddWithValue("@nombreUsuario", "USUARIO_NO_IDENTIFICADO")
            End If

            conexion.Open()

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

            Return True

        Catch e As ExcepcionDeComando
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.GUARDAR_EN_BITACORA_SP)
        End Try
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of ElementoDeBitacora)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of ElementoDeBitacora)
        Try
            If Not queryCriteria Is Nothing Then
                Dim criteria As ElementoDeBitacoraQueryCriteria = DirectCast(queryCriteria, ElementoDeBitacoraQueryCriteria)
                Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_TODOS_LOS_ELEMENTOS_DE_BITACORA_SP, conexion)
                Dim dataReader As SqlDataReader
                Dim listaElementos As List(Of ElementoDeBitacora) = New List(Of ElementoDeBitacora)
                Dim elemento As ElementoDeBitacora

                conexion.Open()
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@usuario", criteria.usuario)
                comando.Parameters.AddWithValue("@idEvento", criteria.evento)
                comando.Parameters.AddWithValue("@fecha", criteria.fecha.ToString("yyyy-MM-dd"))

                dataReader = comando.ExecuteReader()

                While dataReader.Read()
                    elemento = New ElementoDeBitacora()
                    elemento.evento = dataReader.GetValue(0)
                    elemento.hora = dataReader.GetValue(1).ToString()
                    elemento.fecha = dataReader.GetValue(2)
                    elemento.id = dataReader.GetValue(3)
                    elemento.usuario = Criptografia.ObtenerInstancia().DecypherTripleDES(dataReader.GetValue(4), Sesion.obtenerInstancia().DESSEED, True)
                    listaElementos.Add(elemento)
                End While

                dataReader.Close()
                conexion.Close()
                comando.Dispose()

                Return listaElementos
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_TODOS_LOS_ELEMENTOS_DE_BITACORA_SP)
        End Try

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As ElementoDeBitacora

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
