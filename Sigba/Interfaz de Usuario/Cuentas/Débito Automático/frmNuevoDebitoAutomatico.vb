Public Class frmNuevoDebitoAutomatico

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Dim decision = MessageBox.Show("¿Está seguro que desea dar de alta este débito automático? La empresa será notificada dentro de las 48 horas hábiles.", "Confirmar", MessageBoxButtons.YesNo)
        If (decision = Windows.Forms.DialogResult.Yes) Then
            MessageBox.Show("La suscripción se ha creado correactamente.")
            Me.Close()
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCantidad.KeyPress, txtDiaCobro.KeyPress, txtTelContactoEmpresa.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class