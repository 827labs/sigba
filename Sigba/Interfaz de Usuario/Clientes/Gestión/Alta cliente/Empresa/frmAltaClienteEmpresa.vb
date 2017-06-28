Public Class frmAltaClienteEmpresa

    Private Sub frmAltaClienteEmpresa_Submit()
        ' Aqui se tienen que validar los datos antes de enviarlos.
        If FormularioEsValido() Then
            ' Si se llega a esta parte del codigo es porque estamos seguros que
            ' el formulario es completamente valido.
        End If
    End Sub

    Private Function FormularioEsValido() As Boolean
        Dim Condicion As Boolean = ( _
            txtNombreEmpresa.Text <> "" _
            And txtRazonSocial.Text <> "" _
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
            And cboPaisDocContactoPrincipal.SelectedIndex <> 0 _
            And cboTipoDocContactoPrincipal.SelectedIndex <> 0 _
            And txtNroDocContactoPrincipal.Text <> "" _
            And txtNombreCompletoContactoPrincipal.Text <> "" _
            And txtDireccionContactoPrincipal.Text <> "" _
            And txtTelefonoContactoPrincipal.Text <> "" _
        )

        If Condicion = False Then
            MessageBox.Show("Verifique los datos")
        End If

        Return Condicion
    End Function

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If (tabControl.SelectedIndex = 0) Then
            ' Si el SelectedIndex es 0, debemos avanzar al siguiente tab.
            tabControl.SelectTab(1)
        Else
            ' Si el SelectedIndex es 1, debemos "enviar" el formulario
            frmAltaClienteEmpresa_Submit()

        End If

        If Validadores.EsEmailValido(txtContactoEmail.Text) AndAlso Validadores.EsWebValida(txtContactoSitioWeb.Text) = False Then
            MessageBox.Show("Verifique los datos")
        End If

    End Sub

    Private Sub tabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl.SelectedIndexChanged
        If tabControl.SelectedIndex = 0 Then
            btnSiguiente.Text = "Siguiente"
        Else
            btnSiguiente.Text = "Enviar"
        End If
    End Sub

    Private Sub txtNroDocContactoPrincipal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocContactoPrincipal.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDocContactoPrincipal, txtNroDocContactoPrincipal)
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
        cboPaisDocContactoPrincipal.Items.AddRange(Constantes.Paises())
        cboParSoc1PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc2PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc3PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc4PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc5PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc6PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc7PaisDoc.Items.AddRange(Constantes.Paises())
        cboParSoc8PaisDoc.Items.AddRange(Constantes.Paises())

        cboPaisOrigenCapital.SelectedIndex = 187
        cboPaisResidenciaEmpresa.SelectedIndex = 187
        cboPaisDocContactoPrincipal.SelectedIndex = 187
        cboTipoDocContactoPrincipal.SelectedIndex = 0
        cboTipoSociedad.SelectedIndex = 0
        cboParSoc1PaisDoc.SelectedIndex = 187
        cboParSoc1TipoDoc.SelectedIndex = 0
        cboParSoc2PaisDoc.SelectedIndex = 187
        cboParSoc2TipoDoc.SelectedIndex = 0
        cboParSoc3PaisDoc.SelectedIndex = 187
        cboParSoc3TipoDoc.SelectedIndex = 0
        cboParSoc4PaisDoc.SelectedIndex = 187
        cboParSoc4TipoDoc.SelectedIndex = 0
        cboParSoc5PaisDoc.SelectedIndex = 187
        cboParSoc5TipoDoc.SelectedIndex = 0
        cboParSoc6PaisDoc.SelectedIndex = 187
        cboParSoc6TipoDoc.SelectedIndex = 0
        cboParSoc7PaisDoc.SelectedIndex = 187
        cboParSoc7TipoDoc.SelectedIndex = 0
        cboParSoc8PaisDoc.SelectedIndex = 187
        cboParSoc8TipoDoc.SelectedIndex = 0
    End Sub

    Private Sub txtNombreCompletoContactoPrincipal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCompletoContactoPrincipal.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtTelefonoContactoPrincipal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoContactoPrincipal.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub


    Private Sub txtContactoNumerosTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactoNumerosTelefono.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtDomicilioEmpresaNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomicilioEmpresaNumero.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    'Falta validar documento, código postal y el RUT y también
    'el documento en la página de participación societaria

    Private Sub txtParSoc1Nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParSoc1Nombre.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub txtPartAcc1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc2.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc3.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc4.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc5.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc6_KeyPress (ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc6.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc7.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtPartAcc8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartAcc8.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        tabControl.SelectedIndex = 0
    End Sub

    Private Sub btnLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If tabControl.SelectedIndex = 0 Then
            txtNombreEmpresa.Clear()
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
            cboPaisDocContactoPrincipal.SelectedIndex = 187
            cboTipoDocContactoPrincipal.SelectedIndex = 0
            txtNroDocContactoPrincipal.Clear()
            txtNombreCompletoContactoPrincipal.Clear()
            txtDireccionContactoPrincipal.Clear()
            txtTelefonoContactoPrincipal.Clear()

        ElseIf tabControl.SelectedIndex = 1 Then
            txtParSoc1Nombre.Clear()
            txtParSoc2Nombre.Clear()
            txtParSoc3Nombre.Clear()
            txtParSoc4Nombre.Clear()
            txtParSoc5Nombre.Clear()
            txtParSoc6Nombre.Clear()
            txtParSoc7Nombre.Clear()
            txtParSoc8Nombre.Clear()
            cboParSoc1PaisDoc.SelectedIndex = 187
            cboParSoc2PaisDoc.SelectedIndex = 187
            cboParSoc3PaisDoc.SelectedIndex = 187
            cboParSoc4PaisDoc.SelectedIndex = 187
            cboParSoc5PaisDoc.SelectedIndex = 187
            cboParSoc6PaisDoc.SelectedIndex = 187
            cboParSoc7PaisDoc.SelectedIndex = 187
            cboParSoc8PaisDoc.SelectedIndex = 187
            cboParSoc1TipoDoc.SelectedIndex = 0
            cboParSoc2TipoDoc.SelectedIndex = 0
            cboParSoc3TipoDoc.SelectedIndex = 0
            cboParSoc4TipoDoc.SelectedIndex = 0
            cboParSoc5TipoDoc.SelectedIndex = 0
            cboParSoc6TipoDoc.SelectedIndex = 0
            cboParSoc7TipoDoc.SelectedIndex = 0
            cboParSoc8TipoDoc.SelectedIndex = 0
            txtParSoc1Doc.Clear()
            txtParSoc2Doc.Clear()
            txtParSoc3Doc.Clear()
            txtParSoc4Doc.Clear()
            txtParSoc5Doc.Clear()
            txtParSoc6Doc.Clear()
            txtParSoc7Doc.Clear()
            txtParSoc8Doc.Clear()
            txtPartAcc1.Clear()
            txtPartAcc2.Clear()
            txtPartAcc3.Clear()
            txtPartAcc4.Clear()
            txtPartAcc5.Clear()
            txtPartAcc6.Clear()
            txtPartAcc7.Clear()
            txtPartAcc8.Clear()
            txtPartAccDomicilio1.Clear()
            txtPartAccDomicilio2.Clear()
            txtPartAccDomicilio3.Clear()
            txtPartAccDomicilio4.Clear()
            txtPartAccDomicilio5.Clear()
            txtPartAccDomicilio6.Clear()
            txtPartAccDomicilio7.Clear()
            txtPartAccDomicilio8.Clear()
        End If
    End Sub

    Private Sub txtRUT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        Validadores.KeyPressRUT(e, txtRUT.Text)
    End Sub

    Private Sub txtDomicilioEmpresaCodPostal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomicilioEmpresaCodPostal.KeyPress
        Validadores.KeyPressCodigoPostal(e, txtDomicilioEmpresaCodPostal.Text)
    End Sub
End Class