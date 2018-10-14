Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class CalcularFaltantesDeStockCmd
    Inherits Comando(Of List(Of ExistenciaDeProductoEnStock), CalcularFaltantesDeStockAccion)


    Public Overrides Function execute(accion As CalcularFaltantesDeStockAccion) As List(Of ExistenciaDeProductoEnStock)
        Try
            Dim cmd As New ObenerTodasLasExistenciasDeStockCmd
            'obtengo la lista de existencias en stock por producto por deposito
            Dim listaProductos As List(Of ExistenciaDeProductoEnStock) = cmd.execute(New ObtenerTodasLasExistenciasDeStockAccion(accion.deposito.id, 0))
            Dim esFaltante As Boolean
            Dim listaResultado As New List(Of ExistenciaDeProductoEnStock)
            For Each existencia As ExistenciaDeProductoEnStock In listaProductos
                esFaltante = CalculadorDeFaltanteEnStockPorModo.calcular(existencia, accion.deposito.id)
                If esFaltante Then
                    listaResultado.Add(existencia)
                End If
            Next
            Return listaResultado
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
