Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class CrearNuevoIdiomaCmd
    Inherits Comando(Of String, CrearIdiomaAccion)

    Public Overrides Function execute(accion As CrearIdiomaAccion) As String
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.CREAR)
            Dim dao As AbstractDao(Of RelacionElementoIdioma) = DaoFactory(Of RelacionElementoIdioma).obtenerInstancia().crear(GetType(RelacionElementoIdioma))
            Dim esExitoso As Boolean = dao.guardarMuchos(accion.elementosDeIdioma)
            If esExitoso Then
                Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.IDIOMA_GUARDADO_CON_EXITO)
            Else
                Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ERROR_AL_CREAR_IDIOMA)
            End If
    End Function
End Class
