Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarIdiomaCmd
    Inherits Comando(Of List(Of RelacionElementoIdioma), BuscarIdiomaAccion)

    Public Overrides Function execute(accion As BuscarIdiomaAccion) As List(Of RelacionElementoIdioma)
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            Dim idioDao As AbstractDao(Of Idioma) = DaoFactory(Of Idioma).obtenerInstancia().crear(GetType(Idioma))
            Dim idioCriteria As New GenericQueryCriteria
            idioCriteria.stringCriteria = accion.idioma
            Dim idiom As Idioma = idioDao.obtenerUno(idioCriteria)
            Dim dao As AbstractDao(Of RelacionElementoIdioma) = DaoFactory(Of RelacionElementoIdioma).obtenerInstancia().crear(GetType(RelacionElementoIdioma))
            Dim relacion As New RelacionElementoIdioma
            relacion.idioma = idiom
            Dim criteria As New GenericQueryCriteria
            criteria.oObject = relacion
            Dim listaElementos As IList(Of RelacionElementoIdioma) = dao.obtenerMuchos(criteria)
            Return listaElementos
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.Name, accion)
        End Try
        Return Nothing
    End Function
End Class
