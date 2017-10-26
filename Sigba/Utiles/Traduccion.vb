Module Traduccion
    Public Function T(ByVal espanol As String, ByVal ingles As String) As String
        Select Case Autenticacion.idioma
            Case "es"
                Return espanol
            Case "en"
                Return ingles
            Case Else
                Return espanol
        End Select
    End Function
End Module
