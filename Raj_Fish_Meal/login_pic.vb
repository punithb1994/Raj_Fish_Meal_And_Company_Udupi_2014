Public Class login_pic
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub btnadmin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        usertype = "Administrator"
        frmlogin.LinkLabel1.Visible = True
        Me.btnadmin.BackColor = Color.DimGray
        Me.btnmgr.BackColor = Color.Transparent
        Me.btnstaff.BackColor = Color.Transparent
        Dim dimg As String
        dimg = Application.StartupPath
        Dim len = dimg.Length
        dimg = Mid(dimg, 1, len - 9)
        PictureBox1.Image = Image.FromFile(dimg & "Resources\ajax_loader_red_512.gif")
        Me.PictureBox1.Visible = True
        Me.Timer1.Enabled = True
        picsel = "Administrator"
        Try
            connect()
            issuecommand.CommandText = "select empid,department,username,empimage,lock from login where usertype='" & picsel & "'"
            da.SelectCommand = issuecommand
            da.Fill(ds, "login")
            eid = ds.Tables("login").Rows(0).Item(0)
            dept = ds.Tables("login").Rows(0).Item(1)
            uname = ds.Tables("login").Rows(0).Item(2)
            Dim mstream As IO.MemoryStream
            Dim imgbyte As Byte()
            imgbyte = ds.Tables("login").Rows(0).Item(3)
            mstream = New IO.MemoryStream(imgbyte)
            eimage = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnmgr_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmgr.Click
        usertype = "Manager"
        frmlogin.LinkLabel1.Visible = False
        Me.btnmgr.BackColor = Color.DimGray
        Me.btnstaff.BackColor = Color.Transparent
        Me.btnadmin.BackColor = Color.Transparent
        Dim dimg As String
        dimg = Application.StartupPath
        Dim len = dimg.Length
        dimg = Mid(dimg, 1, len - 9)
        PictureBox1.Image = Image.FromFile(dimg & "Resources\ajax_loader_red_512.gif")
        Me.PictureBox1.Visible = True
        Me.Timer1.Enabled = True
        picsel = "Manager"
    End Sub
    Private Sub btnstaff_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaff.Click
        usertype = "Staff"
        frmlogin.LinkLabel1.Visible = False
        Me.btnstaff.BackColor = Color.DimGray
        Me.btnadmin.BackColor = Color.Transparent
        Me.btnmgr.BackColor = Color.Transparent
        Dim dimg As String
        dimg = Application.StartupPath
        Dim len = dimg.Length
        dimg = Mid(dimg, 1, len - 9)
        PictureBox1.Image = Image.FromFile(dimg & "Resources\ajax_loader_red_512.gif")
        Me.PictureBox1.Visible = True
        Me.Timer1.Enabled = True
        picsel = "Staff"
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        btnadmin_Click_1(sender, e)
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        btnmgr_Click_1(sender, e)
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        btnstaff_Click_1(sender, e)
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        home.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 1000 Then
            Me.PictureBox1.Visible = False
            Me.Timer1.Stop()
            If picsel <> "Administrator" Then
                selpic.Show()
                Me.Hide()
            Else
                Me.PictureBox1.Image = eimage
                frmlogin.lbluname.Text = uname
                frmlogin.lblutype.Text = picsel
                frmlogin.txtpassword.Text = ""
                frmlogin.Show()
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub login_pic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        home.Hide()
        Me.PictureBox1.Visible = False
        ToolTip1.SetToolTip(Me.btnadmin, "Administrator")
        ToolTip1.SetToolTip(Me.btnmgr, "Manager")
        ToolTip1.SetToolTip(Me.btnstaff, "Staff")
        ToolTip1.SetToolTip(Me.PictureBox2, "Administrator")
        ToolTip1.SetToolTip(Me.PictureBox3, "Manager")
        ToolTip1.SetToolTip(Me.PictureBox4, "Staff")
        ToolTip1.SetToolTip(Me.btnclose, "Close")
        ToolTip1.SetToolTip(Me.btnclose1, "Close")
        'frmmdihome.Hide()
        'selpic.Hide()
        'frmlogin.Hide()
        Dim dt, dt1 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select empid,department,username,empimage,lock from login where usertype='Staff' and empid in(select empid from employee where status=0)"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Me.btnstaff.Enabled = False
                Me.PictureBox4.Enabled = False
            End If

            issuecommand.CommandText = "select empid,department,username,empimage,lock from login where usertype='Manager'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                Me.btnmgr.Enabled = False
                Me.PictureBox3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        Me.PictureBox2.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        Me.PictureBox3.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        Me.PictureBox4.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Me.PictureBox2.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        Me.PictureBox3.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        Me.PictureBox4.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub btnclose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose1.Click
        home.Close()
        selpic.Close()
        frmlogin.Close()
        Me.Close()
    End Sub
    Private Sub btnclose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseHover
        Me.btnclose1.Visible = True
        Me.btnclose.Visible = False
    End Sub
    Private Sub btnclose1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose1.MouseLeave
        Me.btnclose.Visible = True
        Me.btnclose1.Visible = False
    End Sub
End Class