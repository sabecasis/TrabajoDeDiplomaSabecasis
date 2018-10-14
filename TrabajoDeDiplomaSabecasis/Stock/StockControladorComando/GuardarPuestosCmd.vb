Imports StockModelo
Imports StockDatos
Imports StockControladorAccion
Imports ElementosTransversales

Public Class GuardarPuestosCmd
    Inherits Comando(Of String, GuardarPuestosAccion)

    Public Overrides Function execute(accion As GuardarPuestosAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
        Dim puestos As List(Of Puesto) = accion.puestos
        Dim dao As AbstractDao(Of Puesto) = DaoFactory(Of Puesto).obtenerInstancia().crear(GetType(Puesto))
        Dim optCMD As ObtenerTodosLosPuestosCmd = New ObtenerTodosLosPuestosCmd()
        Dim puestosExistentes As List(Of Puesto) = optCMD.execute(New ObtenerTodosAccion())
        Dim puestosAGuardar As List(Of Puesto) = New List(Of Puesto)
        If puestos.Count > 0 Then
            Dim esExitoso As Boolean = dao.guardarMuchos(puestos)
            If esExitoso Then
                Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.PUESTO_GUARDADO_CON_EXITO)
            Else
                Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_GUARDAR_PUESTO)
            End If
        Else
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_HAY_NUEVO_PUESTO)
        End If
    End Function
End Class
