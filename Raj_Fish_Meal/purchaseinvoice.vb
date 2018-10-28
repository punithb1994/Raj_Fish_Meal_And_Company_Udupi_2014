Public Class purchaseinvoice
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim selcatid As String
    Dim lft, si, selqty As Integer
    Private Sub purchaseinvoice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub btnnewinvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewinvoice.Click
        Me.cmborderno.Text = ""
        Me.cmbitemname.Text = ""
        Me.cmbtype.Text = ""
        Me.txttax.Text = ""
        Me.txtqtyrecieved.Text = 0
        Me.txtprice.Text = "0.00"
        Me.txtnetamt.Text = "0.00"
        Me.txtamount.Text = "0.00"
        Me.txttaxamt.Text = "0.00"
        Me.txtsubtot.Text = "0.00"
        Me.txtnetrate.Text = "0.00"
        Me.txtsuppname.Clear()
        Me.txtaddress.Clear()
        Me.txtorderdate.Clear()
        Me.txtorderedqty.Clear()
        Me.txtavailable.Clear()
        Me.txttotqty.Text = 0
        Me.DateTimePicker1.Value = Today.Date
        Me.DataGridView2.Visible = True
        Me.GroupBox2.Enabled = True
        Me.cmborderno.Enabled = True
        Me.cmborderno.Focus()
        Me.GroupBox3.Enabled = False
        Me.GroupBox4.Enabled = False
        Me.btnsave.Enabled = False
        Me.btndel.Enabled = False
        Me.btnprint.Enabled = False
        Dim dt, dt1, dt2 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from purchaseinvoicedetail where pbillno='" & txtinvoiceno.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from purchaseinvoice where pbillno='" & txtinvoiceno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
            Me.txtinvoiceno.Clear()
            Dim n, k As Integer
            Dim m, i As String
            Dim a() As Integer
            a = New Integer() {0}
            issuecommand.CommandText = "select pbillno from purchaseinvoice"
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
            txtinvoiceno.Text = "PI" & max

            issuecommand.CommandText = "select porderno from purchaseorder where porderno in(select porderno from purchaseorderdetails where status=0)"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim z As Integer
            Me.cmborderno.Items.Clear()
            For z = 0 To dt1.Rows.Count - 1
                Me.cmborderno.Items.Add(dt1.Rows(z).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmborderno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmborderno.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmborderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborderno.SelectedIndexChanged
        Me.btnsave.Enabled = True
        Me.btnsave.Focus()
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select distinct catname from category where catid in(select catid from purchaseorderdetails where porderno='" & Me.cmborderno.Text & "' and status=0)"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim z As Integer
            Me.cmbitemname.Items.Clear()
            For z = 0 To dt.Rows.Count - 1
                Me.cmbitemname.Items.Add(dt.Rows(z).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbitemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbitemname.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbitemname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitemname.SelectedIndexChanged
        Me.cmbtype.Enabled = True
        Me.cmbtype.Focus()
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select type from category where catid in(select catid from purchaseorderdetails where porderno='" & Me.cmborderno.Text & "' and status=0) and catname='" & Me.cmbitemname.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim z As Integer
            Me.cmbtype.Items.Clear()
            For z = 0 To dt.Rows.Count - 1
                Me.cmbtype.Items.Add(dt.Rows(z).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtype.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged
        Me.txtprice.Enabled = True
        Me.txtprice.Focus()
        Dim dt, dt1, dt2, dt3, dt4, dt5 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select catid  from category where catname='" & Me.cmbitemname.Text & "' and type='" & Me.cmbtype.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            selcatid = dt.Rows(0).Item(0)
            'MsgBox(selcatid)
            issuecommand.CommandText = "select rqty from purchaseorderdetails where porderno='" & Me.cmborderno.Text & "' and catid='" & dt.Rows(0).Item(0) & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            txtorderedqty.Text = dt3.Rows(0).Item(0)
            issuecommand.CommandText = "select qtyrecv from purchaseinvoicedetail where pbillno in(select pbillno from purchaseinvoice where porder='" & Me.cmborderno.Text & "') and catid='" & selcatid & "'"
            da.SelectCommand = issuecommand
            dt5.Clear()
            da.Fill(dt5)
            If dt5.Rows.Count > 0 Then
                Dim i, a As Integer
                a = 0
                For i = 0 To dt5.Rows.Count - 1
                    a = a + dt5.Rows(i).Item(0)
                Next
                lft = Val(txtorderedqty.Text) - a
            Else
                lft = Val(txtorderedqty.Text)
            End If
            issuecommand.CommandText = "select sname,address from supplier where supid in(select supid from purchaseorderdetails where catid='" & dt.Rows(0).Item(0) & "' and porderno='" & Me.cmborderno.Text & "')"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.txtsuppname.Text = dt1.Rows(0).Item(0)
            Me.txtaddress.Text = dt1.Rows(0).Item(1)
            issuecommand.CommandText = "select orderdate from purchaseorder where porderno='" & Me.cmborderno.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Me.txtorderdate.Text = dt2.Rows(0).Item(0)
            issuecommand.CommandText = "select qty from rawinventory where catid='" & selcatid & "'"
            da.SelectCommand = issuecommand
            dt4.Clear()
            da.Fill(dt4)
            Me.txtavailable.Text = dt4.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub purchaseinvoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from purchaseinvoicedetail where pbillno='" & txtinvoiceno.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from purchaseinvoice where pbillno='" & txtinvoiceno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub purchaseinvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Me.btnnewinvoice, "New Purchase Invoice")
        ToolTip1.SetToolTip(Me.txtinvoiceno, "Purchase Invoice")
        ToolTip1.SetToolTip(Me.cmborderno, "Select order number")
        ToolTip1.SetToolTip(Me.btnsave, "Save")
        ToolTip1.SetToolTip(Me.cmbitemname, "Select item name")
        ToolTip1.SetToolTip(Me.cmbtype, "Select item type")
        ToolTip1.SetToolTip(Me.txtprice, "Unit price")
        ToolTip1.SetToolTip(Me.txtqtyrecieved, "Quantity recieved")
        ToolTip1.SetToolTip(Me.txttax, "Tax")
        ToolTip1.SetToolTip(Me.txtnetrate, "Net Rate")
        ToolTip1.SetToolTip(Me.txtamount, "Amount")
        ToolTip1.SetToolTip(Me.txtsuppname, "Supplier Name")
        ToolTip1.SetToolTip(Me.txtaddress, "Supplier address")
        ToolTip1.SetToolTip(Me.txtorderdate, "Order Date")
        ToolTip1.SetToolTip(Me.DateTimePicker1, "Recieving Date")
        ToolTip1.SetToolTip(Me.btnadd, "Add")
        ToolTip1.SetToolTip(Me.txttaxamt, "Tax")
        ToolTip1.SetToolTip(Me.txttotqty, "Total quantity")
        ToolTip1.SetToolTip(Me.txtsubtot, "Sub Total")
        ToolTip1.SetToolTip(Me.txtnetamt, "Net Amount")
        ToolTip1.SetToolTip(Me.btndel, "Delete")
        ToolTip1.SetToolTip(Me.btnprint, "Print")
        ToolTip1.SetToolTip(Me.txtorderedqty, "Ordered Quantity")
        ToolTip1.SetToolTip(Me.txtavailable, "Available Quantity")
        Me.GroupBox2.Enabled = False
        Me.txttaxamt.Enabled = False
        Me.txtsubtot.Enabled = False
        Me.txttotqty.Enabled = False
        Me.txtnetamt.Enabled = False
        Me.btnadd.Enabled = False
        Me.btndel.Enabled = False
        Me.btnprint.Enabled = False
        Me.DataGridView2.Visible = True
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.GroupBox3.Enabled = True
        Me.cmbitemname.Focus()
        Me.cmbtype.Enabled = False
        Me.txtprice.Enabled = False
        Me.txtqtyrecieved.Enabled = False
        Me.txttax.Enabled = False
        Me.btnadd.Enabled = False
        Try
            connect()
            issuecommand.CommandText = "insert into purchaseinvoice values(@pbillno,@porder,@taxamttotal,@totalqty,@subtotal,@nettotal)"
            issuecommand.CommandType = CommandType.Text
            issuecommand.Parameters.Clear()
            issuecommand.Parameters.Add("@pbillno", SqlDbType.NVarChar).Value = txtinvoiceno.Text
            issuecommand.Parameters.Add("@porder", SqlDbType.NVarChar).Value = cmborderno.Text
            issuecommand.Parameters.Add("@taxamttotal", SqlDbType.Money).Value = 0
            issuecommand.Parameters.Add("@totalqty", SqlDbType.BigInt).Value = 0
            issuecommand.Parameters.Add("@subtotal", SqlDbType.Money).Value = 0
            issuecommand.Parameters.Add("@nettotal", SqlDbType.Money).Value = 0
            issuecommand.ExecuteNonQuery()
            'MsgBox("Details saved successfully.")
            Me.cmborderno.Enabled = False
            Me.btnsave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim dt As New DataTable
        Dim flag = 0
        Try
            connect()
            If Val(Me.txtprice.Text) = 0 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.Label8, "Cannot be zero")
            End If
            If (Me.txtqtyrecieved.Text) = 0 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.Label10, "Cannot be zero")
            End If
            If flag = 0 Then
                issuecommand.CommandText = "select max(slno) from purchaseinvoicedetail where pbillno='" & Me.txtinvoiceno.Text & "'"
                Dim s = issuecommand.ExecuteScalar
                If IsDBNull(s) Then
                    s = 1
                Else
                    s += 1
                End If
                issuecommand.CommandText = "insert into purchaseinvoicedetail values(@slno,@catid,@recdate,@rate,@qtyrecv,@tax,@netrate,@amount,@pbillno)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@slno", SqlDbType.BigInt).Value = s
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar).Value = selcatid
                issuecommand.Parameters.Add("@recdate", SqlDbType.DateTime).Value = DateTimePicker1.Value.Date
                issuecommand.Parameters.Add("@rate", SqlDbType.Money).Value = txtprice.Text
                issuecommand.Parameters.Add("@qtyrecv", SqlDbType.BigInt).Value = Val(txtqtyrecieved.Text)
                issuecommand.Parameters.Add("@tax", SqlDbType.Money).Value = txttax.Text
                issuecommand.Parameters.Add("@netrate", SqlDbType.Money).Value = Me.txtnetrate.Text
                issuecommand.Parameters.Add("@amount", SqlDbType.Money).Value = txtamount.Text
                issuecommand.Parameters.Add("@pbillno", SqlDbType.NVarChar).Value = txtinvoiceno.Text
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "select purchaseinvoicedetail.slno,category.catname,category.type,purchaseinvoicedetail.rate,purchaseinvoicedetail.qtyrecv,purchaseinvoicedetail.tax,purchaseinvoicedetail.netrate,purchaseinvoicedetail.amount,purchaseinvoicedetail.recdate from purchaseinvoicedetail,category where purchaseinvoicedetail.pbillno='" & txtinvoiceno.Text & "' and category.catid='" & selcatid & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                Me.DataGridView1.DataSource = dt
                Me.DataGridView2.Visible = False

                issuecommand.CommandText = "update purchaseinvoice set taxamttotal=@a,totalqty=@b,subtotal=@c,nettotal=@d where pbillno=@e"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@a", SqlDbType.Money).Value = txttaxamt.Text
                issuecommand.Parameters.Add("@b", SqlDbType.BigInt).Value = Val(txttotqty.Text)
                issuecommand.Parameters.Add("@c", SqlDbType.Money).Value = txtsubtot.Text
                issuecommand.Parameters.Add("@d", SqlDbType.Money).Value = txtnetamt.Text
                issuecommand.Parameters.Add("@e", SqlDbType.NVarChar).Value = txtinvoiceno.Text
                issuecommand.ExecuteNonQuery()

                issuecommand.CommandText = "update rawinventory set qty=qty+" & Val(txtqtyrecieved.Text) & " where catid='" & selcatid & "'"
                issuecommand.ExecuteNonQuery()
                If lft = Val(Me.txtqtyrecieved.Text) Then
                    issuecommand.CommandText = "update purchaseorderdetails set status=1 where porderno='" & Me.cmborderno.Text & "' and catid='" & selcatid & "'"
                    issuecommand.ExecuteNonQuery()
                End If
                Me.cmbtype.Items.RemoveAt(Me.cmbtype.SelectedIndex)
                If Me.cmbtype.Items.Count = 0 Then
                    Me.cmbitemname.Items.RemoveAt(Me.cmbitemname.SelectedIndex)
                End If
                If Me.cmbitemname.Items.Count = 0 Then
                    'MsgBox("No record found")
                End If
                Me.cmbitemname.Text = ""
                Me.cmbtype.Text = ""
                Me.txttax.Text = ""
                me.txtqtyrecieved.Text=0
                Me.txtprice.Text = "0.00"
                'Me.txtnetamt.Text = "0.00"
                Me.txtamount.Text = "0.00"
                'Me.txttaxamt.Text = "0.00"
                'Me.txtsubtot.Text = "0.00"
                Me.txtnetrate.Text = "0.00"
                Me.txtsuppname.Clear()
                Me.txtaddress.Clear()
                Me.txtorderdate.Clear()
                Me.txtorderedqty.Clear()
                Me.txtavailable.Clear()
                'Me.txttotqty.Text = 0
                Me.DateTimePicker1.Value = Today.Date
                Me.btnprint.Enabled = True
                Me.cmbtype.Enabled = False
                Me.txtprice.Enabled = False
                Me.txtqtyrecieved.Enabled = False
                Me.txttax.Enabled = False
                Me.DateTimePicker1.Enabled = False
                Me.btnadd.Enabled = False
                MsgBox("Details saved successfully.")
            Else
                MsgBox("Invalid entries")
            End If
            rpt = "{purchaseinvoice.pbillno}='" & Me.txtinvoiceno.Text & "' and {purchaseinvoice.porder}='" & Me.cmborderno.Text & "'"
            Me.btnprint.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.Label8, "Invalid character")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.Label8, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub txtprice_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprice.Leave
        If Me.txtprice.Text = 0 Then
            Me.ErrorProvider1.SetError(Me.Label8, "Cannot be zero")
        End If
        If Me.txtprice.Text > 5000 Then
            Me.ErrorProvider1.SetError(Me.Label8, "Invalid rate")
        End If
    End Sub
    Private Sub txtprice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprice.LostFocus
        Me.txtprice.Text = Math.Round(Double.Parse(Me.txtprice.Text), 2)
        Dim i, flag, ctr As Integer
        flag = 0
        ctr = -1
        For i = 1 To Me.txtprice.TextLength
            If Asc(Mid(Me.txtprice.Text, i, 1)) = 46 Then
                flag = 1
            End If
            If flag = 1 Then
                ctr += 1
            End If
        Next
        If flag = 0 Then
            Me.txtprice.Text = Me.txtprice.Text & ".00"
        End If
        If ctr = 1 Then
            Me.txtprice.Text = Me.txtprice.Text & "0"
        End If
    End Sub
    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        Me.ErrorProvider1.SetError(Me.Label8, "")
        Me.txtqtyrecieved.Enabled = True
    End Sub
    Private Sub txtqtyrecieved_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtyrecieved.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.Label10, "Invalid character")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.Label10, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If Val(Me.txtqtyrecieved.Text) = 0 Then
            If Asc(e.KeyChar) = 48 Then
                Beep()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtqtyrecieved_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqtyrecieved.Leave
        If Me.txtqtyrecieved.Text = 0 Then
            Me.ErrorProvider1.SetError(Me.Label10, "Cannot be zero")
        End If
    End Sub
    Private Sub txtqtyrecieved_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqtyrecieved.TextChanged
        Me.ErrorProvider1.SetError(Me.Label10, "")
        Me.txttax.Enabled = True
        If Val(Me.txtorderedqty.Text) = lft Then
            If Val(Me.txtqtyrecieved.Text) > lft Then
                Beep()
                Me.txtqtyrecieved.Clear()
                Me.txttax.Enabled = False
                Me.ErrorProvider1.SetError(Me.Label10, "Recieved quantity cannot be greater than ordered quantity")
            End If
        Else
            If Val(Me.txtqtyrecieved.Text) > lft Then
                Beep()
                Me.txtqtyrecieved.Clear()
                Me.txttax.Enabled = False
                Me.ErrorProvider1.SetError(Me.Label10, "Cannot recieve more than " & lft & ", leftover item recieved before.")
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.CloseUp
        Me.btnadd.Enabled = True
        Me.btnadd.Focus()
    End Sub
    Private Sub DateTimePicker1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.LostFocus
        If DateTimePicker1.Value.Date > Today.Date Then
            Beep()
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "Invalid date")
            Me.btnadd.Enabled = False
        End If
        If Me.DateTimePicker1.Value.Date < Date.Parse(Me.txtorderdate.Text) Then
            Me.ErrorProvider1.SetError(Me.DateTimePicker1, "Cannot be less than order date")
            Me.btnadd.Enabled = False
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.ErrorProvider1.SetError(Me.DateTimePicker1, "")
        Me.btnadd.Enabled = True
        Me.btnadd.Focus()
    End Sub
    Private Sub txttax_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttax.KeyPress
        e.Handled = True
    End Sub
    Private Sub txttax_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttax.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.Label12, "")
        Me.GroupBox4.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker1.Focus()
        Dim tx As Double
        tx = Double.Parse(Me.txtprice.Text) * Me.txttax.Text / 100
        Me.txtnetrate.Text = Math.Round(tx + Double.Parse(Me.txtprice.Text), 2)
        Dim i, flag, ctr As Integer
        flag = 0
        ctr = -1
        For i = 1 To Me.txtnetrate.TextLength
            If Asc(Mid(Me.txtnetrate.Text, i, 1)) = 46 Then
                flag = 1
            End If
            If flag = 1 Then
                ctr += 1
            End If
        Next
        If flag = 0 Then
            Me.txtnetrate.Text = Me.txtnetrate.Text & ".00"
        End If
        If ctr = 1 Then
            Me.txtnetrate.Text = Me.txtnetrate.Text & "0"
        End If
        Me.txtamount.Text = Math.Round((Double.Parse(Me.txtprice.Text) * Val(Me.txtqtyrecieved.Text)) + (tx * Val(Me.txtqtyrecieved.Text)), 2)
        flag = 0
        ctr = -1
        For i = 1 To Me.txtamount.TextLength
            If Asc(Mid(Me.txtamount.Text, i, 1)) = 46 Then
                flag = 1
            End If
            If flag = 1 Then
                ctr += 1
            End If
        Next
        If flag = 0 Then
            Me.txtamount.Text = Me.txtamount.Text & ".00"
        End If
        If ctr = 1 Then
            Me.txtamount.Text = Me.txtamount.Text & "0"
        End If
        Me.txttaxamt.Text = Math.Round(Double.Parse(Me.txttaxamt.Text) + (tx * Val(Me.txtqtyrecieved.Text)), 2)
        flag = 0
        ctr = -1
        For i = 1 To Me.txttaxamt.TextLength
            If Asc(Mid(Me.txttaxamt.Text, i, 1)) = 46 Then
                flag = 1
            End If
            If flag = 1 Then
                ctr += 1
            End If
        Next
        If flag = 0 Then
            Me.txttaxamt.Text = Me.txttaxamt.Text & ".00"
        End If
        If ctr = 1 Then
            Me.txttaxamt.Text = Me.txttaxamt.Text & "0"
        End If
        Me.txttotqty.Text = Val(Me.txttotqty.Text) + Val(Me.txtqtyrecieved.Text)
        Me.txtsubtot.Text = Math.Round(Double.Parse(Me.txtsubtot.Text) + (Double.Parse(Me.txtprice.Text) * Val(Me.txtqtyrecieved.Text)), 2)
        flag = 0
        ctr = -1
        For i = 1 To Me.txtsubtot.TextLength
            If Asc(Mid(Me.txtsubtot.Text, i, 1)) = 46 Then
                flag = 1
            End If
            If flag = 1 Then
                ctr += 1
            End If
        Next
        If flag = 0 Then
            Me.txtsubtot.Text = Me.txtsubtot.Text & ".00"
        End If
        If ctr = 1 Then
            Me.txtsubtot.Text = Me.txtsubtot.Text & "0"
        End If
        Me.txtnetamt.Text = Math.Round(Double.Parse(Me.txtsubtot.Text) + Double.Parse(Me.txttaxamt.Text), 2)
        flag = 0
        ctr = -1
        For i = 1 To Me.txtnetamt.TextLength
            If Asc(Mid(Me.txtnetamt.Text, i, 1)) = 46 Then
                flag = 1
            End If
            If flag = 1 Then
                ctr += 1
            End If
        Next
        If flag = 0 Then
            Me.txtnetamt.Text = Me.txtnetamt.Text & ".00"
        End If
        If ctr = 1 Then
            Me.txtnetamt.Text = Me.txtnetamt.Text & "0"
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dt As New DataTable
        Me.btndel.Enabled = True
        Try
            si = Val(Me.DataGridView1.Item(0, e.RowIndex).Value)
            selqty = Val(Me.DataGridView1.Item(4, e.RowIndex).Value)
            connect()
            issuecommand.CommandText = "select catid  from category where catname='" & Me.DataGridView1.Item(1, e.RowIndex).Value & "' and type='" & Me.DataGridView1.Item(2, e.RowIndex).Value & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            selcatid = dt.Rows(0).Item(0)
            'MsgBox(selqty)
            'MsgBox(selcatid)
        Catch ex As Exception
            MsgBox("Invalid selection...", MsgBoxStyle.OkOnly, "Purchase order")
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Dim dt As New DataTable
        Try
            connect()
            Dim res = MsgBox("Are you sure to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Purchase Invoice")
            If res = vbYes Then
                issuecommand.CommandText = "delete from purchaseinvoicedetail where pbillno='" & Me.txtinvoiceno.Text & "' and slno=" & si
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "update rawinventory set qty=qty-" & selqty & " where catid='" & selcatid & "'"
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "update purchaseorderdetails set status=0 where porderno='" & Me.cmborderno.Text & "' and catid='" & selcatid & "'"
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "select purchaseinvoicedetail.slno,category.catname,category.type,purchaseinvoicedetail.rate,purchaseinvoicedetail.qtyrecv,purchaseinvoicedetail.tax,purchaseinvoicedetail.netrate,purchaseinvoicedetail.amount,purchaseinvoicedetail.recdate from purchaseinvoicedetail,category where purchaseinvoicedetail.pbillno='" & txtinvoiceno.Text & "' and category.catid='" & selcatid & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                Me.DataGridView1.DataSource = dt
                cnnstr.Close()
                cmborderno_SelectedIndexChanged(sender, e)
                Me.btnsave.Enabled = False
                Me.btndel.Enabled = False
                MsgBox("deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Me.btnprint.Enabled = False
        Me.Cursor = Cursors.AppStarting
        Dim a As Form
        a = PIReport
        a.StartPosition = FormStartPosition.CenterScreen
        a.Show()
        a.WindowState = FormWindowState.Maximized
    End Sub
End Class
