Public Class frmGestionUsuarios

    ' Inicio validaciones

    Private Function HayCedulaIngresada()
        Return (txtBuscaCedula.Text <> "")
    End Function

    ' Fin validaciones

    Private Sub btnBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCedula.Click
        If (HayCedulaIngresada() = False) Then
            MessageBox.Show("Ingrese un número de cédula para buscar.", "Formulario inválido")
        End If

        Usuarios.ListarUsuarios(dgvUsuarios, Val(txtBuscaCedula.Text))
    End Sub

    Private Sub txtBuscaCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscaCedula.KeyPress
        txtBuscaCedula.MaxLength = 8 'está seleccionado, el textbox tendrá 8 caracteres como máximo
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtFiltroApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtFiltroNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub btnLimpiarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarCedula.Click
        ' Limpia el formulario de filtros
        txtBuscaCedula.Clear()
    End Sub

    Private Sub frmGestionUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Usuarios.ListarUsuarios(dgvUsuarios)
    End Sub

    Private Sub btnNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoUsuario.Click
        frmNuevoUsuario.Show()
    End Sub

    Private Sub dgvUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        Dim usuario = dgvUsuarios.Rows(e.RowIndex).Cells(4).Value
        Dim frmEdicion = New frmNuevoUsuario()
        frmEdicion.Show()
        frmEdicion.SetearUsuarioEdicion(usuario)

    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        Usuarios.ListarUsuarios(dgvUsuarios)
    End Sub
End Class