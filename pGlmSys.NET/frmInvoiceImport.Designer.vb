<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInvoiceImport
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
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
	Public WithEvents txtAccount As System.Windows.Forms.TextBox
	Public WithEvents txtStoreNumber As System.Windows.Forms.TextBox
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cbStatusDesc As System.Windows.Forms.ComboBox
	Public WithEvents cbStatusFlag As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents dgPendingInvoices As AxMSDataGridLib.AxDataGrid
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lbRecordCount As System.Windows.Forms.Label
	Public WithEvents lbStatusFlag As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInvoiceImport))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtInvoiceNo = New System.Windows.Forms.TextBox
		Me.txtAccount = New System.Windows.Forms.TextBox
		Me.txtStoreNumber = New System.Windows.Forms.TextBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cbStatusDesc = New System.Windows.Forms.ComboBox
		Me.cbStatusFlag = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.dgPendingInvoices = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.lbRecordCount = New System.Windows.Forms.Label
		Me.lbStatusFlag = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgPendingInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Invoice Import"
		Me.ClientSize = New System.Drawing.Size(741, 533)
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
		Me.Name = "frmInvoiceImport"
		Me.cbState.Size = New System.Drawing.Size(57, 21)
		Me.cbState.Location = New System.Drawing.Point(424, 144)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 18
		Me.cbState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbState.BackColor = System.Drawing.SystemColors.Window
		Me.cbState.CausesValidation = True
		Me.cbState.Enabled = True
		Me.cbState.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbState.IntegralHeight = True
		Me.cbState.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbState.Sorted = False
		Me.cbState.TabStop = True
		Me.cbState.Visible = True
		Me.cbState.Name = "cbState"
		Me.txtInvoiceNo.AutoSize = False
		Me.txtInvoiceNo.Size = New System.Drawing.Size(185, 21)
		Me.txtInvoiceNo.Location = New System.Drawing.Point(424, 176)
		Me.txtInvoiceNo.TabIndex = 16
		Me.txtInvoiceNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoiceNo.AcceptsReturn = True
		Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInvoiceNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtInvoiceNo.CausesValidation = True
		Me.txtInvoiceNo.Enabled = True
		Me.txtInvoiceNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInvoiceNo.HideSelection = True
		Me.txtInvoiceNo.ReadOnly = False
		Me.txtInvoiceNo.Maxlength = 0
		Me.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInvoiceNo.MultiLine = False
		Me.txtInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInvoiceNo.TabStop = True
		Me.txtInvoiceNo.Visible = True
		Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInvoiceNo.Name = "txtInvoiceNo"
		Me.txtAccount.AutoSize = False
		Me.txtAccount.Size = New System.Drawing.Size(273, 21)
		Me.txtAccount.Location = New System.Drawing.Point(80, 176)
		Me.txtAccount.TabIndex = 15
		Me.txtAccount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccount.AcceptsReturn = True
		Me.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccount.BackColor = System.Drawing.SystemColors.Window
		Me.txtAccount.CausesValidation = True
		Me.txtAccount.Enabled = True
		Me.txtAccount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccount.HideSelection = True
		Me.txtAccount.ReadOnly = False
		Me.txtAccount.Maxlength = 0
		Me.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccount.MultiLine = False
		Me.txtAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccount.TabStop = True
		Me.txtAccount.Visible = True
		Me.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccount.Name = "txtAccount"
		Me.txtStoreNumber.AutoSize = False
		Me.txtStoreNumber.Size = New System.Drawing.Size(273, 21)
		Me.txtStoreNumber.Location = New System.Drawing.Point(80, 144)
		Me.txtStoreNumber.TabIndex = 12
		Me.txtStoreNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreNumber.AcceptsReturn = True
		Me.txtStoreNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreNumber.CausesValidation = True
		Me.txtStoreNumber.Enabled = True
		Me.txtStoreNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreNumber.HideSelection = True
		Me.txtStoreNumber.ReadOnly = False
		Me.txtStoreNumber.Maxlength = 0
		Me.txtStoreNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreNumber.MultiLine = False
		Me.txtStoreNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreNumber.TabStop = True
		Me.txtStoreNumber.Visible = True
		Me.txtStoreNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreNumber.Name = "txtStoreNumber"
		Me.cbVendor.Size = New System.Drawing.Size(449, 21)
		Me.cbVendor.Location = New System.Drawing.Point(80, 104)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 10
		Me.cbVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendor.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendor.CausesValidation = True
		Me.cbVendor.Enabled = True
		Me.cbVendor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendor.IntegralHeight = True
		Me.cbVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendor.Sorted = False
		Me.cbVendor.TabStop = True
		Me.cbVendor.Visible = True
		Me.cbVendor.Name = "cbVendor"
		Me.cbStatusDesc.Size = New System.Drawing.Size(225, 21)
		Me.cbStatusDesc.Location = New System.Drawing.Point(424, 72)
		Me.cbStatusDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStatusDesc.TabIndex = 7
		Me.cbStatusDesc.Visible = False
		Me.cbStatusDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStatusDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbStatusDesc.CausesValidation = True
		Me.cbStatusDesc.Enabled = True
		Me.cbStatusDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStatusDesc.IntegralHeight = True
		Me.cbStatusDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStatusDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStatusDesc.Sorted = False
		Me.cbStatusDesc.TabStop = True
		Me.cbStatusDesc.Name = "cbStatusDesc"
		Me.cbStatusFlag.Size = New System.Drawing.Size(225, 21)
		Me.cbStatusFlag.Location = New System.Drawing.Point(424, 48)
		Me.cbStatusFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStatusFlag.TabIndex = 6
		Me.cbStatusFlag.Visible = False
		Me.cbStatusFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStatusFlag.BackColor = System.Drawing.SystemColors.Window
		Me.cbStatusFlag.CausesValidation = True
		Me.cbStatusFlag.Enabled = True
		Me.cbStatusFlag.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStatusFlag.IntegralHeight = True
		Me.cbStatusFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStatusFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStatusFlag.Sorted = False
		Me.cbStatusFlag.TabStop = True
		Me.cbStatusFlag.Name = "cbStatusFlag"
		Me.cbCustId.Size = New System.Drawing.Size(177, 21)
		Me.cbCustId.Location = New System.Drawing.Point(80, 48)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 4
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
		Me.cbCustName.Size = New System.Drawing.Size(273, 21)
		Me.cbCustName.Location = New System.Drawing.Point(80, 72)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 3
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
		dgPendingInvoices.OcxState = CType(resources.GetObject("dgPendingInvoices.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgPendingInvoices.Size = New System.Drawing.Size(697, 305)
		Me.dgPendingInvoices.Location = New System.Drawing.Point(24, 216)
		Me.dgPendingInvoices.TabIndex = 1
		Me.dgPendingInvoices.Name = "dgPendingInvoices"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(741, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 0
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me.Label6.Text = "State"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.Location = New System.Drawing.Point(376, 144)
		Me.Label6.TabIndex = 17
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Invoice Number"
		Me.Label5.Size = New System.Drawing.Size(41, 33)
		Me.Label5.Location = New System.Drawing.Point(376, 176)
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
		Me.Label4.Text = "Account"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 176)
		Me.Label4.TabIndex = 13
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
		Me.Label3.Text = "Store Number"
		Me.Label3.Size = New System.Drawing.Size(49, 25)
		Me.Label3.Location = New System.Drawing.Point(24, 144)
		Me.Label3.TabIndex = 11
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
		Me.Label2.Text = "Vendor"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 104)
		Me.Label2.TabIndex = 9
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
		Me.lbRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lbRecordCount.Text = "Total Records:"
		Me.lbRecordCount.Size = New System.Drawing.Size(105, 25)
		Me.lbRecordCount.Location = New System.Drawing.Point(616, 184)
		Me.lbRecordCount.TabIndex = 8
		Me.lbRecordCount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbRecordCount.BackColor = System.Drawing.SystemColors.Control
		Me.lbRecordCount.Enabled = True
		Me.lbRecordCount.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbRecordCount.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbRecordCount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbRecordCount.UseMnemonic = True
		Me.lbRecordCount.Visible = True
		Me.lbRecordCount.AutoSize = False
		Me.lbRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbRecordCount.Name = "lbRecordCount"
		Me.lbStatusFlag.Text = "Status"
		Me.lbStatusFlag.Size = New System.Drawing.Size(41, 17)
		Me.lbStatusFlag.Location = New System.Drawing.Point(376, 72)
		Me.lbStatusFlag.TabIndex = 5
		Me.lbStatusFlag.Visible = False
		Me.lbStatusFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbStatusFlag.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbStatusFlag.BackColor = System.Drawing.SystemColors.Control
		Me.lbStatusFlag.Enabled = True
		Me.lbStatusFlag.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbStatusFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbStatusFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbStatusFlag.UseMnemonic = True
		Me.lbStatusFlag.AutoSize = False
		Me.lbStatusFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbStatusFlag.Name = "lbStatusFlag"
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 72)
		Me.Label1.TabIndex = 2
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
		Me.Controls.Add(cbState)
		Me.Controls.Add(txtInvoiceNo)
		Me.Controls.Add(txtAccount)
		Me.Controls.Add(txtStoreNumber)
		Me.Controls.Add(cbVendor)
		Me.Controls.Add(cbStatusDesc)
		Me.Controls.Add(cbStatusFlag)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(dgPendingInvoices)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(lbRecordCount)
		Me.Controls.Add(lbStatusFlag)
		Me.Controls.Add(Label1)
		CType(Me.dgPendingInvoices, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class