Imports StockControlador
Imports StockModelo
Imports ElementosTransversales
Imports StockControladorAccion

Public Class GestionarUsuario


    Private Sub GestionarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LSTEmpleadosDeUsuario.DisplayMember = "nroEmpleado"
            LSTEmpleadosDeUsuario.DataSource = Dispatcher(Of List(Of Empleado), ObtenerTodosAccion).execute(New ObtenerTodosAccion())

        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BTNGuardarUsuario_Click(sender As Object, e As EventArgs) Handles BTNGuardarUsuario.Click
        Try
            Dim idUsuario As Integer = 0
            If Not TXTIdUsuario.Text.Equals("") Then
                idUsuario = Convert.ToInt32(TXTIdUsuario.Text)
            End If
            Dim listaEmpleados As List(Of Empleado) = New List(Of Empleado)
            Dim empleado As Empleado
            For i As Integer = 0 To LSTEmpleadosDeUsuario.SelectedItems.Count - 1
                empleado = TryCast(LSTEmpleadosDeUsuario.SelectedItems(i), Empleado)
                listaEmpleados.Add(empleado)
            Next
            Dim mensaje As String = Dispatcher(Of String, GuardarUsuarioAccion).execute(New GuardarUsuarioAccion(Convert.ToBoolean(CHKBloqueado.CheckState), idUsuario, TXTPaswordCrearUsuario.Text, TXTRepetirPasswordCrearUsuario.Text, TXTUsuarioCrearUsuario.Text, TXTCrearPreguntaSecreta.Text, TXTCrearRespuestaSecreta.Text, listaEmpleados))
            LBLMensajeGestionUsuarios.Text = mensaje
            clear()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub


    Private Sub BTNBuscarUsuario_Click(sender As Object, e As EventArgs) Handles BTNBuscarUsuario.Click
        Try
            Dim oUsuario As Usuario = Dispatcher(Of Usuario, BuscarUsuarioAccion).execute(New BuscarUsuarioAccion(TXTUsuarioCrearUsuario.Text))
            If Not oUsuario Is Nothing Then
                TXTCrearPreguntaSecreta.Text = oUsuario.preguntaSecreta
                TXTIdUsuario.Text = oUsuario.id
                TXTUsuarioCrearUsuario.Text = oUsuario.nombre
                CHKBloqueado.CheckState = Convert.ToByte(oUsuario.bloqueado)
                TXTCrearRespuestaSecreta.Text = oUsuario.respuestaSecreta
                TXTContadorMalaPassUsuario.Text = oUsuario.contadorMalaPassword
                For i As Integer = 0 To LSTEmpleadosDeUsuario.Items.Count - 1
                    For Each oEmpleado As Empleado In oUsuario.empleados
                        If TryCast(LSTEmpleadosDeUsuario.Items(i), Empleado).id = oEmpleado.id Then
                            LSTEmpleadosDeUsuario.SetSelected(i, True)
                        End If
                    Next
                Next
            Else
                Throw New StockException(New Exception(Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.USUARIO_INEXISTENTE)), Me.GetType.ToString)

            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub LSTEmpleadosDeUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSTEmpleadosDeUsuario.SelectedIndexChanged
        Try
            Dim nroEmpleado As String = Nothing
            If Not LSTEmpleadosDeUsuario.SelectedValue Is Nothing Then
                nroEmpleado = DirectCast(LSTEmpleadosDeUsuario.SelectedValue, Empleado).nroEmpleado
            End If
            Dim empleado As Empleado = Dispatcher(Of Empleado, ObtenerEmpleadoPorNroAccion).execute(New ObtenerEmpleadoPorNroAccion(nroEmpleado))
            If Not empleado Is Nothing Then
                If Not empleado.persona Is Nothing Then
                    TXTApellidoEmpleado.Text = empleado.persona.apellido
                    TXTNombreEmpleado.Text = empleado.persona.nombre
                    TXTNroDocumentoEmpleado.Text = empleado.persona.documento
                End If
            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BTNLimpiarPantallaUsuario_Click(sender As Object, e As EventArgs) Handles BTNLimpiarPantallaUsuario.Click
        clear()
    End Sub

    Private Sub clear()
        TXTApellidoEmpleado.Text = ""
        TXTContadorMalaPassUsuario.Text = ""
        TXTCrearPreguntaSecreta.Text = ""
        TXTCrearRespuestaSecreta.Text = ""
        TXTIdUsuario.Text = ""
        TXTNombreEmpleado.Text = ""
        TXTNroDocumentoEmpleado.Text = ""
        TXTPaswordCrearUsuario.Text = ""
        TXTRepetirPasswordCrearUsuario.Text = ""
        TXTUsuarioCrearUsuario.Text = ""
        LSTEmpleadosDeUsuario.SelectedIndex = 0
    End Sub

    Private Sub BTNEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BTNEliminarUsuario.Click
        Try
            Dim idUsuario As Integer = CType(TXTIdUsuario.Text, Integer)
            Dim mnsaje As String = Dispatcher(Of String, EliminarUsuarioAccion).execute(New EliminarUsuarioAccion(idUsuario))
            LBLMensajeGestionUsuarios.Text = mnsaje
            clear()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub
End Class