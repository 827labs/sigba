Imports System.Data.Odbc

Public Class frmATMSolicitarPin

    Private Enum ResultadoValidacionPin
        Invalido = 0
        Valido = 1
        NecesitaCrear = 2
    End Enum

    Private Enum ModoVentana
        SolicitaPIN = 0
        CreacionPIN = 1
        ConfirmacionPIN = 2
    End Enum

    Private modo = ModoVentana.SolicitaPIN

    Private nuevoPin = ""
    Private nuevoPinConf = ""

    Private Sub ContinuarAutenticacion(ByVal usuario As Integer, ByVal pin As Integer)
        Autenticacion.usuarioATM = usuario
        Autenticacion.pinATM = pin

        Dim formc = New frmATMSelectorCuenta()
        formc.Show()
        Me.Hide()

    End Sub

    Private Function GuardarNuevoPIN(ByVal pin As String)
        Dim numdocp = Autenticacion.usuarioATM
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("UPDATE persona SET pinp='{0}' WHERE numdocp='{1}';", pin, numdocp), cx)
        cm.ExecuteNonQuery()
        Return True
    End Function

    Private Function VerificarUsuarioPIN() As ResultadoValidacionPin
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("SELECT COUNT(*) c FROM persona WHERE numdocp='{0}' AND pinp='{1}';", Autenticacion.usuarioATM, Autenticacion.pinATM), cx)
        Dim cmNull = New OdbcCommand(String.Format("SELECT COUNT(*) c FROM persona WHERE numdocp='{0}' AND pinp IS NULL;", Autenticacion.usuarioATM, Autenticacion.pinATM), cx)

        If Val(cm.ExecuteScalar) > 0 Then
            Return ResultadoValidacionPin.Valido
        End If

        If Val(cmNull.ExecuteScalar) > 0 Then
            Return ResultadoValidacionPin.NecesitaCrear
        End If

        Return ResultadoValidacionPin.Invalido
    End Function


    Private Sub ATM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub txtPIN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIN.KeyPress
        Validadores.KeyPressSoloNumeros(e)
        Validadores.KeyPressLongitudMaxima(e, txtPIN.Text, 6)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Autenticacion.usuarioATM = Nothing
        Autenticacion.pinATM = Nothing
        Dim formP = New frmATMBienvenido()
        formP.Show()
        Me.Hide()
    End Sub

    Private Sub txtPIN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPIN.TextChanged
        If txtPIN.TextLength = 6 Then
            Autenticacion.pinATM = txtPIN.Text
            If modo = ModoVentana.SolicitaPIN Then
                Dim validacionPIN = VerificarUsuarioPIN()
                If validacionPIN = ResultadoValidacionPin.Valido Then
                    ContinuarAutenticacion(Autenticacion.usuarioATM, Autenticacion.pinATM)
                ElseIf validacionPIN = ResultadoValidacionPin.Invalido Then
                    Autenticacion.usuarioATM = Nothing
                    Autenticacion.pinATM = Nothing
                    lblSubtitulo.Text = "PIN/Cliente inválido."
                    txtPIN.Clear()
                ElseIf validacionPIN = ResultadoValidacionPin.NecesitaCrear Then
                    lblSubtitulo.Text = "Su cuenta no tiene PIN, ingrese uno ahora."
                    modo = ModoVentana.CreacionPIN
                    txtPIN.Clear()
                Else
                    txtPIN.Clear()
                    Autenticacion.pinATM = Nothing
                    lblSubtitulo.Text = "Error inesperado."
                End If
            ElseIf modo = ModoVentana.CreacionPIN Then
                nuevoPin = txtPIN.Text
                modo = ModoVentana.ConfirmacionPIN
                lblSubtitulo.Text = "Confirme nuevo PIN"
                txtPIN.Clear()
            ElseIf modo = ModoVentana.ConfirmacionPIN Then
                nuevoPinConf = txtPIN.Text
                txtPIN.Clear()

                If nuevoPin = nuevoPinConf Then
                    If GuardarNuevoPIN(nuevoPinConf) Then
                        ContinuarAutenticacion(Autenticacion.usuarioATM, nuevoPinConf)
                    Else
                        lblSubtitulo.Text = "Error inesperado, contacte al banco."
                    End If
                Else
                    lblSubtitulo.Text = "Nuevo PIN no coincide, ingrese nuevo PIN."
                    modo = ModoVentana.CreacionPIN
                End If
            End If
        End If
    End Sub
End Class