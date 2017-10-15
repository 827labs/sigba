Public Class frmNuevaCuenta

    Private Sub frmNuevaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Rellenar combo con las sucursales
        Sucursales.ObtenerSucursalesCombo(cboSucursal)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If (cboTipoCuenta.Text <> "" And cboSucursal.Text <> "" And cboUsoFormas.Text <> "" And txtClienteEncontrado.Text <> "") Then
            Dim usuarioConfirma = Mensajes.PreguntaSiNo("¿Desea confirmar esta información?", "Confirmar")
            Dim tipoCliente = If(tabTipoCliente.SelectedIndex = 0, Clientes.TipoCliente.Persona, Clientes.TipoCliente.Empresa)
            Dim nroSucursal As Integer = Val(cboSucursal.Text.Split(" - ")(0))
            Dim idCliente As Integer = Val(txtClienteEncontrado.Text.Split(" / ")(0))
            Dim tipoCuenta As String = cboTipoCuenta.Text.Split(" - ")(0)

            If usuarioConfirma = True Then
                Dim pudoCrearCuenta = Cuentas.CrearCuenta(tipoCliente, idCliente, tipoCuenta, cboUsoFormas.Text.ToUpper(), cboMoneda.Text, nroSucursal)

                If pudoCrearCuenta Then
                    Mensajes.Simple("Cuenta creada exitosamente")
                    Me.Close()
                End If

            End If
        Else
            Mensajes.ErrorSimple("Complete todos los campos para continuar")
        End If
    End Sub

    Private Sub txtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc.TextChanged, txtRUT.TextChanged
        Try
            Dim tipoCliente = If(tabTipoCliente.SelectedIndex = 0, Clientes.TipoCliente.Persona, Clientes.TipoCliente.Empresa)
            Dim pkTextField = If(tipoCliente = Clientes.TipoCliente.Persona, txtNroDoc, txtRUT)
            Dim idCliente = Clientes.ObtenerIdCliente(pkTextField.Text, tipoCliente)
            Dim nombreCliente = Clientes.ObtenerNombreCliente(idCliente, tipoCliente)

            If (idCliente <> 0) Then
                txtClienteEncontrado.Text = idCliente & " / " & nombreCliente
            Else
                txtClienteEncontrado.Text = ""
            End If
        Catch ex As Exception
            If ModoDesarrolloActivado() Then
                txtClienteEncontrado.Text = "Error: " & ex.Message
            Else
                txtClienteEncontrado.Text = "Escriba un número de documento o RUT en el campo"
            End If
        End Try
    End Sub

    Private Sub txtRUT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        Validadores.KeyPressRUT(e, txtRUT.Text)
    End Sub
End Class