Public Class RelacionEntidadDAO

    Property dao As String
    Property entidad As String

    Public Sub New(dao As String, entidad As String)
        Me.dao = dao
        Me.entidad = entidad
    End Sub

    Public Sub New()

    End Sub

End Class
