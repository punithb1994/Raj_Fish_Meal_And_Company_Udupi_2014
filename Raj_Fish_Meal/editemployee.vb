Imports System.Text.RegularExpressions
Imports System.IO
Public Class editemployee
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Dim item As Control
    Dim ydiff, flag, ctr As Integer
    Dim path As Integer
    Dim img1 As Image
    Public space = 0
    Sub dobvalid()
        Try
            Dim dt As Date
            Dim day, month, year, tday, tmonth, tyear As Integer
            dt = Me.DateTimePickerempdob.Value
            If dt.Date > Today.Date Then
                Beep()
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "Date of birth cannot exceed the today's date, Please enter valid date.")
                Me.DateTimePickerempdob.Value = Today
                Me.Timer1.Enabled = True
                Exit Sub
            Else
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "")
            End If
            day = Int(dt.Day)
            month = Int(dt.Month)
            year = Int(dt.Year)
            tday = Today.Day
            tmonth = Today.Month
            tyear = Today.Year
            If (day > tday) Then
                tmonth -= 1
                tday += 30
            End If
            If (month > tmonth) Then
                tyear -= 1
                tmonth += 12
            End If
            ydiff = tyear - year
            If ydiff < 14 Then
                Beep()
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "Employee age must be greater than 14!")
                'MsgBox("Employee age must be greater than 14!")
                Me.DateTimePickerempdob.Value = Today
                Exit Sub
            Else
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "")
            End If
            If ydiff > 60 Then
                Beep()
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "Invalid date. Employee age cannot be greater than 60 years.")
                Me.DateTimePickerempdob.Value = Today
                flag = 1
                Exit Sub
            Else
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub frmaddemployee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub frmaddemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.cmdupadateemp, "Click here to update employee information")
        Me.ToolTip1.SetToolTip(Me.cmdimgbrowse, "Click here to change picture")
        ToolTip1.SetToolTip(Me.employeeid, "Select employee id to edit")
        ToolTip1.SetToolTip(Me.txtemployeename, "Edit employee's name")
        ToolTip1.SetToolTip(Me.DateTimePickerempdob, "Edit employee's birth date")
        ToolTip1.SetToolTip(Me.txtempaddress, "Edit employee's address")
        ToolTip1.SetToolTip(Me.txtemailid, "Edit employee's email id")
        ToolTip1.SetToolTip(Me.txtqualification, "Edit employee's qualification")
        ToolTip1.SetToolTip(Me.DateTimePickerempdoj, "Change employee's joining date")
        ToolTip1.SetToolTip(Me.cmbdesig1, "Change employee's designation")
        ToolTip1.SetToolTip(Me.cmbdesig2, "Change employee's department")
        ToolTip1.SetToolTip(Me.txtemployeename, "Edit employee's name")
        ToolTip1.SetToolTip(Me.txtbasic, "Change employee's basic salary")
        ToolTip1.SetToolTip(Me.Panel1, "Select gender")
        ToolTip1.SetToolTip(Me.rdbmale, "Male")
        ToolTip1.SetToolTip(Me.rdbfemale, "Female")
        ToolTip1.SetToolTip(Me.empimage, "Employee's image")
        ToolTip1.SetToolTip(Me.Panel2, "Employee's contact details")
        ToolTip1.SetToolTip(Me.txtlandline, "Employee's landline number")
        ToolTip1.SetToolTip(Me.txtmobile, "Employee's mobile number")
        path = 0
        img1 = empimage.Image
        ctr = 0
        Dim dt1 As New DataTable
        Me.employeeid.Text = "Select"
        Me.txtemployeename.Enabled = False
        Me.DateTimePickerempdob.Enabled = False
        Me.rdbmale.Enabled = False
        Me.rdbfemale.Enabled = False
        Me.txtempaddress.Enabled = False
        Me.txtlandline.Enabled = False
        Me.txtmobile.Enabled = False
        Me.txtemailid.Enabled = False
        Me.txtqualification.Enabled = False
        Me.txtbasic.Enabled = False
        Me.DateTimePickerempdoj.Enabled = False
        Me.cmbdesig1.Enabled = False
        Me.cmbdesig2.Enabled = False
        Me.cmdimgbrowse.Enabled = False
        Me.cmdupadateemp.Enabled = False
        Try
            connect()
            issuecommand.CommandText = "select empid from employee where status=0"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim i As Integer
            Me.employeeid.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                If dt1.Rows(i).Item(0) <> "0" Then
                    Me.employeeid.Items.Add(dt1.Rows(i).Item(0))
                End If
            Next
            If employeeid.Items.Count = "0" Then
                Panel3.BringToFront()
                Me.Panel3.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtemployeename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemployeename.KeyPress
        ctr += 1
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtemployeename, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtemployeename, "")
        End If
        If ctr = 1 Then
            If (Asc(e.KeyChar) = 32) Then
                ctr = 0
                e.Handled = True
            End If
        End If
        If (Asc(e.KeyChar) = 32) Then
            space += 1
        Else
            space = 0
        End If
        If space > 1 Then
            Beep()
            e.Handled = True
        End If
    End Sub
    Private Sub DateTimePickerempdob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerempdob.LostFocus
        Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "")
        dobvalid()
    End Sub
    Private Sub txtemailid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemailid.Leave
        If Me.txtemailid.TextLength = 50 Then
            Me.txtemailid.Clear()
            Exit Sub
        End If
        If Me.txtemailid.Text <> "" Then
            Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(txtemailid.Text), "^([0-9a-z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                Beep()
                Me.txtemailid.Text = ""
                Me.ErrorProvider1.SetError(Me.txtemailid, "Enter valid email Address")
            Else
                Me.ErrorProvider1.SetError(Me.txtemailid, "")
            End If
        End If
    End Sub
    Private Sub DateTimePickerempdoj_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePickerempdoj.LostFocus
        Dim dt As Date
        dt = Me.DateTimePickerempdoj.Value
        If Me.DateTimePickerempdoj.Value.Date < DateAndTime.DateAdd(DateInterval.Year, 14, Me.DateTimePickerempdob.Value.Date) Then
            Beep()
            Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "Enter valid join date.")
            Me.DateTimePickerempdoj.Value = Today
            flag = 1
            Exit Sub
        Else
            Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "")
        End If
        If dt.Date > Today.Date Then
            Beep()
            Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "Date of birth cannot exceed the todays date, Please enter valid date.")
            Me.DateTimePickerempdoj.Value = Today
            Exit Sub
        Else
            Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "")
        End If
    End Sub
    Private Sub txtemployeename_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtemployeename.Validating
        If Me.txtemployeename.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(Me.txtemployeename, "Name must be entered")
        Else
            Me.ErrorProvider1.SetError(Me.txtemployeename, "")
        End If
    End Sub
    Private Sub txtempaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempaddress.KeyPress
        Me.ErrorProvider1.SetError(Me.txtempaddress, "")
    End Sub
    Private Sub txtempaddress_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtempaddress.Validating
        If txtempaddress.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtempaddress, "Employee address must be required")
        Else
            Me.ErrorProvider1.SetError(Me.txtempaddress, "")
            Dim i, ctr As Integer
            ctr = 0
            For i = 1 To Me.txtempaddress.TextLength
                If IsNumeric(Mid(Me.txtempaddress.Text, i, 1)) Or Asc(Mid(Me.txtempaddress.Text, i, 1)) = 32 Or Asc(Mid(Me.txtempaddress.Text, i, 1)) = 13 Or ((Asc(Mid(Me.txtempaddress.Text, i, 1)) >= 48 And Asc(Mid(Me.txtempaddress.Text, i, 1)) <= 57)) Or (Not ((Asc(Mid(Me.txtempaddress.Text, i, 1)) >= 65 And Asc(Mid(Me.txtempaddress.Text, i, 1)) <= 90) Or (Asc(Mid(Me.txtempaddress.Text, i, 1)) >= 97 And Asc(Mid(Me.txtempaddress.Text, i, 1)) <= 122) Or Asc(Mid(Me.txtempaddress.Text, i, 1)) = 32)) Then
                    ctr += 1
                End If
            Next
            If ctr = Me.txtempaddress.TextLength Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtempaddress, "Invalid adrres. Enter valid address.")
                Me.txtempaddress.Clear()
            End If
        End If
    End Sub
    Private Sub cmbdesig1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdesig1.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbdesig1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdesig1.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.cmbdesig1, "")
        If Me.cmbdesig1.SelectedIndex = 0 Then
            Me.cmbdesig2.Enabled = True
            Me.txtbasic.Enabled = True
        End If
        If Me.cmbdesig1.SelectedIndex = 1 Then
            Me.cmbdesig2.Text = ""
            Me.txtbasic.Clear()
            Me.cmbdesig2.Enabled = False
            Me.txtbasic.Enabled = False
            Me.ErrorProvider1.SetError(Me.cmbdesig2, "")
            Me.ErrorProvider1.SetError(Me.txtbasic, "")
        End If
    End Sub
    Private Sub employeeid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles employeeid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub employeeid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles employeeid.SelectedIndexChanged
        Dim dt As New DataTable
        path = 1
        Me.txtemployeename.Enabled = True
        Me.DateTimePickerempdob.Enabled = True
        Me.rdbmale.Enabled = True
        Me.rdbfemale.Enabled = True
        Me.txtempaddress.Enabled = True
        Me.txtlandline.Enabled = True
        Me.txtmobile.Enabled = True
        Me.txtemailid.Enabled = True
        Me.txtqualification.Enabled = True
        Me.txtbasic.Enabled = True
        Me.DateTimePickerempdoj.Enabled = True
        Me.cmbdesig1.Enabled = True
        Me.cmbdesig2.Enabled = True
        Me.cmdimgbrowse.Enabled = True
        Me.cmdupadateemp.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select * from employee where empid='" & Me.employeeid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtemployeename.Text = dt.Rows(0).Item(1)
            Me.DateTimePickerempdob.Value = dt.Rows(0).Item(2)
            Dim gen As String = dt.Rows(0).Item(3)
            If gen = "male" Then
                rdbmale.Checked = True
            ElseIf gen = "female" Then
                rdbfemale.Checked = True
            End If
            Me.txtempaddress.Text = dt.Rows(0).Item(4)
            Me.txtlandline.Text = dt.Rows(0).Item(5)
            Me.txtmobile.Text = dt.Rows(0).Item(6)
            Me.txtemailid.Text = dt.Rows(0).Item(7)
            Me.txtqualification.Text = dt.Rows(0).Item(8)
            Me.DateTimePickerempdoj.Value = dt.Rows(0).Item(9)
            Me.cmbdesig1.Text = dt.Rows(0).Item(10)
            Me.cmbdesig2.Text = dt.Rows(0).Item(11)
            If Me.cmbdesig1.Text = "Staff" Then
                Me.cmbdesig2.Enabled = False
                Me.txtbasic.Enabled = False
            End If
            Dim mstream As IO.MemoryStream
            Dim imgbyte As Byte()
            imgbyte = dt.Rows(0).Item(12)
            mstream = New IO.MemoryStream(imgbyte)
            empimage.Image = Image.FromStream(mstream)
            Me.txtbasic.Text = dt.Rows(0).Item(13).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        empimage.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub
    Private Sub txtbasic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbasic.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtbasic, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtbasic, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 2000 Then
            Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "")
            Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "")
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub cmbdesig2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdesig2.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbdesig2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesig2.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.cmbdesig2, "")
        'If Me.cmbdesig2.Focus = True Then
        '    Dim dt As New DataTable
        '    Try
        '        cnnstr.Close()
        '        connect()
        '        issuecommand.CommandText = "select * from employee where designation='Manager' and department='" & Me.cmbdesig2.Text & "' and status=0"
        '        da.SelectCommand = issuecommand
        '        dt.Clear()
        '        da.Fill(dt)
        '        If dt.Rows.Count <> 0 Then
        '            Beep()
        '            MsgBox(Me.cmbdesig2.Text & " manager already exists")
        '            For Each item In Me.grpnewemp.Controls
        '                If TypeOf (item) Is TextBox Or TypeOf (item) Is DateTimePicker Or TypeOf (item) Is ComboBox Then
        '                    item.Text = ""
        '                End If
        '            Next
        '            Me.employeeid.Text = "Select"
        '            Me.txtemployeename.Enabled = False
        '            Me.DateTimePickerempdob.Enabled = False
        '            Me.rdbmale.Enabled = False
        '            Me.rdbfemale.Enabled = False
        '            Me.txtempaddress.Enabled = False
        '            Me.txtlandline.Enabled = False
        '            Me.txtmobile.Enabled = False
        '            Me.txtemailid.Enabled = False
        '            Me.txtqualification.Enabled = False
        '            Me.txtbasic.Enabled = False
        '            Me.DateTimePickerempdoj.Enabled = False
        '            Me.cmbdesig1.Enabled = False
        '            cmbdesig2.Text = ""
        '            Me.cmbdesig2.Enabled = False
        '            Me.cmdimgbrowse.Enabled = False
        '            Me.cmdupadateemp.Enabled = False
        '            Me.ErrorProvider1.Clear()
        '            Me.rdbfemale.Checked = False
        '            Me.rdbmale.Checked = False
        '            Me.empimage.Image = img1
        '            Me.txtlandline.Clear()
        '            Me.txtmobile.Clear()
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    Finally
        '        cnnstr.Close()
        '    End Try
        'End If
    End Sub
    Private Sub rdbmale_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbmale.CheckedChanged
        Me.ErrorProvider1.SetError(Me.Panel1, "")
    End Sub
    Private Sub rdbfemale_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbfemale.CheckedChanged
        Me.ErrorProvider1.SetError(Me.Panel1, "")
    End Sub
    Private Sub txtlandline_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlandline.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.Panel2, "Landline number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.Panel2, "")
        End If
        If Me.txtlandline.Text.Length > 10 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtlandline_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlandline.Leave
        If Me.txtlandline.TextLength <> 0 Then
            If Me.txtlandline.TextLength < 10 Then
                Beep()
                Me.txtlandline.Clear()
                Me.ErrorProvider1.SetError(Me.Panel2, "Invalid phone number")
            Else
                Me.ErrorProvider1.SetError(Me.Panel2, "")
            End If
        End If
    End Sub
    Private Sub txtlandline_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlandline.TextChanged
        Me.ErrorProvider1.SetError(Me.Panel2, "")
    End Sub
    Private Sub txtmobile_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.Panel2, "Mobile number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.Panel2, "")
        End If
        If Me.txtmobile.Text.Length > 9 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtmobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobile.Leave
        If Me.txtmobile.TextLength <> 0 Then
            If Me.txtmobile.TextLength < 10 Then
                Beep()
                Me.txtmobile.Clear()
                Me.ErrorProvider1.SetError(Me.Panel2, "Invalid phone number")
            Else
                Me.ErrorProvider1.SetError(Me.Panel2, "")
            End If
            If Val(Mid(Me.txtmobile.Text, 1, 1)) < 7 Then
                Beep()
                Me.txtmobile.Clear()
                Me.ErrorProvider1.SetError(Me.Panel2, "Invalid mobile number")
            Else
                Me.ErrorProvider1.SetError(Me.Panel2, "")
            End If
        End If
    End Sub
    Private Sub txtmobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmobile.TextChanged
        Me.ErrorProvider1.SetError(Me.Panel2, "")
    End Sub
    Private Sub cmdupadateemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupadateemp.Click
        Try
            flag = 0
            If Me.txtemployeename.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtemployeename, "Name of the employee must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtemployeename, "")
            End If
            dobvalid()
            If ydiff < 14 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "Date of birth must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdob, "")
            End If
            If Me.DateTimePickerempdoj.Value.Date < DateAndTime.DateAdd(DateInterval.Year, 14, Me.DateTimePickerempdob.Value.Date) Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "Invalid join date. This is a mandatory field.")
            Else
                Me.ErrorProvider1.SetError(Me.DateTimePickerempdoj, "")
            End If
            If (Me.rdbmale.Checked = False And Me.rdbfemale.Checked = False) Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.Panel1, "Select gender of the employee")
            Else
                Me.ErrorProvider1.SetError(Me.Panel1, "")
            End If
            If txtempaddress.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtempaddress, "Address of the employee must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtempaddress, "")
            End If
            If txtqualification.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtqualification, "Qualification must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtqualification, "")
            End If
            If Me.txtlandline.TextLength = 0 And Me.txtmobile.TextLength = 0 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.Panel2, "Enter any contact number")
            Else
                Me.ErrorProvider1.SetError(Me.Panel2, "")
            End If
            If Me.cmbdesig1.SelectedIndex = 0 Then
                If Me.txtbasic.Text = "" Then
                    Me.ErrorProvider1.SetError(Me.txtbasic, "Basic salary must be entered")
                    flag = 1
                Else
                    Me.ErrorProvider1.SetError(Me.txtbasic, "")
                End If
            End If
            If path <> 1 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.lblemployeeimage, "Choose your image")
            Else
                Me.ErrorProvider1.SetError(Me.lblemployeeimage, "")
            End If
            If cmbdesig1.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.cmbdesig1, "Choose designation")
            Else
                Me.ErrorProvider1.SetError(Me.cmbdesig1, "")
            End If
            If Me.cmbdesig1.SelectedIndex = 0 Then
                If Me.cmbdesig2.Text = "" Then
                    flag = 1
                    Me.ErrorProvider1.SetError(Me.cmbdesig2, "Choose department")
                Else
                    Me.ErrorProvider1.SetError(Me.cmbdesig2, "")
                End If
            End If
            If flag = 0 Then
                Dim gender As String
                gender = ""
                If Me.rdbmale.Checked = True Then
                    gender = "male"
                ElseIf Me.rdbfemale.Checked = True Then
                    gender = "female"
                End If
                connect()
                issuecommand.CommandText = "update employee set empname=@empname,dob=@dob,gender=@gender,address=@address,landline=@landline,mob=@mob,email=@email,qualification=@qualification,doj=@doj,designation=@designation,department=@department,empimage=@empimage,basic=@basic where empid=@empid"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = employeeid.Text
                issuecommand.Parameters.Add("@empname", SqlDbType.VarChar, 50).Value = txtemployeename.Text
                issuecommand.Parameters.Add("@dob", SqlDbType.DateTime, 8).Value = DateTimePickerempdob.Value.Date
                issuecommand.Parameters.Add("@gender", SqlDbType.VarChar, 50).Value = gender
                issuecommand.Parameters.Add("@address", SqlDbType.NVarChar, 50).Value = txtempaddress.Text
                issuecommand.Parameters.Add("@landline", SqlDbType.NVarChar, 50).Value = txtlandline.Text
                issuecommand.Parameters.Add("@mob", SqlDbType.NVarChar, 50).Value = txtmobile.Text
                issuecommand.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txtemailid.Text
                issuecommand.Parameters.Add("@qualification", SqlDbType.NVarChar, 50).Value = txtqualification.Text
                issuecommand.Parameters.Add("@doj", SqlDbType.DateTime, 8).Value = DateTimePickerempdoj.Value.Date
                issuecommand.Parameters.Add("@designation", SqlDbType.VarChar, 50).Value = cmbdesig1.Text
                issuecommand.Parameters.Add("@department", SqlDbType.VarChar, 50).Value = cmbdesig2.Text
                Dim img As Image
                Dim mstream As IO.MemoryStream = New IO.MemoryStream
                img = Me.empimage.Image
                img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                issuecommand.Parameters.Add("@empimage", SqlDbType.Image).Value = mstream.GetBuffer
                issuecommand.Parameters.Add("@basic", SqlDbType.Money).Value = Val(Me.txtbasic.Text)
                issuecommand.ExecuteNonQuery()
                'cnnstr.Close()
                Dim dt As New DataTable
                issuecommand.CommandText = "select * from login where empid='" & Me.employeeid.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    issuecommand.CommandText = "update login set usertype=@usertype,department=@department,username=@username,empimage=@empimage where empid=@empid"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = employeeid.Text
                    issuecommand.Parameters.Add("@usertype", SqlDbType.VarChar, 50).Value = cmbdesig1.Text
                    issuecommand.Parameters.Add("@department", SqlDbType.VarChar, 50).Value = cmbdesig2.Text
                    issuecommand.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = txtemployeename.Text
                    issuecommand.Parameters.Add("@empimage", SqlDbType.Image).Value = mstream.GetBuffer
                    issuecommand.ExecuteNonQuery()
                End If
                MsgBox("Details updated successfully.")
                Me.ErrorProvider1.Clear()
                Me.txtemployeename.Enabled = False
                Me.DateTimePickerempdob.Enabled = False
                Me.rdbmale.Enabled = False
                Me.rdbfemale.Enabled = False
                Me.txtempaddress.Enabled = False
                Me.txtlandline.Enabled = False
                Me.txtmobile.Enabled = False
                Me.txtemailid.Enabled = False
                Me.txtqualification.Enabled = False
                Me.txtbasic.Enabled = False
                Me.DateTimePickerempdoj.Enabled = False
                Me.cmbdesig1.Enabled = False
                Me.cmbdesig2.Enabled = False
                Me.cmdimgbrowse.Enabled = False
                Me.cmdupadateemp.Enabled = False
                For Each item In Me.grpnewemp.Controls
                    If TypeOf (item) Is TextBox Or TypeOf (item) Is DateTimePicker Or TypeOf (item) Is ComboBox Then
                        item.Text = ""
                    End If
                Next
                Me.rdbfemale.Checked = False
                Me.rdbmale.Checked = False
                Me.txtlandline.Clear()
                Me.txtmobile.Clear()
                empimage.Image = img1
                Me.employeeid.Text = "Select"
            Else
                MsgBox("Enter all mandatory fields!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtbasic_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbasic.Leave
        If Val(Me.txtbasic.Text) < 5000 Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtbasic, "Basic salary must be greater than 5000")
            Me.txtbasic.Clear()
        End If
    End Sub
    Private Sub cmdimgbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimgbrowse.Click
        Try
            OpenFileDialog1.ShowDialog()
            empimage.SizeMode = PictureBoxSizeMode.StretchImage
            If DialogResult <> Windows.Forms.DialogResult.Cancel Then
                Me.empimage.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
                path = 1
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnlckok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        Me.Close()
    End Sub
    Private Sub txtqualification_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqualification.KeyPress
        Me.ErrorProvider1.SetError(Me.txtqualification, "")
    End Sub
    Private Sub txtqualification_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqualification.Leave
        If Me.txtqualification.Text = "" Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqualification, "Qualification must be entered.")
        Else
            Me.ErrorProvider1.SetError(Me.txtqualification, "")
            Dim i, ctr As Integer
            ctr = 0
            For i = 1 To Me.txtqualification.TextLength
                If IsNumeric(Mid(Me.txtqualification.Text, i, 1)) Or Asc(Mid(Me.txtqualification.Text, i, 1)) = 32 Or Asc(Mid(Me.txtqualification.Text, i, 1)) = 13 Or ((Asc(Mid(Me.txtqualification.Text, i, 1)) >= 48 And Asc(Mid(Me.txtqualification.Text, i, 1)) <= 57)) Or (Not ((Asc(Mid(Me.txtqualification.Text, i, 1)) >= 65 And Asc(Mid(Me.txtqualification.Text, i, 1)) <= 90) Or (Asc(Mid(Me.txtqualification.Text, i, 1)) >= 97 And Asc(Mid(Me.txtqualification.Text, i, 1)) <= 122) Or Asc(Mid(Me.txtqualification.Text, i, 1)) = 32)) Then
                    ctr += 1
                End If
            Next
            If ctr = Me.txtqualification.TextLength Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtqualification, "Invalid entry.")
                Me.txtqualification.Clear()
            End If
        End If
    End Sub
End Class