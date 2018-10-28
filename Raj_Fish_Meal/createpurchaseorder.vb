Public Class createpurchaseorder
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim selcatid, selsupid As String
    Dim sid() As String
    Dim item As Control
    Sub clrsup()  'function to clear all the controls of supplier info group box
        For Each item In Me.GroupBox2.Controls
            If TypeOf (item) Is TextBox Or TypeOf (item) Is ComboBox Then
                item.Text = ""
            End If
        Next
    End Sub
    Sub clritem()   'function to clear all the controls of item info group box
        Dim item As Control
        For Each item In Me.GroupBox4.Controls
            If TypeOf (item) Is TextBox Or TypeOf (item) Is ComboBox Then
                item.Text = ""
            End If
        Next
    End Sub
    Sub selcatname()
        Dim dt As New DataTable
        issuecommand.CommandText = "select distinct catname from category where status=0"
        da.SelectCommand = issuecommand
        dt.Clear()
        da.Fill(dt)
        Dim j As Integer
        Me.cmbcategory.Items.Clear()
        For j = 0 To dt.Rows.Count - 1
            Me.cmbcategory.Items.Add(dt.Rows(j).Item(0))
        Next
    End Sub
    Sub disp()
        Dim dt As New DataTable
        issuecommand.CommandText = "select purchaseorderdetails.slno,category.catname,category.type,supplier.sname,supplier.address,purchaseorderdetails.rqty from purchaseorderdetails,category,supplier where purchaseorderdetails.porderno='" & Me.txtpurchaseorderno.Text & "' and purchaseorderdetails.catid=category.catid and purchaseorderdetails.supid=supplier.supid"
        da.SelectCommand = issuecommand
        dt.Clear()
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
    End Sub
    Private Sub createpurchaseorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Me.cmbporoderno, "Select Purchase order number to edit")
        ToolTip1.SetToolTip(Me.btnneworder, "Create new Purchase order")
        ToolTip1.SetToolTip(Me.txtdate, "Order date")
        ToolTip1.SetToolTip(Me.txtslno, "Serial Number")
        ToolTip1.SetToolTip(Me.cmbcategory, "Item name")
        ToolTip1.SetToolTip(Me.cmbtype, "Item type")
        ToolTip1.SetToolTip(Me.txtitemquantity, "Quantity")
        ToolTip1.SetToolTip(Me.supname, "Select Supplier name")
        ToolTip1.SetToolTip(Me.txtsadd, "Supplier address")
        ToolTip1.SetToolTip(Me.txtsmail, "Supplier E-mail address")
        ToolTip1.SetToolTip(Me.txtsphone, "Supplier phone number")
        ToolTip1.SetToolTip(Me.txtpurchaseorderno, "Order number")
        ToolTip1.SetToolTip(Me.btnaddnew, "Add new Item")
        ToolTip1.SetToolTip(Me.btnsave, "Save")
        ToolTip1.SetToolTip(Me.btnupdate, "Update")
        ToolTip1.SetToolTip(Me.btndel, "Delete")
        ToolTip1.SetToolTip(Me.btnedit, "Edit Purchase Order")
        ToolTip1.SetToolTip(Me.btncancelorder, "Cancel Purchase order")
        ToolTip1.SetToolTip(Me.TextBox6, "Available Inventory")
        ToolTip1.SetToolTip(Me.Label9, "Available Inventory")
        Me.btnneworder.Focus()
        Me.GroupBox3.Enabled = False
        Me.btncancelorder.Enabled = False
        Me.txtdate.Text = Today.Date
        Me.DataGridView1.ReadOnly = True
    End Sub
    Private Sub btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnew.Click
        Me.cmbcategory.Enabled = True
        Me.btnedit.Enabled = True
        Me.msg.Text = ""
        Me.GroupBox4.Enabled = True
        Me.cmbtype.Enabled = False
        Me.txtitemquantity.Enabled = False
        Me.btnaddnew.Enabled = False
        Me.btnupdate.Enabled = False
        Me.btndel.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnaddnew.Enabled = False
        clrsup()
        clritem()
        Try
            connect()
            'load serial number
            issuecommand.CommandText = "select max(slno) from purchaseorderdetails where porderno='" & Me.txtpurchaseorderno.Text & "'"
            Dim i = issuecommand.ExecuteScalar
            If IsDBNull(i) Then
                i = 1
            Else
                i += 1
            End If
            Me.txtslno.Text = i

            'load itemname
            selcatname()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbcategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcategory.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcategory.SelectedIndexChanged
        Me.cmbtype.Enabled = True
        Me.cmbtype.Text = ""
        Me.txtitemquantity.Text = ""
        Me.TextBox6.Text = ""
        clrsup()
        Me.GroupBox2.Enabled = False
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select type from category where catname='" & Me.cmbcategory.Text & "' and status=0"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbtype.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.cmbtype.Items.Add(dt.Rows(i).Item(0))
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
        Me.btnupdate.Enabled = False
        Me.txtitemquantity.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.supname.Enabled = True
        clrsup()
        Dim dt, dt1, dt2, dt3, dt4 As New DataTable
        Try
            issuecommand.CommandText = "select catid  from category where catname='" & Me.cmbcategory.Text & "' and type='" & Me.cmbtype.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            selcatid = dt.Rows(0).Item(0)
            issuecommand.CommandText = "select qty from rawinventory where catid='" & selcatid & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                Me.TextBox6.Text = dt1.Rows(0).Item(0)
            Else
                Me.TextBox6.Text = 0
            End If
            'load supplier name
            sid = New String() {""}
            issuecommand.CommandText = "select supplier.supid,supplier.sname from supplier,category_supplier where category_supplier.catid='" & dt.Rows(0).Item(0) & "' and supplier.supid=category_supplier.supid"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            ReDim sid(dt2.Rows.Count)
            Dim i As Integer
            Me.supname.Items.Clear()
            For i = 0 To dt2.Rows.Count - 1
                sid(i) = dt2.Rows(i).Item(0)
                Me.supname.Items.Add(dt2.Rows(i).Item(1))
            Next
            If Me.btnaddnew.Enabled = False Then
                issuecommand.CommandText = "select * from purchaseorderdetails where catid='" & selcatid & "' and porderno='" & Me.txtpurchaseorderno.Text & "'" ' and supid='" & selsupid & "'"
                da.SelectCommand = issuecommand
                dt4.Clear()
                da.Fill(dt4)
                If dt4.Rows.Count > 0 Then
                    MsgBox("Item already in the order list. Update the changes.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Purchase order")
                    Me.txtslno.Text = dt4.Rows(0).Item(0)
                    Me.btnupdate.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub supname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles supname.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub supname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supname.SelectedIndexChanged
        If Me.btnaddnew.Enabled = False And Me.btnupdate.Enabled = False Then
            Me.btnsave.Enabled = True
        End If
        Dim dt As New DataTable
        Try
            issuecommand.CommandText = "select *  from supplier where sname='" & Me.supname.Text & "' and supid='" & sid(Me.supname.SelectedIndex) & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            selsupid = dt.Rows(0).Item(0)
            Me.txtsadd.Text = dt.Rows(0).Item(2)
            Me.txtsmail.Text = dt.Rows(0).Item(4)
            Me.txtsphone.Text = dt.Rows(0).Item(3)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.btnedit.Enabled = True
        Dim dt, dt1 As New DataTable
        Me.DataGridView2.Visible = False
        Try
            If Me.txtitemquantity.TextLength <> 0 Then
                connect()
                issuecommand.CommandText = "select * from purchaseorder where porderno='" & Me.txtpurchaseorderno.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    issuecommand.CommandText = "insert into purchaseorder values(@porderno,@orderdate)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@porderno", SqlDbType.NVarChar).Value = txtpurchaseorderno.Text
                    issuecommand.Parameters.Add("@orderdate", SqlDbType.DateTime).Value = txtdate.Text
                    issuecommand.ExecuteNonQuery()
                End If
                issuecommand.CommandText = "insert into purchaseorderdetails values(@slno,@catid,@supid,@rqty,@porderno,@status)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@slno", SqlDbType.BigInt).Value = Val(txtslno.Text)
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar).Value = selcatid
                issuecommand.Parameters.Add("@supid", SqlDbType.NVarChar).Value = selsupid
                issuecommand.Parameters.Add("@rqty", SqlDbType.BigInt).Value = Val(txtitemquantity.Text)
                issuecommand.Parameters.Add("@porderno", SqlDbType.NVarChar).Value = Me.txtpurchaseorderno.Text
                issuecommand.Parameters.Add("@status", SqlDbType.Int).Value = 0
                issuecommand.ExecuteNonQuery()
                Me.msg.Text = "Details saved successfully..."
                disp()
                Me.GroupBox2.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.btnaddnew.Enabled = True
                Me.btnsave.Enabled = False
                clrsup()
                clritem()
            Else
                Me.ErrorProvider1.SetError(Me.txtitemquantity, "Quantity must be entered.")
                Me.msg.Text = "Quantity must be entered..."
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.btnedit.Enabled = False
        Me.cmbporoderno.Text = ""
        Me.GroupBox4.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = True
        Me.cmbporoderno.Visible = True
        Me.txtpurchaseorderno.Visible = False
        Me.btnaddnew.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnupdate.Enabled = False
        Me.btndel.Enabled = False
        Me.DataGridView2.Visible = True
        Me.ErrorProvider1.Clear()
        Me.TextBox6.Clear()
        Me.msg.Text = ""
        clrsup()
        clritem()
        Dim dt, dt1 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select porderno from purchaseorder where porderno not in(select distinct porder from purchaseinvoice)"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Me.Panel1.BringToFront()
                Me.Panel1.Visible = True
            End If
            Dim i As Integer
            Me.cmbporoderno.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.cmbporoderno.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbporoderno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbporoderno.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbporoderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbporoderno.SelectedIndexChanged
        Me.msg.Text = ""
        Me.DataGridView2.Visible = False
        Me.btnaddnew.Enabled = True
        Me.btnsave.Enabled = False
        Me.btndel.Enabled = False
        Me.btnupdate.Enabled = False
        Me.btncancelorder.Enabled = True
        clrsup()
        clritem()
        txtpurchaseorderno.Text = Me.cmbporoderno.Text
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select orderdate from purchaseorder where porderno='" & Me.cmbporoderno.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtdate.Text = dt.Rows(0).Item(0)
            disp()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selcatname()
        Me.msg.Text = ""
        Me.btnaddnew.Enabled = True
        Me.btnsave.Enabled = False
        Me.btnupdate.Enabled = True
        Me.btndel.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.GroupBox4.Enabled = True
        Me.cmbtype.Enabled = False
        Me.cmbcategory.Enabled = False
        Me.supname.Enabled = False
        Dim dt1, dt2 As New DataTable
        Try
            Me.txtslno.Text = Me.DataGridView1.Item(0, e.RowIndex).Value
            Me.cmbcategory.Text = Me.DataGridView1.Item(1, e.RowIndex).Value
            cmbcategory_SelectedIndexChanged(sender, e)
            Me.cmbtype.Text = Me.DataGridView1.Item(2, e.RowIndex).Value
            cmbtype_SelectedIndexChanged(sender, e)
            Me.txtitemquantity.Text = Me.DataGridView1.Item(5, e.RowIndex).Value
            connect()
            issuecommand.CommandText = "select supid  from purchaseorderdetails where porderno='" & Me.txtpurchaseorderno.Text & "' and slno='" & Me.txtslno.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            issuecommand.CommandText = "select *  from supplier where supid='" & dt1.Rows(0).Item(0) & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Me.supname.Text = dt2.Rows(0).Item(1)
            Me.txtsadd.Text = dt2.Rows(0).Item(2)
            Me.txtsmail.Text = dt2.Rows(0).Item(4)
            Me.txtsphone.Text = dt2.Rows(0).Item(3)
            Me.btnupdate.Enabled = True
        Catch ex As Exception
            MsgBox("Invalid selection...", MsgBoxStyle.OkOnly, "Purchase order")
        Finally
            cnnstr.Close()
            Me.cmbtype.Enabled = False
        End Try
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Me.btnedit.Enabled = True
        Dim dt, dt1, dt2 As New DataTable
        Dim n As Date
        n = DateAndTime.DateAdd(DateInterval.Day, 3, Date.Parse(Me.txtdate.Text))
        Try
            If Today.Date <= n Then
                connect()
                issuecommand.CommandText = "select catid  from category where catname='" & Me.cmbcategory.Text & "' and type='" & Me.cmbtype.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                issuecommand.CommandText = "select supid  from supplier where sname='" & Me.supname.Text & "' and email='" & Me.txtsmail.Text & "'"
                da.SelectCommand = issuecommand
                dt2.Clear()
                da.Fill(dt2)
                'issuecommand.CommandText = "select * from purchaseorderdetails where catid='" & dt.Rows(0).Item(0) & "' and porderno='" & Me.txtpurchaseorderno.Text & "' and supid='" & dt2.Rows(0).Item(0) & "'"
                'da.SelectCommand = issuecommand
                'dt1.Clear()
                'da.Fill(dt1)
                'If dt1.Rows.Count = 0 Then
                issuecommand.CommandText = "update purchaseorderdetails set catid=@catid,supid=@supid,rqty=@rqty where porderno='" & Me.txtpurchaseorderno.Text & "' and slno='" & Me.txtslno.Text & "'"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar).Value = dt.Rows(0).Item(0)
                issuecommand.Parameters.Add("@supid", SqlDbType.NVarChar).Value = dt2.Rows(0).Item(0)
                issuecommand.Parameters.Add("@rqty", SqlDbType.BigInt).Value = Val(txtitemquantity.Text)
                issuecommand.ExecuteNonQuery()
                Me.btnupdate.Enabled = False
                Me.btndel.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.btnaddnew.Enabled = True
                clrsup()
                clritem()
                Me.msg.Text = "Details updated successfully..."
                disp()
            Else
                Me.msg.Text = "Failed to update."
            End If
            'Else
            '    MsgBox("Item already in the order list. Update changes to that item.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Purchase order")
            '    clrsup()
            '    clritem()
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Me.btnedit.Enabled = True
        Dim n As Date
        n = DateAndTime.DateAdd(DateInterval.Day, 3, Date.Parse(Me.txtdate.Text))
        Try
            If Today.Date <= n Then
               connect()
                issuecommand.CommandText = "delete from purchaseorderdetails where porderno='" & Me.txtpurchaseorderno.Text & "' and slno='" & Me.txtslno.Text & "'"
                issuecommand.ExecuteNonQuery()
                clrsup()
                clritem()
                Me.msg.Text = "Item deleted successfully..."
                disp()
                Me.GroupBox2.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.btndel.Enabled = False
                Me.btnupdate.Enabled = False
            Else
                Me.msg.Text = "Failed to delete."
            End If
                Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btncancelorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelorder.Click
        Me.btnedit.Enabled = True
        Dim n As Date
        n = DateAndTime.DateAdd(DateInterval.Day, 3, Date.Parse(Me.txtdate.Text))
        Try
            If Today.Date <= n Then
                Dim res = MsgBox("Are you sure to cancel the order?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Cancel order")
                If res = vbYes Then
                    connect()
                    issuecommand.CommandText = "delete from purchaseorderdetails where porderno='" & Me.cmbporoderno.Text & "'"
                    issuecommand.ExecuteNonQuery()
                    issuecommand.CommandText = "delete from purchaseorder where porderno='" & Me.cmbporoderno.Text & "'"
                    issuecommand.ExecuteNonQuery()
                    cnnstr.Close()
                    btnedit_Click(sender, e)
                    Me.msg.Text = "Order cancelled successfully..."
                End If
            Else
                Me.msg.Text = "Cancellation period expired..."
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtitemquantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemquantity.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtitemquantity, "Invalid character")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtitemquantity, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtitemquantity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitemquantity.Leave
        If Me.txtitemquantity.TextLength <> 0 Then
            If Me.txtitemquantity.Text = 0 Then
                Beep()
                Me.ErrorProvider1.SetError(Me.txtitemquantity, "Cannot be zero")
            End If
        End If
    End Sub
    Private Sub txtitemquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemquantity.TextChanged
        Me.ErrorProvider1.Clear()
        Me.msg.Text = ""
    End Sub
    Private Sub btnneworder_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnneworder.Click
        Me.txtdate.Text = Today.Date
        Me.btnedit.Enabled = True
        Me.cmbporoderno.Text = ""
        Me.btncancelorder.Enabled = False
        Me.cmbporoderno.Visible = False
        Me.txtpurchaseorderno.Visible = True
        Me.msg.Text = ""
        Me.txtpurchaseorderno.Text = ""
        clrsup()
        clritem()
        Me.DataGridView2.Visible = True
        Me.btnaddnew.Enabled = True
        Me.GroupBox3.Enabled = True
        Me.GroupBox2.Enabled = False
        Me.GroupBox4.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnupdate.Enabled = False
        Me.btndel.Enabled = False
        Me.ErrorProvider1.Clear()
        Me.TextBox6.Clear()
        Dim dt As New DataTable
        Try
            Dim n, k As Integer
            Dim m, i As String
            Dim a() As Integer
            a = New Integer() {0}
            'n = 1
            connect()
            issuecommand.CommandText = "select porderno from purchaseorder"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            ReDim a(dt.Rows.Count) 'define size of array
            For k = 0 To dt.Rows.Count - 1
                i = dt.Rows(k).Item(0) 'passing porderno to variable i
                m = ""
                Dim length = Len(i)
                For n = 1 To length
                    Dim ch = Mid(i, n, 1) 'each character in varisble i is checked to see whether it is a number, if it is a number then it is copied to the variable m
                    If (Char.IsNumber(ch)) Then
                        m = m + ch
                    End If
                Next
                a(k) = Int(m) 'passing number to the array
            Next

            'Code for reduce the empid, if empid is deleted then it can be reused
            Dim len1 = a.Length
            Dim t, j, temp, max As Integer
            For t = 0 To len1 - 1 'Initially sorting array in ascending order
                For j = t + 1 To len1 - 1
                    If a(t) > a(j) Then
                        temp = a(t)
                        a(t) = a(j)
                        a(j) = temp
                    End If
                Next
            Next
            t = 1
            For j = 0 To len1 - 1 'initially variable t is 1, value of t is checked with the values in the array
                If t = a(j) Then
                    t += 1
                    j = 0
                End If
            Next
            max = t
            Me.txtpurchaseorderno.Text = "P" & max
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnlckok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        Me.Panel1.Visible = False
    End Sub
End Class