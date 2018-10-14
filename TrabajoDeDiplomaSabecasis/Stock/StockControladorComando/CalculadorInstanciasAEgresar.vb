Imports StockModelo

Public Class CalculadorInstanciasAEgresar

    Public Shared Function calcular(listaInstancias As List(Of InstanciaDeProducto), metodoValoracion As ModoValoracionProducto, cantidad As Integer) As List(Of InstanciaDeProducto)
        Dim listaresultado As New List(Of InstanciaDeProducto)
        If Not listaInstancias Is Nothing Then
            If listaInstancias.Count > 0 Then
                If metodoValoracion.id = 1 Then
                    ' si es PPP da igual de dónde se tomen las instancias
                    If listaInstancias.Count >= cantidad Then
                        listaresultado.AddRange(listaInstancias.GetRange(0, cantidad))
                    End If
                ElseIf metodoValoracion.id = 2 Then
                    'si es PEPS o FIFO hay que sacar las primeras en ingresar 
                    '(se asume que la lista enviada está ordernada de perimero a último ingresado)
                    If listaInstancias.Count >= cantidad Then
                        listaresultado.AddRange(listaInstancias.GetRange(0, cantidad)) 'salen los primeros ingresados
                    End If
                ElseIf metodoValoracion.id = 3 Then 'si es ueps o LIFO
                    If listaInstancias.Count >= cantidad Then
                        Dim puntoDeArranque As Integer = listaInstancias.Count - 1 - cantidad
                        listaresultado.AddRange(listaInstancias.GetRange(puntoDeArranque, cantidad))
                    End If
                ElseIf metodoValoracion.id = 4 Then 'si es RETAIL
                    listaresultado.AddRange(listaInstancias.GetRange(0, cantidad)) 'Da igual
                Else 'Si es Método de costo específico
                    listaresultado.AddRange(listaInstancias.GetRange(0, cantidad)) 'Da igual
                End If
            End If
        End If
        Return listaresultado
    End Function


End Class
