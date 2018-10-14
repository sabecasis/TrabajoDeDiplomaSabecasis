Imports StockModelo

Public Class GuardarEnBitacoraAccion
    Implements Accion

    Public Sub New()

    End Sub

    Public Sub New(accion As String, resultado As String)
        Me.accion = accion
        Me.resultado = resultado
    End Sub
    Property accion As String
    Property resultado As String

End Class
