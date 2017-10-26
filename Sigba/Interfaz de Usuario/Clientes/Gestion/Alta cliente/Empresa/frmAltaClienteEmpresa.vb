Public Class frmAltaClienteEmpresa

    Private Sub frmAltaClienteEmpresa_Submit()
        ' Aqui se tienen que validar los datos antes de enviarlos.
        If FormularioEsValido() Then
            ' Si se llega a esta parte del codigo es porque estamos seguros que
            ' el formulario es completamente valido.
            Dim idCliente = Clientes.AltaCliente(txtDomicilioEmpresaCalle.Text, txtCiudadEmpresa.Text, txtDomicilioEmpresaCodPostal.Text, txtDomicilioEmpresaNumero.Text, txtContactoNumerosTelefono.Text, txtDomicilioEmpresaBlock.Text, txtDomicilioEmpresaApartamento.Text, "")
            Dim rut = txtRUT.Text
            If idCliente <> 0 Then
                Dim pudoCrearEmpresa = Empresas.AltaEmpresa(txtDepartamentoEmpresa.Text, Val(idCliente), rut, cboPaisOrigenCapital.Text, cboPaisResidenciaEmpresa.Text, txtContactoSitioWeb.Text, txtRazonSocial.Text, cboTipoSociedad.Text)

                If (pudoCrearEmpresa = True) Then
                    Mensajes.Simple("Cliente creado con éxito.")
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Function FormularioEsValido() As Boolean
        Dim Condicion As Boolean = ( _
            txtRazonSocial.Text <> "" _
            And cboTipoSociedad.SelectedIndex <> 0 _
            And txtRUT.Text <> "" _
            And EsRUTValido(txtRUT.Text) _
            And cboPaisOrigenCapital.SelectedIndex <> 0 _
            And cboPaisResidenciaEmpresa.SelectedIndex <> 0 _
            And txtCiudadEmpresa.Text <> "" _
            And txtDepartamentoEmpresa.Text <> "" _
            And txtDomicilioEmpresaCalle.Text <> "" _
            And txtDomicilioEmpresaNumero.Text <> "" _
            And txtDomicilioEmpresaCodPostal.Text <> "" _
            And txtContactoNumerosTelefono.Text <> "" _
            And txtContactoEmail.Text <> "" _
        )

        If Condicion = False Then
            MessageBox.Show("Verifique los datos")
        End If

        Return Condicion
    End Function

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        frmAltaClienteEmpresa_Submit()

        If Validadores.EsEmailValido(txtContactoEmail.Text) AndAlso Validadores.EsWebValida(txtContactoSitioWeb.Text) = False Then
            MessageBox.Show("Verifique los datos")
        End If

    End Sub

    Private Sub txtRazonSocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtCiudadEmpresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCiudadEmpresa.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtDepartamentoEmpresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDepartamentoEmpresa.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub frmAltaClienteEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisOrigenCapital.Items.AddRange(Constantes.Paises())

        cboPaisOrigenCapital.SelectedIndex = 187
        cboPaisResidenciaEmpresa.SelectedIndex = 187
        cboTipoSociedad.SelectedIndex = 0
    End Sub

    Private Sub txtNombreCompletoContactoPrincipal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtTelefonoContactoPrincipal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validadores.KeyPressSoloNumeros(e)
    End Sub


    Private Sub txtContactoNumerosTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactoNumerosTelefono.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtDomicilioEmpresaNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomicilioEmpresaNumero.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

 

    Private Sub btnLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtRazonSocial.Clear()
        txtRUT.Clear()
        cboTipoSociedad.SelectedIndex = 0
        cboPaisOrigenCapital.SelectedIndex = 187
        cboPaisResidenciaEmpresa.SelectedIndex = 187
        txtCiudadEmpresa.Clear()
        txtDepartamentoEmpresa.Clear()
        txtDomicilioEmpresaCalle.Clear()
        txtDomicilioEmpresaNumero.Clear()
        txtDomicilioEmpresaBlock.Clear()
        txtDomicilioEmpresaApartamento.Clear()
        txtDomicilioEmpresaCodPostal.Clear()
        txtContactoNumerosTelefono.Clear()
        txtContactoEmail.Clear()
        txtContactoSitioWeb.Clear()
    End Sub

    Private Sub txtRUT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        Validadores.KeyPressRUT(e, txtRUT.Text)
    End Sub

    Private Sub txtDomicilioEmpresaCodPostal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomicilioEmpresaCodPostal.KeyPress
        Validadores.KeyPressCodigoPostal(e, txtDomicilioEmpresaCodPostal.Text)
    End Sub

End Class