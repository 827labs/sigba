Public Class frmBajaCliente
    Private Function ValidarFormulario() As Boolean
        Dim condicionPersona = cboPaisDoc.SelectedIndex <> 0 And cboTipoDoc.Text <> "" And txtNroDoc.Text <> ""
        Dim condicionEmpresa = txtRUT.Text <> ""
        Dim condicionGeneral = txtRazonBaja.Text <> ""

        Dim condicionACumplir = If(tabTipoCliente.SelectedIndex = 0, condicionEmpresa, condicionPersona)

        If Not (condicionACumplir And condicionGeneral) Then
            MessageBox.Show("Por favor, complete todos los campos del formulario.")
        End If

        Return condicionACumplir And condicionGeneral
    End Function

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Dim idC = If(tabTipoCliente.SelectedIndex = 0, txtRUT.Text, txtNroDoc.Text)
        Dim tipoC = If(tabTipoCliente.SelectedIndex = 0, TipoCliente.Empresa, TipoCliente.Persona)
        Dim idCliente = Clientes.ObtenerIdCliente(idC, tipoC)
        If ValidarFormulario() Then
            If (Clientes.DarBajaCliente(idCliente, txtRazonBaja.Text)) Then
                Mensajes.Simple("Cliente dado de baja con éxito")
            End If
        End If
    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        If cboTipoDoc.SelectedIndex = 0 Then
            txtNroDoc.MaxLength = 8
            Validadores.KeyPressSoloNumeros(e)
        Else
            txtNroDoc.MaxLength = 100
        End If
    End Sub

    Private Sub frmBajaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDoc.SelectedIndex = 187
        cboTipoDoc.SelectedIndex = 0
    End Sub
End Class