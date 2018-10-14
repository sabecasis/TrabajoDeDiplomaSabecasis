Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class BuscarUsuarioCmd
    Inherits Comando(Of Usuario, BuscarUsuarioAccion)


    Public Overrides Function execute(accion As BuscarUsuarioAccion) As Usuario
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            Dim oCriptografia As Criptografia = Criptografia.ObtenerInstancia()
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            Dim dao As AbstractDao(Of Usuario) = DaoFactory(Of Usuario).obtenerInstancia().crear(GetType(Usuario))
            Dim criteria As GenericQueryCriteria = New GenericQueryCriteria()
            criteria.stringCriteria = oCriptografia.CypherTripleDES(accion.usuario, oSesion.DESSEED, True)
            Dim oUsuario As Usuario = dao.obtenerUno(criteria)
            If Not oUsuario Is Nothing Then
                oUsuario.preguntaSecreta = oCriptografia.DecypherTripleDES(oUsuario.preguntaSecreta, oSesion.DESSEED, True)
                oUsuario.nombre = oCriptografia.DecypherTripleDES(oUsuario.nombre, oSesion.DESSEED, True)
                oUsuario.respuestaSecreta = oCriptografia.DecypherTripleDES(oUsuario.respuestaSecreta, oSesion.DESSEED, True)
            End If
            Return oUsuario
        Catch e As Exception
            Throw New ExcepcionDeComando(e, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
