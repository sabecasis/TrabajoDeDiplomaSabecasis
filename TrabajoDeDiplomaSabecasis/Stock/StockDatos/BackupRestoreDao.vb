Imports System.Data.SqlClient
Imports ElementosTransversales
Imports System.IO

Public Class BackupRestoreDao

    Public Function restaurarBackup(ruta As String) As Boolean
        Dim query As String = ""
        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexionMaster()
        Try
            'Nos aseguramos de que el stored procedure exista en la base master (no podemos depender de un tercero para esto)
            query = "IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[restore_db]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[restore_db]"
            Dim comando As SqlCommand = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.Text
            conexion.Open()

            comando.ExecuteNonQuery()

            comando.Dispose()

            query = "CREATE PROCEDURE [dbo].[restore_db]  @Archivo varchar(255) AS SET NOCOUNT ON IF (not EXISTS (SELECT name  FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = 'stock_db' OR name = 'stock_db'))) CREATE DATABASE stock_db; ALTER DATABASE stock_db SET SINGLE_USER WITH ROLLBACK IMMEDIATE; declare @logfile varchar(MAX); declare @mdffile varchar(MAX); SELECT @logfile= [physical_name] FROM sys.[master_files] WHERE [database_id] IN (DB_ID('stock_db'), DB_ID('stock_db')) and name='stock_db_log' ORDER BY [type], DB_NAME([database_id]); SELECT @mdffile= [physical_name] FROM sys.[master_files] WHERE [database_id] IN (DB_ID('stock_db'), DB_ID('stock_db')) and name='stock_db' ORDER BY [type], DB_NAME([database_id]); RESTORE DATABASE stock_db FROM DISK = @Archivo WITH MOVE 'stock_db' TO @mdffile, MOVE 'stock_db_log' TO  @logfile, REPLACE;  ALTER DATABASE stock_db SET MULTI_USER;"
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.Text
            comando.ExecuteNonQuery()

            comando.Dispose()

            comando = New SqlCommand(ConstantesDeDatos.RESTAURAR_BACKUP_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            Dim param As New SqlParameter("@Archivo", SqlDbType.VarChar)
            param.Value = ruta
            comando.Parameters.Add(param)

            comando.ExecuteNonQuery()

            comando.Dispose()
            conexion.Close()

        Catch e As Exception
            conexion.Close()
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, query)
        End Try

        Return True
    End Function

    Public Function crearBackup(ruta As String) As Boolean
        Dim conexion As SqlConnection = ConnectionManager.obtenerInstancia().obtenerConexion()
        Try

            Dim comando As SqlCommand = New SqlCommand(ConstantesDeDatos.CREAR_BACKUP_SP, conexion)
            comando.CommandType = CommandType.StoredProcedure

            Dim file As String = ruta.Substring(ruta.LastIndexOf("\") + 1)
            Dim folder As String = ruta.Substring(0, ruta.LastIndexOf("\"))

            comando.Parameters.AddWithValue("@folder", folder)
            comando.Parameters.AddWithValue("@file", file)

            conexion.Open()

            comando.ExecuteNonQuery()

            comando.Dispose()
            conexion.Close()

            Return True

        Catch e As Exception
            conexion.Close()
            Throw New ExcepcionDeDatos(e, Me.GetType.Name, ConstantesDeDatos.CREAR_BACKUP_SP)
        End Try

    End Function


   
End Class
