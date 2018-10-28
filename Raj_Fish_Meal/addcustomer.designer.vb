<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcustomer
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.grbdata = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdbforeign = New System.Windows.Forms.RadioButton
        Me.rdbindian = New System.Windows.Forms.RadioButton
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcustomeremail = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtlandline = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.lbladdress = New System.Windows.Forms.Label
        Me.lblphno = New System.Windows.Forms.Label
        Me.txtcustid = New System.Windows.Forms.TextBox
        Me.lblcustname = New System.Windows.Forms.Label
        Me.lblcustid = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grbdata.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnnew)
        Me.GroupBox1.Controls.Add(Me.grbdata)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 463)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(30, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Saved Successfully..."
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(27, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 39)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ADD CUSTOMER"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(331, 408)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(93, 34)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnew.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(232, 408)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(93, 34)
        Me.btnnew.TabIndex = 5
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'grbdata
        '
        Me.grbdata.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbdata.Controls.Add(Me.Label4)
        Me.grbdata.Controls.Add(Me.rdbforeign)
        Me.grbdata.Controls.Add(Me.rdbindian)
        Me.grbdata.Controls.Add(Me.txtmobile)
        Me.grbdata.Controls.Add(Me.Label3)
        Me.grbdata.Controls.Add(Me.txtcustomeremail)
        Me.grbdata.Controls.Add(Me.Label1)
        Me.grbdata.Controls.Add(Me.txtlandline)
        Me.grbdata.Controls.Add(Me.txtaddress)
        Me.grbdata.Controls.Add(Me.txtcustname)
        Me.grbdata.Controls.Add(Me.lbladdress)
        Me.grbdata.Controls.Add(Me.lblphno)
        Me.grbdata.Controls.Add(Me.txtcustid)
        Me.grbdata.Controls.Add(Me.lblcustname)
        Me.grbdata.Controls.Add(Me.lblcustid)
        Me.grbdata.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbdata.Location = New System.Drawing.Point(30, 64)
        Me.grbdata.Name = "grbdata"
        Me.grbdata.Size = New System.Drawing.Size(394, 329)
        Me.grbdata.TabIndex = 6
        Me.grbdata.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nationality:"
        '
        'rdbforeign
        '
        Me.rdbforeign.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdbforeign.AutoSize = True
        Me.rdbforeign.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbforeign.ForeColor = System.Drawing.Color.White
        Me.rdbforeign.Location = New System.Drawing.Point(243, 180)
        Me.rdbforeign.Name = "rdbforeign"
        Me.rdbforeign.Size = New System.Drawing.Size(75, 23)
        Me.rdbforeign.TabIndex = 9
        Me.rdbforeign.TabStop = True
        Me.rdbforeign.Text = "Foreign"
        Me.rdbforeign.UseVisualStyleBackColor = True
        '
        'rdbindian
        '
        Me.rdbindian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdbindian.AutoSize = True
        Me.rdbindian.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbindian.ForeColor = System.Drawing.Color.White
        Me.rdbindian.Location = New System.Drawing.Point(150, 180)
        Me.rdbindian.Name = "rdbindian"
        Me.rdbindian.Size = New System.Drawing.Size(67, 23)
        Me.rdbindian.TabIndex = 8
        Me.rdbindian.TabStop = True
        Me.rdbindian.Text = "Indian"
        Me.rdbindian.UseVisualStyleBackColor = True
        '
        'txtmobile
        '
        Me.txtmobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmobile.Location = New System.Drawing.Point(150, 242)
        Me.txtmobile.MaxLength = 10
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(217, 27)
        Me.txtmobile.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(63, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mobile No:"
        '
        'txtcustomeremail
        '
        Me.txtcustomeremail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustomeremail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustomeremail.Location = New System.Drawing.Point(150, 275)
        Me.txtcustomeremail.MaxLength = 50
        Me.txtcustomeremail.Name = "txtcustomeremail"
        Me.txtcustomeremail.Size = New System.Drawing.Size(217, 27)
        Me.txtcustomeremail.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Email ID:"
        '
        'txtlandline
        '
        Me.txtlandline.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlandline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlandline.Location = New System.Drawing.Point(150, 209)
        Me.txtlandline.MaxLength = 11
        Me.txtlandline.Name = "txtlandline"
        Me.txtlandline.Size = New System.Drawing.Size(217, 27)
        Me.txtlandline.TabIndex = 3
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(150, 103)
        Me.txtaddress.MaxLength = 200
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(217, 71)
        Me.txtaddress.TabIndex = 2
        '
        'txtcustname
        '
        Me.txtcustname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustname.Location = New System.Drawing.Point(150, 70)
        Me.txtcustname.MaxLength = 35
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(217, 27)
        Me.txtcustname.TabIndex = 1
        '
        'lbladdress
        '
        Me.lbladdress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.White
        Me.lbladdress.Location = New System.Drawing.Point(78, 106)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(65, 19)
        Me.lbladdress.TabIndex = 0
        Me.lbladdress.Text = "Address:"
        '
        'lblphno
        '
        Me.lblphno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblphno.AutoSize = True
        Me.lblphno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphno.ForeColor = System.Drawing.Color.White
        Me.lblphno.Location = New System.Drawing.Point(53, 212)
        Me.lblphno.Name = "lblphno"
        Me.lblphno.Size = New System.Drawing.Size(90, 19)
        Me.lblphno.TabIndex = 0
        Me.lblphno.Text = "Landline No:"
        '
        'txtcustid
        '
        Me.txtcustid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcustid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustid.Location = New System.Drawing.Point(150, 37)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(217, 27)
        Me.txtcustid.TabIndex = 2
        '
        'lblcustname
        '
        Me.lblcustname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustname.AutoSize = True
        Me.lblcustname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustname.ForeColor = System.Drawing.Color.White
        Me.lblcustname.Location = New System.Drawing.Point(27, 73)
        Me.lblcustname.Name = "lblcustname"
        Me.lblcustname.Size = New System.Drawing.Size(117, 19)
        Me.lblcustname.TabIndex = 1
        Me.lblcustname.Text = "Customer Name:"
        '
        'lblcustid
        '
        Me.lblcustid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcustid.AutoSize = True
        Me.lblcustid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustid.ForeColor = System.Drawing.Color.White
        Me.lblcustid.Location = New System.Drawing.Point(52, 40)
        Me.lblcustid.Name = "lblcustid"
        Me.lblcustid.Size = New System.Drawing.Size(91, 19)
        Me.lblcustid.TabIndex = 0
        Me.lblcustid.Text = "Customer Id:"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'addcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "addcustomer"
        Me.Text = "Add Customer"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbdata.ResumeLayout(False)
        Me.grbdata.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents grbdata As System.Windows.Forms.GroupBox
    Friend WithEvents txtcustomeremail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlandline As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblphno As System.Windows.Forms.Label
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents lblcustname As System.Windows.Forms.Label
    Friend WithEvents lblcustid As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbforeign As System.Windows.Forms.RadioButton
    Friend WithEvents rdbindian As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
