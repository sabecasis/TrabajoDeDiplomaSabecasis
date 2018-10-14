Public Class Deposito
    Property id As Integer = 0
    Property nomber As String
    Property contacto As Contacto

    Public Overrides Function ToString() As String
        Return "Id :" & Me.id.ToString & " nombre: " & Me.nomber
    End Function
End Class
