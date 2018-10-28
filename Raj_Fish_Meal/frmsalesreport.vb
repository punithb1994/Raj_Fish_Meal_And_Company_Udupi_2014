Public Class frmsalesreport

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmdihome.onlyone()
        frmmdihome.Panel2.Visible = True
        frmmdihome.Panel1.BringToFront()
        frmmdihome.btnhome.Visible = False
        Me.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt7
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class