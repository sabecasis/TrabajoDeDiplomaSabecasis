Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class RestaurarBackupCmd
    Inherits Comando(Of String, RestaurarBackupAccion)

    Public Overrides Function execute(accion As RestaurarBackupAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.RESTORE)
        'está cableado porque nos interesa que esta accion en especial se pueda ejecutar si la base está rota también.
        Dim dao As BackupRestoreDao = New BackupRestoreDao()
        Dim resultado As Boolean = dao.restaurarBackup(accion.ruta)
        Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.BACKUP_RESTAURADO_CORRECTAMENTE)
    End Function
End Class
