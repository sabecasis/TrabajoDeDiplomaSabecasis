Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerInstanciasDeProductoConFiltroCmd
    Inherits Comando(Of List(Of InstanciaDeProducto), ObtenerInstanciasDeProductoConFiltroAccion)


    Public Overrides Function execute(accion As ObtenerInstanciasDeProductoConFiltroAccion) As List(Of InstanciaDeProducto)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia.crear(GetType(InstanciaDeProducto))
            Dim criteria As New InstanciaConFiltroQueryCriteria
            criteria.idSucursal = accion.sucursal.id
            criteria.idProducto = accion.producto.id
            criteria.idDeposito = accion.deposito.id
            criteria.idFamilia = accion.familia.id
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
