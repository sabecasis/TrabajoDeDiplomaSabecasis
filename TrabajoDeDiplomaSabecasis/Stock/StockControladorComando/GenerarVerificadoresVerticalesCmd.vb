Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales
Imports System.Reflection

Public Class GenerarVerificadoresVerticalesCmd
    Inherits Comando(Of Boolean, GenerarVerificadoresVerticalesAccion)


    Public Overrides Function execute(accion As GenerarVerificadoresVerticalesAccion) As Boolean
        Try
            Dim dao As RelacionEntidadDAODao = RelacionEntidadDAODao.obtenerInstancia()
            Dim listaDaos As List(Of RelacionEntidadDAO) = dao.obtenerMuchos(Nothing)
            Dim tipo As Type
            Dim newDao As Object
            Dim method As MethodInfo
            For Each element As RelacionEntidadDAO In listaDaos
                newDao = Util.fetchInstance(element.dao)
                tipo = newDao.GetType()
                method = tipo.GetMethod("calcularVerificadorVertical")
                method.Invoke(newDao, Nothing)
            Next
        Catch e As Exception
            Throw New ExcepcionDeComando(e, Me.GetType.FullName, accion)
        End Try

        Return Nothing
    End Function
End Class
