Public Class EstadoInstanciaProducto
    Property id As Integer
    Property estado As String

    Public Overrides Function ToString() As String
        Return Me.estado
    End Function
End Class
