Imports StockModelo
Imports StockControladorAccion
Imports ElementosTransversales
Imports StockDatos

Public Class BuscarSucursalCmd
    Inherits Comando(Of Sucursal, BuscarSucursalAccion)


    Public Overrides Function execute(accion As BuscarSucursalAccion) As Sucursal
        Try
            Autorizador.obtenerInstancia.autorizar(ConstantesDePermisos.BUSCAR)
            Dim dao As AbstractDao(Of Sucursal) = DaoFactory(Of Sucursal).obtenerInstancia.crear(GetType(Sucursal))
            If accion Is Nothing Then
                Throw New Exception(Sesion.obtenerInstancia.correlacionElementoIdioma.Item(ConstantesDeMensaje.ACCION_NULA))
            End If
            Dim queryCriteria As New GenericQueryCriteria()
            queryCriteria.integerCriteria = accion.id
            Dim oSucursal As Sucursal = dao.obtenerUno(queryCriteria)
            Return oSucursal
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, Me.GetType.ToString, accion)
        End Try
    End Function
End Class
