Imports System.Globalization

Public Class frmSeteoCotizacionATMManual

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If Not (txtEURCot.Text <> "" And txtUSDCot.Text <> "") Then
            Mensajes.ErrorSimple("Debe completar ambos camoos.")
        End If

        Try
            Cotizaciones.cotEUR = Convert.ToDecimal(txtEURCot.Text)
            Cotizaciones.cotUSD = Convert.ToDecimal(txtUSDCot.Text)
            Me.Close()
        Catch ex As Exception
            Mensajes.ErrorSimple("Asegurese de haber ingresado solo números en los campos.")
        End Try


    End Sub

    Private Sub frmSeteoCotizacionManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (ModoDesarrolloActivado()) Then
            txtEURCot.Text = "34.5"
            txtUSDCot.Text = "29.74"
        End If
        System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo(Autenticacion.idioma)
    End Sub
End Class