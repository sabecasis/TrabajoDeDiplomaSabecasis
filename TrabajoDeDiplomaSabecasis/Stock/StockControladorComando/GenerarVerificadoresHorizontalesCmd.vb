Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports System.Reflection
Imports ElementosTransversales

Public Class GenerarVerificadoresHorizontalesCmd
    Inherits Comando(Of Boolean, GenerarVerificadoresHorizontalesAccion)

    Public Overrides Function execute(accion As GenerarVerificadoresHorizontalesAccion) As Boolean
        Try
            Dim dao As RelacionEntidadDAODao = RelacionEntidadDAODao.obtenerInstancia()
            Dim listaDaos As List(Of RelacionEntidadDAO) = dao.obtenerMuchos(Nothing)
            Dim tipo As Type
            Dim newDao As Object
            Dim method As MethodInfo
            For Each element As RelacionEntidadDAO In listaDaos
                newDao = Util.fetchInstance(element.dao)
                tipo = newDao.GetType()
                method = tipo.GetMethod("calcularVerificadorHoriontal")
                method.Invoke(newDao, Nothing)
            Next
        Catch e As Exception
            Throw New ExcepcionDeComando(e, Me.GetType.FullName, accion)
        End Try

        Return Nothing
    End Function

End Class
