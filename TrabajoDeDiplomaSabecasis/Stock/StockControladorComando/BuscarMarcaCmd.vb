Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales

Public Class BuscarMarcaCmd
    Inherits Comando(Of Marca, BuscarMarcaAccion)


    Public Overrides Function execute(accion As BuscarMarcaAccion) As Marca
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Marca) = DaoFactory(Of Marca).obtenerInstancia.crear(GetType(Marca))
            Dim queryCriteria As New GenericQueryCriteria
            queryCriteria.integerCriteria = accion.id
            queryCriteria.stringCriteria = accion.marca
            Dim oMarca As Marca = dao.obtenerUno(queryCriteria)
            Return oMarca
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try

    End Function
End Class
