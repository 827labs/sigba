Public Class frmATMBienvenido

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmATMBienvenido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBienvenido.BackColor = System.Drawing.Color.Transparent
        txtCedula.Focus()

        If Cotizaciones.cotUSD Is Nothing Or Cotizaciones.cotEUR Is Nothing Then
            frmInicializacionATM.Show()
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        txtCedula.MaxLength = 8
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCedula.TextChanged
        If Autenticacion.numATMActivo = Nothing Then
            txtCedula.Enabled = False
            lblCedula.Visible = False
            txtCedula.Clear()
            lblBienvenido.Text = T("Cajero fuera de servicio", "Sorry, this ATM is out of service")
            btnActualizar.Visible = True
        End If

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

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If Autenticacion.numATMActivo <> Nothing Then
            txtCedula.Enabled = True
            btnActualizar.Visible = False
            lblCedula.Visible = True
            lblBienvenido.Text = T("Bienvenido a SigbaBank", "Welcome to SigbaBank")
        End If
    End Sub
End Class