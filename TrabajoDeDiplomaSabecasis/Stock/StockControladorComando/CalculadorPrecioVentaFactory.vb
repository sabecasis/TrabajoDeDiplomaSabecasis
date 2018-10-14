Imports ElementosTransversales

Public Class CalculadorPrecioVentaFactory

    Private Shared instancia As New CalculadorPrecioVentaFactory

    Private Sub New()

    End Sub

    Public Shared Function obtenerInstancia() As CalculadorPrecioVentaFactory
        Return instancia
    End Function

    Public Function crear(metodoValoracion) As CalculadorPrecioVenta
        If metodoValoracion Is Nothing Then
            Return New CalculadorPrecioVentaGenerico()
        ElseIf ConstantesDeMetodoDeValoracion.PPP.Equals(metodoValoracion.id) Then
            Return New CalculadorPrecioVentaPPP
        ElseIf ConstantesDeMetodoDeValoracion.PEPS.Equals(metodoValoracion.id) Then
            Return New CalculadorPrecioVentaGenerico
        ElseIf ConstantesDeMetodoDeValoracion.UEPS.Equals(metodoValoracion.id) Then
            Return New CalculadorPrecioVentaGenerico
        ElseIf ConstantesDeMetodoDeValoracion.RETAIL.Equals(metodoValoracion.id) Then
            Return New CalculadorPrecioVentaGenerico
        ElseIf ConstantesDeMetodoDeValoracion.CE.Equals(metodoValoracion.id) Then
            Return New CalculadorPrecioVentaGenerico
        End If
        Return Nothing
    End Function
End Class
