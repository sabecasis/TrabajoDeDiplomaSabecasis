Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodasLasInstanciasProductoParaEgresoCmd
    Inherits Comando(Of List(Of InstanciaDeProducto), ObtenerTodasLasInstanciasProductoParaEgresoAccion)


    Public Overrides Function execute(accion As ObtenerTodasLasInstanciasProductoParaEgresoAccion) As List(Of InstanciaDeProducto)
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BUSCAR)
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim dao As AbstractDao(Of InstanciaDeProducto) = DaoFactory(Of InstanciaDeProducto).obtenerInstancia().crear(GetType(InstanciaDeProducto))
            Dim criteria As New InstanciaDeProductoQueryCriteria
            criteria.idProducto = accion.idProducto
            criteria.idDeposito = accion.idDeposito
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
