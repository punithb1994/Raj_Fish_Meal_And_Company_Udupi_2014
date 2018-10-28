<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unlockuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(unlockuser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtrpassword = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.empimage = New System.Windows.Forms.PictureBox
        Me.txtdept = New System.Windows.Forms.TextBox
        Me.txtusertype = New System.Windows.Forms.TextBox
        Me.empname = New System.Windows.Forms.TextBox
        Me.cmbempid = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnunlock = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnlckok = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnunlock)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtrpassword)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.empimage)
        Me.GroupBox2.Controls.Add(Me.txtdept)
        Me.GroupBox2.Controls.Add(Me.txtusertype)
        Me.GroupBox2.Controls.Add(Me.empname)
        Me.GroupBox2.Controls.Add(Me.cmbempid)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(613, 252)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(365, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'txtrpassword
        '
        Me.txtrpassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtrpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrpassword.Location = New System.Drawing.Point(166, 200)
        Me.txtrpassword.Name = "txtrpassword"
        Me.txtrpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtrpassword.Size = New System.Drawing.Size(193, 27)
        Me.txtrpassword.TabIndex = 25
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpassword.Location = New System.Drawing.Point(166, 167)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtpassword.Size = New System.Drawing.Size(193, 27)
        Me.txtpassword.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Re-Enter Password:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(52, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "New Password:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(365, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'empimage
        '
        Me.empimage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.empimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empimage.Image = Global.Raj_Fish_Meal.My.Resources.Resources.guest
        Me.empimage.Location = New System.Drawing.Point(397, 35)
        Me.empimage.Name = "empimage"
        Me.empimage.Size = New System.Drawing.Size(192, 192)
        Me.empimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.empimage.TabIndex = 21
        Me.empimage.TabStop = False
        '
        'txtdept
        '
        Me.txtdept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtdept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdept.Location = New System.Drawing.Point(166, 134)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.ReadOnly = True
        Me.txtdept.Size = New System.Drawing.Size(193, 27)
        Me.txtdept.TabIndex = 20
        '
        'txtusertype
        '
        Me.txtusertype.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtusertype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusertype.Location = New System.Drawing.Point(166, 101)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.ReadOnly = True
        Me.txtusertype.Size = New System.Drawing.Size(193, 27)
        Me.txtusertype.TabIndex = 19
        '
        'empname
        '
        Me.empname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.empname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empname.Location = New System.Drawing.Point(166, 68)
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Size = New System.Drawing.Size(193, 27)
        Me.empname.TabIndex = 18
        '
        'cmbempid
        '
        Me.cmbempid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbempid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbempid.FormattingEnabled = True
        Me.cmbempid.Location = New System.Drawing.Point(166, 35)
        Me.cmbempid.Name = "cmbempid"
        Me.cmbempid.Size = New System.Drawing.Size(193, 27)
        Me.cmbempid.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(70, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Department:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "User Type:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User Name:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Select Employee ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 42)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "UNLOCK USER"
        '
        'btnunlock
        '
        Me.btnunlock.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnunlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunlock.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunlock.ForeColor = System.Drawing.Color.White
        Me.btnunlock.Location = New System.Drawing.Point(514, 318)
        Me.btnunlock.Name = "btnunlock"
        Me.btnunlock.Size = New System.Drawing.Size(121, 38)
        Me.btnunlock.TabIndex = 11
        Me.btnunlock.Text = "Unlock"
        Me.btnunlock.UseVisualStyleBackColor = False
        '
        'Timer1
        '
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
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-4, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 214)
        Me.Panel1.TabIndex = 29
        Me.Panel1.Visible = False
        '
        'btnlckok
        '
        Me.btnlckok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlckok.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlckok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlckok.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlckok.ForeColor = System.Drawing.Color.White
        Me.btnlckok.Location = New System.Drawing.Point(333, 116)
        Me.btnlckok.Name = "btnlckok"
        Me.btnlckok.Size = New System.Drawing.Size(152, 53)
        Me.btnlckok.TabIndex = 2
        Me.btnlckok.Text = "OK"
        Me.btnlckok.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(203, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(413, 45)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "None of the user is locked."
        '
        'unlockuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "unlockuser"
        Me.Text = "Unlock User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents empimage As System.Windows.Forms.PictureBox
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
    Friend WithEvents empname As System.Windows.Forms.TextBox
    Friend WithEvents cmbempid As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtrpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnunlock As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnlckok As System.Windows.Forms.Button
End Class
