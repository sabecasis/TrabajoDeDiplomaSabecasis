Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class EliminarIdiomaCmd
    Inherits Comando(Of String, EliminarIdiomaAccion)

    Public Overrides Function execute(accion As EliminarIdiomaAccion) As String
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ELIMINAR)
            Dim idioDao As AbstractDao(Of Idioma) = DaoFactory(Of Idioma).obtenerInstancia().crear(GetType(Idioma))
            Dim idioCriteria As New GenericQueryCriteria
            idioCriteria.stringCriteria = accion.idioma
            Dim idiom As Idioma = idioDao.obtenerUno(idioCriteria)
            idioDao.eliminar(idiom)
            Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.IDIOMA_ELIMINADO)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
