﻿Public Class frmCierreCaja
    ' Estas variables solo se utilizan en la primera entrega
    ' a fin de simular una diferencia con el saldo previo de la caja.
    Dim ejemploSaldoActualUYU = 21823
    Dim ejemploSaldoActualUSD = 7513

    Private Sub frmCierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFecha.Text = Generadores.StringFechaActual()
        txtHora.Text = Generadores.StringHoraActual()
        txtCajero.Text = Autenticacion.usuario
        txtCajero.Enabled = False

        Dim cajero = New Usuario(Autenticacion.usuario)

        txtNombreCajera.Text = String.Format("{0}, {1}", cajero.Apellido, cajero.Nombre)

        If Autenticacion.HayCajaAbierta() Then
            txtSucursal.Text = Autenticacion.sucursalCajaAbierta
            txtCaja.Text = Autenticacion.cajaAbierta
        End If
    End Sub

    Private Sub KPSoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoUYU.KeyPress, txtSaldoUSD.KeyPress, txtCaja.KeyPress, txtCajero.KeyPress, txtSucursal.KeyPress
        Validadores.KeyPressSoloNumeros(e)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtSucursal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSucursal.Leave
        Dim suc = New Sucursal(Val(txtSucursal.Text))
        If suc.EsValido() Then
            lblSucursal.Text = suc.NumSuc & " - " & suc.NombreSuc
            txtCaja.Enabled = True
        Else
            txtCaja.Enabled = False
            txtSucursal.Focus()
            txtSucursal.Clear()
        End If
    End Sub

    Private Sub txtCaja_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCaja.Leave
        Dim cajaActual = New Caja(Val(txtCaja.Text))
        If Not (cajaActual.EsValido() And cajaActual.NumSuc = Val(txtSucursal.Text)) Then
            Mensajes.ErrorSimple("La caja no existe o no pertenece a esta sucursal")
            txtCaja.Focus()
            txtCaja.Clear()
        End If
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        ' Chequear que la sucursal exista y que la caja pertenezca a la sucursal indicada
        Dim suc = New Sucursal(txtSucursal.Text)
        Dim caj = New Caja(txtCaja.Text)

        If caj.Abierta = Nothing Then
            Mensajes.ErrorSimple(T("La caja no está abierta.", "The register is not open."))
            Return
        End If

        If suc.EsValido() = False Or caj.EsValido() = False Then
            Mensajes.ErrorSimple(T("La caja o sucursal indicada es invalida.", "The register or branch is invalid"))
            Return
        End If

        If Not (caj.NumSuc = suc.NumSuc) Then
            Mensajes.ErrorSimple(T("La caja no coincide con la sucursal.", "The register does not belong to this branch."))
            Return
        End If

        If Not (txtSaldoUYU.Text <> "" And txtSaldoUSD.Text <> "") Then
            Mensajes.ErrorSimple(T("Complete los campos faltantes.", "Fill the remaining fields"))
            Return
        End If

        Dim est = New Estado()

        est.SaldoUSD = txtSaldoUSD.Text
        est.SaldoUYU = txtSaldoUYU.Text
        est.NumCaja = caj.Num
        est.Tipo = "CIERRE"
        est.Fecha = Date.Today.ToString(FormatoFecha())

        est.Guardar()

        Mensajes.Simple(T("La caja se cerró correctamente. Numero de cierre: ", "The register has been closed successfully. Close ID: ") & est.IdE)

        Autenticacion.cajaAbierta = Nothing
        Autenticacion.sucursalCajaAbierta = Nothing
        Autenticacion.estadoCaja = Nothing

        caj.CerrarCaja()
        Auditoria.RegistrarAccion("Cierre de caja", String.Format("caja={0};saldouyu={1};saldousd={2}", txtCaja.Text, txtSaldoUYU.Text, txtSaldoUSD.Text))

        Me.Close()
    End Sub
End Class