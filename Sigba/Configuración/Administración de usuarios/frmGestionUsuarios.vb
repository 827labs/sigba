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
            MessageBox.Show("Seleccione al menos un término para filtrar.", "Formulario invalido")
        End If

        ' TODO: Realizar filtro
    End Sub

    Private Sub btnBuscarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCedula.Click
        If (HayCedulaIngresada() = False) Then
            MessageBox.Show("Ingrese un número de cédula para buscar.", "Formulatio invalido")
        End If

        ' TODO: Realizar busqueda
    End Sub
End Class