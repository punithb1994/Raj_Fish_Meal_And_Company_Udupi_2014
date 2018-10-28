Imports System.IO
Public Class salary
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub salary_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub salary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltip
        ToolTip1.SetToolTip(Me.cmbempid, "Select employee id to pay salary")
        ToolTip1.SetToolTip(Me.txtempname, "Employee name")
        ToolTip1.SetToolTip(Me.txtdesignation, "Employee's designation")
        ToolTip1.SetToolTip(Me.txtdepartment, "Department in which Employee works")
        ToolTip1.SetToolTip(Me.DateTimePickerpaydate, "Date on which salary is paid")
        ToolTip1.SetToolTip(Me.txtmonth, "Month of which salary is paid")
        ToolTip1.SetToolTip(Me.txtbasic, "Basic salary")
        ToolTip1.SetToolTip(Me.txtshifta, "Usual shifts worked")
        ToolTip1.SetToolTip(Me.txtshiftb, "Evening shifts worked")
        ToolTip1.SetToolTip(Me.txtshiftc, "Night shifts worked")
        ToolTip1.SetToolTip(Me.txttotalshifts, "Total number of shifts employee worked")
        ToolTip1.SetToolTip(Me.txtda, "Daily Allowance")
        ToolTip1.SetToolTip(Me.txthra, "House rent allowance")
        ToolTip1.SetToolTip(Me.txtpf, "Provident fund")
        ToolTip1.SetToolTip(Me.txtnetsalary, "Net salary paid")
        ToolTip1.SetToolTip(Me.btnsave, "Save salary details")
        Me.btnsave.Enabled = False
        Me.Label15.Text = ""
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select empid from employee where status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbempid.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item(0) <> "0" Then
                    Me.cmbempid.Items.Add(dt.Rows(i).Item(0))
                End If
            Next
            Me.cmbempid.Text = "Select"
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
        Me.Label15.Text = ""
        Me.btnsave.Enabled = True
        Dim dt, dt1, dt2, dt3, dt5 As New DataTable
        Dim item As Control
        Dim yr As Integer
        For Each item In Me.grbsalary.Controls
            If TypeOf (item) Is TextBox Then
                item.Text = ""
            End If
        Next
        Try
            connect()
            issuecommand.CommandText = "select empname,designation,department,basic from employee where empid='" & Me.cmbempid.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Me.txtempname.Text = dt2.Rows(0).Item(0)
            Me.txtdesignation.Text = dt2.Rows(0).Item(1)
            Me.txtdepartment.Text = dt2.Rows(0).Item(2)
            If Me.txtdepartment.Text = "" Then
                Me.txtdepartment.Text = "None"
            End If
            Me.txtbasic.Text = Math.Round(dt2.Rows(0).Item(3), 2)
            Me.DateTimePickerpaydate.Text = Today.Date
            If Today.Month <> 1 Then
                Me.txtmonth.Text = DateAndTime.MonthName(Today.Month - 1)
                yr = Today.Year
            Else
                Me.txtmonth.Text = DateAndTime.MonthName(12)
                yr = Today.Year - 1
            End If
            issuecommand.CommandText = "select flag from salary where empid='" & Me.cmbempid.Text & "' and salmonth='" & Me.txtmonth.Text & "' and salyear=" & yr
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)

            If dt3.Rows.Count > 0 Then
                Me.Label15.Text = "Salary for employee " & Me.txtempname.Text & ", already paid."
                Me.btnsave.Enabled = False
            End If
            Dim ctr, k, m As Integer
            Dim i As Date
            Dim diff As Integer
            Dim ot As Double
            'Dim dt, dt1 As New DataTable
            Dim eda1, ehra1, epf1
            Dim j As String
            'Dim wyear As Integer
            'Dim n = Me.cmbmonth.SelectedIndex + 1
            'MsgBox(n)
            'If n = Today.Month Then
            '    wyear = Today.Year
            'ElseIf n = 1 Then
            '    wyear = Today.Year - 1
            '    'MsgBox(wyear)
            'ElseIf n > Today.Month Then
            '    MsgBox("Invalid selection. Please select valid month")
            'End If
            issuecommand.CommandText = "select * from attendance where empid='" & Me.cmbempid.Text & "'  and work_month='" & Me.txtmonth.Text & "' and work_year='" & yr & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                Me.btnsave.Enabled = False
                Me.Label15.Text = "Employee " & Me.txtempname.Text & ", did not work in previous month."
                Exit Sub
            End If
            Me.txtshifta.Text = dt1.Rows(0).Item(1)
            Me.txtshiftb.Text = dt1.Rows(0).Item(2)
            Me.txtshiftc.Text = dt1.Rows(0).Item(2)
            Me.txttotalshifts.Text = Val(Me.txtshifta.Text) + Val(Me.txtshiftb.Text) + Val(Me.txtshiftc.Text)

            issuecommand.CommandText = "select da,hra,pf from settings"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            eda = dt.Rows(0).Item(0)
            ehra = dt.Rows(0).Item(1)
            epf = dt.Rows(0).Item(2)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'Finally
            '    cnnstr.Close()
            'End Try
            ot = 0
            ctr = 0
            'j = Me.cmbmonth.SelectedIndex + 1
            j = Me.txtmonth.Text.ToUpper
            If Me.txtdesignation.Text = "Manager" Then
                If j = DateAndTime.MonthName(1).ToUpper Or j = DateAndTime.MonthName(3).ToUpper Or j = DateAndTime.MonthName(5).ToUpper Or j = DateAndTime.MonthName(7).ToUpper Or j = DateAndTime.MonthName(8).ToUpper Or j = DateAndTime.MonthName(10).ToUpper Or j = DateAndTime.MonthName(12).ToUpper Then
                    'where m is number of days in month
                    m = 31
                ElseIf j = DateAndTime.MonthName(4).ToUpper Or j = DateAndTime.MonthName(6).ToUpper Or j = DateAndTime.MonthName(9).ToUpper Or j = DateAndTime.MonthName(11).ToUpper Then
                    m = 30
                Else
                    If Today.Year \ 4 = 0 Then
                        'leap year
                        m = 29
                    Else
                        m = 28
                    End If
                End If
                For k = 1 To m
                    'To check number of sunday in a selected month
                    i = j & "/" & k & "/" & Today.Year
                    If i.DayOfWeek = DayOfWeek.Sunday Then
                        'ctr is used count sunday in a selected month
                        ctr += 1
                    End If
                Next
                'Number of sunday will be deducted from month m
                m -= ctr
                If Val(Me.txttotalshifts.Text) > m Then  ' if an employee worked for extra shifts then following statements executed
                    'Variable diff used to find extra shifts
                    diff = Val(Me.txttotalshifts.Text) - m
                    'ot is overtime, 500rs for extra shifts
                    ot = diff * 500.0
                    eda1 = Double.Parse(Me.txtbasic.Text) * eda
                    ehra1 = Double.Parse(Me.txtbasic.Text) * ehra
                    epf1 = Double.Parse(Me.txtbasic.Text) * epf
                    Me.txtda.Text = Math.Round(eda1, 2)
                    Me.txthra.Text = Math.Round(ehra1, 2)
                    Me.txtpf.Text = Math.Round(epf1, 2)
                    Me.txtnetsalary.Text = Math.Round(Double.Parse(Me.txtbasic.Text) + eda1 + ehra1 - epf1 + ot, 2)
                Else
                    'here diff variable is used to find leaves
                    diff = m - Val(Me.txttotalshifts.Text)
                    'MsgBox("m=" & m)
                    'MsgBox("diff=" & diff)
                    If diff <= 3 Then
                        ot = 0
                    Else
                        ot = diff * (Double.Parse(Me.txtbasic.Text) / m) * 0.75
                        'MsgBox("ot=" & ot)
                    End If
                    'MsgBox((Me.txtbasic.Text) - ot)
                    eda1 = (Double.Parse(Me.txtbasic.Text) - ot) * eda
                    ehra1 = (Double.Parse(Me.txtbasic.Text) - ot) * ehra
                    epf1 = (Double.Parse(Me.txtbasic.Text) - ot) * epf
                    'MsgBox("da=" & eda1)
                    'MsgBox("hra=" & ehra1)
                    'MsgBox("pf=" & epf1)
                    Me.txtda.Text = Math.Round(eda1, 2)
                    Me.txthra.Text = Math.Round(ehra1, 2)
                    Me.txtpf.Text = Math.Round(epf1, 2)
                    Me.txtnetsalary.Text = Math.Round(Double.Parse(Me.txtbasic.Text) + eda1 + ehra1 - epf1 - ot, 2)
                End If
            ElseIf Me.txtdesignation.Text = "Staff" Then
                Dim basic As Double
                basic = (Val(Me.txtshifta.Text) * 400) + (Val(Me.txtshiftb.Text) * 500) + (Val(Me.txtshiftc.Text) * 600)
                'MsgBox(basic)
                eda1 = basic * eda
                ehra1 = basic * ehra
                epf1 = basic * epf
                Me.txtda.Text = Math.Round(eda1, 2)
                Me.txthra.Text = Math.Round(ehra1, 2)
                Me.txtpf.Text = Math.Round(epf1, 2)
                Me.txtnetsalary.Text = Math.Round(basic + eda1 + ehra1 - epf1, 2)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
            'For Each item1 In Me.grbsalary.Controls
            '    If TypeOf (item1) Is TextBox Then
            '        If (item1.Text = "") Then
            'Me.btnsave.Enabled = False
            'Me.Label15.Text = "This employee did not worked in previous month."
            '        End If
            '    End If
            'Next
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim item As Control
        Try
            connect()
            issuecommand.CommandText = "insert into salary values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)"
            issuecommand.CommandType = CommandType.Text
            issuecommand.Parameters.Clear()
            issuecommand.Parameters.Add("@a", SqlDbType.NVarChar).Value = Me.cmbempid.Text
            issuecommand.Parameters.Add("@b", SqlDbType.DateTime).Value = Me.DateTimePickerpaydate.Text
            issuecommand.Parameters.Add("@c", SqlDbType.VarChar).Value = Me.txtmonth.Text
            issuecommand.Parameters.Add("@d", SqlDbType.VarChar).Value = Today.Year
            issuecommand.Parameters.Add("@e", SqlDbType.BigInt).Value = Val(Me.txttotalshifts.Text)
            issuecommand.Parameters.Add("@f", SqlDbType.Money).Value = Me.txtda.Text
            issuecommand.Parameters.Add("@g", SqlDbType.Money).Value = Me.txthra.Text
            issuecommand.Parameters.Add("@h", SqlDbType.Money).Value = Me.txtpf.Text
            issuecommand.Parameters.Add("@i", SqlDbType.Money).Value = Me.txtnetsalary.Text
            issuecommand.Parameters.Add("@j", SqlDbType.Int).Value = 1
            issuecommand.ExecuteNonQuery()
            Me.Label15.Text = "Saved succesfully."
            rpt3 = "{salary.empid}='" & Me.cmbempid.Text & "' and {salary.salmonth}='" & Me.txtmonth.Text & "'"
            Me.Label15.ForeColor = Color.Lime
            Me.btnsave.Enabled = False
            For Each item In Me.grbsalary.Controls
                If TypeOf (item) Is TextBox Then
                    item.Text = ""
                End If
            Next
            Me.cmbempid.Text = "Select"
            Me.btnslip.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnslip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnslip.Click
        Me.btnslip.Enabled = False
        Dim a As Form
        a = Epayslip
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
    End Sub
End Class