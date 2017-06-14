Public Class frmGestionCargos

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        frmEdicionCargo.Show()
    End Sub

    Private Sub frmGestionCargos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgvCargos.Rows.Add("Gerente", "47", "2", "Ninguno")
        dgvCargos.Rows.Add("Auxiliar", "21", "0", "Ninguno")
    End Sub

    Private Sub dgvCargos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCargos.CellDoubleClick
        Dim indiceCargo = e.RowIndex
        Dim frmEdicionExistente = New frmEdicionCargo()
        Dim row = dgvCargos.Rows(indiceCargo)
        frmEdicionExistente.EditarCargo(indiceCargo, row.Cells(0).Value)
        frmEdicionExistente.Show()
    End Sub
End Class