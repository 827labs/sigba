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
End Class