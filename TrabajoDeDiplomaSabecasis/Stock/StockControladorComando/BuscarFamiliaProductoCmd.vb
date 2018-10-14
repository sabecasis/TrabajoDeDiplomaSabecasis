Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarFamiliaProductoCmd
    Inherits Comando(Of FamiliaDeProducto, BuscarFamiliaProductoAccion)

    Public Overrides Function execute(accion As BuscarFamiliaProductoAccion) As FamiliaDeProducto
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of FamiliaDeProducto) = DaoFactory(Of FamiliaDeProducto).obtenerInstancia.crear(GetType(FamiliaDeProducto))
            Dim criteria As New GenericQueryCriteria
            criteria.integerCriteria = accion.id
            criteria.stringCriteria = accion.familia
            Return dao.obtenerUno(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
