Imports System.Data.Odbc
Module Sucursales
    Sub ObtenerSucursales(ByRef dgv As DataGridView)
        Dim cx = ConexionBaseDatos.ObtenerActual()
        Dim cm = New OdbcCommand("SELECT numsuc, nombresuc, calledirsuc, nrodirsuc, horario FROM sucursal", cx)
        Dim da = New OdbcDataAdapter(cm)
        Dim ds = New DataSet
        cm.ExecuteNonQuery()
        da.Fill(ds, "sucursal")

        dgv.DataSource = ds.Tables("sucursal")
        With dgv
            .Columns(0).HeaderCell.Value = "No"
            .Columns(1).HeaderCell.Value = "Nombre"
            .Columns(2).HeaderCell.Value = "Calle"
            .Columns(3).HeaderCell.Value = "Numero"
            .Columns(4).HeaderCell.Value = "Horario"
        End With
    End Sub
End Module
