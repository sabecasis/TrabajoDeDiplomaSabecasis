Imports StockModelo

Public Class DescargarArchivoAccion
    Implements Accion

    Public Sub New(path As String, buffer As Byte())
        Me.path = path
        Me.buffer = buffer
    End Sub

    Property path As String
    Property buffer As Byte()


End Class
