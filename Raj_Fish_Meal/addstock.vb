Imports System.Text.RegularExpressions
Public Class addstock
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim item As Control
    Dim ydiff, flag, ctr, qty As Integer
    Dim quantity As Integer
    Public space = 0
    Private Sub addstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.btnupdate, "Click here to update customer information")
        ToolTip1.SetToolTip(Me.cmbproductcode, "Select product code to add stock")
        ToolTip1.SetToolTip(Me.txtprodname, "Product name")
        ToolTip1.SetToolTip(Me.txtperprice, "Price per product")
        ToolTip1.SetToolTip(Me.txtqty, "Enter quantity")
        ToolTip1.SetToolTip(Me.txtdesc, "Product description")
        ToolTip1.SetToolTip(Me.TextBox2, "Available stock")
        Dim dt1 As New DataTable
        Dim dt2, dt3 As New DataTable
        Me.txtdate.Text = Today.Date
        Me.txtprodname.Enabled = False
        Me.txtperprice.Enabled = False
        Me.txtqty.Enabled = False
        Me.txtdesc.ReadOnly = True
        Try
            connect()
            issuecommand.CommandText = "select productcode from stockinventory"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim i As Integer
            Me.cmbproductcode.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                Me.cmbproductcode.Items.Add(dt1.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim dt10, dt3, dt, dt1 As New DataTable
        Try
            flag = 0
            If Me.txtperprice.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtperprice, "Price of the Product must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtperprice, "")
            End If

            If Me.txtqty.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtqty, "Quantity of the Product must be entered")
            End If
            If Val(Me.txtqty.Text) < 1000 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtqty, "Quantity must contain be minimum 1000 KGs")
            End If
            If Val(Me.txtqty.Text) > 10000 Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtqty, "Quantity cannot more than 10000 KGs")
            End If

            issuecommand.CommandText = "select * from stockinventory where productcode='" & Me.cmbproductcode.Text & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            quantity = dt3.Rows(0).Item(3)
            If flag = 0 Then
                connect()
                issuecommand.CommandText = "update stockinventory set pname=@pname,price=@price,qty=@qty,description=@description where productcode=@productcode"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@productcode", SqlDbType.NVarChar, 50).Value = Me.cmbproductcode.Text
                issuecommand.Parameters.Add("@pname", SqlDbType.VarChar, 50).Value = Me.txtprodname.Text
                issuecommand.Parameters.Add("@price", SqlDbType.Decimal, 18).Value = Me.txtperprice.Text
                issuecommand.Parameters.Add("@qty", SqlDbType.BigInt, 50).Value = Val(Me.txtqty.Text + quantity)
                issuecommand.Parameters.Add("@description", SqlDbType.NVarChar, 50).Value = Me.txtdesc.Text
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "select * from dailyproduction where mfgdate='" & Me.txtdate.Text & "' and productcode='" & Me.cmbproductcode.Text & "'"
                da.SelectCommand = issuecommand
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    issuecommand.CommandText = "insert into dailyproduction values(@productcode,@mfgdate,@qty)"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@productcode", SqlDbType.NVarChar, 50).Value = Me.cmbproductcode.Text
                    issuecommand.Parameters.Add("@mfgdate", SqlDbType.DateTime).Value = Me.txtdate.Text
                    issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                    issuecommand.ExecuteNonQuery()
                Else
                    issuecommand.CommandText = "update dailyproduction set qty=qty+@qty where mfgdate='" & Me.txtdate.Text & "' and productcode='" & Me.cmbproductcode.Text & "'"
                    issuecommand.CommandType = CommandType.Text
                    issuecommand.Parameters.Clear()
                    issuecommand.Parameters.Add("@qty", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                    issuecommand.ExecuteNonQuery()
                End If
                issuecommand.CommandText = "select * from dailyproduction1 where proddate='" & Me.txtdate.Text & "'"
                da.SelectCommand = issuecommand
                dt1.Clear()
                da.Fill(dt1)
                If dt1.Rows.Count = 0 Then
                    If Me.cmbproductcode.SelectedIndex = 0 Then
                        issuecommand.CommandText = "insert into dailyproduction1 values(@proddate,@fishmeal,@fishoil,@fishsoluble,@fsp)"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@proddate", SqlDbType.DateTime).Value = Me.txtdate.Text
                        issuecommand.Parameters.Add("@fishmeal", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.Parameters.Add("@fishoil", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fishsoluble", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fsp", SqlDbType.BigInt).Value = 0
                        issuecommand.ExecuteNonQuery()
                    ElseIf Me.cmbproductcode.SelectedIndex = 1 Then
                        issuecommand.CommandText = "insert into dailyproduction1 values(@proddate,@fishmeal,@fishoil,@fishsoluble,@fsp)"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@proddate", SqlDbType.DateTime).Value = Me.txtdate.Text
                        issuecommand.Parameters.Add("@fishmeal", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fishoil", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.Parameters.Add("@fishsoluble", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fsp", SqlDbType.BigInt).Value = 0
                        issuecommand.ExecuteNonQuery()
                    ElseIf Me.cmbproductcode.SelectedIndex = 2 Then
                        issuecommand.CommandText = "insert into dailyproduction1 values(@proddate,@fishmeal,@fishoil,@fishsoluble,@fsp)"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@proddate", SqlDbType.DateTime).Value = Me.txtdate.Text
                        issuecommand.Parameters.Add("@fishmeal", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fishoil", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fishsoluble", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.Parameters.Add("@fsp", SqlDbType.BigInt).Value = 0
                        issuecommand.ExecuteNonQuery()
                    ElseIf Me.cmbproductcode.SelectedIndex = 3 Then
                        issuecommand.CommandText = "insert into dailyproduction1 values(@proddate,@fishmeal,@fishoil,@fishsoluble,@fsp)"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@proddate", SqlDbType.DateTime).Value = Me.txtdate.Text
                        issuecommand.Parameters.Add("@fishmeal", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fishoil", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fishsoluble", SqlDbType.BigInt).Value = 0
                        issuecommand.Parameters.Add("@fsp", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.ExecuteNonQuery()
                    End If
                Else
                    If Me.cmbproductcode.SelectedIndex = 0 Then
                        issuecommand.CommandText = "update dailyproduction1 set fishmeal=fishmeal+@fishmeal where proddate='" & Me.txtdate.Text & "'"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@fishmeal", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.ExecuteNonQuery()
                    ElseIf Me.cmbproductcode.SelectedIndex = 1 Then
                        issuecommand.CommandText = "update dailyproduction1 set fishoil=fishoil+@fishoil where proddate='" & Me.txtdate.Text & "'"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@fishoil", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.ExecuteNonQuery()
                    ElseIf Me.cmbproductcode.SelectedIndex = 2 Then
                        issuecommand.CommandText = "update dailyproduction1 set fishsoluble=fishsoluble+@fishsoluble where proddate='" & Me.txtdate.Text & "'"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@fishsoluble", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.ExecuteNonQuery()
                    ElseIf Me.cmbproductcode.SelectedIndex = 3 Then
                        issuecommand.CommandText = "update dailyproduction1 set fsp=fsp+@fsp where proddate='" & Me.txtdate.Text & "'"
                        issuecommand.CommandType = CommandType.Text
                        issuecommand.Parameters.Clear()
                        issuecommand.Parameters.Add("@fsp", SqlDbType.BigInt).Value = Val(Me.txtqty.Text)
                        issuecommand.ExecuteNonQuery()
                    End If
                End If
                Me.cmbproductcode.Text = ""
                Me.txtprodname.Clear()
                Me.txtperprice.Clear()
                Me.txtqty.Clear()
                Me.txtdesc.Clear()
                Me.TextBox2.Clear()
                Me.txtprodname.Enabled = False
                Me.txtperprice.Enabled = False
                Me.txtqty.Enabled = False
                'Me.txtdesc.Enabled = False
                Me.btnupdate.Enabled = False
                MsgBox("Details updated successfully.")
                Me.ErrorProvider1.Clear()
                cnnstr.Close()
                cmbproductcode_SelectedIndexChanged_1(sender, e)
            Else
                Beep()
                MsgBox("Enter all mandatory fields!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub cmbproductcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbproductcode.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub cmbproductcode_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproductcode.SelectedIndexChanged
        Dim dt, dt2 As New DataTable
        Me.txtqty.Focus()
        Try
            connect()
            issuecommand.CommandText = "select qty from stockinventory where productcode ='" & Me.cmbproductcode.Text & "'"
            da.SelectCommand = issuecommand
            dt2.Clear()
            da.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                Me.TextBox2.Text = dt2.Rows(0).Item(0)
            Else
                Me.TextBox2.Text = 0
            End If

            issuecommand.CommandText = "select * from stockinventory where productcode='" & Me.cmbproductcode.Text & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Me.txtprodname.Text = dt.Rows(0).Item(1)
            Me.txtperprice.Text = dt.Rows(0).Item(2)
            Me.txtqty.Text = ""
            'Me.txtqty.Text = dt.Rows(0).Item(3)
            '  Me.DateTimePicker1.Value = dt.Rows(0).Item(4)
            Me.txtdesc.Text = dt.Rows(0).Item(4)
            Me.txtprodname.Enabled = True
            Me.txtprodname.ReadOnly = True
            Me.txtperprice.Enabled = True
            Me.txtqty.Enabled = True
            Me.txtdesc.ReadOnly = True
            Me.btnupdate.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub txtperprice_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtperprice.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtperprice, "Price can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtperprice, "")
        End If
        If Me.txtperprice.Text.Length > 9 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtqty_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        Me.ErrorProvider1.SetError(Me.txtqty, "")
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqty, "Quantity can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtqty, "")
        End If
        If Me.txtqty.Text.Length > 9 Then
            Beep()
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtqty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.Leave
        If Val(Me.txtqty.Text) < 1000 Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqty, "Quantity must contain be minimum 1000 KGs")
        End If
        If Val(Me.txtqty.Text) > 10000 Then
            Beep()
            Me.ErrorProvider1.SetError(Me.txtqty, "Quantity cannot more than 10000 KGs")
            Me.txtqty.Clear()
        End If
    End Sub
End Class