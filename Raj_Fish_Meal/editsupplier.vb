Imports System.Text.RegularExpressions
Imports System.IO
Public Class editsupplier
    Public da As New SqlClient.SqlDataAdapter
    Public dt, dt1 As New DataTable
    Public ds As New DataSet
    Dim item As Control
    Dim path, ctr As Integer
    Dim flag1 As Integer
    Public space = 0
    Private Sub addnewsupplier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub txtsname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsname.KeyPress
        Me.ErrorProvider1.SetError(Me.txtsname, "")
        ctr += 1
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtsname, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtsname, "")
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
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtsupplierphoneno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsupplierphoneno.KeyPress
        Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "")
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "Phone number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "")
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If Me.txtsupplierphoneno.Text.Length > 10 Then
            Beep()
            e.Handled = True
        End If
    End Sub
    Private Sub txtsupplieremailid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsupplieremailid.KeyPress
        Me.ErrorProvider1.SetError(Me.txtsupplieremailid, "")
    End Sub
    Private Sub txtsupplieremailid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsupplieremailid.Leave
        If Me.txtsupplieremailid.TextLength = 50 Then
            Me.txtsupplieremailid.Clear()
            Exit Sub
        End If
        If Me.txtsupplieremailid.Text <> "" Then
            Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(txtsupplieremailid.Text), "^([0-9a-z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                Beep()
                Me.txtsupplieremailid.Text = ""
                Me.ErrorProvider1.SetError(Me.txtsupplieremailid, "Enter valid email Address")
            Else
                Me.ErrorProvider1.SetError(Me.txtsupplieremailid, "")
            End If
        End If
    End Sub
    Private Sub txtsupplierphoneno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsupplierphoneno.Leave
        If Me.txtsupplierphoneno.TextLength <> 0 Then
            If Me.txtsupplierphoneno.TextLength < 10 Then
                Beep()
                Me.txtsupplierphoneno.Clear()
                Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "Invalid phone number")
            Else
                Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "")
            End If
            If Val(Mid(Me.txtsupplierphoneno.Text, 1, 1)) < 7 Then
                Beep()
                Me.txtsupplierphoneno.Clear()
                Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "Invalid mobile number")
            Else
                Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "")
            End If
        End If
    End Sub
    Private Sub cmbsupplierid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbsupplierid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbsupplierid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsupplierid.SelectedIndexChanged
        Me.btnupdate.Enabled = True
        Dim dt As New DataTable
        Me.GroupBox3.Enabled = True
        Label3.Visible = False
        Try
            connect()
            issuecommand.CommandText = "select * from supplier where supid='" & Me.cmbsupplierid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtsname.Text = dt.Rows(0).Item(1)
            Me.txtsupplieraddress.Text = dt.Rows(0).Item(2)
            Me.txtsupplierphoneno.Text = dt.Rows(0).Item(3)
            Me.txtsupplieremailid.Text = dt.Rows(0).Item(4)
            Me.txtsuppaccno.Text = dt.Rows(0).Item(5)
            Me.txtsuppbankbranch.Text = dt.Rows(0).Item(6)
            Me.txtsuppifsccode.Text = dt.Rows(0).Item(7)
            Me.txtneftcode.Text = dt.Rows(0).Item(8)
            Me.cmbsupplierid.Enabled = True
            Me.txtsname.Enabled = True
            Me.txtsupplieraddress.Enabled = True
            Me.txtsupplierphoneno.Enabled = True
            Me.txtsupplieremailid.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try

            flag1 = 0
            ' Validation for supplier name
            If Me.txtsname.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsname, "Name of the supplier must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsname, "")
            End If
            'validation for address of supplier

            If Me.txtsupplieraddress.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsupplieraddress, "Address of the supplier must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsupplieraddress, "")
            End If

            'validation for phone no

            If Me.txtsupplierphoneno.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "Phone no of the supplier must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsupplierphoneno, "")
            End If

            'Validation for email id
            If Me.txtsupplieremailid.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsupplieremailid, "Email id of the supplier must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsupplieremailid, "")
            End If


            If Me.txtsuppaccno.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsuppaccno, "Account no of the supplier must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsuppaccno, "")
            End If

            If Me.txtsuppbankbranch.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsuppbankbranch, "Branch must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsuppbankbranch, "")
            End If

            If Me.txtsuppifsccode.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "Ifsc Code must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "")
            End If


            If Me.txtsuppifsccode.Text.Length < 10 Then
                flag1 = 1
                Me.txtsuppifsccode.Clear()
                Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "Ifsc Code must be greater 10 alphanumeric characters ")
            Else
                Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "")
            End If


            If Me.txtneftcode.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtneftcode, "Neft code must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtneftcode, "")
            End If

            If Me.txtneftcode.Text.Length < 10 Then
                flag1 = 1
                Me.txtneftcode.Clear()
                Me.ErrorProvider1.SetError(Me.txtneftcode, "Neft Code must be greater 10 alphanumeric characters ")
            Else
                Me.ErrorProvider1.SetError(Me.txtneftcode, "")
            End If


            If flag1 = 0 Then
                connect()
                issuecommand.CommandText = "update supplier set sname=@sname,address=@address,phone=@phone,email=@email,bankaccno=@bankaccno,branch=@branch,ifsccode=@ifsccode,neftcode=@neftcode where supid=@supid"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@supid", SqlDbType.NVarChar, 50).Value = Me.cmbsupplierid.Text
                issuecommand.Parameters.Add("@sname", SqlDbType.VarChar, 50).Value = Me.txtsname.Text
                issuecommand.Parameters.Add("@address", SqlDbType.NVarChar, 50).Value = Me.txtsupplieraddress.Text
                issuecommand.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = Me.txtsupplierphoneno.Text
                issuecommand.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = Me.txtsupplieremailid.Text
                issuecommand.Parameters.Add("@bankaccno", SqlDbType.NVarChar, 50).Value = Me.txtsuppaccno.Text
                issuecommand.Parameters.Add("@branch", SqlDbType.VarChar, 50).Value = Me.txtsuppbankbranch.Text
                issuecommand.Parameters.Add("@ifsccode", SqlDbType.NVarChar, 50).Value = Me.txtsuppifsccode.Text
                issuecommand.Parameters.Add("@neftcode", SqlDbType.NVarChar, 50).Value = Me.txtneftcode.Text
                issuecommand.ExecuteNonQuery()
                Me.cmbsupplierid.Text = ""
                Label3.Visible = True
                Me.cmbsupplierid.Enabled = True
                Me.txtsname.Enabled = False
                Me.txtsupplieraddress.Enabled = False
                Me.txtsupplierphoneno.Enabled = False
                Me.txtsupplieremailid.Enabled = False
                Me.txtsname.Clear()
                Me.txtsupplieraddress.Clear()
                Me.txtsupplierphoneno.Clear()
                Me.txtsupplieremailid.Clear()
                Me.btnupdate.Enabled = False
                Me.GroupBox3.Enabled = False
                For Each item In Me.GroupBox3.Controls
                    If TypeOf (item) Is TextBox Or TypeOf (item) Is DateTimePicker Or TypeOf (item) Is ComboBox Then
                        item.Text = ""
                    End If
                Next
            Else
                MsgBox("Enter all mandatory fields!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub editsupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnupdate.Enabled = False
        'tooltips
        ToolTip1.SetToolTip(Me.btnupdate, "Update supplier information")
        ToolTip1.SetToolTip(Me.cmbsupplierid, "Select Supplier Id to edit")
        ToolTip1.SetToolTip(Me.txtsname, "Edit supplier's name")
        ToolTip1.SetToolTip(Me.txtsupplieraddress, "Edit supplier's address")
        ToolTip1.SetToolTip(Me.txtsupplierphoneno, "Edit supplier's contact number")
        ToolTip1.SetToolTip(Me.txtsupplieremailid, "Edit supplier's email id")
        ToolTip1.SetToolTip(Me.txtsuppaccno, "Edit supplier's bank account number")
        ToolTip1.SetToolTip(Me.txtsuppbankbranch, "Edit supplier's bank's branch name")
        ToolTip1.SetToolTip(Me.txtsuppifsccode, "Edit supplier's bank's ifsc code")

        ToolTip1.SetToolTip(Me.txtneftcode, "Edit supplier's bank's neft code")
        Dim dt1 As New DataTable
        Me.cmbsupplierid.Enabled = True
        Me.txtsname.Enabled = False
        Me.txtsupplieraddress.Enabled = False
        Me.txtsupplierphoneno.Enabled = False
        Me.txtsupplieremailid.Enabled = False
        Me.GroupBox3.Enabled = False
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select supid from supplier"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim i As Integer
            Me.cmbsupplierid.Items.Clear()

            For i = 0 To dt1.Rows.Count - 1
                If dt1.Rows(i).Item(0) <> "0" Then
                    Me.cmbsupplierid.Items.Add(dt1.Rows(i).Item(0))
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtsuppbankbranch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsuppbankbranch.KeyPress
        Me.ErrorProvider1.SetError(Me.txtsuppbankbranch, "")
        ctr += 1
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtsuppbankbranch, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtsuppbankbranch, "")
        End If
        If ctr = 1 Then
            If (Asc(e.KeyChar) = 32) Then
                ctr = 0
                e.Handled = True
            End If
        End If
        If Me.txtsuppbankbranch.Text.Length > 26 Then
            Beep()
            e.Handled = True
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
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtsuppifsccode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsuppifsccode.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "")
        End If
        If Me.txtsuppifsccode.Text.Length > 19 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtneftcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtneftcode.KeyPress
        Me.ErrorProvider1.SetError(Me.txtneftcode, "")
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtneftcode, "Invalid character!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "")
        End If
        If Me.txtneftcode.Text.Length > 19 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtsuppaccno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsuppaccno.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtsuppaccno, "Account number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtsuppaccno, "")
        End If
        If Me.txtsuppaccno.Text.Length > 19 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtsupplieraddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsupplieraddress.Leave
        If Me.txtsupplieraddress.TextLength <> 0 Then
            Dim i, ctr As Integer
            ctr = 0
            For i = 1 To Me.txtsupplieraddress.TextLength
                If IsNumeric(Mid(Me.txtsupplieraddress.Text, i, 1)) Or Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) = 32 Or Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) = 13 Or ((Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) >= 48 And Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) <= 57)) Or (Not ((Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) >= 65 And Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) <= 90) Or (Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) >= 97 And Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) <= 122) Or Asc(Mid(Me.txtsupplieraddress.Text, i, 1)) = 32)) Then
                    ctr += 1
                End If
            Next
            If ctr = Me.txtsupplieraddress.TextLength Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtsupplieraddress, "Invalid adrress. Enter valid address.")
                Me.txtsupplieraddress.Clear()
            End If
        End If
    End Sub
    Private Sub txtneftcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtneftcode.Leave
        Dim i, flag, ctr As Integer
        flag = ctr = 0
        For i = 1 To Me.txtneftcode.TextLength
            If IsNumeric(Mid(Me.txtneftcode.Text, i, 1)) Then
                flag += 1
            End If
            If Char.IsLetter(Mid(Me.txtneftcode.Text, i, 1)) Then
                ctr += 1
            End If
        Next
        If Not (flag > 0 And ctr > 0) Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtneftcode, "Invalid NEFT Code")
            Me.txtneftcode.Clear()
        End If
    End Sub
    Private Sub txtsuppifsccode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsuppifsccode.Leave
        Dim i, flag, ctr As Integer
        flag = ctr = 0
        For i = 1 To Me.txtsuppifsccode.TextLength
            If IsNumeric(Mid(Me.txtsuppifsccode.Text, i, 1)) Then
                flag += 1
            End If
            If Char.IsLetter(Mid(Me.txtsuppifsccode.Text, i, 1)) Then
                ctr += 1
            End If
        Next
        If Not (flag > 0 And ctr > 0) Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtsuppifsccode, "Invalid IFSC Code")
            Me.txtsuppifsccode.Clear()
        End If
    End Sub
End Class