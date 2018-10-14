Imports ElementosTransversales
Imports StockControlador
Imports StockControladorAccion
Imports StockModelo

Public Class GestionarMoneda

    Private Sub GestionarMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTIdMoneda.Text = 0
    End Sub

    Private Sub limpiar()
        TXTIdMoneda.Text = 0
        TXTMoneda.Text = ""
    End Sub

    Private Sub BTNLimpiarMoneda_Click(sender As Object, e As EventArgs) Handles BTNLimpiarMoneda.Click
        limpiar()
    End Sub

    Private Sub BTNGuardarMoneda_Click(sender As Object, e As EventArgs) Handles BTNGuardarMoneda.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, GuardarMonedaAccion).execute(New GuardarMonedaAccion(CType(TXTIdMoneda.Text, Integer), TXTMoneda.Text))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub BTNEliminarMoneda_Click(sender As Object, e As EventArgs) Handles BTNEliminarMoneda.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarMonedaAccion).execute(New EliminarMonedaAccion(CType(TXTIdMoneda.Text, Integer)))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub BTNBuscarMoneda_Click(sender As Object, e As EventArgs) Handles BTNBuscarMoneda.Click
        Try
            Dim oMoneda As Moneda = Dispatcher(Of Moneda, BuscarMonedaAccion).execute(New BuscarMonedaAccion(CType(TXTIdMoneda.Text, Integer), TXTMoneda.Text))
            If oMoneda Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_MONEDA)), Me.GetType.ToString)
            End If
            TXTIdMoneda.Text = oMoneda.id
            TXTMoneda.Text = oMoneda.moneda
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub
End Class