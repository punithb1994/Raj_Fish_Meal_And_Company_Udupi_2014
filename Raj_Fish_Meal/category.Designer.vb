<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(category))
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbcatid = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtsadd = New System.Windows.Forms.TextBox
        Me.cmbsid = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbcatname = New System.Windows.Forms.ComboBox
        Me.txtcattype = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcatid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnnew = New System.Windows.Forms.Button
        Me.lblslno = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btndel = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(638, 304)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(101, 37)
        Me.btnsave.TabIndex = 17
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(91, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 45)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Add category"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(852, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 37)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbcatid)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtsadd)
        Me.Panel1.Controls.Add(Me.cmbsid)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtsname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbcatname)
        Me.Panel1.Controls.Add(Me.txtcattype)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtcatid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(77, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 179)
        Me.Panel1.TabIndex = 32
        '
        'cmbcatid
        '
        Me.cmbcatid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbcatid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcatid.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcatid.ForeColor = System.Drawing.Color.Black
        Me.cmbcatid.FormattingEnabled = True
        Me.cmbcatid.Items.AddRange(New Object() {"Fish", "Bearing", "Others"})
        Me.cmbcatid.Location = New System.Drawing.Point(158, 18)
        Me.cmbcatid.Name = "cmbcatid"
        Me.cmbcatid.Size = New System.Drawing.Size(264, 31)
        Me.cmbcatid.TabIndex = 44
        Me.cmbcatid.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(506, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Address:"
        '
        'txtsadd
        '
        Me.txtsadd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsadd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsadd.ForeColor = System.Drawing.Color.Black
        Me.txtsadd.Location = New System.Drawing.Point(590, 93)
        Me.txtsadd.Multiline = True
        Me.txtsadd.Name = "txtsadd"
        Me.txtsadd.ReadOnly = True
        Me.txtsadd.Size = New System.Drawing.Size(264, 64)
        Me.txtsadd.TabIndex = 42
        '
        'cmbsid
        '
        Me.cmbsid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbsid.Enabled = False
        Me.cmbsid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbsid.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsid.ForeColor = System.Drawing.Color.Black
        Me.cmbsid.FormattingEnabled = True
        Me.cmbsid.Items.AddRange(New Object() {"Fish", "Bearing", "Others"})
        Me.cmbsid.Location = New System.Drawing.Point(590, 19)
        Me.cmbsid.Name = "cmbsid"
        Me.cmbsid.Size = New System.Drawing.Size(264, 31)
        Me.cmbsid.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(459, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 23)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Supplier name:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(101, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 23)
        Me.Label8.TabIndex = 44
        '
        'txtsname
        '
        Me.txtsname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsname.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.ForeColor = System.Drawing.Color.Black
        Me.txtsname.Location = New System.Drawing.Point(590, 56)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.ReadOnly = True
        Me.txtsname.Size = New System.Drawing.Size(264, 31)
        Me.txtsname.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(486, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Supplier Id:"
        '
        'cmbcatname
        '
        Me.cmbcatname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbcatname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcatname.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcatname.ForeColor = System.Drawing.Color.Black
        Me.cmbcatname.FormattingEnabled = True
        Me.cmbcatname.Items.AddRange(New Object() {"Fish", "Bearing", "Others"})
        Me.cmbcatname.Location = New System.Drawing.Point(158, 56)
        Me.cmbcatname.Name = "cmbcatname"
        Me.cmbcatname.Size = New System.Drawing.Size(264, 31)
        Me.cmbcatname.TabIndex = 37
        '
        'txtcattype
        '
        Me.txtcattype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcattype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcattype.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcattype.ForeColor = System.Drawing.Color.Black
        Me.txtcattype.Location = New System.Drawing.Point(158, 93)
        Me.txtcattype.MaxLength = 30
        Me.txtcattype.Name = "txtcattype"
        Me.txtcattype.Size = New System.Drawing.Size(264, 31)
        Me.txtcattype.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Category Type:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Category name:"
        '
        'txtcatid
        '
        Me.txtcatid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcatid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcatid.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcatid.ForeColor = System.Drawing.Color.Black
        Me.txtcatid.Location = New System.Drawing.Point(158, 19)
        Me.txtcatid.Name = "txtcatid"
        Me.txtcatid.ReadOnly = True
        Me.txtcatid.Size = New System.Drawing.Size(264, 31)
        Me.txtcatid.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Category Id:"
        '
        'btnnew
        '
        Me.btnnew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnew.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(424, 304)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(101, 37)
        Me.btnnew.TabIndex = 45
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'lblslno
        '
        Me.lblslno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblslno.AutoSize = True
        Me.lblslno.BackColor = System.Drawing.Color.Transparent
        Me.lblslno.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslno.ForeColor = System.Drawing.Color.Gray
        Me.lblslno.Location = New System.Drawing.Point(179, 290)
        Me.lblslno.Name = "lblslno"
        Me.lblslno.Size = New System.Drawing.Size(0, 94)
        Me.lblslno.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(760, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 15)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "It allows to add multiple supplier to an item." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnedit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(531, 304)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(101, 37)
        Me.btnedit.TabIndex = 47
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(638, 304)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(101, 37)
        Me.btnupdate.TabIndex = 48
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        Me.btnupdate.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'btndel
        '
        Me.btndel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(745, 304)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(101, 37)
        Me.btndel.TabIndex = 49
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1030, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblslno)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsadd As System.Windows.Forms.TextBox
    Friend WithEvents cmbsid As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbcatname As System.Windows.Forms.ComboBox
    Friend WithEvents txtcattype As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcatid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents lblslno As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents cmbcatid As System.Windows.Forms.ComboBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
