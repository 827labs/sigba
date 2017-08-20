Public Class frmATMBienvenido

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmATMBienvenido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBienvenido.BackColor = System.Drawing.Color.Transparent
        txtCedula.Focus()

    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        txtCedula.MaxLength = 8
        Validadores.KeyPressSoloNumeros(e)

        If txtCedula.TextLength = 7 Then
            Dim form = New frmATMSolicitarPin()
            form.Show()
            Me.Hide()
        End If
    End Sub
End Class