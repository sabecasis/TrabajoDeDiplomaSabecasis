<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupRestore
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
        Me.BTNCrearBackup = New System.Windows.Forms.Button()
        Me.TXTUbicacion = New System.Windows.Forms.TextBox()
        Me.LBLUbicacionBackup = New System.Windows.Forms.Label()
        Me.BTNExaminar = New System.Windows.Forms.Button()
        Me.OFDBackup = New System.Windows.Forms.OpenFileDialog()
        Me.BTNRestaurar = New System.Windows.Forms.Button()
        Me.LBLMensajeBackup = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNCrearBackup
        '
        Me.BTNCrearBackup.Location = New System.Drawing.Point(49, 138)
        Me.BTNCrearBackup.Name = "BTNCrearBackup"
        Me.BTNCrearBackup.Size = New System.Drawing.Size(226, 23)
        Me.BTNCrearBackup.TabIndex = 0
        Me.BTNCrearBackup.Text = "Crear Backup"
        Me.BTNCrearBackup.UseVisualStyleBackColor = True
        '
        'TXTUbicacion
        '
        Me.TXTUbicacion.Location = New System.Drawing.Point(158, 44)
        Me.TXTUbicacion.Name = "TXTUbicacion"
        Me.TXTUbicacion.Size = New System.Drawing.Size(330, 20)
        Me.TXTUbicacion.TabIndex = 1
        '
        'LBLUbicacionBackup
        '
        Me.LBLUbicacionBackup.AutoSize = True
        Me.LBLUbicacionBackup.Location = New System.Drawing.Point(46, 51)
        Me.LBLUbicacionBackup.Name = "LBLUbicacionBackup"
        Me.LBLUbicacionBackup.Size = New System.Drawing.Size(55, 13)
        Me.LBLUbicacionBackup.TabIndex = 2
        Me.LBLUbicacionBackup.Text = "Ubicacion"
        '
        'BTNExaminar
        '
        Me.BTNExaminar.Location = New System.Drawing.Point(525, 41)
        Me.BTNExaminar.Name = "BTNExaminar"
        Me.BTNExaminar.Size = New System.Drawing.Size(86, 23)
        Me.BTNExaminar.TabIndex = 3
        Me.BTNExaminar.Text = "Examinar"
        Me.BTNExaminar.UseVisualStyleBackColor = True
        '
        'OFDBackup
        '
        Me.OFDBackup.CheckFileExists = False
        Me.OFDBackup.FileName = "backup.bak"
        '
        'BTNRestaurar
        '
        Me.BTNRestaurar.Location = New System.Drawing.Point(340, 138)
        Me.BTNRestaurar.Name = "BTNRestaurar"
        Me.BTNRestaurar.Size = New System.Drawing.Size(258, 23)
        Me.BTNRestaurar.TabIndex = 4
        Me.BTNRestaurar.Text = "Restaurar backup"
        Me.BTNRestaurar.UseVisualStyleBackColor = True
        '
        'LBLMensajeBackup
        '
        Me.LBLMensajeBackup.AutoSize = True
        Me.LBLMensajeBackup.ForeColor = System.Drawing.Color.Red
        Me.LBLMensajeBackup.Location = New System.Drawing.Point(49, 196)
        Me.LBLMensajeBackup.Name = "LBLMensajeBackup"
        Me.LBLMensajeBackup.Size = New System.Drawing.Size(0, 13)
        Me.LBLMensajeBackup.TabIndex = 5
        '
        'BackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 421)
        Me.Controls.Add(Me.LBLMensajeBackup)
        Me.Controls.Add(Me.BTNRestaurar)
        Me.Controls.Add(Me.BTNExaminar)
        Me.Controls.Add(Me.LBLUbicacionBackup)
        Me.Controls.Add(Me.TXTUbicacion)
        Me.Controls.Add(Me.BTNCrearBackup)
        Me.Name = "BackupRestore"
        Me.Text = "BackupRestore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNCrearBackup As System.Windows.Forms.Button
    Friend WithEvents TXTUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents LBLUbicacionBackup As System.Windows.Forms.Label
    Friend WithEvents BTNExaminar As System.Windows.Forms.Button
    Friend WithEvents OFDBackup As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BTNRestaurar As System.Windows.Forms.Button
    Friend WithEvents LBLMensajeBackup As System.Windows.Forms.Label
End Class
