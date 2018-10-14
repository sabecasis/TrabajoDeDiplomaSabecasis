Imports ElementosTransversales
Imports StockDatos
Imports StockModelo
Imports StockControladorAccion
Imports StockControladorComando

'Es la fabrica de comandos
Public Class CommandFactory(Of T, I As Accion)
    Inherits Factory(Of T)

    Private Shared oDaoFactory As CommandFactory(Of T, I) = New CommandFactory(Of T, I)

    Public Shared Function obtenerInstancia() As CommandFactory(Of T, I)
        Return oDaoFactory
    End Function
    Private Sub New()

    End Sub

    Public Overrides Function crear(oEntidad As Type) As Object
        Return Nothing
    End Function

    Public Overloads Function crear(oAccion As Type, oResutado As Type) As Object
        If oAccion = GetType(HacerBackupAccion) Then
            'Está cableado porque necesitamos que esta sea una acción que se ejecute sin importar el estado de la base de datos.
            Return New CrearBackupCmd()
        End If
        If oAccion = GetType(RestaurarBackupAccion) Then
            Return New RestaurarBackupCmd()
        End If
        Dim nombreCmd As String = Cache.obtenerComandoPorAccionYResultado(oAccion.FullName, oResutado.FullName)
        If Not nombreCmd Is Nothing Then
            Dim cmd As Comando(Of T, I) = Util.fetchInstance(nombreCmd)
            Return cmd
        Else
            Dim criteria As ComandoQueryCriteria = New ComandoQueryCriteria()
            criteria.Accion = oAccion.FullName
            criteria.Resultado = oResutado.FullName
            Dim dao As RelacionComandoAccionResultadoDao = New RelacionComandoAccionResultadoDao()
            Dim relacion = dao.obtenerUno(criteria)
            If Not relacion Is Nothing Then
                Cache.setComandoPorAccinYResultado(relacion.comando, relacion.resultado, relacion.accion)
                Dim cmd As Object = Util.fetchInstance(relacion.comando)
                Return cmd
            End If
        End If

        Return Nothing
    End Function
End Class
