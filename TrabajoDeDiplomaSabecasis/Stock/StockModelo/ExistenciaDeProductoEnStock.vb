Public Class ExistenciaDeProductoEnStock
    Property idProducto As Integer
    Property producto As String
    Property cantidad As Integer
    Property minStock As Integer
    Property maxStock As Integer
    Property modoReposicion As MetodoDeReposicion
    Property ciclo As Integer
    Property pedidoAutomatico As Boolean
    Property deposito As Deposito
End Class
