Public Class frmmdihome
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Sub onlyone()
        Me.btnhome.Visible = True
        Dim i As Form
        For Each i In Me.MdiChildren
            i.Close()
        Next
    End Sub
    Private Sub AddEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As frmaddemployee
        a = frmaddemployee
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()

    End Sub
    Private Sub CreateLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateLoginToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As createnewuser
        a = createnewuser
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub SearchInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchInventoryToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As searchinventory
        a = searchinventory
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub AddSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSupplierToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As addnewsupplier
        a = addnewsupplier
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub EditSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSupplierToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As editsupplier
        a = editsupplier
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As removeemployee
        a = removeemployee
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub InventoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem1.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As factoryconsumption
        a = factoryconsumption
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As employeedetails
        a = employeedetails
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub SalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        'Dim dimg As String
        'dimg = Application.StartupPath
        'Dim len = dimg.Length
        'dimg = Mid(dimg, 1, len - 9)
        'Me.EmployeeToolStripMenuItem.BackgroundImage = Image.FromFile(dimg & "Resources\nav_on_.png")
        Dim a As salary
        a = salary
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub AttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As attendance
        a = attendance
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub CreatePurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePurchaseOrderToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As createpurchaseorder
        a = createpurchaseorder
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub PurchaseBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseBillToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As purchaseinvoice
        a = purchaseinvoice
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub SearchSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSupplierToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As searchsupplier
        a = searchsupplier
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As unlockuser
        a = unlockuser
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As editemployee
        a = editemployee
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub SalesOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesOrderToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As salesorder
        a = salesorder
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub AddCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As addcustomer
        a = addcustomer
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub ViewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As viewcustomer
        a = viewcustomer
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub EditCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCustomerToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As updatecustomer
        a = updatecustomer
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub SalesBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesBillToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As salesbill
        a = salesbill
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As salesdetails
        a = salesdetails
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub AddStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStockToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As addstock
        a = addstock
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub ViewStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As viewstock
        a = viewstock
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    Private Sub PurchaseReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As purchasereturn
        a = purchasereturn
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
  
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        onlyone()
        Me.Panel3.Hide()
        Me.btnhome.Visible = True
        Dim a As settings
        a = settings
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
    'Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
    '    Me.Panel3.Hide()
    '    Me.Button1.Visible = True
    '    Dim a As salesorderedit
    '    a = salesorderedit
    '    a.MdiParent = Me
    '    a.StartPosition = FormStartPosition.CenterScreen
    '    a.Show()
    '    a.WindowState = FormWindowState.Maximized
    '    Me.Panel1.SendToBack()
    'End Sub
    Private Sub frmmdihome_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmlogin.Close()
        login_pic.Close()
        home.Close()
    End Sub
    Private Sub frmmdihome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Panel5new.Visible = True Or Me.Panel4current.Visible = True Then
            e.Cancel = True
        End If
        'To display message of confirmation before closing form
        'Dim w As Integer
        'w = MsgBox("Do you want to Exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Alert Message")
        'If w = vbNo Then
        '    e.Cancel = True
        'End If
    End Sub
    Public Sub frmmdihome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips

        ToolTip1.SetToolTip(Me.btnhome, "Home")
        ToolTip1.SetToolTip(Me.btnnxt1, "Next")
        ToolTip1.SetToolTip(Me.btncancel1, "Cancel")
        ToolTip1.SetToolTip(Me.TextBox1, "Enter current password")

        ToolTip1.SetToolTip(Me.TextBox3, "Enter new password")
        ToolTip1.SetToolTip(Me.TextBox2, "Re-enter new password")
        ToolTip1.SetToolTip(Me.Button5, "Finish")
        ToolTip1.SetToolTip(Me.Button4, "Cancel")
        ToolTip1.SetToolTip(Me.btnchangepswrd, "Click here to change password")
        ToolTip1.SetToolTip(Me.btnlck, "Click here to lock")
        ToolTip1.SetToolTip(Me.btnsignout, "Logout")

        'MsgBox("hi")
        frmlogin.Close()
        Me.Panel2.Visible = True
        Me.PictureBox1.Image = eimage
        Me.Label3.Text = uname
        Me.Label15.Text = usertype
        Me.btnhome.Visible = False
        'If Timer1.Interval = 0 Then
        '    Timer1.Interval = 1000
        'End If
        Me.Panel4current.Visible = False
        Me.Panel5new.Visible = False
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Double click on item to order")
        Dim dt As New DataTable
        Dim ctr As Integer = 0
        Try
            If usertype = "Administrator" Or (usertype = "Manager" And dept = "Purchase") Then
                cnnstr.Close()
                connect()
                issuecommand.CommandText = "select category.catname,category.type from category where catid in(select catid from rawinventory where qty<=5)"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Dim i As Integer
                    Me.ListBox1.Items.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        ctr = ctr + 1
                        Me.ListBox1.Items.Add(dt.Rows(i).Item(0) & "  -  " & dt.Rows(i).Item(1))
                    Next
                    'MsgBox(ctr)
                    Me.NotifyIcon1.Visible = True
                    Me.NotifyIcon1.ShowBalloonTip(10, "Re-order level", ctr & " items reached out of order", ToolTipIcon.Info)
                End If
            End If
            rpt8 = "{employee.empid}='" & eid & "'"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 10 Then
            Me.Timer1.Interval = 10
        End If
        Dim min, hr, str As String
        str = "am"
        If (DateAndTime.Minute(Now) < 10) Then
            min = "0" & DateAndTime.Minute(Now)
        Else
            min = DateAndTime.Minute(Now)
        End If
        hr = DateAndTime.Hour(Now)
        If (hr > 12) Then
            str = "pm"
            hr = hr - 12
        End If
        If (hr < 10) Then
            hr = "0" & hr
        End If
        Me.Label1.Text = hr & ":" & min  ' ControlChars.CrLf &
        Me.Label2.Text = DateAndTime.WeekdayName(DateAndTime.Weekday(Now)) & ControlChars.CrLf & DateAndTime.MonthName(DateAndTime.Month(Now)) & " " & DateAndTime.Day(Now)
    End Sub
    Private Sub MenuToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.MouseHover
        Me.MenuToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub EmployeeToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.MouseHover
        Me.EmployeeToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub InventoryToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem.MouseHover
        Me.InventoryToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub PurchaseToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.MouseHover
        Me.PurchaseToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub SupplierToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.MouseHover
        Me.SupplierToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub SalesToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.MouseHover
        Me.SalesToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub FinishedGoodsToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles FinishedGoodsToolStripMenuItem.MouseHover
        Me.FinishedGoodsToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub CustomerToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.MouseHover
        Me.CustomerToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub ReportsToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.MouseHover
        Me.ReportsToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub frmmdihome_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        Me.Panel2.Visible = False
    End Sub
    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        onlyone()
        frmlogin.frmlogin_Load(sender, e)
        login_pic.Show()
        frmlogin.txtpassword.Text = ""
        Me.Hide()
    End Sub
    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        If Me.Panel3.Visible = True Then
            Me.Panel3.Visible = False
        Else
            Me.Panel3.BringToFront()
            Me.Panel3.Visible = True
            Me.Panel3.Focus()
            Me.Timer3.Enabled = True
        End If
    End Sub
    Private Sub Panel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Me.Panel2.BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Me.Panel2.BackColor = Color.FromArgb(35, 35, 35)
    End Sub
    Private Sub ListBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Panel3.Visible = False
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If Me.Panel3.Visible = True Then
            Me.Panel3.Visible = False
        Else
            Me.Panel3.Visible = True
            Me.Panel3.Focus()
            Me.Timer3.Enabled = True
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Me.Panel3.Visible = True Then
            Me.Panel3.Visible = False
        Else
            Me.Panel3.Visible = True
            Me.Panel3.Focus()
            Me.Timer3.Enabled = True
        End If
    End Sub
    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Me.Panel2.BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Me.Panel2.BackColor = Color.FromArgb(35, 35, 35)
    End Sub
    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Me.Panel2.BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Me.Panel2.BackColor = Color.FromArgb(35, 35, 35)
    End Sub
    Private Sub btnchangepswrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangepswrd.Click
        Me.Panel3.Visible = False
        'Me.Enabled = False
        Me.MenuStrip1.Enabled = False
        Me.Panel2.Enabled = False
        Me.Panel4current.BringToFront()
        Me.Panel4current.Visible = True
        Me.PictureBox2.Image = eimage
        Me.lbluname.Text = uname
        Me.Label7.Visible = False
        Me.Label12.Visible = False
        Me.TextBox1.Clear()
        Me.Label7.Visible = False
        Me.Label12.Visible = False
    End Sub
    Private Sub btnlck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlck.Click
        Me.Panel3.Visible = False
        frmlockscreen.WindowState = FormWindowState.Maximized
        frmlogin.Show()
        frmlockscreen.Show()
        Me.Hide()

    End Sub
    Private Sub btnsignout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsignout.Click
        onlyone()
        Me.Panel3.Visible = False
        frmlogin.frmlogin_Load(sender, e)
        login_pic.Show()
        frmlogin.txtpassword.Text = ""
        Me.Hide()
    End Sub
    Private Sub btnnxt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnxt1.Click
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select password from login where empid='" & eid & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If Me.TextBox1.Text <> "" Then
                If Me.TextBox1.Text = dt.Rows(0).Item(0) Then
                    Me.Panel5new.BringToFront()
                    Me.Panel5new.Visible = True
                    Me.Panel4current.Visible = False
                    Me.Label7.Visible = True
                    Me.Button4.Visible = True
                    Me.PictureBox3.Visible = False
                    'Me.Label3.Visible = False
                    Me.Label14.Visible = False
                    Me.Label5.Visible = False
                    Me.TextBox2.Clear()
                    Me.TextBox3.Clear()
                Else
                    Me.Label12.Visible = True
                    Me.Label7.Visible = False
                    Me.TextBox1.Clear()
                End If
            Else
                Me.Label7.Visible = True
                Me.Label12.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btncancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel1.Click
        Me.Panel4current.Visible = False
        Me.Panel5new.Visible = False
        Me.TextBox1.Clear()
        Me.MenuStrip1.Enabled = True
        Me.Panel2.Enabled = True
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            connect()
            If Me.TextBox3.TextLength >= 8 Then
                If Me.TextBox2.Text = Me.TextBox3.Text Then
                    issuecommand.CommandText = "update login set password='" & Me.TextBox2.Text & "' where empid='" & eid & "'"
                    issuecommand.ExecuteNonQuery()
                    Me.Button4.Visible = False
                    Me.PictureBox3.Visible = True
                    Me.Label13.BringToFront()
                    Me.Label13.Visible = True
                    Me.MenuStrip1.Enabled = True
                    Me.Panel2.Enabled = True
                    Me.Timer2.Enabled = True
                Else
                    Me.Label5.Visible = True
                    Me.Label14.Visible = False
                End If
            Else
                Me.Label14.Visible = True
                Me.Label5.Visible = False
                Me.TextBox2.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Timer2.Interval = 2000 Then
            Me.Panel5new.Visible = False
            Me.Timer2.Stop()
            Me.PictureBox3.Visible = False
            Me.Label13.Visible = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Panel4current.Visible = False
        Me.Panel5new.Visible = False
        Me.TextBox1.Clear()
        Me.MenuStrip1.Enabled = True
        Me.Panel2.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhome.Click
        onlyone()
        Me.Panel2.Visible = True
        Me.btnhome.Visible = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Timer3.Interval = 3000 Then
            Me.Panel3.Visible = False
        End If
    End Sub

    Private Sub Panel3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseEnter
        Me.Timer3.Stop()
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Me.Timer3.Interval = 3000
        Me.Timer3.Start()
    End Sub

    Private Sub btnchangepswrd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnchangepswrd.MouseEnter
        Me.Timer3.Stop()
    End Sub

    Private Sub btnlck_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlck.MouseEnter
        Me.Timer3.Stop()
    End Sub

    Private Sub btnsignout_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsignout.MouseEnter
        Me.Timer3.Stop()
    End Sub

    Private Sub btnchangepswrd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnchangepswrd.MouseLeave
        Me.Timer3.Interval = 3000
        Me.Timer3.Start()
    End Sub

    Private Sub btnlck_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlck.MouseLeave
        Me.Timer3.Interval = 3000
        Me.Timer3.Start()
    End Sub

    Private Sub btnsignout_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsignout.MouseLeave
        Me.Timer3.Interval = 3000
        Me.Timer3.Start()
    End Sub

    Private Sub FactoryOrderReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactoryOrderReportToolStripMenuItem.Click
        factconsumrpt.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dailyreportToolStripMenuItem1.Click
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from dailyproduction where mfgdate='" & Today.Date & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                onlyone()
                rpt4 = "{dailyproduction.mfgdate}=#" & Today.Date & "#"
                Me.Panel3.Hide()
                Me.Panel1.SendToBack()
                Me.btnhome.Visible = False
                Dim a As Form
                a = frmdailyreport
                a.MdiParent = Me
                a.StartPosition = FormStartPosition.CenterScreen
                a.Show()
                a.WindowState = FormWindowState.Maximized
            Else
                MsgBox("No record found.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Daily report")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from purchaseinvoicedetail where recdate='" & Today.Date & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                onlyone()
                rpt5 = "{purchaseinvoicedetail.recdate}=#" & Today.Date & "#"
                Me.Panel3.Hide()
                Me.Panel1.SendToBack()
                Me.btnhome.Visible = False
                Dim a As Form
                a = frmpurchasereport
                a.MdiParent = Me
                a.StartPosition = FormStartPosition.CenterScreen
                a.Show()
                a.WindowState = FormWindowState.Maximized
            Else
                MsgBox("No record found.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Purchase report")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub FactoryConsumptionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactoryConsumptionReportToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        Me.Panel1.SendToBack()
        Me.btnhome.Visible = False
        Dim a As Form
        a = frmstock
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Me.ListBox1.Visible = True
        Me.Timer4.Enabled = True
        Me.Focus()
        Me.NotifyIcon1.Visible = False
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Me.Timer4.Interval = 4000 Then
            Me.ListBox1.Visible = False
            Me.Timer4.Stop()
        End If
    End Sub

    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Me.ListBox1.Visible = False
        Me.CreatePurchaseOrderToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ListBox1.Visible = False
    End Sub

    Private Sub ListBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.MouseEnter
        Me.Timer4.Stop()
    End Sub

    Private Sub ListBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.MouseLeave
        Me.Timer4.Start()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from salesbill where billdate='" & Today.Date & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                onlyone()
                rpt7 = "{salesbill.billdate}=#" & Today.Date & "#"
                Me.Panel3.Hide()
                Me.Panel1.SendToBack()
                Me.btnhome.Visible = False
                Dim a As Form
                a = frmsalesreport
                a.MdiParent = Me
                a.StartPosition = FormStartPosition.CenterScreen
                a.Show()
                a.WindowState = FormWindowState.Maximized
            Else
                MsgBox("No record found.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sales report")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        onlyone()
        Me.Panel3.Hide()
        'Me.Panel1.SendToBack()
        Me.btnhome.Visible = False
        Dim a As Form
        a = frmemprpt
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        onlyone()
        Me.Panel3.Hide()
        'Me.Panel1.SendToBack()
        Me.btnhome.Visible = False
        Dim a As Form
        a = frmempviewprof
        a.MdiParent = Me
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
        Me.Panel1.SendToBack()
    End Sub
End Class