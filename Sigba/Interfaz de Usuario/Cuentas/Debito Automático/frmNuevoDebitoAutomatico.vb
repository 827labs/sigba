Public Class frmNuevoDebitoAutomatico

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub SetearNroCuenta(ByVal nrocuenta As String)
        lblCtaDebito.Text = nrocuenta
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If txtAsunto.Text = "" Or txtDiaCobro.Text = "" Or txtEmpresa.Text = "" Or txtMontoCantidad.Text = "" Or txtTelContactoEmpresa.Text = "" Or cboMontoMoneda.Text = "" Then
            Mensajes.ErrorSimple(T("Complete todos los campos", "Fill all the fields"))
            Return
        End If
        Dim decision = MessageBox.Show(T("¿Está seguro que desea dar de alta este débito automático? La empresa será notificada dentro de las 48 horas hábiles.", "Are you sure? The company will be notified 48hrs from now."), T("Confirmar", "Confirm"), MessageBoxButtons.YesNo)
        If (decision = Windows.Forms.DialogResult.Yes) Then
            If DebitosAutomaticos.CrearDebitoAutomatico(txtEmpresa.Text, txtAsunto.Text, txtDiaCobro.Text, cboMontoMoneda.Text, txtMontoCantidad.Text, lblCtaDebito.Text, txtTelContactoEmpresa.Text) Then
                MessageBox.Show(T("La suscripción se ha creado correactamente.", "Success"))
                Me.Close()
            End If
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCantidad.KeyPress, txtDiaCobro.KeyPress, txtTelContactoEmpresa.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtDiaCobro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaCobro.TextChanged
        txtDiaCobro.MaxLength = 2
    End Sub
End Class