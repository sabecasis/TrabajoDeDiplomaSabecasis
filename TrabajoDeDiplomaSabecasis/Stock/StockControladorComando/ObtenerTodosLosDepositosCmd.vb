Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosDepositosCmd
    Inherits Comando(Of List(Of Deposito), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Deposito)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Deposito) = DaoFactory(Of Deposito).obtenerInstancia.crear(GetType(Deposito))
            Dim depositos As List(Of Deposito) = dao.obtenerMuchos(Nothing)
            Return depositos
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
