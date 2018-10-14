Imports System.Data.SqlClient
Imports System.Configuration

Public Class ConnectionManager

    Private Shared oConnManager As ConnectionManager = New ConnectionManager
    Private Sub New()

    End Sub

    Public Shared Function obtenerInstancia() As ConnectionManager
        Return oConnManager
    End Function

    Public Function obtenerConexion() As SqlConnection
        Dim connectionstring As String = ConfigurationManager.ConnectionStrings("stockdb").ConnectionString()
        Dim conexion As SqlConnection
        conexion = New SqlConnection(connectionstring)
        Return conexion
    End Function

    Public Function obtenerConexionMaster() As SqlConnection
        Dim connectionstring As String = ConfigurationManager.ConnectionStrings("master").ConnectionString()
        Dim conexion As SqlConnection
        conexion = New SqlConnection(connectionstring)
        Return conexion
    End Function
End Class
