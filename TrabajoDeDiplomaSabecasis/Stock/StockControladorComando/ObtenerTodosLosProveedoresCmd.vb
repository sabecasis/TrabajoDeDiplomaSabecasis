Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodosLosProveedoresCmd
    Inherits Comando(Of List(Of Proveedor), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Proveedor)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Proveedor) = DaoFactory(Of Proveedor).obtenerInstancia.crear(GetType(Proveedor))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
