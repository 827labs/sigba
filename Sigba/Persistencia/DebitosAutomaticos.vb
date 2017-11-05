Imports System.Data.Odbc

Module DebitosAutomaticos

    Function CrearDebitoAutomatico(ByVal empresa As String, ByVal asunto As String, ByVal diaMes As Integer, ByVal moneda As String, ByVal monto As String, ByVal cuentaCompleto As String, ByVal telEmpresa As String) As Integer
        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim idcuenta = cuentaCompleto.Split(" ")(2)
        Dim cm = New OdbcCommand(String.Format("INSERT INTO debitoautomatico (empresa, asunto, idcuenta, telempresa, diacobro, monto, moneda) VALUES ('{0}', '{1}', {2}, '{3}', {4}, {5}, '{6}')", empresa, asunto, idcuenta, telEmpresa, diaMes, monto, moneda), cx)

        Return cm.ExecuteNonQuery() > 0
    End Function

    Sub CompletarDGVDebitos(ByVal nroCuentaCompleto As String, ByRef dgv As DataGridView)
        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim idcuenta = nroCuentaCompleto.Split(" ")(2)
        Dim cm = New OdbcCommand(String.Format("SELECT numdeb, empresa, telempresa, asunto, moneda, monto, diacobro FROM debitoautomatico WHERE idcuenta='{0}'", idcuenta), cx)

        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        da.Fill(ds, "debitoautomatico")

        dgv.DataSource = ds.Tables("debitoautomatico")

        With dgv
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(1).HeaderCell.Value = T("Empresa", "Company")
            .Columns(2).HeaderCell.Value = T("Telefono", "Phone")
            .Columns(3).HeaderCell.Value = T("Asunto", "Reason")
            .Columns(4).HeaderCell.Value = T("Moneda", "Currency")
            .Columns(5).HeaderCell.Value = T("Monto", "Amount")
            .Columns(6).HeaderCell.Value = T("Dia de cobro", "Day of the month")
        End With
    End Sub


    Function Eliminar(ByVal id As Integer) As Boolean
        Dim cx = ConexionBaseDatos.ObtenerActual
        Dim cm = New OdbcCommand(String.Format("DELETE FROM debitoautomatico WHERE numdeb={0}", id), cx)

        Return cm.ExecuteNonQuery() > 0
    End Function


End Module
