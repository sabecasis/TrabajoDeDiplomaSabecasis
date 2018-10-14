Imports StockModelo
Imports ElementosTransversales
Imports StockDatos

Public Class Autorizador

    Private Shared oInstancia As Autorizador = New Autorizador()

    Property moduloActual As String

    Public Shared Function obtenerInstancia() As Autorizador
        Return oInstancia
    End Function

    Private Sub New()

    End Sub

    Private Function obtenerOpciones(oGrupo As Grupo) As List(Of String)
        Try
            Dim listaRetorno As List(Of String) = New List(Of String)
            If Not oGrupo.roles Is Nothing Then
                'obtener dentro del grupo actual
                For Each oRol As Rol In oGrupo.roles
                    If oRol.id > 25 Then
                        listaRetorno.Add(oRol.modulo.url)
                    End If
                Next
            End If

            'si el grupo a su vez pertenece a otros grupos, buscar ahí adentro también
            If Not oGrupo.elementos Is Nothing Then
                For Each oElemento As Grupo In oGrupo.elementos
                    listaRetorno.AddRange(obtenerOpciones(oElemento))
                Next
            End If
            Return listaRetorno
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try
        Return Nothing
    End Function

    Public Function retornarOpcionesDisponibles() As List(Of String)
        Try
            Dim elementos As List(Of ElementoDeSeguridad) = Sesion.obtenerInstancia().usuarioActual.elementos
            Dim opciones As List(Of String) = New List(Of String)
            If Not elementos Is Nothing Then
                For Each oGrupo As Grupo In elementos
                    opciones.AddRange(obtenerOpciones(oGrupo))
                Next
            End If
            Return opciones
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try
        Return Nothing
    End Function


    Public Sub checkearVerificadoresVerticales()
        Try
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            Dim ok As Boolean = False
            Dim rolDao As RolDao = New RolDao()
            Dim usuarioDao As UsuarioDao = New UsuarioDao()
            If Not rolDao.checkearVerificadorVertical() Then
                Throw New DigitoVerificadorException("Rol", -1, oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL))
            End If
            If Not usuarioDao.checkearVerificadorVertical() Then
                Throw New DigitoVerificadorException("Usuario", -1, oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_DGV_HORIZONTAL))
            End If
        Catch dg As DigitoVerificadorException
            Throw dg
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try
    End Sub

    Public Function autorizar(permiso As String) As Boolean
        Try
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            If oSesion.usuarioActual.nombre.Equals("SuperAdmin") Then
                Return True
            End If
            If oSesion.bloqueado Then
                Throw New AutorizacionException(permiso)
            End If
            Dim resultado As Boolean = False
            Dim grupos As List(Of ElementoDeSeguridad) = oSesion.usuarioActual.elementos
            If Not grupos Is Nothing Then
                For Each oGrupo As Grupo In grupos
                    resultado = resultado Or checkearRoles(oGrupo, permiso)
                Next
            End If
            If resultado = False Then
                Throw New AutorizacionException(permiso)
            End If
            Return resultado
        Catch au As AutorizacionException
            Throw au
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            Return True
        End Try
    End Function

    Private Function checkearRoles(oGrupo As Grupo, permiso As String) As Boolean
        Try
            Dim resultado As Boolean = False
            If Not oGrupo.roles Is Nothing Then
                'checkear dentro del grupo actual
                For Each oRol As Rol In oGrupo.roles
                    If Not oRol.permisos Is Nothing Then
                        For Each oPermiso As Permiso In oRol.permisos
                            If oPermiso.nombre.Equals(permiso) And oRol.modulo.url.Equals(Me.moduloActual) Then
                                Return True
                            End If
                        Next
                    End If
                Next
                'y si no está en este grupo probablemente esté en alguno de los superiores
                If Not oGrupo.elementos Is Nothing Then
                    For Each oElemento As Grupo In oGrupo.elementos
                        resultado = resultado Or checkearRoles(oElemento, permiso)
                    Next
                End If
            End If
            'si en el arbol alguno es true, el resultado final va a ser true
            Return resultado
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            Return False
        End Try
    End Function


End Class
