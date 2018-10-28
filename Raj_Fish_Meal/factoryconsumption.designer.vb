<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class factoryconsumption
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txtempname = New System.Windows.Forms.TextBox
        Me.lblemployeename = New System.Windows.Forms.Label
        Me.cmbemployeeid = New System.Windows.Forms.ComboBox
        Me.txtquantity = New System.Windows.Forms.TextBox
        Me.cmbitemtype = New System.Windows.Forms.ComboBox
        Me.cmbitemname = New System.Windows.Forms.ComboBox
        Me.lblemployeeid = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblitemquantity = New System.Windows.Forms.Label
        Me.lblitemtype = New System.Windows.Forms.Label
        Me.lblitemname = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(62, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 420)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.Highlight
        Me.LinkLabel1.Location = New System.Drawing.Point(688, 22)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 19)
        Me.LinkLabel1.TabIndex = 37
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add new category"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DimGray
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(20, 351)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(172, 47)
        Me.TextBox2.TabIndex = 36
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(20, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Inventory Available:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 39)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "FACTORY CONSUMPTION"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(651, 354)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(162, 44)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtdate)
        Me.GroupBox3.Controls.Add(Me.txtempname)
        Me.GroupBox3.Controls.Add(Me.lblemployeename)
        Me.GroupBox3.Controls.Add(Me.cmbemployeeid)
        Me.GroupBox3.Controls.Add(Me.txtquantity)
        Me.GroupBox3.Controls.Add(Me.cmbitemtype)
        Me.GroupBox3.Controls.Add(Me.cmbitemname)
        Me.GroupBox3.Controls.Add(Me.lblemployeeid)
        Me.GroupBox3.Controls.Add(Me.lbldate)
        Me.GroupBox3.Controls.Add(Me.lblitemquantity)
        Me.GroupBox3.Controls.Add(Me.lblitemtype)
        Me.GroupBox3.Controls.Add(Me.lblitemname)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 251)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'txtdate
        '
        Me.txtdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdate.Location = New System.Drawing.Point(136, 134)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(182, 27)
        Me.txtdate.TabIndex = 13
        '
        'txtempname
        '
        Me.txtempname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtempname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempname.Location = New System.Drawing.Point(136, 200)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.ReadOnly = True
        Me.txtempname.Size = New System.Drawing.Size(182, 27)
        Me.txtempname.TabIndex = 12
        '
        'lblemployeename
        '
        Me.lblemployeename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemployeename.AutoSize = True
        Me.lblemployeename.ForeColor = System.Drawing.Color.White
        Me.lblemployeename.Location = New System.Drawing.Point(16, 203)
        Me.lblemployeename.Name = "lblemployeename"
        Me.lblemployeename.Size = New System.Drawing.Size(118, 19)
        Me.lblemployeename.TabIndex = 11
        Me.lblemployeename.Text = "Employee Name:"
        '
        'cmbemployeeid
        '
        Me.cmbemployeeid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbemployeeid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbemployeeid.FormattingEnabled = True
        Me.cmbemployeeid.Location = New System.Drawing.Point(136, 167)
        Me.cmbemployeeid.Name = "cmbemployeeid"
        Me.cmbemployeeid.Size = New System.Drawing.Size(182, 27)
        Me.cmbemployeeid.TabIndex = 10
        '
        'txtquantity
        '
        Me.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquantity.Location = New System.Drawing.Point(136, 101)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(182, 27)
        Me.txtquantity.TabIndex = 8
        '
        'cmbitemtype
        '
        Me.cmbitemtype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbitemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbitemtype.FormattingEnabled = True
        Me.cmbitemtype.Location = New System.Drawing.Point(136, 68)
        Me.cmbitemtype.Name = "cmbitemtype"
        Me.cmbitemtype.Size = New System.Drawing.Size(182, 27)
        Me.cmbitemtype.TabIndex = 6
        '
        'cmbitemname
        '
        Me.cmbitemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbitemname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbitemname.FormattingEnabled = True
        Me.cmbitemname.Location = New System.Drawing.Point(136, 35)
        Me.cmbitemname.Name = "cmbitemname"
        Me.cmbitemname.Size = New System.Drawing.Size(182, 27)
        Me.cmbitemname.TabIndex = 5
        '
        'lblemployeeid
        '
        Me.lblemployeeid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemployeeid.AutoSize = True
        Me.lblemployeeid.ForeColor = System.Drawing.Color.White
        Me.lblemployeeid.Location = New System.Drawing.Point(42, 170)
        Me.lblemployeeid.Name = "lblemployeeid"
        Me.lblemployeeid.Size = New System.Drawing.Size(92, 19)
        Me.lblemployeeid.TabIndex = 4
        Me.lblemployeeid.Text = "Employee Id:"
        '
        'lbldate
        '
        Me.lbldate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldate.AutoSize = True
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(90, 134)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(44, 19)
        Me.lbldate.TabIndex = 3
        Me.lbldate.Text = "Date:"
        '
        'lblitemquantity
        '
        Me.lblitemquantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemquantity.AutoSize = True
        Me.lblitemquantity.ForeColor = System.Drawing.Color.White
        Me.lblitemquantity.Location = New System.Drawing.Point(65, 104)
        Me.lblitemquantity.Name = "lblitemquantity"
        Me.lblitemquantity.Size = New System.Drawing.Size(69, 19)
        Me.lblitemquantity.TabIndex = 2
        Me.lblitemquantity.Text = "Quantity:"
        '
        'lblitemtype
        '
        Me.lblitemtype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemtype.AutoSize = True
        Me.lblitemtype.ForeColor = System.Drawing.Color.White
        Me.lblitemtype.Location = New System.Drawing.Point(58, 71)
        Me.lblitemtype.Name = "lblitemtype"
        Me.lblitemtype.Size = New System.Drawing.Size(76, 19)
        Me.lblitemtype.TabIndex = 1
        Me.lblitemtype.Text = "Item Type:"
        '
        'lblitemname
        '
        Me.lblitemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemname.AutoSize = True
        Me.lblitemname.ForeColor = System.Drawing.Color.White
        Me.lblitemname.Location = New System.Drawing.Point(50, 38)
        Me.lblitemname.Name = "lblitemname"
        Me.lblitemname.Size = New System.Drawing.Size(84, 19)
        Me.lblitemname.TabIndex = 0
        Me.lblitemname.Text = "Item Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView1.Location = New System.Drawing.Point(371, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.Size = New System.Drawing.Size(442, 241)
        Me.DataGridView1.TabIndex = 5
        '
        'Timer1
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'factoryconsumption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "factoryconsumption"
        Me.Text = "Factory Consumption"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtempname As System.Windows.Forms.TextBox
    Friend WithEvents lblemployeename As System.Windows.Forms.Label
    Friend WithEvents cmbemployeeid As System.Windows.Forms.ComboBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbitemtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbitemname As System.Windows.Forms.ComboBox
    Friend WithEvents lblemployeeid As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblitemquantity As System.Windows.Forms.Label
    Friend WithEvents lblitemtype As System.Windows.Forms.Label
    Friend WithEvents lblitemname As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
