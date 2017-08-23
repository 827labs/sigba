Public Class frmRecuperacionClaveEmisor

    Dim codigo As Integer
    Dim usuario As Usuario

    Private Sub MostrarCodigoRecuperacion()
        lblPreCodigo.Visible = True
        lblCodigo.Visible = True
        lblCodigo.Text = Me.codigo
        lblPreCodigo.Text = String.Format("El código de recuperación para {0}, {1} es:", usuario.Apellido, usuario.Nombre)
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
            Me.usuario = New Usuario(Val(txtCedulaUsuario.Text))
            Me.codigo = Val(Generadores.CodigoRecuperacionAleatorio())
            txtCedulaUsuario.Clear()

            If usuario.EsValido() And usuario.ActualizarCodRecuperacion(Me.codigo) Then
                Auditoria.RegistrarAccion(Funcionalidad.GeneracionCodRecuperacion, String.Format("codigo={0};cedula={1}", Me.codigo, Me.usuario.NumDocU))
                MostrarCodigoRecuperacion()
            End If
        End If

    End Sub

    Private Sub txtCedulaUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaUsuario.KeyPress
        txtCedulaUsuario.MaxLength = 8
        Validadores.KeyPressSoloNumeros(e)
    End Sub

End Class