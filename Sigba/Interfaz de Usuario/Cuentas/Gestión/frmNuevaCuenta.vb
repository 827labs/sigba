Public Class frmNuevaCuenta

    Private Sub frmNuevaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDoc.Items.AddRange(Constantes.Paises())
        cboPaisDoc.SelectedIndex = 187
        cboTipoDoc.SelectedIndex = 0

        ' Rellenar combo con las sucursales
        Sucursales.ObtenerSucursalesCombo(cboSucursal)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If (cboTipoCuenta.Text <> "" And cboSucursal.Text <> "" And cboUsoFormas.Text <> "") Then
            Dim usuarioConfirma = Mensajes.PreguntaSiNo("¿Desea confirmar esta información?", "Confirmar")

            If usuarioConfirma = True Then
                Mensajes.Simple("La cuenta se ha dado de alta exitosamente.")
                Me.Close()
            End If
        Else
            Mensajes.ErrorSimple("Complete todos los campos para continuar")
        End If
    End Sub

    Private Sub cboTipoDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoDoc.KeyPress

    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        If cboTipoDoc.SelectedIndex = 0 Then
            txtNroDoc.MaxLength = 8
            Validadores.KeyPressSoloNumeros(e)
        Else
            txtNroDoc.MaxLength = 100
        End If
    End Sub
End Class