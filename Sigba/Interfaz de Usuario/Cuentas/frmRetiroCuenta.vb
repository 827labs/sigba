Public Class frmRetiroCuenta
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtMontoCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCantidad.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnBuscarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCuenta.Click
        Dim form = New frmBusquedaCuentaPorCliente()
        form.SetearNotificable(AddressOf SetearNumeroCuenta)
        form.Show()
    End Sub

    Private Sub SetearNumeroCuenta(ByVal cuenta As String)
        txtCuentaBeneficiario.Text = cuenta
    End Sub
End Class