Public Class Cache

    Private Shared entidadDaoCache As Hashtable
    Private Shared comandoAccionResultadoCache As Hashtable

    Public Shared Sub init()
        entidadDaoCache = New Hashtable()
        comandoAccionResultadoCache = New Hashtable()
    End Sub

    Public Shared Function obtenerDaoPorEntidad(oEntidad As String) As String
        Return entidadDaoCache.Item(oEntidad)
    End Function

    Public Shared Sub setDaoPorEntidad(oEntidad As String, oDao As String)
        entidadDaoCache.Add(oEntidad, oDao)
    End Sub

    Public Shared Function obtenerComandoPorAccionYResultado(oAccion As String, oResultado As String)
        Return comandoAccionResultadoCache.Item(oAccion & oResultado)
    End Function

    Public Shared Sub setComandoPorAccinYResultado(oComando As String, oResultado As String, oAccion As String)
        comandoAccionResultadoCache.Add(oAccion & oResultado, oComando)
    End Sub

End Class
