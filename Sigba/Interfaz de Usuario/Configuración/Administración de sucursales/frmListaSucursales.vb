Public Class frmListaSucursales

    Private Sub frmListaSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sucursales.ObtenerSucursales(dgvSucursales)
    End Sub

    Private Sub dgvSucursales_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSucursales.CellClick
        Dim frmEdicion = New frmEditarSucursal()
        frmEdicion.SetEditar(dgvSucursales.Rows(e.RowIndex).Cells(0).Value)
        frmEdicion.Show()
    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        Dim frmNuevo = New frmEditarSucursal()
        frmNuevo.Show()
    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        Sucursales.ObtenerSucursales(dgvSucursales)
    End Sub
End Class