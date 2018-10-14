Imports Microsoft.Office.Interop.Word
Imports StockModelo
Imports ElementosTransversales
Imports System.Reflection
Imports System.IO

Public Class GeneradorDeComprobantes
    Public Shared oGlobalWord As Application

    Public Shared Function generarComprobanteDeMovimientoDeStock(id As Integer, fecha As Date, listaInstancias As List(Of InstanciaDeProducto), depositoOrigen As String, depositoDestino As String, motivo As String) As Byte()
        Dim oWord As Application = CreateObject("Word.Application")
        oGlobalWord = oWord
        Dim oDoc As Document
        Try
            Dim instancias As String = ""
            Dim path As String = (New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
            path = path.Substring(0, path.LastIndexOf("/"))
            path = path & "/ComprobanteMovimientoStock.docx"
            oDoc = oWord.Documents.Open(path)
            oDoc.Bookmarks.Item("productos").Range.InsertParagraphAfter()

            If Not listaInstancias Is Nothing Then
                For Each oInstancia As InstanciaDeProducto In listaInstancias
                    instancias = " Nro. Articulo: " & oInstancia.id.ToString & " Nro. Producto: " & oInstancia.producto.id.ToString & " Producto: " & oInstancia.producto.nombre
                    oDoc.Bookmarks.Item("productos").Range.Text = instancias
                    oDoc.Bookmarks.Item("productos").Range.InsertParagraphAfter()
                Next
            End If
            oDoc.Bookmarks.Item("identificador").Range.Text = id.ToString()
            oDoc.Bookmarks.Item("motivo").Range.Text = motivo
            oDoc.Bookmarks.Item("fecha").Range.Text = fecha.ToString()
            oDoc.Bookmarks.Item("deposito").Range.Text = depositoOrigen
            oDoc.Bookmarks.Item("depositodest").Range.Text = depositoDestino
            Try
                oDoc.Bookmarks.Item("usuario").Range.Text = Sesion.obtenerInstancia().usuarioActual.nombre

            Catch ex As Exception
                oDoc.Bookmarks.Item("usuario").Range.Text = "SuperAdmin"
            End Try

            Dim converted As Byte() = ObjectToByteArray(oDoc, oWord, "/ComprobanteMovimientoStock.docx")
            oWord.Visible = True
            Return converted
        Catch exe As Exception
            oWord.Documents.Close()
            Throw exe
        End Try

    End Function


    Public Shared Function generarComprobanteDePedidoAStock(id As Integer, fecha As Date, deposito As String, cantidad As Integer, producto As String, idProducto As Integer) As Byte()
        Dim oWord As Application = CreateObject("Word.Application")
        oGlobalWord = oWord
        Dim oDoc As Document
        Try
            Dim instancias As String = ""
            Dim path As String = (New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
            path = path.Substring(0, path.LastIndexOf("/"))
            path = path & "/ComprobantePedidoStock.docx"
            oDoc = oWord.Documents.Open(path)

            oDoc.Bookmarks.Item("identificador").Range.Text = id.ToString()
            oDoc.Bookmarks.Item("producto").Range.Text = producto
            oDoc.Bookmarks.Item("cantidad").Range.Text = cantidad.ToString
            oDoc.Bookmarks.Item("fecha").Range.Text = fecha.ToString()
            oDoc.Bookmarks.Item("deposito").Range.Text = deposito
            oDoc.Bookmarks.Item("idproducto").Range.Text = idProducto.ToString
            Try
                oDoc.Bookmarks.Item("usuario").Range.Text = Sesion.obtenerInstancia().usuarioActual.nombre
                oDoc.Bookmarks.Item("empleado").Range.Text = Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).persona.nombre & " " & Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).persona.apellido
            Catch ex As Exception
                oDoc.Bookmarks.Item("usuario").Range.Text = "SuperAdmin"
                oDoc.Bookmarks.Item("empleado").Range.Text = "SuperAdmin"
            End Try

            Dim converted As Byte() = ObjectToByteArray(oDoc, oWord, "/ComprobantePedidoStock.docx")
            oWord.Visible = True
            Return converted
        Catch exe As Exception
            oWord.Documents.Close()
            Throw exe
        End Try

    End Function




    Public Shared Function generarComprobanteDeEgresoDeStock(idEgreso As Integer, fecha As Date, listaInstancias As List(Of InstanciaDeProducto), nombreDeposito As String, motivo As String) As Byte()
        Dim oWord As Application = CreateObject("Word.Application")
        oGlobalWord = oWord
        Dim oDoc As Document
        Try
            Dim instancias As String = ""
            Dim path As String = (New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
            path = path.Substring(0, path.LastIndexOf("/"))
            path = path & "/ComprobanteEgresoStock.docx"
            oDoc = oWord.Documents.Open(path)
            oDoc.Bookmarks.Item("productos").Range.InsertParagraphAfter()

            If Not listaInstancias Is Nothing Then
                For Each oInstancia As InstanciaDeProducto In listaInstancias
                    instancias = " Nro. Articulo: " & oInstancia.id.ToString & " Nro. Producto: " & oInstancia.producto.id.ToString & " Producto: " & oInstancia.producto.nombre
                    oDoc.Bookmarks.Item("productos").Range.Text = instancias
                    oDoc.Bookmarks.Item("productos").Range.InsertParagraphAfter()
                Next
            End If

            oDoc.Bookmarks.Item("identificador").Range.Text = idEgreso.ToString()
            oDoc.Bookmarks.Item("motivo").Range.Text = motivo
            oDoc.Bookmarks.Item("fecha").Range.Text = fecha.ToString()
            oDoc.Bookmarks.Item("deposito").Range.Text = nombreDeposito
            Try
                oDoc.Bookmarks.Item("empleado").Range.Text = Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).persona.nombre & " " & Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).persona.apellido
                oDoc.Bookmarks.Item("usuario").Range.Text = Sesion.obtenerInstancia().usuarioActual.nombre

            Catch ex As Exception
                oDoc.Bookmarks.Item("empleado").Range.Text = "SuperAdmin"
                oDoc.Bookmarks.Item("usuario").Range.Text = "SuperAdmin"
            End Try

            Dim converted As Byte() = ObjectToByteArray(oDoc, oWord, "/ComprobanteEgresoStock.docx")
            oWord.Visible = True
            Return converted
        Catch exe As Exception
            oWord.Documents.Close()
            Throw exe
        End Try

    End Function

    Public Shared Function generarComprobanteDeIngresoAStock(idIngreso As Integer, fecha As Date, listaInstancias As List(Of InstanciaDeProducto), nombreDeposito As String) As Byte()

        Dim oWord As Application = CreateObject("Word.Application")
        oGlobalWord = oWord
        Dim oDoc As Document
        Try
            Dim instancias As String = ""
            Dim path As String = (New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
            path = path.Substring(0, path.LastIndexOf("/"))
            path = path & "/ComprobanteIngresoStock.docx"
            oDoc = oWord.Documents.Open(path)
            oDoc.Bookmarks.Item("productos").Range.InsertParagraphAfter()

            If Not listaInstancias Is Nothing Then
                For Each oInstancia As InstanciaDeProducto In listaInstancias
                    instancias = " Nro. Articulo: " & oInstancia.id.ToString & " Nro. Producto: " & oInstancia.producto.id.ToString & " Producto: " & oInstancia.producto.nombre
                    oDoc.Bookmarks.Item("productos").Range.Text = instancias
                    oDoc.Bookmarks.Item("productos").Range.InsertParagraphAfter()
                Next
            End If

            oDoc.Bookmarks.Item("identificador_ingreso").Range.Text = idIngreso.ToString()
            oDoc.Bookmarks.Item("fecha_emision").Range.Text = fecha.ToString()
            oDoc.Bookmarks.Item("deposito").Range.Text = nombreDeposito
            Try
                oDoc.Bookmarks.Item("empleado").Range.Text = Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).persona.nombre & " " & Sesion.obtenerInstancia().usuarioActual.empleados.Item(0).persona.apellido
                oDoc.Bookmarks.Item("usuario").Range.Text = Sesion.obtenerInstancia().usuarioActual.nombre

            Catch ex As Exception
                oDoc.Bookmarks.Item("empleado").Range.Text = "SuperAdmin"
                oDoc.Bookmarks.Item("usuario").Range.Text = "SuperAdmin"
            End Try

            Dim converted As Byte() = ObjectToByteArray(oDoc, oWord, "/ComprobanteIngresoTemp.docx")
            oWord.Visible = True
            Return converted
        Catch exe As Exception
            oWord.Documents.Close()
            Throw exe
        End Try

    End Function


    Public Shared Sub guardarArchivoEnDisco(buffer As Byte(), path As String)
        Dim tmpFileStream As FileStream = File.OpenWrite(path)
        tmpFileStream.Write(buffer, 0, buffer.Length)
        tmpFileStream.Close()
    End Sub

    Public Shared Function convertFromByteArray(buffer As Byte()) As Document
        Dim oWord As Application = CreateObject("Word.Application")
        Dim oDoc As Document = byteArrayToOject(buffer, oWord)
        oWord.Visible = True
        Return oDoc

    End Function

    Public Shared Function byteArrayToOject(ByVal _Object As Byte(), oWord As Application) As Document

        Try
            Dim missing As Object = System.Reflection.Missing.Value
            Dim path As String = (New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
            path = path.Substring(0, path.LastIndexOf("/"))
            Dim fileName As String = path & "/comprobanteIngresoAbrirTemp.docx"
            guardarArchivoEnDisco(_Object, fileName)

            Dim oDoc As Document = oWord.Documents.Open(fileName, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, True, missing, missing, missing)

            Return oDoc

        Catch ex As Exception

            ' Error

            Throw ex

        End Try
    End Function


    Public Shared Function ObjectToByteArray(oDoc As Document, oWord As Application, file As String) As Byte()

        Try

            Dim missing As Object = System.Reflection.Missing.Value
            Dim path As String = (New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
            path = path.Substring(0, path.LastIndexOf("/"))
            Dim fileName As String = path & file
            oDoc.SaveAs2(fileName, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing)
            oDoc.Close()
            Dim fileStream As New FileStream(fileName, FileMode.Open)
            Dim fileData As Byte() = New Byte(fileStream.Length) {}
            fileStream.Read(fileData, 0, fileStream.Length)
            fileStream.Close()
            Dim newDoc = oWord.Documents.Open(fileName)
            Return fileData
        Catch ex As Exception

            ' Error

            Throw ex

        End Try

        Return Nothing

    End Function


End Class
