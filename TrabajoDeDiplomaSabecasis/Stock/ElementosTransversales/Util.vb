Imports System.Reflection
Public Class Util

    Public Shared Function fetchInstance(ByVal fullyQualifiedClassName As String) As Object
        Dim nspace As String = fullyQualifiedClassName.Substring(0, fullyQualifiedClassName.LastIndexOf("."))
        Dim name As String = fullyQualifiedClassName.Substring(fullyQualifiedClassName.LastIndexOf(".") + 1).Trim()
        Dim o As Object = Nothing
        Try
            o = Assembly.Load(nspace).CreateInstance(fullyQualifiedClassName.Trim)
        Catch ex As Exception
            Throw New ExcepcionDeComando(ex, "Util", Nothing)
        End Try
        Return o
    End Function


End Class
