Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales


Public Class GuardarGrupoCmd
    Inherits Comando(Of String, GuardarGrupoAccion)

    Public Overrides Function execute(accion As GuardarGrupoAccion) As String
        Dim dao As AbstractDao(Of Grupo) = DaoFactory(Of Grupo).obtenerInstancia().crear(GetType(Grupo))
        Dim grupo As Grupo = New Grupo()
        grupo.id = accion.idGrupo
        grupo.nombre = Criptografia.ObtenerInstancia().CypherTripleDES(accion.nombre, Sesion.obtenerInstancia().DESSEED, True)
        grupo.elementos = accion.elementos
        Dim esExitoso As Boolean = False
        If accion.idGrupo = 0 Then
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
            esExitoso = dao.guardar(grupo)
        Else
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ACTUALIZAR)
            esExitoso = dao.actualizar(grupo)
        End If
        If esExitoso Then
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.GRUPO_GUARDADO_CON_EXITO)
        Else
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_GUARDAR_GRUPO)
        End If
    End Function
End Class
