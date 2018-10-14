Imports StockControlador
Imports StockModelo
Imports ElementosTransversales
Imports StockControladorAccion
Imports StockControladorComando

Public Class FormGestionRoles

    Private Sub FormGestionRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim obtenerTodos As New ObtenerTodosAccion
            LSTPermisosNoAsignadosARol.Items.Clear()
            CMBModuloRol.DataSource = Dispatcher(Of List(Of Modulo), ObtenerTodosAccion).execute(obtenerTodos)
            CMBModuloRol.DisplayMember = "nombre"
            Dim grupos As List(Of ElementoDeSeguridad) = Dispatcher(Of List(Of ElementoDeSeguridad), ObtenerTodosAccion).execute(obtenerTodos)
            LSTGruposRolNoAsignados.Items.Clear()
            For Each oElemento As ElementoDeSeguridad In grupos
                LSTGruposRolNoAsignados.Items.Add(oElemento)
            Next

            LSTGruposRolAsignados.DisplayMember = "nombre"
            LSTGruposRolNoAsignados.DisplayMember = "nombre"
            LSTGruposRolAsignados.ValueMember = "id"
            LSTGruposRolNoAsignados.ValueMember = "id"

            Dim permisos As List(Of Permiso) = Dispatcher(Of List(Of Permiso), ObtenerTodosAccion).execute(obtenerTodos)
            For Each oPermiso As Permiso In permisos
                LSTPermisosNoAsignadosARol.Items.Add(oPermiso)
            Next
            LSTPermisosNoAsignadosARol.DisplayMember = "nombre"
            LSTPermisosAsignadosARol.DisplayMember = "nombre"
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BTNAsignarGrupoARol_Click(sender As Object, e As EventArgs) Handles BTNAsignarGrupoARol.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ASIGNAR)
            For Each item As Grupo In LSTGruposRolNoAsignados.SelectedItems
                LSTGruposRolAsignados.Items.Add(item)

            Next
            LSTGruposRolAsignados.Refresh()
            LSTGruposRolAsignados.Update()

            For Each item As Grupo In LSTGruposRolAsignados.Items
                If LSTGruposRolNoAsignados.Items.Contains(item) Then
                    LSTGruposRolNoAsignados.Items.Remove(item)

                End If


            Next
            LSTGruposRolNoAsignados.Refresh()
            LSTGruposRolNoAsignados.Update()

        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNDesasignarGrupoARol_Click(sender As Object, e As EventArgs) Handles BTNDesasignarGrupoARol.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.DESASIGNAR)
            For Each item As Grupo In LSTGruposRolAsignados.SelectedItems
                LSTGruposRolNoAsignados.Items.Add(item)

            Next
            LSTGruposRolNoAsignados.Refresh()
            LSTGruposRolNoAsignados.Update()

            For Each item As Grupo In LSTGruposRolNoAsignados.Items
                If LSTGruposRolAsignados.Items.Contains(item) Then
                    LSTGruposRolAsignados.Items.Remove(item)

                End If


            Next
            LSTGruposRolAsignados.Refresh()
            LSTGruposRolAsignados.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try

    End Sub

    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        Try
            Dim idRol As Integer = 0
            If Not TXTIdRol.Text Is Nothing And Not TXTIdRol.Text.Equals("") Then
                idRol = Convert.ToInt32(TXTIdRol.Text)
            End If

            Dim listaGrupos As List(Of ElementoDeSeguridad) = New List(Of ElementoDeSeguridad)
            For Each oElemento As Grupo In LSTGruposRolAsignados.Items
                listaGrupos.Add(oElemento)
            Next

            Dim listaPermisos As List(Of Permiso) = New List(Of Permiso)
            For Each oPermiso As Permiso In LSTPermisosAsignadosARol.Items
                listaPermisos.Add(oPermiso)
            Next

            Dim mensaje As String = Dispatcher(Of String, GuardarRolAccion).execute(New GuardarRolAccion(idRol, TXTNombreRol.Text, TXTDescripcionRol.Text, CMBModuloRol.SelectedValue, listaGrupos, listaPermisos))
            LBLMensajeRol.Text = mensaje
            limpiarPantalla()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Try
            Dim oRol As Rol = Dispatcher(Of Rol, BuscarRolAccion).execute(New BuscarRolAccion(TXTNombreRol.Text))
            Dim elementosAEliminarDeLista As List(Of Grupo) = New List(Of Grupo)
            Dim permisosAEliminarDeLaLista As List(Of Permiso) = New List(Of Permiso)
            If Not oRol Is Nothing Then
                TXTDescripcionRol.Text = oRol.descripcion
                TXTIdRol.Text = oRol.id
                TXTNombreRol.Text = oRol.rol
                For Each item As Modulo In CMBModuloRol.Items
                    If item.id = oRol.modulo.id Then
                        CMBModuloRol.SelectedItem = item
                    End If

                Next


                If Not oRol.grupos Is Nothing Then
                    For Each oGrupo As Grupo In oRol.grupos
                        LSTGruposRolAsignados.Items.Add(oGrupo)
                        For Each oElemento As Grupo In LSTGruposRolNoAsignados.Items
                            If oElemento.id = oGrupo.id Then
                                elementosAEliminarDeLista.Add(oElemento)
                                Exit For
                            End If
                        Next
                    Next

                    For Each oGrupo As Grupo In elementosAEliminarDeLista
                        LSTGruposRolNoAsignados.Items.Remove(oGrupo)
                    Next
                End If

                If Not (oRol.permisos Is Nothing) Then
                    For Each oPermiso As Permiso In oRol.permisos
                        LSTPermisosAsignadosARol.Items.Add(oPermiso)
                        For Each oElemento As Permiso In LSTPermisosNoAsignadosARol.Items
                            If oElemento.id = oPermiso.id Then
                                permisosAEliminarDeLaLista.Add(oElemento)
                                Exit For
                            End If
                        Next
                    Next

                    For Each oPermiso As Permiso In permisosAEliminarDeLaLista
                        LSTPermisosNoAsignadosARol.Items.Remove(oPermiso)
                    Next
                End If

            End If
        Catch ex As StockException
            MessageBox.Show(ex.mensaje)
        End Try
    End Sub

    Private Sub limpiarPantalla()
        TXTIdRol.Text = ""
        TXTDescripcionRol.Text = ""
        TXTNombreRol.Text = ""
        CMBModuloRol.SelectedIndex = 0
        LSTGruposRolAsignados.Items.Clear()
        LSTGruposRolNoAsignados.Items.Clear()
        LSTPermisosAsignadosARol.Items.Clear()
        LSTPermisosNoAsignadosARol.Items.Clear()

        Dim grupos As List(Of ElementoDeSeguridad) = Dispatcher(Of List(Of ElementoDeSeguridad), ObtenerTodosAccion).execute(New ObtenerTodosAccion())
        Dim permisos As List(Of Permiso) = Dispatcher(Of List(Of Permiso), ObtenerTodosAccion).execute(New ObtenerTodosAccion())

        For Each oElemento As ElementoDeSeguridad In grupos
            LSTGruposRolNoAsignados.Items.Add(oElemento)
        Next

        For Each oPermiso As Permiso In permisos
            LSTPermisosNoAsignadosARol.Items.Add(oPermiso)
        Next
    End Sub

    Private Sub BTNAsignarPermiso_Click(sender As Object, e As EventArgs) Handles BTNAsignarPermiso.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.ASIGNAR)
            For Each item As Permiso In LSTPermisosNoAsignadosARol.SelectedItems
                LSTPermisosAsignadosARol.Items.Add(item)

            Next
            LSTPermisosAsignadosARol.Refresh()
            LSTPermisosAsignadosARol.Update()

            For Each item As Permiso In LSTPermisosAsignadosARol.Items
                If LSTPermisosNoAsignadosARol.Items.Contains(item) Then
                    LSTPermisosNoAsignadosARol.Items.Remove(item)

                End If


            Next
            LSTPermisosNoAsignadosARol.Refresh()
            LSTPermisosNoAsignadosARol.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNDesasignarPermiso_Click(sender As Object, e As EventArgs) Handles BTNDesasignarPermiso.Click
        Try
            Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.DESASIGNAR)
            For Each item As Permiso In LSTPermisosAsignadosARol.SelectedItems
                LSTPermisosNoAsignadosARol.Items.Add(item)

            Next
            LSTPermisosNoAsignadosARol.Refresh()
            LSTPermisosNoAsignadosARol.Update()

            For Each item As Permiso In LSTPermisosNoAsignadosARol.Items
                If LSTPermisosAsignadosARol.Items.Contains(item) Then
                    LSTPermisosAsignadosARol.Items.Remove(item)

                End If


            Next
            LSTPermisosAsignadosARol.Refresh()
            LSTPermisosAsignadosARol.Update()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub

    Private Sub BTNELimpiarPantallaRoles_Click(sender As Object, e As EventArgs) Handles BTNELimpiarPantallaRoles.Click
        limpiarPantalla()
    End Sub

    Private Sub BTNEliminarRol_Click(sender As Object, e As EventArgs) Handles BTNEliminarRol.Click
        Try
            Dim mensaje As String = Dispatcher(Of String, EliminarRolAccion).execute(New EliminarRolAccion(TXTIdRol.Text))
            LBLMensajeRol.Text = mensaje
            limpiarPantalla()
        Catch exc As StockException
            MessageBox.Show(exc.mensaje)
        End Try
    End Sub
End Class