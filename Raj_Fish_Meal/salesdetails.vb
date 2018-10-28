Public Class salesdetails
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub salesdetails_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub salesdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'tooltips

        ToolTip1.SetToolTip(Me.cmbbillno, "Select Bill Number to view details")

        ToolTip1.SetToolTip(Me.btnviewall, "View all sales details")

        Me.DataGridView1.ReadOnly = True
        Try
            connect()
            Dim dt As New DataTable
            issuecommand.CommandText = "select * from salesbill"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbbillno.Items.Clear()
            If dt.Rows.Count = 0 Then
                Me.Panel2.Visible = True
                Me.cmbbillno.Enabled = False
                Me.btnviewall.Enabled = False
            End If
            For i = 0 To dt.Rows.Count - 1
                Me.cmbbillno.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbillno.SelectedIndexChanged
        Dim dt3 As New DataTable
        Try
            issuecommand.CommandText = "select * from salesbill where billno='" & Me.cmbbillno.Text & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            Me.DataGridView1.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnviewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        Try
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select * from salesbill"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnlckok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        Me.Close()
    End Sub
End Class