Imports System.Net.Mail
Public Class frmlogin
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim counter, flag As Integer
    Dim n = 0
    Sub linklbl()
        Try
            connect()
            issuecommand.CommandText = "select email from employee where designation='Administrator'"
            Dim k = issuecommand.ExecuteScalar
            'MsgBox(k.ToString)
            issuecommand.CommandText = "select password from login where usertype='Administrator'"
            Dim i = issuecommand.ExecuteScalar
            'MsgBox(i.ToString)
            Dim msg As New MailMessage
            msg.From = New MailAddress(k.ToString)
            msg.[To].Add(k.ToString)
            msg.Subject = "Hi Admin,"
            msg.Body = "Your password is " & i
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("sandeshacharya761@gmail.com", "sandeshblue")
            smtp.EnableSsl = True
            smtp.Send(msg)
            'MsgBox(msg.ToString)
            Me.Timer1.Enabled = True
            Me.Panel2.BringToFront()
            Me.Panel2.Visible = True
        Catch ex As Exception
            Beep()
            MsgBox("No internet connection", MsgBoxStyle.Information, "Login")
        Finally
            cnnstr.Close()
            'Me.Timer1.Enabled = True
            'Me.Panel2.Visible = True
        End Try
    End Sub
    Public Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        selpic.Close()
        If IsKeyLocked(Keys.CapsLock) Then
            Me.lblcapslock.Visible = True
        End If
        ToolTip1.SetToolTip(Me.btnclose, "Close")
        ToolTip1.SetToolTip(Me.btnclose1, "Close")
        ToolTip1.SetToolTip(Me.btnback, "Back")
        ToolTip1.SetToolTip(Me.PictureBox1, uname)
        ToolTip1.SetToolTip(Me.lbluname, "User name")
        ToolTip1.SetToolTip(Me.lblutype, "Designation")
        ToolTip1.SetToolTip(Me.txtpassword, "Password")
        ToolTip1.SetToolTip(Me.btnok, "Click OK to try again")
        ToolTip1.SetToolTip(Me.btnlogin, "Click to login")
        ToolTip1.SetToolTip(Me.LinkLabel1, "Click here, if forgot your password." & ControlChars.CrLf & "Your password will be sent your E-mail address.")
        ToolTip1.SetToolTip(Me.btnlckok, "Click OK to close")
        ToolTip1.SetToolTip(Me.btnpok, "OK")
        ToolTip1.SetToolTip(Me.btnpcancel, "Cancel")
        'frmmdihome.Close()
        Me.PictureBox1.Image = eimage
        Me.lbluname.Text = uname
        Me.lblutype.Text = picsel
        Me.txtpassword.Text = ""
        counter = 0
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select lock from login where empid='" & eid & "' and username='" & uname & "' and usertype='" & usertype & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows(0).Item(0) = 1 Then
                Me.Label2.Text = "Your account is locked. Contact administrator to change password."
                Me.Panel1.BringToFront()
                Me.Panel1.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        login_pic.Show()
        Me.Close()
    End Sub
    Private Sub btnlogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim pwrd = Me.txtpassword.Text
        Dim i, n As Integer
        Try
            flag = 0
            connect()
            issuecommand.CommandText = "select * from login"
            da.SelectCommand = issuecommand
            da.Fill(ds, "login")
            n = ds.Tables("login").Rows.Count
            For i = 0 To n - 1
                If usertype = ds.Tables("login").Rows(i).Item(1) And uname = ds.Tables("login").Rows(i).Item(3) And pwrd = ds.Tables("login").Rows(i).Item(4) Then
                    If usertype = "Administrator" Then
                        frmmdihome.MenuToolStripMenuItem.Visible = True
                        frmmdihome.EmployeeToolStripMenuItem.Visible = True
                        frmmdihome.SalesToolStripMenuItem.Visible = True
                        frmmdihome.FinishedGoodsToolStripMenuItem.Visible = True
                        frmmdihome.CustomerToolStripMenuItem.Visible = True
                        frmmdihome.InventoryToolStripMenuItem.Visible = True
                        frmmdihome.PurchaseToolStripMenuItem.Visible = True
                        frmmdihome.SupplierToolStripMenuItem.Visible = True
                        frmmdihome.ReportsToolStripMenuItem.Visible = True
                        frmmdihome.ToolStripMenuItem4.Visible = True
                        frmmdihome.ToolStripMenuItem5.Visible = False
                        frmmdihome.PictureBox1.Image = eimage
                        frmmdihome.Label3.Text = uname
                        'Me.Hide()
                        frmmdihome.frmmdihome_Load(sender, e)
                        frmmdihome.Show()
                    ElseIf usertype = "Manager" Then
                        If dept = "Purchase" Or dept = "Store" Then
                            frmmdihome.MenuToolStripMenuItem.Visible = False
                            frmmdihome.EmployeeToolStripMenuItem.Visible = False
                            frmmdihome.SalesToolStripMenuItem.Visible = False
                            frmmdihome.FinishedGoodsToolStripMenuItem.Visible = False
                            frmmdihome.CustomerToolStripMenuItem.Visible = False
                            frmmdihome.InventoryToolStripMenuItem.Visible = True
                            frmmdihome.PurchaseToolStripMenuItem.Visible = True
                            frmmdihome.SupplierToolStripMenuItem.Visible = True
                            frmmdihome.ReportsToolStripMenuItem.Visible = False
                            frmmdihome.ToolStripMenuItem4.Visible = False
                            frmmdihome.ToolStripMenuItem5.Visible = False
                            frmmdihome.PictureBox1.Image = eimage
                            frmmdihome.Label3.Text = uname
                            frmmdihome.PictureBox1.Image = eimage
                            frmmdihome.Label3.Text = uname
                            'Me.Hide()
                            frmmdihome.frmmdihome_Load(sender, e)
                            frmmdihome.Show()
                        ElseIf dept = "Sales" Then
                            frmmdihome.MenuToolStripMenuItem.Visible = False
                            frmmdihome.EmployeeToolStripMenuItem.Visible = False
                            frmmdihome.SalesToolStripMenuItem.Visible = True
                            frmmdihome.FinishedGoodsToolStripMenuItem.Visible = True
                            frmmdihome.CustomerToolStripMenuItem.Visible = True
                            frmmdihome.InventoryToolStripMenuItem.Visible = False
                            frmmdihome.PurchaseToolStripMenuItem.Visible = False
                            frmmdihome.SupplierToolStripMenuItem.Visible = False
                            frmmdihome.ReportsToolStripMenuItem.Visible = False
                            frmmdihome.ToolStripMenuItem4.Visible = False
                            frmmdihome.ToolStripMenuItem5.Visible = False
                            frmmdihome.PictureBox1.Image = eimage
                            frmmdihome.Label3.Text = uname
                            'Me.Hide()
                            frmmdihome.frmmdihome_Load(sender, e)
                            frmmdihome.Show()
                        End If
                    ElseIf usertype = "Staff" Then
                        frmmdihome.MenuToolStripMenuItem.Visible = False
                        frmmdihome.EmployeeToolStripMenuItem.Visible = False
                        frmmdihome.SalesToolStripMenuItem.Visible = False
                        frmmdihome.FinishedGoodsToolStripMenuItem.Visible = False
                        frmmdihome.CustomerToolStripMenuItem.Visible = False
                        frmmdihome.InventoryToolStripMenuItem.Visible = False
                        frmmdihome.PurchaseToolStripMenuItem.Visible = False
                        frmmdihome.SupplierToolStripMenuItem.Visible = False
                        frmmdihome.ReportsToolStripMenuItem.Visible = False
                        frmmdihome.ToolStripMenuItem4.Visible = False
                        frmmdihome.ToolStripMenuItem5.Visible = True
                        frmmdihome.PictureBox1.Image = eimage
                        frmmdihome.Label3.Text = uname
                        'Me.Hide()
                        frmmdihome.frmmdihome_Load(sender, e)
                        frmmdihome.Show()
                    End If
                    Exit For
                Else
                    flag = 1
                End If
            Next
            If flag = 1 Then
                Me.txtpassword.Visible = False
                Me.invalid.Visible = True
                Me.btnok.Visible = True
                Me.lblcapslock.Visible = False
                counter = counter + 1
                If counter = 3 Then
                    Try
                        If usertype <> "Administrator" Then
                            issuecommand.CommandText = "update login set lock=" & 1 & " where empid='" & eid & "' and username='" & uname & "' and usertype='" & usertype & "'"
                            issuecommand.ExecuteNonQuery()
                            'MsgBox("saved to lock")
                            Me.Panel1.BringToFront()
                            Me.Panel1.Visible = True
                        Else
                            Me.Panel3.BringToFront()
                            Me.Panel3.Visible = True
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Me.txtpassword.Visible = True
        Me.btnok.Visible = True
        Me.invalid.Visible = False
        Me.btnok.Visible = False
        Me.txtpassword.Focus()
        Me.txtpassword.Text = ""
        Me.LinkLabel1.Visible = False
        If IsKeyLocked(Keys.CapsLock) Then
            Me.lblcapslock.Visible = True
        Else
            Me.lblcapslock.Visible = False
        End If
    End Sub
    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If Me.btnlogin.Visible = True Then
            Me.btnlogin_Click_1(sender, e)
            'End If
            'If Me.btnok.Visible = True Then
            '    btnok_Click(sender, e)
            'End If
        End If
        If e.KeyCode = Keys.CapsLock = True Then
            If IsKeyLocked(Keys.CapsLock) Then
                Me.lblcapslock.Visible = True
            Else
                Me.lblcapslock.Visible = False
            End If
        End If
    End Sub
    Private Sub btnclose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseHover
        Me.btnclose1.Visible = True
        Me.btnclose.Visible = False
    End Sub
    Private Sub btnclose1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose1.Click
        home.Close()
        login_pic.Close()
        selpic.Close()
        Me.Close()
    End Sub
    Private Sub btnclose1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose1.MouseLeave
        Me.btnclose.Visible = True
        Me.btnclose1.Visible = False
    End Sub
    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If txtpassword.TextLength > 24 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        linklbl()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 3000 Then
            Me.Panel2.Visible = False
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel2.Visible = False
    End Sub
    Private Sub btnlckok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        login_pic.Show()
        Me.Close()
    End Sub
    Private Sub btnpok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpok.Click
        Try
            linklbl()
            Me.Panel3.Visible = False
            btnback_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnpcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpcancel.Click
        Me.Panel3.Visible = False
        btnback_Click(sender, e)
    End Sub
End Class
