Public Class viewstock
    Public da As New SqlClient.SqlDataAdapter
    Public da1 As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub viewstock_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub viewstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.cmbprodid, "Select product id to view details")
        ToolTip1.SetToolTip(Me.cmbprodname, "Select product name to view details")
        ToolTip1.SetToolTip(Me.btnviewall, "View all product's detail")

        Me.datagrid.ReadOnly = True
        Try
            connect()
            Dim dt As New DataTable
            Dim dt1 As New DataTable

            'By product Id
            issuecommand.CommandText = "select * from stockinventory"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbprodid.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.cmbprodid.Items.Add(dt.Rows(i).Item(0))
            Next
            ' By product name

            issuecommand.CommandText = "select * from stockinventory"
            da1.SelectCommand = issuecommand
            dt1.Clear()
            da1.Fill(dt1)
            Dim j As Integer
            Me.cmbprodname.Items.Clear()
            For j = 0 To dt.Rows.Count - 1
                Me.cmbprodname.Items.Add(dt1.Rows(j).Item(1))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnviewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        'View all items in stock
        Try
            Me.cmbprodname.Text = ""
            Me.cmbprodid.Text = ""
            Dim dt1 As New DataTable
            connect()
            issuecommand.CommandText = "select * from stockinventory"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.datagrid.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbprodid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodid.SelectedIndexChanged
        Dim dt3 As New DataTable
        Try
            Me.cmbprodname.Text = ""
            connect()
            issuecommand.CommandText = "select * from stockinventory where productcode='" & Me.cmbprodid.Text & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            Me.datagrid.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbprodname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodname.SelectedIndexChanged
        Dim dt4 As New DataTable
        Try
            Me.cmbprodid.Text = ""
            connect()
            issuecommand.CommandText = "select * from stockinventory where pname='" & Me.cmbprodname.Text & "'"
            da.SelectCommand = issuecommand
            dt4.Clear()
            da.Fill(dt4)
            Me.datagrid.DataSource = dt4
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

   
End Class