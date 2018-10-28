Imports System.Text.RegularExpressions
Imports System.IO
Public Class updatecustomer
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Dim item As Control
    Dim flag, ctr As Integer
    Public space = 0
    Private Sub updatecustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub updatecustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.btnupdate, "Click here to update customer information")
        ToolTip1.SetToolTip(Me.Combocustid, "Select Customer Id you want to update")
        ToolTip1.SetToolTip(Me.btndisplay, "Display all customer's information")
        ToolTip1.SetToolTip(Me.txtcustname, "Customer name")
        ToolTip1.SetToolTip(Me.txtcustaddress, "Customer address")
        ToolTip1.SetToolTip(Me.rdbindian, "Customer's nationality")
        ToolTip1.SetToolTip(Me.rdbforeign, "Customer's nationality")
        ToolTip1.SetToolTip(Me.txtlandline, "Customer's landline number")
        ToolTip1.SetToolTip(Me.txtmobileno, "Customer's mobile number")
        ToolTip1.SetToolTip(Me.txtemail, "Customer's email address")


        Dim dt1 As New DataTable
        Me.btnupdate.Enabled = False
        Me.txtcustname.Enabled = False
        Me.txtcustaddress.Enabled = False
        Me.rdbforeign.Enabled = False
        Me.rdbindian.Enabled = False
        Me.txtlandline.Enabled = False
        Me.txtmobileno.Enabled = False
        Me.txtemail.Enabled = False
        Me.DataGridView1.ReadOnly = True
        Try
            connect()
            issuecommand.CommandText = "select custid from customer"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim i As Integer
            Me.Combocustid.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                Me.Combocustid.Items.Add(dt1.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Combocustid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Combocustid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub Combocustid_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combocustid.SelectedIndexChanged
        Dim dt As New DataTable
        'DataGridView2.Visible = True
        'Me.btndisplay.Enabled = False
        Me.btnupdate.Enabled = True
        Me.txtcustname.Enabled = True
        Me.txtcustaddress.Enabled = True
        Me.rdbforeign.Enabled = True
        Me.rdbindian.Enabled = True
        Me.txtlandline.Enabled = True
        Me.txtmobileno.Enabled = True
        Me.txtemail.Enabled = True
        Label9.Visible = False
        Try
            connect()
            issuecommand.CommandText = "select * from customer where custid='" & Me.Combocustid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtcustname.Text = dt.Rows(0).Item(1)
            Me.txtcustaddress.Text = dt.Rows(0).Item(2)
            Dim gen = dt.Rows(0).Item(3)
            If gen = "indian" Then
                Me.rdbindian.Checked = True
            ElseIf gen = "foreign" Then
                Me.rdbforeign.Checked = True
            End If
            Me.txtlandline.Text = dt.Rows(0).Item(4)
            Me.txtmobileno.Text = dt.Rows(0).Item(5)
            Me.txtemail.Text = dt.Rows(0).Item(6)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtcustname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustname.KeyPress
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
    Private Sub txtphno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlandline.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtlandline, "Phone number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtlandline, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        Me.ErrorProvider1.SetError(Me.txtemail, "")
    End Sub
    Private Sub txtemail_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        If Me.txtemail.Text <> "" Then
            Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(txtemail.Text), "^([0-9a-z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                Beep()
                Me.txtemail.Text = ""
                Me.ErrorProvider1.SetError(Me.txtemail, "Enter valid email Address")
            Else
                Me.ErrorProvider1.SetError(Me.txtemail, "")
            End If
        End If
    End Sub
    Private Sub txtcustname_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcustname.Validating
        If Me.txtcustname.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(Me.txtcustname, "Name must be entered")
        Else
            Me.ErrorProvider1.SetError(Me.txtcustname, "")
        End If
    End Sub
    Private Sub txtcustaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustaddress.KeyPress
        Me.ErrorProvider1.SetError(Me.txtcustaddress, "")
    End Sub
    Private Sub txtcustaddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcustaddress.Leave
        If txtcustaddress.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtcustaddress, "Customer address must be entered")
        Else
            Me.ErrorProvider1.SetError(Me.txtcustaddress, "")
            Dim i, ctr As Integer
            ctr = 0
            For i = 1 To Me.txtcustaddress.TextLength
                If IsNumeric(Mid(Me.txtcustaddress.Text, i, 1)) Or Asc(Mid(Me.txtcustaddress.Text, i, 1)) = 32 Or Asc(Mid(Me.txtcustaddress.Text, i, 1)) = 13 Or ((Asc(Mid(Me.txtcustaddress.Text, i, 1)) >= 48 And Asc(Mid(Me.txtcustaddress.Text, i, 1)) <= 57)) Or (Not ((Asc(Mid(Me.txtcustaddress.Text, i, 1)) >= 65 And Asc(Mid(Me.txtcustaddress.Text, i, 1)) <= 90) Or (Asc(Mid(Me.txtcustaddress.Text, i, 1)) >= 97 And Asc(Mid(Me.txtcustaddress.Text, i, 1)) <= 122) Or Asc(Mid(Me.txtcustaddress.Text, i, 1)) = 32)) Then
                    ctr += 1
                End If
            Next
            If ctr = Me.txtcustaddress.TextLength Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtcustaddress, "Invalid adrress. Enter valid address.")
                Me.txtcustaddress.Clear()
            End If
        End If
    End Sub
    Private Sub txtphno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlandline.Leave
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
    Private Sub txtphno_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtlandline.Validating
        If IsDBNull(txtcustaddress) Then
            Me.ErrorProvider1.SetError(Me.txtcustaddress, "Phone No. must be entered")
        Else
            Me.ErrorProvider1.SetError(Me.txtcustaddress, "")
        End If
    End Sub
    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            flag = 0
            If txtcustname.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtcustname, "Name of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtcustname, "")
            End If
            If txtcustaddress.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtcustaddress, "Address of the employee must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtcustaddress, "")
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


            If Me.txtmobileno.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtmobileno, "Mobile number of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtmobileno, "")
            End If

            If txtemail.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtemail, "Email ID of the customer must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtemail, "")
            End If
            If flag = 0 Then
                Dim nationality As String
                nationality = ""
                If Me.rdbindian.Checked = True Then
                    nationality = "indian"
                ElseIf Me.rdbforeign.Checked = True Then
                    nationality = "foreign"
                End If
                connect()
                issuecommand.CommandText = "update customer set custname=@custname,custadd=@custadd,nationality=@nationality,custlandline=@custlandline,custmobile=@custmobile,custemail=@custemail where custid=@custid"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@custid", SqlDbType.NVarChar, 50).Value = Combocustid.Text
                issuecommand.Parameters.Add("@custname", SqlDbType.VarChar, 50).Value = txtcustname.Text
                issuecommand.Parameters.Add("@custadd", SqlDbType.NVarChar, 50).Value = Me.txtcustaddress.Text
                issuecommand.Parameters.Add("@nationality", SqlDbType.VarChar, 50).Value = nationality
                issuecommand.Parameters.Add("@custlandline", SqlDbType.NVarChar, 50).Value = Me.txtlandline.Text
                issuecommand.Parameters.Add("@custmobile", SqlDbType.NVarChar, 50).Value = Me.txtmobileno.Text
                issuecommand.Parameters.Add("@custemail", SqlDbType.NVarChar, 50).Value = Me.txtemail.Text
                issuecommand.ExecuteNonQuery()
                DataGridView2.Visible = True
                Me.Label9.Text = "Updated Successfully..."
                Label9.Visible = True
                Me.btnupdate.Enabled = False
                Me.btndisplay.Enabled = True
                'Me.txtcustname.Clear()
                'Me.txtcustaddress.Clear()
                'Me.txtlandline.Clear()
                'Me.txtemail.Clear()
                Me.Combocustid.Enabled = True
                Me.txtcustname.Enabled = False
                Me.txtcustaddress.Enabled = False
                Me.txtlandline.Enabled = False
                Me.txtmobileno.Enabled = False
                Me.txtemail.Enabled = False
                Me.rdbforeign.Checked = False
                Me.rdbindian.Checked = False
                For Each item In Me.GroupBox2.Controls
                    If TypeOf (item) Is TextBox Or TypeOf (item) Is DateTimePicker Or TypeOf (item) Is ComboBox Then
                        item.Text = ""
                    End If
                Next
                Me.ErrorProvider1.Clear()
            Else
                Me.Label9.Text = "Enter all fields..."
                Label9.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btndisplay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisplay.Click
        Me.ErrorProvider1.Clear()
        Me.DataGridView2.Visible = False
        Me.Label9.Visible = False
        Me.txtcustname.Clear()
        Me.txtcustaddress.Clear()
        Me.txtlandline.Clear()
        Me.txtemail.Clear()
        Me.Combocustid.Text = ""
        Me.txtmobileno.Clear()
        Me.rdbforeign.Checked = False
        Me.rdbindian.Checked = False
        Me.txtcustname.Enabled = False
        Me.txtcustaddress.Enabled = False
        Me.rdbforeign.Enabled = False
        Me.rdbindian.Enabled = False
        Me.txtlandline.Enabled = False
        Me.txtmobileno.Enabled = False
        Me.txtemail.Enabled = False
        Me.btnupdate.Enabled = False
        Try
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select * from customer"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Me.Combocustid.Enabled = True
            Me.txtcustname.Enabled = True
            Me.txtcustaddress.Enabled = True
            Me.txtlandline.Enabled = True
            Me.txtemail.Enabled = True
            Me.btnupdate.Enabled = True
            Me.Combocustid.Text = Me.DataGridView1.Item(0, e.RowIndex).Value
            Me.txtcustname.Text = Me.DataGridView1.Item(1, e.RowIndex).Value
            Me.txtcustaddress.Text = Me.DataGridView1.Item(2, e.RowIndex).Value
            If Me.DataGridView1.Item(3, e.RowIndex).Value = "indian" Then
                Me.rdbindian.Checked = True
            Else
                Me.rdbforeign.Checked = True
            End If
            Me.txtlandline.Text = Me.DataGridView1.Item(4, e.RowIndex).Value
            Me.txtmobileno.Text = Me.DataGridView1.Item(5, e.RowIndex).Value
            Me.txtemail.Text = Me.DataGridView1.Item(6, e.RowIndex).Value
        Catch ex As Exception
            Me.Label9.Text = "Invalid selection..."
            Label9.Visible = True
        End Try
    End Sub
    Private Sub txtmobileno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobileno.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtmobileno, "Mobile number can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtmobileno, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtmobileno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobileno.Leave
        If Me.txtmobileno.TextLength <> 0 Then
            If Me.txtmobileno.TextLength < 10 Then
                Beep()
                Me.txtmobileno.Clear()
                Me.ErrorProvider1.SetError(Me.txtmobileno, "Invalid phone number")
            Else
                Me.ErrorProvider1.SetError(Me.txtmobileno, "")
            End If
            If Val(Mid(Me.txtmobileno.Text, 1, 1)) < 7 Then
                Beep()
                Me.txtmobileno.Clear()
                Me.ErrorProvider1.SetError(Me.txtmobileno, "Invalid mobile number")
            Else
                Me.ErrorProvider1.SetError(Me.txtmobileno, "")
            End If
        End If
    End Sub
End Class


