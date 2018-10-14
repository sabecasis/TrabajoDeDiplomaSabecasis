Public MustInherit Class Comando(Of T, I As Accion)

    Public MustOverride Function execute(accion As I) As T

End Class
