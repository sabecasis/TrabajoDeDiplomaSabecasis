Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class AbrirComprobanteIngresoCmd
    Inherits Comando(Of String, AbrirComprobanteIngresoAccion)

    Public Overrides Function execute(accion As AbrirComprobanteIngresoAccion) As String
        Try
            GeneradorDeComprobantes.convertFromByteArray(accion.buffer)
            Return ""
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
