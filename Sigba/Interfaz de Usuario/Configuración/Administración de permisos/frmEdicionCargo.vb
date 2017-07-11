Public Class frmEdicionCargo
    Public Enum ComportamientoEdicionCargo
        Nuevo = 0
        Existente = 1
    End Enum

    Dim modoEdicion = ComportamientoEdicionCargo.Nuevo

    Public Sub EditarCargo(ByVal id As Integer, ByVal nombre As String)
        Me.Text = "Editar cargo: " & id & " - " & nombre
        Me.modoEdicion = ComportamientoEdicionCargo.Existente
        txtIdCargo.Text = Convert.ToString(id)
        txtNombreCargo.Text = nombre
    End Sub

    Private Sub frmEdicionCargo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Cargo"

        dgvUsuarios.Rows.Add("1.234.567-8", "Mellado", "Nicolas Santiago", "02/12/2016")
        dgvUsuarios.Rows.Add("5.019.990-8", "Correa Sosa", "Franco Agustin", "02/12/2016")

        Dim funcs As Funcionalidad() = Funcionalidades.Funcionalidades()

        For i = 0 To UBound(funcs)
            dgvFuncionalidades.Rows.Add(True, funcs(i).nombre)
        Next
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not (txtNombreCargo.Text <> "") Then
            MessageBox.Show("Compruebe los campos")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Está seguro? Esta acción es irreversible y los usuarios en este cargo serán removidos a el cargo más cercano.", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("El cargo se ha eliminado exitosamente.")
            Me.Close()
        End If
    End Sub
End Class