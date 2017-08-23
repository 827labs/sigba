Imports System.Data.Odbc
Public Class Login

    Dim CompletarLogin = Desarrollo.ModoDesarrolloActivado()

    Private Sub MostrarPrincipal()
        Dim principal = New Principal()
        principal.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If Usuarios.ValidarUsuario(txtCedula.Text, txtClave.Text) Then
            Autenticacion.usuario = Val(txtCedula.Text)
            MostrarPrincipal()
            Auditoria.RegistrarAccion(Funcionalidad.IngresoAlSistema)
        Else
            Auditoria.RegistrarAccion(Funcionalidad.ErrorDeAcceso, String.Format("cedula={0}", txtCedula.Text))
            MessageBox.Show("Credenciales incorrectas", "Error de acceso")
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

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Me.CompletarLogin) Then
            txtCedula.Text = "12345678"
            txtClave.Text = "12345678"
        End If
    End Sub
End Class
