Public Class employeedetails
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim sel As String
    Private Sub employeedetails_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub btnviewindividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewindividual.Click
        Me.btnviewindividual.Enabled = False
        Me.btnviewall.Enabled = True
        Me.RadioButton1.Visible = True
        Me.RadioButton2.Visible = True
        Me.RadioButton3.Visible = False
        Me.RadioButton4.Visible = False
        Me.DataGridView2.Visible = True
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            Me.ComboBox1.Visible = True
            Me.DataGridView2.Visible = True
            Me.ComboBox1.Text = ""
            sel = "empid"
            connect()
            Dim dt As New DataTable
            issuecommand.CommandText = "select empid from employee"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.ComboBox1.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item(0) <> "0" Then
                    Me.ComboBox1.Items.Add(dt.Rows(i).Item(0))
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            Me.ComboBox1.Visible = True
            Me.DataGridView2.Visible = True
            Me.ComboBox1.Text = ""
            sel = "empname"
            connect()
            Dim dt2 As New DataTable
            issuecommand.CommandText = "select empname from employee"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Dim i As Integer
            Me.ComboBox1.Items.Clear()
            For i = 1 To dt2.Rows.Count - 1
                If dt2.Rows(i).Item(0) <> "0" Then
                    Me.ComboBox1.Items.Add(dt2.Rows(i).Item(0))
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnviewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        Try
            Me.btnviewall.Enabled = False
            Me.btnviewindividual.Enabled = True
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton1.Checked = False
            Me.RadioButton1.Checked = False
            Me.RadioButton3.Visible = True
            Me.RadioButton4.Visible = True
            Me.ComboBox1.Visible = False
            Me.DataGridView2.Visible = False
            connect()
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select * from employee"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim dt3 As New DataTable
        Me.DataGridView2.Visible = False
        Try
            connect()
            issuecommand.CommandText = "select * from employee where " & sel & "='" & Me.ComboBox1.Text & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            Me.DataGridView1.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub employeedetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.btnviewindividual, "View individual employee details")
        ToolTip1.SetToolTip(Me.btnviewall, "View all employee details")
        ToolTip1.SetToolTip(Me.RadioButton1, "View employee by id")
        ToolTip1.SetToolTip(Me.RadioButton2, "View employee by name")
        ToolTip1.SetToolTip(Me.ComboBox1, "Select to view details")
        Me.DataGridView1.ReadOnly = True
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Try
            connect()
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select * from employee where status=0"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Try
            connect()
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select * from employee where status=1"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
End Class