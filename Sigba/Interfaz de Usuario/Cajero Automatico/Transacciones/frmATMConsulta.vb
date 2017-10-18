Public Class frmATMConsulta

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
    End Sub

    Private Sub frmATMConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Transacciones de la cuenta " & Autenticacion.cuentaATM
        HistoricoCuentaDGV(dgvTransacciones, Autenticacion.cuentaATM)
    End Sub
End Class