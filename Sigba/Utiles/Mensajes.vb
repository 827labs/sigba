Public Module Mensajes
    Public Sub Simple(ByVal mensaje As String)
        MessageBox.Show(mensaje, "SIGBA", MessageBoxButtons.OK)
    End Sub

    Public Sub ErrorSimple(ByVal mensaje As String)
        MessageBox.Show(mensaje, "Error - SIGBA", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function PreguntaSiNo(ByVal pregunta As String, ByVal titulo As String) As Boolean
        Dim respuesta = MessageBox.Show(pregunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Return (respuesta = DialogResult.Yes)
    End Function

End Module
