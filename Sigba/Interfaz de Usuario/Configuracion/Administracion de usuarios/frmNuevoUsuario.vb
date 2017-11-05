Imports System.Data.Odbc

Public Class frmNuevoUsuario

    Private editando As Boolean = False

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If txtNombres.Text <> "" And txtApellidos.Text <> "" And txtCedula.Text <> "" And txtCorreo.Text <> "" And Validadores.EsEmailValido(txtCorreo.Text) Then
            If Not Me.editando Then
                Dim codUsuario = Usuarios.CrearUsuario(txtCedula.Text, txtCorreo.Text, txtNombres.Text, txtApellidos.Text, txtUsuario.Text)
                AsignarCargoAUsuario()
                If codUsuario Then
                    Mensajes.Simple(T("El usuario ha sido ingresado exitosamente.", "The user has been registered successfully"))
                End If

            Else
                Dim cx = ConexionBaseDatos.ObtenerActual()
                Dim cm = New OdbcCommand(String.Format("update usuario set nombre='{0}', apellido='{1}', nomusuariosou='{2}', emailu='{3}' where numdocu={4}", txtNombres.Text, txtApellidos.Text, txtUsuario.Text, txtCorreo.Text, txtCedula.Text), cx)
                AsignarCargoAUsuario()

                If cm.ExecuteNonQuery() > 0 Then
                    Mensajes.Simple(T("Usuario actualizado correctamente", "The user has been updated successfully"))
                    RegistrarAccion("Editar datos usuario", "numdocu=" & txtCedula.Text)
                    Me.Close()
                Else
                    Mensajes.ErrorSimple(T("No se pudo actualizar el usuario, contacte a soporte.", "We couldn't update user details, please contact support."))
                End If
            End If
        Else
            Mensajes.ErrorSimple("Complete todos los campos correctamente")
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        Validadores.KeyPressSoloNumeros(e)
        txtCedula.MaxLength = 8
    End Sub

    Public Sub SetearUsuarioEdicion(ByVal numdocu As String)
        Dim u = New Usuario(numdocu)
        txtNombres.Text = u.Nombre
        txtApellidos.Text = u.Apellido
        txtCedula.Text = u.NumDocU
        txtCedula.Enabled = False
        txtUsuario.Text = u.NomUsuarioSOU
        txtCorreo.Text = u.EmailU
        Me.editando = True
        Me.Text = T("Editar usuario", "Edit user")
        Me.lblTitulo.Text = T("Editar usuario", "Edit user")

        btnSuspender.Visible = True
        btnLimpiar.Visible = False

        If u.EstaSuspendido() Then
            btnSuspender.Text = T("Habiltar", "Enable")
        End If

        btnIngresar.Text = "OK"
        SetearCargoEnCombo()
    End Sub

    Private Sub btnSuspender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuspender.Click
        Dim u = New Usuario(txtUsuario.Text)
        Dim cx = ConexionBaseDatos.ObtenerActual()

        If u.EstaSuspendido() Then
            Dim cm = New OdbcCommand(String.Format("update usuario set suspendido=NULL where numdocu='{0}'", txtCedula.Text), cx)

            If cm.ExecuteNonQuery() > 0 Then
                Mensajes.Simple(T("Usuario habilitado correctamente", "The user has been re-enabled successfully"))
                RegistrarAccion("Habilitar usuario", String.Format("numdocu={0}", txtCedula.Text))
            Else
                Mensajes.ErrorSimple(T("No se pudo habilitar al usuario. Contacte a soporte.", "We coudn't re-enable the user, please contact support."))
            End If
        Else
            Dim fecha = Date.Today().ToString("dd/MM/yyyy")
            Dim cm = New OdbcCommand(String.Format("update usuario set suspendido='{0}' where numdocu='{1}'", fecha, txtCedula.Text), cx)

            If cm.ExecuteNonQuery() > 0 Then
                Mensajes.Simple(T("Usuario suspendido correctamente", "The user has been suspended"))
                RegistrarAccion("Suspender usuario", String.Format("numdocu={0}", txtCedula.Text))
            Else
                Mensajes.ErrorSimple(T("No se pudo suspender al usuario. Contacte a soporte.", "We couldn't suspend the user, please contact support."))
            End If
        End If
    End Sub

    Private Sub frmNuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("select idcargo id, nombre from cargo", cx)
        Dim reader = cm.ExecuteReader()

        While reader.Read()
            cboCargo.Items.Add(String.Format("{0} - {1}", reader("id"), reader("nombre")))
        End While
    End Sub

    Private Sub SetearCargoEnCombo()
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand(String.Format("select idcargo id from ejerce where numdocu={0}", txtCedula.Text), cx)

        Dim idcargo As String = cm.ExecuteScalar()

        If idcargo = "" Then
            Return
        End If

        If idcargo >= 0 Then
            cboCargo.SelectedIndex = cboCargo.FindString(idcargo & " - ")
        Else
            Mensajes.ErrorSimple("no se encontro cargos ameo")
        End If
    End Sub

    Private Sub AsignarCargoAUsuario()
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("delete from ejerce where numdocu=" & txtCedula.Text, cx)
        cm.ExecuteNonQuery()

        Dim idcargo = cboCargo.Text.Split(" - ")(0)
        cm = New OdbcCommand(String.Format("insert into ejerce (numdocu, idcargo, asignado) values ({0}, {1}, '{2}');", txtCedula.Text, idcargo, Date.Today.ToString(FormatoFecha())), cx)
        cm.ExecuteNonQuery()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtApellidos.Clear()
        txtNombres.Clear()

        If txtCedula.Enabled Then
            txtCedula.Clear()
        End If

        txtCorreo.Clear()
        txtUsuario.Clear()
        cboCargo.SelectedIndex = -1
    End Sub
End Class