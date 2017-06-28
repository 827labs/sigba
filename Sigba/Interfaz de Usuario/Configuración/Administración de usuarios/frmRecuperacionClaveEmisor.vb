Public Class frmRecuperacionClaveEmisor
    Private Sub MostrarCodigoRecuperacion()
        lblPreCodigo.Visible = True
        lblCodigo.Visible = True
        lblCodigo.Text = Generadores.CodigoRecuperacionAleatorio()
    End Sub

    Private Function FormularioEsValido() As Boolean
        Dim valido = (txtCedulaUsuario.Text <> "")

        If valido = False Then
            MsgBox("Por favor, ingrese una cedula.")
            lblCodigo.Visible = False
            lblPreCodigo.Visible = False
        End If

        Return valido
    End Function

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If (FormularioEsValido()) Then
            MostrarCodigoRecuperacion()
        End If

    End Sub

    Private Sub txtCedulaUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaUsuario.KeyPress
        txtCedulaUsuario.MaxLength = 8
        'está seleccionado, el textbox tendrá 8 caracteres como máximo

        If Char.IsDigit(e.KeyChar) Then

            'Char: Digito
            'IsDigit: Indica si un carácter es numérico
            'e.KeyChar: Caracter que se pulsó en el teclado

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        Else

            e.Handled = True 'Le dice al evento que se tomó la acción adecuada
        End If

    End Sub

End Class