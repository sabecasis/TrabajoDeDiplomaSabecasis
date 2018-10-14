Imports StockModelo
Imports StockDatos
Imports StockControladorAccion

Public Class ObtenerTodosLosTiposDeDocumentoCmd
    Inherits Comando(Of List(Of TipoDocumento), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of TipoDocumento)
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
        Dim dao As AbstractDao(Of TipoDocumento) = DaoFactory(Of TipoDocumento).obtenerInstancia().crear(GetType(TipoDocumento))
        Return dao.obtenerMuchos(Nothing)
    End Function
End Class
