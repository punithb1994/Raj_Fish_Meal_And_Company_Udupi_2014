Public Class removeemployee
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Sub eidload()
        Dim dt1 As New DataTable
        If Me.cmbempidwise.Text = "" Then
            Me.DataGridView1.Enabled = False
            Me.btnremoveinfo.Enabled = False
        End If
        cnnstr.Close()
        connect()
        issuecommand.CommandText = "select empid from employee where status=0"
        da.SelectCommand = issuecommand
        dt1.Clear()
        da.Fill(dt1)
        Dim i As Integer
        Me.cmbempidwise.Items.Clear()

        For i = 0 To dt1.Rows.Count - 1
            If dt1.Rows(i).Item(0) <> "0" Then
                Me.cmbempidwise.Items.Add(dt1.Rows(i).Item(0))
            End If
        Next
    End Sub
    Private Sub removeemployee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub removeemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Me.cmbempidwise, "Select employee id to delete employee information")
        ToolTip1.SetToolTip(Me.btnremoveinfo, "Click here to delete selected employee information")
        Try
            connect()
            eidload()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbempidwise_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbempidwise.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub cmbempidwise_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbempidwise.SelectedIndexChanged
        Dim dt As New DataTable
        Me.DataGridView1.Enabled = True
        Me.btnremoveinfo.Enabled = True
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from employee where empid='" & Me.cmbempidwise.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnremoveinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremoveinfo.Click
        
        Try
            Dim res = MsgBox("Are you sure to remove employee information", MsgBoxStyle.YesNo, "Remove Employee")
            If res = vbYes Then
                connect()
                issuecommand.CommandText = "update employee set status=1 where empid='" & Me.cmbempidwise.Text & "'"
                issuecommand.ExecuteNonQuery()
                eidload()
                Me.cmbempidwise.Text = ""
                Me.DataGridView1.Refresh()
            End If
            cmbempidwise_SelectedIndexChanged(sender, e)
            Me.DataGridView1.Enabled = False
            Me.btnremoveinfo.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
End Class

    