Public Class RelacionElementoIdioma

    Public Sub New()

    End Sub

    Public Sub New(elemento As ElementoDeIdioma, idioma As Idioma, texto As String)
        Me.elemento = elemento
        Me.idioma = idioma
        Me.texto = texto
    End Sub

    Property elemento As ElementoDeIdioma
    Property idioma As Idioma
    Property texto As String
End Class
