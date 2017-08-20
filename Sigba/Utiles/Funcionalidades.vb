Module Funcionalidades
    Dim funcs As Funcionalidad() = New Funcionalidad() { _
        New Funcionalidad("Funcionalidad de Prueba 1"), _
        New Funcionalidad("Funcionalidad de Prueba 2"), _
        New Funcionalidad("Funcionalidad de Prueba 3"), _
        New Funcionalidad("Funcionalidad de Prueba 4"), _
        New Funcionalidad("Funcionalidad de Prueba 5"), _
        New Funcionalidad("Funcionalidad de Prueba 6"), _
        New Funcionalidad("Funcionalidad de Prueba 7"), _
        New Funcionalidad("Funcionalidad de Prueba 8"), _
        New Funcionalidad("Funcionalidad de Prueba 9"), _
        New Funcionalidad("Funcionalidad de Prueba 10") _
    }

    Public Function Funcionalidades() As Funcionalidad()
        Return funcs
    End Function
End Module
