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

    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        If cboTipoDoc.SelectedIndex = 0 Then
            txtNroDoc.MaxLength = 8
            Validadores.KeyPressSoloNumeros(e)
        Else
            txtNroDoc.MaxLength = 100
        End If
    End Sub

    Private Sub frmBajaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDoc.SelectedIndex = 187
        cboTipoDoc.SelectedIndex = 0
    End Sub
End Class