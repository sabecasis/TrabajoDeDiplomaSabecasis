Imports ElementosTransversales
Imports StockControlador
Imports StockModelo
Imports StockControladorAccion
Imports StockControladorComando

Public Class Login
    Implements PantallaMultiIdioma

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click, BTNLogin.KeyPress
        Try
            Autorizador.obtenerInstancia().checkearVerificadoresVerticales()
            Dim respuesta As RespuestaSeguridad = Autenticador.obtenerInstancia().autenticar(TXTUsuario.Text, TXTPassword.Text)
            If respuesta.estaAutenticado Then
                Dim pi As PantallaInicio = New PantallaInicio()
                Me.Hide()
                pi.ShowDialog()

            Else
                LBLRazon.Text = respuesta.razon
            End If
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
            Dim respuesta As RespuestaSeguridad = Autenticador.obtenerInstancia().autenticarSuperAdmin(TXTUsuario.Text, TXTPassword.Text)
            If respuesta.estaAutenticado Then
                Dim pi As PantallaInicio = New PantallaInicio()
                Me.Hide()
                pi.ShowDialog()
                pi.establecerIdioma(CMBIdioma.SelectedIndex)
            End If
        End Try


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BTNCambiarConexion.Visible = False
            Cache.init()
            establecerParametrosDeIdiomaDePantalla()
            Dim listaDeIdiomas As List(Of Idioma) = Dispatcher(Of List(Of Idioma), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
            CMBIdioma.DataSource = listaDeIdiomas
            CMBIdioma.DisplayMember = "cultura"
            CMBIdioma.ValueMember = "id"
            CMBIdioma.SelectedValue = 0
            TXTPassword.Text = ""
            TXTUsuario.Text = ""
            Dispatcher(Of Object, GestionarIdiomaYCulturaActualAccion).execute(New GestionarIdiomaYCulturaActualAccion(CMBIdioma.SelectedValue))
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
            BTNCambiarConexion.Visible = True
        End Try
    End Sub

    Private Sub CMBIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBIdioma.SelectedIndexChanged
        Try
            If Not TypeOf CMBIdioma.SelectedValue Is Idioma Then
                Dispatcher(Of Object, GestionarIdiomaYCulturaActualAccion).execute(New GestionarIdiomaYCulturaActualAccion(Convert.ToInt32(CMBIdioma.SelectedValue)))
                establecerParametrosDeIdiomaDePantalla()
            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub


    Public Sub establecerParametrosDeIdiomaDePantalla() Implements PantallaMultiIdioma.establecerParametrosDeIdiomaDePantalla
        Try
            Dim oSesion As Sesion = Sesion.obtenerInstancia()
            LBLUsuario.Text = oSesion.correlacionElementoIdioma.Item(ConstantesDeIdioma.LBLUsuario)
            LBLPassword.Text = oSesion.correlacionElementoIdioma.Item(ConstantesDeIdioma.LBLPassword)
            LBLIdioma.Text = oSesion.correlacionElementoIdioma.Item(ConstantesDeIdioma.LBLIdioma)
            BTNLogin.Text = oSesion.correlacionElementoIdioma.Item(ConstantesDeIdioma.BTNLogin)
            BTNOlvidarPassword.Text = oSesion.correlacionElementoIdioma.Item(ConstantesDeIdioma.BTNOlvidarPassword)
            Me.Text = oSesion.correlacionElementoIdioma.Item(ConstantesDeIdioma.TITULOIniciarSesion)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTNOlvidarPassword_Click(sender As Object, e As EventArgs) Handles BTNOlvidarPassword.Click
        Dim olvidePassword As New CambiarPassword
        olvidePassword.ShowDialog()
    End Sub

    Private Sub BTNCambiarConexion_Click(sender As Object, e As EventArgs) Handles BTNCambiarConexion.Click
        Dim con As New CreacionDB
        con.ShowDialog()
    End Sub
End Class