Imports System.Text.RegularExpressions
Imports System.IO
Public Class salesorder
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim item As Control
    Dim flg, quantity1, quanto As Integer
    Dim price1, netamount As Double
    Dim a, c As Integer
    Private Sub salesorder_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub salesorder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dt As New DataTable
        Try
            cnnstr.Close()
            connect()
            flg = 0
            issuecommand.CommandText = "select * from salesorderdetail where orderno='" & Me.txtorderno.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                flg = 1
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.txtorderno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub salesorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tool tips
        ToolTip1.SetToolTip(Me.txtorderno, "Order number")
        ToolTip1.SetToolTip(Me.txtdateoforder, "Date of order")
        ToolTip1.SetToolTip(Me.txtcustname, "Customer name")
        ToolTip1.SetToolTip(Me.btnnew, "New Order")
        ToolTip1.SetToolTip(Me.btnsave, "Save Order")
        ToolTip1.SetToolTip(Me.Btnnew2, "Add New Product")
        ToolTip1.SetToolTip(Me.btnsaveprod, "Save New Product")
        ToolTip1.SetToolTip(Me.cmbcustid, "Select Customer Id")
        ToolTip1.SetToolTip(Me.cmbproductname, "Select Product Name")
        ToolTip1.SetToolTip(Me.txtprodqty, "Enter Quantity to be Ordered")
        ToolTip1.SetToolTip(Me.btnedit, "Edit Sales Order")
        ToolTip1.SetToolTip(Me.btndisplay, "Display Order")
        ToolTip1.SetToolTip(Me.cmbselorderno, "Select Order Number")
        Me.GroupBox3.Enabled = False
        Me.DataGridView2.Visible = True
        Me.datagridview1.Visible = False
        Panel1.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnsaveprod.Enabled = False
        Me.cmbproductname.Enabled = False
        Me.txtproductid.Enabled = False
        Me.cmbcustid.Enabled = False
        Me.txtprodqty.Enabled = False
        Me.datagridview1.ReadOnly = True
        Dim dt, dt1, dt2 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select custid from customer"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.cmbcustid.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.cmbcustid.Items.Add(dt.Rows(i).Item(0))
            Next
            cmbproductname.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtitmqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtprodqty, "Can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtprodqty, "")
        End If
        If Me.txtprodqty.Text.Length > 9 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub btnnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.cmbproductname.Text = ""
        Me.txtproductid.Clear()
        Me.txtprodqty.Clear()
        Me.txtprice.Clear()
        Dim dt, dt1 As New DataTable
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from salesorderdetail where orderno='" & Me.txtorderno.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.txtorderno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
            Dim n, k As Integer
            Dim m, i As String
            Dim a() As Integer
            a = New Integer() {0}
            n = 1
            issuecommand.CommandText = "select orderno from salesorder"
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
            'Code for reduce the salesorder, if salesorderno is deleted then it can be reused
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
            Me.txtorderno.Text = "O" & max
            Me.txtdateoforder.Text = Today.Date
            Me.btnnew.Enabled = False
            Me.btnsave.Enabled = True
            Me.txtprodqty.Enabled = True
            Me.txtcustname.Clear()
            Me.Label5.Visible = False
            Me.btnsaveprod.Enabled = True
            Me.cmbcustid.Enabled = True
            Me.cmbcustid.Text = ""
            Me.cmbproductname.Enabled = True
            Me.GroupBox4.Enabled = True
            Me.GroupBox3.Enabled = False
            Me.DataGridView2.Visible = True
            Me.datagridview1.Visible = False
            Me.Panel1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbcustid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcustid.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbcustid_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcustid.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.cmbcustid, "")
        Me.Label5.Text = ""
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from customer where custid='" & Me.cmbcustid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtcustname.Text = dt.Rows(0).Item(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim dt1 As New DataTable
        Try
            Dim flag As Integer
            flag = 0
            If Me.cmbcustid.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cmbcustid, "Customer id must be selected")
                flag = 1
            Else
                Me.ErrorProvider1.SetError(Me.cmbcustid, "")
            End If
            If flag = 0 Then
                connect()
                issuecommand.CommandText = "insert into salesorder values(@orderno,@orderdate,@custid)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@orderno", SqlDbType.NVarChar, 50).Value = Me.txtorderno.Text
                issuecommand.Parameters.Add("@orderdate", SqlDbType.DateTime, 8).Value = Me.txtdateoforder.Text
                issuecommand.Parameters.Add("@custid", SqlDbType.NVarChar, 50).Value = Me.cmbcustid.Text
                issuecommand.ExecuteNonQuery()
                Me.Label5.Visible = True
                Me.Label5.Text = "Details Saved succesfully..."
                Me.txtproductid.Enabled = False
                Me.txtprodqty.Enabled = False
                Me.btnnew.Enabled = True
                Me.Btnnew2.Enabled = True
                Me.btnsave.Enabled = False
                Me.btnsaveprod.Enabled = False
                Me.cmbcustid.Enabled = False
                Me.cmbproductname.Enabled = False
                Me.GroupBox3.Enabled = True
                Me.DataGridView2.Visible = True
                Me.datagridview1.Visible = False
                issuecommand.CommandText = "select pname from stockinventory"
                da.SelectCommand = issuecommand
                dt1.Clear()
                da.Fill(dt1)
                Dim j As Integer
                Me.cmbproductname.Items.Clear()
                For j = 0 To dt1.Rows.Count - 1
                    Me.cmbproductname.Items.Add(dt1.Rows(j).Item(0))
                Next
            Else
                Me.Label5.Visible = True
                Me.Label5.Text = "Select customer..."
                Me.cmbcustid.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try

    End Sub
    Private Sub btndisplay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisplay.Click
        Dim dt, dt1 As New DataTable
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from salesorderdetail where orderno='" & Me.txtorderno.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.txtorderno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
            issuecommand.CommandText = "select orderno from salesorder where orderno not in(select orderno from salesbill)"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Me.Panel2.BringToFront()
                Me.Panel2.Visible = True
                Me.cmbselorderno.Enabled = False
                Exit Sub
            End If
            Me.Label5.Visible = False
            Panel1.Enabled = True
            Me.txtorderno.Clear()
            Me.txtdateoforder.Clear()
            Me.txtcustname.Clear()
            Me.txtcustomerid.Clear()
            Me.txtcustomername.Clear()
            Me.textorderdate.Clear()
            Me.cmbcustid.Enabled = False
            Me.cmbselorderno.Text = ""
            Me.cmbcustid.Text = ""
            Me.Btnnew2.Enabled = False
            Me.btnsave.Enabled = False
            Me.btnnew.Enabled = True
            Me.DataGridView2.Visible = True
            Me.datagridview1.Visible = False
            Me.cmbselorderno.Enabled = True
            Dim o As Integer
            Me.cmbselorderno.Items.Clear()
            For o = 0 To dt.Rows.Count - 1
                Me.cmbselorderno.Items.Add(dt.Rows(o).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbproductname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbproductname.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbproductname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproductname.SelectedIndexChanged
        Me.ErrorProvider1.SetError(Me.cmbproductname, "")
        Me.Label5.Text = ""
        Dim dt, dt1 As New DataTable
        Try
            Me.txtprodqty.Enabled = True
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from stockinventory where pname='" & Me.cmbproductname.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtproductid.Text = dt.Rows(0).Item(0)
            Me.txtprodqty.Focus()
            issuecommand.CommandText = "select price from stockinventory where pname='" & Me.cmbproductname.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.txtprice.Text = dt1.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnsaveprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveprod.Click
        Dim dt, dt1 As New DataTable
        connect()
        Try
            Dim flag As Integer
            flag = 0
            If Me.cmbproductname.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.cmbproductname, "Product Name must be selected")
            Else
                Me.ErrorProvider1.SetError(Me.cmbproductname, "")
            End If

            If Val(Me.txtprodqty.Text) = 0 Or Me.txtprodqty.Text = "" Then
                flag = 1
                Me.txtprodqty.Clear()
                Me.ErrorProvider1.SetError(Me.Label6, "Enter valid quantity")
            End If
            If flag = 0 Then
                issuecommand.CommandText = "select * from salesorder where orderno='" & Me.txtorderno.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    issuecommand.CommandText = "insert into salesorder values(@orderno,@orderdate,@custid)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@orderno", SqlDbType.NVarChar, 50).Value = Me.txtorderno.Text
                    issuecommand.Parameters.Add("@orderdate", SqlDbType.DateTime, 8).Value = Me.txtdateoforder.Text
                    issuecommand.Parameters.Add("@custid", SqlDbType.NVarChar, 50).Value = Me.cmbcustid.Text
                    issuecommand.ExecuteNonQuery()
                End If
                'to select price from stockinventory
                issuecommand.CommandText = "select price from stockinventory where pname='" & Me.cmbproductname.Text & "'"
                da.SelectCommand = issuecommand
                dt1.Clear()
                da.Fill(dt1)
                price1 = dt1.Rows(0).Item(0)
                netamount = (price1 * Me.txtprodqty.Text)
                issuecommand.CommandText = "insert into salesorderdetail values(@orderno,@productcode,@productname,@qty,@netamt)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@orderno", SqlDbType.NVarChar, 50).Value = Me.txtorderno.Text
                issuecommand.Parameters.Add("@productcode", SqlDbType.NVarChar, 50).Value = Me.txtproductid.Text
                issuecommand.Parameters.Add("@productname", SqlDbType.VarChar, 50).Value = Me.cmbproductname.Text
                issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(Me.txtprodqty.Text)
                issuecommand.Parameters.Add("@netamt", SqlDbType.Money).Value = Val(netamount)
                issuecommand.ExecuteNonQuery()
                Me.Label5.Visible = True
                Me.Label5.Text = "Details Saved succesfully..."
                Me.cmbproductname.Items.RemoveAt(Me.cmbproductname.SelectedIndex)
                If Me.cmbproductname.Items.Count = 0 Then
                    Me.GroupBox3.Enabled = False
                End If
                Me.cmbproductname.Text = ""
                Me.txtprodqty.Enabled = False
                Me.txtproductid.Clear()
                Me.txtprodqty.Clear()
                Me.txtprice.Clear()
                Me.cmbproductname.Enabled = False
                Me.Btnnew2.Enabled = True
                Me.btnsaveprod.Enabled = False
                btnnew.Enabled = True
            Else
                Beep()
                Me.Label5.Visible = True
                Me.Label5.Text = "Enter product details..."
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Btnnew2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnew2.Click
        Dim dt1 As New DataTable
        Me.Label5.Visible = False
        Me.cmbcustid.Enabled = False
        Me.cmbproductname.Enabled = True
        Me.btnsaveprod.Enabled = True
        Me.btnsave.Enabled = False
        Me.Btnnew2.Enabled = False
    End Sub
    Private Sub txtprodqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprodqty.KeyPress
        If Me.txtprodqty.Text.Length > 5 Then
            Beep()
            e.Handled = True
        End If
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.Label6, "Can contain only numbers!")
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.cmbselorderno.Text = ""
        Me.txtcustomerid.Clear()
        Me.txtcustomername.Clear()
        Me.textorderdate.Clear()
        Dim dt, dt1 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from salesorderdetail where orderno='" & Me.txtorderno.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.txtorderno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
            flg = 0
            issuecommand.CommandText = "select * from salesorderdetail where orderno='" & Me.txtorderno.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                flg = 1
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.txtorderno.Text & "'"
                issuecommand.ExecuteNonQuery()
            End If
            Me.Panel1.Enabled = False
            Me.Label5.Visible = False
            Me.cmbcustid.Enabled = False
            Me.DataGridView2.Visible = True
            Me.datagridview1.Visible = False
            Me.txtorderno.Clear()
            Me.cmbcustid.Text = ""
            Me.txtdateoforder.Clear()
            Me.txtcustname.Clear()
            salesorderedit.Show()
            btnnew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnlckok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        Me.Panel2.Hide()
    End Sub
    Private Sub cmbselorderno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbselorderno.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbselorderno_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbselorderno.SelectedIndexChanged
        Dim dt, dt1, dt2 As New DataTable
        Dim ds As New DataSet
        Dim flag As Integer
        flag = 0
        Me.DataGridView2.Visible = False
        Me.datagridview1.Visible = True
        Try
            cnnstr.Close()
            connect()
            Me.datagridview1.Refresh()
            issuecommand.CommandText = "select productcode,productname,qty,netamt from salesorderdetail where orderno='" & Me.cmbselorderno.Text & "'"
            da.SelectCommand = issuecommand
            ds.Clear()
            da.Fill(ds, "Data")
            If (ds.Tables("data").Rows.Count = 0) Then
                MsgBox("No Records found")
                flag = 1
            End If
            Me.datagridview1.DataSource = ds
            Me.datagridview1.DataMember = "data"
            issuecommand.CommandText = "select * from salesorder where orderno='" & Me.cmbselorderno.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            issuecommand.CommandText = "select customer.custid,customer.custname from customer,salesorder,stockinventory where salesorder.orderno='" & Me.cmbselorderno.Text & "' and customer.custid=salesorder.custid"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.txtcustomerid.Text = dt1.Rows(0).Item(0)
            Me.txtcustomername.Text = dt1.Rows(0).Item(1)
            issuecommand.CommandText = "select salesorder.orderdate from salesorder,customer,stockinventory where salesorder.orderno='" & Me.cmbselorderno.Text & "' and customer.custid=salesorder.custid"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Me.textorderdate.Text = dt2.Rows(1).Item(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtprodqty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprodqty.TextChanged
        Me.Label5.Text = ""
        Me.ErrorProvider1.SetError(Me.Label6, "")
    End Sub
End Class