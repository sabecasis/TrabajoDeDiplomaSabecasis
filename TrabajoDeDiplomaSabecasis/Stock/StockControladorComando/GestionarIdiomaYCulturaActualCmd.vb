Imports StockModelo
Imports StockControladorAccion
Imports StockDatos
Imports ElementosTransversales
Imports System.Threading

Public Class GestionarIdiomaYCulturaActualCmd
    Inherits Comando(Of Object, GestionarIdiomaYCulturaActualAccion)


    Public Overrides Function execute(accion As GestionarIdiomaYCulturaActualAccion) As Object
        Dim queryCriteria As GenericQueryCriteria = New GenericQueryCriteria()
        Dim relElementoIdioma As RelacionElementoIdioma = New RelacionElementoIdioma()
        Dim relElementoIdiomaList As List(Of RelacionElementoIdioma)
        If accion.idIdioma = 0 Then
            Sesion.obtenerInstancia().cargarIdiomaYCulturaPorDefecto()
        Else
            Dim dao As AbstractDao(Of RelacionElementoIdioma) = DaoFactory(Of RelacionElementoIdioma).obtenerInstancia().crear(GetType(RelacionElementoIdioma))

            relElementoIdioma.idioma = New Idioma()
            relElementoIdioma.idioma.id = accion.idIdioma
            queryCriteria.oObject = relElementoIdioma
            relElementoIdiomaList = dao.obtenerMuchos(queryCriteria)
            If Not relElementoIdiomaList Is Nothing And relElementoIdiomaList.Count > 0 Then
                cargarIdiomaYCulturaDados(relElementoIdiomaList)
            End If

        End If
        Return Nothing
    End Function

    Private Sub cargarIdiomaYCulturaDados(relElementoIdiomaList As List(Of RelacionElementoIdioma))
        Thread.CurrentThread.CurrentCulture = relElementoIdiomaList.Item(0).idioma.cultura
        Thread.CurrentThread.CurrentUICulture = relElementoIdiomaList.Item(0).idioma.cultura

        Dim correlacionElementoIdioma As Hashtable = Sesion.obtenerInstancia().correlacionElementoIdioma

        correlacionElementoIdioma.Clear()
        For Each oRelElem As RelacionElementoIdioma In relElementoIdiomaList
            If Not correlacionElementoIdioma.ContainsKey(oRelElem.elemento.nombre) Then
                correlacionElementoIdioma.Add(oRelElem.elemento.nombre, oRelElem.texto)
            End If
        Next


    End Sub
End Class
