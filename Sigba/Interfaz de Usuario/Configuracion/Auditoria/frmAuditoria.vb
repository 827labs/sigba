Public Class frmAuditoria

    Private Sub btnsFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarFecha.Click, btnFiltrarUsuario.Click
        If (txtFechaDesde.Text <> "" And txtFechaHasta.Text <> "") Or (txtCedula.Text <> "") Then
            Auditoria.ObtenerRegistros(dgvAcciones, txtFechaDesde.Text, txtFechaHasta.Text, txtCedula.Text)
        Else
            MessageBox.Show("Ingrese un criterio de búsqueda para filtrar.")
        End If
    End Sub

    Private Sub frmAuditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaDesde.Text = Date.Today.ToString(FormatoFecha())
        txtFechaHasta.Text = Date.Today.ToString(FormatoFecha())
        Auditoria.ObtenerRegistros(dgvAcciones)
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        txtCedula.MaxLength = 8
        Validadores.KeyPressSoloNumeros(e)
    End Sub

   
    Private Sub txtFechaDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaDesde.KeyPress
        txtFechaDesde.MaxLength = 10
        Validadores.KeyPressTxtFecha(e, txtFechaDesde)
    End Sub

    Private Sub txtFechaHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaHasta.KeyPress
        txtFechaHasta.MaxLength = 10
        Validadores.KeyPressTxtFecha(e, txtFechaHasta)
    End Sub
End Class