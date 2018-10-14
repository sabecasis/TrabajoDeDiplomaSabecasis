Imports StockControlador
Imports StockControladorAccion
Imports StockModelo
Imports ElementosTransversales

Public Class GestionarInstanciasDeProducto

    Private Sub GestionarInstanciasDeProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CMBProducto.DataSource = Dispatcher(Of List(Of Producto), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBProducto.DisplayMember = "nombre"
            CMBDeposito.DataSource = Dispatcher(Of List(Of Deposito), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBDeposito.DisplayMember = "nomber"
            CMBFamiliaDeProducto.DataSource = Dispatcher(Of List(Of FamiliaDeProducto), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBFamiliaDeProducto.DisplayMember = "familia"
            CMBSucursal.DataSource = Dispatcher(Of List(Of Sucursal), ObtenerTodosAccion).execute(New ObtenerTodosAccion)
            CMBSucursal.DisplayMember = "id"
            limpiar()
        Catch ex As Exception
            Dim excepcion As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub limpiar()
        Try
  

            CHKIgnorarDepInstancia.Checked = True
            CHKIgnorarFamiliaInstancia.Checked = True
            CHKIgnorarProdInstancia.Checked = True
            CHKIgnorarSucursalInstancia.Checked = True
            DGVInstanciasDeProducto.DataSource = Dispatcher(Of List(Of InstanciaDeProducto), ObtenerInstanciasDeProductoConFiltroAccion).execute(New ObtenerInstanciasDeProductoConFiltroAccion(New Producto, New Deposito, New Sucursal, New FamiliaDeProducto))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try

    End Sub

    Private Sub BTNLimpiarInstancias_Click(sender As Object, e As EventArgs) Handles BTNLimpiarInstancias.Click
        limpiar()
    End Sub

    Private Sub BTNFiltrarInstancias_Click(sender As Object, e As EventArgs) Handles BTNFiltrarInstancias.Click
        Try
            Dim producto As New Producto
            If CHKIgnorarProdInstancia.Checked = False Then
                producto = CMBProducto.SelectedValue
            End If
            Dim deposito As New Deposito
            If CHKIgnorarDepInstancia.Checked = False Then
                deposito = CMBDeposito.SelectedValue
            End If
            Dim sucursal As New Sucursal
            If CHKIgnorarSucursalInstancia.Checked = False Then
                sucursal = CMBSucursal.SelectedValue
            End If

            Dim familia As New FamiliaDeProducto
            If CHKIgnorarFamiliaInstancia.Checked = False Then
                familia = CMBFamiliaDeProducto.SelectedValue
            End If
            DGVInstanciasDeProducto.DataSource = Dispatcher(Of List(Of InstanciaDeProducto), ObtenerInstanciasDeProductoConFiltroAccion).execute(New ObtenerInstanciasDeProductoConFiltroAccion(producto, deposito, sucursal, familia))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try

    End Sub
End Class