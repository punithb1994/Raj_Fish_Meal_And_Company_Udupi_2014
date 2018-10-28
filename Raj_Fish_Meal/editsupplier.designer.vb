<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editsupplier
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
        Me.cmbsupplierid = New System.Windows.Forms.ComboBox
        Me.txtsupplieremailid = New System.Windows.Forms.TextBox
        Me.txtsupplierphoneno = New System.Windows.Forms.TextBox
        Me.txtsupplieraddress = New System.Windows.Forms.TextBox
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.lblsupplieremailid = New System.Windows.Forms.Label
        Me.lblsuppliercontactno = New System.Windows.Forms.Label
        Me.lblsupplieraddress = New System.Windows.Forms.Label
        Me.lblsuppliername = New System.Windows.Forms.Label
        Me.lblsupplierid = New System.Windows.Forms.Label
        Me.btnupdate = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtneftcode = New System.Windows.Forms.TextBox
        Me.txtsuppifsccode = New System.Windows.Forms.TextBox
        Me.txtsuppbankbranch = New System.Windows.Forms.TextBox
        Me.txtsuppaccno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cmbsupplierid)
        Me.GroupBox1.Controls.Add(Me.txtsupplieremailid)
        Me.GroupBox1.Controls.Add(Me.txtsupplierphoneno)
        Me.GroupBox1.Controls.Add(Me.txtsupplieraddress)
        Me.GroupBox1.Controls.Add(Me.txtsname)
        Me.GroupBox1.Controls.Add(Me.lblsupplieremailid)
        Me.GroupBox1.Controls.Add(Me.lblsuppliercontactno)
        Me.GroupBox1.Controls.Add(Me.lblsupplieraddress)
        Me.GroupBox1.Controls.Add(Me.lblsuppliername)
        Me.GroupBox1.Controls.Add(Me.lblsupplierid)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(19, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 252)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Info"
        '
        'cmbsupplierid
        '
        Me.cmbsupplierid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbsupplierid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsupplierid.ForeColor = System.Drawing.Color.Black
        Me.cmbsupplierid.FormattingEnabled = True
        Me.cmbsupplierid.Location = New System.Drawing.Point(113, 31)
        Me.cmbsupplierid.Name = "cmbsupplierid"
        Me.cmbsupplierid.Size = New System.Drawing.Size(195, 27)
        Me.cmbsupplierid.TabIndex = 14
        '
        'txtsupplieremailid
        '
        Me.txtsupplieremailid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsupplieremailid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsupplieremailid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplieremailid.ForeColor = System.Drawing.Color.Black
        Me.txtsupplieremailid.Location = New System.Drawing.Point(113, 204)
        Me.txtsupplieremailid.MaxLength = 50
        Me.txtsupplieremailid.Name = "txtsupplieremailid"
        Me.txtsupplieremailid.Size = New System.Drawing.Size(196, 27)
        Me.txtsupplieremailid.TabIndex = 13
        '
        'txtsupplierphoneno
        '
        Me.txtsupplierphoneno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsupplierphoneno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsupplierphoneno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplierphoneno.ForeColor = System.Drawing.Color.Black
        Me.txtsupplierphoneno.Location = New System.Drawing.Point(113, 171)
        Me.txtsupplierphoneno.MaxLength = 11
        Me.txtsupplierphoneno.Name = "txtsupplierphoneno"
        Me.txtsupplierphoneno.Size = New System.Drawing.Size(196, 27)
        Me.txtsupplierphoneno.TabIndex = 12
        '
        'txtsupplieraddress
        '
        Me.txtsupplieraddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsupplieraddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsupplieraddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplieraddress.ForeColor = System.Drawing.Color.Black
        Me.txtsupplieraddress.Location = New System.Drawing.Point(113, 97)
        Me.txtsupplieraddress.MaxLength = 200
        Me.txtsupplieraddress.Multiline = True
        Me.txtsupplieraddress.Name = "txtsupplieraddress"
        Me.txtsupplieraddress.Size = New System.Drawing.Size(196, 68)
        Me.txtsupplieraddress.TabIndex = 11
        '
        'txtsname
        '
        Me.txtsname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.ForeColor = System.Drawing.Color.Black
        Me.txtsname.Location = New System.Drawing.Point(112, 64)
        Me.txtsname.MaxLength = 25
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(196, 27)
        Me.txtsname.TabIndex = 8
        '
        'lblsupplieremailid
        '
        Me.lblsupplieremailid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsupplieremailid.AutoSize = True
        Me.lblsupplieremailid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplieremailid.ForeColor = System.Drawing.Color.White
        Me.lblsupplieremailid.Location = New System.Drawing.Point(37, 207)
        Me.lblsupplieremailid.Name = "lblsupplieremailid"
        Me.lblsupplieremailid.Size = New System.Drawing.Size(69, 19)
        Me.lblsupplieremailid.TabIndex = 6
        Me.lblsupplieremailid.Text = "Email_Id:"
        '
        'lblsuppliercontactno
        '
        Me.lblsuppliercontactno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsuppliercontactno.AutoSize = True
        Me.lblsuppliercontactno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppliercontactno.ForeColor = System.Drawing.Color.White
        Me.lblsuppliercontactno.Location = New System.Drawing.Point(26, 174)
        Me.lblsuppliercontactno.Name = "lblsuppliercontactno"
        Me.lblsuppliercontactno.Size = New System.Drawing.Size(85, 19)
        Me.lblsuppliercontactno.TabIndex = 5
        Me.lblsuppliercontactno.Text = "Contact No:"
        '
        'lblsupplieraddress
        '
        Me.lblsupplieraddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsupplieraddress.AutoSize = True
        Me.lblsupplieraddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplieraddress.ForeColor = System.Drawing.Color.White
        Me.lblsupplieraddress.Location = New System.Drawing.Point(42, 100)
        Me.lblsupplieraddress.Name = "lblsupplieraddress"
        Me.lblsupplieraddress.Size = New System.Drawing.Size(65, 19)
        Me.lblsupplieraddress.TabIndex = 4
        Me.lblsupplieraddress.Text = "Address:"
        '
        'lblsuppliername
        '
        Me.lblsuppliername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsuppliername.AutoSize = True
        Me.lblsuppliername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppliername.ForeColor = System.Drawing.Color.White
        Me.lblsuppliername.Location = New System.Drawing.Point(50, 67)
        Me.lblsuppliername.Name = "lblsuppliername"
        Me.lblsuppliername.Size = New System.Drawing.Size(56, 19)
        Me.lblsuppliername.TabIndex = 1
        Me.lblsuppliername.Text = "Sname:"
        '
        'lblsupplierid
        '
        Me.lblsupplierid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsupplierid.AutoSize = True
        Me.lblsupplierid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplierid.ForeColor = System.Drawing.Color.White
        Me.lblsupplierid.Location = New System.Drawing.Point(25, 34)
        Me.lblsupplierid.Name = "lblsupplierid"
        Me.lblsupplierid.Size = New System.Drawing.Size(81, 19)
        Me.lblsupplierid.TabIndex = 0
        Me.lblsupplierid.Text = "Supplier Id:"
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(626, 274)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(101, 41)
        Me.btnupdate.TabIndex = 0
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnupdate)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 335)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(369, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 19)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Details Updated successfully..."
        Me.Label3.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtneftcode)
        Me.GroupBox3.Controls.Add(Me.txtsuppifsccode)
        Me.GroupBox3.Controls.Add(Me.txtsuppbankbranch)
        Me.GroupBox3.Controls.Add(Me.txtsuppaccno)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(360, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 185)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bank Info"
        '
        'txtneftcode
        '
        Me.txtneftcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtneftcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtneftcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtneftcode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtneftcode.ForeColor = System.Drawing.Color.Black
        Me.txtneftcode.Location = New System.Drawing.Point(148, 132)
        Me.txtneftcode.MaxLength = 15
        Me.txtneftcode.Name = "txtneftcode"
        Me.txtneftcode.Size = New System.Drawing.Size(196, 27)
        Me.txtneftcode.TabIndex = 13
        '
        'txtsuppifsccode
        '
        Me.txtsuppifsccode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsuppifsccode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsuppifsccode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsuppifsccode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuppifsccode.ForeColor = System.Drawing.Color.Black
        Me.txtsuppifsccode.Location = New System.Drawing.Point(148, 99)
        Me.txtsuppifsccode.MaxLength = 11
        Me.txtsuppifsccode.Name = "txtsuppifsccode"
        Me.txtsuppifsccode.Size = New System.Drawing.Size(196, 27)
        Me.txtsuppifsccode.TabIndex = 12
        '
        'txtsuppbankbranch
        '
        Me.txtsuppbankbranch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsuppbankbranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsuppbankbranch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuppbankbranch.ForeColor = System.Drawing.Color.Black
        Me.txtsuppbankbranch.Location = New System.Drawing.Point(148, 66)
        Me.txtsuppbankbranch.MaxLength = 30
        Me.txtsuppbankbranch.Name = "txtsuppbankbranch"
        Me.txtsuppbankbranch.Size = New System.Drawing.Size(196, 27)
        Me.txtsuppbankbranch.TabIndex = 8
        '
        'txtsuppaccno
        '
        Me.txtsuppaccno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsuppaccno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsuppaccno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuppaccno.ForeColor = System.Drawing.Color.Black
        Me.txtsuppaccno.Location = New System.Drawing.Point(149, 33)
        Me.txtsuppaccno.MaxLength = 25
        Me.txtsuppaccno.Name = "txtsuppaccno"
        Me.txtsuppaccno.Size = New System.Drawing.Size(196, 27)
        Me.txtsuppaccno.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NEFT Code:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "IFSC Code:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(84, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Branch:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Account Number:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(12, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 39)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "EDIT NEW SUPPLIER"
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
        'editsupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "editsupplier"
        Me.Text = "Edit Supplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsupplieraddress As System.Windows.Forms.TextBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents lblsupplieremailid As System.Windows.Forms.Label
    Friend WithEvents lblsuppliercontactno As System.Windows.Forms.Label
    Friend WithEvents lblsupplieraddress As System.Windows.Forms.Label
    Friend WithEvents lblsuppliername As System.Windows.Forms.Label
    Friend WithEvents lblsupplierid As System.Windows.Forms.Label
    Friend WithEvents txtsupplieremailid As System.Windows.Forms.TextBox
    Friend WithEvents txtsupplierphoneno As System.Windows.Forms.TextBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbsupplierid As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtneftcode As System.Windows.Forms.TextBox
    Friend WithEvents txtsuppifsccode As System.Windows.Forms.TextBox
    Friend WithEvents txtsuppbankbranch As System.Windows.Forms.TextBox
    Friend WithEvents txtsuppaccno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
