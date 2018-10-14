Imports StockModelo
Imports System.Data.SqlClient
Imports System.Configuration

Public Class GuardarEnLogAccion

    Public Shared Sub guardar(accion As String, clase As String, query As String, tipo_error_id As Integer, excepcion As String, fecha As DateTime, mensaje_error As String)
        Try
            Dim connectionstring As String = ConfigurationManager.ConnectionStrings("stockdb").ConnectionString()
            Dim conexion As SqlConnection
            conexion = New SqlConnection(connectionstring)
            Dim comando As SqlCommand = New SqlCommand("guardar_log_de_errores", conexion)
            conexion.Open()

            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@fecha_y_hora", fecha)
            comando.Parameters.AddWithValue("@mensaje_error", mensaje_error)
            comando.Parameters.AddWithValue("@excepcion", excepcion)
            comando.Parameters.AddWithValue("@tipo_excepcion_id", tipo_error_id)
            If clase Is Nothing Then
                comando.Parameters.AddWithValue("@clase", "")
            Else
                comando.Parameters.AddWithValue("@clase", clase)
            End If
            If accion Is Nothing Then
                comando.Parameters.AddWithValue("@accion", "")
            Else
                comando.Parameters.AddWithValue("@accion", accion)
            End If
            If query Is Nothing Then
                comando.Parameters.AddWithValue("@query", "")
            Else
                comando.Parameters.AddWithValue("@query", query)
            End If

            comando.ExecuteNonQuery()

            conexion.Close()
            comando.Dispose()

        Catch ex As Exception
            'todo logear en un txt
        End Try

    End Sub

End Class
