Public Class frmEdicionCargo
    Public Enum ComportamientoEdicionCargo
        Nuevo = 0
        Existente = 1
    End Enum

    Dim modoEdicion = ComportamientoEdicionCargo.Nuevo

    Public Sub EditarCargo(ByVal id As Integer, ByVal nombre As String)
        Me.modoEdicion = ComportamientoEdicionCargo.Existente
        txtIdCargo.Text = Convert.ToString(id)
        txtNombreCargo.Text = nombre
        Me.Text = "Editar cargo: " & id & " - " & nombre
    End Sub

    Private Sub frmEdicionCargo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Nuevo cargo"

        dgvUsuarios.Rows.Add("1.234.567-8", "Mellado", "Nicolas Santiago", "02/12/2016")
        dgvUsuarios.Rows.Add("5.019.990-8", "Correa Sosa", "Franco Agustin", "02/12/2016")
    End Sub
End Class