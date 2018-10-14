<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarGrupo
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
        Me.LBLIdGrupo = New System.Windows.Forms.Label()
        Me.LBLNombreGrupo = New System.Windows.Forms.Label()
        Me.LSTGruposNoAsignados = New System.Windows.Forms.ListBox()
        Me.LSTGruposAsignados = New System.Windows.Forms.ListBox()
        Me.BTNAsignarGrupo = New System.Windows.Forms.Button()
        Me.BTNDesasignarGrupo = New System.Windows.Forms.Button()
        Me.LBLTituloGrupoNoAsignado = New System.Windows.Forms.Label()
        Me.LBLGruposAsignados = New System.Windows.Forms.Label()
        Me.TXTIdGrupo = New System.Windows.Forms.TextBox()
        Me.TXTNombreGrupo = New System.Windows.Forms.TextBox()
        Me.BTNGuardarGrupo = New System.Windows.Forms.Button()
        Me.LBLMensajeOperacionGrupo = New System.Windows.Forms.Label()
        Me.BTNBuscarGrupo = New System.Windows.Forms.Button()
        Me.BTNLimpiar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLIdGrupo
        '
        Me.LBLIdGrupo.AutoSize = True
        Me.LBLIdGrupo.Location = New System.Drawing.Point(62, 63)
        Me.LBLIdGrupo.Name = "LBLIdGrupo"
        Me.LBLIdGrupo.Size = New System.Drawing.Size(16, 13)
        Me.LBLIdGrupo.TabIndex = 0
        Me.LBLIdGrupo.Text = "Id"
        '
        'LBLNombreGrupo
        '
        Me.LBLNombreGrupo.AutoSize = True
        Me.LBLNombreGrupo.Location = New System.Drawing.Point(62, 89)
        Me.LBLNombreGrupo.Name = "LBLNombreGrupo"
        Me.LBLNombreGrupo.Size = New System.Drawing.Size(44, 13)
        Me.LBLNombreGrupo.TabIndex = 1
        Me.LBLNombreGrupo.Text = "Nombre"
        '
        'LSTGruposNoAsignados
        '
        Me.LSTGruposNoAsignados.FormattingEnabled = True
        Me.LSTGruposNoAsignados.Location = New System.Drawing.Point(65, 158)
        Me.LSTGruposNoAsignados.Name = "LSTGruposNoAsignados"
        Me.LSTGruposNoAsignados.Size = New System.Drawing.Size(180, 186)
        Me.LSTGruposNoAsignados.TabIndex = 2
        '
        'LSTGruposAsignados
        '
        Me.LSTGruposAsignados.FormattingEnabled = True
        Me.LSTGruposAsignados.Location = New System.Drawing.Point(317, 158)
        Me.LSTGruposAsignados.Name = "LSTGruposAsignados"
        Me.LSTGruposAsignados.Size = New System.Drawing.Size(200, 186)
        Me.LSTGruposAsignados.TabIndex = 3
        '
        'BTNAsignarGrupo
        '
        Me.BTNAsignarGrupo.Location = New System.Drawing.Point(260, 199)
        Me.BTNAsignarGrupo.Name = "BTNAsignarGrupo"
        Me.BTNAsignarGrupo.Size = New System.Drawing.Size(51, 23)
        Me.BTNAsignarGrupo.TabIndex = 4
        Me.BTNAsignarGrupo.Text = ">>"
        Me.BTNAsignarGrupo.UseVisualStyleBackColor = True
        '
        'BTNDesasignarGrupo
        '
        Me.BTNDesasignarGrupo.Location = New System.Drawing.Point(260, 245)
        Me.BTNDesasignarGrupo.Name = "BTNDesasignarGrupo"
        Me.BTNDesasignarGrupo.Size = New System.Drawing.Size(51, 23)
        Me.BTNDesasignarGrupo.TabIndex = 5
        Me.BTNDesasignarGrupo.Text = "<<"
        Me.BTNDesasignarGrupo.UseVisualStyleBackColor = True
        '
        'LBLTituloGrupoNoAsignado
        '
        Me.LBLTituloGrupoNoAsignado.AutoSize = True
        Me.LBLTituloGrupoNoAsignado.Location = New System.Drawing.Point(65, 139)
        Me.LBLTituloGrupoNoAsignado.Name = "LBLTituloGrupoNoAsignado"
        Me.LBLTituloGrupoNoAsignado.Size = New System.Drawing.Size(157, 13)
        Me.LBLTituloGrupoNoAsignado.TabIndex = 6
        Me.LBLTituloGrupoNoAsignado.Text = "Usuarios y grupos no asignados"
        '
        'LBLGruposAsignados
        '
        Me.LBLGruposAsignados.AutoSize = True
        Me.LBLGruposAsignados.Location = New System.Drawing.Point(314, 139)
        Me.LBLGruposAsignados.Name = "LBLGruposAsignados"
        Me.LBLGruposAsignados.Size = New System.Drawing.Size(142, 13)
        Me.LBLGruposAsignados.TabIndex = 7
        Me.LBLGruposAsignados.Text = "Usuarios y grupos asignados"
        '
        'TXTIdGrupo
        '
        Me.TXTIdGrupo.Location = New System.Drawing.Point(200, 60)
        Me.TXTIdGrupo.Name = "TXTIdGrupo"
        Me.TXTIdGrupo.ReadOnly = True
        Me.TXTIdGrupo.Size = New System.Drawing.Size(100, 20)
        Me.TXTIdGrupo.TabIndex = 8
        '
        'TXTNombreGrupo
        '
        Me.TXTNombreGrupo.Location = New System.Drawing.Point(200, 85)
        Me.TXTNombreGrupo.Name = "TXTNombreGrupo"
        Me.TXTNombreGrupo.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombreGrupo.TabIndex = 9
        '
        'BTNGuardarGrupo
        '
        Me.BTNGuardarGrupo.Location = New System.Drawing.Point(317, 82)
        Me.BTNGuardarGrupo.Name = "BTNGuardarGrupo"
        Me.BTNGuardarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardarGrupo.TabIndex = 10
        Me.BTNGuardarGrupo.Text = "Guardar"
        Me.BTNGuardarGrupo.UseVisualStyleBackColor = True
        '
        'LBLMensajeOperacionGrupo
        '
        Me.LBLMensajeOperacionGrupo.AutoSize = True
        Me.LBLMensajeOperacionGrupo.ForeColor = System.Drawing.Color.Red
        Me.LBLMensajeOperacionGrupo.Location = New System.Drawing.Point(65, 13)
        Me.LBLMensajeOperacionGrupo.Name = "LBLMensajeOperacionGrupo"
        Me.LBLMensajeOperacionGrupo.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensajeOperacionGrupo.TabIndex = 11
        '
        'BTNBuscarGrupo
        '
        Me.BTNBuscarGrupo.Location = New System.Drawing.Point(416, 82)
        Me.BTNBuscarGrupo.Name = "BTNBuscarGrupo"
        Me.BTNBuscarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscarGrupo.TabIndex = 12
        Me.BTNBuscarGrupo.Text = "Buscar"
        Me.BTNBuscarGrupo.UseVisualStyleBackColor = True
        '
        'BTNLimpiar
        '
        Me.BTNLimpiar.Location = New System.Drawing.Point(317, 53)
        Me.BTNLimpiar.Name = "BTNLimpiar"
        Me.BTNLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiar.TabIndex = 13
        Me.BTNLimpiar.Text = "Limpiar"
        Me.BTNLimpiar.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(416, 53)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminar.TabIndex = 14
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'GestionarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 460)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.BTNLimpiar)
        Me.Controls.Add(Me.BTNBuscarGrupo)
        Me.Controls.Add(Me.LBLMensajeOperacionGrupo)
        Me.Controls.Add(Me.BTNGuardarGrupo)
        Me.Controls.Add(Me.TXTNombreGrupo)
        Me.Controls.Add(Me.TXTIdGrupo)
        Me.Controls.Add(Me.LBLGruposAsignados)
        Me.Controls.Add(Me.LBLTituloGrupoNoAsignado)
        Me.Controls.Add(Me.BTNDesasignarGrupo)
        Me.Controls.Add(Me.BTNAsignarGrupo)
        Me.Controls.Add(Me.LSTGruposAsignados)
        Me.Controls.Add(Me.LSTGruposNoAsignados)
        Me.Controls.Add(Me.LBLNombreGrupo)
        Me.Controls.Add(Me.LBLIdGrupo)
        Me.Name = "GestionarGrupo"
        Me.Text = "GestionarGrupo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIdGrupo As System.Windows.Forms.Label
    Friend WithEvents LBLNombreGrupo As System.Windows.Forms.Label
    Friend WithEvents LSTGruposNoAsignados As System.Windows.Forms.ListBox
    Friend WithEvents LSTGruposAsignados As System.Windows.Forms.ListBox
    Friend WithEvents BTNAsignarGrupo As System.Windows.Forms.Button
    Friend WithEvents BTNDesasignarGrupo As System.Windows.Forms.Button
    Friend WithEvents LBLTituloGrupoNoAsignado As System.Windows.Forms.Label
    Friend WithEvents LBLGruposAsignados As System.Windows.Forms.Label
    Friend WithEvents TXTIdGrupo As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombreGrupo As System.Windows.Forms.TextBox
    Friend WithEvents BTNGuardarGrupo As System.Windows.Forms.Button
    Friend WithEvents LBLMensajeOperacionGrupo As System.Windows.Forms.Label
    Friend WithEvents BTNBuscarGrupo As System.Windows.Forms.Button
    Friend WithEvents BTNLimpiar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
End Class
