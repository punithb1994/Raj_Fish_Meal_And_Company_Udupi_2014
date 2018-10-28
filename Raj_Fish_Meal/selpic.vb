Public Class selpic
    Dim i, j, m, n, h, v, k, a As Integer
    Dim pic As New Button
    Dim piccount As Integer
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim seid() As String
    Dim suname() As String
    Dim sdept() As String

    Private Sub selpic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        login_pic.Close()
        ToolTip1.SetToolTip(Me.btnclose, "Close")
        ToolTip1.SetToolTip(Me.btnclose1, "Close")
        ToolTip1.SetToolTip(Me.btnback, "Back")
        ToolTip1.SetToolTip(Me.Label1, usertype)
        Me.Label1.Text = usertype
        seid = New String() {""}
        suname = New String() {""}
        sdept = New String() {""}
        'Me.Label1.Text = picsel.ToUpper
        login_pic.Hide()
        Me.PictureBox1.Visible = False
        Try
            connect()
            issuecommand.CommandText = "select empid,department,username,empimage,lock from login where usertype='" & picsel & "' and empid in(select empid from employee where status=0)"
            da.SelectCommand = issuecommand
            da.Fill(ds, "login")
            piccount = ds.Tables("login").Rows.Count
            j = 0
            k = 0
            'n = Me.Size.Width - 250
            'h = n \ 170
            'h -= 1
            'a = h
            m = Me.Size.Height - 150
            v = m \ 170
            a = v
            'MsgBox(v)
            ReDim seid(piccount)
            ReDim suname(piccount)
            ReDim sdept(piccount)
            'MsgBox(ds.Tables("login").Rows(i).Item(0))
            For i = 0 To piccount - 1
                'MsgBox("i=" & i)
                seid(i) = ds.Tables("login").Rows(i).Item(0)
                sdept(i) = ds.Tables("login").Rows(i).Item(1)
                suname(i) = ds.Tables("login").Rows(i).Item(2)
                pic = New Button
                With pic
                    .Location = New Point(130 + j, 150 + k)
                    .Size = New Size(170, 170)
                    .Name = "btn" & i
                    Dim mstream As IO.MemoryStream
                    Dim imgbyte As Byte()
                    imgbyte = ds.Tables("login").Rows(i).Item(3)
                    mstream = New IO.MemoryStream(imgbyte)
                    .BackgroundImage = Image.FromStream(mstream)
                    .BackgroundImageLayout = ImageLayout.Stretch
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderSize = 5
                    .FlatAppearance.BorderColor = Color.DarkGray
                    .Cursor = Cursors.Hand
                    If ds.Tables("login").Rows(i).Item(4) = 1 Then
                        Dim dimg As String
                        dimg = Application.StartupPath
                        Dim len = dimg.Length
                        dimg = Mid(dimg, 1, len - 9)
                        .Image = Image.FromFile(dimg & "Resources\293.gif")
                        .ImageAlign = ContentAlignment.MiddleCenter
                    End If
                    k += 180
                    If i + 1 = v Then
                        'MsgBox("v=" & v)
                        j += 180
                        k = 0
                        v += a
                    End If
                End With
                Controls.Add(pic)
                AddHandler pic.Click, AddressOf btnclick
                ToolTip1.SetToolTip(pic, suname(i))
                AddHandler pic.MouseHover, AddressOf btnmousehover
                AddHandler pic.MouseLeave, AddressOf btnmouseleave
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PictureBox1.Visible = True
        Me.Timer1.Enabled = True
        Dim btn As Button = DirectCast(sender, Button)
        For i = 0 To piccount
            If btn.Name = "btn" & i Then
                eimage = btn.BackgroundImage
                uname = suname(i)
                eid = seid(i)
                dept = sdept(i)
            End If
        Next
    End Sub
    Private Sub btnmouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        For i = 0 To piccount
            If btn.Name = "btn" & i Then
                btn.FlatAppearance.BorderColor = Color.DarkGray
                btn.FlatAppearance.BorderSize = 5
            End If
        Next
    End Sub
    Private Sub btnmousehover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        For i = 0 To piccount
            If btn.Name = "btn" & i Then
                btn.FlatAppearance.BorderColor = Color.RoyalBlue
                btn.FlatAppearance.BorderSize = 7
            End If
        Next
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 1000 Then
            frmlogin.Show()
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub btnclose1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose1.Click
        home.Close()
        login_pic.Close()
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
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        login_pic.Show()
        Me.Close()
    End Sub
End Class