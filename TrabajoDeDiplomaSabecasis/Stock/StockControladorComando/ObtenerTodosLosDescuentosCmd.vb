Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosDescuentosCmd
    Inherits Comando(Of List(Of Descuento), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Descuento)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Descuento) = DaoFactory(Of Descuento).obtenerInstancia().crear(GetType(Descuento))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
