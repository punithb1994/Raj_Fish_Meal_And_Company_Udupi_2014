Public Class factconsumrpt
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from consumption where consumdate='" & Me.DateTimePicker1.Value.Date & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                rpt1 = "{consumption.consumdate}=#" & Me.DateTimePicker1.Value.Date & "#"
                frmmdihome.Panel3.Hide()
                frmmdihome.Panel2.Visible = False
                frmmdihome.btnhome.Visible = False
                Dim a As Form
                a = factreport
                a.MdiParent = frmmdihome
                a.StartPosition = FormStartPosition.CenterScreen
                a.Show()
                a.WindowState = FormWindowState.Maximized
                frmmdihome.Panel1.SendToBack()
                frmmdihome.Enabled = True
                Me.Close()
            Else
                Me.Label3.Visible = True
                Me.ErrorProvider1.SetError(Me.DateTimePicker1, "No record found in this date.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub factconsumrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmdihome.Enabled = False
        Dim w, h, lw As Integer
        w = frmmdihome.Size.Width
        h = frmmdihome.Size.Height
        lw = frmmdihome.Location.X
        Me.Size = New Size(w, 263)
        Me.Location = New Point(lw, (h \ 2) - (263 \ 2))
        Me.Button1.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        frmmdihome.Enabled = True
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.CloseUp
        Me.Button1.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.ErrorProvider1.Clear()
        Me.Label3.Visible = False
        Me.Button1.Enabled = True
        If Me.DateTimePicker1.Value.Date > Today.Date Then
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "Invalid date")
        End If
    End Sub
End Class