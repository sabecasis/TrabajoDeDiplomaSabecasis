Imports System.Globalization
Imports StockControlador
Imports StockModelo
Imports ElementosTransversales
Imports StockControladorAccion

Public Class GestionarIdioma

    Private Sub GestionarIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CMBCultura.DataSource = CultureInfo.GetCultures(CultureTypes.AllCultures)
            CMBCultura.DisplayMember = "DisplayName"
            CMBCultura.ValueMember = "Name"

            DGVIdiomaElemento.DataSource = Dispatcher(Of List(Of ElementoDeIdioma), ObtenerTodosAccion).execute(New ObtenerTodosAccion())

        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub


    Private Sub BTNGuardarIdioma_Click(sender As Object, e As EventArgs) Handles BTNGuardarIdioma.Click
        Try
            Dim listaElementoIdioma As List(Of RelacionElementoIdioma) = New List(Of RelacionElementoIdioma)
            For cont As Integer = 0 To DGVIdiomaElemento.RowCount - 1
                listaElementoIdioma.Add(New RelacionElementoIdioma(
                    New ElementoDeIdioma(
                        DGVIdiomaElemento.Rows(cont).Cells(1).Value,
                        DGVIdiomaElemento.Rows(cont).Cells(2).Value.ToString
                        ),
                    New Idioma(
                        CultureInfo.CreateSpecificCulture(CMBCultura.SelectedValue.ToString),
                        TXTDescripcionIdioma.Text
                        ),
                    DGVIdiomaElemento.Rows(cont).Cells(0).Value
                    )
                )
            Next
            Dim esExitoso As String = Dispatcher(Of String, CrearIdiomaAccion).execute(New CrearIdiomaAccion(listaElementoIdioma))
            LBLErrorCrearIdioma.Text = esExitoso
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub limpiarGrilla()
        For Each row As DataGridViewRow In DGVIdiomaElemento.Rows
            row.Cells(0).Value = ""
        Next
    End Sub

    Private Sub CMBCultura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCultura.SelectedIndexChanged
        Try
            Dim listaElementos As List(Of RelacionElementoIdioma) = Dispatcher(Of List(Of RelacionElementoIdioma), BuscarIdiomaAccion).execute(New BuscarIdiomaAccion(System.Globalization.CultureInfo.GetCultureInfo(CMBCultura.SelectedValue.ToString).DisplayName))
            If Not listaElementos Is Nothing Then
                For Each row As DataGridViewRow In DGVIdiomaElemento.Rows
                    For Each rel As RelacionElementoIdioma In listaElementos
                        If rel.elemento.nombre.Equals(row.Cells(2).Value) Then
                            row.Cells(0).Value = rel.texto
                        End If
                    Next
                Next
                TXTDescripcionIdioma.Text = listaElementos.Item(0).idioma.descripcion
            Else
                limpiarGrilla()
                TXTDescripcionIdioma.Text = ""
            End If
        Catch exe As Exception
            ' no hacer nada
        End Try

    End Sub


    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarIdiomaAccion).execute(New EliminarIdiomaAccion(System.Globalization.CultureInfo.GetCultureInfo(CMBCultura.SelectedValue.ToString).DisplayName))
            LBLErrorCrearIdioma.Text = mensaje
            limpiarGrilla()
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim excepcion As New StockException(exe, Me.GetType.ToString)
            MessageBox.Show(exe.Message)
        End Try

    End Sub
End Class