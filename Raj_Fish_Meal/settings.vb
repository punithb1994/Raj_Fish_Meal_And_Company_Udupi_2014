Imports System.Text.RegularExpressions
Imports System.IO
Public Class settings
    Sub updating()
        Dim flag As Integer
        flag = 1
        Dim item As Control
        For Each item In Me.GroupBox1.Controls
            If TypeOf (item) Is CheckBox Then
                If CType(item, CheckBox).Checked = True Then
                    flag = 0
                    Exit For
                End If
            End If
        Next
        If flag = 1 Then
            Me.btnupdate.Enabled = False
        End If
    End Sub
    Public da As New SqlClient.SqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Dim item As Control
    Dim daa, hra, pf, discount, vat As Double
    Private Sub settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub
    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.chkda, "Select to change daily allowance")
        ToolTip1.SetToolTip(Me.chkhra, "Select to change house rent allowance")
        ToolTip1.SetToolTip(Me.chkpf, "Select to change provident fund")
        ToolTip1.SetToolTip(Me.chkdiscount, "Select to change discount")
        ToolTip1.SetToolTip(Me.chkvat, "Select to change value added tax")
        ToolTip1.SetToolTip(Me.txtda, "Change daily allowance")
        ToolTip1.SetToolTip(Me.txthra, "Change house rent allowance")
        ToolTip1.SetToolTip(Me.txtpf, "Change provident fund")
        ToolTip1.SetToolTip(Me.txtdiscount, "Change discount")
        ToolTip1.SetToolTip(Me.txtvat, "Change value added tax")
        ToolTip1.SetToolTip(Me.btnupdate, "Update")
        Try
            connect()
            issuecommand.CommandText = "select * from settings"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            daa = dt.Rows(0).Item(0)
            hra = dt.Rows(0).Item(1)
            pf = dt.Rows(0).Item(2)
            Me.txtdiscount.Text = dt.Rows(0).Item(3)
            Me.txtvat.Text = dt.Rows(0).Item(4)
            daa = (daa * 100)
            Me.txtda.Text = daa
            hra = (hra * 100)
            Me.txthra.Text = hra
            pf = (pf * 100)
            Me.txtpf.Text = pf
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub chkda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkda.CheckedChanged
        If Me.chkda.Checked = True Then
            Me.txtda.Enabled = True
            Me.btnupdate.Enabled = True
        Else
            updating()
            Me.txtda.Enabled = False
        End If

    End Sub

    Private Sub chkhra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhra.CheckedChanged
        If Me.chkhra.Checked = True Then
            Me.txthra.Enabled = True
            Me.btnupdate.Enabled = True
        Else
            updating()
            Me.txthra.Enabled = False
        End If

    End Sub

    Private Sub chkpf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpf.CheckedChanged
        If Me.chkpf.Checked = True Then
            Me.txtpf.Enabled = True
            Me.btnupdate.Enabled = True
        Else
            updating()
            Me.txtpf.Enabled = False
        End If

    End Sub

    Private Sub chkdiscount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdiscount.CheckedChanged
        If Me.chkdiscount.Checked = True Then
            Me.txtdiscount.Enabled = True
            Me.btnupdate.Enabled = True
        Else
            updating()
            Me.txtdiscount.Enabled = False
        End If
    End Sub

    Private Sub chkvat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkvat.CheckedChanged
        If Me.chkvat.Checked = True Then
            Me.txtvat.Enabled = True
            Me.btnupdate.Enabled = True
        Else
            updating()
            Me.txtvat.Enabled = False
        End If
    End Sub

    Private Sub txtda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtda.KeyPress
        'If Val(Me.txtda.Text) = 0 Then
        '    Beep()
        '    Me.ErrorProvider1.SetError(Me.txtda, "DA should be greater than 0")
        '    txtda.Clear()
        '    e.Handled = True
        'End If

        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtda, "DA can contain only numbers!")
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txthra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthra.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txthra, "HRA can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txthra, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtpf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpf.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtpf, "PF can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtpf, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtdiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiscount.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtdiscount, "Discount can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtdiscount, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub
    Private Sub txtvat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvat.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then '8 for backspace and 32 for space
            Beep()
            Me.ErrorProvider1.SetError(Me.txtvat, "VAT can contain only numbers!")
            e.Handled = True
        Else
            Me.ErrorProvider1.SetError(Me.txtvat, "")
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'da validation
        If Val(Me.txtda.Text) > 20 Or Val(Me.txtda.Text) < 1 Then
            Me.txtda.Focus()
            Me.txtda.SelectAll()
            Me.ErrorProvider1.SetError(Me.txtda, "DA must be between 1 to 20")
        End If
        ' hra validation
        If Val(Me.txthra.Text) > 20 Or Val(Me.txthra.Text) < 1 Then
            Me.txthra.Focus()
            Me.txthra.SelectAll()
            Me.ErrorProvider1.SetError(Me.txthra, "HRA must be between 1 to 20")
        End If

        ' PF validation
        If Val(Me.txtpf.Text) > 20 Or Val(Me.txtpf.Text) < 1 Then
            Me.txtpf.Focus()
            Me.txtpf.SelectAll()
            Me.ErrorProvider1.SetError(Me.txtpf, "PF must be between 1 to 20")
        End If

        ' Discount validation
        If Val(Me.txtdiscount.Text) > 20 Or Val(Me.txtdiscount.Text) < 1 Then
            Me.txtdiscount.Focus()
            Me.txtdiscount.SelectAll()
            Me.ErrorProvider1.SetError(Me.txtdiscount, "Discount must be between 1 to 20")
        End If

        ' Vat validation
        If Val(Me.txtvat.Text) > 20 Or Val(Me.txtvat.Text) < 1 Then
            Me.txtvat.Focus()
            Me.txtvat.SelectAll()
            Me.ErrorProvider1.SetError(Me.txtvat, "Vat must be between 1 to 20")
        End If

        'timer check validation
        If Me.Timer1.Interval = 5 Then
            Me.Timer1.Interval = 5
        End If
    End Sub

    Private Sub txtda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtda.TextChanged
        Me.ErrorProvider1.SetError(Me.txtda, "")
    End Sub
    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim da1, hra1, pf1 As Double
        Dim flag As Integer
        flag = 0
        Try
            If Me.txtda.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtda, "DA must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtda, "")
            End If

            If Me.txthra.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txthra, "HRA must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txthra, "")
            End If

            If Me.txtpf.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtpf, "PF must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtpf, "")
            End If

            If Me.txtdiscount.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtdiscount, "Discount must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtdiscount, "")
            End If


            If Me.txtvat.Text = "" Then
                flag = 1
                Me.ErrorProvider1.SetError(Me.txtvat, "VAT must be entered")
            Else
                Me.ErrorProvider1.SetError(Me.txtvat, "")
            End If
            If flag = 0 Then
                connect()
                issuecommand.CommandText = "update settings set da=@da,hra=@hra,pf=@pf,discount=@discount,vat=@vat"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()

                da1 = Me.txtda.Text
                da1 = (da1 / 100)

                hra1 = Me.txthra.Text
                hra1 = (hra1 / 100)

                pf1 = Me.txtpf.Text
                pf1 = (pf1 / 100)
                issuecommand.Parameters.Add("@da", SqlDbType.Float, 50).Value = da1
                issuecommand.Parameters.Add("@hra", SqlDbType.Float, 50).Value = hra1
                issuecommand.Parameters.Add("@pf", SqlDbType.Float, 50).Value = pf1
                issuecommand.Parameters.Add("@discount", SqlDbType.Float, 50).Value = Me.txtdiscount.Text
                issuecommand.Parameters.Add("@vat", SqlDbType.Float, 50).Value = Me.txtvat.Text
                issuecommand.ExecuteNonQuery()
                MsgBox("Details updated", MsgBoxStyle.SystemModal)
                Me.chkda.Checked = False
                Me.chkhra.Checked = False
                Me.chkpf.Checked = False
                Me.chkdiscount.Checked = False
                Me.chkvat.Checked = False
                Me.txtda.Enabled = False
                Me.txthra.Enabled = False
                Me.txtpf.Enabled = False
                Me.txtdiscount.Enabled = False
                Me.txtvat.Enabled = False
                cnnstr.Close()
                settings_Load(sender, e)
            Else
                MsgBox("Enter all mandatory fields!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
End Class