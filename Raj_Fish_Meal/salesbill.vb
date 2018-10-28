Imports System.Text.RegularExpressions
Imports System.IO
Public Class salesbill
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim flagz As Integer
    Dim netamount As Integer

    Private Sub salesbill_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub cmborderno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmborderno.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmborderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborderno.SelectedIndexChanged
        Dim dt, dt1, dt2 As New DataTable
        Dim flag As Integer
        Try
            connect()
            ' code for discount and vat to display from settings table
            issuecommand.CommandText = "select * from settings"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtdiscount.Text = dt.Rows(0).Item(3)
            Me.txtvat.Text = dt.Rows(0).Item(4)


            'to display products in datagrid
            issuecommand.CommandText = "select distinct salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price,salesorderdetail.netamt from salesorderdetail,salesorder,stockinventory where salesorderdetail.orderno='" & Me.cmborderno.Text & "' and salesorderdetail.productcode=stockinventory.productcode"
            da.SelectCommand = issuecommand
            ds.Clear()
            da.Fill(ds, "Data")
            If (ds.Tables("data").Rows.Count = 0) Then
                MsgBox("No Records found")
                flag = 1
            End If
            Me.DataGridView1.DataSource = ds
            Me.DataGridView1.DataMember = "data"


            issuecommand.CommandText = "select * from salesorder where orderno='" & Me.cmborderno.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.txtcustid.Text = dt1.Rows(0).Item(2)

            issuecommand.CommandText = "select * from customer where custid='" & Me.txtcustid.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Me.txtcustname.Text = dt2.Rows(0).Item(1)
            Me.txtaddress.Text = dt2.Rows(0).Item(2)
            Me.txtnationality.Text = dt2.Rows(0).Item(3)
            Me.txtphno.Text = dt2.Rows(0).Item(4)

            Dim totalamt, m, qty, price As Integer
            totalamt = 0
            For m = 0 To Me.DataGridView1.RowCount - 1
                qty = Me.DataGridView1.Item(2, m).Value
                price = Me.DataGridView1.Item(3, m).Value
                totalamt = totalamt + (qty * price)
            Next
            netamount = totalamt
            Dim discount, vat, totalamt1, totalamt2 As Integer
            discount = Me.txtdiscount.Text
            vat = Me.txtvat.Text
            totalamt1 = (totalamt * vat) / 100
            totalamt2 = (totalamt * discount) / 100
            Me.txtvatrs.Text = totalamt1
            Me.txtdisrs.Text = totalamt2
            Me.txtnet.Text = totalamt
            totalamt = totalamt + totalamt1
            totalamt = totalamt - totalamt2
            Me.txttotalamt.Text = totalamt
            Me.DataGridView1.Visible = True
            Me.DataGridView2.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub salesbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tool tips
        ToolTip1.SetToolTip(Me.cmborderno, "Select order number to generate sales bill")
        ToolTip1.SetToolTip(Me.btnnewbill, "Generate new sales bill")
        ToolTip1.SetToolTip(Me.grbcustdetails, "Customer details")
        ToolTip1.SetToolTip(Me.btnsavebill, "Save generated sales bill")
        ToolTip1.SetToolTip(Me.txtbillno, "Generated bill number")
        ToolTip1.SetToolTip(Me.txtbilldate, "Bill date")
        ToolTip1.SetToolTip(Me.txtdiscount, "Discount")
        ToolTip1.SetToolTip(Me.txtvat, "Value added tax")
        ToolTip1.SetToolTip(Me.txttotalamt, "Final total amount")
        ToolTip1.SetToolTip(Me.txtnet, "Net amount")
        ToolTip1.SetToolTip(Me.txtdisrs, "Discount in Rupees")
        ToolTip1.SetToolTip(Me.txtvatrs, "Value added tax in Rupees")
        ToolTip1.SetToolTip(Me.txtcustid, "Customer id")
        ToolTip1.SetToolTip(Me.txtcustname, "Customer's name")
        ToolTip1.SetToolTip(Me.txtaddress, "Customer's address")
        ToolTip1.SetToolTip(Me.txtnationality, "Customer's phone number")
        ToolTip1.SetToolTip(Me.txtphno, "Customer's e-mail address")
        ToolTip1.SetToolTip(Me.grbcustdetails, "Customer details")
        Dim dt As New DataTable
        Try
            flagz = 0
            cnnstr.Close()
            connect()
            Me.txtbilldate.Text = Today.Date
            issuecommand.CommandText = "select orderno from salesorder where orderno not in (select orderno from salesbill)"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Panel2.Visible = True
                flagz = 1
            End If
            Dim o As Integer
            Me.cmborderno.Items.Clear()
            For o = 0 To dt.Rows.Count - 1
                Me.cmborderno.Items.Add(dt.Rows(o).Item(0))
            Next
            Me.cmborderno.Enabled = False
            Me.btnsavebill.Enabled = False
            Me.DataGridView1.Visible = False
            Me.DataGridView2.Visible = True
            Me.cmborderno.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnnewbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewbill.Click
        Dim dt As New DataTable
        Try
            connect()
            salesbill_Load(sender, e)
            If flagz = 0 Then

                Dim n, k As Integer
                Dim m, i As String
                Dim a() As Integer
                a = New Integer() {0}
                n = 1

                issuecommand.CommandText = "select billno from salesbill"
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

                'Code for reduce the billno, if billno is deleted then it can be reused
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
                Me.txtbillno.Text = "B" & max
                Me.btnnewbill.Enabled = False
                Me.cmborderno.Enabled = True
                Me.btnsavebill.Enabled = True
                Me.cmborderno.Text = ""
                Me.DataGridView1.Visible = False
                Me.DataGridView2.Visible = True
                Me.cmborderno.Enabled = True
            Else
                Me.Panel2.BringToFront()
                Panel2.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnsavebill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavebill.Click
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim i, v As Integer
        v = 0
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select stockinventory.qty,salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty from stockinventory inner join salesorderdetail on salesorderdetail.productcode=stockinventory.productcode where salesorderdetail.orderno='" & Me.cmborderno.Text & "'"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim qut
            Dim K
            For K = 0 To dt1.Rows.Count - 1
                qut = Val(dt1.Rows(K).Item(0)) - Val(dt1.Rows(K).Item(3))
            Next
            If qut <= 0 Then
                MsgBox("Ordered quantity not available")
                Exit Sub
            End If
            If qut > 0 Then
                Dim j
                For j = 0 To dt1.Rows.Count - 1
                    issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty from salesorderdetail inner join stockinventory on salesorderdetail.productcode=stockinventory.productcode where salesorderdetail.orderno='" & Me.cmborderno.Text & "'"
                    da.SelectCommand = issuecommand
                    dt.Clear()
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        MsgBox("Ordered quantity not available")
                    ElseIf dt.Rows.Count > 0 Then
                        For i = 0 To dt.Rows.Count - 1
                            cnnstr.Close()
                            connect()
                            issuecommand.CommandText = "update stockinventory set qty=qty-'" & dt.Rows(i).Item(2) & "' where productcode='" & dt.Rows(i).Item(0) & "' and pname='" & dt.Rows(i).Item(1) & "' "
                            issuecommand.ExecuteNonQuery()
                        Next
                        issuecommand.CommandText = "insert into salesbill values(@billno,@billdate,@orderno,@custid,@netamt,@totalamt)"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@billno", SqlDbType.NVarChar, 50).Value = Me.txtbillno.Text
                        issuecommand.Parameters.Add("@billdate", SqlDbType.DateTime, 8).Value = Me.txtbilldate.Text
                        issuecommand.Parameters.Add("@orderno", SqlDbType.NVarChar, 50).Value = Me.cmborderno.Text
                        issuecommand.Parameters.Add("@custid", SqlDbType.NVarChar, 50).Value = Me.txtcustid.Text
                        issuecommand.Parameters.Add("@netamt", SqlDbType.Int).Value = Val(netamount)
                        issuecommand.Parameters.Add("@totalamt", SqlDbType.Decimal).Value = Val(Me.txttotalamt.Text)
                        issuecommand.ExecuteNonQuery()
                        MsgBox("Bill saved successfully.")
                        rpt6 = "{salesbill.billno}='" & Me.txtbillno.Text & "'" ' and {customer.custid}='" & Me.txtcustid.Text & "'"
                        Dim a As Form
                        a = frmsalesinvoice
                        a.StartPosition = FormStartPosition.CenterScreen
                        a.WindowState = FormWindowState.Maximized
                        a.Show()
                        Me.DataGridView1.Visible = False
                        Me.DataGridView2.Visible = True
                        Me.cmborderno.Enabled = False
                        Me.btnsavebill.Enabled = False
                        Me.btnnewbill.Enabled = True
                        Me.cmborderno.Text = ""
                        Me.txtaddress.Text = ""
                        Me.txtbillno.Text = ""
                        Me.txtcustid.Text = ""
                        Me.txtcustname.Text = ""
                        Me.txtdiscount.Text = ""
                        Me.txtphno.Text = ""
                        Me.txtnationality.Text = ""
                        Me.txttotalamt.Text = ""
                        Me.txtvat.Text = ""
                        Me.txtbilldate.Clear()
                        Me.txtdisrs.Clear()
                        Me.txtvatrs.Clear()
                        Me.txtnet.Clear()
                        'to remove previously selected order number from combobox
                        Me.cmborderno.Items.RemoveAt(Me.cmborderno.SelectedIndex)
                        'salesbill_Load(sender, e)
                        'save(bill)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnlckok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        Me.Close()
    End Sub
End Class