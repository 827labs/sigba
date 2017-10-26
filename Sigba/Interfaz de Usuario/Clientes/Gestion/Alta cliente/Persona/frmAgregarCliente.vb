Public Class frmAgregarClienteEmpresa

    Dim Mail As Boolean 'Declaración de variable mail para luego validarla

    Dim AnchoPantalla As Integer = My.Computer.Screen.Bounds.Width 'Dimensiones del ancho
    Dim AltoPantalla As Integer = My.Computer.Screen.WorkingArea.Height 'Dimensiones del alto

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Principal.Show() 'Al dar click en el botón cancelar, se aparece la ventana principal
        Me.Close() 'Y esta ventana (Agregar Cliente) se cierra
    End Sub

    Private Sub frmAgregarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cboTipoDoc.SelectedIndex = 0 Then 'Si el primer item del combobox está seleccionado
            txtNroDoc.MaxLength = 8          'el textbox Numero de documento tendrá como límite 8 caracteres
        End If

        cboPaisDoc.Items.AddRange(Constantes.Paises())
        cboPaisNaci.Items.AddRange(Constantes.Paises())
        cboPaisDocCony.Items.AddRange(Constantes.Paises())
        cboPaisRes.Items.AddRange(Constantes.Paises())

        ' Rellenar el ComboBox de Año dinamicamente
        Generadores.RellenarComboBoxAnio(cboAnoNaci)

        Limpiar()
        
        ' Deshabilitar form del conyuge por default
        CambiarHabilitacionModuloConyuge(False)

        If Desarrollo.ModoDesarrolloActivado() Then
            AutoCompletarFormDesarrollo()
        End If
    End Sub

    Private Sub AutoCompletarFormDesarrollo()
        txtNombre1.Text = "Juan"
        txtNombre2.Text = ""
        txtApellido1.Text = "Perez"
        txtApellido2.Text = "Rodriguez"
        cboSexo.SelectedIndex = 1
        txtNroDoc.Text = "87654321"
        cboDiaNaci.SelectedIndex = 4
        cboMesNaci.SelectedIndex = 3
        cboAnoNaci.SelectedIndex = 40
        cboPaisNaci.SelectedIndex = 187
        txtCiudadNac.Text = "Montevideo"

        txtLocalidadRes.Text = "Montevideo"
        txtRegionRes.Text = "Montevideo"
        txtCalleDom.Text = "Andes"
        txtNroDom.Text = "1234"
        txtCiudadNac.Text = "Montevideo"
        txtCodigoPos.Text = "19000"
        txtTelefonoFijo.Text = "29056969"
        txtCelular.Text = "098891892"
        txtBlockDom.Text = ""
        txtAptoDom.Text = ""
        txtAclaracionDom.Text = ""
    End Sub

    Private Sub Limpiar()
        'Borra el contenido de los TextBox
        txtApellido1.Clear()
        txtApellido2.Clear()
        txtNombre1.Clear()
        txtNombre2.Clear()
        txtCiudadNac.Clear()
        txtNroDoc.Clear()
        txtCalleDom.Clear()
        txtNroDom.Clear()
        txtBlockDom.Clear()
        txtAptoDom.Clear()
        txtAclaracionDom.Clear()
        txtTelefonoFijo.Clear()
        txtCelular.Clear()
        txtNombreCony.Clear()
        txtCodigoPos.Clear()
        txtRegionRes.Clear()
        txtNroDocCony.Clear()
        txtMail.Clear()

        'Deja por defecto el primer item de los ComboBox
        cboDiaNaci.SelectedIndex = 0
        cboMesNaci.SelectedIndex = 0
        cboAnoNaci.SelectedIndex = 0
        cboTipoDoc.SelectedIndex = 0

        cboSexo.SelectedIndex = 0
        cboTipoDocCony.SelectedIndex = 0

        'Deja por defecto el item numero 187 (Uruguay) de los ComboBox
        cboPaisNaci.SelectedIndex = 187
        cboPaisDoc.SelectedIndex = 187
        cboPaisRes.SelectedIndex = 187
        cboPaisDocCony.SelectedIndex = 187
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        InsertarCliente()
    End Sub

    Private Sub InsertarCliente()
        Dim apellidoCliente = txtApellido1.Text & " " & txtApellido2.Text
        Dim nombreCliente = txtNombre1.Text & " " & txtNombre2.Text
        Dim fechaNacimiento = New Date(Val(cboAnoNaci.Text), cboMesNaci.SelectedIndex, Val(cboDiaNaci.Text))
        Dim sexoCliente = If(cboSexo.Text = "Masculino", "F", "M")

        Dim idCliente = Clientes.AltaCliente(txtCalleDom.Text, txtLocalidadRes.Text, txtCodigoPos.Text, txtNroDom.Text, txtTelefonoFijo.Text, txtBlockDom.Text, txtAptoDom.Text, txtAclaracionDom.Text)
        Dim pudoCrearPersona = Personas.AltaPersona(apellidoCliente, txtCiudadNac.Text, fechaNacimiento, txtMail.Text, idCliente, nombreCliente, txtNroDocCony.Text, txtNroDoc.Text, cboPaisDocCony.Text, cboPaisDoc.Text, cboPaisNaci.Text, sexoCliente, cboTipoDocCony.Text, cboTipoDoc.Text)

        If (pudoCrearPersona) Then
            Mensajes.Simple("Cliente creado con éxito.")
            Me.Close()
        End If
    End Sub


    Private Sub KPSoloLetras(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCiudadNac.KeyPress, txtNombreCony.KeyPress, txtNombre2.KeyPress, txtNombre1.KeyPress, txtApellido2.KeyPress, txtApellido1.KeyPress
        Validadores.KeyPressSoloLetras(e)
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoFijo.KeyPress, txtNroDom.KeyPress, txtCelular.KeyPress, txtAptoDom.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub txtCodigoPos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoPos.KeyPress
        Validadores.KeyPressCodigoPostal(e, txtCodigoPos.Text)
    End Sub

    Private Sub txtNroDocCony_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocCony.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDocCony, txtNroDocCony)
    End Sub


    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDoc, txtNroDoc)
    End Sub


    Private Sub cboPaisNaci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisNaci.SelectedIndexChanged
        cboPaisDoc.SelectedIndex = cboPaisNaci.SelectedIndex
    End Sub

    Private Sub CambiarHabilitacionModuloConyuge(ByVal esHabilitado As Boolean)
        cboPaisDocCony.Enabled = esHabilitado
        cboTipoDocCony.Enabled = esHabilitado
        txtNroDocCony.Enabled = esHabilitado
    End Sub

    Private Sub txtNombreCony_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreCony.TextChanged
        If txtNombreCony.Text.Length > 0 Then
            CambiarHabilitacionModuloConyuge(True)
        Else
            CambiarHabilitacionModuloConyuge(False)
        End If
    End Sub
End Class