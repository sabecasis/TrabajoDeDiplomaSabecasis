Imports StockModelo
Imports StockControladorAccion
Imports StockDatos

Public Class ObtenerElementosDeIdiomaCmd
    Inherits Comando(Of List(Of ElementoDeIdioma), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of ElementoDeIdioma)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of ElementoDeIdioma) = DaoFactory(Of ElementoDeIdioma).obtenerInstancia().crear(GetType(ElementoDeIdioma))
        'Envío un GenericQueryCriteria vacío para obtener todos los elementos existentes.
        Return dao.obtenerMuchos(New GenericQueryCriteria())
    End Function
End Class
