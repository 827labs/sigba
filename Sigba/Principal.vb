Public Class Principal
    ' El formulario 'Principal' actúa como un menú de funcionalidades
    ' donde el usuario es libre de elegir a que sección del sistema quiere dirigirse.

    Private Sub Principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Si se cierra el formulario principal,
        ' terminar la ejecucion el programa.
        Application.Exit()
    End Sub

    Private Sub GestionarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarUsuariosToolStripMenuItem.Click
        frmGestionUsuarios.Show()
    End Sub

    Private Sub AdministraciónDeCargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraciónDeCargosToolStripMenuItem.Click
        frmGestionCargos.Show()
    End Sub

    Private Sub RecuperacionDeContraseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecuperacionDeContraseToolStripMenuItem.Click
        frmRecuperacionClaveEmisor.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem.Click
    End Sub
End Class