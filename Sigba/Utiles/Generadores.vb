Module Generadores
    Function NumeroAleatorio()
        Return CInt(Math.Ceiling(Rnd() * 9))
    End Function

    Function NumeroAleatorioStr() As String
        Return NumeroAleatorio().ToString()
    End Function


    Function CodigoRecuperacionAleatorio()
        Return NumeroAleatorioStr() & NumeroAleatorioStr() & NumeroAleatorioStr() & "-" & NumeroAleatorioStr() & NumeroAleatorioStr() & NumeroAleatorioStr()
    End Function

    Sub RellenarComboBoxAnio(ByRef combo As ComboBox)
        Dim minimoEdad = 14
        Dim contador = Date.Today.Year() - minimoEdad
        Dim objetivo = contador - 120


        While contador > objetivo
            combo.Items.Add(contador)
            contador -= 1
        End While
    End Sub
End Module
