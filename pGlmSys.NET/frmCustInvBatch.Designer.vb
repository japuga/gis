<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustInvBatch
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cbStoreGroup As System.Windows.Forms.ComboBox
	Public WithEvents dtTo As AxMSComCtl2.AxDTPicker
	Public WithEvents dtFrom As AxMSComCtl2.AxDTPicker
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents frInvoiceDates As System.Windows.Forms.GroupBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbPeriod As System.Windows.Forms.ComboBox
	Public WithEvents cbFill As System.Windows.Forms.Button
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents ckInvoiceDates As System.Windows.Forms.CheckBox
	Public WithEvents dgBatch As AxMSDataGridLib.AxDataGrid
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustInvBatch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbStoreGroup = New System.Windows.Forms.ComboBox
		Me.frInvoiceDates = New System.Windows.Forms.GroupBox
		Me.dtTo = New AxMSComCtl2.AxDTPicker
		Me.dtFrom = New AxMSComCtl2.AxDTPicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbPeriod = New System.Windows.Forms.ComboBox
		Me.cbFill = New System.Windows.Forms.Button
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.ckInvoiceDates = New System.Windows.Forms.CheckBox
		Me.dgBatch = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.frInvoiceDates.SuspendLayout()
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtTo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgBatch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "MS-Word Customer Invoices"
		Me.ClientSize = New System.Drawing.Size(752, 457)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCustInvBatch"
		Me.cbStoreGroup.Size = New System.Drawing.Size(169, 21)
		Me.cbStoreGroup.Location = New System.Drawing.Point(104, 96)
		Me.cbStoreGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStoreGroup.TabIndex = 15
		Me.cbStoreGroup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStoreGroup.BackColor = System.Drawing.SystemColors.Window
		Me.cbStoreGroup.CausesValidation = True
		Me.cbStoreGroup.Enabled = True
		Me.cbStoreGroup.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStoreGroup.IntegralHeight = True
		Me.cbStoreGroup.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStoreGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStoreGroup.Sorted = False
		Me.cbStoreGroup.TabStop = True
		Me.cbStoreGroup.Visible = True
		Me.cbStoreGroup.Name = "cbStoreGroup"
		Me.frInvoiceDates.Text = "Search For"
		Me.frInvoiceDates.Enabled = False
		Me.frInvoiceDates.Size = New System.Drawing.Size(425, 89)
		Me.frInvoiceDates.Location = New System.Drawing.Point(24, 152)
		Me.frInvoiceDates.TabIndex = 6
		Me.frInvoiceDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frInvoiceDates.BackColor = System.Drawing.SystemColors.Control
		Me.frInvoiceDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frInvoiceDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frInvoiceDates.Visible = True
		Me.frInvoiceDates.Name = "frInvoiceDates"
		dtTo.OcxState = CType(resources.GetObject("dtTo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtTo.Size = New System.Drawing.Size(97, 25)
		Me.dtTo.Location = New System.Drawing.Point(296, 32)
		Me.dtTo.TabIndex = 7
		Me.dtTo.Name = "dtTo"
		dtFrom.OcxState = CType(resources.GetObject("dtFrom.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtFrom.Size = New System.Drawing.Size(97, 25)
		Me.dtFrom.Location = New System.Drawing.Point(72, 32)
		Me.dtFrom.TabIndex = 8
		Me.dtFrom.Name = "dtFrom"
		Me.Label2.Text = "From"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 32)
		Me.Label2.TabIndex = 10
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.Text = "To"
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(248, 40)
		Me.Label3.TabIndex = 9
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.cbCustName.Size = New System.Drawing.Size(137, 21)
		Me.cbCustName.Location = New System.Drawing.Point(104, 64)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 5
		Me.cbCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustName.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustName.CausesValidation = True
		Me.cbCustName.Enabled = True
		Me.cbCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustName.IntegralHeight = True
		Me.cbCustName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustName.Sorted = False
		Me.cbCustName.TabStop = True
		Me.cbCustName.Visible = True
		Me.cbCustName.Name = "cbCustName"
		Me.cbPeriod.Size = New System.Drawing.Size(137, 21)
		Me.cbPeriod.Location = New System.Drawing.Point(312, 64)
		Me.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriod.TabIndex = 4
		Me.cbPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPeriod.BackColor = System.Drawing.SystemColors.Window
		Me.cbPeriod.CausesValidation = True
		Me.cbPeriod.Enabled = True
		Me.cbPeriod.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbPeriod.IntegralHeight = True
		Me.cbPeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbPeriod.Sorted = False
		Me.cbPeriod.TabStop = True
		Me.cbPeriod.Visible = True
		Me.cbPeriod.Name = "cbPeriod"
		Me.cbFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cbFill.Text = "Apply Filter"
		Me.cbFill.Size = New System.Drawing.Size(97, 33)
		Me.cbFill.Location = New System.Drawing.Point(512, 160)
		Me.cbFill.TabIndex = 2
		Me.cbFill.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbFill.BackColor = System.Drawing.SystemColors.Control
		Me.cbFill.CausesValidation = True
		Me.cbFill.Enabled = True
		Me.cbFill.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cbFill.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbFill.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbFill.TabStop = True
		Me.cbFill.Name = "cbFill"
		Me.cbCustId.Size = New System.Drawing.Size(73, 21)
		Me.cbCustId.Location = New System.Drawing.Point(504, 64)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 1
		Me.cbCustId.Visible = False
		Me.cbCustId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustId.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustId.CausesValidation = True
		Me.cbCustId.Enabled = True
		Me.cbCustId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustId.IntegralHeight = True
		Me.cbCustId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustId.Sorted = False
		Me.cbCustId.TabStop = True
		Me.cbCustId.Name = "cbCustId"
		Me.ckInvoiceDates.Text = "Invoice Dates"
		Me.ckInvoiceDates.Size = New System.Drawing.Size(113, 17)
		Me.ckInvoiceDates.Location = New System.Drawing.Point(24, 128)
		Me.ckInvoiceDates.TabIndex = 0
		Me.ckInvoiceDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckInvoiceDates.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckInvoiceDates.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckInvoiceDates.BackColor = System.Drawing.SystemColors.Control
		Me.ckInvoiceDates.CausesValidation = True
		Me.ckInvoiceDates.Enabled = True
		Me.ckInvoiceDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckInvoiceDates.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckInvoiceDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckInvoiceDates.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckInvoiceDates.TabStop = True
		Me.ckInvoiceDates.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckInvoiceDates.Visible = True
		Me.ckInvoiceDates.Name = "ckInvoiceDates"
		dgBatch.OcxState = CType(resources.GetObject("dgBatch.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgBatch.Size = New System.Drawing.Size(689, 185)
		Me.dgBatch.Location = New System.Drawing.Point(24, 256)
		Me.dgBatch.TabIndex = 3
		Me.dgBatch.Name = "dgBatch"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(752, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 13
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button4.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button4.AutoSize = False
		Me._Toolbar1_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Label5.Text = "Store Group"
		Me.Label5.Size = New System.Drawing.Size(65, 17)
		Me.Label5.Location = New System.Drawing.Point(24, 96)
		Me.Label5.TabIndex = 14
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 64)
		Me.Label1.TabIndex = 12
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label4.Text = "Period"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(272, 64)
		Me.Label4.TabIndex = 11
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Controls.Add(cbStoreGroup)
		Me.Controls.Add(frInvoiceDates)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(cbPeriod)
		Me.Controls.Add(cbFill)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(ckInvoiceDates)
		Me.Controls.Add(dgBatch)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label4)
		Me.frInvoiceDates.Controls.Add(dtTo)
		Me.frInvoiceDates.Controls.Add(dtFrom)
		Me.frInvoiceDates.Controls.Add(Label2)
		Me.frInvoiceDates.Controls.Add(Label3)
		Me.Toolbar1.Items.Add(_Toolbar1_Button4)
		CType(Me.dgBatch, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtTo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.frInvoiceDates.ResumeLayout(False)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class