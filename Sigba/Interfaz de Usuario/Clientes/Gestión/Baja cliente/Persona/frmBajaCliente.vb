Public Class frmBajaCliente
    Private Function ValidarFormulario() As Boolean
        Dim condicion = cboPaisDoc.SelectedIndex <> 0 And cboTipoDoc.SelectedIndex <> 0 And txtNroDoc.Text <> "" And txtRazonBaja.Text <> ""

        If condicion = False Then
            MessageBox.Show("Por favor, complete todos los campos del formulario.")
        End If

        Return condicion
    End Function

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If ValidarFormulario() Then
            ' Para hacer: dar de baja el usuario.
        End If
    End Sub
End Class