Imports StockControlador
Imports StockModelo
Imports ElementosTransversales
Imports StockControladorAccion
Imports StockControladorComando

Public Class GestionarGrupo

    Private listaGrupos As List(Of ElementoDeSeguridad) = New List(Of ElementoDeSeguridad)
    Private listaGruposAsignados As List(Of ElementoDeSeguridad) = New List(Of ElementoDeSeguridad)

    Private Sub GestionarGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            listaGrupos = Dispatcher(Of List(Of ElementoDeSeguridad), ObtenerTodosAccion).execute(New ObtenerTodosAccion)
            LSTGruposNoAsignados.Items.Clear()
            For Each oGrupo As Grupo In listaGrupos
                LSTGruposNoAsignados.Items.Add(oGrupo)
            Next

            LSTGruposNoAsignados.DisplayMember = "nombre"
            LSTGruposAsignados.DisplayMember = "nombre"
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BTNGuardarGrupo_Click(sender As Object, e As EventArgs) Handles BTNGuardarGrupo.Click
        Try
            Dim listaGruposUsuarios As List(Of ElementoDeSeguridad) = New List(Of ElementoDeSeguridad)
            For i As Integer = 0 To LSTGruposAsignados.Items.Count - 1
                listaGruposUsuarios.Add(TryCast(LSTGruposAsignados.Items(i), ElementoDeSeguridad))
            Next
            Dim idGrupo As Integer
            If TXTIdGrupo.Text.Equals("") Then
                idGrupo = 0
            Else
                idGrupo = Convert.ToInt32(TXTIdGrupo.Text)
            End If
            Dim mensaje As String = Dispatcher(Of String, GuardarGrupoAccion).execute(New GuardarGrupoAccion(idGrupo, TXTNombreGrupo.Text, listaGruposUsuarios))
            LBLMensajeOperacionGrupo.Text = mensaje
            limpiarPantalla()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNAsignarGrupo_Click(sender As Object, e As EventArgs) Handles BTNAsignarGrupo.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ASIGNAR)

            For Each item As Grupo In LSTGruposNoAsignados.SelectedItems
                LSTGruposAsignados.Items.Add(item)

            Next
            LSTGruposAsignados.Refresh()
            LSTGruposAsignados.Update()

            For Each item As Grupo In LSTGruposAsignados.Items
                If LSTGruposNoAsignados.Items.Contains(item) Then
                    LSTGruposNoAsignados.Items.Remove(item)

                End If
            Next
            LSTGruposNoAsignados.Refresh()
            LSTGruposNoAsignados.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNDesasignarGrupo_Click(sender As Object, e As EventArgs) Handles BTNDesasignarGrupo.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.DESASIGNAR)
            For Each item As Grupo In LSTGruposAsignados.SelectedItems
                LSTGruposNoAsignados.Items.Add(item)

            Next
            LSTGruposAsignados.Refresh()
            LSTGruposAsignados.Update()

            For Each item As Grupo In LSTGruposNoAsignados.Items
                If LSTGruposAsignados.Items.Contains(item) Then
                    LSTGruposAsignados.Items.Remove(item)

                End If
            Next

            LSTGruposAsignados.Refresh()
            LSTGruposAsignados.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub


    Private Sub limpiarPantalla()
        LSTGruposAsignados.Items.Clear()
        LSTGruposNoAsignados.Items.Clear()
        listaGrupos = Dispatcher(Of List(Of ElementoDeSeguridad), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        For Each oGrupo As Grupo In listaGrupos
            LSTGruposNoAsignados.Items.Add(oGrupo)
        Next
        TXTNombreGrupo.Text = ""
        TXTIdGrupo.Text = ""

    End Sub


    Private Sub BTNBuscarGrupo_Click(sender As Object, e As EventArgs) Handles BTNBuscarGrupo.Click
        Try
            Dim oGrupo As Grupo = Dispatcher(Of Grupo, BuscarGrupoAccion).execute(New BuscarGrupoAccion(TXTNombreGrupo.Text))
            Dim listaElementosABorrar As List(Of Grupo) = New List(Of Grupo)
            If Not oGrupo Is Nothing Then
                If Not oGrupo.elementos Is Nothing Then
                    For Each oElemento As ElementoDeSeguridad In oGrupo.elementos
                        LSTGruposAsignados.Items.Add(oElemento)
                        For Each item As Grupo In LSTGruposNoAsignados.Items
                            If oElemento.id = item.id Then
                                listaElementosABorrar.Add(item)
                                Exit For
                            End If
                        Next
                    Next
                End If

                For Each item As Grupo In listaElementosABorrar
                    LSTGruposNoAsignados.Items.Remove(item)
                Next

                LSTGruposAsignados.Refresh()
                LSTGruposAsignados.Update()
                LSTGruposNoAsignados.Refresh()
                LSTGruposNoAsignados.Update()

                TXTIdGrupo.Text = oGrupo.id
                TXTNombreGrupo.Text = oGrupo.nombre
            End If
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try

    End Sub

    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarGrupoAccion).execute(New EliminarGrupoAccion(CType(TXTIdGrupo.Text, Integer)))
            LBLMensajeOperacionGrupo.Text = mensaje
            limpiarPantalla()
        Catch exe As StockException
            MessageBox.Show(exe.mensaje)
        Catch ex As Exception
            Dim log As New StockException(ex, Me.GetType.ToString)
            MessageBox.Show(log.mensaje)
        End Try

    End Sub

    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiar.Click
        limpiarPantalla()
    End Sub
End Class