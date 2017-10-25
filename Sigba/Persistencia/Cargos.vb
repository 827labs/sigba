Imports System.Data.Odbc

Module Cargos
    Public Sub ListarCargos(ByRef dgv As DataGridView)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand
        cm.Connection = cx
        cm.CommandText = "select idcargo, nombre from cargo ORDER BY idcargo DESC"

        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet()
        da.Fill(ds, "cargo")

        dgv.DataSource = ds.Tables("cargo")

        With dgv
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(1).HeaderCell.Value = T("Nombre", "Name")
        End With
    End Sub
End Module
