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

End Module
