Public Class frmemprpt
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmdihome.onlyone()
        frmmdihome.Panel2.Visible = True
        frmmdihome.Panel1.BringToFront()
        frmmdihome.btnhome.Visible = False
        Me.Close()
    End Sub

    Private Sub frmemprpt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select empid from employee where status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.ComboBox3.Items.Clear()
            For i = 1 To dt.Rows.Count - 1
                Me.ComboBox3.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Me.CrystalReportViewer1.Focus()
        Me.CrystalReportViewer1.Visible = True
        Me.CrystalReportViewer1.SelectionFormula = "{employee.empid}='" & Me.ComboBox3.Text & "'"
        Me.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.SelectionFormula = "{employee.empid}='E1'"
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class