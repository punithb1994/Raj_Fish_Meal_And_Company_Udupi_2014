Public Class frmstock
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Private Sub frmstock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            connect()
            issuecommand.CommandText = "delete from dailyproductionyear"
            issuecommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub frmstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select distinct year(proddate) from dailyproduction1"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.ComboBox1.Items.Clear()
            Me.ComboBox3.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.ComboBox1.Items.Add(dt.Rows(i).Item(0))
                Me.ComboBox3.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.CrystalReportViewer1.Visible = False
        Me.ComboBox2.Text = ""
        Me.ComboBox2.Enabled = True
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select distinct month(proddate) from dailyproduction1 where year(proddate)='" & Val(Me.ComboBox1.Text) & "'"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            Me.ComboBox2.Items.Clear()
            For i = 0 To dt.Rows.Count - 1
                Me.ComboBox2.Items.Add(DateAndTime.MonthName(dt.Rows(i).Item(0)))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Me.CrystalReportViewer1.Visible = True
        Me.CrystalReportViewer1.SelectionFormula = "MonthName (Month ({dailyproduction1.proddate}))='" & Me.ComboBox2.Text & "'"
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Beep()
        e.Handled = True
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            connect()
            issuecommand.CommandText = "select year(proddate),month(proddate),sum(fishmeal),sum(fishoil),sum(fishsoluble),sum(fsp) from dailyproduction1 group by month(proddate),year(proddate)"
            da.SelectCommand = issuecommand
            dt.Clear()
            da.Fill(dt)
            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1
                issuecommand.CommandText = "insert into dailyproductionyear values(@year1,@month1,@fishmeal,@fishoil,@fishsoluble,@fsp)"
                issuecommand.CommandType = CommandType.Text
                issuecommand.Parameters.Clear()
                issuecommand.Parameters.Add("@year1", SqlDbType.BigInt).Value = dt.Rows(i).Item(0)
                issuecommand.Parameters.Add("@month1", SqlDbType.VarChar, 50).Value = DateAndTime.MonthName(dt.Rows(i).Item(1))
                issuecommand.Parameters.Add("@fishmeal", SqlDbType.BigInt).Value = dt.Rows(i).Item(2)
                issuecommand.Parameters.Add("@fishoil", SqlDbType.BigInt).Value = dt.Rows(i).Item(3)
                issuecommand.Parameters.Add("@fishsoluble", SqlDbType.BigInt).Value = dt.Rows(i).Item(4)
                issuecommand.Parameters.Add("@fsp", SqlDbType.BigInt).Value = dt.Rows(i).Item(5)
                issuecommand.ExecuteNonQuery()
            Next
            Me.CrystalReportViewer2.Visible = True
            'MsgBox(Me.ComboBox3.Text)
            Me.CrystalReportViewer2.SelectionFormula = "{dailyproductionyear.year1}=" & Val(Me.ComboBox3.Text)
            Me.CrystalReportViewer2.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmmdihome.onlyone()
        frmmdihome.Panel2.Visible = True
        frmmdihome.Panel1.BringToFront()
        frmmdihome.btnhome.Visible = False
        Me.Close()
    End Sub
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.SelectionFormula = "MonthName (Month ({dailyproduction1.proddate}))='March'"
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub CrystalReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer2.Load
        Me.CrystalReportViewer2.SelectionFormula = "{dailyproductionyear.year1}=2014"
        Me.CrystalReportViewer2.RefreshReport()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmdihome.onlyone()
        frmmdihome.Panel2.Visible = True
        frmmdihome.Panel1.BringToFront()
        frmmdihome.btnhome.Visible = False
        Try
            connect()
            issuecommand.CommandText = "delete from dailyproductionyear"
            issuecommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
        Me.Close()
    End Sub
End Class