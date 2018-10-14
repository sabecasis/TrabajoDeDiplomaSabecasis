Imports System.Globalization

Public Class Idioma

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, cultura As CultureInfo, descripcion As String)
        Me.id = id
        Me.cultura = cultura
        Me.descripcion = descripcion
    End Sub

    Public Sub New(cultura As CultureInfo, descripcion As String)
        Me.id = Nothing
        Me.cultura = cultura
        Me.descripcion = descripcion
    End Sub

    Property id As Integer
    Property cultura As CultureInfo
    Property descripcion As String
End Class
