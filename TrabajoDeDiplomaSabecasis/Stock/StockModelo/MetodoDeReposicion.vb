Public Class MetodoDeReposicion
    Property id As Integer
    Property metodo As String

    Public Overrides Function ToString() As String
        Return metodo
    End Function
End Class
