Public Class frmGestionUsuarios

    ' Inicio validaciones

    Private Function HayFiltrosSeleccionados() As Boolean
        Return (cboFiltroCargo.Text <> "" Or txtFiltroApellido.Text <> "" Or txtFiltroNombre.Text <> "")
    End Function

    Private Function HayCedulaIngresada()
        Return (txtBuscaCedula.Text <> "")
    End Function

    ' Fin validaciones

    Private Sub btnLimpiarFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarFiltros.Click
        ' Limpia el formulario de filtros
        cboFiltroCargo.Text = ""
        txtFiltroApellido.Clear()
        txtFiltroNombre.Clear()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If (HayFiltrosSeleccionados() = False) Then
            MessageBox.Show("Seleccione al menos un término para filtrar.", "Formulario inválido")
        End If

        ' TODO: Realizar filtro
    End Sub

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

    Private Sub txtFiltroApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroApellido.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtFiltroNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroNombre.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub btnLimpiarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarCedula.Click
        ' Limpia el formulario de filtros
        txtBuscaCedula.Clear()
    End Sub

    Private Sub frmGestionUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFiltroCargo.SelectedIndex = 0
        cboFiltroCargo.DropDownStyle = ComboBoxStyle.DropDownList

        Usuarios.ListarUsuarios(dgvUsuarios)
    End Sub
End Class