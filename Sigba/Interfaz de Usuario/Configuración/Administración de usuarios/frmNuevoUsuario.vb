Public Class frmNuevoUsuario

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If txtNombres.Text <> "" And txtApellidos.Text <> "" And txtCedula.Text <> "" And txtCorreo.Text <> "" And Validadores.EsEmailValido(txtCorreo.Text) Then
            Dim codUsuario = Usuarios.CrearUsuario(txtCedula.Text, txtCorreo.Text, txtNombres.Text, txtApellidos.Text)

            If codUsuario Then
                Mensajes.Simple(String.Format("El usuario ha sido ingresado exitosamente, podrá crear su contraseña con el codigo '{0}'.", codUsuario))
            End If
        Else
            Mensajes.ErrorSimple("Complete todos los campos correctamente")
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        Validadores.KeyPressSoloNumeros(e)
        txtCedula.MaxLength = 8
    End Sub
End Class