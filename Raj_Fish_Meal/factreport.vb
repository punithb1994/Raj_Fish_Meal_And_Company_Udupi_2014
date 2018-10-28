Public Class factreport
    
    Private Sub CrystalReportViewer1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt1
        Me.CrystalReportViewer1.RefreshReport()
        'factconsumrpt.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmdihome.onlyone()
        frmmdihome.Panel2.Visible = True
        frmmdihome.Panel1.BringToFront()
        frmmdihome.btnhome.Visible = False
        Me.Close()
    End Sub

    Private Sub factreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.Default
    End Sub
End Class