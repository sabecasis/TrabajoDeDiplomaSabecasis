Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class RelacionElementoIdiomaDao
    Inherits AbstractDao(Of RelacionElementoIdioma)


    Public Overrides Function actualizar(oEntity As RelacionElementoIdioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of RelacionElementoIdioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As RelacionElementoIdioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of RelacionElementoIdioma)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As RelacionElementoIdioma) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of RelacionElementoIdioma)) As Boolean
        'todo: checkear si la relacion no existe antes de crear
        Try
            Dim idiomaDao As AbstractDao(Of Idioma) = DaoFactory(Of Idioma).obtenerInstancia().crear(GetType(Idioma))
            Dim esExitoso As Boolean = idiomaDao.guardar(oEntityList.Item(0).idioma)
            Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.GUARDAR_RELACION_ELEMENTO_IDIOMA_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()
            For Each oEntity As RelacionElementoIdioma In oEntityList

                comando.Parameters.Clear()

                comando.Parameters.AddWithValue("@elemento_id", oEntity.elemento.id)
                comando.Parameters.AddWithValue("@texto", oEntity.texto)
                comando.Parameters.AddWithValue("@idioma_id", oEntityList.Item(0).idioma.id)

                comando.ExecuteNonQuery()
            Next

            conexion.Close()
            comando.Dispose()
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.GUARDAR_RELACION_ELEMENTO_IDIOMA_SP)
        End Try
        Return True
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of RelacionElementoIdioma)
        Dim criteria As GenericQueryCriteria = queryCriteria
        Try
            If Not criteria Is Nothing Then
                Dim relElementoIdioma As RelacionElementoIdioma = TryCast(criteria.oObject, RelacionElementoIdioma)
                If Not relElementoIdioma Is Nothing And Not relElementoIdioma.idioma Is Nothing Then
                    If relElementoIdioma.idioma.id <> 0 Then
                        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                        Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_RELACIONES_ELEMENTO_IDIOMA_POR_IDIOMA_SP, conexion)
                        Dim dataReader As SqlDataReader
                        Dim relEelementoIdiomaResult As RelacionElementoIdioma
                        Dim relElementoIdiomaList As List(Of RelacionElementoIdioma) = New List(Of RelacionElementoIdioma)

                        comando.CommandType = CommandType.StoredProcedure

                        conexion.Open()

                        comando.Parameters.Clear()
                        comando.Parameters.AddWithValue("@idioma_id", relElementoIdioma.idioma.id)

                        dataReader = comando.ExecuteReader()
                        While dataReader.Read()
                            relEelementoIdiomaResult = New RelacionElementoIdioma()
                            relEelementoIdiomaResult.texto = dataReader.GetValue(0)
                            relEelementoIdiomaResult.elemento = New ElementoDeIdioma()
                            relEelementoIdiomaResult.elemento.id = dataReader.GetValue(1)
                            relEelementoIdiomaResult.elemento.nombre = dataReader.GetValue(2)
                            relEelementoIdiomaResult.idioma = New Idioma()
                            relEelementoIdiomaResult.idioma.id = dataReader.GetValue(3)
                            relEelementoIdiomaResult.idioma.descripcion = dataReader.GetValue(4)
                            relEelementoIdiomaResult.idioma.cultura = New System.Globalization.CultureInfo(dataReader.GetValue(5).ToString)
                            relElementoIdiomaList.Add(relEelementoIdiomaResult)
                        End While

                        conexion.Close()
                        comando.Dispose()

                        Return relElementoIdiomaList
                    End If
                Else
                    'obtener todos
                End If
            End If
        Catch e As Exception
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.OBTENER_RELACIONES_ELEMENTO_IDIOMA_POR_IDIOMA_SP)
        End Try

        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As RelacionElementoIdioma
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
