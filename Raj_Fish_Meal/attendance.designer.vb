<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendance
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
        Me.lblempid = New System.Windows.Forms.Label
        Me.lblempname = New System.Windows.Forms.Label
        Me.grbattendance = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtempdesignation2 = New System.Windows.Forms.TextBox
        Me.txtempdesignation1 = New System.Windows.Forms.TextBox
        Me.cmbempid = New System.Windows.Forms.ComboBox
        Me.txtempname = New System.Windows.Forms.TextBox
        Me.lblempdesignation = New System.Windows.Forms.Label
        Me.lbltoday = New System.Windows.Forms.Label
        Me.grbshifts = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.lblshiftc = New System.Windows.Forms.Label
        Me.lblshiftb = New System.Windows.Forms.Label
        Me.lblshifta = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbattendance.SuspendLayout()
        Me.grbshifts.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblempid
        '
        Me.lblempid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblempid.AutoSize = True
        Me.lblempid.Location = New System.Drawing.Point(51, 29)
        Me.lblempid.Name = "lblempid"
        Me.lblempid.Size = New System.Drawing.Size(92, 19)
        Me.lblempid.TabIndex = 0
        Me.lblempid.Text = "Employee Id:"
        '
        'lblempname
        '
        Me.lblempname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblempname.AutoSize = True
        Me.lblempname.Location = New System.Drawing.Point(25, 62)
        Me.lblempname.Name = "lblempname"
        Me.lblempname.Size = New System.Drawing.Size(118, 19)
        Me.lblempname.TabIndex = 1
        Me.lblempname.Text = "Employee Name:"
        '
        'grbattendance
        '
        Me.grbattendance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbattendance.Controls.Add(Me.Label2)
        Me.grbattendance.Controls.Add(Me.txtempdesignation2)
        Me.grbattendance.Controls.Add(Me.txtempdesignation1)
        Me.grbattendance.Controls.Add(Me.cmbempid)
        Me.grbattendance.Controls.Add(Me.txtempname)
        Me.grbattendance.Controls.Add(Me.lblempdesignation)
        Me.grbattendance.Controls.Add(Me.lblempid)
        Me.grbattendance.Controls.Add(Me.lblempname)
        Me.grbattendance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbattendance.Location = New System.Drawing.Point(19, 66)
        Me.grbattendance.Name = "grbattendance"
        Me.grbattendance.Size = New System.Drawing.Size(718, 107)
        Me.grbattendance.TabIndex = 2
        Me.grbattendance.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Department:"
        '
        'txtempdesignation2
        '
        Me.txtempdesignation2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtempdesignation2.BackColor = System.Drawing.SystemColors.Window
        Me.txtempdesignation2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempdesignation2.ForeColor = System.Drawing.Color.Black
        Me.txtempdesignation2.Location = New System.Drawing.Point(479, 62)
        Me.txtempdesignation2.Name = "txtempdesignation2"
        Me.txtempdesignation2.ReadOnly = True
        Me.txtempdesignation2.Size = New System.Drawing.Size(214, 27)
        Me.txtempdesignation2.TabIndex = 9
        '
        'txtempdesignation1
        '
        Me.txtempdesignation1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtempdesignation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempdesignation1.ForeColor = System.Drawing.Color.Black
        Me.txtempdesignation1.Location = New System.Drawing.Point(479, 29)
        Me.txtempdesignation1.Name = "txtempdesignation1"
        Me.txtempdesignation1.ReadOnly = True
        Me.txtempdesignation1.Size = New System.Drawing.Size(214, 27)
        Me.txtempdesignation1.TabIndex = 6
        '
        'cmbempid
        '
        Me.cmbempid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbempid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbempid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmbempid.FormattingEnabled = True
        Me.cmbempid.Location = New System.Drawing.Point(149, 26)
        Me.cmbempid.Name = "cmbempid"
        Me.cmbempid.Size = New System.Drawing.Size(214, 27)
        Me.cmbempid.TabIndex = 5
        '
        'txtempname
        '
        Me.txtempname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtempname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempname.ForeColor = System.Drawing.Color.Black
        Me.txtempname.Location = New System.Drawing.Point(149, 59)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.ReadOnly = True
        Me.txtempname.Size = New System.Drawing.Size(214, 27)
        Me.txtempname.TabIndex = 4
        '
        'lblempdesignation
        '
        Me.lblempdesignation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblempdesignation.AutoSize = True
        Me.lblempdesignation.Location = New System.Drawing.Point(382, 32)
        Me.lblempdesignation.Name = "lblempdesignation"
        Me.lblempdesignation.Size = New System.Drawing.Size(91, 19)
        Me.lblempdesignation.TabIndex = 2
        Me.lblempdesignation.Text = "Designation:"
        '
        'lbltoday
        '
        Me.lbltoday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltoday.AutoSize = True
        Me.lbltoday.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltoday.ForeColor = System.Drawing.Color.DarkGray
        Me.lbltoday.Location = New System.Drawing.Point(567, 23)
        Me.lbltoday.Name = "lbltoday"
        Me.lbltoday.Size = New System.Drawing.Size(62, 26)
        Me.lbltoday.TabIndex = 3
        Me.lbltoday.Text = "DATE:"
        '
        'grbshifts
        '
        Me.grbshifts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbshifts.Controls.Add(Me.RadioButton3)
        Me.grbshifts.Controls.Add(Me.RadioButton2)
        Me.grbshifts.Controls.Add(Me.RadioButton1)
        Me.grbshifts.Controls.Add(Me.lblshiftc)
        Me.grbshifts.Controls.Add(Me.lblshiftb)
        Me.grbshifts.Controls.Add(Me.lblshifta)
        Me.grbshifts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbshifts.Location = New System.Drawing.Point(19, 171)
        Me.grbshifts.Name = "grbshifts"
        Me.grbshifts.Size = New System.Drawing.Size(542, 123)
        Me.grbshifts.TabIndex = 3
        Me.grbshifts.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(159, 86)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(63, 31)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Shift C"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(159, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 31)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Shift B"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(159, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 31)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Shift A"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblshiftc
        '
        Me.lblshiftc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblshiftc.AutoSize = True
        Me.lblshiftc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshiftc.ForeColor = System.Drawing.Color.White
        Me.lblshiftc.Location = New System.Drawing.Point(228, 92)
        Me.lblshiftc.Name = "lblshiftc"
        Me.lblshiftc.Size = New System.Drawing.Size(138, 19)
        Me.lblshiftc.TabIndex = 5
        Me.lblshiftc.Text = "12:00 AM - 5:00 AM"
        '
        'lblshiftb
        '
        Me.lblshiftb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblshiftb.AutoSize = True
        Me.lblshiftb.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshiftb.ForeColor = System.Drawing.Color.White
        Me.lblshiftb.Location = New System.Drawing.Point(228, 57)
        Me.lblshiftb.Name = "lblshiftb"
        Me.lblshiftb.Size = New System.Drawing.Size(137, 19)
        Me.lblshiftb.TabIndex = 4
        Me.lblshiftb.Text = "5:00 PM - 12:00 AM"
        '
        'lblshifta
        '
        Me.lblshifta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblshifta.AutoSize = True
        Me.lblshifta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshifta.ForeColor = System.Drawing.Color.White
        Me.lblshifta.Location = New System.Drawing.Point(228, 23)
        Me.lblshifta.Name = "lblshifta"
        Me.lblshifta.Size = New System.Drawing.Size(133, 19)
        Me.lblshifta.TabIndex = 3
        Me.lblshifta.Text = "9:00  AM - 5:00 PM"
        '
        'btnadd
        '
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnadd.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(576, 256)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(161, 38)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.grbattendance)
        Me.GroupBox1.Controls.Add(Me.grbshifts)
        Me.GroupBox1.Controls.Add(Me.lbltoday)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(81, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 338)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(623, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "12/12/2014"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(107, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(12, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(346, 39)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "EMPLOYEE ATTENDANCE"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Name = "attendance"
        Me.Text = "Attendance"
        Me.grbattendance.ResumeLayout(False)
        Me.grbattendance.PerformLayout()
        Me.grbshifts.ResumeLayout(False)
        Me.grbshifts.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblempid As System.Windows.Forms.Label
    Friend WithEvents lblempname As System.Windows.Forms.Label
    Friend WithEvents grbattendance As System.Windows.Forms.GroupBox
    Friend WithEvents txtempdesignation1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbempid As System.Windows.Forms.ComboBox
    Friend WithEvents txtempname As System.Windows.Forms.TextBox
    Friend WithEvents lbltoday As System.Windows.Forms.Label
    Friend WithEvents lblempdesignation As System.Windows.Forms.Label
    Friend WithEvents grbshifts As System.Windows.Forms.GroupBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtempdesignation2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblshiftc As System.Windows.Forms.Label
    Friend WithEvents lblshiftb As System.Windows.Forms.Label
    Friend WithEvents lblshifta As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
