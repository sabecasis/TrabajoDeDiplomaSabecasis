Public Class Usuario
    Inherits ElementoDeSeguridad

    Property password As String
    Property bloqueado As Boolean
    Property contadorMalaPassword As Integer = 0
    Property preguntaSecreta As String
    Property respuestaSecreta As String
    Property empleados As List(Of Empleado)
    Property esCambioDePassword As Boolean = False

End Class
