Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales

Public Class LogDeErrores

    Private Sub LogDeErrores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub limpiar()
        Try
            CMBTipoExcepcion.DataSource = Dispatcher(Of List(Of TipoDeExcepcion), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBTipoExcepcion.DisplayMember = "tipo"
            CHKIgnorarFechaLogErrores.Checked = True
            CHKIgnorarTipoDeExcepcion.Checked = True
            DGVErrores.DataSource = Dispatcher(Of List(Of ErrorLog), ObtenerTodosLosErroresConFiltroAccion).execute(New ObtenerTodosLosErroresConFiltroAccion())
            TXTClase.Text = ""
            TXTQuery.Text = ""
            TXTIdError.Text = 0
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub BTNLimpiarLogDeErrores_Click(sender As Object, e As EventArgs) Handles BTNLimpiarLogDeErrores.Click
        limpiar()
    End Sub

    Private Sub BTNFiltrarLogDeErrores_Click(sender As Object, e As EventArgs) Handles BTNFiltrarLogDeErrores.Click
        Try
            Dim fecha As DateTime
            If CHKIgnorarFechaLogErrores.Checked = True Then
                fecha = Nothing
            Else
                fecha = DTPFecha.Value
            End If

            Dim tipoExcepcion As TipoDeExcepcion
            If CHKIgnorarTipoDeExcepcion.Checked = True Then
                tipoExcepcion = New TipoDeExcepcion
            Else
                tipoExcepcion = CMBTipoExcepcion.SelectedValue
            End If

            Dim idError As Integer = 0
            Try
                idError = CType(TXTIdError.Text, Integer)
            Catch ex As Exception
                idError = 0
            End Try

            DGVErrores.DataSource = Dispatcher(Of List(Of ErrorLog), ObtenerTodosLosErroresConFiltroAccion).execute(New ObtenerTodosLosErroresConFiltroAccion(idError, TXTClase.Text, TXTQuery.Text, fecha, tipoExcepcion))
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try

    End Sub
End Class