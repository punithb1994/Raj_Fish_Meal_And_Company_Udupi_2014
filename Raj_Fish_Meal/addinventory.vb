Public Class addinventory
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Public dt, dt1 As New DataTable
    Dim item As Control
    Dim ydiff, flag, ctr As Integer
    Dim path As Integer
    Dim img1 As Image
    'Dim s As String
    Public space = 0

    Private Sub addinventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub addinventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtsuppliername.Enabled = False
        Me.txtitemtype2.Visible = False
        Me.btnsave.Enabled = False
        Me.cmbitemcode.Visible = False
        Me.txtitemcode.Visible = True
        Me.cmbcatid.Visible = False
        Me.cmbitype1.Visible = False
        Me.cmbitype2.Visible = False
        Me.grpinventoryinfo.Enabled = False

        Try
            Dim dt1 As New DataTable
            connect()
            issuecommand.CommandText = "select supid from supplier"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            Dim i As Integer
            Me.cmbsuppid.Items.Clear()
            For i = 0 To dt1.Rows.Count - 1
                Me.cmbsuppid.Items.Add(dt1.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try

    End Sub

    Private Sub grpinventoryinfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpinventoryinfo.Enter

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Me.grpinventoryinfo.Enabled = True
        Me.btnsave.Enabled = True
        Me.cmbitemcode.Visible = True
        Me.txtitemcode.Visible = False
        Me.cmbcatid.Visible = True
        Me.cmbitype1.Visible = True
        Me.cmbitype2.Visible = True
        Me.txtcatid.Visible = False
        Me.txtitemtype1.Visible = False
        Me.txtitemtype2.Visible = False

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.txtopeningstock.Text = 0
        Me.txtsuppliername.Enabled = False
        Me.grpinventoryinfo.Enabled = True
        Me.btnsave.Enabled = True
        Me.cmbitemcode.Visible = False
        Me.txtitemcode.Visible = True
        Me.txtitemtype1.Visible = True
        Me.txtitemtype2.Visible = False
        Me.cmbcatid.Visible = False
        Me.cmbitype1.Visible = False
        Me.cmbitype2.Visible = False
        Me.txtcatid.Visible = True
        Me.txtcatid.Enabled = False
        Me.cmbitemname.Focus()
        Me.btnadd.Enabled = False

        'To generate new Cat id
        Try
            Dim n, k As Integer
            Dim m, i As String
            Dim a() As Integer
            a = New Integer() {0}
            n = 1
            connect()
            issuecommand.CommandText = "select catid from category"
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

            'Code for reduce the catid, if catid is deleted then it can be reused
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
            Me.txtcatid.Text = "C" & max










            'to generate new item code
            Dim n1, k1 As Integer
            Dim m1, i1 As String
            Dim a1() As Integer
            a1 = New Integer() {0}
            n1 = 1
            issuecommand.CommandText = "select itemcode from rawinventory"
            da.SelectCommand = issuecommand
            dt1.Clear()
            da.Fill(dt1)
            ReDim a1(dt1.Rows.Count)
            For k1 = 0 To dt1.Rows.Count - 1
                i1 = dt1.Rows(k1).Item(0)
                m1 = ""
                Dim length = Len(i1)
                For n1 = 1 To length
                    Dim ch1 = Mid(i1, n1, 1)
                    If (Char.IsNumber(ch1)) Then
                        m1 = m1 + ch1
                    End If
                Next
                a1(k1) = Int(m1)
            Next

            'Code for reduce the itemid, if itemid is deleted then it can be reused
            Dim len2 = a1.Length
            Dim t1, j1, temp1, max1 As Integer
            For t1 = 0 To len2 - 1
                For j1 = t1 + 1 To len2 - 1
                    If a1(t1) > a1(j1) Then
                        temp1 = a1(t1)
                        a1(t1) = a1(j1)
                        a1(j1) = temp1
                    End If
                Next
            Next
            t1 = 1
            For j1 = 0 To len2 - 1
                If t1 = a1(j1) Then
                    t1 += 1
                    j1 = 0
                End If
            Next
            max1 = t1
            Me.txtitemcode.Text = "I" & max1
            Me.btnnew.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try

            Dim flag1 As Integer
            flag1 = 0
            ' Validation for item name
            If Me.cmbitemname.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.cmbitemname, "Name of the item must be selected")
            Else
                Me.ErrorProvider1.SetError(Me.cmbitemname, "")
            End If
            'validation for item 1

            If Me.txtitemtype1.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtitemtype1, "Must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtitemtype1, "")
            End If
            If Me.cmbitemname.Text = "Hardwares" Then
                'validation for item 2

                If Me.txtitemtype2.Text = "" Then
                    flag1 = 1
                    Me.ErrorProvider1.SetError(Me.txtitemtype2, "Must be entered")
                Else
                    Me.ErrorProvider1.SetError(Me.txtitemtype2, "")
                End If
            End If
            'Validation for supplier id
            If Me.cmbsuppid.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.cmbsuppid, "Supplier id must be selected")
            Else
                Me.ErrorProvider1.SetError(Me.cmbsuppid, "")
            End If
            'Validation for supplier id
            If Me.txtincomingstock.Text = "" Then
                flag1 = 1
                Me.ErrorProvider1.SetError(Me.txtincomingstock, "Incoming Stock must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtincomingstock, "")
            End If

            If flag1 = 0 Then
                connect()
                issuecommand.CommandText = "insert into category values(@catid,@catname,@type)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar, 50).Value = Me.txtcatid.Text
                issuecommand.Parameters.Add("@catname", SqlDbType.NVarChar, 50).Value = Me.txtitemtype1.Text
                issuecommand.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = Me.txtitemtype2.Text
                issuecommand.ExecuteNonQuery()
                issuecommand.CommandText = "insert into rawinventory values(@itemcode,@itemname,@supid,@qty,@catid)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@itemcode", SqlDbType.NVarChar, 50).Value = Me.txtitemcode.Text
                issuecommand.Parameters.Add("@itemname", SqlDbType.NVarChar, 50).Value = Me.cmbitemname.Text
                issuecommand.Parameters.Add("@supid", SqlDbType.NVarChar, 50).Value = Me.cmbsuppid.Text
                issuecommand.Parameters.Add("@qty", SqlDbType.NVarChar, 50).Value = Me.txtclosingstock.Text
                issuecommand.Parameters.Add("@catid", SqlDbType.NVarChar, 50).Value = Me.txtcatid.Text
                issuecommand.ExecuteNonQuery()
                MsgBox("Details saved successfully.")
                Me.txtcatid.Clear()
                Me.txtitemtype1.Clear()
                Me.txtitemtype2.Clear()
                Me.cmbcatid.Text = ""
                Me.txtclosingstock.Clear()
                Me.txtincomingstock.Clear()
                Me.txtitemcode.Clear()
                Me.txtopeningstock.Clear()
                Me.txtsuppliername.Clear()
                Me.inventorydate.Value = Today
                Me.cmbsuppid.Text = ""
                Me.cmbitemname.Text = ""
                Me.btnadd.Enabled = True
                Me.btnnew.Enabled = True
                Me.btnsave.Enabled = False
            Else
                MsgBox("Enter all mandatory fields!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbsuppid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsuppid.SelectedIndexChanged
        Dim dt3 As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select * from supplier where supid='" & Me.cmbsuppid.Text & "'"
            da.SelectCommand = issuecommand
            dt3.Clear()
            da.Fill(dt3)
            Me.txtsuppliername.Text = dt3.Rows(0).Item(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub cmbitemname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitemname.SelectedIndexChanged
        If Me.cmbitemname.Text = "Hardwares" Then
            Me.txtitemtype2.Visible = True
        Else
            Me.txtitemtype2.Visible = False
        End If
    End Sub


    Private Sub txtincomingstock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtincomingstock.LostFocus
        Dim x, y, z As Integer
        Try
            x = Me.txtopeningstock.Text
            y = Me.txtincomingstock.Text
            z = x + y
            Me.txtclosingstock.Text = z
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtopeningstock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtopeningstock.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtincomingstock, "Enter only numbers")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtincomingstock, "")
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If Me.txtincomingstock.Text.Length > 10 Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtopeningstock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtopeningstock.TextChanged

    End Sub
End Class