Module Desarrollo
    ' Si esta variable está igualada a True,
    ' el sistema podrá tener activadas ciertas
    ' caracteristicas que ayudan a lograr mayor
    ' productividad a la hora del desarrollo del mismo.
    Dim modoDesarrollo As Boolean = False


    Function ModoDesarrolloActivado() As Boolean
        Return modoDesarrollo
    End Function

End Module
