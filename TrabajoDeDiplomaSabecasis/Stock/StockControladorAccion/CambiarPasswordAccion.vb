Imports StockModelo

Public Class CambiarPasswordAccion
    Implements Accion

    Property usuario As Usuario

    Public Sub New(user As Usuario)
        Me.usuario = user
    End Sub
End Class
