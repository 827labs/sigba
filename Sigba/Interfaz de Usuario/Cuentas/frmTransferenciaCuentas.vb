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
        If CuentaEstaHabilitada(cuenta) Then
            txtCuentaDestino.Text = cuenta
        Else
            txtCuentaDestino.Text = "N/D"
        End If
    End Sub

    Private Sub SetearCuentaOrigen(ByVal cuenta As String)
        If CuentaEstaHabilitada(cuenta) Then
            txtCuentaOrigen.Text = cuenta
        Else
            txtCuentaOrigen.Text = "N/D"
        End If
    End Sub

    Private Sub frmTransferenciaCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSaldoCuentaOrigen.Text = "N/D"
        lblTitularCtaDestino.Text = "N/D"
        lblTitularCtaOrigen.Text = "N/D"
    End Sub

    Private Sub txtCuentaOrigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaOrigen.TextChanged
        Try
            Dim cuenta = txtCuentaOrigen.Text
            lblTitularCtaOrigen.Text = ObtenerNombreTitularCuenta(cuenta)
            lblSaldoCuentaOrigen.Text = ObtenerSaldoCuenta(cuenta)
        Catch ex As Exception
            lblTitularCtaOrigen.Text = "N/D"
            lblSaldoCuentaOrigen.Text = "N/D"
        End Try
    End Sub

    Private Sub txtCuentaDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaDestino.TextChanged
        Try
            Dim cuenta = txtCuentaDestino.Text
            lblTitularCtaDestino.Text = ObtenerNombreTitularCuenta(cuenta)
        Catch ex As Exception
            lblTitularCtaDestino.Text = "N/D"
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir.Click
        If (txtCuentaDestino.Text <> "" And txtCuentaOrigen.Text <> "" And cboMontoMoneda.Text <> "" And txtMontoCantidad.Text <> "") Then
            If lblTitularCtaOrigen.Text = "N/D" Or lblSaldoCuentaOrigen.Text = "N/D" Then
                Mensajes.ErrorSimple("La cuenta de origen no la podido ser encontrada")
                Return
            End If

            Dim decision = MessageBox.Show("¿Desea confirmar esta transacción?", "Confirmar", MessageBoxButtons.YesNo)
            If decision = Windows.Forms.DialogResult.Yes Then
                Dim pudoTransferir = Movimientos.EfectuarTransferencia(txtCuentaOrigen.Text, txtCuentaDestino.Text, cboMontoMoneda.Text, Convert.ToDecimal(txtMontoCantidad.Text))

                If pudoTransferir Then
                    Mensajes.Simple("Transferencia efectuada exitosamente")
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("Complete todos los campos para continuar")
        End If
    End Sub

    Private Sub txtMontoCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCantidad.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub
End Class