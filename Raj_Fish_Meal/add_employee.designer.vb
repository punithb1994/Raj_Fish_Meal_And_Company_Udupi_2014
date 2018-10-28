<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddemployee
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdnewemp = New System.Windows.Forms.Button
        Me.cmdsaveemp = New System.Windows.Forms.Button
        Me.grpnewemp = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblmobile = New System.Windows.Forms.Label
        Me.lbllandline = New System.Windows.Forms.Label
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.txtlandline = New System.Windows.Forms.TextBox
        Me.lblcontactno = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdbmale = New System.Windows.Forms.RadioButton
        Me.lblgender = New System.Windows.Forms.Label
        Me.rdbfemale = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbasic = New System.Windows.Forms.TextBox
        Me.txtqualification = New System.Windows.Forms.TextBox
        Me.lblqualification = New System.Windows.Forms.Label
        Me.cmdimgbrowse = New System.Windows.Forms.Button
        Me.cmbdesig1 = New System.Windows.Forms.ComboBox
        Me.cmbdesig2 = New System.Windows.Forms.ComboBox
        Me.lbldesig = New System.Windows.Forms.Label
        Me.lblemployeeimage = New System.Windows.Forms.Label
        Me.empimage = New System.Windows.Forms.PictureBox
        Me.DateTimePickerempdoj = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerempdob = New System.Windows.Forms.DateTimePicker
        Me.lblempdoj = New System.Windows.Forms.Label
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.lblemailid = New System.Windows.Forms.Label
        Me.txtemployeeid = New System.Windows.Forms.TextBox
        Me.txtempaddress = New System.Windows.Forms.TextBox
        Me.lblemployeeid = New System.Windows.Forms.Label
        Me.lblemployeename = New System.Windows.Forms.Label
        Me.txtemployeename = New System.Windows.Forms.TextBox
        Me.lblempdob = New System.Windows.Forms.Label
        Me.lblempaddress = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpnewemp.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.empimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdnewemp)
        Me.GroupBox1.Controls.Add(Me.cmdsaveemp)
        Me.GroupBox1.Controls.Add(Me.grpnewemp)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 594)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(20, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 39)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "ADD NEW EMPLOYEE"
        '
        'cmdnewemp
        '
        Me.cmdnewemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdnewemp.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdnewemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdnewemp.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnewemp.ForeColor = System.Drawing.Color.White
        Me.cmdnewemp.Location = New System.Drawing.Point(452, 531)
        Me.cmdnewemp.Name = "cmdnewemp"
        Me.cmdnewemp.Size = New System.Drawing.Size(135, 42)
        Me.cmdnewemp.TabIndex = 31
        Me.cmdnewemp.Text = "New"
        Me.cmdnewemp.UseVisualStyleBackColor = False
        '
        'cmdsaveemp
        '
        Me.cmdsaveemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdsaveemp.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdsaveemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsaveemp.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsaveemp.ForeColor = System.Drawing.Color.White
        Me.cmdsaveemp.Location = New System.Drawing.Point(593, 531)
        Me.cmdsaveemp.Name = "cmdsaveemp"
        Me.cmdsaveemp.Size = New System.Drawing.Size(135, 42)
        Me.cmdsaveemp.TabIndex = 32
        Me.cmdsaveemp.Text = "Save"
        Me.cmdsaveemp.UseVisualStyleBackColor = False
        '
        'grpnewemp
        '
        Me.grpnewemp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpnewemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grpnewemp.Controls.Add(Me.Panel2)
        Me.grpnewemp.Controls.Add(Me.Panel1)
        Me.grpnewemp.Controls.Add(Me.Label1)
        Me.grpnewemp.Controls.Add(Me.txtbasic)
        Me.grpnewemp.Controls.Add(Me.txtqualification)
        Me.grpnewemp.Controls.Add(Me.lblqualification)
        Me.grpnewemp.Controls.Add(Me.cmdimgbrowse)
        Me.grpnewemp.Controls.Add(Me.cmbdesig1)
        Me.grpnewemp.Controls.Add(Me.cmbdesig2)
        Me.grpnewemp.Controls.Add(Me.lbldesig)
        Me.grpnewemp.Controls.Add(Me.lblemployeeimage)
        Me.grpnewemp.Controls.Add(Me.empimage)
        Me.grpnewemp.Controls.Add(Me.DateTimePickerempdoj)
        Me.grpnewemp.Controls.Add(Me.DateTimePickerempdob)
        Me.grpnewemp.Controls.Add(Me.lblempdoj)
        Me.grpnewemp.Controls.Add(Me.txtemailid)
        Me.grpnewemp.Controls.Add(Me.lblemailid)
        Me.grpnewemp.Controls.Add(Me.txtemployeeid)
        Me.grpnewemp.Controls.Add(Me.txtempaddress)
        Me.grpnewemp.Controls.Add(Me.lblemployeeid)
        Me.grpnewemp.Controls.Add(Me.lblemployeename)
        Me.grpnewemp.Controls.Add(Me.txtemployeename)
        Me.grpnewemp.Controls.Add(Me.lblempdob)
        Me.grpnewemp.Controls.Add(Me.lblempaddress)
        Me.grpnewemp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpnewemp.ForeColor = System.Drawing.Color.White
        Me.grpnewemp.Location = New System.Drawing.Point(24, 62)
        Me.grpnewemp.Name = "grpnewemp"
        Me.grpnewemp.Size = New System.Drawing.Size(701, 454)
        Me.grpnewemp.TabIndex = 29
        Me.grpnewemp.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblmobile)
        Me.Panel2.Controls.Add(Me.lbllandline)
        Me.Panel2.Controls.Add(Me.txtmobile)
        Me.Panel2.Controls.Add(Me.txtlandline)
        Me.Panel2.Controls.Add(Me.lblcontactno)
        Me.Panel2.Location = New System.Drawing.Point(445, 320)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 108)
        Me.Panel2.TabIndex = 35
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.Location = New System.Drawing.Point(18, 74)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(58, 19)
        Me.lblmobile.TabIndex = 31
        Me.lblmobile.Text = "Mobile:"
        '
        'lbllandline
        '
        Me.lbllandline.AutoSize = True
        Me.lbllandline.Location = New System.Drawing.Point(10, 41)
        Me.lbllandline.Name = "lbllandline"
        Me.lbllandline.Size = New System.Drawing.Size(68, 19)
        Me.lbllandline.TabIndex = 30
        Me.lbllandline.Text = "Landline:"
        '
        'txtmobile
        '
        Me.txtmobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmobile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtmobile.Location = New System.Drawing.Point(80, 71)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(138, 27)
        Me.txtmobile.TabIndex = 29
        '
        'txtlandline
        '
        Me.txtlandline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlandline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtlandline.Location = New System.Drawing.Point(80, 38)
        Me.txtlandline.Name = "txtlandline"
        Me.txtlandline.Size = New System.Drawing.Size(138, 27)
        Me.txtlandline.TabIndex = 28
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Location = New System.Drawing.Point(10, 10)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(118, 19)
        Me.lblcontactno.TabIndex = 27
        Me.lblcontactno.Text = "Contact Number:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rdbmale)
        Me.Panel1.Controls.Add(Me.lblgender)
        Me.Panel1.Controls.Add(Me.rdbfemale)
        Me.Panel1.Location = New System.Drawing.Point(445, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 30)
        Me.Panel1.TabIndex = 34
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.BackColor = System.Drawing.Color.Transparent
        Me.rdbmale.FlatAppearance.BorderSize = 0
        Me.rdbmale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.rdbmale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.rdbmale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbmale.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rdbmale.Location = New System.Drawing.Point(76, 3)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(59, 23)
        Me.rdbmale.TabIndex = 34
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "Male"
        Me.rdbmale.UseVisualStyleBackColor = False
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(10, 5)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(60, 19)
        Me.lblgender.TabIndex = 33
        Me.lblgender.Text = "Gender:"
        '
        'rdbfemale
        '
        Me.rdbfemale.AutoSize = True
        Me.rdbfemale.BackColor = System.Drawing.Color.Transparent
        Me.rdbfemale.FlatAppearance.BorderSize = 0
        Me.rdbfemale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.rdbfemale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.rdbfemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbfemale.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rdbfemale.Location = New System.Drawing.Point(142, 3)
        Me.rdbfemale.Name = "rdbfemale"
        Me.rdbfemale.Size = New System.Drawing.Size(73, 23)
        Me.rdbfemale.TabIndex = 35
        Me.rdbfemale.TabStop = True
        Me.rdbfemale.Text = "Female"
        Me.rdbfemale.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Basic Pay:"
        '
        'txtbasic
        '
        Me.txtbasic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtbasic.Location = New System.Drawing.Point(149, 401)
        Me.txtbasic.MaxLength = 6
        Me.txtbasic.Name = "txtbasic"
        Me.txtbasic.Size = New System.Drawing.Size(240, 27)
        Me.txtbasic.TabIndex = 33
        '
        'txtqualification
        '
        Me.txtqualification.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtqualification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqualification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtqualification.Location = New System.Drawing.Point(149, 247)
        Me.txtqualification.MaxLength = 50
        Me.txtqualification.Multiline = True
        Me.txtqualification.Name = "txtqualification"
        Me.txtqualification.Size = New System.Drawing.Size(240, 82)
        Me.txtqualification.TabIndex = 31
        '
        'lblqualification
        '
        Me.lblqualification.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblqualification.AutoSize = True
        Me.lblqualification.Location = New System.Drawing.Point(47, 250)
        Me.lblqualification.Name = "lblqualification"
        Me.lblqualification.Size = New System.Drawing.Size(96, 19)
        Me.lblqualification.TabIndex = 30
        Me.lblqualification.Text = "Qualification:"
        '
        'cmdimgbrowse
        '
        Me.cmdimgbrowse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdimgbrowse.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdimgbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdimgbrowse.Location = New System.Drawing.Point(445, 246)
        Me.cmdimgbrowse.Name = "cmdimgbrowse"
        Me.cmdimgbrowse.Size = New System.Drawing.Size(180, 32)
        Me.cmdimgbrowse.TabIndex = 2
        Me.cmdimgbrowse.Text = "Browse"
        Me.cmdimgbrowse.UseVisualStyleBackColor = False
        '
        'cmbdesig1
        '
        Me.cmbdesig1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbdesig1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbdesig1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmbdesig1.FormattingEnabled = True
        Me.cmbdesig1.Items.AddRange(New Object() {"Manager", "Staff"})
        Me.cmbdesig1.Location = New System.Drawing.Point(149, 368)
        Me.cmbdesig1.Name = "cmbdesig1"
        Me.cmbdesig1.Size = New System.Drawing.Size(117, 27)
        Me.cmbdesig1.TabIndex = 24
        '
        'cmbdesig2
        '
        Me.cmbdesig2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbdesig2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbdesig2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmbdesig2.FormattingEnabled = True
        Me.cmbdesig2.Items.AddRange(New Object() {"Purchase", "Store", "Sales"})
        Me.cmbdesig2.Location = New System.Drawing.Point(272, 368)
        Me.cmbdesig2.Name = "cmbdesig2"
        Me.cmbdesig2.Size = New System.Drawing.Size(117, 27)
        Me.cmbdesig2.TabIndex = 23
        '
        'lbldesig
        '
        Me.lbldesig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldesig.AutoSize = True
        Me.lbldesig.Location = New System.Drawing.Point(52, 371)
        Me.lbldesig.Name = "lbldesig"
        Me.lbldesig.Size = New System.Drawing.Size(91, 19)
        Me.lbldesig.TabIndex = 22
        Me.lbldesig.Text = "Designation:"
        '
        'lblemployeeimage
        '
        Me.lblemployeeimage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemployeeimage.AutoSize = True
        Me.lblemployeeimage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployeeimage.Location = New System.Drawing.Point(450, 28)
        Me.lblemployeeimage.Name = "lblemployeeimage"
        Me.lblemployeeimage.Size = New System.Drawing.Size(169, 26)
        Me.lblemployeeimage.TabIndex = 21
        Me.lblemployeeimage.Text = "EMPLOYEE IMAGE"
        '
        'empimage
        '
        Me.empimage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.empimage.BackColor = System.Drawing.SystemColors.Control
        Me.empimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.empimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empimage.Image = Global.Raj_Fish_Meal.My.Resources.Resources.guest
        Me.empimage.Location = New System.Drawing.Point(445, 60)
        Me.empimage.Name = "empimage"
        Me.empimage.Size = New System.Drawing.Size(180, 180)
        Me.empimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.empimage.TabIndex = 20
        Me.empimage.TabStop = False
        '
        'DateTimePickerempdoj
        '
        Me.DateTimePickerempdoj.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerempdoj.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerempdoj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerempdoj.Location = New System.Drawing.Point(149, 335)
        Me.DateTimePickerempdoj.Name = "DateTimePickerempdoj"
        Me.DateTimePickerempdoj.Size = New System.Drawing.Size(240, 27)
        Me.DateTimePickerempdoj.TabIndex = 15
        '
        'DateTimePickerempdob
        '
        Me.DateTimePickerempdob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerempdob.Checked = False
        Me.DateTimePickerempdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerempdob.Location = New System.Drawing.Point(149, 93)
        Me.DateTimePickerempdob.Name = "DateTimePickerempdob"
        Me.DateTimePickerempdob.Size = New System.Drawing.Size(240, 27)
        Me.DateTimePickerempdob.TabIndex = 14
        '
        'lblempdoj
        '
        Me.lblempdoj.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblempdoj.AutoSize = True
        Me.lblempdoj.Location = New System.Drawing.Point(30, 341)
        Me.lblempdoj.Name = "lblempdoj"
        Me.lblempdoj.Size = New System.Drawing.Size(113, 19)
        Me.lblempdoj.TabIndex = 6
        Me.lblempdoj.Text = "Date Of Joining:"
        '
        'txtemailid
        '
        Me.txtemailid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtemailid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemailid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtemailid.Location = New System.Drawing.Point(149, 214)
        Me.txtemailid.MaxLength = 50
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(240, 27)
        Me.txtemailid.TabIndex = 12
        '
        'lblemailid
        '
        Me.lblemailid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemailid.AutoSize = True
        Me.lblemailid.Location = New System.Drawing.Point(73, 217)
        Me.lblemailid.Name = "lblemailid"
        Me.lblemailid.Size = New System.Drawing.Size(70, 19)
        Me.lblemailid.TabIndex = 5
        Me.lblemailid.Text = "E-mail Id:"
        '
        'txtemployeeid
        '
        Me.txtemployeeid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtemployeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemployeeid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtemployeeid.Location = New System.Drawing.Point(149, 27)
        Me.txtemployeeid.Name = "txtemployeeid"
        Me.txtemployeeid.ReadOnly = True
        Me.txtemployeeid.Size = New System.Drawing.Size(240, 27)
        Me.txtemployeeid.TabIndex = 7
        '
        'txtempaddress
        '
        Me.txtempaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtempaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtempaddress.Location = New System.Drawing.Point(149, 126)
        Me.txtempaddress.MaxLength = 200
        Me.txtempaddress.Multiline = True
        Me.txtempaddress.Name = "txtempaddress"
        Me.txtempaddress.Size = New System.Drawing.Size(240, 82)
        Me.txtempaddress.TabIndex = 10
        '
        'lblemployeeid
        '
        Me.lblemployeeid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemployeeid.AutoSize = True
        Me.lblemployeeid.Location = New System.Drawing.Point(49, 30)
        Me.lblemployeeid.Name = "lblemployeeid"
        Me.lblemployeeid.Size = New System.Drawing.Size(94, 19)
        Me.lblemployeeid.TabIndex = 0
        Me.lblemployeeid.Text = "Employee ID:"
        '
        'lblemployeename
        '
        Me.lblemployeename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemployeename.AutoSize = True
        Me.lblemployeename.Location = New System.Drawing.Point(27, 63)
        Me.lblemployeename.Name = "lblemployeename"
        Me.lblemployeename.Size = New System.Drawing.Size(116, 19)
        Me.lblemployeename.TabIndex = 1
        Me.lblemployeename.Text = "Employee name:"
        '
        'txtemployeename
        '
        Me.txtemployeename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtemployeename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemployeename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtemployeename.Location = New System.Drawing.Point(149, 60)
        Me.txtemployeename.MaxLength = 25
        Me.txtemployeename.Name = "txtemployeename"
        Me.txtemployeename.Size = New System.Drawing.Size(240, 27)
        Me.txtemployeename.TabIndex = 8
        '
        'lblempdob
        '
        Me.lblempdob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblempdob.AutoSize = True
        Me.lblempdob.Location = New System.Drawing.Point(44, 99)
        Me.lblempdob.Name = "lblempdob"
        Me.lblempdob.Size = New System.Drawing.Size(99, 19)
        Me.lblempdob.TabIndex = 2
        Me.lblempdob.Text = "Date Of Birth:"
        '
        'lblempaddress
        '
        Me.lblempaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblempaddress.AutoSize = True
        Me.lblempaddress.Location = New System.Drawing.Point(78, 129)
        Me.lblempaddress.Name = "lblempaddress"
        Me.lblempaddress.Size = New System.Drawing.Size(65, 19)
        Me.lblempaddress.TabIndex = 3
        Me.lblempaddress.Text = "Address:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'frmaddemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 646)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmaddemployee"
        Me.Text = "Add new employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpnewemp.ResumeLayout(False)
        Me.grpnewemp.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.empimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdsaveemp As System.Windows.Forms.Button
    Friend WithEvents cmdnewemp As System.Windows.Forms.Button
    Friend WithEvents grpnewemp As System.Windows.Forms.GroupBox
    Friend WithEvents cmdimgbrowse As System.Windows.Forms.Button
    Friend WithEvents cmbdesig1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdesig2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbldesig As System.Windows.Forms.Label
    Friend WithEvents lblemployeeimage As System.Windows.Forms.Label
    Friend WithEvents empimage As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePickerempdoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerempdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblempdoj As System.Windows.Forms.Label
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents lblemailid As System.Windows.Forms.Label
    Friend WithEvents txtemployeeid As System.Windows.Forms.TextBox
    Friend WithEvents txtempaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblemployeeid As System.Windows.Forms.Label
    Friend WithEvents lblemployeename As System.Windows.Forms.Label
    Friend WithEvents txtemployeename As System.Windows.Forms.TextBox
    Friend WithEvents lblempdob As System.Windows.Forms.Label
    Friend WithEvents lblempaddress As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblqualification As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtqualification As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbasic As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdbmale As System.Windows.Forms.RadioButton
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents rdbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblmobile As System.Windows.Forms.Label
    Friend WithEvents lbllandline As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents txtlandline As System.Windows.Forms.TextBox
    Friend WithEvents lblcontactno As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
