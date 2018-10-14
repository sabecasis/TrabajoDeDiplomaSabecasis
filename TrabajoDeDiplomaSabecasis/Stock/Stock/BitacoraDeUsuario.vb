Imports StockModelo
Imports StockControlador
Imports StockControladorAccion
Imports ElementosTransversales

Public Class BitacoraDeUsuario


    Private Sub BitacoraDeUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            crearParametrosInicialesDePantalla()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub


    Private Sub crearParametrosInicialesDePantalla()
        Dim listaDeBitacora As List(Of ElementoDeBitacora) = Dispatcher(Of List(Of ElementoDeBitacora), ObtenerBitacoraAccion).execute(New ObtenerBitacoraAccion())
        DGVBitacora.DataSource = listaDeBitacora

        Dim listaDeEventos As List(Of RelacionComandoAccionResultado) = Dispatcher(Of List(Of RelacionComandoAccionResultado), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        Dim primerEvento As RelacionComandoAccionResultado = New RelacionComandoAccionResultado()
        primerEvento.id = 0
        primerEvento.evento = "Seleccionar Evento"
        listaDeEventos.Add(primerEvento)
        CMBEventoBitacora.DataSource = listaDeEventos
        CMBEventoBitacora.ValueMember = "id"
        CMBEventoBitacora.DisplayMember = "evento"
        CMBEventoBitacora.SelectedValue = 0
        TXTUsuarioBitacora.Text = ""
        DTPFechaBitacora.Value = Date.Now
    End Sub

    Private Sub BTNFiltrarBitacora_Click(sender As Object, e As EventArgs) Handles BTNFiltrarBitacora.Click
        Try
            Dim listaDeBitacora As List(Of ElementoDeBitacora) = Dispatcher(Of List(Of ElementoDeBitacora), ObtenerBitacoraAccion).execute(New ObtenerBitacoraAccion(CMBEventoBitacora.SelectedValue, TXTUsuarioBitacora.Text, DTPFechaBitacora.Value))
            DGVBitacora.DataSource = listaDeBitacora
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNLimpiarBitacora_Click(sender As Object, e As EventArgs) Handles BTNLimpiarBitacora.Click
        Try
            crearParametrosInicialesDePantalla()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub
End Class