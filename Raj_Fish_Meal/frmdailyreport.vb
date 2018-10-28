Public Class frmdailyreport
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt4
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmdihome.onlyone()
        frmmdihome.Panel2.Visible = True
        frmmdihome.Panel1.BringToFront()
        frmmdihome.btnhome.Visible = False
        Me.Close()
    End Sub
End Class