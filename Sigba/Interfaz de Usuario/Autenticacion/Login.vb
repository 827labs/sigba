Imports System.Data.Odbc
Imports System.Globalization

Public Class Login

    Dim CompletarLogin = Desarrollo.ModoDesarrolloActivado()

    Private Sub MostrarPrincipal()
        Dim principal = New Principal()
        principal.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If txtUsuario.Text = "" Or txtClave.Text = "" Then
            Mensajes.ErrorSimple("Complete todos los campos")
        End If
        If Usuarios.ValidarUsuario(txtUsuario.Text, txtClave.Text) Then
            MostrarPrincipal()
            Auditoria.RegistrarAccion(Funcionalidad.IngresoAlSistema)
        Else
            Auditoria.RegistrarAccion(Funcionalidad.ErrorDeAcceso, String.Format("cedula={0}", txtUsuario.Text))
            MessageBox.Show("No se pudo validar el usuario", "Error de acceso")
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        ' KeyPress es el evento que se maneja cuando el usuario presiona un tecla que produce un caracter
        ' que se puede escribir
        txtUsuario.MaxLength = 8          'el textbox tendrá 8 caracteres como máximo
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCajero.Click
        frmATMBienvenido.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Me.CompletarLogin) Then
            txtUsuario.Text = "informix"
            txtClave.Text = "informix"
        End If
        cboIdioma.SelectedIndex = 0
    End Sub

    Private Sub cboIdioma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIdioma.SelectedIndexChanged
        Select Case cboIdioma.SelectedIndex
            Case 0
                Autenticacion.idioma = "es"
            Case 1
                Autenticacion.idioma = "en"
        End Select

        System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo(Autenticacion.idioma)
    End Sub
End Class
