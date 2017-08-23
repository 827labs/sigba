Public Module Mensajes
    Public Sub Simple(ByVal mensaje As String)
        MessageBox.Show(mensaje, "SIGBA", MessageBoxButtons.OK)
    End Sub

    Public Sub ErrorSimple(ByVal mensaje As String)
        MessageBox.Show(mensaje, "Error - SIGBA", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Module
