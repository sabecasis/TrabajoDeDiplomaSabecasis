Imports StockModelo
Imports System.Runtime.Serialization

Public Class AbrirComprobanteIngresoAccion
    Implements Accion
    Public Sub New(buffer As Byte())
        Me.buffer = buffer
    End Sub

    Property buffer As Byte()
End Class
