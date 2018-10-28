Public Class viewcustomer
    Public da As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Dim i, n, m As Integer
    Dim bds As New BindingSource

    Private Sub viewcustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmmdihome.Panel1.BringToFront()
    End Sub

    Private Sub viewcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tooltips
        ToolTip1.SetToolTip(Me.btnfirst, "First customer record")
        ToolTip1.SetToolTip(Me.btnprev, "Previous customer record")
        ToolTip1.SetToolTip(Me.btnnext, "Next customer record")
        ToolTip1.SetToolTip(Me.btnlast, "Last customer record")


        ToolTip1.SetToolTip(Me.txtcid, "Customer Id")
        ToolTip1.SetToolTip(Me.txtcustname, "Customer name")
        ToolTip1.SetToolTip(Me.txtaddress, "Customer address")
        ToolTip1.SetToolTip(Me.txtnationality, "Customer's nationality")

        ToolTip1.SetToolTip(Me.txtlanno, "Customer's landline number")
        ToolTip1.SetToolTip(Me.txtmobno, "Customer's mobile number")
        ToolTip1.SetToolTip(Me.txtemail, "Customer's email address")

        Me.btnfirst.Enabled = True
        Me.btnlast.Enabled = True
        Me.btnnext.Enabled = True
        Me.btnprev.Enabled = True
        Try
            connect()
            issuecommand.CommandText = "select * from customer"
            da.SelectCommand = issuecommand
            ds.Clear()
            da.Fill(ds, "customer")
            m = ds.Tables("customer").Rows.Count - 1
            bds.DataSource = ds
            bds.DataMember = "customer"
            Me.txtcid.DataBindings.Clear()
            Me.txtcustname.DataBindings.Clear()
            Me.txtaddress.DataBindings.Clear()
            Me.txtlanno.DataBindings.Clear()
            Me.txtemail.DataBindings.Clear()
            Me.txtcid.DataBindings.Add("text", bds, "custid")
            Me.txtcustname.DataBindings.Add("text", bds, "custname")
            Me.txtaddress.DataBindings.Add("text", bds, "custadd")
            Me.txtnationality.DataBindings.Add("text", bds, "nationality")
            Me.txtlanno.DataBindings.Add("text", bds, "custlandline")
            Me.txtmobno.DataBindings.Add("text", bds, "custmobile")
            Me.txtemail.DataBindings.Add("text", bds, "custemail")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnnstr.Close()
        End Try
    End Sub

    Private Sub btnfirst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        Me.Label2.Visible = True
        Me.Label2.Text = ""
        Me.Label2.Text = "First Record"
        bds.MoveFirst()
        Me.btnprev.Enabled = False
        Me.btnnext.Enabled = True
        Me.btnfirst.Enabled = False
        Me.btnlast.Enabled = True
    End Sub

    Private Sub btnprev_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Me.btnlast.Enabled = True
        Me.btnnext.Enabled = True
        If bds.Position = 0 Then
            Me.Label2.Visible = True
            Me.Label2.Text = ""
            Me.Label2.Text = "First Record"
            Me.btnprev.Enabled = False
            Me.btnfirst.Enabled = False
        Else
            Me.btnfirst.Enabled = True
            Me.btnprev.Enabled = True
            Me.Label2.Visible = False
        End If
        bds.MovePrevious()
    End Sub

    Private Sub btnnext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Me.btnfirst.Enabled = True
        Me.btnprev.Enabled = True
        If bds.Position = m Then
            Me.Label2.Visible = True
            Me.Label2.Text = ""
            Me.Label2.Text = "Last Record"
            Me.btnnext.Enabled = False
            Me.btnlast.Enabled = False
        Else
            Me.btnlast.Enabled = True
            Me.btnnext.Enabled = True
            Me.Label2.Visible = False
        End If
        bds.MoveNext()

    End Sub

    Private Sub btnlast_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        Me.Label2.Visible = True
        Me.Label2.Text = ""
        Me.Label2.Text = "Last Record"
        bds.MoveLast()
        Me.btnprev.Enabled = True
        Me.btnnext.Enabled = False
        Me.btnlast.Enabled = False
        Me.btnfirst.Enabled = True
    End Sub
End Class
