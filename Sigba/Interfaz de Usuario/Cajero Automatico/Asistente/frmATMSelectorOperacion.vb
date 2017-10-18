Public Class frmATMSelectorOperacion

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        Dim form = New frmATMRetiro()
        form.Show()
    End Sub

    Private Sub btnDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposito.Click
        Dim form = New frmATMDeposito()
        form.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Autenticacion.usuarioATM = Nothing
        Autenticacion.pinATM = Nothing
        Autenticacion.cuentaATM = Nothing
        Dim form = New frmATMBienvenido()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Dim form = New frmATMConsulta()
        form.Show()
    End Sub

    Private Sub btnTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferencia.Click
        Dim form = New frmATMTransferencia()
        form.Show()
    End Sub
End Class