Imports ElementosTransversales
Imports StockControlador
Imports StockControladorAccion
Imports StockModelo

Public Class GestionarMarca

    Private Sub BTNGuardarMarca_Click(sender As Object, e As EventArgs) Handles BTNGuardarMarca.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, GuardarMarcaAccion).execute(New GuardarMarcaAccion(TXTIdMarca.Text, TXTMarca.Text))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.Message)
        End Try
        limpiar()
    End Sub

    Private Sub limpiar()
        TXTIdMarca.Text = 0
        TXTMarca.Text = ""
    End Sub

    Private Sub BTNEliminarMarca_Click(sender As Object, e As EventArgs) Handles BTNEliminarMarca.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarMarcaAccion).execute(New EliminarMarcaAccion(CType(TXTIdMarca.Text, Integer)))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.Message)
        End Try
        limpiar()
    End Sub

    Private Sub GestionarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTIdMarca.Text = 0
    End Sub

    Private Sub BTNBuscarMarca_Click(sender As Object, e As EventArgs) Handles BTNBuscarMarca.Click
        Try
            Dim oMarca As Marca = Dispatcher(Of Marca, BuscarMarcaAccion).execute(New BuscarMarcaAccion(CType(TXTIdMarca.Text, Integer), TXTMarca.Text))
            If oMarca Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_MARCA))
            End If
            TXTIdMarca.Text = oMarca.id
            TXTMarca.Text = oMarca.marca
        Catch ex As Exception
            Dim exep As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTNLimpiarMarca_Click(sender As Object, e As EventArgs) Handles BTNLimpiarMarca.Click
        limpiar()
    End Sub
End Class