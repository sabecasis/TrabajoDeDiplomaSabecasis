<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionRoles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBLMensajeRol = New System.Windows.Forms.Label()
        Me.LBLIdRol = New System.Windows.Forms.Label()
        Me.LBLNombreRol = New System.Windows.Forms.Label()
        Me.LBLDescripcionRol = New System.Windows.Forms.Label()
        Me.TXTIdRol = New System.Windows.Forms.TextBox()
        Me.TXTNombreRol = New System.Windows.Forms.TextBox()
        Me.TXTDescripcionRol = New System.Windows.Forms.TextBox()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNBuscar = New System.Windows.Forms.Button()
        Me.CMBModuloRol = New System.Windows.Forms.ComboBox()
        Me.LBLModuloRol = New System.Windows.Forms.Label()
        Me.LBLGrupoasAsignadosRol = New System.Windows.Forms.Label()
        Me.LBLGrruposNoAsignadosRol = New System.Windows.Forms.Label()
        Me.BTNAsignarGrupoARol = New System.Windows.Forms.Button()
        Me.BTNDesasignarGrupoARol = New System.Windows.Forms.Button()
        Me.LSTGruposRolAsignados = New System.Windows.Forms.ListBox()
        Me.LSTGruposRolNoAsignados = New System.Windows.Forms.ListBox()
        Me.LSTPermisosNoAsignadosARol = New System.Windows.Forms.ListBox()
        Me.LSTPermisosAsignadosARol = New System.Windows.Forms.ListBox()
        Me.BTNDesasignarPermiso = New System.Windows.Forms.Button()
        Me.BTNAsignarPermiso = New System.Windows.Forms.Button()
        Me.LBLPermisosNoAsinadosARol = New System.Windows.Forms.Label()
        Me.LBLPermisosAsignadosARol = New System.Windows.Forms.Label()
        Me.BTNELimpiarPantallaRoles = New System.Windows.Forms.Button()
        Me.BTNEliminarRol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLMensajeRol
        '
        Me.LBLMensajeRol.AutoSize = True
        Me.LBLMensajeRol.ForeColor = System.Drawing.Color.Red
        Me.LBLMensajeRol.Location = New System.Drawing.Point(63, 29)
        Me.LBLMensajeRol.Name = "LBLMensajeRol"
        Me.LBLMensajeRol.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensajeRol.TabIndex = 0
        '
        'LBLIdRol
        '
        Me.LBLIdRol.AutoSize = True
        Me.LBLIdRol.Location = New System.Drawing.Point(71, 78)
        Me.LBLIdRol.Name = "LBLIdRol"
        Me.LBLIdRol.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdRol.TabIndex = 1
        Me.LBLIdRol.Text = "Id"
        '
        'LBLNombreRol
        '
        Me.LBLNombreRol.AutoSize = True
        Me.LBLNombreRol.Location = New System.Drawing.Point(68, 105)
        Me.LBLNombreRol.Name = "LBLNombreRol"
        Me.LBLNombreRol.Size = New System.Drawing.Size(44, 13)
        Me.LBLNombreRol.TabIndex = 2
        Me.LBLNombreRol.Text = "Nombre"
        '
        'LBLDescripcionRol
        '
        Me.LBLDescripcionRol.AutoSize = True
        Me.LBLDescripcionRol.Location = New System.Drawing.Point(68, 134)
        Me.LBLDescripcionRol.Name = "LBLDescripcionRol"
        Me.LBLDescripcionRol.Size = New System.Drawing.Size(63, 13)
        Me.LBLDescripcionRol.TabIndex = 3
        Me.LBLDescripcionRol.Text = "Descripción"
        '
        'TXTIdRol
        '
        Me.TXTIdRol.Location = New System.Drawing.Point(202, 75)
        Me.TXTIdRol.Name = "TXTIdRol"
        Me.TXTIdRol.ReadOnly = True
        Me.TXTIdRol.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdRol.TabIndex = 4
        '
        'TXTNombreRol
        '
        Me.TXTNombreRol.Location = New System.Drawing.Point(202, 102)
        Me.TXTNombreRol.Name = "TXTNombreRol"
        Me.TXTNombreRol.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombreRol.TabIndex = 5
        '
        'TXTDescripcionRol
        '
        Me.TXTDescripcionRol.Location = New System.Drawing.Point(202, 131)
        Me.TXTDescripcionRol.Name = "TXTDescripcionRol"
        Me.TXTDescripcionRol.Size = New System.Drawing.Size(100, 20)
        Me.TXTDescripcionRol.TabIndex = 6
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Location = New System.Drawing.Point(407, 72)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 7
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNBuscar
        '
        Me.BTNBuscar.Location = New System.Drawing.Point(514, 72)
        Me.BTNBuscar.Name = "BTNBuscar"
        Me.BTNBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscar.TabIndex = 8
        Me.BTNBuscar.Text = "Buscar"
        Me.BTNBuscar.UseVisualStyleBackColor = True
        '
        'CMBModuloRol
        '
        Me.CMBModuloRol.FormattingEnabled = True
        Me.CMBModuloRol.Location = New System.Drawing.Point(202, 163)
        Me.CMBModuloRol.Name = "CMBModuloRol"
        Me.CMBModuloRol.Size = New System.Drawing.Size(280, 21)
        Me.CMBModuloRol.TabIndex = 9
        '
        'LBLModuloRol
        '
        Me.LBLModuloRol.AutoSize = True
        Me.LBLModuloRol.Location = New System.Drawing.Point(68, 171)
        Me.LBLModuloRol.Name = "LBLModuloRol"
        Me.LBLModuloRol.Size = New System.Drawing.Size(42, 13)
        Me.LBLModuloRol.TabIndex = 10
        Me.LBLModuloRol.Text = "Módulo"
        '
        'LBLGrupoasAsignadosRol
        '
        Me.LBLGrupoasAsignadosRol.AutoSize = True
        Me.LBLGrupoasAsignadosRol.Location = New System.Drawing.Point(68, 223)
        Me.LBLGrupoasAsignadosRol.Name = "LBLGrupoasAsignadosRol"
        Me.LBLGrupoasAsignadosRol.Size = New System.Drawing.Size(195, 13)
        Me.LBLGrupoasAsignadosRol.TabIndex = 11
        Me.LBLGrupoasAsignadosRol.Text = "Grupos y usuarios con este rol asignado"
        '
        'LBLGrruposNoAsignadosRol
        '
        Me.LBLGrruposNoAsignadosRol.AutoSize = True
        Me.LBLGrruposNoAsignadosRol.Location = New System.Drawing.Point(333, 223)
        Me.LBLGrruposNoAsignadosRol.Name = "LBLGrruposNoAsignadosRol"
        Me.LBLGrruposNoAsignadosRol.Size = New System.Drawing.Size(210, 13)
        Me.LBLGrruposNoAsignadosRol.TabIndex = 12
        Me.LBLGrruposNoAsignadosRol.Text = "Grupos y usuarios con este rol no asignado"
        '
        'BTNAsignarGrupoARol
        '
        Me.BTNAsignarGrupoARol.Location = New System.Drawing.Point(256, 275)
        Me.BTNAsignarGrupoARol.Name = "BTNAsignarGrupoARol"
        Me.BTNAsignarGrupoARol.Size = New System.Drawing.Size(75, 23)
        Me.BTNAsignarGrupoARol.TabIndex = 15
        Me.BTNAsignarGrupoARol.Text = "<<"
        Me.BTNAsignarGrupoARol.UseVisualStyleBackColor = True
        '
        'BTNDesasignarGrupoARol
        '
        Me.BTNDesasignarGrupoARol.Location = New System.Drawing.Point(256, 321)
        Me.BTNDesasignarGrupoARol.Name = "BTNDesasignarGrupoARol"
        Me.BTNDesasignarGrupoARol.Size = New System.Drawing.Size(75, 23)
        Me.BTNDesasignarGrupoARol.TabIndex = 16
        Me.BTNDesasignarGrupoARol.Text = ">>"
        Me.BTNDesasignarGrupoARol.UseVisualStyleBackColor = True
        '
        'LSTGruposRolAsignados
        '
        Me.LSTGruposRolAsignados.FormattingEnabled = True
        Me.LSTGruposRolAsignados.Location = New System.Drawing.Point(74, 249)
        Me.LSTGruposRolAsignados.Name = "LSTGruposRolAsignados"
        Me.LSTGruposRolAsignados.Size = New System.Drawing.Size(176, 186)
        Me.LSTGruposRolAsignados.TabIndex = 17
        '
        'LSTGruposRolNoAsignados
        '
        Me.LSTGruposRolNoAsignados.FormattingEnabled = True
        Me.LSTGruposRolNoAsignados.Location = New System.Drawing.Point(336, 249)
        Me.LSTGruposRolNoAsignados.Name = "LSTGruposRolNoAsignados"
        Me.LSTGruposRolNoAsignados.Size = New System.Drawing.Size(207, 186)
        Me.LSTGruposRolNoAsignados.TabIndex = 19
        '
        'LSTPermisosNoAsignadosARol
        '
        Me.LSTPermisosNoAsignadosARol.FormattingEnabled = True
        Me.LSTPermisosNoAsignadosARol.Location = New System.Drawing.Point(873, 249)
        Me.LSTPermisosNoAsignadosARol.Name = "LSTPermisosNoAsignadosARol"
        Me.LSTPermisosNoAsignadosARol.Size = New System.Drawing.Size(192, 186)
        Me.LSTPermisosNoAsignadosARol.TabIndex = 25
        '
        'LSTPermisosAsignadosARol
        '
        Me.LSTPermisosAsignadosARol.FormattingEnabled = True
        Me.LSTPermisosAsignadosARol.Location = New System.Drawing.Point(611, 249)
        Me.LSTPermisosAsignadosARol.Name = "LSTPermisosAsignadosARol"
        Me.LSTPermisosAsignadosARol.Size = New System.Drawing.Size(176, 186)
        Me.LSTPermisosAsignadosARol.TabIndex = 24
        '
        'BTNDesasignarPermiso
        '
        Me.BTNDesasignarPermiso.Location = New System.Drawing.Point(793, 321)
        Me.BTNDesasignarPermiso.Name = "BTNDesasignarPermiso"
        Me.BTNDesasignarPermiso.Size = New System.Drawing.Size(75, 23)
        Me.BTNDesasignarPermiso.TabIndex = 23
        Me.BTNDesasignarPermiso.Text = ">>"
        Me.BTNDesasignarPermiso.UseVisualStyleBackColor = True
        '
        'BTNAsignarPermiso
        '
        Me.BTNAsignarPermiso.Location = New System.Drawing.Point(793, 275)
        Me.BTNAsignarPermiso.Name = "BTNAsignarPermiso"
        Me.BTNAsignarPermiso.Size = New System.Drawing.Size(75, 23)
        Me.BTNAsignarPermiso.TabIndex = 22
        Me.BTNAsignarPermiso.Text = "<<"
        Me.BTNAsignarPermiso.UseVisualStyleBackColor = True
        '
        'LBLPermisosNoAsinadosARol
        '
        Me.LBLPermisosNoAsinadosARol.AutoSize = True
        Me.LBLPermisosNoAsinadosARol.Location = New System.Drawing.Point(870, 223)
        Me.LBLPermisosNoAsinadosARol.Name = "LBLPermisosNoAsinadosARol"
        Me.LBLPermisosNoAsinadosARol.Size = New System.Drawing.Size(161, 13)
        Me.LBLPermisosNoAsinadosARol.TabIndex = 21
        Me.LBLPermisosNoAsinadosARol.Text = "Permisos no asignados a este rol"
        '
        'LBLPermisosAsignadosARol
        '
        Me.LBLPermisosAsignadosARol.AutoSize = True
        Me.LBLPermisosAsignadosARol.Location = New System.Drawing.Point(608, 223)
        Me.LBLPermisosAsignadosARol.Name = "LBLPermisosAsignadosARol"
        Me.LBLPermisosAsignadosARol.Size = New System.Drawing.Size(146, 13)
        Me.LBLPermisosAsignadosARol.TabIndex = 20
        Me.LBLPermisosAsignadosARol.Text = "Permisos asignados a este rol"
        '
        'BTNELimpiarPantallaRoles
        '
        Me.BTNELimpiarPantallaRoles.Location = New System.Drawing.Point(407, 104)
        Me.BTNELimpiarPantallaRoles.Name = "BTNELimpiarPantallaRoles"
        Me.BTNELimpiarPantallaRoles.Size = New System.Drawing.Size(75, 23)
        Me.BTNELimpiarPantallaRoles.TabIndex = 26
        Me.BTNELimpiarPantallaRoles.Text = "Limpiar"
        Me.BTNELimpiarPantallaRoles.UseVisualStyleBackColor = True
        '
        'BTNEliminarRol
        '
        Me.BTNEliminarRol.Location = New System.Drawing.Point(514, 104)
        Me.BTNEliminarRol.Name = "BTNEliminarRol"
        Me.BTNEliminarRol.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminarRol.TabIndex = 27
        Me.BTNEliminarRol.Text = "Eliminar"
        Me.BTNEliminarRol.UseVisualStyleBackColor = True
        '
        'FormGestionRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 482)
        Me.Controls.Add(Me.BTNEliminarRol)
        Me.Controls.Add(Me.BTNELimpiarPantallaRoles)
        Me.Controls.Add(Me.LSTPermisosNoAsignadosARol)
        Me.Controls.Add(Me.LSTPermisosAsignadosARol)
        Me.Controls.Add(Me.BTNDesasignarPermiso)
        Me.Controls.Add(Me.BTNAsignarPermiso)
        Me.Controls.Add(Me.LBLPermisosNoAsinadosARol)
        Me.Controls.Add(Me.LBLPermisosAsignadosARol)
        Me.Controls.Add(Me.LSTGruposRolNoAsignados)
        Me.Controls.Add(Me.LSTGruposRolAsignados)
        Me.Controls.Add(Me.BTNDesasignarGrupoARol)
        Me.Controls.Add(Me.BTNAsignarGrupoARol)
        Me.Controls.Add(Me.LBLGrruposNoAsignadosRol)
        Me.Controls.Add(Me.LBLGrupoasAsignadosRol)
        Me.Controls.Add(Me.LBLModuloRol)
        Me.Controls.Add(Me.CMBModuloRol)
        Me.Controls.Add(Me.BTNBuscar)
        Me.Controls.Add(Me.BTNGuardar)
        Me.Controls.Add(Me.TXTDescripcionRol)
        Me.Controls.Add(Me.TXTNombreRol)
        Me.Controls.Add(Me.TXTIdRol)
        Me.Controls.Add(Me.LBLDescripcionRol)
        Me.Controls.Add(Me.LBLNombreRol)
        Me.Controls.Add(Me.LBLIdRol)
        Me.Controls.Add(Me.LBLMensajeRol)
        Me.Name = "FormGestionRoles"
        Me.Text = "GestionarRoles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLMensajeRol As System.Windows.Forms.Label
    Friend WithEvents LBLIdRol As System.Windows.Forms.Label
    Friend WithEvents LBLNombreRol As System.Windows.Forms.Label
    Friend WithEvents LBLDescripcionRol As System.Windows.Forms.Label
    Friend WithEvents TXTIdRol As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombreRol As System.Windows.Forms.TextBox
    Friend WithEvents TXTDescripcionRol As System.Windows.Forms.TextBox
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNBuscar As System.Windows.Forms.Button
    Friend WithEvents CMBModuloRol As System.Windows.Forms.ComboBox
    Friend WithEvents LBLModuloRol As System.Windows.Forms.Label
    Friend WithEvents LBLGrupoasAsignadosRol As System.Windows.Forms.Label
    Friend WithEvents LBLGrruposNoAsignadosRol As System.Windows.Forms.Label
    Friend WithEvents BTNAsignarGrupoARol As System.Windows.Forms.Button
    Friend WithEvents BTNDesasignarGrupoARol As System.Windows.Forms.Button
    Friend WithEvents LSTGruposRolAsignados As System.Windows.Forms.ListBox
    Friend WithEvents LSTGruposRolNoAsignados As System.Windows.Forms.ListBox
    Friend WithEvents LSTPermisosNoAsignadosARol As System.Windows.Forms.ListBox
    Friend WithEvents LSTPermisosAsignadosARol As System.Windows.Forms.ListBox
    Friend WithEvents BTNDesasignarPermiso As System.Windows.Forms.Button
    Friend WithEvents BTNAsignarPermiso As System.Windows.Forms.Button
    Friend WithEvents LBLPermisosNoAsinadosARol As System.Windows.Forms.Label
    Friend WithEvents LBLPermisosAsignadosARol As System.Windows.Forms.Label
    Friend WithEvents BTNELimpiarPantallaRoles As System.Windows.Forms.Button
    Friend WithEvents BTNEliminarRol As System.Windows.Forms.Button
End Class
