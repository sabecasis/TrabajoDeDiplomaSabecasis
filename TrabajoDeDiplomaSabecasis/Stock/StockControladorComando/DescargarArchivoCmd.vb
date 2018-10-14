Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class DescargarArchivoCmd
    Inherits Comando(Of String, DescargarArchivoAccion)


    Public Overrides Function execute(accion As DescargarArchivoAccion) As String
        Try
            GeneradorDeComprobantes.guardarArchivoEnDisco(accion.buffer, accion.path)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

        Return ""
    End Function
End Class
