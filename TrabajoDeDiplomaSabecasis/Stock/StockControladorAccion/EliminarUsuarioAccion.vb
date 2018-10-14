Imports StockModelo

Public Class EliminarUsuarioAccion
    Implements Accion

    Public Sub New(idUsuario As Integer)
        Me.idUsuario = idUsuario
    End Sub

    Property idUsuario As Integer
End Class
