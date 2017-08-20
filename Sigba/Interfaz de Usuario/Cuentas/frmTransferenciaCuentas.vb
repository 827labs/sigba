Public Class frmTransferenciaCuentas

    Private Sub btnBuscarCuentaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCuentaOrigen.Click
        Dim form = New frmBusquedaCuentaPorCliente()
        form.SetearNotificable(AddressOf SetearCuentaOrigen)
        form.Show()
    End Sub

    Private Sub btnBuscarCuentaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCuentaDestino.Click
        Dim form = New frmBusquedaCuentaPorCliente()
        form.SetearNotificable(AddressOf SetearCuentaDestino)
        form.Show()
    End Sub

    Private Sub SetearCuentaDestino(ByVal cuenta As String)
        txtCuentaDestino.Text = cuenta
    End Sub

    Private Sub SetearCuentaOrigen(ByVal cuenta As String)
        txtCuentaOrigen.Text = cuenta
    End Sub

    Private Sub frmTransferenciaCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSaldoCuentaOrigen.Text = "N/D"
        lblTitularCtaDestino.Text = "N/D"
        lblTitularCtaOrigen.Text = "N/D"
    End Sub

    Private Sub txtCuentaOrigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaOrigen.TextChanged
        If txtCuentaOrigen.TextLength = 19 Then
            ' Esto es una simulación para la primera entrega
            lblTitularCtaOrigen.Text = "PEREZ, JUAN"
            lblSaldoCuentaOrigen.Text = "UYU 123,45"
        End If
    End Sub

    Private Sub txtCuentaDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaDestino.TextChanged
        If txtCuentaDestino.TextLength = 19 Then
            lblTitularCtaDestino.Text = "COUTHINIO, ANTONIO"
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir.Click
        If (txtCuentaDestino.Text <> "" And txtCuentaOrigen.Text <> "" And cboMontoMoneda.Text <> "" And txtMontoCantidad.Text <> "") Then
            Dim decision = MessageBox.Show("¿Desea confirmar esta transacción?", "Confirmar", MessageBoxButtons.YesNo)
            If decision = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("La transacción se ha confirmado exitosamente.")
                Me.Close()
            End If
        Else
            MessageBox.Show("Complete todos los campos para continuar")
        End If
    End Sub

    Private Sub txtMontoCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCantidad.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class