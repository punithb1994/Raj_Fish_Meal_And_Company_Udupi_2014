Public Class frmsalesinvoice
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt6
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class