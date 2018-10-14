Imports StockModelo
Imports StockControladorAccion
Imports StockDatos

Public Class ObtenerTodosLosEventosDeBitacoraCmd
    Inherits Comando(Of List(Of RelacionComandoAccionResultado), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of RelacionComandoAccionResultado)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of RelacionComandoAccionResultado) = DaoFactory(Of RelacionComandoAccionResultado).obtenerInstancia().crear(GetType(RelacionComandoAccionResultado))
        Dim criteria As GenericQueryCriteria = New GenericQueryCriteria()
        criteria.booleanCriteria = True
        Dim lista As List(Of RelacionComandoAccionResultado) = dao.obtenerMuchos(criteria)
        Return lista
    End Function
End Class
