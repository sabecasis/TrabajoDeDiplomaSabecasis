Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class ObtenerTodasMateriasPrimasCmd
    Inherits Comando(Of List(Of Producto), ObtenerTodasMateriasPrimasAccion)


    Public Overrides Function execute(accion As ObtenerTodasMateriasPrimasAccion) As List(Of Producto)
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Producto) = DaoFactory(Of Producto).obtenerInstancia().crear(GetType(Producto))
            Dim criteria As New GenericQueryCriteria()
            criteria.booleanCriteria = True
            Return dao.obtenerMuchos(criteria)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
