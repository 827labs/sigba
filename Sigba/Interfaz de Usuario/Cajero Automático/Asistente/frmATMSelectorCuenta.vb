Public Class frmATMSelectorCuenta

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmATMSelectorCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvCuentas.Rows.Add("Caja de Ahorro (CA)", "Pesos Uruguayos (UYU)", "012-345678-9", "$ 12823,42")
        dgvCuentas.Rows.Add("Cuenta Corriente (CC)", "Pesos Uruguayos (UYU)", "012-335645-2", "$ 151376,29")
        dgvCuentas.Rows.Add("Cuenta Corriente (CC)", "Dólares Americanos (USD)", "012-234567-5", "US$ 238,32")
    End Sub

    Private Sub dgvCuentas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        Dim form = New frmATMSelectorOperacion()
        form.Show()
        Me.Hide()
    End Sub
End Class