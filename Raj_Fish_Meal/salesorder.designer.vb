<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesorder
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.textorderdate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcustomername = New System.Windows.Forms.TextBox
        Me.txtcustomerid = New System.Windows.Forms.TextBox
        Me.lblcustomerid = New System.Windows.Forms.Label
        Me.cmbselorderno = New System.Windows.Forms.ComboBox
        Me.lblselectorderno = New System.Windows.Forms.Label
        Me.datagridview1 = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnedit = New System.Windows.Forms.Button
        Me.btndisplay = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.cmbproductname = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Btnnew2 = New System.Windows.Forms.Button
        Me.btnsaveprod = New System.Windows.Forms.Button
        Me.txtprodqty = New System.Windows.Forms.TextBox
        Me.txtproductid = New System.Windows.Forms.TextBox
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblitemid = New System.Windows.Forms.Label
        Me.lblitemname = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtdateoforder = New System.Windows.Forms.TextBox
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.cmbcustid = New System.Windows.Forms.ComboBox
        Me.txtorderno = New System.Windows.Forms.TextBox
        Me.lblcustname = New System.Windows.Forms.Label
        Me.lblcustid = New System.Windows.Forms.Label
        Me.lbldateoforder = New System.Windows.Forms.Label
        Me.lblorderno = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnlckok = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 586)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(17, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 39)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SALES ORDER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Controls.Add(Me.btndisplay)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 500)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.textorderdate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtcustomername)
        Me.Panel1.Controls.Add(Me.txtcustomerid)
        Me.Panel1.Controls.Add(Me.lblcustomerid)
        Me.Panel1.Controls.Add(Me.cmbselorderno)
        Me.Panel1.Controls.Add(Me.lblselectorderno)
        Me.Panel1.Controls.Add(Me.datagridview1)
        Me.Panel1.Location = New System.Drawing.Point(24, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 167)
        Me.Panel1.TabIndex = 43
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView2.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView2.Location = New System.Drawing.Point(291, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(442, 126)
        Me.DataGridView2.TabIndex = 32
        '
        'textorderdate
        '
        Me.textorderdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textorderdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textorderdate.Enabled = False
        Me.textorderdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textorderdate.Location = New System.Drawing.Point(141, 118)
        Me.textorderdate.Name = "textorderdate"
        Me.textorderdate.Size = New System.Drawing.Size(144, 27)
        Me.textorderdate.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Order Date:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Customer Name:"
        '
        'txtcustomername
        '
        Me.txtcustomername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustomername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustomername.Enabled = False
        Me.txtcustomername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomername.Location = New System.Drawing.Point(141, 85)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(144, 27)
        Me.txtcustomername.TabIndex = 28
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustomerid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustomerid.Enabled = False
        Me.txtcustomerid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomerid.Location = New System.Drawing.Point(141, 52)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(144, 27)
        Me.txtcustomerid.TabIndex = 27
        '
        'lblcustomerid
        '
        Me.lblcustomerid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustomerid.AutoSize = True
        Me.lblcustomerid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomerid.ForeColor = System.Drawing.Color.White
        Me.lblcustomerid.Location = New System.Drawing.Point(43, 54)
        Me.lblcustomerid.Name = "lblcustomerid"
        Me.lblcustomerid.Size = New System.Drawing.Size(91, 19)
        Me.lblcustomerid.TabIndex = 26
        Me.lblcustomerid.Text = "Customer Id:"
        '
        'cmbselorderno
        '
        Me.cmbselorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbselorderno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbselorderno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbselorderno.FormattingEnabled = True
        Me.cmbselorderno.Location = New System.Drawing.Point(141, 19)
        Me.cmbselorderno.Name = "cmbselorderno"
        Me.cmbselorderno.Size = New System.Drawing.Size(144, 27)
        Me.cmbselorderno.TabIndex = 25
        '
        'lblselectorderno
        '
        Me.lblselectorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblselectorderno.AutoSize = True
        Me.lblselectorderno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectorderno.ForeColor = System.Drawing.Color.White
        Me.lblselectorderno.Location = New System.Drawing.Point(19, 22)
        Me.lblselectorderno.Name = "lblselectorderno"
        Me.lblselectorderno.Size = New System.Drawing.Size(115, 19)
        Me.lblselectorderno.TabIndex = 24
        Me.lblselectorderno.Text = "Select Order No:"
        '
        'datagridview1
        '
        Me.datagridview1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.datagridview1.BackgroundColor = System.Drawing.Color.DimGray
        Me.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview1.Cursor = System.Windows.Forms.Cursors.Default
        Me.datagridview1.GridColor = System.Drawing.Color.DimGray
        Me.datagridview1.Location = New System.Drawing.Point(291, 19)
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagridview1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.datagridview1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridview1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datagridview1.Size = New System.Drawing.Size(442, 126)
        Me.datagridview1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(20, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Visible = False
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnedit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(522, 258)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(124, 45)
        Me.btnedit.TabIndex = 42
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndisplay
        '
        Me.btndisplay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndisplay.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btndisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndisplay.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplay.ForeColor = System.Drawing.Color.White
        Me.btndisplay.Location = New System.Drawing.Point(652, 258)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(124, 45)
        Me.btndisplay.TabIndex = 12
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtprice)
        Me.GroupBox3.Controls.Add(Me.cmbproductname)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Btnnew2)
        Me.GroupBox3.Controls.Add(Me.btnsaveprod)
        Me.GroupBox3.Controls.Add(Me.txtprodqty)
        Me.GroupBox3.Controls.Add(Me.txtproductid)
        Me.GroupBox3.Controls.Add(Me.lblqty)
        Me.GroupBox3.Controls.Add(Me.lblitemid)
        Me.GroupBox3.Controls.Add(Me.lblitemname)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(409, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 230)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(314, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "KG"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Enabled = False
        Me.txtprice.Location = New System.Drawing.Point(132, 131)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(211, 27)
        Me.txtprice.TabIndex = 12
        '
        'cmbproductname
        '
        Me.cmbproductname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbproductname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbproductname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproductname.FormattingEnabled = True
        Me.cmbproductname.Location = New System.Drawing.Point(132, 32)
        Me.cmbproductname.Name = "cmbproductname"
        Me.cmbproductname.Size = New System.Drawing.Size(211, 27)
        Me.cmbproductname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(81, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Price:"
        '
        'Btnnew2
        '
        Me.Btnnew2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btnnew2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnnew2.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnew2.ForeColor = System.Drawing.Color.White
        Me.Btnnew2.Location = New System.Drawing.Point(28, 177)
        Me.Btnnew2.Name = "Btnnew2"
        Me.Btnnew2.Size = New System.Drawing.Size(152, 31)
        Me.Btnnew2.TabIndex = 10
        Me.Btnnew2.Text = "New"
        Me.Btnnew2.UseVisualStyleBackColor = False
        '
        'btnsaveprod
        '
        Me.btnsaveprod.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsaveprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsaveprod.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveprod.ForeColor = System.Drawing.Color.White
        Me.btnsaveprod.Location = New System.Drawing.Point(186, 177)
        Me.btnsaveprod.Name = "btnsaveprod"
        Me.btnsaveprod.Size = New System.Drawing.Size(157, 31)
        Me.btnsaveprod.TabIndex = 9
        Me.btnsaveprod.Text = "Save"
        Me.btnsaveprod.UseVisualStyleBackColor = False
        '
        'txtprodqty
        '
        Me.txtprodqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtprodqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprodqty.Location = New System.Drawing.Point(132, 98)
        Me.txtprodqty.MaxLength = 6
        Me.txtprodqty.Name = "txtprodqty"
        Me.txtprodqty.Size = New System.Drawing.Size(176, 27)
        Me.txtprodqty.TabIndex = 7
        '
        'txtproductid
        '
        Me.txtproductid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtproductid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproductid.Enabled = False
        Me.txtproductid.Location = New System.Drawing.Point(132, 65)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(211, 27)
        Me.txtproductid.TabIndex = 6
        '
        'lblqty
        '
        Me.lblqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblqty.AutoSize = True
        Me.lblqty.ForeColor = System.Drawing.Color.White
        Me.lblqty.Location = New System.Drawing.Point(57, 100)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(69, 19)
        Me.lblqty.TabIndex = 2
        Me.lblqty.Text = "Quantity:"
        '
        'lblitemid
        '
        Me.lblitemid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemid.AutoSize = True
        Me.lblitemid.ForeColor = System.Drawing.Color.White
        Me.lblitemid.Location = New System.Drawing.Point(27, 67)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(99, 19)
        Me.lblitemid.TabIndex = 1
        Me.lblitemid.Text = "Product Code:"
        '
        'lblitemname
        '
        Me.lblitemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemname.AutoSize = True
        Me.lblitemname.ForeColor = System.Drawing.Color.White
        Me.lblitemname.Location = New System.Drawing.Point(24, 35)
        Me.lblitemname.Name = "lblitemname"
        Me.lblitemname.Size = New System.Drawing.Size(102, 19)
        Me.lblitemname.TabIndex = 0
        Me.lblitemname.Text = "Product name:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.txtdateoforder)
        Me.GroupBox4.Controls.Add(Me.txtcustname)
        Me.GroupBox4.Controls.Add(Me.cmbcustid)
        Me.GroupBox4.Controls.Add(Me.txtorderno)
        Me.GroupBox4.Controls.Add(Me.lblcustname)
        Me.GroupBox4.Controls.Add(Me.lblcustid)
        Me.GroupBox4.Controls.Add(Me.lbldateoforder)
        Me.GroupBox4.Controls.Add(Me.lblorderno)
        Me.GroupBox4.Controls.Add(Me.btnsave)
        Me.GroupBox4.Controls.Add(Me.btnnew)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(24, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(379, 230)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'txtdateoforder
        '
        Me.txtdateoforder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdateoforder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdateoforder.Location = New System.Drawing.Point(144, 65)
        Me.txtdateoforder.Name = "txtdateoforder"
        Me.txtdateoforder.ReadOnly = True
        Me.txtdateoforder.Size = New System.Drawing.Size(211, 27)
        Me.txtdateoforder.TabIndex = 13
        '
        'txtcustname
        '
        Me.txtcustname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustname.Location = New System.Drawing.Point(144, 131)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(211, 27)
        Me.txtcustname.TabIndex = 7
        '
        'cmbcustid
        '
        Me.cmbcustid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbcustid.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbcustid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcustid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcustid.FormattingEnabled = True
        Me.cmbcustid.Location = New System.Drawing.Point(144, 98)
        Me.cmbcustid.Name = "cmbcustid"
        Me.cmbcustid.Size = New System.Drawing.Size(211, 27)
        Me.cmbcustid.Sorted = True
        Me.cmbcustid.TabIndex = 5
        '
        'txtorderno
        '
        Me.txtorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtorderno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorderno.Location = New System.Drawing.Point(144, 32)
        Me.txtorderno.Name = "txtorderno"
        Me.txtorderno.ReadOnly = True
        Me.txtorderno.Size = New System.Drawing.Size(211, 27)
        Me.txtorderno.TabIndex = 4
        '
        'lblcustname
        '
        Me.lblcustname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustname.AutoSize = True
        Me.lblcustname.ForeColor = System.Drawing.Color.White
        Me.lblcustname.Location = New System.Drawing.Point(22, 137)
        Me.lblcustname.Name = "lblcustname"
        Me.lblcustname.Size = New System.Drawing.Size(117, 19)
        Me.lblcustname.TabIndex = 3
        Me.lblcustname.Text = "Customer Name:"
        '
        'lblcustid
        '
        Me.lblcustid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustid.AutoSize = True
        Me.lblcustid.ForeColor = System.Drawing.Color.White
        Me.lblcustid.Location = New System.Drawing.Point(47, 103)
        Me.lblcustid.Name = "lblcustid"
        Me.lblcustid.Size = New System.Drawing.Size(91, 19)
        Me.lblcustid.TabIndex = 2
        Me.lblcustid.Text = "Customer Id:"
        '
        'lbldateoforder
        '
        Me.lbldateoforder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldateoforder.AutoSize = True
        Me.lbldateoforder.ForeColor = System.Drawing.Color.White
        Me.lbldateoforder.Location = New System.Drawing.Point(36, 70)
        Me.lbldateoforder.Name = "lbldateoforder"
        Me.lbldateoforder.Size = New System.Drawing.Size(102, 19)
        Me.lbldateoforder.TabIndex = 1
        Me.lbldateoforder.Text = "Date of Order:"
        '
        'lblorderno
        '
        Me.lblorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblorderno.AutoSize = True
        Me.lblorderno.ForeColor = System.Drawing.Color.White
        Me.lblorderno.Location = New System.Drawing.Point(65, 35)
        Me.lblorderno.Name = "lblorderno"
        Me.lblorderno.Size = New System.Drawing.Size(72, 19)
        Me.lblorderno.TabIndex = 0
        Me.lblorderno.Text = "Order No:"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(192, 177)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(163, 31)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnew.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(26, 177)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(160, 31)
        Me.btnnew.TabIndex = 10
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(942, 49)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "No sales order to display"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlckok
        '
        Me.btnlckok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlckok.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlckok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlckok.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlckok.ForeColor = System.Drawing.Color.White
        Me.btnlckok.Location = New System.Drawing.Point(383, 134)
        Me.btnlckok.Name = "btnlckok"
        Me.btnlckok.Size = New System.Drawing.Size(185, 57)
        Me.btnlckok.TabIndex = 1
        Me.btnlckok.Text = "OK"
        Me.btnlckok.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btnlckok)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(-8, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 249)
        Me.Panel2.TabIndex = 51
        Me.Panel2.Visible = False
        '
        'salesorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "salesorder"
        Me.Text = "Sales Order"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsaveprod As System.Windows.Forms.Button
    Friend WithEvents txtprodqty As System.Windows.Forms.TextBox
    Friend WithEvents txtproductid As System.Windows.Forms.TextBox
    Friend WithEvents cmbproductname As System.Windows.Forms.ComboBox
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblitemid As System.Windows.Forms.Label
    Friend WithEvents lblitemname As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents cmbcustid As System.Windows.Forms.ComboBox
    Friend WithEvents txtorderno As System.Windows.Forms.TextBox
    Friend WithEvents lblcustname As System.Windows.Forms.Label
    Friend WithEvents lblcustid As System.Windows.Forms.Label
    Friend WithEvents lbldateoforder As System.Windows.Forms.Label
    Friend WithEvents lblorderno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btnnew2 As System.Windows.Forms.Button
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtdateoforder As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents textorderdate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcustomername As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents lblcustomerid As System.Windows.Forms.Label
    Friend WithEvents cmbselorderno As System.Windows.Forms.ComboBox
    Friend WithEvents lblselectorderno As System.Windows.Forms.Label
    Friend WithEvents datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnlckok As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
