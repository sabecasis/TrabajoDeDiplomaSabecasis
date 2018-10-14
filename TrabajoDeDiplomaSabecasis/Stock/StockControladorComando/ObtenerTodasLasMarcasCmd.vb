Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class ObtenerTodasLasMarcasCmd
    Inherits Comando(Of List(Of Marca), ObtenerTodosAccion)


    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Marca)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Marca) = DaoFactory(Of Marca).obtenerInstancia().crear(GetType(Marca))
            Return dao.obtenerMuchos(Nothing)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
