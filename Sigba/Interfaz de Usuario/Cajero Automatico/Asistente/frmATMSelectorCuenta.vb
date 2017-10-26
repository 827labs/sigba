Public Class frmATMSelectorCuenta

    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmATMSelectorCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim idCliente = ObtenerIdCliente(Autenticacion.usuarioATM, TipoCliente.Persona)
        BuscarCuentasDGV(idCliente, dgvCuentas)
    End Sub

    Private Sub dgvCuentas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellContentClick
        Dim cuentaSeleccionada = dgvCuentas.Rows(e.RowIndex).Cells(0).Value
        Autenticacion.cuentaATM = cuentaSeleccionada

        Dim form = New frmATMSelectorOperacion()
        form.Show()
        Me.Hide()
    End Sub
End Class