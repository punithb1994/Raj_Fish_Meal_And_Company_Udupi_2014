<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseorderdetails
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
        Me.lblpurchaseorderno = New System.Windows.Forms.Label
        Me.grbpodetails = New System.Windows.Forms.GroupBox
        Me.DateTimePickerorderdate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerrecievingdate = New System.Windows.Forms.DateTimePicker
        Me.txtorderqty = New System.Windows.Forms.TextBox
        Me.txtrecvqty = New System.Windows.Forms.TextBox
        Me.txttax = New System.Windows.Forms.TextBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.lblamount = New System.Windows.Forms.Label
        Me.lbltax = New System.Windows.Forms.Label
        Me.lblrecvqty = New System.Windows.Forms.Label
        Me.lblorderqty = New System.Windows.Forms.Label
        Me.lblrecvdate = New System.Windows.Forms.Label
        Me.lblorderdate = New System.Windows.Forms.Label
        Me.txtsuppname = New System.Windows.Forms.TextBox
        Me.lblsuppname = New System.Windows.Forms.Label
        Me.txtsuppid = New System.Windows.Forms.TextBox
        Me.lblsuppid = New System.Windows.Forms.Label
        Me.cmbpurorderno = New System.Windows.Forms.ComboBox
        Me.grbcontrols = New System.Windows.Forms.GroupBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.grbpodetails.SuspendLayout()
        Me.grbcontrols.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblpurchaseorderno
        '
        Me.lblpurchaseorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblpurchaseorderno.AutoSize = True
        Me.lblpurchaseorderno.Location = New System.Drawing.Point(106, 35)
        Me.lblpurchaseorderno.Name = "lblpurchaseorderno"
        Me.lblpurchaseorderno.Size = New System.Drawing.Size(135, 19)
        Me.lblpurchaseorderno.TabIndex = 0
        Me.lblpurchaseorderno.Text = "Purchase Order No:"
        '
        'grbpodetails
        '
        Me.grbpodetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbpodetails.Controls.Add(Me.DateTimePickerorderdate)
        Me.grbpodetails.Controls.Add(Me.DateTimePickerrecievingdate)
        Me.grbpodetails.Controls.Add(Me.txtorderqty)
        Me.grbpodetails.Controls.Add(Me.txtrecvqty)
        Me.grbpodetails.Controls.Add(Me.txttax)
        Me.grbpodetails.Controls.Add(Me.txtamount)
        Me.grbpodetails.Controls.Add(Me.lblamount)
        Me.grbpodetails.Controls.Add(Me.lbltax)
        Me.grbpodetails.Controls.Add(Me.lblrecvqty)
        Me.grbpodetails.Controls.Add(Me.lblorderqty)
        Me.grbpodetails.Controls.Add(Me.lblrecvdate)
        Me.grbpodetails.Controls.Add(Me.lblorderdate)
        Me.grbpodetails.Controls.Add(Me.txtsuppname)
        Me.grbpodetails.Controls.Add(Me.lblsuppname)
        Me.grbpodetails.Controls.Add(Me.txtsuppid)
        Me.grbpodetails.Controls.Add(Me.lblsuppid)
        Me.grbpodetails.Controls.Add(Me.cmbpurorderno)
        Me.grbpodetails.Controls.Add(Me.lblpurchaseorderno)
        Me.grbpodetails.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbpodetails.Location = New System.Drawing.Point(72, 51)
        Me.grbpodetails.Name = "grbpodetails"
        Me.grbpodetails.Size = New System.Drawing.Size(492, 397)
        Me.grbpodetails.TabIndex = 1
        Me.grbpodetails.TabStop = False
        '
        'DateTimePickerorderdate
        '
        Me.DateTimePickerorderdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerorderdate.Location = New System.Drawing.Point(275, 147)
        Me.DateTimePickerorderdate.Name = "DateTimePickerorderdate"
        Me.DateTimePickerorderdate.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePickerorderdate.TabIndex = 21
        '
        'DateTimePickerrecievingdate
        '
        Me.DateTimePickerrecievingdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerrecievingdate.Location = New System.Drawing.Point(275, 185)
        Me.DateTimePickerrecievingdate.Name = "DateTimePickerrecievingdate"
        Me.DateTimePickerrecievingdate.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePickerrecievingdate.TabIndex = 20
        '
        'txtorderqty
        '
        Me.txtorderqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtorderqty.Location = New System.Drawing.Point(275, 222)
        Me.txtorderqty.Name = "txtorderqty"
        Me.txtorderqty.Size = New System.Drawing.Size(100, 27)
        Me.txtorderqty.TabIndex = 19
        '
        'txtrecvqty
        '
        Me.txtrecvqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtrecvqty.Location = New System.Drawing.Point(275, 257)
        Me.txtrecvqty.Name = "txtrecvqty"
        Me.txtrecvqty.Size = New System.Drawing.Size(100, 27)
        Me.txtrecvqty.TabIndex = 18
        '
        'txttax
        '
        Me.txttax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttax.Location = New System.Drawing.Point(275, 292)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(100, 27)
        Me.txttax.TabIndex = 17
        '
        'txtamount
        '
        Me.txtamount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtamount.Location = New System.Drawing.Point(275, 328)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(100, 27)
        Me.txtamount.TabIndex = 15
        '
        'lblamount
        '
        Me.lblamount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblamount.AutoSize = True
        Me.lblamount.Location = New System.Drawing.Point(161, 331)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(63, 19)
        Me.lblamount.TabIndex = 12
        Me.lblamount.Text = "Amount:"
        '
        'lbltax
        '
        Me.lbltax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(179, 292)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(35, 19)
        Me.lbltax.TabIndex = 10
        Me.lbltax.Text = "Tax:"
        '
        'lblrecvqty
        '
        Me.lblrecvqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblrecvqty.AutoSize = True
        Me.lblrecvqty.Location = New System.Drawing.Point(109, 257)
        Me.lblrecvqty.Name = "lblrecvqty"
        Me.lblrecvqty.Size = New System.Drawing.Size(132, 19)
        Me.lblrecvqty.TabIndex = 9
        Me.lblrecvqty.Text = "Recieved Quantity:"
        '
        'lblorderqty
        '
        Me.lblorderqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblorderqty.AutoSize = True
        Me.lblorderqty.Location = New System.Drawing.Point(117, 222)
        Me.lblorderqty.Name = "lblorderqty"
        Me.lblorderqty.Size = New System.Drawing.Size(126, 19)
        Me.lblorderqty.TabIndex = 8
        Me.lblorderqty.Text = "Ordered Quantity:"
        '
        'lblrecvdate
        '
        Me.lblrecvdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblrecvdate.AutoSize = True
        Me.lblrecvdate.Location = New System.Drawing.Point(123, 185)
        Me.lblrecvdate.Name = "lblrecvdate"
        Me.lblrecvdate.Size = New System.Drawing.Size(111, 19)
        Me.lblrecvdate.TabIndex = 7
        Me.lblrecvdate.Text = "Recieving Date:"
        '
        'lblorderdate
        '
        Me.lblorderdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblorderdate.AutoSize = True
        Me.lblorderdate.Location = New System.Drawing.Point(145, 147)
        Me.lblorderdate.Name = "lblorderdate"
        Me.lblorderdate.Size = New System.Drawing.Size(85, 19)
        Me.lblorderdate.TabIndex = 6
        Me.lblorderdate.Text = "Order Date:"
        '
        'txtsuppname
        '
        Me.txtsuppname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsuppname.Location = New System.Drawing.Point(275, 110)
        Me.txtsuppname.Name = "txtsuppname"
        Me.txtsuppname.Size = New System.Drawing.Size(100, 27)
        Me.txtsuppname.TabIndex = 5
        '
        'lblsuppname
        '
        Me.lblsuppname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsuppname.AutoSize = True
        Me.lblsuppname.Location = New System.Drawing.Point(128, 110)
        Me.lblsuppname.Name = "lblsuppname"
        Me.lblsuppname.Size = New System.Drawing.Size(107, 19)
        Me.lblsuppname.TabIndex = 4
        Me.lblsuppname.Text = "Supplier Name:"
        '
        'txtsuppid
        '
        Me.txtsuppid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsuppid.Location = New System.Drawing.Point(275, 72)
        Me.txtsuppid.Name = "txtsuppid"
        Me.txtsuppid.Size = New System.Drawing.Size(100, 27)
        Me.txtsuppid.TabIndex = 3
        '
        'lblsuppid
        '
        Me.lblsuppid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsuppid.AutoSize = True
        Me.lblsuppid.Location = New System.Drawing.Point(147, 72)
        Me.lblsuppid.Name = "lblsuppid"
        Me.lblsuppid.Size = New System.Drawing.Size(81, 19)
        Me.lblsuppid.TabIndex = 2
        Me.lblsuppid.Text = "Supplier Id:"
        '
        'cmbpurorderno
        '
        Me.cmbpurorderno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbpurorderno.FormattingEnabled = True
        Me.cmbpurorderno.Location = New System.Drawing.Point(275, 35)
        Me.cmbpurorderno.Name = "cmbpurorderno"
        Me.cmbpurorderno.Size = New System.Drawing.Size(121, 27)
        Me.cmbpurorderno.TabIndex = 1
        '
        'grbcontrols
        '
        Me.grbcontrols.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbcontrols.Controls.Add(Me.btnsave)
        Me.grbcontrols.Controls.Add(Me.btnnew)
        Me.grbcontrols.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbcontrols.Location = New System.Drawing.Point(148, 454)
        Me.grbcontrols.Name = "grbcontrols"
        Me.grbcontrols.Size = New System.Drawing.Size(340, 90)
        Me.grbcontrols.TabIndex = 2
        Me.grbcontrols.TabStop = False
        Me.grbcontrols.Text = "Controls"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.Location = New System.Drawing.Point(194, 30)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 35)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnew.Location = New System.Drawing.Point(67, 30)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 35)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Purchase Order details"
        '
        'purchaseorderdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grbcontrols)
        Me.Controls.Add(Me.grbpodetails)
        Me.Name = "purchaseorderdetails"
        Me.Text = "Purchase Order Details"
        Me.grbpodetails.ResumeLayout(False)
        Me.grbpodetails.PerformLayout()
        Me.grbcontrols.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpurchaseorderno As System.Windows.Forms.Label
    Friend WithEvents grbpodetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbpurorderno As System.Windows.Forms.ComboBox
    Friend WithEvents lblrecvdate As System.Windows.Forms.Label
    Friend WithEvents lblorderdate As System.Windows.Forms.Label
    Friend WithEvents txtsuppname As System.Windows.Forms.TextBox
    Friend WithEvents lblsuppname As System.Windows.Forms.Label
    Friend WithEvents txtsuppid As System.Windows.Forms.TextBox
    Friend WithEvents lblsuppid As System.Windows.Forms.Label
    Friend WithEvents lblrecvqty As System.Windows.Forms.Label
    Friend WithEvents lblorderqty As System.Windows.Forms.Label
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents grbcontrols As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerorderdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerrecievingdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtorderqty As System.Windows.Forms.TextBox
    Friend WithEvents txtrecvqty As System.Windows.Forms.TextBox
    Friend WithEvents txttax As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
