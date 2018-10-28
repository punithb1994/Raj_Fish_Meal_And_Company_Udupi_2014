Imports System.Text.RegularExpressions
Public Class category
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltip
        ToolTip1.SetToolTip(Me.cmbcatid, "Select category id")
        ToolTip1.SetToolTip(Me.txtcatid, "Category Id")
        ToolTip1.SetToolTip(Me.cmbcatname, "Select category name")
        ToolTip1.SetToolTip(Me.txtcattype, "Enter category type")
        ToolTip1.SetToolTip(Me.cmbsid, "Select supplier id")
        ToolTip1.SetToolTip(Me.txtsname, "Supplier name")
        ToolTip1.SetToolTip(Me.txtsadd, "Supplier address")
        ToolTip1.SetToolTip(Me.btnnew, "Add new category")
        ToolTip1.SetToolTip(Me.btnedit, "Edit")
        ToolTip1.SetToolTip(Me.btnupdate, "Update")
        ToolTip1.SetToolTip(Me.btnsave, "Save")
        ToolTip1.SetToolTip(Me.btndel, "Delete")
        ToolTip1.SetToolTip(Me.Button1, "Cancel")
        frmmdihome.Enabled = False
        Me.Panel1.Enabled = False
        Me.btnsave.Enabled = False
        Me.btndel.Enabled = False
        Dim w, h, lw As Integer
        w = frmmdihome.Size.Width
        h = frmmdihome.Size.Height
        lw = frmmdihome.Location.X
        Me.Size = New Size(w, 388)
        Me.Location = New Point(lw, (h \ 2) - (388 \ 2))
        Me.txtcattype.Enabled = False
    End Sub
    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.btnnew.Enabled = True
        Dim dt, dt1, dt2, dt3, dt4, dt5, dt6 As New DataTable
        Try
            Dim flag As Integer
            flag = 0
            If Me.cmbcatname.Text = "Select" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.cmbcatname, "Category name must be entered")
            End If
            If Me.txtcattype.Text = "" Then
                flag = 1
                If Me.cmbcatname.Text = "Select" Then
                    Me.ErrorProvider1.SetError(Me.txtcattype, "Category type must be entered")
                Else
                    Me.ErrorProvider1.SetError(Me.txtcattype, "Type of the " & Me.cmbcatname.Text & " must be entered")
                End If
            End If
            If Me.cmbsid.Text = "Select" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.cmbsid, "Supplier must be selected")
            End If
            If flag = 0 Then
                connect()
                issuecommand.CommandText = "select * from category where catid='" & Me.txtcatid.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    issuecommand.CommandText = "insert into category values(@catid,@catname,@type,@status)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar, 50).Value = Me.txtcatid.Text
                    issuecommand.Parameters.Add("@catname", SqlDbType.VarChar, 50).Value = Me.cmbcatname.Text
                    issuecommand.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = Me.txtcattype.Text
                    issuecommand.Parameters.Add("@status", SqlDbType.Int, 50).Value = 0
                    issuecommand.ExecuteNonQuery()
                    'save rawinvetory table
                    Dim n, k As Integer
                    Dim m, i As String
                    Dim a() As Integer
                    a = New Integer() {0}
                    n = 1
                    issuecommand.CommandText = "select itemcode from rawinventory"
                    da.SelectCommand = issuecommand
                    dt1.Clear()
                    da.Fill(dt1)
                    ReDim a(dt1.Rows.Count)
                    For k = 0 To dt1.Rows.Count - 1
                        i = dt1.Rows(k).Item(0)
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

                    'Code for reduce the catid, if catid is deleted then it can be reused
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
                    issuecommand.CommandText = "insert into rawinventory values(@itemcode,@catid,@qty)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@itemcode", SqlDbType.NVarChar, 50).Value = "I" & max
                    issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar, 50).Value = Me.txtcatid.Text
                    issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = 0
                    issuecommand.ExecuteNonQuery()
                End If
                issuecommand.CommandText = "insert into category_supplier values(@slno,@supid,@catid)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@slno", SqlDbType.BigInt).Value = Val(Me.lblslno.Text)
                issuecommand.Parameters.Add("@supid", SqlDbType.NVarChar).Value = Me.cmbsid.Text
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar).Value = Me.txtcatid.Text
                issuecommand.ExecuteNonQuery()
                Me.Label8.Text = "Details saved successfully..."
                Me.btnnew.Enabled = True
                Me.btnsave.Enabled = False
                Me.cmbcatname.Enabled = False
                Me.txtcattype.ReadOnly = True
                Me.cmbsid.Items.RemoveAt(Me.cmbsid.SelectedIndex)
                Me.cmbsid.Text = "Select"
                Me.txtsname.Text = ""
                Me.txtsadd.Text = ""
                If Me.cmbsid.Items.Count = 0 Then
                    Me.cmbsid.Text = "No supplier"
                    Me.cmbsid.Enabled = False
                End If
                issuecommand.CommandText = "select max(slno) from category_supplier where catid='" & Me.txtcatid.Text & "'"
                Dim s = issuecommand.ExecuteScalar
                If IsDBNull(s) Then
                    s = 1
                Else
                    s += 1
                End If
                Me.lblslno.Text = s
            Else
                Me.Label8.Text = "Fill all fields..."

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmdihome.Enabled = True
        Me.Close()
    End Sub
    Private Sub Panel1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.GotFocus
        Me.Label8.Visible = False
    End Sub
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.Label8.Text = ""
        Me.lblslno.Text = ""
        Me.cmbcatid.Visible = False
        Me.txtcatid.Visible = True
        Me.btnsave.Visible = True
        Me.btnsave.Enabled = False
        Me.btnupdate.Visible = False
        Me.cmbcatname.Enabled = True
        Me.txtcattype.ReadOnly = False
        'Me.btnsave.Enabled = True
        Me.btnnew.Enabled = False
        Me.btnedit.Enabled = True
        Me.cmbcatname.Enabled = True
        Me.btndel.Enabled = False
        Dim item As Control
        For Each item In Me.Panel1.Controls
            If TypeOf (item) Is TextBox Or TypeOf (item) Is ComboBox Then
                item.Text = ""
            End If
        Next
        Me.cmbcatname.Text = "Select"
        Me.cmbsid.Text = "Select"
        Me.Panel1.Enabled = True
        Dim dt, dt1 As New DataTable
        Dim n, k As Integer
        Dim m, i As String
        Dim a() As Integer
        a = New Integer() {0}
        n = 1
        Try
            connect()
            issuecommand.CommandText = "select catid from category"
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
            'Code for reduce the catid, if catid is deleted then it can be reused
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
            Me.txtcatid.Text = "C" & max
            Me.cmbcatid.Text = Me.txtcatid.Text
            issuecommand.CommandText = "select supid from supplier"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim z As Integer
            Me.cmbsid.Items.Clear()
            For z = 0 To dt1.Rows.Count - 1
                Me.cmbsid.Items.Add(dt1.Rows(z).Item(0))
            Next
            Me.lblslno.Text = 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbsid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbsid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbsid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsid.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.cmbsid, "")
        Me.btnsave.Enabled = True
        Me.btnupdate.Enabled = True
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select max(slno) from category_supplier where catid='" & Me.cmbcatid.Text & "'"
            Dim s = issuecommand.ExecuteScalar
            If IsDBNull(s) Then
                s = 1
            Else
                s += 1
            End If
            Me.lblslno.Text = s
            issuecommand.CommandText = "select * from supplier where supid='" & Me.cmbsid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtsname.Text = dt.Rows(0).Item(1)
            Me.txtsadd.Text = dt.Rows(0).Item(2)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbcatname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcatname.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbcatname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcatname.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.cmbcatname, "")
        Me.txtcattype.Text = ""
        If Me.cmbcatid.Visible = False Then
            Me.txtcattype.Enabled = True
        Else
            Me.txtcattype.Enabled = False
        End If
    End Sub
    Private Sub txtcattype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcattype.KeyPress
        Me.ErrorProvider1.SetError(Me.txtcattype, "")
        Me.cmbsid.Enabled = True
        If Me.cmbcatname.SelectedIndex = 1 Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
                Beep()
                Me.ErrorProvider1.SetError(Me.txtcattype, "Bearing type can contain only number.")
                e.Handled = True
            Else
                Me.ErrorProvider1.SetError(Me.txtcattype, "")
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
                Exit Sub
            End If
        ElseIf Me.cmbcatname.SelectedIndex = 0 Then
            If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
                Beep()
                Me.ErrorProvider1.SetError(Me.txtcattype, "Invalid character!")
                e.Handled = True
            Else
                Me.ErrorProvider1.SetError(Me.txtcattype, "")
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
                Exit Sub
            End If
        End If
    End Sub
    Private Sub txtcattype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcattype.Leave
        If Me.cmbcatname.SelectedIndex = 1 Then
            If Val(Me.txtcattype.Text) > 25 Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtcattype, "Invalid type of bearing")
                Me.txtcattype.Clear()
            Else
                Me.ErrorProvider1.SetError(Me.txtcattype, "")
            End If
        End If
        Dim dt As New DataTable
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from category where catname='" & Me.cmbcatname.Text & "' and type='" & Me.txtcattype.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                Me.Label8.Text = "Item already exists..."
                Me.txtcattype.Clear()
                Me.cmbsid.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.lblslno.Text = ""
        Me.Panel1.Enabled = True
        Me.btnedit.Enabled = False
        Me.btnnew.Enabled = True
        Me.btndel.Enabled = False
        Me.cmbcatid.Visible = True
        Me.txtcatid.Visible = False
        Me.btnsave.Visible = False
        Me.btnupdate.Visible = True
        Me.btnupdate.Enabled = False
        Me.cmbcatname.Enabled = False
        Me.txtcattype.Enabled = False
        Me.cmbcatname.Text = ""
        Me.txtcattype.Text = ""
        Me.cmbsid.Text = "Select"
        Me.cmbsid.Enabled = False
        Me.txtsname.Text = ""
        Me.txtsadd.Text = ""
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select catid from category where status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim z As Integer
            Me.cmbcatid.Items.Clear()
            For z = 0 To dt.Rows.Count - 1
                Me.cmbcatid.Items.Add(dt.Rows(z).Item(0))
            Next
            Me.cmbcatid.Text = "Select"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbcatid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcatid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbcatid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcatid.SelectedIndexChanged
        Me.cmbsid.Enabled = True
        'Me.cmbcatid.Enabled = True
        'Me.btnedit.Enabled = True
        'Me.btnupdate.Enabled = True
        Me.btndel.Enabled = True
        Me.txtsname.Text = ""
        Me.txtsadd.Text = ""
        Me.txtcatid.Text = Me.cmbcatid.Text
        Dim dt, dt1 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from category where catid='" & Me.cmbcatid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.cmbcatname.Text = dt.Rows(0).Item(1)
            Me.txtcattype.Text = dt.Rows(0).Item(2)
            issuecommand.CommandText = "select supid from supplier where supid not in(select supid from category_supplier where catid='" & Me.cmbcatid.Text & "')"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                Me.cmbsid.Text = "No more supplier"
                Me.cmbsid.Enabled = False
            Else
                Me.cmbsid.Text = "Select"
                Me.cmbsid.Enabled = True
                Dim z As Integer
                Me.cmbsid.Items.Clear()
                For z = 0 To dt1.Rows.Count - 1
                    Me.cmbsid.Items.Add(dt1.Rows(z).Item(0))
                Next
            End If
            issuecommand.CommandText = "select max(slno) from category_supplier where catid='" & Me.cmbcatid.Text & "'"
            Dim s = issuecommand.ExecuteScalar
            Me.lblslno.Text = s.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            connect()
            issuecommand.CommandText = "insert into category_supplier values(@slno,@supid,@catid)"
            issuecommand.CommandType = CommandType.Text
            issuecommand.Parameters.Clear()
            issuecommand.Parameters.Add("@slno", SqlDbType.BigInt).Value = Val(Me.lblslno.Text)
            issuecommand.Parameters.Add("@supid", SqlDbType.NVarChar).Value = Me.cmbsid.Text
            issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar).Value = Me.cmbcatid.Text
            issuecommand.ExecuteNonQuery()
            Me.Label8.Text = "Updated successfully..."
            Me.cmbsid.Items.RemoveAt(Me.cmbsid.SelectedIndex)
            Me.cmbsid.Text = "Select"
            Me.txtsname.Text = ""
            Me.txtsadd.Text = ""
            If Me.cmbsid.Items.Count = 0 Then
                Me.cmbsid.Text = "No supplier"
                Me.cmbsid.Enabled = False
            End If
            Me.btnupdate.Enabled = False
            'Me.cmbsid.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Label8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.TextChanged
        Me.Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 2000 Then
            Me.Label8.Text = ""
            Timer1.Stop()
        End If
    End Sub
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        'Me.btnupdate.Enabled = True
        Try
            Dim i = MsgBox("Are you sure to delete an item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete an item from category")
            If i = vbYes Then
                connect()
                issuecommand.CommandText = "update category set status=1 where catid='" & Me.cmbcatid.Text & "'"
                issuecommand.ExecuteNonQuery()
                Me.Label8.Text = "Deleted succesfully..."
                cnnstr.Close()
                btnedit_Click(sender, e)
                'Me.btnedit.Enabled = True
                Me.btnupdate.Enabled = False
                Me.btndel.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
End Class