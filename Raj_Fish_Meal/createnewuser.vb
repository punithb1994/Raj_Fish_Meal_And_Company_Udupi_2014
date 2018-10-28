Imports System.IO
Public Class createnewuser
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim img1 As Image
    Dim flag = 0
    Private Sub createnewuser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub frmcreatenewuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.cmbempid, "Select employee id to create user")
        ToolTip1.SetToolTip(Me.empname, "Employee name")
        ToolTip1.SetToolTip(Me.txtusertype, "User type")
        ToolTip1.SetToolTip(Me.txtdept, "Employee department")
        ToolTip1.SetToolTip(Me.txtpassword, "Enter password")
        ToolTip1.SetToolTip(Me.txtrpassword, "Re-enter password")
        ToolTip1.SetToolTip(Me.empimage, "Employee image")
        ToolTip1.SetToolTip(Me.btncreateuser, "Click here to create new user")
        Me.txtpassword.Focus()
        Dim dt1 As New DataTable
        img1 = Me.empimage.Image
        Me.txtpassword.Enabled = False
        Me.txtpassword.Enabled = False
        Me.txtrpassword.Enabled = False
        Try
            connect()
            issuecommand.CommandText = "select empid from employee where empid not in(select distinct empid from login) and status=0"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                Me.GroupBox1.Enabled = False
                Me.Panel1.BringToFront()
                Me.Panel1.Visible = True
                Exit Sub
            End If
            Dim i As Integer
            Me.cmbempid.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                Me.cmbempid.Items.Add(dt1.Rows(i).Item(0))
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
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        Dim dt As New DataTable
        Me.btncreateuser.Enabled = True
        Me.txtpassword.Enabled = True
        Me.txtrpassword.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select * from employee where empid='" & Me.cmbempid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.empname.Text = dt.Rows(0).Item(1)
            Me.txtusertype.Text = dt.Rows(0).Item(10)
            Me.txtdept.Text = dt.Rows(0).Item(11)
            Dim mstream As IO.MemoryStream
            Dim imgbyte As Byte()
            imgbyte = dt.Rows(0).Item(12)
            mstream = New IO.MemoryStream(imgbyte)
            empimage.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try

    End Sub
    Private Sub btncreateuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateuser.Click
        Try
            If Me.txtpassword.TextLength < 8 Then
                Me.ErrorProvider1.SetError(Me.txtpassword, "Password can contain atleast 8 characters")
                flag = 1
            End If
            If Me.txtpassword.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtpassword, "Password must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtpassword, "")
                If Me.txtrpassword.Text = "" Then
                    flag = 1
                    Me.ErrorProvider1.SetError(Me.txtrpassword, "Confirm your password")
                Else
                    Me.ErrorProvider1.SetError(Me.txtrpassword, "")
                End If
            End If
            If flag = 0 Then
                If Me.txtpassword.Text = Me.txtrpassword.Text Then
                    connect()
                    issuecommand.CommandText = "insert into login values(@empid,@usertype,@department,@empname,@password,@empimage,@lock)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@empid", SqlDbType.NVarChar, 50).Value = Me.cmbempid.Text
                    issuecommand.Parameters.Add("@usertype", SqlDbType.VarChar, 50).Value = Me.txtusertype.Text
                    issuecommand.Parameters.Add("@department", SqlDbType.VarChar, 50).Value = Me.txtdept.Text
                    issuecommand.Parameters.Add("@empname", SqlDbType.VarChar, 50).Value = empname.Text
                    issuecommand.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtpassword.Text
                    Dim img As Image
                    Dim mstream As IO.MemoryStream = New IO.MemoryStream
                    img = Me.empimage.Image
                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    issuecommand.Parameters.Add("@empimage", SqlDbType.Image).Value = mstream.GetBuffer
                    issuecommand.Parameters.Add("@lock", SqlDbType.Int).Value = 0
                    issuecommand.ExecuteNonQuery()
                    MsgBox("Account created successfully", MsgBoxStyle.MsgBoxRight, "Account creation")
                    Me.cmbempid.Items.RemoveAt(Me.cmbempid.SelectedIndex)
                    If Me.cmbempid.Items.Count = 0 Then
                        Me.GroupBox1.Enabled = False
                        Me.Panel1.BringToFront()
                        Me.Panel1.Visible = True
                    End If
                    Dim item As Control
                    For Each item In Me.GroupBox2.Controls
                        If TypeOf (item) Is TextBox Or TypeOf (item) Is ComboBox Then
                            item.Text = ""
                        End If
                    Next
                    empimage.Image = img1
                    Me.txtpassword.Enabled = False
                    Me.txtrpassword.Enabled = False
                    Me.btncreateuser.Enabled = False
                    Me.PictureBox2.Visible = False
                    Me.PictureBox1.Visible = False
                Else
                    MsgBox("Password doesn't match.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 100 Then
            Me.Timer1.Start()
        End If
        If Me.PictureBox2.Visible = True Then
            Me.Timer1.Stop()
        End If
        If Me.txtrpassword.TextLength <> 0 Then
            If Me.txtpassword.Text <> Me.txtrpassword.Text Then
                Me.PictureBox1.Visible = True
                Me.PictureBox2.Visible = False
            Else
                Me.PictureBox2.Visible = True
                Me.PictureBox1.Visible = False
            End If
        End If
    End Sub
    Private Sub txtrpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrpassword.KeyPress
        Me.Timer1.Enabled = True
        If Me.txtpassword.TextLength = 0 Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtrpassword, "Enter password first")
            e.Handled = True
        End If
        If txtrpassword.TextLength > 24 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        Me.ErrorProvider1.SetError(Me.txtpassword, "")
        Me.ErrorProvider1.SetError(Me.txtrpassword, "")
        If txtpassword.TextLength > 24 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtpassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.Leave
        If Me.txtpassword.TextLength < 8 Then
            Beep()
            Me.txtpassword.Clear()
            Me.ErrorProvider1.SetError(Me.txtpassword, "Password can contain atleast 8 characters")
        End If
    End Sub
    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If Me.txtpassword.Text.Length > 1 Then
            Me.txtrpassword.Enabled = True
        End If
        Me.ErrorProvider1.SetError(Me.txtpassword, "")
    End Sub
    Private Sub txtrpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrpassword.TextChanged
        Me.ErrorProvider1.SetError(Me.txtrpassword, "")
    End Sub
    Private Sub btnlckok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        Me.Close()
    End Sub
End Class