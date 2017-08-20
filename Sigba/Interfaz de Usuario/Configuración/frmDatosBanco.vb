Public Class frmDatosBanco

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If (txtNombreFantasia.Text <> "" And txtRazonSocial.Text <> "" And txtRUT.Text <> "" And txtCasaCentral.Text <> "" And txtTelefono.Text <> "" And txtSitioWeb.Text <> "" And txtLimRetDiarioDependenciasUSD.Text <> "" And txtLimRetDiarioDependenciasUYU.Text <> "" And txtLimRetDiarioIslaUSD.Text <> "" And txtLimRetDiarioIslaUYU.Text <> "" And txtMinimoDepCajaUSD.Text <> "" And txtMinimoDepCajaUYU.Text <> "" And txtMaximoDepCajaUSD.Text <> "" And txtMaximoDepCajaUYU.Text <> "") Then
            Dim decision = MessageBox.Show("¿Desea confirmar esta información?", "Confirmar", MessageBoxButtons.YesNo)
            If decision = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("La información se ha actualizado exitosamente.")
                Me.Close()
            End If
        Else
            MessageBox.Show("Complete todos los campos para continuar")
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress, txtMinimoDepCajaUYU.KeyPress, txtMinimoDepCajaUSD.KeyPress, txtMaximoDepCajaUYU.KeyPress, txtMaximoDepCajaUSD.KeyPress, txtLimRetDiarioIslaUYU.KeyPress, txtLimRetDiarioIslaUSD.KeyPress, txtLimRetDiarioDependenciasUYU.KeyPress, txtLimRetDiarioDependenciasUSD.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class