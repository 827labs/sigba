﻿Public Class frmATMDeposito
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If txtMonto.TextLength = 0 Then
            lblTitulo.Text = "Ingrese un monto"
        ElseIf Val(txtMonto.Text) < 1 Then
            lblTitulo.Text = "Ingrese un monto mayor a cero"
        ElseIf Val(txtMonto.Text) < 500 Then
            lblTitulo.Text = "Ingrese un monto mayor a 500"
        Else
            btnContinuar.Visible = False
            txtMonto.Visible = False
            lblTitulo.Text = "Ingrese el sobre y finalice"
            btnCancelar.Text = "FINALIZAR"
            btnCancelar.Height += 20
            Dim monedaCuenta = Autenticacion.cuentaATM.Split(" ")(1)
            EfectuarDeposito(Autenticacion.cuentaATM, monedaCuenta, txtMonto.Text, True)
        End If
    End Sub

    Private Sub frmATMDeposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCuenta.Text = Autenticacion.cuentaATM
    End Sub
End Class