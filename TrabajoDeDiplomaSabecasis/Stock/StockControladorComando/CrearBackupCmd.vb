Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class CrearBackupCmd
    Inherits Comando(Of String, HacerBackupAccion)


    Public Overrides Function execute(accion As HacerBackupAccion) As String
        Autorizador.obtenerInstancia().autorizar(ConstantesDePermisos.BACKUP)
        'Esto se hace por fuera de la factory porque necesitamos que esta sea la única acción que siempre se ejcute sin importar
        'el estado de la base de datos.
        Dim dao As BackupRestoreDao = New BackupRestoreDao()
        dao.crearBackup(accion.ruta)
        Return Sesion.obtenerInstancia().correlacionElementoIdioma.Item(ConstantesDeMensaje.BACKUP_CREADO_CORRECTO)
    End Function
End Class
