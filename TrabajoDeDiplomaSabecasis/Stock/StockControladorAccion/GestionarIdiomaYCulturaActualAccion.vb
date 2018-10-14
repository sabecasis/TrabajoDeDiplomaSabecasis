Imports StockModelo

Public Class GestionarIdiomaYCulturaActualAccion
    Implements Accion

    Public Sub New(idiomaId As Integer)
        Me.idIdioma = idiomaId
    End Sub

    Private _idIdioma As Integer
    Public Property idIdioma() As Integer
        Get
            Return _idIdioma
        End Get
        Set(ByVal value As Integer)
            _idIdioma = value
        End Set
    End Property


End Class
