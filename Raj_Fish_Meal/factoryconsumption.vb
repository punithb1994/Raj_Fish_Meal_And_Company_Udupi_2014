Public Class factoryconsumption
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim code
    Private Sub factoryconsumption_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub factoryconsumption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltip
        ToolTip1.SetToolTip(Me.cmbitemname, "Select item name")
        ToolTip1.SetToolTip(Me.cmbitemtype, "Select item type")
        ToolTip1.SetToolTip(Me.txtquantity, "Enter quantity consumed")
        ToolTip1.SetToolTip(Me.txtdate, "Consumed date")
        ToolTip1.SetToolTip(Me.cmbemployeeid, "Select employee id")
        ToolTip1.SetToolTip(Me.txtempname, "Employee name")
        Me.ToolTip1.SetToolTip(Me.DataGridView1, "Shows todays consumption to factory")
        Dim dt, dt1 As New DataTable
        Me.cmbitemtype.Enabled = False
        Me.txtquantity.Enabled = False
        Me.cmbemployeeid.Enabled = False
        Me.btnsave.Enabled = False
        Try
            connect()
            issuecommand.CommandText = "select distinct catname from category where status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbitemname.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.cmbitemname.Items.Add(dt.Rows(i).Item(0))
            Next
            issuecommand.CommandText = "select * from consumption where consumdate='" & Me.txtdate.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
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
        Dim dt As New DataTable
        Me.cmbitemtype.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select type from category where catname='" & Me.cmbitemname.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbitemtype.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.cmbitemtype.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbemployeeid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbemployeeid.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub cmbemployeeid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbemployeeid.SelectedIndexChanged
        Dim dt As New DataTable
        Me.btnsave.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select empname from employee where empid='" & Me.cmbemployeeid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtempname.Text = dt.Rows(0).Item(0)
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
        Dim dt, dt1, dt2 As New DataTable
        Me.txtdate.Text = Today.Date
        Me.txtquantity.Enabled = True
        Me.cmbemployeeid.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select empid from employee where status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbemployeeid.Items.Clear()

            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item(0) <> "0" Then
                    Me.cmbemployeeid.Items.Add(dt.Rows(i).Item(0))
                End If
            Next

            issuecommand.CommandText = "select qty from rawinventory where catid in (select catid from category where catname='" & Me.cmbitemname.Text & "' and type='" & Me.cmbitemtype.Text & "')"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                Me.TextBox2.Text = dt1.Rows(0).Item(0)
            Else
                Me.TextBox2.Text = 0
            End If

            issuecommand.CommandText = "select itemcode from rawinventory where catid in (select catid from category where catname='" & Me.cmbitemname.Text & "' and type='" & Me.cmbitemtype.Text & "')"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                code = dt2.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub txtquantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantity.KeyPress
        Me.ErrorProvider1.SetError(Me.txtquantity, "")
        Me.Timer1.Enabled = True
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtquantity, "Quantity can contain only numbers")
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Val(Me.txtquantity.Text) > Val(Me.TextBox2.Text) Then
            Me.Timer1.Enabled = False
            MsgBox(Me.txtquantity.Text & " " & Me.cmbitemname.Text & " not available", MsgBoxStyle.OkOnly, "Quantity")
            Me.txtquantity.Clear()
        End If
        If Me.Timer1.Interval = 100 Then
            Me.Timer1.Interval = 100
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If Val(Me.txtquantity.Text) = 0 Then
                Me.ErrorProvider1.SetError(Me.txtquantity, "Cannot be zero")
                Me.txtquantity.Clear()
            End If
            connect()
            If Val(Me.txtquantity.TextLength) <> 0 Then
                issuecommand.CommandText = "insert into consumption values(@itemcode,@consumdate,@qty,@empname)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@consumdate", SqlDbType.DateTime).Value = Me.txtdate.Text
                issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(txtquantity.Text)
                issuecommand.Parameters.Add("@empname", SqlDbType.VarChar).Value = Me.txtempname.Text
                issuecommand.Parameters.Add("@itemcode", SqlDbType.NVarChar).Value = code
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "update rawinventory set qty=@qty where itemcode=@itemcode"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(Me.TextBox2.Text) - Val(txtquantity.Text)
                issuecommand.Parameters.Add("@itemcode", SqlDbType.NVarChar).Value = code
                issuecommand.ExecuteNonQuery()
                MsgBox("Details saved successfully.")
                cnnstr.Close()
                factoryconsumption_Load(sender, e)
                Me.cmbitemtype.Enabled = False
                Me.txtquantity.Enabled = False
                Me.cmbemployeeid.Enabled = False
                Me.btnsave.Enabled = False
                Me.TextBox2.Clear()
                Dim item As Control
                For Each item In Me.GroupBox3.Controls
                    If TypeOf (item) Is TextBox Or TypeOf (item) Is ComboBox Then
                        item.Text = ""
                    End If
                Next
            Else
                MsgBox("Fill qty field", MsgBoxStyle.OkOnly, "Quantity")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        category.Show()
    End Sub

    Private Sub txtquantity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtquantity.Leave
        If Val(Me.txtquantity.Text) = 0 Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtquantity, "Cannot be zero")
            Me.txtquantity.Clear()
        End If
    End Sub
End Class