Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class GuardarRolCmd
    Inherits Comando(Of String, GuardarRolAccion)



    Public Overrides Function execute(accion As GuardarRolAccion) As String
        Dim oAutorizador = Autorizador.obtenerInstancia()
        Dim oSesion = Sesion.obtenerInstancia()
        Dim dao As AbstractDao(Of Rol) = DaoFactory(Of Rol).obtenerInstancia().crear(GetType(Rol))
        Dim oRol As Rol = New Rol()
        Dim esExitoso As Boolean
        oRol.id = accion.id
        oRol.rol = accion.nombre
        oRol.modulo = accion.modulo
        oRol.descripcion = accion.descripcion
        oRol.grupos = accion.grupos
        oRol.permisos = accion.permisos
        If oRol.id = 0 Then
            oAutorizador.autorizar(ConstantesDePermisos.CREAR)
            esExitoso = dao.guardar(oRol)
        Else
            oAutorizador.autorizar(ConstantesDePermisos.ACTUALIZAR)
            esExitoso = dao.actualizar(oRol)
        End If
        If esExitoso Then
            Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ROL_GUARDADO_CORRECTAMENTE)
        Else
            Return oSesion.correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_GUARDAR_ROL)
        End If
        Return Nothing
    End Function
End Class
