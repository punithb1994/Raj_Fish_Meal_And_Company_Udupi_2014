<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addinventory
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
        Me.grpinventoryinfo = New System.Windows.Forms.GroupBox
        Me.cmbsuppid = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtitemtype2 = New System.Windows.Forms.TextBox
        Me.txtitemtype1 = New System.Windows.Forms.TextBox
        Me.txtcatid = New System.Windows.Forms.TextBox
        Me.cmbcatid = New System.Windows.Forms.ComboBox
        Me.cmbitemcode = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.inventorydate = New System.Windows.Forms.DateTimePicker
        Me.txtsuppliername = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtitemcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtclosingstock = New System.Windows.Forms.TextBox
        Me.txtincomingstock = New System.Windows.Forms.TextBox
        Me.txtopeningstock = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbitype2 = New System.Windows.Forms.ComboBox
        Me.cmbitype1 = New System.Windows.Forms.ComboBox
        Me.cmbitemname = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpinventoryinfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpinventoryinfo
        '
        Me.grpinventoryinfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpinventoryinfo.AutoSize = True
        Me.grpinventoryinfo.Controls.Add(Me.cmbsuppid)
        Me.grpinventoryinfo.Controls.Add(Me.Label9)
        Me.grpinventoryinfo.Controls.Add(Me.txtitemtype2)
        Me.grpinventoryinfo.Controls.Add(Me.txtitemtype1)
        Me.grpinventoryinfo.Controls.Add(Me.txtcatid)
        Me.grpinventoryinfo.Controls.Add(Me.cmbcatid)
        Me.grpinventoryinfo.Controls.Add(Me.cmbitemcode)
        Me.grpinventoryinfo.Controls.Add(Me.Label8)
        Me.grpinventoryinfo.Controls.Add(Me.inventorydate)
        Me.grpinventoryinfo.Controls.Add(Me.txtsuppliername)
        Me.grpinventoryinfo.Controls.Add(Me.Label7)
        Me.grpinventoryinfo.Controls.Add(Me.txtitemcode)
        Me.grpinventoryinfo.Controls.Add(Me.Label6)
        Me.grpinventoryinfo.Controls.Add(Me.txtclosingstock)
        Me.grpinventoryinfo.Controls.Add(Me.txtincomingstock)
        Me.grpinventoryinfo.Controls.Add(Me.txtopeningstock)
        Me.grpinventoryinfo.Controls.Add(Me.Label5)
        Me.grpinventoryinfo.Controls.Add(Me.Label4)
        Me.grpinventoryinfo.Controls.Add(Me.Label3)
        Me.grpinventoryinfo.Controls.Add(Me.cmbitype2)
        Me.grpinventoryinfo.Controls.Add(Me.cmbitype1)
        Me.grpinventoryinfo.Controls.Add(Me.cmbitemname)
        Me.grpinventoryinfo.Controls.Add(Me.Label2)
        Me.grpinventoryinfo.Controls.Add(Me.Label1)
        Me.grpinventoryinfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpinventoryinfo.Location = New System.Drawing.Point(41, 58)
        Me.grpinventoryinfo.Name = "grpinventoryinfo"
        Me.grpinventoryinfo.Size = New System.Drawing.Size(476, 475)
        Me.grpinventoryinfo.TabIndex = 0
        Me.grpinventoryinfo.TabStop = False
        '
        'cmbsuppid
        '
        Me.cmbsuppid.FormattingEnabled = True
        Me.cmbsuppid.Location = New System.Drawing.Point(214, 208)
        Me.cmbsuppid.Name = "cmbsuppid"
        Me.cmbsuppid.Size = New System.Drawing.Size(183, 27)
        Me.cmbsuppid.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Supplier ID"
        '
        'txtitemtype2
        '
        Me.txtitemtype2.Location = New System.Drawing.Point(281, 163)
        Me.txtitemtype2.Name = "txtitemtype2"
        Me.txtitemtype2.Size = New System.Drawing.Size(113, 27)
        Me.txtitemtype2.TabIndex = 24
        '
        'txtitemtype1
        '
        Me.txtitemtype1.Location = New System.Drawing.Point(283, 118)
        Me.txtitemtype1.Name = "txtitemtype1"
        Me.txtitemtype1.Size = New System.Drawing.Size(113, 27)
        Me.txtitemtype1.TabIndex = 23
        '
        'txtcatid
        '
        Me.txtcatid.Location = New System.Drawing.Point(213, 119)
        Me.txtcatid.Name = "txtcatid"
        Me.txtcatid.Size = New System.Drawing.Size(63, 27)
        Me.txtcatid.TabIndex = 22
        '
        'cmbcatid
        '
        Me.cmbcatid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbcatid.FormattingEnabled = True
        Me.cmbcatid.Location = New System.Drawing.Point(212, 119)
        Me.cmbcatid.Name = "cmbcatid"
        Me.cmbcatid.Size = New System.Drawing.Size(63, 27)
        Me.cmbcatid.TabIndex = 21
        '
        'cmbitemcode
        '
        Me.cmbitemcode.FormattingEnabled = True
        Me.cmbitemcode.Location = New System.Drawing.Point(212, 35)
        Me.cmbitemcode.Name = "cmbitemcode"
        Me.cmbitemcode.Size = New System.Drawing.Size(182, 27)
        Me.cmbitemcode.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(121, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Date:"
        '
        'inventorydate
        '
        Me.inventorydate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.inventorydate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inventorydate.Location = New System.Drawing.Point(212, 296)
        Me.inventorydate.Name = "inventorydate"
        Me.inventorydate.Size = New System.Drawing.Size(184, 27)
        Me.inventorydate.TabIndex = 18
        '
        'txtsuppliername
        '
        Me.txtsuppliername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsuppliername.Location = New System.Drawing.Point(211, 250)
        Me.txtsuppliername.Name = "txtsuppliername"
        Me.txtsuppliername.Size = New System.Drawing.Size(186, 27)
        Me.txtsuppliername.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Supplier Name:"
        '
        'txtitemcode
        '
        Me.txtitemcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtitemcode.Enabled = False
        Me.txtitemcode.Location = New System.Drawing.Point(214, 36)
        Me.txtitemcode.Name = "txtitemcode"
        Me.txtitemcode.Size = New System.Drawing.Size(177, 27)
        Me.txtitemcode.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Item Code:"
        '
        'txtclosingstock
        '
        Me.txtclosingstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtclosingstock.Enabled = False
        Me.txtclosingstock.Location = New System.Drawing.Point(213, 422)
        Me.txtclosingstock.Name = "txtclosingstock"
        Me.txtclosingstock.Size = New System.Drawing.Size(182, 27)
        Me.txtclosingstock.TabIndex = 13
        '
        'txtincomingstock
        '
        Me.txtincomingstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtincomingstock.Location = New System.Drawing.Point(213, 379)
        Me.txtincomingstock.Name = "txtincomingstock"
        Me.txtincomingstock.Size = New System.Drawing.Size(182, 27)
        Me.txtincomingstock.TabIndex = 12
        '
        'txtopeningstock
        '
        Me.txtopeningstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtopeningstock.Enabled = False
        Me.txtopeningstock.Location = New System.Drawing.Point(213, 338)
        Me.txtopeningstock.Name = "txtopeningstock"
        Me.txtopeningstock.Size = New System.Drawing.Size(184, 27)
        Me.txtopeningstock.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Closing Stock:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Incoming Stock:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Opening Stock:"
        '
        'cmbitype2
        '
        Me.cmbitype2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbitype2.FormattingEnabled = True
        Me.cmbitype2.Items.AddRange(New Object() {"6853", "3695", "3669", "5656", "6645", "5555", "6994", "6555"})
        Me.cmbitype2.Location = New System.Drawing.Point(282, 164)
        Me.cmbitype2.Name = "cmbitype2"
        Me.cmbitype2.Size = New System.Drawing.Size(113, 27)
        Me.cmbitype2.TabIndex = 7
        '
        'cmbitype1
        '
        Me.cmbitype1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbitype1.FormattingEnabled = True
        Me.cmbitype1.Items.AddRange(New Object() {"Mackeral ", "Mix Fish"})
        Me.cmbitype1.Location = New System.Drawing.Point(282, 119)
        Me.cmbitype1.Name = "cmbitype1"
        Me.cmbitype1.Size = New System.Drawing.Size(113, 27)
        Me.cmbitype1.TabIndex = 6
        '
        'cmbitemname
        '
        Me.cmbitemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbitemname.FormattingEnabled = True
        Me.cmbitemname.Items.AddRange(New Object() {"Fish", "Hardwares", "Others"})
        Me.cmbitemname.Location = New System.Drawing.Point(212, 74)
        Me.cmbitemname.Name = "cmbitemname"
        Me.cmbitemname.Size = New System.Drawing.Size(182, 27)
        Me.cmbitemname.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name:"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(344, 535)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(93, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btnnew)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.grpinventoryinfo)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 570)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(120, 535)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(83, 29)
        Me.btnadd.TabIndex = 36
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnew.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(233, 535)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 29)
        Me.btnnew.TabIndex = 35
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(168, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 39)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "ADD INVENTORY"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'addinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "addinventory"
        Me.Text = "Add Inventory"
        Me.grpinventoryinfo.ResumeLayout(False)
        Me.grpinventoryinfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpinventoryinfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbitype2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbitype1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbitemname As System.Windows.Forms.ComboBox
    Friend WithEvents txtopeningstock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsuppliername As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtitemcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtclosingstock As System.Windows.Forms.TextBox
    Friend WithEvents txtincomingstock As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents inventorydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cmbitemcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcatid As System.Windows.Forms.ComboBox
    Friend WithEvents txtcatid As System.Windows.Forms.TextBox
    Friend WithEvents txtitemtype2 As System.Windows.Forms.TextBox
    Friend WithEvents txtitemtype1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbsuppid As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
