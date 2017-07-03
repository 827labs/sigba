Imports System.Text.RegularExpressions

Module Validadores
    Public Function EsRUTValido(ByVal rut As String) As Boolean
        ' Un RUT debe tener 12 digitos y ser numerico
        Return (rut.Length = 12 And IsNumeric(rut))
    End Function

    Public Function EsCedulaValida(ByVal cedula As String) As Boolean
        ' Se le quitan los puntos y guiones para
        ' validar la longitud real del número
        cedula = cedula.Replace(".", "")
        cedula = cedula.Replace("-", "")

        ' Un número de cédula debe contener 8 digitos
        Return (cedula.Length = 8 And IsNumeric(cedula))
    End Function

    Function EsEmailValido(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        Dim regex As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$") 'Los valores en rojo representan la cadena de caracteres necesarios para especificar un correo electrónico
        'regex representa una expresión regular
        Dim m As Match = regex.Match(email)
        'Match indica si la expresión regular especificada en Regex encuentra una coincidencia en una cadena de entrada especificada
        Return (m.Captures.Count <> 0)
    End Function


    Function EsWebValida(ByVal Web As String) As Boolean
        Dim regex As Regex = New Regex("^(https?|ftp|file)://[-A-Z0-9+&@#/%?=~_|!:,.;]*[-A-Z0-9+&@#/%=~_|]", RegexOptions.IgnoreCase)
        'regex representa una expresión regular
        Dim m As Match = regex.Match(Web)
        'Match indica si la expresión regular especificada en Regex encuentra una coincidencia en una cadena de entrada especificada
        Return (m.Captures.Count <> 0)
    End Function

    Sub KeyPressSoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            'IsLetter: Indica si un carácter es una letra
            'e.KeyChar: Caracter que se pulsó en el teclado
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub KeyPressSoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            'IsDigit: Indica si un carácter es numérico
            'e.KeyChar: Caracter que se pulsó en el teclado

            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub KeyPressLongitudMaxima(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByVal contenidoActual As String, ByVal maximoCaracteres As Integer)
        If (contenidoActual.Length >= maximoCaracteres) And (Char.IsControl(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub

    Sub KeyPressDocumento(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByRef cboTipo As ComboBox, ByRef txtNro As TextBox)
        ' Si el tipo de documento es Cedula (Item 0), limitamos a solo numeros
        ' y su longitud maxima puede ser de 8 caracteres
        If (cboTipo.SelectedIndex = 0) Then
            KeyPressSoloNumeros(e)
            KeyPressLongitudMaxima(e, txtNro.Text, 8)
        Else
            ' Si el tipo de documento no es Cedula (Items 1 o 2), no se limita a numeros
            ' y la longitud maxima se limita a 100 catacteres.
            KeyPressLongitudMaxima(e, txtNro.Text, 100)
        End If
    End Sub

    Sub KeyPressCodigoPostal(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByVal contenidoActual As String)
        KeyPressSoloNumeros(e)
        KeyPressLongitudMaxima(e, contenidoActual, 6)
    End Sub

    Sub KeyPressRUT(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByVal contenidoActual As String)
        KeyPressSoloNumeros(e)
        KeyPressLongitudMaxima(e, contenidoActual, 12)
    End Sub
End Module
