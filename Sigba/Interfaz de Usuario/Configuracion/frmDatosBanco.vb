Public Class frmDatosBanco

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If (txtNombreFantasia.Text <> "" And txtRazonSocial.Text <> "" And txtRUT.Text <> "" And txtCasaCentral.Text <> "" And txtTelefono.Text <> "" And txtSitioWeb.Text <> "" And txtLimRetDiarioDependenciasUSD.Text <> "" And txtLimRetDiarioDependenciasUYU.Text <> "" And txtLimRetDiarioIslaUSD.Text <> "" And txtLimRetDiarioIslaUYU.Text <> "" And txtMinimoDepCajaUSD.Text <> "" And txtMinimoDepCajaUYU.Text <> "" And txtMaximoDepCajaUSD.Text <> "" And txtMaximoDepCajaUYU.Text <> "") Then
            Dim decision = MessageBox.Show("¿Desea confirmar esta información?", "Confirmar", MessageBoxButtons.YesNo)
            If decision = Windows.Forms.DialogResult.Yes Then
                Dim banc = New Banco()
                banc.NombreFantasiaB = txtNombreFantasia.Text
                banc.RazonSocial = txtRazonSocial.Text
                banc.RUT = txtRUT.Text
                banc.DireccionB = txtCasaCentral.Text
                banc.TelefonoB = txtTelefono.Text
                banc.SitioWebB = txtSitioWeb.Text
                banc.LimiteRetiroCajeroDependenciasPesos = Val(txtLimRetDiarioDependenciasUYU.Text)
                banc.LimiteRetiroCajeroDependenciasDolares = Val(txtLimRetDiarioDependenciasUSD.Text)
                banc.LimiteRetiroCajeroIslaPesos = Val(txtLimRetDiarioIslaUYU.Text)
                banc.LimiteRetiroCajeroIslaDolares = Val(txtLimRetDiarioIslaUSD.Text)
                banc.HabilitarCCPersonas = chkCCPersonas.Checked
                banc.MaxDepositoSinDeclararPesos = Val(txtMaximoDepCajaUYU.Text)
                banc.MaxDepositoSinDeclararDolares = Val(txtMaximoDepCajaUSD.Text)
                banc.MinimoDepositoSinDeclararPesos = Val(txtMinimoDepCajaUYU.Text)
                banc.MinimoDepositoSinDeclararDolares = Val(txtMinimoDepCajaUSD.Text)

                If banc.Actualizar() Then
                    MessageBox.Show("La información se ha actualizado exitosamente.")
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("Complete todos los campos para continuar")
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress, txtMinimoDepCajaUYU.KeyPress, txtMinimoDepCajaUSD.KeyPress, txtMaximoDepCajaUYU.KeyPress, txtMaximoDepCajaUSD.KeyPress, txtLimRetDiarioIslaUYU.KeyPress, txtLimRetDiarioIslaUSD.KeyPress, txtLimRetDiarioDependenciasUYU.KeyPress, txtLimRetDiarioDependenciasUSD.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub frmDatosBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Banco.HayBancoRegistrado Then
            Return
        End If

        Dim banc = New Banco()
        txtNombreFantasia.Text = banc.NombreFantasiaB
        txtRazonSocial.Text = banc.RazonSocial
        txtRUT.Text = banc.RUT
        txtCasaCentral.Text = banc.DireccionB
        txtTelefono.Text = banc.TelefonoB
        txtSitioWeb.Text = banc.SitioWebB
        txtLimRetDiarioDependenciasUYU.Text = banc.LimiteRetiroCajeroDependenciasPesos
        txtLimRetDiarioDependenciasUSD.Text = banc.LimiteRetiroCajeroDependenciasDolares
        txtLimRetDiarioIslaUYU.Text = banc.LimiteRetiroCajeroIslaPesos
        txtLimRetDiarioIslaUSD.Text = banc.LimiteRetiroCajeroIslaDolares
        chkCCPersonas.Checked = banc.HabilitarCCPersonas
        txtMaximoDepCajaUYU.Text = banc.MaxDepositoSinDeclararPesos
        txtMaximoDepCajaUSD.Text = banc.MaxDepositoSinDeclararDolares
        txtMinimoDepCajaUYU.Text = banc.MinimoDepositoSinDeclararPesos
        txtMinimoDepCajaUSD.Text = banc.MinimoDepositoSinDeclararDolares
    End Sub
End Class