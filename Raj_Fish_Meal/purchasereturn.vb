Public Class purchasereturn
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim selcatid
    Dim dat As Date
    Private Sub purchasereturn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
  
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.Label3.Visible = False
        Me.DataGridView2.Visible = True
        Me.GroupBox2.Enabled = True
        Me.cmbinvoice.Enabled = True
        Me.GroupBox4.Enabled = False
        Me.GroupBox3.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnnew.Enabled = False
        Me.txtrtnno.Text = ""
        Me.cmbinvoice.Text = ""
        Me.cmbcatname.Text = ""
        Me.cmbtype.Text = ""
        Me.txtqty.Text = ""
        Me.txtrtnno.Text = ""
        Me.DateTimePicker1.Value = Today.Date
        Me.cmbinvoice.Text = "Select"
        Dim dt, dt1 As New DataTable
        Dim n, k As Integer
        Dim m, i As String
        Dim a() As Integer
        a = New Integer() {0}
        n = 1
        Try
            connect()
            issuecommand.CommandText = "select returnno from purchase_return"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            ReDim a(dt.Rows.Count)
            For k = 0 To dt.Rows.Count - 1
                i = dt.Rows(k).Item(0)
                m = ""
                Dim length = Len(i)
                For n = 1 To length
                    Dim ch = Mid(i, n, 1)
                    If (Char.IsNumber(ch)) Then
                        m = m + ch
                    End If
                Next
                a(k) = Int(m)
            Next

            'Code for reduce the empid, if empid is deleted then it can be reused
            Dim len1 = a.Length
            Dim t, j, temp, max As Integer
            For t = 0 To len1 - 1
                For j = t + 1 To len1 - 1
                    If a(t) > a(j) Then
                        temp = a(t)
                        a(t) = a(j)
                        a(j) = temp
                    End If
                Next
            Next
            t = 1
            For j = 0 To len1 - 1
                If t = a(j) Then
                    t += 1
                    j = 0
                End If
            Next
            max = t
            txtrtnno.Text = "R" & max
            issuecommand.CommandText = "select pbillno from purchaseinvoice where pbillno not in(select invoiceno from purchase_return)"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim q As Integer
            Me.cmbinvoice.Items.Clear()
            For q = 0 To dt1.Rows.Count - 1
                Me.cmbinvoice.Items.Add(dt1.Rows(q).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbinvoice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbinvoice.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub cmbinvoice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbinvoice.SelectedIndexChanged
        Me.GroupBox4.Enabled = True
        Me.cmbcatname.Text = "Select"
        Me.cmbtype.Enabled = False
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select distinct catname from category where catid in(select catid from purchaseinvoicedetail where pbillno='" & Me.cmbinvoice.Text & "')"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim q As Integer
            Me.cmbcatname.Items.Clear()
            For q = 0 To dt.Rows.Count - 1
                ' If dt.Rows(q).Item(0) <> "Fish" Then
                Me.cmbcatname.Items.Add(dt.Rows(q).Item(0))
                'End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbcatname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcatname.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub cmbcatname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcatname.SelectedIndexChanged
        Me.Label3.Visible = False
        Me.cmbtype.Text = "Select"
        Me.cmbtype.Enabled = True
        Me.GroupBox3.Enabled = True
        Me.DateTimePicker1.Enabled = False
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select type from category where catid in(select catid from purchaseinvoicedetail where pbillno='" & Me.cmbinvoice.Text & "') and catname='" & Me.cmbcatname.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim q As Integer
            Me.cmbtype.Items.Clear()
            For q = 0 To dt.Rows.Count - 1
                Me.cmbtype.Items.Add(dt.Rows(q).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtype.KeyPress
        Beep()
        e.Handled = True
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged
        Me.txtqtyrtn.Text = "Quantity"
        Me.txtqtyrtn.Focus()
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select catid from category where catname='" & Me.cmbcatname.Text & "' and type='" & Me.cmbtype.Text & "'"
            selcatid = issuecommand.ExecuteScalar
            'MsgBox(selcatid)
            issuecommand.CommandText = "select qtyrecv,recdate from purchaseinvoicedetail where catid='" & selcatid & "' and pbillno='" & Me.cmbinvoice.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtqty.Text = dt.Rows(0).Item(0)
            dat = dt.Rows(0).Item(1)
            Me.DateTimePicker1.MinDate = dat.Date
            Me.DateTimePicker1.MaxDate = Today.Date
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim dt As New DataTable
        Dim flag As Integer = 0
        Try
            If Me.txtqtyrtn.Text = "Quantity" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtqtyrtn, "Enter returning quantity")
            End If
            If Val(Me.txtqtyrtn.Text) > Val(Me.txtqty.Text) Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtqtyrtn, "Returning quantity cannot be greater than recieved qty")
            End If
            If flag = 0 Then
                connect()
                issuecommand.CommandText = "insert into purchase_return values(@returnno,@invoiceno,@catid,@qty_returned,@rdate)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@returnno", SqlDbType.NVarChar).Value = txtrtnno.Text
                issuecommand.Parameters.Add("@invoiceno", SqlDbType.NVarChar).Value = Me.cmbinvoice.Text
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar).Value = selcatid
                issuecommand.Parameters.Add("@qty_returned", SqlDbType.BigInt).Value = Val(Me.txtqtyrtn.Text)
                issuecommand.Parameters.Add("@rdate", SqlDbType.NVarChar).Value = Me.DateTimePicker1.Value.Date
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "update rawinventory set qty=qty-" & Val(txtqtyrtn.Text) & " where catid='" & selcatid & "'"
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "select category.catname,category.type,purchase_return.qty_returned,purchase_return.rdate from category, purchase_return where purchase_return.returnno='" & Me.txtrtnno.Text & "' and category.catid='" & selcatid & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                Me.DataGridView2.Visible = False
                Me.DataGridView1.DataSource = dt
                Me.Label3.Visible = True
                Me.cmbtype.Items.RemoveAt(Me.cmbtype.SelectedIndex)
                If Me.cmbtype.Items.Count = 0 Then
                    Me.cmbcatname.Items.RemoveAt(Me.cmbcatname.SelectedIndex)
                End If
                ' MsgBox("Details saved successfully.")
                Me.btnsave.Enabled = False
                Me.btnnew.Enabled = True
                Me.cmbcatname.Text = ""
                Me.cmbtype.Text = ""
                Me.txtqty.Text = ""
                Me.txtrtnno.Text = ""
                Me.DateTimePicker1.Value = Today.Date
            Else
                Beep()
                MsgBox("Enter all fields")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub purchasereturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Me.txtrtnno, "Purchase Return number")
        ToolTip1.SetToolTip(Me.cmbinvoice, "Select Invoice number")
        ToolTip1.SetToolTip(Me.cmbcatname, "Select Item name")
        ToolTip1.SetToolTip(Me.cmbtype, "Select Item type")
        ToolTip1.SetToolTip(Me.txtqty, "Quantity recieved")
        ToolTip1.SetToolTip(Me.txtqtyrtn, "Quantity returned")
        ToolTip1.SetToolTip(Me.DateTimePicker1, "Quantity returned date")
        ToolTip1.SetToolTip(Me.btnnew, "New")
        ToolTip1.SetToolTip(Me.btnsave, "Save")
        Me.GroupBox2.Enabled = False
    End Sub

    Private Sub txtqtyrtn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtyrtn.KeyPress
        Me.ErrorProvider1.SetError(Me.txtqtyrtn, "")
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqtyrtn, "Quantity can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtqtyrtn, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub txtqtyrtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqtyrtn.Click
        If Me.txtqtyrtn.Text = "Quantity" Then
            Me.txtqtyrtn.Clear()
        End If
    End Sub

    Private Sub txtqtyrtn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqtyrtn.Leave
        If Me.txtqtyrtn.Text = "Quantity" Or Me.txtqtyrtn.TextLength = 0 Or Val(Me.txtqtyrtn.Text) = 0 Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqtyrtn, "Invalid data to quantity field")
            Me.txtqtyrtn.Clear()
            Me.DateTimePicker1.Enabled = False
        Else
            Me.ErrorProvider1.SetError(Me.txtqtyrtn, "")
        End If
    End Sub

    Private Sub txtqtyrtn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqtyrtn.TextChanged
        Me.DateTimePicker1.Enabled = True
        If Val(Me.txtqtyrtn.Text) > Val(Me.txtqty.Text) Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqtyrtn, "Returning quantity cannot be greater than recieved qty")
            Me.txtqtyrtn.Clear()
        End If
    End Sub

    Private Sub DateTimePicker1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.GotFocus
        Me.btnsave.Enabled = True
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If Me.DateTimePicker1.Value.Date < dat.Date Then
            Beep()
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "Cannot be less than recieved date")
            Me.DateTimePicker1.Value = Today.Date
        Else
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "")
        End If
        If Me.DateTimePicker1.Value.Date > Today.Date Then
            Beep()
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "Invalid date")
            Me.DateTimePicker1.Value = Today.Date
        Else
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "")
        End If
    End Sub
End Class