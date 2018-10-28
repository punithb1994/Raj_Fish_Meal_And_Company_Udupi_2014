Imports System.Text.RegularExpressions
Imports System.IO
Public Class salesorderedit
    Sub eidload()
        Try
            cnnstr.Close()
            connect()
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select orderno from salesorder where orderno not in(select orderno from salesbill)"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            If dt1.Rows.Count = 0 Then
                Panel1.Visible = False
                Me.cmborderno.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.Button1.Enabled = False
                Me.Panel2.Enabled = True
                Me.Panel2.Visible = True
            Else
                Me.Panel2.Visible = False
            End If
            Dim i As Integer
            Me.cmborderno.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                Me.cmborderno.Items.Add(dt1.Rows(i).Item(0))
            Next


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim item As Control
    Dim availableqtyglobal, availableqtyglobal1, qtytoadd, flag As Integer
    Dim fishmeal, fishoil, fishsoluble, fishpowder As String
    Private Sub cmborderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborderno.SelectedIndexChanged
        Try
            Me.GroupBox4.Enabled = True
            Me.comboproductname.Enabled = False
            btndelete.Enabled = True
            Dim dt, dt1, dt2 As New DataTable
            btnnew.Enabled = True
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from salesorder where orderno='" & Me.cmborderno.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No Order Numbers")
            Else
                Me.txtdateoforder.Text = dt.Rows(0).Item(1)
                Me.txtcustid.Text = dt.Rows(0).Item(2)

            End If
            issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
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

    Private Sub salesorderedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.cmborderno, "Select Order Number To Edit")
        ToolTip1.SetToolTip(Me.btnnew, "Add New Product to Selected Order Number")
        ToolTip1.SetToolTip(Me.btnsave, "Save Product")
        ToolTip1.SetToolTip(Me.btndelete, "To Delete Product From Order Number")
        ToolTip1.SetToolTip(Me.comboproductname, "Select Product Name")
        ToolTip1.SetToolTip(Me.Button1, "Close Editing of Sales Order")
        ToolTip1.SetToolTip(Me.productquantity, "Enter Product Quantity")
        ToolTip1.SetToolTip(Me.btnfishmeal, "Delete Fish Meal From Selected Order Number")
        ToolTip1.SetToolTip(Me.btnfishoil, "Delete Fish Oil From Selected Order Number")
        ToolTip1.SetToolTip(Me.btnfishsoluble, "Delete Fish Soluble From Selected Order Number")
        ToolTip1.SetToolTip(Me.btnfishpowder, "Delete Fish Powder From Selected Order Number")
        ToolTip1.SetToolTip(Me.Button5, "Close")

        Me.cmborderno.Focus()
        Me.productquantity.Enabled = False
        frmmdihome.Enabled = False
        Dim w, h, lw As Integer
        w = frmmdihome.Size.Width
        h = frmmdihome.Size.Height
        lw = frmmdihome.Location.X
        Me.Size = New Size(w, 600)
        Me.Location = New Point(lw, (h \ 2) - (600 \ 2))

        Dim dt, dt1 As New DataTable
        Me.txtprodcode.ReadOnly = True
        Me.txtprice.ReadOnly = True
        Me.txtdateoforder.ReadOnly = True
        Me.txtcustid.ReadOnly = True
        Me.txtcustname.ReadOnly = True
        Try
            cnnstr.Close()
            connect()
            'to load salesorderdetail name to add new products to existing orderno
            issuecommand.CommandText = "select pname from stockinventory"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim j As Integer
            Me.comboproductname.Items.Clear()
            For j = 0 To dt.Rows.Count - 1
                Me.comboproductname.Items.Add(dt.Rows(j).Item(0))
            Next

            ' to select or load sales orderno in cmborderno
            eidload()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtcustid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustid.TextChanged
        Dim dt As New DataTable
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select * from customer where custid='" & Me.txtcustid.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Exit Sub
            End If
            Me.txtcustname.Text = dt.Rows(0).Item(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            connect()
            Me.DataGridView2.ReadOnly = True
            Dim dt1 As New DataTable
            issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Me.DataGridView2.DataSource = dt1
            Me.DataGridView2.Visible = True
            btndelete.Enabled = False
            Me.comboproductname.Enabled = True
            Me.txtprodcode.Enabled = True
            Me.txtprice.Enabled = True
            Me.btnsave.Enabled = True
            Me.comboproductname.Focus()
            Me.btnnew.Enabled = False
            Me.Label12.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub comboproductname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboproductname.SelectedIndexChanged
        Dim dt, dt1, dt2, dt3, dt4, dt5, dt7, dt8 As New DataTable
        Me.productquantity.Visible = True
        flag = 0
        Try
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "select productname from salesorderdetail,salesorder where salesorderdetail.orderno='" & Me.cmborderno.Text & "' and salesorderdetail.productname='" & Me.comboproductname.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                Me.productquantity.Enabled = True
                Me.btnsave.Enabled = True
                MsgBox("Product already selected do you want to update")
                flag = 1

                issuecommand.CommandText = "select * from stockinventory where pname='" & Me.comboproductname.Text & "'"
                da.SelectCommand = issuecommand
                dt7.Clear()
                da.Fill(dt7)
                Me.txtprodcode.Text = dt7.Rows(0).Item(0)
                Me.productquantity.Focus()
                Me.txtprice.Text = dt7.Rows(0).Item(2)
            Else
                Me.btnsave.Enabled = True
                Me.productquantity.Enabled = True
                issuecommand.CommandText = "select * from stockinventory where pname='" & Me.comboproductname.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                Me.txtprodcode.Text = dt.Rows(0).Item(0)
                Me.productquantity.Focus()
                Me.txtprice.Text = dt.Rows(0).Item(2)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim dt, dt2 As New DataTable
        Dim flag1, flag2 As Integer
        flag1 = 0
        flag2 = 0
        Try
            If flag = 0 Then
                If Me.productquantity.Text = "" Then
                    flag1 = 1
                    Me.ErrorProvider1.SetError(Me.productquantity, "Item Quantity must be entered")
                Else
                    Me.ErrorProvider1.SetError(Me.productquantity, "")
                End If
                If flag1 = 0 Then
                    cnnstr.Close()
                    connect()
                    issuecommand.CommandText = "insert into salesorderdetail values(@orderno,@productcode,@productname,@qty,@netamt)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@orderno", SqlDbType.NVarChar, 50).Value = Me.cmborderno.Text
                    issuecommand.Parameters.Add("@productcode", SqlDbType.NVarChar, 50).Value = Me.txtprodcode.Text
                    issuecommand.Parameters.Add("@productname", SqlDbType.VarChar, 50).Value = Me.comboproductname.Text
                    issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(Me.productquantity.Text)
                    issuecommand.Parameters.Add("@netamt", SqlDbType.Money).Value = 100
                    issuecommand.ExecuteNonQuery()

                    'to display again
                    issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
                    da.SelectCommand = issuecommand
                    dt2.Clear()
                    da.Fill(dt2)
                    Me.DataGridView1.DataSource = dt2

                    Me.DataGridView2.Visible = False
                    btndelete.Enabled = True
                    txtprodcode.Clear()
                    txtprice.Clear()
                    productquantity.Clear()
                    Me.comboproductname.Text = ""
                    Me.btnnew.Enabled = True
                    Me.comboproductname.Enabled = False
                    Me.txtprodcode.Enabled = False
                    Me.productquantity.Enabled = False
                    Me.txtprice.Enabled = False
                    Me.btnsave.Enabled = False
                    Me.Label12.Text = "Saved Successfully"
                    Me.Label12.Visible = True ' Label saved successfully
                Else
                    MsgBox("Enter all mandatory fields")
                End If
            ElseIf flag = 1 Then
                flag2 = 0
                If Me.productquantity.Text = "" Then
                    flag2 = 1
                    Me.ErrorProvider1.SetError(Me.productquantity, "Item Quantity must be entered")
                Else
                    Me.ErrorProvider1.SetError(Me.productquantity, "")
                End If
                If flag2 = 0 Then
                    'update 
                    connect()
                    issuecommand.CommandText = "update salesorderdetail set qty=@qty where productname=@productname and orderno=@orderno"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@orderno", SqlDbType.NVarChar, 50).Value = Me.cmborderno.Text
                    issuecommand.Parameters.Add("@productname", SqlDbType.VarChar, 50).Value = Me.comboproductname.Text
                    issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(Me.productquantity.Text)
                    issuecommand.ExecuteNonQuery()
                    'to display again
                    issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
                    da.SelectCommand = issuecommand
                    dt2.Clear()
                    da.Fill(dt2)
                    Me.DataGridView1.DataSource = dt2
                    productquantity.Clear()
                    Me.DataGridView2.Visible = False
                    btndelete.Enabled = True
                    txtprodcode.Clear()
                    txtprice.Clear()
                    Me.btnnew.Enabled = True
                    Me.comboproductname.Text = ""
                    Me.comboproductname.Enabled = False
                    Me.txtprodcode.Enabled = False
                    Me.productquantity.Enabled = False
                    Me.txtprice.Enabled = False
                    Me.btnsave.Enabled = False
                    Me.Label12.Text = "Saved Successfully"
                    Me.Label12.Visible = True ' Label saved successfully
                Else
                    MsgBox("Enter all mandatory fields")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try

    End Sub
    Private Sub productquantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles productquantity.KeyPress
        If Me.productquantity.Text.Length > 5 Then
            Me.ErrorProvider1.SetError(Me.productquantity, "Enter valid quantity")
            Beep()
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.productquantity, "")
        End If
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.productquantity, "Can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.productquantity, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            fishmeal = 0
            fishoil = 0
            fishsoluble = 0
            fishpowder = 0
            Dim dt2 As New DataTable
            Me.Panel1.Visible = True
            issuecommand.CommandText = "select productcode from salesorderdetail where orderno='" & Me.cmborderno.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            Dim j As Integer
            For j = 0 To dt2.Rows.Count - 1
                If dt2.Rows(j).Item(0) = "P1" Then
                    fishmeal = 1
                End If

                If dt2.Rows(j).Item(0) = "P2" Then
                    fishoil = 1
                End If

                If dt2.Rows(j).Item(0) = "P3" Then
                    fishsoluble = 1
                End If

                If dt2.Rows(j).Item(0) = "P4" Then
                    fishpowder = 1
                End If
            Next


            If fishmeal = 1 Then
                Me.btnfishmeal.Enabled = True
            Else
                Me.btnfishmeal.Enabled = False
            End If

            If fishoil = 1 Then
                Me.btnfishoil.Enabled = True
            Else
                Me.btnfishoil.Enabled = False
            End If

            If fishsoluble = 1 Then
                Me.btnfishsoluble.Enabled = True
            Else
                Me.btnfishsoluble.Enabled = False
            End If

            If fishpowder = 1 Then
                Me.btnfishpowder.Enabled = True
            Else
                Me.btnfishpowder.Enabled = False
            End If
            Me.Label12.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Button1.Enabled = True
        Me.Panel1.Visible = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 2500 Then
            Me.Label10.Visible = False
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Label12.Visible = False
        frmmdihome.Focus()
        frmmdihome.Enabled = True
        Me.Close()
    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Me.Button1.Enabled = False
    End Sub
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Me.txtcustname.Clear()
            Me.btnnew.Enabled = False
            Me.txtcustid.Clear()
            Me.DataGridView1.Visible = False
            Me.DataGridView2.Visible = True
            Me.txtdateoforder.Clear()
            Me.cmborderno.Text = ""
            Me.Panel1.Hide()
            Me.btndelete.Enabled = False
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnfishmeal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfishmeal.Click
        Dim dt2, dt5 As New DataTable
        Try
            Me.Timer1.Enabled = True
            Me.Timer1.Start()
            Me.Label10.Visible = True
            Me.Label10.Text = "Fishmeal removed from Sales order"
            connect()
            issuecommand.CommandText = "delete from salesorderdetail where productcode='" & "P1" & " ' and orderno='" & Me.cmborderno.Text & "'"
            issuecommand.ExecuteNonQuery()
            btndelete.Enabled = False
            'to display again
            issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.cmborderno.Text & "'"
                issuecommand.ExecuteNonQuery()
                ' to select or load sales orderno in cmborderno
                eidload()
                Me.cmborderno.Text = ""
            End If
            Me.DataGridView1.DataSource = dt2
            btnfishmeal.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnfishoil_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfishoil.Click
        Dim dt2, dt5 As New DataTable
        'Dim productqty As Integer
        Try
            Me.Timer1.Enabled = True
            Me.Timer1.Start()
            Me.Label10.Visible = True
            Me.Label10.Text = "Fishoil removed from Sales order"
            connect()
            issuecommand.CommandText = "delete from salesorderdetail where productcode='" & "P2" & " ' and orderno='" & Me.cmborderno.Text & "'"
            issuecommand.ExecuteNonQuery()
            btndelete.Enabled = False
            'to display again
            issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.cmborderno.Text & "'"
                issuecommand.ExecuteNonQuery()
                ' to select or load sales orderno in cmborderno
                eidload()
                Me.cmborderno.Text = ""
            End If
            Me.DataGridView1.DataSource = dt2
            btnfishoil.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnfishsoluble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfishsoluble.Click
        Dim dt2, dt5 As New DataTable
        Try
            Me.Timer1.Enabled = True
            Me.Timer1.Start()
            Me.Label10.Visible = True
            Me.Label10.Text = "Fish soluble removed from Sales order"
            cnnstr.Close()
            connect()
            issuecommand.CommandText = "delete from salesorderdetail where productcode='" & "P3" & " ' and orderno='" & Me.cmborderno.Text & "'"
            issuecommand.ExecuteNonQuery()
            btndelete.Enabled = False
            'to display again
            issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.cmborderno.Text & "'"
                issuecommand.ExecuteNonQuery()
                ' to select or load sales orderno in cmborderno
                eidload()
                Me.cmborderno.Text = ""
            End If
            Me.DataGridView1.DataSource = dt2
            btnfishsoluble.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnfishpowder_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfishpowder.Click
        Dim dt2, dt5 As New DataTable
        Try
            Me.Timer1.Enabled = True
            Me.Timer1.Start()
            Me.Label10.Visible = True
            Me.Label10.Text = "Fish Powder removed from Sales order"
            connect()
            issuecommand.CommandText = "delete from salesorderdetail where productcode='" & "P4" & " ' and orderno='" & Me.cmborderno.Text & "'"
            issuecommand.ExecuteNonQuery()
            Me.Label10.Visible = True
            Me.Label10.Text = "Fish Powder removed from Sales order"
            btndelete.Enabled = False
            'to display again
            issuecommand.CommandText = "select salesorderdetail.productcode,salesorderdetail.productname,salesorderdetail.qty,stockinventory.price from salesorderdetail,stockinventory where orderno='" & Me.cmborderno.Text & "' and stockinventory.productcode= salesorderdetail.productcode"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count = 0 Then
                issuecommand.CommandText = "delete from salesorder where orderno='" & Me.cmborderno.Text & "'"
                issuecommand.ExecuteNonQuery()
                ' to select or load sales orderno in cmborderno
                eidload()
                Me.cmborderno.Text = ""
            End If
            Me.DataGridView1.DataSource = dt2
            btnfishpowder.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnlckok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlckok.Click
        For Each item In Me.GroupBox1.Controls
            If TypeOf (item) Is TextBox Then
                item.Text = ""
            End If
        Next
        frmmdihome.Focus()
        frmmdihome.Enabled = True
        Me.Close()
    End Sub

    Private Sub productquantity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles productquantity.Leave
        If Val(Me.productquantity.Text) < 1 Then
            Me.ErrorProvider1.SetError(Me.productquantity, "Quantity must be greater than zero")
            Me.productquantity.Clear()
        End If
    End Sub

    Private Sub productquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles productquantity.TextChanged

    End Sub


End Class