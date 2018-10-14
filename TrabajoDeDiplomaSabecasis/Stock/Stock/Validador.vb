Public Class Validador

    Private Shared objeto As Validador = New Validador()

    Private Sub New()

    End Sub

    Public Shared Function obtenerInstancia() As Validador
        Return objeto
    End Function

    


End Class
