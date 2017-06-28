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

        ' TODO: Realizar busqueda
    End Sub

    Private Sub txtBuscaCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscaCedula.KeyPress
        txtBuscaCedula.MaxLength = 8 'está seleccionado, el textbox tendrá 8 caracteres como máximo

        If Char.IsDigit(e.KeyChar) Then

            'Char: Digito
            'IsDigit: Indica si un carácter es numérico
            'e.KeyChar: Caracter que se pulsó en el teclado


            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada
        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        Else

            e.Handled = True 'Le dice al evento que se tomó la acción adecuada
        End If

    End Sub

    Private Sub txtFiltroApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroApellido.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            'Char: Digito
            'IsLetter: Indica si un carácter es una letra
            'e.KeyChar: Caracter que se pulsó en el teclado

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        ElseIf Char.IsSeparator(e.KeyChar) Then 'Indica si el carácter se clasifica como carácter separador

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        Else

            e.Handled = True 'Le dice al evento que se tomó la acción adecuada

        End If
    End Sub

    Private Sub txtFiltroNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            'Char: Digito
            'IsLetter: Indica si un carácter es una letra
            'e.KeyChar: Caracter que se pulsó en el teclado

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        ElseIf Char.IsSeparator(e.KeyChar) Then 'Indica si el carácter se clasifica como carácter separador

            e.Handled = False 'Le dice al evento que no se tomó la acción adecuada

        Else

            e.Handled = True 'Le dice al evento que se tomó la acción adecuada

        End If
    End Sub

    Private Sub btnLimpiarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarCedula.Click
        ' Limpia el formulario de filtros
        txtBuscaCedula.Clear()
    End Sub

    Private Sub frmGestionUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFiltroCargo.SelectedIndex = 0
        cboFiltroCargo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class