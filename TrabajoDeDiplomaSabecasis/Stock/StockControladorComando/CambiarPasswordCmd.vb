Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class CambiarPasswordCmd
    Inherits Comando(Of String, CambiarPasswordAccion)

    Public Overrides Function execute(accion As CambiarPasswordAccion) As String
        Try
            Dim dao As AbstractDao(Of Usuario) = DaoFactory(Of Usuario).obtenerInstancia.crear(GetType(Usuario))
            accion.usuario.esCambioDePassword = True
            dao.actualizar(accion.usuario)
            Return Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.PASSWORD_CAMBIADA)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
