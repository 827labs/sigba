Public Class frmOlvidoClave

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If txtCodigoAcceso.Text <> "" And txtNuevaClave.Text <> "" Then
            If MessageBox.Show("¿Está seguro que desea cambiar su clave de acceso?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Su clave de acceso ha sido reestablecida exitosamente")
                Me.Close()
            End If
        Else
            MessageBox.Show("Ingrese ambos campos para continuar")
        End If
    End Sub

    Private Sub txtCodigoAcceso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoAcceso.KeyPress
        txtCodigoAcceso.MaxLength = 6
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class