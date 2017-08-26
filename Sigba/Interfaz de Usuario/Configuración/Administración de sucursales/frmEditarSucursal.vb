Public Class frmEditarSucursal

    Dim modoForm = Modo.Agregar
    Dim sucursal As New Sucursal()

    Public Enum Modo
        Agregar = 0
        Editar = 1
    End Enum

    Public Sub SetEditar(ByVal id As Integer)
        Me.sucursal = New Sucursal(id)
        Me.modoForm = Modo.Editar
    End Sub

    Private Sub frmEditarSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNumero.Text = Me.sucursal.NumSuc
        txtNombre.Text = Me.sucursal.NombreSuc
        txtDirCalle.Text = Me.sucursal.CalleDirSuc
        txtDirNumero.Text = Me.sucursal.NroDirSuc
        txtHorario.Text = Me.sucursal.Horario


        txtNumero.Enabled = False
    End Sub

    Private Sub btnAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccion.Click
        Me.sucursal.NumSuc = txtNumero.Text
        Me.sucursal.NombreSuc = txtNombre.Text
        Me.sucursal.CalleDirSuc = txtDirCalle.Text
        Me.sucursal.NroDirSuc = txtDirNumero.Text
        Me.sucursal.Horario = txtHorario.Text

        Dim pudoGuardar = Me.sucursal.Guardar()
        If pudoGuardar Then
            Me.Close()
        End If
    End Sub
End Class