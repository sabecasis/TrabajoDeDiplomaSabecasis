Imports System.IO
Imports System.Runtime.Serialization.Json

Public Class JsonSerializer(Of T)

    Public Shared Function serializarAJson(objeto As T) As String
        Dim stream1 As New MemoryStream()
        Dim ser As New DataContractJsonSerializer(objeto.GetType)
        ser.WriteObject(stream1, objeto)
        stream1.Position = 0
        Dim sr As New StreamReader(stream1)
        Return sr.ReadToEnd()
    End Function

End Class
