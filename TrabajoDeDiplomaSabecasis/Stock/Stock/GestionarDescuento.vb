Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class GestionarDescuento

    Private Sub GestionarDescuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CMBMonedaDescuento.DataSource = Dispatcher(Of List(Of Moneda), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBMonedaDescuento.DisplayMember = "moneda"
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Public Sub limpiar()
        TXTDescripcionDescuento.Text = ""
        TXTIdDescuento.Text = 0
        TXTMontoDescuento.Text = 0
        TXTPorcentajeDescuento.Text = 0
        TXTNombreDescuento.Text = ""
    End Sub

    Private Sub BTNLimpiarDescuento_Click(sender As Object, e As EventArgs) Handles BTNLimpiarDescuento.Click
        limpiar()
    End Sub

    Private Sub BTNGuardarDescuento_Click(sender As Object, e As EventArgs) Handles BTNGuardarDescuento.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, GuardarDescuentoAccion).execute(New GuardarDescuentoAccion(CType(TXTIdDescuento.Text, Integer), TXTNombreDescuento.Text, TXTDescripcionDescuento.Text, CType(Val(TXTMontoDescuento.Text), Double), CType(Val(LBLPorcentajeDescuento.Text), Double)))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub BTNEliminarDescuento_Click(sender As Object, e As EventArgs) Handles BTNEliminarDescuento.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarDescuentoAccion).execute(New EliminarDescuentoAccion(CType(TXTIdDescuento.Text, Integer)))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub BTNBuscarDescuento_Click(sender As Object, e As EventArgs) Handles BTNBuscarDescuento.Click
        Try
            Dim oDescuento As Descuento = Dispatcher(Of Descuento, BuscarDescuentoAccion).execute(New BuscarDescuentoAccion(CType(TXTIdDescuento.Text, Integer), TXTNombreDescuento.Text))
            If oDescuento Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.DESCUENTO_NO_ENCONTRADO)), Me.GetType.ToString)
            End If
            TXTDescripcionDescuento.Text = oDescuento.descripcion
            TXTIdDescuento.Text = oDescuento.id
            TXTNombreDescuento.Text = oDescuento.nombre
            TXTPorcentajeDescuento.Text = oDescuento.porcentaje
            TXTMontoDescuento.Text = oDescuento.monto
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        End Try
    End Sub
End Class