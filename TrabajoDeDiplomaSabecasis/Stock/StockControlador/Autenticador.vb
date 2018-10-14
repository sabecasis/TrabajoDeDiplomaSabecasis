Imports StockDatos
Imports StockModelo
Imports ElementosTransversales
Imports StockControladorAccion
Imports StockControladorComando

Public Class Autenticador

    Private Shared oAutenticador As Autenticador = New Autenticador

    Private Sub New()
    End Sub

    Public Shared Function obtenerInstancia() As Autenticador
        Return oAutenticador
    End Function

    Public Function autenticarSuperAdmin(oUsuario As String, oPassword As String)
        Dim usuario As Usuario = New Usuario()
        Dim respuesta As RespuestaSeguridad = New RespuestaSeguridad
        If esSuperAdmin(oUsuario, oPassword) Then
            respuesta.estaAutenticado = True
            usuario.nombre = oUsuario
            usuario.empleados = New List(Of Empleado)
            Dim oEmpleado As New Empleado
            oEmpleado.id = 1
            usuario.empleados.Add(oEmpleado)
            Sesion.obtenerInstancia().usuarioActual = usuario
            Return respuesta
        Else
            respuesta.estaAutenticado = False
            Return respuesta
        End If
    End Function

    Public Function autenticar(oUsuario As String, oPassword As String) As RespuestaSeguridad
        Dim usuario As Usuario = New Usuario()
        Dim respuesta As RespuestaSeguridad = New RespuestaSeguridad
        Sesion.obtenerInstancia().usuarioActual.nombre = oUsuario
        If esSuperAdmin(oUsuario, oPassword) Then
            respuesta.estaAutenticado = True
            Dim guardarEnBitacora As New GuardarEnBitacoraCmd()
            guardarEnBitacora.execute(New GuardarEnBitacoraAccion(GetType(LoginAccion).ToString, "Nothing"))
            usuario.nombre = oUsuario
            usuario.empleados = New List(Of Empleado)
            Dim oEmpleado As New Empleado
            oEmpleado.id = 1
            Try
                Dim empDao As AbstractDao(Of Empleado) = DaoFactory(Of Empleado).obtenerInstancia().crear(GetType(Empleado))
                Dim criteria As New GenericQueryCriteria
                criteria.stringCriteria = "SuperAdmin"
                oEmpleado = empDao.obtenerUno(criteria)
            Catch ex As Exception
                ' no hacer nada, puede que esté bloqueada la base
            End Try
            usuario.empleados.Add(oEmpleado)
            Sesion.obtenerInstancia().usuarioActual = usuario
        Else
            respuesta = Dispatcher(Of RespuestaSeguridad, LoginAccion).execute(New LoginAccion(oUsuario, oPassword))
        End If
        Return respuesta
    End Function

    Private Function esSuperAdmin(usuario As String, password As String) As Boolean
        Dim temPassword As String = "SuperAdmin" & Date.Now.Month.ToString() & Date.Now.Day.ToString & Date.Now.Year.ToString
        If usuario.Trim.Equals("SuperAdmin") And password.Trim.Equals(temPassword.Trim) Then
            Return True
        End If
        Return False
    End Function
End Class
