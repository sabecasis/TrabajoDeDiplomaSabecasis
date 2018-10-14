Public Class Rol
    Property id As Integer
    Property rol As String
    Property descripcion As String
    Property modulo As Modulo
    Property grupos As List(Of ElementoDeSeguridad)
    Property permisos As List(Of Permiso)
    Property digitoHorizontal As Integer
End Class
