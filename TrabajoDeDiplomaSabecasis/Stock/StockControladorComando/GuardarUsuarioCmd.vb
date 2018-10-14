Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class GuardarUsuarioCmd
    Inherits Comando(Of String, GuardarUsuarioAccion)


    Public Overrides Function execute(accion As GuardarUsuarioAccion) As String
        Dim dao As AbstractDao(Of Usuario) = DaoFactory(Of Usuario).obtenerInstancia().crear(GetType(Usuario))
        Dim oUsuario As Usuario = New Usuario()
        If Not accion.passwordDos Is Nothing And Not accion.passwordUno Is Nothing And accion.passwordDos.Equals(accion.passwordUno) Then
            oUsuario.password = Criptografia.ObtenerInstancia().GetHashMD5(accion.passwordUno)
        ElseIf accion.idUsuario = 0 Then
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.CONTRASENIAS_DISTINTAS)
        End If

        oUsuario.preguntaSecreta = Criptografia.ObtenerInstancia().CypherTripleDES(accion.pregunta, Sesion.obtenerInstancia().DESSEED, True)
        oUsuario.nombre = Criptografia.ObtenerInstancia().CypherTripleDES(accion.usuario, Sesion.obtenerInstancia().DESSEED, True)
        oUsuario.respuestaSecreta = Criptografia.ObtenerInstancia().CypherTripleDES(accion.respuesta, Sesion.obtenerInstancia().DESSEED, True)
        oUsuario.contadorMalaPassword = 0
        oUsuario.empleados = accion.empleados
        oUsuario.bloqueado = accion.bloqueado
        oUsuario.id = accion.idUsuario
        Dim esExitoso As Boolean
        If accion.idUsuario = 0 Then
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
            esExitoso = dao.guardar(oUsuario)
        Else
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ACTUALIZAR)
            esExitoso = dao.actualizar(oUsuario)
        End If

        If esExitoso Then
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_CREADO_CON_EXITO)
        Else
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_CREAR_USUARIO)
        End If
        Return Nothing
    End Function
End Class
