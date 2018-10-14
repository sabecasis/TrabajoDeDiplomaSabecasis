Imports StockControlador
Imports StockControladorAccion
Imports ElementosTransversales

Public Class BackupRestore

    Private Sub BTNExaminar_Click(sender As Object, e As EventArgs) Handles BTNExaminar.Click
        OFDBackup.ShowDialog()
        TXTUbicacion.Text = OFDBackup.FileName
    End Sub


    Private Sub BTNCrearBackup_Click(sender As Object, e As EventArgs) Handles BTNCrearBackup.Click
        Try
            Dim resultado As String = Dispatcher(Of String, HacerBackupAccion).execute(New HacerBackupAccion(TXTUbicacion.Text))
            LBLMensajeBackup.Text = resultado
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OFDBackup.FileName = Date.Now.ToString("yyyy-MM-dd") & ".stock_db.bak"
        Catch ex As Exception
            Dim excepcion As New StockException(ex, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNRestaurar_Click(sender As Object, e As EventArgs) Handles BTNRestaurar.Click
        Try
            Dim resultado As String = Dispatcher(Of String, RestaurarBackupAccion).execute(New RestaurarBackupAccion(TXTUbicacion.Text))
            LBLMensajeBackup.Text = resultado
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

   
End Class