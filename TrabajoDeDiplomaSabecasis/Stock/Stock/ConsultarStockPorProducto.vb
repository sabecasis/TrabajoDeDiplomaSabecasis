Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class ConsultarStockPorProducto

    Private Sub ConsultarStockPorProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub limpiar()
        Try
            DGVExistencias.DataSource = Dispatcher(Of List(Of ExistenciaDeProductoEnStock), ObtenerTodasLasExistenciasDeStockAccion).execute(New ObtenerTodasLasExistenciasDeStockAccion(0, 0))
            TXTDeposito.Text = 0
            TXTProducto.Text = 0
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNLimpiarFiltroProductos_Click(sender As Object, e As EventArgs) Handles BTNLimpiarFiltroProductos.Click
        limpiar()
    End Sub

    Private Sub BTNFiltrarListaProductos_Click(sender As Object, e As EventArgs) Handles BTNFiltrarListaProductos.Click
        Try
            DGVExistencias.DataSource = Dispatcher(Of List(Of ExistenciaDeProductoEnStock), ObtenerTodasLasExistenciasDeStockAccion).execute(New ObtenerTodasLasExistenciasDeStockAccion(CType(TXTDeposito.Text, Integer), CType(TXTProducto.Text, Integer)))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub
End Class