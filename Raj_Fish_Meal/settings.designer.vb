<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.txtda = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnupdate = New System.Windows.Forms.Button
        Me.txtvat = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.txtpf = New System.Windows.Forms.TextBox
        Me.chkvat = New System.Windows.Forms.CheckBox
        Me.txthra = New System.Windows.Forms.TextBox
        Me.chkdiscount = New System.Windows.Forms.CheckBox
        Me.chkpf = New System.Windows.Forms.CheckBox
        Me.chkhra = New System.Windows.Forms.CheckBox
        Me.chkda = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtda
        '
        Me.txtda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtda.Enabled = False
        Me.txtda.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtda.ForeColor = System.Drawing.Color.Black
        Me.txtda.Location = New System.Drawing.Point(24, 60)
        Me.txtda.Name = "txtda"
        Me.txtda.Size = New System.Drawing.Size(155, 27)
        Me.txtda.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.txtvat)
        Me.GroupBox1.Controls.Add(Me.txtdiscount)
        Me.GroupBox1.Controls.Add(Me.txtpf)
        Me.GroupBox1.Controls.Add(Me.chkvat)
        Me.GroupBox1.Controls.Add(Me.txthra)
        Me.GroupBox1.Controls.Add(Me.chkdiscount)
        Me.GroupBox1.Controls.Add(Me.chkpf)
        Me.GroupBox1.Controls.Add(Me.chkhra)
        Me.GroupBox1.Controls.Add(Me.chkda)
        Me.GroupBox1.Controls.Add(Me.txtda)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 145)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(724, 96)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(155, 27)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'txtvat
        '
        Me.txtvat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvat.Enabled = False
        Me.txtvat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvat.ForeColor = System.Drawing.Color.Black
        Me.txtvat.Location = New System.Drawing.Point(724, 60)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.Size = New System.Drawing.Size(155, 27)
        Me.txtvat.TabIndex = 10
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscount.Enabled = False
        Me.txtdiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.ForeColor = System.Drawing.Color.Black
        Me.txtdiscount.Location = New System.Drawing.Point(549, 60)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(155, 27)
        Me.txtdiscount.TabIndex = 9
        '
        'txtpf
        '
        Me.txtpf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpf.Enabled = False
        Me.txtpf.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpf.ForeColor = System.Drawing.Color.Black
        Me.txtpf.Location = New System.Drawing.Point(374, 60)
        Me.txtpf.Name = "txtpf"
        Me.txtpf.Size = New System.Drawing.Size(155, 27)
        Me.txtpf.TabIndex = 8
        '
        'chkvat
        '
        Me.chkvat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkvat.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkvat.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkvat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.chkvat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkvat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkvat.ForeColor = System.Drawing.Color.White
        Me.chkvat.Location = New System.Drawing.Point(724, 25)
        Me.chkvat.Name = "chkvat"
        Me.chkvat.Size = New System.Drawing.Size(155, 27)
        Me.chkvat.TabIndex = 6
        Me.chkvat.Text = "VAT"
        Me.chkvat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkvat.UseVisualStyleBackColor = True
        '
        'txthra
        '
        Me.txthra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txthra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthra.Enabled = False
        Me.txthra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthra.ForeColor = System.Drawing.Color.Black
        Me.txthra.Location = New System.Drawing.Point(199, 60)
        Me.txthra.Name = "txthra"
        Me.txthra.Size = New System.Drawing.Size(155, 27)
        Me.txthra.TabIndex = 7
        '
        'chkdiscount
        '
        Me.chkdiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkdiscount.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkdiscount.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkdiscount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.chkdiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkdiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdiscount.ForeColor = System.Drawing.Color.White
        Me.chkdiscount.Location = New System.Drawing.Point(549, 25)
        Me.chkdiscount.Name = "chkdiscount"
        Me.chkdiscount.Size = New System.Drawing.Size(155, 27)
        Me.chkdiscount.TabIndex = 5
        Me.chkdiscount.Text = "DISCOUNT"
        Me.chkdiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkdiscount.UseVisualStyleBackColor = True
        '
        'chkpf
        '
        Me.chkpf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkpf.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkpf.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkpf.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.chkpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkpf.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpf.ForeColor = System.Drawing.Color.White
        Me.chkpf.Location = New System.Drawing.Point(374, 25)
        Me.chkpf.Name = "chkpf"
        Me.chkpf.Size = New System.Drawing.Size(155, 27)
        Me.chkpf.TabIndex = 4
        Me.chkpf.Text = "PF"
        Me.chkpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkpf.UseVisualStyleBackColor = True
        '
        'chkhra
        '
        Me.chkhra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkhra.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkhra.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkhra.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.chkhra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkhra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkhra.ForeColor = System.Drawing.Color.White
        Me.chkhra.Location = New System.Drawing.Point(199, 25)
        Me.chkhra.Name = "chkhra"
        Me.chkhra.Size = New System.Drawing.Size(155, 27)
        Me.chkhra.TabIndex = 3
        Me.chkhra.Text = "HRA"
        Me.chkhra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkhra.UseVisualStyleBackColor = True
        '
        'chkda
        '
        Me.chkda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkda.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkda.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack
        Me.chkda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkda.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkda.ForeColor = System.Drawing.Color.White
        Me.chkda.Location = New System.Drawing.Point(24, 25)
        Me.chkda.Name = "chkda"
        Me.chkda.Size = New System.Drawing.Size(155, 27)
        Me.chkda.TabIndex = 2
        Me.chkda.Text = "DA"
        Me.chkda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkda.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SETTINGS"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(24, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(961, 222)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 289)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Name = "settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtda As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkvat As System.Windows.Forms.CheckBox
    Friend WithEvents chkdiscount As System.Windows.Forms.CheckBox
    Friend WithEvents chkpf As System.Windows.Forms.CheckBox
    Friend WithEvents chkhra As System.Windows.Forms.CheckBox
    Friend WithEvents chkda As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtvat As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtpf As System.Windows.Forms.TextBox
    Friend WithEvents txthra As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
