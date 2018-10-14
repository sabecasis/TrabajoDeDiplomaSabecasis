Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class CambiarPassword

    Private Sub CambiarPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPregunta.Enabled = False
        TXTRespuesta.Enabled = False
        TXTNueva.Enabled = False
        TXTRepetir.Enabled = False
    End Sub

    Private Sub BTNBuscarPregunta_Click(sender As Object, e As EventArgs) Handles BTNBuscarPregunta.Click
        Try
            Dim oUsuario As Usuario = Dispatcher(Of Usuario, BuscarUsuarioAccion).execute(New BuscarUsuarioAccion(TXTUsuario.Text))
            If Not oUsuario Is Nothing Then
                TXTUsuario.Text = oUsuario.nombre
                TXTPregunta.Text = oUsuario.preguntaSecreta
                TXTRespuesta.Enabled = True

                TXTNueva.Enabled = True
                TXTRepetir.Enabled = True
            Else
                LBLMensaje.Text = Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_INEXISTENTE)
            End If
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try

    End Sub

    Private Sub BTNCambiar_Click(sender As Object, e As EventArgs) Handles BTNCambiar.Click
        Try
            Dim oUsuario As Usuario = Dispatcher(Of Usuario, BuscarUsuarioAccion).execute(New BuscarUsuarioAccion(TXTUsuario.Text))
            If TXTNueva.Text.Trim.Equals(TXTRepetir.Text.Trim) Then
                If oUsuario.respuestaSecreta.Equals(TXTRespuesta.Text) Then
                    oUsuario.password = Criptografia.ObtenerInstancia().GetHashMD5(TXTNueva.Text)
                    Dispatcher(Of String, CambiarPasswordAccion).execute(New CambiarPasswordAccion(oUsuario))
                End If
            End If
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try
    End Sub
End Class