﻿Public Class frmATMRetiro

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If txtMonto.TextLength = 0 Then
            lblTitulo.Text = "Ingrese un monto"
        ElseIf Val(txtMonto.Text) < 1 Then
            lblTitulo.Text = "Ingrese un monto mayor a cero"
        ElseIf Not Val(txtMonto.Text) Mod 100 = 0 Then
            lblTitulo.Text = "Ingrese un monto que sea multiplo de 100"
        Else
            Dim saldoCuenta = ObtenerSaldoCuenta(Autenticacion.cuentaATM).Split(" ")(1)
            Dim banco = New Banco()
            Dim monedaCuenta = Autenticacion.cuentaATM.Split(" ")(1)
            If ObtenerMontoNormalizado(txtMonto.Text, monedaCuenta) < banco.LimiteRetiroCajeroDependenciasPesos Then
                If saldoCuenta > Val(txtMonto.Text) Then
                    btnContinuar.Visible = False
                    txtMonto.Visible = False
                    lblTitulo.Text = "Retire el dinero"
                    picRetiro.Visible = True
                    btnCancelar.Text = "FINALIZAR"
                    btnCancelar.Height += 20


                    EfectuarRetiro(Autenticacion.cuentaATM, monedaCuenta, txtMonto.Text)
                Else
                    lblTitulo.Text = "Saldo insuficiente, ingrese un monto menor"
                End If
            Else
                lblTitulo.Text = "Monto excede limite preestablecido"
            End If
        End If
    End Sub
End Class