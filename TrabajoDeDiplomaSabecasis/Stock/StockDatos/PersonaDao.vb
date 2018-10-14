Imports StockModelo
Imports System.Data.SqlClient
Imports ElementosTransversales

Public Class PersonaDao
    Inherits AbstractDao(Of Persona)

    Public Overrides Function actualizar(oEntity As Persona) As Boolean
        Return Nothing
    End Function

    Public Overrides Function actualizarMuchos(oEntityList As List(Of Persona)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function eliminar(oEntity As Persona) As Boolean
        Return Nothing
    End Function

    Public Overrides Function elminarMuchos(oEntityList As List(Of Persona)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardar(oEntity As Persona) As Boolean
        Return Nothing
    End Function

    Public Overrides Function guardarMuchos(oEntityList As List(Of Persona)) As Boolean
        Return Nothing
    End Function

    Public Overrides Function obtenerMuchos(queryCriteria As QueryCriteria) As List(Of Persona)
        Return Nothing
    End Function

    Public Overrides Function obtenerUno(queryCriteria As QueryCriteria) As Persona
        If Not queryCriteria Is Nothing Then
            Dim criteria As GenericQueryCriteria = queryCriteria
            If criteria.integerCriteria <> 0 Then
                Try
                    Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
                    Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.OBTENER_PERSONA_POR_ID_SP, conexion)
                    Dim dataReader As SqlDataReader
                    Dim persona As Persona = Nothing
                    Dim localidadDao As AbstractDao(Of Localidad) = DaoFactory(Of Localidad).obtenerInstancia().crear(GetType(Localidad))
                    Dim locCriteria As GenericQueryCriteria = New GenericQueryCriteria()
                    conexion.Open()

                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@persona_id", criteria.integerCriteria)

                    dataReader = comando.ExecuteReader()

                    While dataReader.Read
                        persona = New Persona()
                        persona.id = dataReader.GetValue(0)
                        persona.nombre = dataReader.GetValue(1)
                        persona.apellido = dataReader.GetValue(2)
                        If Not IsDBNull(dataReader.GetValue(3)) Then
                            persona.documento = dataReader.GetValue(3)
                        Else
                            persona.documento = 0
                        End If
                        persona.tipoDocumento = New TipoDocumento()
                        persona.tipoDocumento.id = dataReader.GetValue(4)
                        persona.contacto = New Contacto()
                        persona.contacto.id = dataReader.GetValue(5)
                        persona.contacto.calle = dataReader.GetValue(6)
                        If Not IsDBNull(dataReader.GetValue(7)) Then
                            persona.contacto.departamento = dataReader.GetValue(7)
                        Else
                            persona.contacto.departamento = 0
                        End If

                        persona.contacto.email = dataReader.GetValue(8)
                        locCriteria.integerCriteria = dataReader.GetValue(9)
                        persona.contacto.localidad = localidadDao.obtenerUno(locCriteria)
                        persona.contacto.nroPuerta = dataReader.GetValue(10)
                        If Not IsDBNull(dataReader.GetValue(11)) Then
                            persona.contacto.piso = dataReader.GetValue(11)
                        Else
                            persona.contacto.piso = 0
                        End If

                        'todo: agregar telefonos
                        Exit While
                    End While

                    conexion.Close()
                    comando.Dispose()
                    dataReader.Close()

                    Return persona
                Catch ex As Exception
                    Throw New ExcepcionDeDatos(ex, Me.GetType.Name, ConstantesDeDatos.OBTENER_PERSONA_POR_ID_SP)
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
