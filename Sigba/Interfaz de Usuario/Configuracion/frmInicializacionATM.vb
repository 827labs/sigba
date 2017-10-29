Imports System.Data.Odbc

Public Class frmInicializacionATM

    Private Sub frmInicializacionATM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Cotizaciones.cotEUR <> Nothing Then
            txtCotizacionEUR.Text = Cotizaciones.cotEUR
        End If

        If Cotizaciones.cotUSD <> Nothing Then
            txtCotizaciónUSD.Text = Cotizaciones.cotUSD
        End If
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Try
            Convert.ToInt32(txtNumCajero.Text)

            Convert.ToDecimal(txtDineroUYU.Text)
            Convert.ToDecimal(txtDineroUSD.Text)
            Convert.ToDecimal(txtCotizacionEUR.Text)
            Convert.ToDecimal(txtCotizaciónUSD.Text)
        Catch ex As Exception
            Mensajes.ErrorSimple(T("Verifique los valores ingresados.", "Check out the entered values."))
            Return
        End Try

        Cotizaciones.cotEUR = txtCotizacionEUR.Text
        Cotizaciones.cotUSD = txtCotizaciónUSD.Text

        Dim dinero = Convert.ToDecimal(txtDineroUYU.Text) + ObtenerMontoNormalizado(txtDineroUSD.Text, "USD", "UYU")

        ' Buscar si existe un cajero con el número ingresado
        Dim usuario, clave
        If ModoDesarrolloActivado() Then
            usuario = "informix"
            clave = "informix"
        Else
            usuario = "fcorrea"
            clave = "50199908"
        End If

        Dim cx = ConexionBaseDatos.ObtenerActual(usuario, clave)
        Dim cm = New OdbcCommand(String.Format("UPDATE cajeroautomatico SET dinero={0} WHERE numcaj={1};", dinero, txtNumCajero.Text), cx)

        If (cm.ExecuteNonQuery > 0) Then
            Autenticacion.numATMActivo = txtNumCajero.Text
            Me.Close()
        Else
            Mensajes.ErrorSimple(T("El número de cajero no ha sido encontrado.", "The ATM number you entered has not been found in the database."))
        End If
    End Sub
End Class