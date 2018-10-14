Imports StockModelo
Imports StockControladorComando
Imports StockControladorAccion
Imports ElementosTransversales

'Esta clase se encarga de llevar a cabo la búsqueda y ejecución de un comando, en base a la acción solicitada y el resultado esperado
Public Class Dispatcher(Of T, I As Accion)

    'El método del dispatcher que lleva a cabo la búsqueda y ejecución del comando de acuerdo a su acción y resultado
    Public Shared Function execute(oAccion As I) As T
            'obtengo el comando
            Dim cmd As Comando(Of T, I) = CommandFactory(Of T, I).obtenerInstancia().crear(GetType(I), GetType(T))
            Dim resultado As T
            'obtengo el resultado ejecutando el comando
            resultado = cmd.execute(oAccion)
            Dim guardarEnBitacora As New GuardarEnBitacoraCmd()
        guardarEnBitacora.execute(New GuardarEnBitacoraAccion(GetType(I).FullName, GetType(T).FullName))
        Return resultado
    End Function

End Class
