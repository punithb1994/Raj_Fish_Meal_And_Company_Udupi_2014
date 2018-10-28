Public Class searchsupplier
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim bds As New BindingSource
    Dim sel() As String
    Private Sub searchsupplier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub cmbsuppid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbsuppid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbsuppid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsuppid.SelectedIndexChanged
        Me.cmbitemname.Text = ""
        Me.cmbitemtype.Text = ""
        Me.cmbitemtype.Enabled = False
        Dim dt3 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from supplier where supid='" & Me.cmbsuppid.Text & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            Me.DataGridView1.DataSource = dt3
            Me.DataGridView1.Visible = True
            Me.DataGridView2.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub searchsupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt1, dt As New DataTable
            Try
                cnnstr.Close()
                connect()
                issuecommand.CommandText = "select supid from supplier"
                da.SelectCommand = issuecommand
                dt1.Clear()
                da.Fill(dt1)
                Dim i As Integer
                Me.cmbsuppid.Items.Clear()

                For i = 0 To dt1.Rows.Count - 1
                    If dt1.Rows(i).Item(0) <> "0" Then
                        Me.cmbsuppid.Items.Add(dt1.Rows(i).Item(0))
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cnnstr.Close()
            End Try

            connect()
            issuecommand.CommandText = "select distinct catname from category where status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 And dt1.Rows.Count = 0 Then
                Me.Label4.Visible = True
            End If
            Dim j As Integer
            Me.cmbitemname.Items.Clear()
            For j = 0 To dt.Rows.Count - 1
                Me.cmbitemname.Items.Add(dt.Rows(j).Item(0))
            Next
            Me.cmbitemtype.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbitemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbitemname.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbitemname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitemname.SelectedIndexChanged
        Me.cmbitemtype.Text = ""
        Me.cmbsuppid.Text = ""
        Me.cmbitemtype.Enabled = True
        Me.DataGridView1.Visible = False
        Me.DataGridView2.Visible = True
        Dim dt As New DataTable
        sel = New String() {""}
        Try
            connect()
            issuecommand.CommandText = "select catid, type from category where catname='" & Me.cmbitemname.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            ReDim sel(dt.Rows.Count)
            Dim j As Integer
            Me.cmbitemtype.Items.Clear()
            For j = 0 To dt.Rows.Count - 1
                Me.cmbitemtype.Items.Add(dt.Rows(j).Item(1))
                sel(j) = dt.Rows(j).Item(0)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbitemtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbitemtype.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbitemtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitemtype.SelectedIndexChanged
        Me.cmbsuppid.Text = ""
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from supplier where supid in(select supid from category_supplier where catid='" & sel(Me.cmbitemtype.SelectedIndex) & "')"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            Me.DataGridView1.Visible = True
            Me.DataGridView2.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Me.cmbitemtype.Enabled = False
        Me.cmbsuppid.Text = ""
        cmbitemname.Text = ""
        cmbitemtype.Text = ""
        Try
            Dim dt3 As New DataTable
            connect()
            Me.DataGridView2.Visible = False
            Me.DataGridView1.Visible = True
            issuecommand.CommandText = "select * from supplier"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)

            Me.DataGridView1.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try

    End Sub
End Class