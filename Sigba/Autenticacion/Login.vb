Public Class Login
    ' Datos temporales mientras no contamos
    ' con una conexion a la base de datos
    Dim cedulaPrueba = "1.234.567-8"
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
End Class
