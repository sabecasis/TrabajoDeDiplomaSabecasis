Imports StockModelo

Public Class CalcularCostoEstandarAccion
    Implements Accion


    Public Sub New(formula As String)
        Me.formulaDeComposicion = formula
    End Sub

    Property formulaDeComposicion As String


End Class
