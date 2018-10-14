Imports System.Configuration
Imports StockControlador
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockControladorComando

Public Class CreacionDB

    Private tipo As String = "Trusted_Connection=Yes;"
    Private tipo2 As String = "User ID={usuario};Password={password};"
    Private stringmaster As String = "Server={servidor};Database=master;"
    Private stringstock As String = "Server={servidor};Database=stock_db;"
    Private tipoActual As String = tipo
    Private Sub CreacionDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CHKAutenticacion.Checked = True
        TXTUsuario.Enabled = False
        TXTPass.Enabled = False

    End Sub

    Private Sub BTNCambiarConn_Click(sender As Object, e As EventArgs) Handles BTNCambiarConn.Click
        Try
            Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config.ConnectionStrings.ConnectionStrings("stockdb").ConnectionString = stringstock.Replace("{servidor}", TXTStringDeConexion.Text.Trim) & tipoActual
            config.ConnectionStrings.ConnectionStrings("master").ConnectionString = stringmaster.Replace("{servidor}", TXTStringDeConexion.Text.Trim) & tipoActual
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("ConnectionStrings")
            Dim resultado As String = Dispatcher(Of String, RestaurarBackupAccion).execute(New RestaurarBackupAccion(IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "stock_db.bak")))
            MessageBox.Show(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.BASE_DE_DATOS_CREADA))
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CHKAutenticacion_CheckedChanged(sender As Object, e As EventArgs) Handles CHKAutenticacion.CheckedChanged
        If CHKAutenticacion.Checked = True Then
            tipoActual = tipo
            TXTUsuario.Enabled = False
            TXTPass.Enabled = False
        Else
            tipoActual = tipo2
            TXTUsuario.Enabled = True
            TXTPass.Enabled = True
        End If
    End Sub
End Class