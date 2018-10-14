Imports StockModelo
Imports StockControladorAccion
Imports StockDatos

Public Class ObtenerTodosLosIdiomasCmd
    Inherits Comando(Of List(Of Idioma), ObtenerTodosAccion)

    Public Overrides Function execute(accion As ObtenerTodosAccion) As List(Of Idioma)
        Dim dao As AbstractDao(Of Idioma) = DaoFactory(Of Idioma).obtenerInstancia().crear(GetType(Idioma))
        Dim listaDeIdiomas As List(Of Idioma) = New List(Of Idioma)
        Dim containsAR As Boolean = False
        listaDeIdiomas = dao.obtenerMuchos(Nothing)
        If listaDeIdiomas Is Nothing Then
            listaDeIdiomas = New List(Of Idioma)
        End If

        If listaDeIdiomas.Count > 0 Then
            For Each oIdioma As Idioma In listaDeIdiomas
                If oIdioma.cultura.Equals(System.Globalization.CultureInfo.CreateSpecificCulture("es-AR")) Then
                    containsAR = True
                    Exit For
                End If
            Next
        End If

        If Not containsAR Then
            Dim oIdioma As Idioma = New Idioma()
            oIdioma.id = 0
            oIdioma.descripcion = "Español Argentina (Por defecto)"
            oIdioma.cultura = System.Globalization.CultureInfo.CreateSpecificCulture("es-AR")
            listaDeIdiomas.Add(oIdioma)
        End If

        Return listaDeIdiomas
    End Function
End Class
