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

    Function StringHoraActual() As String
        Dim fecha = Date.Now()
        Dim horaActual = fecha.Hour.ToString()
        Dim minutoActual = fecha.Minute.ToString()

        If fecha.Hour < 10 Then
            horaActual = "0" & horaActual
        End If

        If fecha.Minute < 10 Then
            minutoActual = "0" & minutoActual
        End If

        Return horaActual & ":" & minutoActual
    End Function

    Function StringFechaActual() As String
        Dim fecha = Date.Now()

        Dim dia = fecha.Day.ToString()
        Dim mes = fecha.Month.ToString()
        Dim anio = fecha.Year.ToString()

        If fecha.Day < 10 Then
            dia = "0" & dia
        End If

        If fecha.Month < 10 Then
            mes = "0" & mes
        End If

        Return dia & "/" & mes & "/" & anio
    End Function
End Module
