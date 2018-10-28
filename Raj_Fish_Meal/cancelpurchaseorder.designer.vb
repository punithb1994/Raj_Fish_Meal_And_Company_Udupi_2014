<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancelpurchaseorder
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblamt = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.txtqtyordered = New System.Windows.Forms.TextBox
        Me.lblqtyordered = New System.Windows.Forms.Label
        Me.txtitemname = New System.Windows.Forms.TextBox
        Me.lblitemname = New System.Windows.Forms.Label
        Me.cmbpurcaseorderno = New System.Windows.Forms.ComboBox
        Me.lblselectpo = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnback = New System.Windows.Forms.Button
        Me.btncancelorder = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.lblamt)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtqtyordered)
        Me.GroupBox1.Controls.Add(Me.lblqtyordered)
        Me.GroupBox1.Controls.Add(Me.txtitemname)
        Me.GroupBox1.Controls.Add(Me.lblitemname)
        Me.GroupBox1.Controls.Add(Me.cmbpurcaseorderno)
        Me.GroupBox1.Controls.Add(Me.lblselectpo)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(84, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 263)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cancel Purchase Order"
        '
        'lblamt
        '
        Me.lblamt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblamt.AutoSize = True
        Me.lblamt.Location = New System.Drawing.Point(171, 171)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(63, 19)
        Me.lblamt.TabIndex = 7
        Me.lblamt.Text = "Amount:"
        '
        'txtamount
        '
        Me.txtamount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtamount.Enabled = False
        Me.txtamount.Location = New System.Drawing.Point(264, 171)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(121, 27)
        Me.txtamount.TabIndex = 6
        '
        'txtqtyordered
        '
        Me.txtqtyordered.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtqtyordered.Enabled = False
        Me.txtqtyordered.Location = New System.Drawing.Point(264, 134)
        Me.txtqtyordered.Name = "txtqtyordered"
        Me.txtqtyordered.Size = New System.Drawing.Size(121, 27)
        Me.txtqtyordered.TabIndex = 5
        '
        'lblqtyordered
        '
        Me.lblqtyordered.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblqtyordered.AutoSize = True
        Me.lblqtyordered.Location = New System.Drawing.Point(127, 134)
        Me.lblqtyordered.Name = "lblqtyordered"
        Me.lblqtyordered.Size = New System.Drawing.Size(126, 19)
        Me.lblqtyordered.TabIndex = 4
        Me.lblqtyordered.Text = "Quantity Ordered:"
        '
        'txtitemname
        '
        Me.txtitemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtitemname.Enabled = False
        Me.txtitemname.Location = New System.Drawing.Point(264, 94)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(121, 27)
        Me.txtitemname.TabIndex = 3
        '
        'lblitemname
        '
        Me.lblitemname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitemname.AutoSize = True
        Me.lblitemname.Location = New System.Drawing.Point(156, 97)
        Me.lblitemname.Name = "lblitemname"
        Me.lblitemname.Size = New System.Drawing.Size(84, 19)
        Me.lblitemname.TabIndex = 2
        Me.lblitemname.Text = "Item Name:"
        '
        'cmbpurcaseorderno
        '
        Me.cmbpurcaseorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbpurcaseorderno.FormattingEnabled = True
        Me.cmbpurcaseorderno.Location = New System.Drawing.Point(264, 53)
        Me.cmbpurcaseorderno.Name = "cmbpurcaseorderno"
        Me.cmbpurcaseorderno.Size = New System.Drawing.Size(121, 27)
        Me.cmbpurcaseorderno.TabIndex = 1
        '
        'lblselectpo
        '
        Me.lblselectpo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblselectpo.AutoSize = True
        Me.lblselectpo.Location = New System.Drawing.Point(83, 61)
        Me.lblselectpo.Name = "lblselectpo"
        Me.lblselectpo.Size = New System.Drawing.Size(178, 19)
        Me.lblselectpo.TabIndex = 0
        Me.lblselectpo.Text = "Select Purchase Order No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.btnback)
        Me.GroupBox2.Controls.Add(Me.btncancelorder)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(214, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'btnback
        '
        Me.btnback.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnback.Location = New System.Drawing.Point(180, 36)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 35)
        Me.btnback.TabIndex = 1
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btncancelorder
        '
        Me.btncancelorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancelorder.Location = New System.Drawing.Point(29, 36)
        Me.btncancelorder.Name = "btncancelorder"
        Me.btncancelorder.Size = New System.Drawing.Size(131, 35)
        Me.btncancelorder.TabIndex = 0
        Me.btncancelorder.Text = "Cancel Purchase Order"
        Me.btncancelorder.UseVisualStyleBackColor = True
        '
        'cancelpurchaseorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "cancelpurchaseorder"
        Me.Text = "Cancel Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtqtyordered As System.Windows.Forms.TextBox
    Friend WithEvents lblqtyordered As System.Windows.Forms.Label
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents lblitemname As System.Windows.Forms.Label
    Friend WithEvents cmbpurcaseorderno As System.Windows.Forms.ComboBox
    Friend WithEvents lblselectpo As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btncancelorder As System.Windows.Forms.Button
End Class
