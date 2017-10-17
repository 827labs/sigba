Imports System
Imports System.Xml.Serialization
Imports System.Collections.Generic

<XmlRoot(ElementName:="datoscotizaciones.dato", Namespace:="Cotiza")> _
Public Class ConsultaBCU

    <XmlElement(ElementName:="Fecha", Namespace:="Cotiza")> _
    Public Fecha As String

    <XmlElement(ElementName:="Moneda", Namespace:="Cotiza")> _
    Public Moneda As String

    <XmlElement(ElementName:="Nombre", Namespace:="Cotiza")> _
    Public Nombre As String

    <XmlElement(ElementName:="CodigoISO", Namespace:="Cotiza")> _
    Public CodigoISO As String

    <XmlElement(ElementName:="Emisor", Namespace:="Cotiza")> _
    Public Emisor As String

    <XmlElement(ElementName:="TCC", Namespace:="Cotiza")> _
    Public TCC As String

    <XmlElement(ElementName:="TCV", Namespace:="Cotiza")> _
    Public TCV As String

    <XmlElement(ElementName:="ArbAct", Namespace:="Cotiza")> _
    Public ArbAct As String

    <XmlElement(ElementName:="FormaArbitrar", Namespace:="Cotiza")> _
    Public FormaArbitrar As String

    <XmlAttribute(AttributeName:="xmlns")> _
    Public Xmlns As String
End Class

<XmlRoot(ElementName:="datoscotizaciones", Namespace:="Cotiza")> _
Public Class Datoscotizaciones

    <XmlElement(ElementName:="datoscotizaciones.dato", Namespace:="Cotiza")> _
    Public Cotizaciones As List(Of ConsultaBCU)

    <XmlAttribute(AttributeName:="xmlns")> _
    Public Xmlns As String
End Class
