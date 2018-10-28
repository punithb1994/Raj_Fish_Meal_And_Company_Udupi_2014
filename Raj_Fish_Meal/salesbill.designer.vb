<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesbill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblbillno = New System.Windows.Forms.Label
        Me.lblbilldate = New System.Windows.Forms.Label
        Me.txtbillno = New System.Windows.Forms.TextBox
        Me.grbprice = New System.Windows.Forms.GroupBox
        Me.txtnet = New System.Windows.Forms.TextBox
        Me.txtvatrs = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdisrs = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttotalamt = New System.Windows.Forms.TextBox
        Me.lbltotalamt = New System.Windows.Forms.Label
        Me.txtvat = New System.Windows.Forms.TextBox
        Me.lblvat = New System.Windows.Forms.Label
        Me.grbcustdetails = New System.Windows.Forms.GroupBox
        Me.txtphno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnationality = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.txtcustid = New System.Windows.Forms.TextBox
        Me.lblphno = New System.Windows.Forms.Label
        Me.lbladdress = New System.Windows.Forms.Label
        Me.lblcustname = New System.Windows.Forms.Label
        Me.lblcustid = New System.Windows.Forms.Label
        Me.lblsalesorderno = New System.Windows.Forms.Label
        Me.cmborderno = New System.Windows.Forms.ComboBox
        Me.btnsavebill = New System.Windows.Forms.Button
        Me.btnnewbill = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtbilldate = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnlckok = New System.Windows.Forms.Button
        Me.grbprice.SuspendLayout()
        Me.grbcustdetails.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblbillno
        '
        Me.lblbillno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbillno.AutoSize = True
        Me.lblbillno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbillno.ForeColor = System.Drawing.Color.White
        Me.lblbillno.Location = New System.Drawing.Point(24, 23)
        Me.lblbillno.Name = "lblbillno"
        Me.lblbillno.Size = New System.Drawing.Size(56, 19)
        Me.lblbillno.TabIndex = 0
        Me.lblbillno.Text = "Bill No:"
        '
        'lblbilldate
        '
        Me.lblbilldate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbilldate.AutoSize = True
        Me.lblbilldate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilldate.ForeColor = System.Drawing.Color.White
        Me.lblbilldate.Location = New System.Drawing.Point(504, 16)
        Me.lblbilldate.Name = "lblbilldate"
        Me.lblbilldate.Size = New System.Drawing.Size(69, 19)
        Me.lblbilldate.TabIndex = 1
        Me.lblbilldate.Text = "Bill Date:"
        '
        'txtbillno
        '
        Me.txtbillno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbillno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbillno.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtbillno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Location = New System.Drawing.Point(26, 44)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.ReadOnly = True
        Me.txtbillno.Size = New System.Drawing.Size(235, 27)
        Me.txtbillno.TabIndex = 2
        '
        'grbprice
        '
        Me.grbprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbprice.Controls.Add(Me.txtnet)
        Me.grbprice.Controls.Add(Me.txtvatrs)
        Me.grbprice.Controls.Add(Me.Label5)
        Me.grbprice.Controls.Add(Me.Label6)
        Me.grbprice.Controls.Add(Me.Label4)
        Me.grbprice.Controls.Add(Me.txtdisrs)
        Me.grbprice.Controls.Add(Me.txtdiscount)
        Me.grbprice.Controls.Add(Me.Label3)
        Me.grbprice.Controls.Add(Me.txttotalamt)
        Me.grbprice.Controls.Add(Me.lbltotalamt)
        Me.grbprice.Controls.Add(Me.txtvat)
        Me.grbprice.Controls.Add(Me.lblvat)
        Me.grbprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbprice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbprice.ForeColor = System.Drawing.Color.DarkGray
        Me.grbprice.Location = New System.Drawing.Point(26, 211)
        Me.grbprice.Name = "grbprice"
        Me.grbprice.Size = New System.Drawing.Size(717, 87)
        Me.grbprice.TabIndex = 5
        Me.grbprice.TabStop = False
        '
        'txtnet
        '
        Me.txtnet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnet.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtnet.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnet.Location = New System.Drawing.Point(28, 45)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.ReadOnly = True
        Me.txtnet.Size = New System.Drawing.Size(105, 27)
        Me.txtnet.TabIndex = 13
        Me.txtnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvatrs
        '
        Me.txtvatrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtvatrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvatrs.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtvatrs.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvatrs.ForeColor = System.Drawing.Color.Black
        Me.txtvatrs.Location = New System.Drawing.Point(472, 45)
        Me.txtvatrs.Name = "txtvatrs"
        Me.txtvatrs.ReadOnly = True
        Me.txtvatrs.Size = New System.Drawing.Size(105, 27)
        Me.txtvatrs.TabIndex = 11
        Me.txtvatrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(468, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "VAT( in Rs)"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Net Amount"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(247, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Discount(in Rs)"
        '
        'txtdisrs
        '
        Me.txtdisrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdisrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdisrs.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtdisrs.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisrs.Location = New System.Drawing.Point(250, 45)
        Me.txtdisrs.Name = "txtdisrs"
        Me.txtdisrs.ReadOnly = True
        Me.txtdisrs.Size = New System.Drawing.Size(105, 27)
        Me.txtdisrs.TabIndex = 8
        Me.txtdisrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdiscount.BackColor = System.Drawing.SystemColors.Control
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscount.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtdiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.ForeColor = System.Drawing.Color.Black
        Me.txtdiscount.Location = New System.Drawing.Point(139, 45)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(105, 27)
        Me.txtdiscount.TabIndex = 7
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(135, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount(in %)"
        '
        'txttotalamt
        '
        Me.txttotalamt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttotalamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalamt.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttotalamt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamt.Location = New System.Drawing.Point(583, 45)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.ReadOnly = True
        Me.txttotalamt.Size = New System.Drawing.Size(105, 27)
        Me.txttotalamt.TabIndex = 5
        Me.txttotalamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotalamt
        '
        Me.lbltotalamt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltotalamt.AutoSize = True
        Me.lbltotalamt.ForeColor = System.Drawing.Color.White
        Me.lbltotalamt.Location = New System.Drawing.Point(579, 23)
        Me.lbltotalamt.Name = "lbltotalamt"
        Me.lbltotalamt.Size = New System.Drawing.Size(95, 19)
        Me.lbltotalamt.TabIndex = 4
        Me.lbltotalamt.Text = "Total Amount"
        '
        'txtvat
        '
        Me.txtvat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtvat.BackColor = System.Drawing.SystemColors.Control
        Me.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvat.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtvat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvat.ForeColor = System.Drawing.Color.Black
        Me.txtvat.Location = New System.Drawing.Point(361, 45)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.ReadOnly = True
        Me.txtvat.Size = New System.Drawing.Size(105, 27)
        Me.txtvat.TabIndex = 2
        Me.txtvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblvat
        '
        Me.lblvat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblvat.AutoSize = True
        Me.lblvat.ForeColor = System.Drawing.Color.White
        Me.lblvat.Location = New System.Drawing.Point(357, 23)
        Me.lblvat.Name = "lblvat"
        Me.lblvat.Size = New System.Drawing.Size(74, 19)
        Me.lblvat.TabIndex = 0
        Me.lblvat.Text = "VAT( in %)"
        '
        'grbcustdetails
        '
        Me.grbcustdetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbcustdetails.Controls.Add(Me.txtphno)
        Me.grbcustdetails.Controls.Add(Me.Label2)
        Me.grbcustdetails.Controls.Add(Me.txtnationality)
        Me.grbcustdetails.Controls.Add(Me.txtaddress)
        Me.grbcustdetails.Controls.Add(Me.txtcustname)
        Me.grbcustdetails.Controls.Add(Me.txtcustid)
        Me.grbcustdetails.Controls.Add(Me.lblphno)
        Me.grbcustdetails.Controls.Add(Me.lbladdress)
        Me.grbcustdetails.Controls.Add(Me.lblcustname)
        Me.grbcustdetails.Controls.Add(Me.lblcustid)
        Me.grbcustdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbcustdetails.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbcustdetails.ForeColor = System.Drawing.Color.DarkGray
        Me.grbcustdetails.Location = New System.Drawing.Point(28, 301)
        Me.grbcustdetails.Name = "grbcustdetails"
        Me.grbcustdetails.Size = New System.Drawing.Size(715, 143)
        Me.grbcustdetails.TabIndex = 6
        Me.grbcustdetails.TabStop = False
        Me.grbcustdetails.Text = "Customer Details"
        '
        'txtphno
        '
        Me.txtphno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtphno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphno.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtphno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphno.Location = New System.Drawing.Point(488, 95)
        Me.txtphno.Name = "txtphno"
        Me.txtphno.ReadOnly = True
        Me.txtphno.Size = New System.Drawing.Size(208, 27)
        Me.txtphno.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(376, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Phone number:"
        '
        'txtnationality
        '
        Me.txtnationality.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnationality.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtnationality.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnationality.Location = New System.Drawing.Point(141, 95)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.ReadOnly = True
        Me.txtnationality.Size = New System.Drawing.Size(208, 27)
        Me.txtnationality.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(488, 29)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(208, 60)
        Me.txtaddress.TabIndex = 6
        '
        'txtcustname
        '
        Me.txtcustname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustname.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtcustname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(141, 62)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(208, 27)
        Me.txtcustname.TabIndex = 5
        '
        'txtcustid
        '
        Me.txtcustid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustid.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtcustid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustid.Location = New System.Drawing.Point(141, 29)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.ReadOnly = True
        Me.txtcustid.Size = New System.Drawing.Size(208, 27)
        Me.txtcustid.TabIndex = 4
        '
        'lblphno
        '
        Me.lblphno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblphno.AutoSize = True
        Me.lblphno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphno.ForeColor = System.Drawing.Color.White
        Me.lblphno.Location = New System.Drawing.Point(51, 97)
        Me.lblphno.Name = "lblphno"
        Me.lblphno.Size = New System.Drawing.Size(84, 19)
        Me.lblphno.TabIndex = 3
        Me.lblphno.Text = "Nationality:"
        '
        'lbladdress
        '
        Me.lbladdress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.White
        Me.lbladdress.Location = New System.Drawing.Point(417, 31)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(65, 19)
        Me.lbladdress.TabIndex = 2
        Me.lbladdress.Text = "Address:"
        '
        'lblcustname
        '
        Me.lblcustname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustname.AutoSize = True
        Me.lblcustname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustname.ForeColor = System.Drawing.Color.White
        Me.lblcustname.Location = New System.Drawing.Point(18, 66)
        Me.lblcustname.Name = "lblcustname"
        Me.lblcustname.Size = New System.Drawing.Size(117, 19)
        Me.lblcustname.TabIndex = 1
        Me.lblcustname.Text = "Customer Name:"
        '
        'lblcustid
        '
        Me.lblcustid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustid.AutoSize = True
        Me.lblcustid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustid.ForeColor = System.Drawing.Color.White
        Me.lblcustid.Location = New System.Drawing.Point(42, 31)
        Me.lblcustid.Name = "lblcustid"
        Me.lblcustid.Size = New System.Drawing.Size(93, 19)
        Me.lblcustid.TabIndex = 0
        Me.lblcustid.Text = "Customer ID:"
        '
        'lblsalesorderno
        '
        Me.lblsalesorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsalesorderno.AutoSize = True
        Me.lblsalesorderno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalesorderno.ForeColor = System.Drawing.Color.White
        Me.lblsalesorderno.Location = New System.Drawing.Point(263, 22)
        Me.lblsalesorderno.Name = "lblsalesorderno"
        Me.lblsalesorderno.Size = New System.Drawing.Size(110, 19)
        Me.lblsalesorderno.TabIndex = 7
        Me.lblsalesorderno.Text = "Sales Order No:"
        '
        'cmborderno
        '
        Me.cmborderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmborderno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmborderno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmborderno.FormattingEnabled = True
        Me.cmborderno.Location = New System.Drawing.Point(267, 44)
        Me.cmborderno.Name = "cmborderno"
        Me.cmborderno.Size = New System.Drawing.Size(235, 27)
        Me.cmborderno.TabIndex = 8
        '
        'btnsavebill
        '
        Me.btnsavebill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsavebill.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsavebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsavebill.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavebill.ForeColor = System.Drawing.Color.White
        Me.btnsavebill.Location = New System.Drawing.Point(594, 454)
        Me.btnsavebill.Name = "btnsavebill"
        Me.btnsavebill.Size = New System.Drawing.Size(149, 35)
        Me.btnsavebill.TabIndex = 1
        Me.btnsavebill.Text = "Print Bill"
        Me.btnsavebill.UseVisualStyleBackColor = False
        '
        'btnnewbill
        '
        Me.btnnewbill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnewbill.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnnewbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewbill.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewbill.ForeColor = System.Drawing.Color.White
        Me.btnnewbill.Location = New System.Drawing.Point(635, 30)
        Me.btnnewbill.Name = "btnnewbill"
        Me.btnnewbill.Size = New System.Drawing.Size(159, 35)
        Me.btnnewbill.TabIndex = 0
        Me.btnnewbill.Text = "New Bill"
        Me.btnnewbill.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SALES BILL"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView1.Location = New System.Drawing.Point(26, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(717, 131)
        Me.DataGridView1.TabIndex = 11
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.No
        Me.DataGridView2.Location = New System.Drawing.Point(26, 78)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowTemplate.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(717, 131)
        Me.DataGridView2.TabIndex = 12
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtbilldate)
        Me.GroupBox1.Controls.Add(Me.btnsavebill)
        Me.GroupBox1.Controls.Add(Me.lblsalesorderno)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.cmborderno)
        Me.GroupBox1.Controls.Add(Me.grbcustdetails)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.grbprice)
        Me.GroupBox1.Controls.Add(Me.lblbillno)
        Me.GroupBox1.Controls.Add(Me.txtbillno)
        Me.GroupBox1.Controls.Add(Me.lblbilldate)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(26, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 507)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtbilldate
        '
        Me.txtbilldate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbilldate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbilldate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtbilldate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbilldate.Location = New System.Drawing.Point(508, 44)
        Me.txtbilldate.Name = "txtbilldate"
        Me.txtbilldate.ReadOnly = True
        Me.txtbilldate.Size = New System.Drawing.Size(235, 27)
        Me.txtbilldate.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnnewbill)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(75, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(820, 603)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btnlckok)
        Me.Panel2.Location = New System.Drawing.Point(-8, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 242)
        Me.Panel2.TabIndex = 56
        Me.Panel2.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(986, 49)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "All sales bill generated or sales not ordered."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlckok
        '
        Me.btnlckok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlckok.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlckok.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnlckok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlckok.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlckok.ForeColor = System.Drawing.Color.White
        Me.btnlckok.Location = New System.Drawing.Point(420, 134)
        Me.btnlckok.Name = "btnlckok"
        Me.btnlckok.Size = New System.Drawing.Size(146, 49)
        Me.btnlckok.TabIndex = 1
        Me.btnlckok.Text = "OK"
        Me.btnlckok.UseVisualStyleBackColor = False
        '
        'salesbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "salesbill"
        Me.Text = "Sales Bill"
        Me.grbprice.ResumeLayout(False)
        Me.grbprice.PerformLayout()
        Me.grbcustdetails.ResumeLayout(False)
        Me.grbcustdetails.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblbillno As System.Windows.Forms.Label
    Friend WithEvents lblbilldate As System.Windows.Forms.Label
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents grbprice As System.Windows.Forms.GroupBox
    Friend WithEvents txtvat As System.Windows.Forms.TextBox
    Friend WithEvents lblvat As System.Windows.Forms.Label
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalamt As System.Windows.Forms.Label
    Friend WithEvents grbcustdetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblphno As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblcustname As System.Windows.Forms.Label
    Friend WithEvents lblcustid As System.Windows.Forms.Label
    Friend WithEvents lblsalesorderno As System.Windows.Forms.Label
    Friend WithEvents cmborderno As System.Windows.Forms.ComboBox
    Friend WithEvents txtnationality As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents btnsavebill As System.Windows.Forms.Button
    Friend WithEvents btnnewbill As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtphno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdisrs As System.Windows.Forms.TextBox
    Friend WithEvents txtvatrs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbilldate As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnlckok As System.Windows.Forms.Button
End Class
