Public Class frmDetalleDebitoAutomatico

    Private Sub frmDetalleDebitoAutomatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvTransacciones.Rows.Add("Ahorro Octubre 2017", "20/10/2017", "Exitosa")
        dgvTransacciones.Rows.Add("Ahorro Septiembre 2017", "20/09/2017", "Exitosa")
        dgvTransacciones.Rows.Add("Ahorro Agosto 2017", "20/08/2017", "Exitosa")
        dgvTransacciones.Rows.Add("Ahorro Julio 2017", "20/07/2017", "Exitosa")
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim decision = MessageBox.Show("¿Está seguro que desea archivar este débito automático? La empresa será notificada dentro de las 48 horas hábiles.", "Confirmar", MessageBoxButtons.YesNo)
        If (decision = Windows.Forms.DialogResult.Yes) Then
            MessageBox.Show("La suscripción se ha archivado correactamente.")
            Me.Close()
        End If
    End Sub
End Class