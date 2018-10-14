Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class LoginCmd
    Inherits Comando(Of RespuestaSeguridad, LoginAccion)

    Public Overrides Function execute(accion As LoginAccion) As RespuestaSeguridad
        Dim oSesion As Sesion = Sesion.obtenerInstancia()
        Dim oCriptografia As Criptografia = Criptografia.ObtenerInstancia()
        Dim dao As AbstractDao(Of Usuario)
        Dim oDaoFactory As DaoFactory(Of Usuario) = DaoFactory(Of Usuario).obtenerInstancia()
        Dim usuario As Usuario = New Usuario()
        Dim respuesta As RespuestaSeguridad = New RespuestaSeguridad
        respuesta.estaAutenticado = False
        usuario.nombre = accion.usuario
        usuario.password = accion.password
        dao = oDaoFactory.crear(GetType(Usuario))
        If Not dao Is Nothing Then
            Dim queryCriteria As GenericQueryCriteria = New GenericQueryCriteria()
            queryCriteria.stringCriteria = oCriptografia.CypherTripleDES(accion.usuario, oSesion.DESSEED, True)
            usuario = dao.obtenerUno(queryCriteria)
            If Not usuario Is Nothing Then
                If Not usuario.bloqueado Then

                    Dim claveEncriptada As String = oCriptografia.GetHashMD5(accion.password)

                    If usuario.password.Equals(claveEncriptada) Then
                        respuesta.estaAutenticado = True
                        usuario.contadorMalaPassword = 0
                        Sesion.obtenerInstancia().usuarioActual = usuario
                        Dim guardarEnBitacora As New GuardarEnBitacoraCmd()
                        guardarEnBitacora.execute(New GuardarEnBitacoraAccion(GetType(LoginAccion).ToString, "Nothing"))
                    Else
                        usuario.contadorMalaPassword += 1
                        respuesta.estaAutenticado = False
                        If usuario.contadorMalaPassword >= 3 Then
                            usuario.bloqueado = True
                            respuesta.razon = oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_BLOQUEADO)
                        Else
                            respuesta.razon = oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.PASSWORD_INCORRECTA)
                        End If
                    End If

                    dao.actualizar(usuario)
                Else
                    respuesta.estaAutenticado = False
                    respuesta.razon = oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_BLOQUEADO)
                End If
            Else
                respuesta.estaAutenticado = False
                respuesta.razon = oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_INEXISTENTE)
            End If

        End If
        Return respuesta
    End Function
End Class
