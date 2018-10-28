Public Class searchinventory
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim flag As Integer
    Private Sub searchinventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub btnfish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfish.Click
        Try
            flag = 1
            Me.ComboBox1.Visible = True
            Me.cmbitemtype.Visible = False
            DataGridView2.Visible = True
            Me.DataGridView1.Visible = False
            Me.ComboBox1.Text = "TYPE"
            connect()
            Dim dt As New DataTable
            issuecommand.CommandText = "select type from category where catname='" & Me.btnfish.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.ComboBox1.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.ComboBox1.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnhw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhardware.Click
        Try
            flag = 0
            Me.DataGridView2.Visible = True
            Me.DataGridView1.Visible = False
            Me.ComboBox1.Visible = True
            Me.cmbitemtype.Visible = True
            Me.ComboBox1.Text = "CATEGORY NAME"
            Me.cmbitemtype.Text = "TYPE"
            connect()
            Dim dt, dt1 As New DataTable
            issuecommand.CommandText = "select distinct catname from category where catname !='" & Me.btnfish.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.ComboBox1.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.ComboBox1.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.cmbitemtype.Text = "TYPE"
        Try
            Dim dt, dt1 As New DataTable
            If flag = 1 Then
                DataGridView1.Visible = True
                Me.DataGridView2.Visible = False
                issuecommand.CommandText = "select category.catname,category.type,rawinventory.qty from category,rawinventory where category.type='" & Me.ComboBox1.Text & "' and rawinventory.catid=category.catid"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                Me.DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub searchinventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.btnfish, "Search inventory details related to fish")
        ToolTip1.SetToolTip(Me.btnhardware, "Search inventory details related to hardware")
        ToolTip1.SetToolTip(Me.ComboBox1, "Select item")
        ToolTip1.SetToolTip(Me.cmbitemtype, "Select item type")
        Me.ComboBox1.Visible = False
        Me.cmbitemtype.Visible = False
        Me.DataGridView2.Visible = True
        Me.DataGridView1.Visible = False
    End Sub
    Private Sub cmbitemtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbitemtype.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbitemtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitemtype.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            DataGridView1.Visible = True
            Me.DataGridView2.Visible = False
            issuecommand.CommandText = "select category.catname,category.type,rawinventory.qty from category,rawinventory where category.catname='" & Me.ComboBox1.Text & "' and category.type='" & Me.cmbitemtype.Text & "' and rawinventory.catid=category.catid"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try

    End Sub
    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Try
            Dim dt As New DataTable
            issuecommand.CommandText = "select type from category where catname ='" & Me.ComboBox1.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim j As Integer
            Me.cmbitemtype.Items.Clear()
            For j = 0 To dt.Rows.Count - 1
                Me.cmbitemtype.Items.Add(dt.Rows(j).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        category.Show()
    End Sub
End Class