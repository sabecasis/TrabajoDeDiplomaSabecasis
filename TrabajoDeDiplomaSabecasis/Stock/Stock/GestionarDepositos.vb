Imports ElementosTransversales
Imports StockControlador
Imports StockControladorAccion
Imports StockModelo

Public Class GestionarDepositos

    Private Sub BTNGuardarDeposito_Click(sender As Object, e As EventArgs) Handles BTNGuardarDeposito.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, GuardarDepositoAccion).execute(New GuardarDepositoAccion(CType(TXTIdDeposito.Text, Integer), TXTNombreDeposito.Text, TXTCalleDeposito.Text, TXTNroPuertaDeposito.Text, CType(TXTPisoDeposito.Text, Integer), TXTDepartamentoDeposito.Text, TXTEmailDeposito.Text, TXTTelefonoDeposito.Text, CMBLocalidadDeposito.SelectedValue))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub

    Private Sub limpiar()
        TXTCalleDeposito.Text = ""
        TXTDepartamentoDeposito.Text = ""
        TXTEmailDeposito.Text = ""
        TXTIdDeposito.Text = 0
        TXTNombreDeposito.Text = ""
        TXTNroPuertaDeposito.Text = ""
        TXTPisoDeposito.Text = 0
        TXTTelefonoDeposito.Text = ""
        CMBPaisDeposito.SelectedIndex = 0
        CMBProvinciaDeposito.DataSource = New List(Of Provincia)
        CMBLocalidadDeposito.DataSource = New List(Of Localidad)
    End Sub

    Private Sub GestionarDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TXTPisoDeposito.Text = 0
            TXTIdDeposito.Text = 0

            CMBPaisDeposito.DataSource = Dispatcher(Of List(Of Pais), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBPaisDeposito.DisplayMember = "pais"
        Catch ex As Exception
            Dim excepcion As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTNBuscarDeposito_Click(sender As Object, e As EventArgs) Handles BTNBuscarDeposito.Click
        Try
            Dim oDeposito As Deposito = Dispatcher(Of Deposito, BuscarDepositoAccion).execute(New BuscarDepositoAccion(CType(TXTIdDeposito.Text, Integer), TXTNombreDeposito.Text))
            If oDeposito Is Nothing Then
                Throw New StockException(New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.NO_SE_ENCONTRO_EL_DEPOSITO)), Me.GetType.ToString)
            End If
            TXTIdDeposito.Text = oDeposito.id
            TXTCalleDeposito.Text = oDeposito.contacto.calle
            TXTDepartamentoDeposito.Text = oDeposito.contacto.departamento
            TXTEmailDeposito.Text = oDeposito.contacto.email
            TXTNombreDeposito.Text = oDeposito.nomber
            TXTNroPuertaDeposito.Text = oDeposito.contacto.nroPuerta
            TXTPisoDeposito.Text = oDeposito.contacto.piso
            TXTTelefonoDeposito.Text = oDeposito.contacto.telefonos.Item(0).telefono

            Dim cantPaises As Integer = CMBPaisDeposito.Items.Count
            Dim paisProvisorio As Pais
            For p As Integer = 0 To cantPaises
                paisProvisorio = CMBPaisDeposito.Items.Item(p)
                If paisProvisorio.id = oDeposito.contacto.localidad.provincia.pais.id Then
                    CMBPaisDeposito.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim cantProv As Integer = CMBProvinciaDeposito.Items.Count
            Dim provProvisoria As Provincia
            For p As Integer = 0 To cantProv
                provProvisoria = CMBProvinciaDeposito.Items.Item(p)
                If provProvisoria.id = oDeposito.contacto.localidad.provincia.id Then
                    CMBProvinciaDeposito.SelectedIndex = p
                    Exit For
                End If
            Next

            Dim cantLoc As Integer = CMBLocalidadDeposito.Items.Count
            Dim locProvisoria As Localidad
            For p As Integer = 0 To cantLoc
                locProvisoria = CMBLocalidadDeposito.Items.Item(p)
                If locProvisoria.id = oDeposito.contacto.localidad.id Then
                    CMBLocalidadDeposito.SelectedIndex = p
                    Exit For
                End If
            Next

        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        Catch exe As Exception
            Dim log As New StockException(exe, Me.GetType.ToString)
        End Try
    End Sub

    Private Sub CMBPaisDeposito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPaisDeposito.SelectedIndexChanged
        CMBProvinciaDeposito.DataSource = TryCast(CMBPaisDeposito.SelectedValue, Pais).provincias
        CMBProvinciaDeposito.DisplayMember = "provincia"
    End Sub

    Private Sub CMBProvinciaDeposito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBProvinciaDeposito.SelectedIndexChanged
        CMBLocalidadDeposito.DataSource = TryCast(CMBProvinciaDeposito.SelectedValue, Provincia).localidades
        CMBLocalidadDeposito.DisplayMember = "localidad"
    End Sub

    Private Sub BTNLimpiarDeposito_Click(sender As Object, e As EventArgs) Handles BTNLimpiarDeposito.Click
        limpiar()
    End Sub

    Private Sub BTNEliminarDeposito_Click(sender As Object, e As EventArgs) Handles BTNEliminarDeposito.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarDepositoAccion).execute(New EliminarDepositoAccion(CType(TXTIdDeposito.Text, Integer)))
            LBLMensaje.Text = mensaje
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
        limpiar()
    End Sub
End Class