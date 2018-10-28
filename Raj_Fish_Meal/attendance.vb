Public Class attendance
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim sel, sel1 As String
    Dim work As Integer
    Private Sub attendance_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.cmbempid, "Select employee id to add attendance")
        ToolTip1.SetToolTip(Me.btnadd, "Add attendance for selected employee")
        ToolTip1.SetToolTip(Me.RadioButton1, "Usual shift")
        ToolTip1.SetToolTip(Me.RadioButton2, "Evening shift")
        ToolTip1.SetToolTip(Me.RadioButton3, "Night shift")
        ToolTip1.SetToolTip(Me.grbshifts, "Select shift")
        ToolTip1.SetToolTip(Me.txtempname, "Name")
        ToolTip1.SetToolTip(Me.txtempdesignation1, "Designation")
        ToolTip1.SetToolTip(Me.txtempdesignation2, "Department")
        Me.btnadd.Enabled = False
        Me.grbshifts.Enabled = False
        Me.Label3.Text = Today.Date
        Dim dt1 As New DataTable
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select empid from employee where status=0"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim i As Integer
            Me.cmbempid.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                If dt1.Rows(i).Item(0) <> "0" Then
                    Me.cmbempid.Items.Add(dt1.Rows(i).Item(0))
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbempid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbempid.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub cmbempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        Me.Label1.Visible = False
        Me.grbshifts.Enabled = True
        Me.RadioButton1.Enabled = True
        Me.RadioButton2.Enabled = True
        Me.RadioButton3.Enabled = True
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.RadioButton3.Checked = False
        Dim dt As New DataTable
        Dim ctr As Integer
        ctr = 0
        Try
            connect()
            issuecommand.CommandText = "select * from employee where empid='" & Me.cmbempid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtempname.Text = dt.Rows(0).Item(1)
            Me.txtempdesignation1.Text = dt.Rows(0).Item(10)
            If Me.txtempdesignation1.Text = "Manager" Then
                Me.txtempdesignation2.Text = dt.Rows(0).Item(11)
                Me.txtempdesignation2.Visible = True
            Else
                Me.txtempdesignation2.Visible = False
            End If
            Dim dt3 As New DataTable
            issuecommand.CommandText = "select eattendance from shifta where empid='" & Me.cmbempid.Text & "' AND attdate='" & Today.Date & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            'MsgBox(dt3.Rows.Count)
            If dt3.Rows.Count <> 0 Then
                'MsgBox(dt3.Rows(0).Item(0))
                If dt3.Rows(0).Item(0) = "P" Then
                    Me.RadioButton1.Enabled = False
                    'Me.lblshifta.Enabled = False
                    ctr += 1
                End If
            End If

            Dim dt4 As New DataTable
            issuecommand.CommandText = "select eattendance from shiftb where empid='" & Me.cmbempid.Text & "' AND attdate='" & Today.Date & "'"
            da.SelectCommand = issuecommand
            dt4.Clear()
            da.Fill(dt4)
            If dt4.Rows.Count <> 0 Then
                If dt4.Rows(0).Item(0) = "P" Then
                    'MsgBox(dt4.Rows(0).Item(0))
                    Me.RadioButton2.Enabled = False
                    'Me.lblshiftb.Enabled = False
                    ctr += 1
                End If
            End If

            Dim dt5 As New DataTable
            issuecommand.CommandText = "select eattendance from shiftc where empid='" & Me.cmbempid.Text & "' AND attdate='" & Today.Date & "'"
            da.SelectCommand = issuecommand
            dt5.Clear()
            da.Fill(dt5)

            If dt5.Rows.Count <> 0 Then
                If dt5.Rows(0).Item(0) = "P" Then
                    'MsgBox(dt5.Rows(0).Item(0))
                    Me.RadioButton3.Enabled = False
                    'Me.lblshiftc.Enabled = False
                    ctr += 1
                End If
            End If
            If ctr >= 2 Then
                Me.grbshifts.Enabled = False
                Me.Label1.ForeColor = Color.Firebrick
                Me.Label1.Text = "Employee can work in only two shifts.."
                Me.Label1.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            connect()
            issuecommand.CommandText = "insert into " & sel & " values(@empid,@attdate,@eattendance)"
            issuecommand.CommandType = CommandType.Text
            issuecommand.Parameters.Clear()
            issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = Me.cmbempid.Text
            issuecommand.Parameters.Add("@attdate", SqlDbType.DateTime).Value = Today.Date
            issuecommand.Parameters.Add("@eattendance", SqlDbType.VarChar).Value = "P"
            issuecommand.ExecuteNonQuery()
            Dim dt2 As New DataTable
            issuecommand.CommandText = "select * from attendance where empid='" & Me.cmbempid.Text & "' and work_month='" & DateAndTime.MonthName(Today.Month) & "' and work_year='" & Today.Year & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count = 0 Then
                issuecommand.CommandText = "insert into attendance values(@empid,@work_a,@work_b,@work_c,@work_month,@work_year)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = Me.cmbempid.Text
                issuecommand.Parameters.Add("@work_a", SqlDbType.Int).Value = 0
                issuecommand.Parameters.Add("@work_b", SqlDbType.Int).Value = 0
                issuecommand.Parameters.Add("@work_c", SqlDbType.Int).Value = 0
                issuecommand.Parameters.Add("@work_month", SqlDbType.VarChar).Value = DateAndTime.MonthName(Today.Month)
                issuecommand.Parameters.Add("@work_year", SqlDbType.BigInt).Value = Today.Year
                issuecommand.ExecuteNonQuery()
            End If
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select * from attendance where empid='" & Me.cmbempid.Text & "' and work_month='" & DateAndTime.MonthName(Today.Month) & "' and work_year='" & Today.Year & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If sel = "shifta" Then
                sel1 = "work_a"
                work = dt1.Rows(0).Item(1) + 1
            ElseIf sel = "shiftb" Then
                sel1 = "work_b"
                work = dt1.Rows(0).Item(2) + 1
            ElseIf sel = "shiftc" Then
                sel1 = "work_c"
                work = dt1.Rows(0).Item(3) + 1
            End If
            'Dim dt As New DataTable
            'issuecommand.CommandText = "select work_month,work_year from attendance where empid='" & Me.cmbempid.Text & "' and work_month='" & DateAndTime.MonthName(txtday.Value.Month) & "' and work_year='" & txtday.Value.Date.Year & "'"
            'da.SelectCommand = issuecommand
            'dt.Clear()
            'da.Fill(dt)
            'If dt.Rows(0).Item(0) = DateAndTime.MonthName(txtday.Value.Month) And dt.Rows(0).Item(1) = txtday.Value.Date.Year Then
            '    MsgBox("san")
            issuecommand.CommandText = "update attendance set " & sel1 & "=@w where empid=@empid and work_month=@work_month and work_year=@work_year"
            issuecommand.CommandType = CommandType.Text
            issuecommand.Parameters.Clear()
            issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = Me.cmbempid.Text
            issuecommand.Parameters.Add("@w", SqlDbType.Int).Value = work
            issuecommand.Parameters.Add("@work_month", SqlDbType.VarChar).Value = DateAndTime.MonthName(Today.Month)
            issuecommand.Parameters.Add("@work_year", SqlDbType.BigInt).Value = Today.Year
            issuecommand.ExecuteNonQuery()
            'Else
            '    issuecommand.CommandText = "update attendance set " & sel1 & "=@w where empid=@empid and work_month=@work_month and work_year=@work_year"
            '    issuecommand.CommandType = CommandType.Text
            '    issuecommand.Parameters.Clear()
            '    issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = Me.cmbempid.Text
            '    issuecommand.Parameters.Add("@w", SqlDbType.Int).Value = work
            '    issuecommand.Parameters.Add("@work_month", SqlDbType.VarChar).Value = DateAndTime.MonthName(txtday.Value.Month)
            '    issuecommand.Parameters.Add("@work_year", SqlDbType.BigInt).Value = txtday.Value.Year
            '    issuecommand.ExecuteNonQuery()
            'End If
            'MsgBox("Details saved successfully.")
            Me.Label1.ForeColor = Color.Green
            Me.Label1.Text = "Details saved successfully.."
            Me.Label1.Visible = True
            Me.btnadd.Enabled = False
            Me.grbshifts.Enabled = False
            Me.RadioButton1.Checked = False
            Me.RadioButton2.Checked = False
            Me.RadioButton3.Checked = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        sel = "shifta"
        Me.btnadd.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        sel = "shiftb"
        Me.btnadd.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        sel = "shiftc"
        Me.btnadd.Enabled = True
    End Sub

End Class