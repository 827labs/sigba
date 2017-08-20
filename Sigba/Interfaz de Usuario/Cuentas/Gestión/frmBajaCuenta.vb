Public Class frmBajaCuenta

    Private Sub cboRazonPredefinida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRazonPredefinida.SelectedIndexChanged
        ' Se habilita el TextBox solamente si se necesita especificar la razón de baja (Otra)
        txtRazon.Enabled = (cboRazonPredefinida.SelectedIndex = cboRazonPredefinida.Items.Count - 1)
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If cboRazonPredefinida.Text <> "" Then
            Dim decision = MessageBox.Show("La cuenta se archivará y podrá ser reabierta en cualquier momento si el cliente lo desea.", "Confirmar cierre", MessageBoxButtons.YesNo)
            If decision = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Cuenta archivada exitosamente.")
                Me.Close()
            End If
        Else
            MessageBox.Show("Seleccione y/o especifique una razón para archivar la cuenta.")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class