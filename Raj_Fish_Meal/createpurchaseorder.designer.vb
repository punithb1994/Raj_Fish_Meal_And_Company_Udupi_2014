<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createpurchaseorder
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnneworder = New System.Windows.Forms.Button
        Me.msg = New System.Windows.Forms.Label
        Me.btncancelorder = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.btnedit = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbporoderno = New System.Windows.Forms.ComboBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnsave = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtslno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbtype = New System.Windows.Forms.ComboBox
        Me.cmbcategory = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtitemquantity = New System.Windows.Forms.TextBox
        Me.lblitemquantity = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtsphone = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtsmail = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtsadd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.supname = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnaddnew = New System.Windows.Forms.Button
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txtpurchaseorderno = New System.Windows.Forms.TextBox
        Me.lblorderdate = New System.Windows.Forms.Label
        Me.lblpurchaseorder = New System.Windows.Forms.Label
        Me.btnupdate = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnlckok = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnneworder)
        Me.GroupBox1.Controls.Add(Me.msg)
        Me.GroupBox1.Controls.Add(Me.btncancelorder)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(47, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 571)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnneworder
        '
        Me.btnneworder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnneworder.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnneworder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnneworder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnneworder.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnneworder.ForeColor = System.Drawing.Color.White
        Me.btnneworder.Location = New System.Drawing.Point(610, 18)
        Me.btnneworder.Name = "btnneworder"
        Me.btnneworder.Size = New System.Drawing.Size(155, 38)
        Me.btnneworder.TabIndex = 42
        Me.btnneworder.Text = "NEW ORDER"
        Me.btnneworder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnneworder.UseVisualStyleBackColor = False
        '
        'msg
        '
        Me.msg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.msg.AutoSize = True
        Me.msg.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg.ForeColor = System.Drawing.Color.Lime
        Me.msg.Location = New System.Drawing.Point(215, 514)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(0, 23)
        Me.msg.TabIndex = 41
        '
        'btncancelorder
        '
        Me.btncancelorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancelorder.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btncancelorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelorder.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelorder.ForeColor = System.Drawing.Color.White
        Me.btncancelorder.Location = New System.Drawing.Point(610, 505)
        Me.btncancelorder.Name = "btncancelorder"
        Me.btncancelorder.Size = New System.Drawing.Size(153, 40)
        Me.btncancelorder.TabIndex = 40
        Me.btncancelorder.Text = "Cancel order"
        Me.btncancelorder.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(58, 487)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Inventory Available"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.BackColor = System.Drawing.Color.DimGray
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(62, 509)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(132, 40)
        Me.TextBox6.TabIndex = 38
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnedit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(499, 505)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(105, 40)
        Me.btnedit.TabIndex = 22
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(18, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 39)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "CREATE PURCHASE ORDER"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.cmbporoderno)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Controls.Add(Me.btndel)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.btnaddnew)
        Me.GroupBox3.Controls.Add(Me.txtdate)
        Me.GroupBox3.Controls.Add(Me.txtpurchaseorderno)
        Me.GroupBox3.Controls.Add(Me.lblorderdate)
        Me.GroupBox3.Controls.Add(Me.lblpurchaseorder)
        Me.GroupBox3.Controls.Add(Me.btnupdate)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(740, 419)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'cmbporoderno
        '
        Me.cmbporoderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbporoderno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbporoderno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbporoderno.ForeColor = System.Drawing.Color.Black
        Me.cmbporoderno.FormattingEnabled = True
        Me.cmbporoderno.Location = New System.Drawing.Point(175, 33)
        Me.cmbporoderno.Name = "cmbporoderno"
        Me.cmbporoderno.Size = New System.Drawing.Size(201, 27)
        Me.cmbporoderno.TabIndex = 33
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(25, 314)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(691, 85)
        Me.DataGridView2.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView1.Location = New System.Drawing.Point(25, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(691, 85)
        Me.DataGridView1.TabIndex = 31
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(120, 268)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 31)
        Me.btnsave.TabIndex = 29
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(300, 268)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(80, 31)
        Me.btndel.TabIndex = 29
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.txtslno)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmbtype)
        Me.GroupBox4.Controls.Add(Me.cmbcategory)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtitemquantity)
        Me.GroupBox4.Controls.Add(Me.lblitemquantity)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox4.Location = New System.Drawing.Point(25, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(356, 181)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item Info"
        '
        'txtslno
        '
        Me.txtslno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtslno.BackColor = System.Drawing.SystemColors.Control
        Me.txtslno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtslno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtslno.ForeColor = System.Drawing.Color.Black
        Me.txtslno.Location = New System.Drawing.Point(133, 31)
        Me.txtslno.Name = "txtslno"
        Me.txtslno.ReadOnly = True
        Me.txtslno.Size = New System.Drawing.Size(201, 27)
        Me.txtslno.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Serial Number:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(84, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Type:"
        '
        'cmbtype
        '
        Me.cmbtype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbtype.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.ForeColor = System.Drawing.Color.Black
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Location = New System.Drawing.Point(133, 97)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(201, 27)
        Me.cmbtype.TabIndex = 32
        '
        'cmbcategory
        '
        Me.cmbcategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.ForeColor = System.Drawing.Color.Black
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Location = New System.Drawing.Point(133, 64)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(201, 27)
        Me.cmbcategory.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Name:"
        '
        'txtitemquantity
        '
        Me.txtitemquantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtitemquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitemquantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemquantity.ForeColor = System.Drawing.Color.Black
        Me.txtitemquantity.Location = New System.Drawing.Point(133, 130)
        Me.txtitemquantity.MaxLength = 5
        Me.txtitemquantity.Name = "txtitemquantity"
        Me.txtitemquantity.Size = New System.Drawing.Size(203, 27)
        Me.txtitemquantity.TabIndex = 29
        Me.txtitemquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblitemquantity
        '
        Me.lblitemquantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemquantity.AutoSize = True
        Me.lblitemquantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemquantity.ForeColor = System.Drawing.Color.White
        Me.lblitemquantity.Location = New System.Drawing.Point(58, 133)
        Me.lblitemquantity.Name = "lblitemquantity"
        Me.lblitemquantity.Size = New System.Drawing.Size(69, 19)
        Me.lblitemquantity.TabIndex = 28
        Me.lblitemquantity.Text = "Quantity:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txtsphone)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtsmail)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtsadd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.supname)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(400, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 226)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier Info"
        '
        'txtsphone
        '
        Me.txtsphone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsphone.BackColor = System.Drawing.SystemColors.Control
        Me.txtsphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsphone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsphone.ForeColor = System.Drawing.Color.Black
        Me.txtsphone.Location = New System.Drawing.Point(93, 176)
        Me.txtsphone.Name = "txtsphone"
        Me.txtsphone.ReadOnly = True
        Me.txtsphone.Size = New System.Drawing.Size(201, 27)
        Me.txtsphone.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(34, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Phone:"
        '
        'txtsmail
        '
        Me.txtsmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtsmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsmail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsmail.ForeColor = System.Drawing.Color.Black
        Me.txtsmail.Location = New System.Drawing.Point(93, 143)
        Me.txtsmail.Name = "txtsmail"
        Me.txtsmail.ReadOnly = True
        Me.txtsmail.Size = New System.Drawing.Size(201, 27)
        Me.txtsmail.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "E-Mail:"
        '
        'txtsadd
        '
        Me.txtsadd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsadd.BackColor = System.Drawing.SystemColors.Control
        Me.txtsadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsadd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsadd.ForeColor = System.Drawing.Color.Black
        Me.txtsadd.Location = New System.Drawing.Point(93, 66)
        Me.txtsadd.Multiline = True
        Me.txtsadd.Name = "txtsadd"
        Me.txtsadd.ReadOnly = True
        Me.txtsadd.Size = New System.Drawing.Size(201, 71)
        Me.txtsadd.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Address:"
        '
        'supname
        '
        Me.supname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.supname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supname.ForeColor = System.Drawing.Color.Black
        Me.supname.FormattingEnabled = True
        Me.supname.Location = New System.Drawing.Point(93, 33)
        Me.supname.Name = "supname"
        Me.supname.Size = New System.Drawing.Size(201, 27)
        Me.supname.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name:"
        '
        'btnaddnew
        '
        Me.btnaddnew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnaddnew.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddnew.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnew.Location = New System.Drawing.Point(26, 268)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(88, 31)
        Me.btnaddnew.TabIndex = 6
        Me.btnaddnew.Text = "Add New"
        Me.btnaddnew.UseVisualStyleBackColor = False
        '
        'txtdate
        '
        Me.txtdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdate.BackColor = System.Drawing.SystemColors.Control
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdate.Location = New System.Drawing.Point(505, 33)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(200, 27)
        Me.txtdate.TabIndex = 25
        '
        'txtpurchaseorderno
        '
        Me.txtpurchaseorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpurchaseorderno.BackColor = System.Drawing.Color.White
        Me.txtpurchaseorderno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpurchaseorderno.Location = New System.Drawing.Point(175, 33)
        Me.txtpurchaseorderno.Name = "txtpurchaseorderno"
        Me.txtpurchaseorderno.ReadOnly = True
        Me.txtpurchaseorderno.Size = New System.Drawing.Size(200, 27)
        Me.txtpurchaseorderno.TabIndex = 6
        '
        'lblorderdate
        '
        Me.lblorderdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblorderdate.AutoSize = True
        Me.lblorderdate.Location = New System.Drawing.Point(414, 36)
        Me.lblorderdate.Name = "lblorderdate"
        Me.lblorderdate.Size = New System.Drawing.Size(85, 19)
        Me.lblorderdate.TabIndex = 2
        Me.lblorderdate.Text = "Order Date:"
        '
        'lblpurchaseorder
        '
        Me.lblpurchaseorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblpurchaseorder.AutoSize = True
        Me.lblpurchaseorder.Location = New System.Drawing.Point(36, 36)
        Me.lblpurchaseorder.Name = "lblpurchaseorder"
        Me.lblpurchaseorder.Size = New System.Drawing.Size(133, 19)
        Me.lblpurchaseorder.TabIndex = 0
        Me.lblpurchaseorder.Text = "Purchase Order no:"
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(206, 268)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(88, 31)
        Me.btnupdate.TabIndex = 30
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnlckok)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-8, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 214)
        Me.Panel1.TabIndex = 31
        Me.Panel1.Visible = False
        '
        'btnlckok
        '
        Me.btnlckok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlckok.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlckok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlckok.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlckok.ForeColor = System.Drawing.Color.White
        Me.btnlckok.Location = New System.Drawing.Point(373, 116)
        Me.btnlckok.Name = "btnlckok"
        Me.btnlckok.Size = New System.Drawing.Size(152, 53)
        Me.btnlckok.TabIndex = 2
        Me.btnlckok.Text = "OK"
        Me.btnlckok.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-1, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(900, 45)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "No purchase order to edit"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createpurchaseorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "createpurchaseorder"
        Me.Text = "Create Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnaddnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpurchaseorderno As System.Windows.Forms.TextBox
    Friend WithEvents lblorderdate As System.Windows.Forms.Label
    Friend WithEvents lblpurchaseorder As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents supname As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsphone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsadd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtslno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtitemquantity As System.Windows.Forms.TextBox
    Friend WithEvents lblitemquantity As System.Windows.Forms.Label
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btncancelorder As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents msg As System.Windows.Forms.Label
    Friend WithEvents cmbporoderno As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnneworder As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnlckok As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
