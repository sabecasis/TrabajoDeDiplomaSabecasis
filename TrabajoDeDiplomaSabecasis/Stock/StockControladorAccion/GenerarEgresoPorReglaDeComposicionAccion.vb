Imports StockModelo

Public Class GenerarEgresoPorReglaDeComposicionAccion
    Implements Accion

    Public Sub New(regla As String, deposito As Deposito, prodId As Integer)
        Me.reglaDeComposicion = regla
        Me.deposito = deposito
        Me.productoId = prodId
    End Sub

    Property reglaDeComposicion As String
    Property deposito As Deposito
    Property productoId As Integer

End Class
