Public Class frmATMBienvenido

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmATMBienvenido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBienvenido.BackColor = System.Drawing.Color.Transparent
        txtCedula.Focus()

        If Cotizaciones.cotUSD Is Nothing Or Cotizaciones.cotEUR Is Nothing Then
            frmSeteoCotizacionManual.Show()
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        txtCedula.MaxLength = 8
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCedula.TextChanged
        If txtCedula.TextLength = 8 Then
            If Val(txtCedula.Text) = 0 Then
                txtCedula.Clear()
                Mensajes.ErrorSimple("Cédula inválida.")
                Return
            End If
            Autenticacion.usuarioATM = Val(txtCedula.Text)
            Dim form = New frmATMSolicitarPin()
            form.Show()
            Me.Hide()
        End If
    End Sub
End Class