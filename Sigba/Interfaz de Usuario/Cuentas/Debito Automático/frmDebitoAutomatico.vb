Public Class frmDebitoAutomatico

    Private Sub frmDebitoAutomatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvDebitos.Rows.Add("FUCEREP S.A.", "045-011217-5", "UYU 1200,00", "20/11/2017", "Exitosa - JDI08FW3HU")
    End Sub

    Private Sub dgvDebitos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDebitos.CellClick
        frmDetalleDebitoAutomatico.Show()
    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        frmNuevoDebitoAutomatico.Show()
    End Sub
End Class