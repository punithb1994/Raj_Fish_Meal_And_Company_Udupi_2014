Imports System.Text.RegularExpressions
Public Class addcustomer
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Dim item As Control
    Dim ydiff, flag, ctr As Integer
    Public space = 0
    Private Sub addcustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub addcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtcustid.ReadOnly = True
        'tooltips
        ToolTip1.SetToolTip(Me.txtcustid, "Customer Id")
        ToolTip1.SetToolTip(Me.btnnew, "Add new customer details")
        ToolTip1.SetToolTip(Me.btnsave, "Save new customer details")
        ToolTip1.SetToolTip(Me.txtcustname, "Enter customer name")
        ToolTip1.SetToolTip(Me.txtaddress, "Enter customer address")
        ToolTip1.SetToolTip(Me.rdbindian, "Select customer's nationality")
        ToolTip1.SetToolTip(Me.rdbforeign, "Select customer's nationality")
        ToolTip1.SetToolTip(Me.txtlandline, "Enter customer's landline number")
        ToolTip1.SetToolTip(Me.txtmobile, "Enter customer's mobile number")
        ToolTip1.SetToolTip(Me.txtcustomeremail, "Enter customer's email address")
        Me.grbdata.Enabled = False
        Me.btnsave.Enabled = False
    End Sub
    Private Sub btnnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            Me.Label5.Visible = False
            Me.grbdata.Enabled = True
            Me.btnsave.Enabled = True
            Me.btnnew.Enabled = False
            Me.txtcustname.Focus()
            Dim n, k As Integer
            Dim m, i As String
            Dim a() As Integer
            a = New Integer() {0}
            n = 1
            For Each item In Me.grbdata.Controls
                If TypeOf (item) Is TextBox Or TypeOf (item) Is DateTimePicker Or TypeOf (item) Is ComboBox Then
                    item.Text = ""
                End If
            Next
            connect()
            issuecommand.CommandText = "select custid from customer"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            ReDim a(dt.Rows.Count)
            For k = 0 To dt.Rows.Count - 1
                i = dt.Rows(k).Item(0)
                m = ""
                Dim length = Len(i)
                For n = 1 To length
                    Dim ch = Mid(i, n, 1)
                    If (Char.IsNumber(ch)) Then
                        m = m + ch
                    End If
                Next
                a(k) = Int(m)
            Next

            'Code for reduce the custid, if custid is deleted then it can be reused
            Dim len1 = a.Length
            Dim t, j, temp, max As Integer
            For t = 0 To len1 - 1
                For j = t + 1 To len1 - 1
                    If a(t) > a(j) Then
                        temp = a(t)
                        a(t) = a(j)
                        a(j) = temp
                    End If
                Next
            Next
            t = 1
            For j = 0 To len1 - 1
                If t = a(j) Then
                    t += 1
                    j = 0
                End If
            Next
            max = t
            Me.txtcustid.Text = "C" & max
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            flag = 0
            If Me.txtcustname.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtcustname, "Name of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtcustname, "")
            End If
            If Me.txtaddress.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtaddress, "Address of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtaddress, "")
            End If

            If (Me.rdbindian.Checked = False And Me.rdbforeign.Checked = False) Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.rdbforeign, "Select nationality of the customer")
            Else
                Me.ErrorProvider1.SetError(Me.rdbforeign, "")
            End If

            If Me.txtlandline.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtlandline, "Landline number of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtlandline, "")
            End If


            If Me.txtmobile.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtmobile, "Mobile number of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtmobile, "")
            End If



            If Me.txtcustomeremail.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtcustomeremail, "Email address of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtcustomeremail, "")
            End If
            If flag = 0 Then
                Me.btnsave.Enabled = False
                Me.btnnew.Enabled = True
                Me.grbdata.Enabled = False

                Dim nationality As String
                nationality = ""
                If Me.rdbindian.Checked = True Then
                    nationality = "indian"
                ElseIf Me.rdbforeign.Checked = True Then
                    nationality = "foreign"
                End If
                connect()
                issuecommand.CommandText = "insert into customer values(@custid,@custname,@custadd,@nationality,@custlandline,@custmobile,@custemail)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@custid", SqlDbType.NVarChar, 50).Value = txtcustid.Text
                issuecommand.Parameters.Add("@custname", SqlDbType.VarChar, 50).Value = txtcustname.Text
                issuecommand.Parameters.Add("@custadd", SqlDbType.NVarChar, 50).Value = Me.txtaddress.Text
                issuecommand.Parameters.Add("@nationality", SqlDbType.VarChar, 50).Value = nationality
                issuecommand.Parameters.Add("@custlandline", SqlDbType.NVarChar, 50).Value = Me.txtlandline.Text
                issuecommand.Parameters.Add("@custmobile", SqlDbType.NVarChar, 50).Value = Me.txtmobile.Text
                issuecommand.Parameters.Add("@custemail", SqlDbType.NVarChar, 50).Value = Me.txtcustomeremail.Text
                issuecommand.ExecuteNonQuery()
                Me.Label5.Visible = True
                Me.txtcustid.Clear()
                Me.txtcustname.Clear()
                Me.rdbindian.Checked = False
                Me.rdbforeign.Checked = False
                Me.txtaddress.Clear()
                Me.txtlandline.Clear()
                Me.txtmobile.Clear()
                Me.txtcustomeremail.Clear()
            Else
                MsgBox("Enter all mandatory fields!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtcustname_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustname.KeyPress
        ctr += 1
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtcustname, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtcustname, "")
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
    Private Sub txtlandline_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlandline.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtlandline, "Landline number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtlandline, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtcustname_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcustname.Validating
        If Me.txtcustname.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(Me.txtcustname, "Customer name must be entered")
        Else
            Me.ErrorProvider1.SetError(Me.txtcustname, "")
        End If
    End Sub
    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        Me.ErrorProvider1.SetError(Me.txtaddress, "")
    End Sub
    Private Sub txtaddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.Leave
        If txtaddress.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtaddress, "Customer address must be entered")
        Else
            Me.ErrorProvider1.SetError(Me.txtaddress, "")
            Dim i, ctr As Integer
            ctr = 0
            For i = 1 To Me.txtaddress.TextLength
                If IsNumeric(Mid(Me.txtaddress.Text, i, 1)) Or Asc(Mid(Me.txtaddress.Text, i, 1)) = 32 Or Asc(Mid(Me.txtaddress.Text, i, 1)) = 13 Or ((Asc(Mid(Me.txtaddress.Text, i, 1)) >= 48 And Asc(Mid(Me.txtaddress.Text, i, 1)) <= 57)) Or (Not ((Asc(Mid(Me.txtaddress.Text, i, 1)) >= 65 And Asc(Mid(Me.txtaddress.Text, i, 1)) <= 90) Or (Asc(Mid(Me.txtaddress.Text, i, 1)) >= 97 And Asc(Mid(Me.txtaddress.Text, i, 1)) <= 122) Or Asc(Mid(Me.txtaddress.Text, i, 1)) = 32)) Then
                    ctr += 1
                End If
            Next
            If ctr = Me.txtaddress.TextLength Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtaddress, "Invalid adrress. Enter valid address.")
                Me.txtaddress.Clear()
            End If
        End If
    End Sub
    Private Sub txtlandline_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlandline.Leave
        If Me.txtlandline.TextLength <> 0 Then
            If Me.txtlandline.TextLength < 11 Then
                Beep()
                Me.txtlandline.Clear()
                Me.ErrorProvider1.SetError(Me.txtlandline, "Invalid phone number")
            Else
                Me.ErrorProvider1.SetError(Me.txtlandline, "")
            End If
        End If
    End Sub
    Private Sub txtcustomeremail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomeremail.KeyPress
        Me.ErrorProvider1.SetError(Me.txtcustomeremail, "")
    End Sub
    Private Sub txtcustomeremail_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcustomeremail.LostFocus
        If Me.txtcustomeremail.TextLength = 50 Then
            Me.txtcustomeremail.Clear()
            Exit Sub
        End If
        If Me.txtcustomeremail.Text <> "" Then
            Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(txtcustomeremail.Text), "^([0-9a-z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                Beep()
                Me.txtcustomeremail.Text = ""
                Me.ErrorProvider1.SetError(Me.txtcustomeremail, "Enter valid email Address")
            Else
                Me.ErrorProvider1.SetError(Me.txtcustomeremail, "")
            End If
        End If
    End Sub
    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtmobile, "Mobile number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtmobile, "")
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
                Me.ErrorProvider1.SetError(Me.txtmobile, "Invalid phone number")
            Else
                Me.ErrorProvider1.SetError(Me.txtmobile, "")
            End If
            If Val(Mid(Me.txtmobile.Text, 1, 1)) < 7 Then
                Beep()
                Me.txtmobile.Clear()
                Me.ErrorProvider1.SetError(Me.txtmobile, "Invalid mobile number")
            Else
                Me.ErrorProvider1.SetError(Me.txtmobile, "")
            End If
        End If
    End Sub
    Private Sub rdbindian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbindian.CheckedChanged
        Me.ErrorProvider1.SetError(Me.rdbforeign, "")

    End Sub
    Private Sub rdbforeign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbforeign.CheckedChanged
        Me.ErrorProvider1.SetError(Me.rdbforeign, "")

    End Sub
End Class
