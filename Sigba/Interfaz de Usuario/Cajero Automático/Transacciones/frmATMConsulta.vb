Public Class frmATMConsulta

    Private Sub frmATMConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvTransacciones.Rows.Add("83", "20/06/2017", "CINE MOVIE MONTEVID", "9475764", "-662,54", "", "21.173,46")
        dgvTransacciones.Rows.Add("1", "20/06/2017", "PSS/SUELDOS/3651748", "9364654", "", "9.377,00", "21.836,00")
        dgvTransacciones.Rows.Add("83", "20/06/2017", "MC DONALD'S MONTEVID", "9448844", "-115,78", "", "12.459,00")
        dgvTransacciones.Rows.Add("83", "20/06/2017", "MC DONALD'S MONTEVID", "9147387", "-349,19", "", "12.574,78")
        dgvTransacciones.Rows.Add("84", "14/06/2017", "MC DONALD'S MONTEVID", "9073676", "-55,58", "", "12.923,97")
        dgvTransacciones.Rows.Add("1", "13/06/2017", "PAGANZA - 5841852", "8778775", "-2.500,00", "", "12.979,55")
        dgvTransacciones.Rows.Add("84", "12/06/2017", "TIENDA SELECT MAESTRO MONTEVID", "9747783", "-1.354,10", "", "15.479,55")
        dgvTransacciones.Rows.Add("82", "11/06/2017", "INT. CAMPERA", "2005274", "-350,00", "", "16.833,65")
        dgvTransacciones.Rows.Add("83", "05/06/2017", "SUPERMARKET EL DORADO SAN CARL", "9757572", "-1.159,69", "", "17.183,65")
        dgvTransacciones.Rows.Add("83", "05/06/2017", "SUPERMARKET EL DORADO SAN CARL", "9790737", "-316,28", "", "18.343,34")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
    End Sub
End Class