Public Class frmATMSolicitarPin

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub txtPIN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIN.KeyPress
        Validadores.KeyPressSoloNumeros(e)

        If txtPIN.TextLength = 3 Then
            Dim form = New frmATMSelectorCuenta()
            form.Show()
            Me.Hide()
        End If
    End Sub
End Class