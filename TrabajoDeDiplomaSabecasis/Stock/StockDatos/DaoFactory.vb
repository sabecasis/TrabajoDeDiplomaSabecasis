Imports StockDatos
Imports ElementosTransversales

Public Class DaoFactory(Of T)
    Inherits Factory(Of T)

    Private Shared oDaoFactory As DaoFactory(Of T) = New DaoFactory(Of T)

    Public Shared Function obtenerInstancia() As DaoFactory(Of T)
        Return oDaoFactory
    End Function
    Private Sub New()

    End Sub

    Public Overrides Function crear(oEntidad As Type) As Object
        Dim nombreDao As String = Cache.obtenerDaoPorEntidad(oEntidad.FullName)
        If Not nombreDao Is Nothing Then
            Dim dao As AbstractDao(Of T) = Util.fetchInstance(nombreDao)
            Return dao
        Else
            Dim criteria As GenericQueryCriteria = New GenericQueryCriteria()
            criteria.stringCriteria = oEntidad.FullName
            Dim relacion = RelacionEntidadDAODao.obtenerInstancia().obtenerUno(criteria)
            If Not relacion Is Nothing Then
                Cache.setDaoPorEntidad(relacion.entidad, relacion.dao)
                Dim dao As Object = Util.fetchInstance(relacion.dao)
                Return dao
            End If
        End If

        Return Nothing
    End Function

End Class
