Public Class TipoDeExcepcion
    Property id As Integer
    Property tipo As String

    Public Overrides Function ToString() As String
        Return tipo
    End Function
End Class
