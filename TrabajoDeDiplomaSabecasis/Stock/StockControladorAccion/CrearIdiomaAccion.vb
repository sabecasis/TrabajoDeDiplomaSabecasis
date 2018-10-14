Imports StockModelo

Public Class CrearIdiomaAccion
    Implements Accion
    Public Sub New(elementosDeIdiomaLista As List(Of RelacionElementoIdioma))
        Me.elementosDeIdioma = elementosDeIdiomaLista
    End Sub

    Private _elementosDeIdioma As List(Of RelacionElementoIdioma)
    Public Property elementosDeIdioma() As List(Of RelacionElementoIdioma)
        Get
            Return _elementosDeIdioma
        End Get
        Set(ByVal value As List(Of RelacionElementoIdioma))
            _elementosDeIdioma = value
        End Set
    End Property


End Class
