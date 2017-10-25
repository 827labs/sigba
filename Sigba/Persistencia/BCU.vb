Imports System
Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Xml.ReadState
Module BCUManager

    Function ObtenerCotizaciones() As Decimal
        Dim fecha = Date.Today()
        Dim URLBancoCentral As String = String.Format("http://www.bcu.gub.uy/_layouts/BCU.Cotizaciones/handler/FileHandler.ashx?op=downloadcotizacionesxml&KeyValuePairs=%7B%22KeyValuePairs%22%3A%7B%22Monedas%22%3A%5B%7B%22Val%22%3A%220%22%2C%22Text%22%3A%22DLS.%20USA%20CABLE%22%7D%5D%2C%22FechaDesde%22%3A%22%7B0%7D%22%2C%22FechaHasta%22%3A%22%7B0%7D%22%2C%22Grupo%22%3A%222%22%7D%7D", fecha.ToString("dd/MM/yyyy"))

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URLBancoCentral)
        Try
            Dim response As System.Net.HttpWebResponse = request.GetResponse()

            If response.StatusCode = System.Net.HttpStatusCode.OK Then
                ' Parse the contents from the response to a stream object
                Dim stream As System.IO.Stream = response.GetResponseStream()
                ' Create a reader for the stream object
                Dim reader As New System.IO.StreamReader(stream)
                ' Read from the stream object using the reader, put the contents in a string
                Dim contents As String = reader.ReadToEnd()
                ' Create a new, empty XML document
                Dim document As New System.Xml.XmlDocument()
                ' Load the contents into the XML document
                document.LoadXml(contents)

                Dim reader2 = New XmlNodeReader(document)
                Dim serializer = New XmlSerializer(GetType(Datoscotizaciones))
                Dim cotizaciones As Datoscotizaciones = serializer.Deserialize(reader2)

                Mensajes.Simple(cotizaciones.Cotizaciones.ToString())
            Else

            End If
        Catch ex As Exception
            frmSeteoCotizacionATMManual.Show()
            Return 0
        End Try
    End Function
End Module
