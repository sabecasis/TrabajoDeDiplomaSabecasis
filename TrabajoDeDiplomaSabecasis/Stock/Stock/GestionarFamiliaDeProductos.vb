Imports ElementosTransversales
Imports StockControlador
Imports StockControladorAccion
Imports StockModelo

Public Class GestionarFamiliaDeProductos

    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiarFamilia.Click
        TXTFamilia.Text = ""
        TXTIdFamilia.Text = 0
    End Sub

    Private Sub BTNGuardarFamilia_Click(sender As Object, e As EventArgs) Handles BTNGuardarFamilia.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, GuardarFamiliaProductoAccion).execute(New GuardarFamiliaProductoAccion(CType(TXTIdFamilia.Text, Integer), TXTFamilia.Text))
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try
    End Sub

    Private Sub BTNBuscarFamilia_Click(sender As Object, e As EventArgs) Handles BTNBuscarFamilia.Click
        Try
            Dim oFamilia As FamiliaDeProducto = Dispatcher(Of FamiliaDeProducto, BuscarFamiliaProductoAccion).execute(New BuscarFamiliaProductoAccion(CType(TXTIdFamilia.Text, Integer), TXTFamilia.Text))
            If oFamilia Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_LA_FAMILIA))
            End If
            TXTFamilia.Text = oFamilia.familia
            TXTIdFamilia.Text = oFamilia.id
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try
    End Sub

    Private Sub BTNEliminarFamilia_Click(sender As Object, e As EventArgs) Handles BTNEliminarFamilia.Click
        Try
            LBLMensaje.Text = Dispatcher(Of String, EliminarFamiliaProductoAccion).execute(New EliminarFamiliaProductoAccion(CType(TXTIdFamilia.Text, Integer)))

        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
        End Try
    End Sub


End Class