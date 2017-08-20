Public Class frmATMTransferencia

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If cboCuentaDestinoMoneda.Text <> "" And cboCuentaDestinoTipo.Text <> "" And txtCuentaDestino.Text <> "" Then
            If txtMonto.TextLength = 0 Then
                lblTitulo.Text = "Ingrese un monto"
            ElseIf Val(txtMonto.Text) < 1 Then
                lblTitulo.Text = "Ingrese un monto mayor a cero"
            ElseIf Val(txtMonto.Text) < 500 Then
                lblTitulo.Text = "Ingrese un monto mayor a 500"
            Else
                lblCuenta.Text = "Transacción completada exitosamente"
                btnContinuar.Visible = False
                txtMonto.Visible = False
                lblTitulo.Visible = False
                cboCuentaDestinoMoneda.Visible = False
                cboCuentaDestinoTipo.Visible = False
                txtCuentaDestino.Visible = False
                btnCancelar.Text = "FINALIZAR"
                btnCancelar.Height += 20
            End If
        Else
            lblCuenta.Text = "Ingrese el numero de cuenta completo"
        End If
    End Sub
End Class