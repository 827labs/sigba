Public Class Login

    ' Datos temporales mientras no contamos
    ' con una conexion a la base de datos
    Dim cedulaPrueba = "12345678"
    Dim clavePrueba = "12345678"
    Dim completarLogin = True

    Private Sub MostrarPrincipal()
        Dim principal = New Principal()
        principal.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If txtCedula.Text = cedulaPrueba And txtClave.Text = clavePrueba Then
            MostrarPrincipal()
        Else
            MessageBox.Show("Credenciales incorrectas", "Error de acceso")
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If completarLogin = True Then
            txtCedula.Text = cedulaPrueba
            txtClave.Text = clavePrueba
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        ' KeyPress es el evento que se maneja cuando el usuario presiona un tecla que produce un caracter
        ' que se puede escribir
        txtCedula.MaxLength = 8          'el textbox tendrá 8 caracteres como máximo
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub lnklblOlvidoContrasena_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblOlvidoContrasena.LinkClicked
        frmOlvidoClave.Show()
    End Sub

    Private Sub btnCajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajero.Click
        frmATMBienvenido.Show()
        Me.Hide()
    End Sub
End Class
