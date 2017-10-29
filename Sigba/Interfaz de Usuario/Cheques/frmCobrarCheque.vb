Imports System.Data.Odbc

Public Class frmCobrarCheque

    Private Sub frmCobrarCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPaisDoc.Items.AddRange(Constantes.Paises())
        cboPaisDoc.SelectedIndex = 187
        cboTipoDoc.SelectedIndex = 0
    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        Validadores.KeyPressDocumento(e, cboTipoDoc, txtNroDoc)
    End Sub

    Private Sub txtFechaEmision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaEmision.TextChanged
        If cboTipoCheque.SelectedIndex = 0 Then
            txtFechaCobro.Enabled = False
            txtFechaCobro.Text = txtFechaEmision.Text
        ElseIf cboTipoCheque.SelectedIndex = 1 Then
            txtFechaCobro.Enabled = True
        Else
            txtFechaCobro.Enabled = False
            txtFechaCobro.Text = txtFechaEmision.Text
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Function Cobrar() As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("update cheque set fechaemisionche='{0}', fechahabilitacobroche='{1}', monedache='{2}', montoche={3}, numdoccobr='{4}', tipodoccobr='{5}', paisdoccobr='{6}', tipoche='{7}' where numlib={8} and serielib={9} and numche={10}", txtFechaEmision.Text, txtFechaCobro.Text, cboMontoMoneda.Text.Substring(0, 3), txtMontoCantidad.Text, txtNroDoc.Text, cboTipoDoc.Text, cboPaisDoc.Text, cboTipoCheque.Text.Substring(0, 3), txtNumLibreta.Text, txtNumSerie.Text, txtNumCheque.Text), cx)

        Try
            If cm.ExecuteNonQuery <= 0 Then
                Mensajes.ErrorSimple(T("No se encontro el cheque en el sistema.", "We couldn't find the check in the system"))
                Return False
            End If
        Catch ex As Exception
            Mensajes.ErrorSimple(T("Ha ocurrido un error inesperado", "An unexpected error has occured") & ": " & ex.Message)
            Return False
        End Try

        cm = New OdbcCommand(String.Format("select idcuenta from libreta where serie={0} and numlib={1}", txtNumSerie.Text, txtNumLibreta.Text), cx)
        Dim idcuenta = cm.ExecuteScalar()

        If idcuenta = Nothing Then
            Mensajes.ErrorSimple(T("La libreta ha sido anulada o no existe", "The checkbook has been canceled or does not exist"))
            Return False
        End If

        cm = New OdbcCommand(String.Format("select moneda from cuenta where idcuenta=(select idcuenta from libreta where serie={0} and numlib={1})", txtNumSerie.Text, txtNumLibreta.Text), cx)
        Dim monedaCuenta = cm.ExecuteScalar()

        cm = New OdbcCommand(String.Format("select saldo from cuenta where idcuenta=(select idcuenta from libreta where serie={0} and numlib={1})", txtNumSerie.Text, txtNumLibreta.Text), cx)
        Dim saldoCuenta = cm.ExecuteScalar()

        Dim montoADebitar = ObtenerMontoNormalizado(txtMontoCantidad.Text, cboMontoMoneda.Text.Substring(0, 3), monedaCuenta)

        If saldoCuenta < montoADebitar Then
            Mensajes.ErrorSimple(T("La cuenta no posee los fondos suficientes para cobrar el cheque", "The account does not have enough funds."))
            Return False
        End If

        cm = New OdbcCommand(String.Format("select tipo || ' ' || moneda || ' ' || idcuenta from cuenta where idcuenta=(select idcuenta from libreta where serie={0} and numlib={1})", txtNumSerie.Text, txtNumLibreta.Text), cx)
        Dim nrocuentacompleto = cm.ExecuteScalar()

        NuevoMovimiento(String.Format("COBRO CHEQUE {0}-{1}-{2}", txtNumSerie.Text, txtNumLibreta.Text, txtNumCheque.Text), -1 * montoADebitar, nrocuentacompleto)

        cm = New OdbcCommand(String.Format("update cuenta set saldo={0} where idcuenta={1}", saldoCuenta - montoADebitar, idcuenta), cx)
        cm.ExecuteNonQuery()

        Return True
    End Function


    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If ( _
            cboTipoCheque.Text <> "" _
            And cboTipoCobro.Text <> "" _
            And txtFechaEmision.Text <> "__/__/____" _
            And txtFechaCobro.Text <> "__/__/____" _
            And cboPaisDoc.Text <> "" _
            And cboTipoDoc.Text <> "" _
            And txtNroDoc.Text <> "" _
            And cboMontoMoneda.Text <> "" _
            And txtMontoCantidad.Text <> "" _
            And Val(txtMontoCantidad.Text) <> 0 _
            And txtNumLibreta.Text <> "" _
            And txtNumSerie.Text <> "" _
            And txtNumCheque.Text <> "") Then

            If MessageBox.Show("¿Desea confirmar el cobro del cheque?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then


                If Cobrar() Then
                    MessageBox.Show("Transacción completada existosamente")
                    Me.Close()
                End If


            End If
        Else
            MessageBox.Show("Compruebe los campos")
        End If
    End Sub
End Class