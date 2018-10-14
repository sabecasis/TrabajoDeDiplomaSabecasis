Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObenerTodasLasExistenciasDeStockCmd
    Inherits Comando(Of List(Of ExistenciaDeProductoEnStock), ObtenerTodasLasExistenciasDeStockAccion)

    Public Overrides Function execute(accion As ObtenerTodasLasExistenciasDeStockAccion) As List(Of ExistenciaDeProductoEnStock)
        Try
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim listaExistencias As New List(Of ExistenciaDeProductoEnStock)
            If accion.iddeposito = 0 And accion.idproducto = 0 Then
                Dim dao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
                Dim productos As List(Of Producto) = dao.obtenerMuchos(Nothing)
                Dim resultado As ExistenciaDeProductoEnStock
                For Each prod As Producto In productos
                    resultado = New ExistenciaDeProductoEnStock
                    resultado.ciclo = prod.ciclo
                    resultado.cantidad = prod.instanciasDeProductoActivas.Count
                    resultado.idProducto = prod.id
                    resultado.maxStock = prod.maxStock
                    resultado.minStock = prod.minStock
                    resultado.modoReposicion = New MetodoDeReposicion
                    resultado.modoReposicion.metodo = prod.metodoDeReposicion.metodo
                    resultado.modoReposicion.metodo = prod.metodoDeReposicion.id
                    resultado.producto = prod.nombre
                    listaExistencias.Add(resultado)
                Next
            Else
                Dim criteria As New ExistenciaQueryCriteria
                criteria.idDeposito = accion.iddeposito
                criteria.idProducto = accion.idproducto
                Dim dao As AbstractDao(Of ExistenciaDeProductoEnStock) = DaoFactory(Of ExistenciaDeProductoEnStock).obtenerInstancia().crear(GetType(ExistenciaDeProductoEnStock))
                Return dao.obtenerMuchos(criteria)
            End If
            Return listaExistencias
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
