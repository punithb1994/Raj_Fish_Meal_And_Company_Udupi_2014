Imports System.IO
Public Class unlockuser
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim img1 As Image
    Dim flag = 0
    Private Sub unlockuser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub unlockuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnunlock.Enabled = False
        Me.txtrpassword.Enabled = False
        'tooltips
        ToolTip1.SetToolTip(Me.cmbempid, "Select employee id to unlock user")
        ToolTip1.SetToolTip(Me.empname, "Employee name")
        ToolTip1.SetToolTip(Me.txtusertype, "User type")
        ToolTip1.SetToolTip(Me.txtdept, "Employee department")
        ToolTip1.SetToolTip(Me.txtpassword, "Enter new password")
        ToolTip1.SetToolTip(Me.txtrpassword, "Re-enter password")
        ToolTip1.SetToolTip(Me.empimage, "Employee image")
        ToolTip1.SetToolTip(Me.btnunlock, "Click here to unlock user")
        Me.txtpassword.Focus()
        Dim dt1 As New DataTable
        img1 = Me.empimage.Image
        Me.txtpassword.Enabled = False
        Me.txtrpassword.Enabled = False
        Me.txtpassword.Text = ""
        Me.txtrpassword.Text = ""
        Me.cmbempid.Text = ""
        Try
            connect()
            issuecommand.CommandText = "select empid from login where lock=1"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                Panel1.BringToFront()
                Panel1.Visible = True
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

    Private Sub cmbempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        Dim dt As New DataTable
        Me.btnunlock.Enabled = True
        Me.txtpassword.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select * from login where empid='" & Me.cmbempid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtusertype.Text = dt.Rows(0).Item(1)
            Me.txtdept.Text = dt.Rows(0).Item(2)
            Me.empname.Text = dt.Rows(0).Item(3)
            Dim mstream As IO.MemoryStream
            Dim imgbyte As Byte()
            imgbyte = dt.Rows(0).Item(5)
            mstream = New IO.MemoryStream(imgbyte)
            empimage.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnunlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunlock.Click
        Dim dt1 As New DataTable
        Dim flag As Integer
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
                connect()
                If Me.txtpassword.Text = Me.txtrpassword.Text Then
                    issuecommand.CommandText = "update login set password='" & Me.txtpassword.Text & "',lock=0 where empid='" & Me.cmbempid.Text & "'"
                    issuecommand.ExecuteNonQuery()
                    MsgBox("Your account has been unlocked")
                    Me.ErrorProvider1.Clear()
                    Me.PictureBox2.Visible = False
                    Me.PictureBox1.Visible = False
                    Me.empname.Clear()
                    Me.txtdept.Clear()
                    Me.txtusertype.Clear()
                    empimage.Image = img1
                    'Me.ErrorProvider1.Clear()
                    Me.btnunlock.Enabled = False
                    cnnstr.Close()
                    unlockuser_Load(sender, e)
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
            Me.ErrorProvider1.SetError(Me.txtpassword, "Password should contain atleast 8 characters")
            Me.txtpassword.Clear()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If Me.txtpassword.Text.Length > 1 Then
            Me.txtrpassword.Enabled = True
        End If
        Me.ErrorProvider1.SetError(Me.txtpassword, "")
    End Sub

    Private Sub txtrpassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrpassword.TextChanged
        Me.ErrorProvider1.SetError(Me.txtrpassword, "")
    End Sub

    Private Sub btnlckok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        frmmdihome.btnhome.Visible = False
        frmmdihome.Panel2.Visible = True
        Me.Close()
    End Sub
End Class