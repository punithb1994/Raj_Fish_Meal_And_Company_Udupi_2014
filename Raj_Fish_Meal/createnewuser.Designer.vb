<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createnewuser
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.empimage = New System.Windows.Forms.PictureBox
        Me.txtrpassword = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtdept = New System.Windows.Forms.TextBox
        Me.txtusertype = New System.Windows.Forms.TextBox
        Me.empname = New System.Windows.Forms.TextBox
        Me.cmbempid = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btncreateuser = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnlckok = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.empimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.empimage)
        Me.GroupBox2.Controls.Add(Me.txtrpassword)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.txtdept)
        Me.GroupBox2.Controls.Add(Me.txtusertype)
        Me.GroupBox2.Controls.Add(Me.empname)
        Me.GroupBox2.Controls.Add(Me.cmbempid)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 227)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'empimage
        '
        Me.empimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.empimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empimage.Image = Global.Raj_Fish_Meal.My.Resources.Resources.guest
        Me.empimage.Location = New System.Drawing.Point(412, 24)
        Me.empimage.Name = "empimage"
        Me.empimage.Size = New System.Drawing.Size(189, 189)
        Me.empimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.empimage.TabIndex = 12
        Me.empimage.TabStop = False
        '
        'txtrpassword
        '
        Me.txtrpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrpassword.Location = New System.Drawing.Point(163, 189)
        Me.txtrpassword.Name = "txtrpassword"
        Me.txtrpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtrpassword.Size = New System.Drawing.Size(208, 27)
        Me.txtrpassword.TabIndex = 11
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpassword.Location = New System.Drawing.Point(163, 156)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtpassword.Size = New System.Drawing.Size(208, 27)
        Me.txtpassword.TabIndex = 10
        '
        'txtdept
        '
        Me.txtdept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdept.Location = New System.Drawing.Point(163, 123)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.ReadOnly = True
        Me.txtdept.Size = New System.Drawing.Size(208, 27)
        Me.txtdept.TabIndex = 9
        '
        'txtusertype
        '
        Me.txtusertype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusertype.Location = New System.Drawing.Point(163, 90)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.ReadOnly = True
        Me.txtusertype.Size = New System.Drawing.Size(208, 27)
        Me.txtusertype.TabIndex = 8
        '
        'empname
        '
        Me.empname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empname.Location = New System.Drawing.Point(163, 57)
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Size = New System.Drawing.Size(208, 27)
        Me.empname.TabIndex = 7
        '
        'cmbempid
        '
        Me.cmbempid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbempid.FormattingEnabled = True
        Me.cmbempid.Location = New System.Drawing.Point(163, 24)
        Me.cmbempid.Name = "cmbempid"
        Me.cmbempid.Size = New System.Drawing.Size(208, 27)
        Me.cmbempid.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(33, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Retype Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Type Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(67, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(72, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Employee ID:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Raj_Fish_Meal.My.Resources.Resources.accept_button
        Me.PictureBox2.Location = New System.Drawing.Point(375, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Raj_Fish_Meal.My.Resources.Resources.delete_button
        Me.PictureBox1.Location = New System.Drawing.Point(375, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btncreateuser
        '
        Me.btncreateuser.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btncreateuser.Enabled = False
        Me.btncreateuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreateuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreateuser.ForeColor = System.Drawing.Color.White
        Me.btncreateuser.Location = New System.Drawing.Point(506, 292)
        Me.btncreateuser.Name = "btncreateuser"
        Me.btncreateuser.Size = New System.Drawing.Size(138, 37)
        Me.btncreateuser.TabIndex = 15
        Me.btncreateuser.Text = "Create User"
        Me.btncreateuser.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(15, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 39)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "CREATE NEW USER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btncreateuser)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-8, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 214)
        Me.Panel1.TabIndex = 30
        Me.Panel1.Visible = False
        '
        'btnlckok
        '
        Me.btnlckok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlckok.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlckok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlckok.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlckok.ForeColor = System.Drawing.Color.White
        Me.btnlckok.Location = New System.Drawing.Point(370, 116)
        Me.btnlckok.Name = "btnlckok"
        Me.btnlckok.Size = New System.Drawing.Size(152, 53)
        Me.btnlckok.TabIndex = 2
        Me.btnlckok.Text = "OK"
        Me.btnlckok.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-1, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(894, 45)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "All the employees have been assigned login ID."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createnewuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "createnewuser"
        Me.Text = "Create new user"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.empimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btncreateuser As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents empimage As System.Windows.Forms.PictureBox
    Friend WithEvents txtrpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
    Friend WithEvents empname As System.Windows.Forms.TextBox
    Friend WithEvents cmbempid As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnlckok As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
