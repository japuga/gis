<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInvoiceBooking
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
	Public WithEvents cmdEdit As System.Windows.Forms.Button
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents txtExtc As System.Windows.Forms.TextBox
	Public WithEvents txtSc As System.Windows.Forms.TextBox
	Public WithEvents cbGroupName As System.Windows.Forms.ComboBox
	Public WithEvents txtWorkOrderNo As System.Windows.Forms.TextBox
	Public WithEvents cbPeriod As System.Windows.Forms.ComboBox
	Public WithEvents txtYearPeriod As System.Windows.Forms.TextBox
	Public WithEvents cbMonthPeriod As System.Windows.Forms.ComboBox
	Public WithEvents txtStoreId As System.Windows.Forms.TextBox
	Public WithEvents cbAccount As System.Windows.Forms.ComboBox
	Public WithEvents txtInvoice As System.Windows.Forms.TextBox
	Public WithEvents txtStore As System.Windows.Forms.TextBox
	Public WithEvents dtDate As AxMSComCtl2.AxDTPicker
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cmdHelpCustomer As System.Windows.Forms.Button
	Public WithEvents cbCustomer As System.Windows.Forms.ComboBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents lbEndDate As System.Windows.Forms.Label
	Public WithEvents lbStartDate As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents label5 As System.Windows.Forms.Label
	Public WithEvents lVendorName As System.Windows.Forms.Label
	Public WithEvents lVendorAddress As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents frHeader As System.Windows.Forms.GroupBox
	Public WithEvents txtGlmTotal As System.Windows.Forms.MaskedTextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents cmdNotes As System.Windows.Forms.Button
	Public WithEvents cmdDrop As System.Windows.Forms.Button
	Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents cbEquipment As System.Windows.Forms.ComboBox
	Public WithEvents cbService As System.Windows.Forms.ComboBox
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents txtTotal As System.Windows.Forms.MaskedTextBox
	Public WithEvents dgDetail As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents lblTotal As System.Windows.Forms.Label
	Public WithEvents frDetail As System.Windows.Forms.Panel
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInvoiceBooking))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdEdit = New System.Windows.Forms.Button
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me.frHeader = New System.Windows.Forms.GroupBox
		Me.txtExtc = New System.Windows.Forms.TextBox
		Me.txtSc = New System.Windows.Forms.TextBox
		Me.cbGroupName = New System.Windows.Forms.ComboBox
		Me.txtWorkOrderNo = New System.Windows.Forms.TextBox
		Me.cbPeriod = New System.Windows.Forms.ComboBox
		Me.txtYearPeriod = New System.Windows.Forms.TextBox
		Me.cbMonthPeriod = New System.Windows.Forms.ComboBox
		Me.txtStoreId = New System.Windows.Forms.TextBox
		Me.cbAccount = New System.Windows.Forms.ComboBox
		Me.txtInvoice = New System.Windows.Forms.TextBox
		Me.txtStore = New System.Windows.Forms.TextBox
		Me.dtDate = New AxMSComCtl2.AxDTPicker
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cmdHelpCustomer = New System.Windows.Forms.Button
		Me.cbCustomer = New System.Windows.Forms.ComboBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.lbEndDate = New System.Windows.Forms.Label
		Me.lbStartDate = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.label5 = New System.Windows.Forms.Label
		Me.lVendorName = New System.Windows.Forms.Label
		Me.lVendorAddress = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.frDetail = New System.Windows.Forms.Panel
		Me.txtGlmTotal = New System.Windows.Forms.MaskedTextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.cmdNotes = New System.Windows.Forms.Button
		Me.cmdDrop = New System.Windows.Forms.Button
		Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.cbEquipment = New System.Windows.Forms.ComboBox
		Me.cbService = New System.Windows.Forms.ComboBox
		Me.cmdAdd = New System.Windows.Forms.Button
		Me.txtTotal = New System.Windows.Forms.MaskedTextBox
		Me.dgDetail = New AxMSDataGridLib.AxDataGrid
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.lblTotal = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.frHeader.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.frDetail.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Invoice Booking"
		Me.ClientSize = New System.Drawing.Size(699, 498)
		Me.Location = New System.Drawing.Point(66, 83)
		Me.ForeColor = System.Drawing.SystemColors.highlightText
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
		Me.Name = "frmInvoiceBooking"
		Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEdit.Text = "Edit"
		Me.cmdEdit.Size = New System.Drawing.Size(57, 25)
		Me.cmdEdit.Location = New System.Drawing.Point(80, 432)
		Me.cmdEdit.TabIndex = 34
		Me.ToolTip1.SetToolTip(Me.cmdEdit, "Enter invoice comments")
		Me.cmdEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEdit.CausesValidation = True
		Me.cmdEdit.Enabled = True
		Me.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEdit.TabStop = True
		Me.cmdEdit.Name = "cmdEdit"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(699, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 22
        '		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button5.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button5.AutoSize = False
		Me._Toolbar1_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button5.Width = 10
		Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.frHeader.Text = "General Information"
		Me.frHeader.Size = New System.Drawing.Size(665, 177)
		Me.frHeader.Location = New System.Drawing.Point(8, 64)
		Me.frHeader.TabIndex = 0
		Me.frHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frHeader.BackColor = System.Drawing.SystemColors.Control
		Me.frHeader.Enabled = True
		Me.frHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frHeader.Visible = True
		Me.frHeader.Name = "frHeader"
		Me.txtExtc.AutoSize = False
		Me.txtExtc.Size = New System.Drawing.Size(49, 19)
		Me.txtExtc.Location = New System.Drawing.Point(520, 152)
		Me.txtExtc.TabIndex = 50
		Me.txtExtc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExtc.AcceptsReturn = True
		Me.txtExtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExtc.BackColor = System.Drawing.SystemColors.Window
		Me.txtExtc.CausesValidation = True
		Me.txtExtc.Enabled = True
		Me.txtExtc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExtc.HideSelection = True
		Me.txtExtc.ReadOnly = False
		Me.txtExtc.Maxlength = 0
		Me.txtExtc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExtc.MultiLine = False
		Me.txtExtc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExtc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExtc.TabStop = True
		Me.txtExtc.Visible = True
		Me.txtExtc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExtc.Name = "txtExtc"
		Me.txtSc.AutoSize = False
		Me.txtSc.Size = New System.Drawing.Size(57, 19)
		Me.txtSc.Location = New System.Drawing.Point(400, 152)
		Me.txtSc.TabIndex = 48
		Me.txtSc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSc.AcceptsReturn = True
		Me.txtSc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSc.BackColor = System.Drawing.SystemColors.Window
		Me.txtSc.CausesValidation = True
		Me.txtSc.Enabled = True
		Me.txtSc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSc.HideSelection = True
		Me.txtSc.ReadOnly = False
		Me.txtSc.Maxlength = 0
		Me.txtSc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSc.MultiLine = False
		Me.txtSc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSc.TabStop = True
		Me.txtSc.Visible = True
		Me.txtSc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSc.Name = "txtSc"
		Me.cbGroupName.Size = New System.Drawing.Size(113, 21)
		Me.cbGroupName.Location = New System.Drawing.Point(248, 152)
		Me.cbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbGroupName.TabIndex = 43
		Me.cbGroupName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbGroupName.BackColor = System.Drawing.SystemColors.Window
		Me.cbGroupName.CausesValidation = True
		Me.cbGroupName.Enabled = True
		Me.cbGroupName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbGroupName.IntegralHeight = True
		Me.cbGroupName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbGroupName.Sorted = False
		Me.cbGroupName.TabStop = True
		Me.cbGroupName.Visible = True
		Me.cbGroupName.Name = "cbGroupName"
		Me.txtWorkOrderNo.AutoSize = False
		Me.txtWorkOrderNo.Size = New System.Drawing.Size(145, 21)
		Me.txtWorkOrderNo.Location = New System.Drawing.Point(56, 152)
		Me.txtWorkOrderNo.TabIndex = 41
		Me.txtWorkOrderNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWorkOrderNo.AcceptsReturn = True
		Me.txtWorkOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWorkOrderNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtWorkOrderNo.CausesValidation = True
		Me.txtWorkOrderNo.Enabled = True
		Me.txtWorkOrderNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWorkOrderNo.HideSelection = True
		Me.txtWorkOrderNo.ReadOnly = False
		Me.txtWorkOrderNo.Maxlength = 0
		Me.txtWorkOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWorkOrderNo.MultiLine = False
		Me.txtWorkOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWorkOrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWorkOrderNo.TabStop = True
		Me.txtWorkOrderNo.Visible = True
		Me.txtWorkOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWorkOrderNo.Name = "txtWorkOrderNo"
		Me.cbPeriod.Size = New System.Drawing.Size(201, 21)
		Me.cbPeriod.Location = New System.Drawing.Point(440, 88)
		Me.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriod.TabIndex = 35
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
		Me.txtYearPeriod.AutoSize = False
		Me.txtYearPeriod.Size = New System.Drawing.Size(57, 21)
		Me.txtYearPeriod.Location = New System.Drawing.Point(504, 176)
		Me.txtYearPeriod.ReadOnly = True
		Me.txtYearPeriod.TabIndex = 32
		Me.txtYearPeriod.Visible = False
		Me.txtYearPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtYearPeriod.AcceptsReturn = True
		Me.txtYearPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtYearPeriod.BackColor = System.Drawing.SystemColors.Window
		Me.txtYearPeriod.CausesValidation = True
		Me.txtYearPeriod.Enabled = True
		Me.txtYearPeriod.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtYearPeriod.HideSelection = True
		Me.txtYearPeriod.Maxlength = 0
		Me.txtYearPeriod.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtYearPeriod.MultiLine = False
		Me.txtYearPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtYearPeriod.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtYearPeriod.TabStop = True
		Me.txtYearPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtYearPeriod.Name = "txtYearPeriod"
		Me.cbMonthPeriod.Size = New System.Drawing.Size(81, 21)
		Me.cbMonthPeriod.Location = New System.Drawing.Point(584, 40)
		Me.cbMonthPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbMonthPeriod.TabIndex = 31
		Me.cbMonthPeriod.Visible = False
		Me.cbMonthPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbMonthPeriod.BackColor = System.Drawing.SystemColors.Window
		Me.cbMonthPeriod.CausesValidation = True
		Me.cbMonthPeriod.Enabled = True
		Me.cbMonthPeriod.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbMonthPeriod.IntegralHeight = True
		Me.cbMonthPeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbMonthPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbMonthPeriod.Sorted = False
		Me.cbMonthPeriod.TabStop = True
		Me.cbMonthPeriod.Name = "cbMonthPeriod"
		Me.txtStoreId.AutoSize = False
		Me.txtStoreId.BackColor = System.Drawing.SystemColors.Menu
		Me.txtStoreId.Size = New System.Drawing.Size(57, 19)
		Me.txtStoreId.Location = New System.Drawing.Point(600, 16)
		Me.txtStoreId.ReadOnly = True
		Me.txtStoreId.TabIndex = 24
		Me.txtStoreId.TabStop = False
		Me.txtStoreId.Visible = False
		Me.txtStoreId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreId.AcceptsReturn = True
		Me.txtStoreId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreId.CausesValidation = True
		Me.txtStoreId.Enabled = True
		Me.txtStoreId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreId.HideSelection = True
		Me.txtStoreId.Maxlength = 0
		Me.txtStoreId.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreId.MultiLine = False
		Me.txtStoreId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreId.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreId.Name = "txtStoreId"
		Me.cbAccount.Size = New System.Drawing.Size(289, 21)
		Me.cbAccount.Location = New System.Drawing.Point(56, 88)
		Me.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAccount.TabIndex = 6
		Me.cbAccount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbAccount.BackColor = System.Drawing.SystemColors.Window
		Me.cbAccount.CausesValidation = True
		Me.cbAccount.Enabled = True
		Me.cbAccount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbAccount.IntegralHeight = True
		Me.cbAccount.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbAccount.Sorted = False
		Me.cbAccount.TabStop = True
		Me.cbAccount.Visible = True
		Me.cbAccount.Name = "cbAccount"
		Me.txtInvoice.AutoSize = False
		Me.txtInvoice.Size = New System.Drawing.Size(145, 21)
		Me.txtInvoice.Location = New System.Drawing.Point(56, 120)
		Me.txtInvoice.Maxlength = 20
		Me.txtInvoice.TabIndex = 7
		Me.txtInvoice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoice.AcceptsReturn = True
		Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInvoice.BackColor = System.Drawing.SystemColors.Window
		Me.txtInvoice.CausesValidation = True
		Me.txtInvoice.Enabled = True
		Me.txtInvoice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInvoice.HideSelection = True
		Me.txtInvoice.ReadOnly = False
		Me.txtInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInvoice.MultiLine = False
		Me.txtInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInvoice.TabStop = True
		Me.txtInvoice.Visible = True
		Me.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInvoice.Name = "txtInvoice"
		Me.txtStore.AutoSize = False
		Me.txtStore.Size = New System.Drawing.Size(73, 21)
		Me.txtStore.Location = New System.Drawing.Point(240, 24)
		Me.txtStore.TabIndex = 3
		Me.txtStore.Text = "Store#"
		Me.txtStore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStore.AcceptsReturn = True
		Me.txtStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStore.BackColor = System.Drawing.SystemColors.Window
		Me.txtStore.CausesValidation = True
		Me.txtStore.Enabled = True
		Me.txtStore.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStore.HideSelection = True
		Me.txtStore.ReadOnly = False
		Me.txtStore.Maxlength = 0
		Me.txtStore.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStore.MultiLine = False
		Me.txtStore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStore.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStore.TabStop = True
		Me.txtStore.Visible = True
		Me.txtStore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStore.Name = "txtStore"
		dtDate.OcxState = CType(resources.GetObject("dtDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtDate.Size = New System.Drawing.Size(97, 21)
		Me.dtDate.Location = New System.Drawing.Point(248, 120)
		Me.dtDate.TabIndex = 8
		Me.dtDate.Name = "dtDate"
		Me.cbState.Size = New System.Drawing.Size(49, 21)
		Me.cbState.Location = New System.Drawing.Point(152, 24)
		Me.cbState.TabIndex = 2
		Me.cbState.Text = "State"
		Me.cbState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbState.BackColor = System.Drawing.SystemColors.Window
		Me.cbState.CausesValidation = True
		Me.cbState.Enabled = True
		Me.cbState.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbState.IntegralHeight = True
		Me.cbState.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbState.Sorted = False
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cbState.TabStop = True
		Me.cbState.Visible = True
		Me.cbState.Name = "cbState"
		Me.cbVendor.Size = New System.Drawing.Size(289, 21)
		Me.cbVendor.Location = New System.Drawing.Point(56, 56)
		Me.cbVendor.Items.AddRange(New Object(){"cbVendor"})
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 5
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
		Me.cmdHelpCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdHelpCustomer.Size = New System.Drawing.Size(33, 21)
		Me.cmdHelpCustomer.Location = New System.Drawing.Point(320, 24)
		Me.cmdHelpCustomer.Image = CType(resources.GetObject("cmdHelpCustomer.Image"), System.Drawing.Image)
		Me.cmdHelpCustomer.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.cmdHelpCustomer, "List of Stores")
		Me.cmdHelpCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdHelpCustomer.BackColor = System.Drawing.SystemColors.Control
		Me.cmdHelpCustomer.CausesValidation = True
		Me.cmdHelpCustomer.Enabled = True
		Me.cmdHelpCustomer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdHelpCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdHelpCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdHelpCustomer.TabStop = True
		Me.cmdHelpCustomer.Name = "cmdHelpCustomer"
		Me.cbCustomer.Size = New System.Drawing.Size(89, 21)
		Me.cbCustomer.Location = New System.Drawing.Point(56, 24)
		Me.cbCustomer.TabIndex = 1
		Me.cbCustomer.Text = "Customer"
		Me.cbCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustomer.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustomer.CausesValidation = True
		Me.cbCustomer.Enabled = True
		Me.cbCustomer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustomer.IntegralHeight = True
		Me.cbCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustomer.Sorted = False
		Me.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cbCustomer.TabStop = True
		Me.cbCustomer.Visible = True
		Me.cbCustomer.Name = "cbCustomer"
		Me.Label15.Text = "EXTC"
		Me.Label15.Size = New System.Drawing.Size(33, 17)
		Me.Label15.Location = New System.Drawing.Point(480, 152)
		Me.Label15.TabIndex = 49
		Me.Label15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label14.Text = "SC"
		Me.Label14.Size = New System.Drawing.Size(17, 17)
		Me.Label14.Location = New System.Drawing.Point(376, 152)
		Me.Label14.TabIndex = 47
		Me.Label14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label11.Text = "Group"
		Me.Label11.Size = New System.Drawing.Size(33, 17)
		Me.Label11.Location = New System.Drawing.Point(208, 152)
		Me.Label11.TabIndex = 42
		Me.Label11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label10.Text = "Work Order #"
		Me.Label10.Size = New System.Drawing.Size(41, 25)
		Me.Label10.Location = New System.Drawing.Point(8, 144)
		Me.Label10.TabIndex = 40
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label9.Text = "To"
		Me.Label9.Size = New System.Drawing.Size(17, 17)
		Me.Label9.Location = New System.Drawing.Point(512, 120)
		Me.Label9.TabIndex = 39
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label6.Text = "From"
		Me.Label6.Size = New System.Drawing.Size(25, 17)
		Me.Label6.Location = New System.Drawing.Point(400, 120)
		Me.Label6.TabIndex = 38
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
		Me.lbEndDate.Text = "lbEndDate"
		Me.lbEndDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbEndDate.Size = New System.Drawing.Size(81, 17)
		Me.lbEndDate.Location = New System.Drawing.Point(536, 120)
		Me.lbEndDate.TabIndex = 37
		Me.lbEndDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbEndDate.BackColor = System.Drawing.SystemColors.Control
		Me.lbEndDate.Enabled = True
		Me.lbEndDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbEndDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbEndDate.UseMnemonic = True
		Me.lbEndDate.Visible = True
		Me.lbEndDate.AutoSize = False
		Me.lbEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbEndDate.Name = "lbEndDate"
		Me.lbStartDate.Text = "lbStartDate"
		Me.lbStartDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbStartDate.Size = New System.Drawing.Size(81, 17)
		Me.lbStartDate.Location = New System.Drawing.Point(432, 120)
		Me.lbStartDate.TabIndex = 36
		Me.lbStartDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbStartDate.BackColor = System.Drawing.SystemColors.Control
		Me.lbStartDate.Enabled = True
		Me.lbStartDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbStartDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbStartDate.UseMnemonic = True
		Me.lbStartDate.Visible = True
		Me.lbStartDate.AutoSize = False
		Me.lbStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbStartDate.Name = "lbStartDate"
		Me.Label8.Text = "Store"
		Me.Label8.Size = New System.Drawing.Size(25, 17)
		Me.Label8.Location = New System.Drawing.Point(208, 26)
		Me.Label8.TabIndex = 29
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label7.Text = "Cust"
		Me.Label7.Size = New System.Drawing.Size(25, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 26)
		Me.Label7.TabIndex = 28
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label3.Text = "Vendor"
		Me.Label3.Size = New System.Drawing.Size(41, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 58)
		Me.Label3.TabIndex = 23
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
		Me.Label1.Text = "Invoice #"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 122)
		Me.Label1.TabIndex = 21
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
		Me.label5.Text = "Service Period"
		Me.label5.Size = New System.Drawing.Size(73, 17)
		Me.label5.Location = New System.Drawing.Point(360, 88)
		Me.label5.TabIndex = 20
		Me.label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label5.BackColor = System.Drawing.SystemColors.Control
		Me.label5.Enabled = True
		Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label5.UseMnemonic = True
		Me.label5.Visible = True
		Me.label5.AutoSize = False
		Me.label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label5.Name = "label5"
		Me.lVendorName.Text = "Vendor Name Xxxxxx Xxxxxxxxxxx"
		Me.lVendorName.Size = New System.Drawing.Size(161, 17)
		Me.lVendorName.Location = New System.Drawing.Point(320, 176)
		Me.lVendorName.TabIndex = 19
		Me.lVendorName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lVendorName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lVendorName.BackColor = System.Drawing.SystemColors.Control
		Me.lVendorName.Enabled = True
		Me.lVendorName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lVendorName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lVendorName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lVendorName.UseMnemonic = True
		Me.lVendorName.Visible = True
		Me.lVendorName.AutoSize = False
		Me.lVendorName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lVendorName.Name = "lVendorName"
		Me.lVendorAddress.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.lVendorAddress.Text = "Store Address Xxxxxxxxxxxxxxxxxxxxxxxxxx"
		Me.lVendorAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lVendorAddress.Size = New System.Drawing.Size(281, 53)
		Me.lVendorAddress.Location = New System.Drawing.Point(360, 24)
		Me.lVendorAddress.TabIndex = 18
		Me.lVendorAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lVendorAddress.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lVendorAddress.Enabled = True
		Me.lVendorAddress.Cursor = System.Windows.Forms.Cursors.Default
		Me.lVendorAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lVendorAddress.UseMnemonic = True
		Me.lVendorAddress.Visible = True
		Me.lVendorAddress.AutoSize = False
		Me.lVendorAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lVendorAddress.Name = "lVendorAddress"
		Me.Label4.Text = "Date"
		Me.Label4.Size = New System.Drawing.Size(25, 17)
		Me.Label4.Location = New System.Drawing.Point(208, 120)
		Me.Label4.TabIndex = 15
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
		Me.Label2.Text = "Acc#"
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 88)
		Me.Label2.TabIndex = 13
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
		Me.Frame1.Size = New System.Drawing.Size(681, 433)
		Me.Frame1.Location = New System.Drawing.Point(8, 56)
		Me.Frame1.TabIndex = 12
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.frDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.frDetail.Text = "Detail"
		Me.frDetail.Size = New System.Drawing.Size(665, 257)
		Me.frDetail.Location = New System.Drawing.Point(8, 152)
		Me.frDetail.TabIndex = 14
		Me.frDetail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frDetail.BackColor = System.Drawing.SystemColors.Control
		Me.frDetail.Enabled = True
		Me.frDetail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frDetail.Cursor = System.Windows.Forms.Cursors.Default
		Me.frDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frDetail.Visible = True
		Me.frDetail.Name = "frDetail"
		Me.txtGlmTotal.AllowPromptAsInput = False
		Me.txtGlmTotal.Size = New System.Drawing.Size(113, 25)
		Me.txtGlmTotal.Location = New System.Drawing.Point(336, 224)
		Me.txtGlmTotal.TabIndex = 46
		Me.txtGlmTotal.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.txtGlmTotal.PromptChar = "_"
		Me.txtGlmTotal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGlmTotal.Name = "txtGlmTotal"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(97, 169)
		Me.Text1.Location = New System.Drawing.Point(528, 24)
		Me.Text1.MultiLine = True
		Me.Text1.TabIndex = 33
		Me.Text1.Visible = False
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.cmdNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNotes.Text = "Notes"
		Me.cmdNotes.Size = New System.Drawing.Size(57, 25)
		Me.cmdNotes.Location = New System.Drawing.Point(192, 224)
		Me.cmdNotes.TabIndex = 30
		Me.ToolTip1.SetToolTip(Me.cmdNotes, "Enter invoice comments")
		Me.cmdNotes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNotes.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNotes.CausesValidation = True
		Me.cmdNotes.Enabled = True
		Me.cmdNotes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNotes.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNotes.TabStop = True
		Me.cmdNotes.Name = "cmdNotes"
		Me.cmdDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDrop.Text = "Delete"
		Me.cmdDrop.Size = New System.Drawing.Size(57, 25)
		Me.cmdDrop.Location = New System.Drawing.Point(128, 224)
		Me.cmdDrop.TabIndex = 11
		Me.ToolTip1.SetToolTip(Me.cmdDrop, "Delete a detail from the invoice")
		Me.cmdDrop.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDrop.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDrop.CausesValidation = True
		Me.cmdDrop.Enabled = True
		Me.cmdDrop.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDrop.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDrop.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDrop.TabStop = True
		Me.cmdDrop.Name = "cmdDrop"
		DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DataGrid1.Size = New System.Drawing.Size(329, 81)
		Me.DataGrid1.Location = New System.Drawing.Point(192, 80)
		Me.DataGrid1.TabIndex = 27
		Me.DataGrid1.Visible = False
		Me.DataGrid1.Name = "DataGrid1"
		Me.cbEquipment.Size = New System.Drawing.Size(81, 21)
		Me.cbEquipment.Location = New System.Drawing.Point(16, 128)
		Me.cbEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEquipment.TabIndex = 26
		Me.cbEquipment.TabStop = False
		Me.cbEquipment.Visible = False
		Me.cbEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEquipment.BackColor = System.Drawing.SystemColors.Window
		Me.cbEquipment.CausesValidation = True
		Me.cbEquipment.Enabled = True
		Me.cbEquipment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEquipment.IntegralHeight = True
		Me.cbEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEquipment.Sorted = False
		Me.cbEquipment.Name = "cbEquipment"
		Me.cbService.Size = New System.Drawing.Size(81, 21)
		Me.cbService.Location = New System.Drawing.Point(24, 160)
		Me.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbService.TabIndex = 25
		Me.cbService.TabStop = False
		Me.cbService.Visible = False
		Me.cbService.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbService.BackColor = System.Drawing.SystemColors.Window
		Me.cbService.CausesValidation = True
		Me.cbService.Enabled = True
		Me.cbService.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbService.IntegralHeight = True
		Me.cbService.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbService.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbService.Sorted = False
		Me.cbService.Name = "cbService"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAdd.Text = "Add"
		Me.cmdAdd.Size = New System.Drawing.Size(57, 25)
		Me.cmdAdd.Location = New System.Drawing.Point(0, 224)
		Me.cmdAdd.TabIndex = 10
		Me.ToolTip1.SetToolTip(Me.cmdAdd, "Add a detail to the invoice")
		Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		Me.txtTotal.AllowPromptAsInput = False
		Me.txtTotal.Size = New System.Drawing.Size(113, 25)
		Me.txtTotal.Location = New System.Drawing.Point(544, 224)
		Me.txtTotal.TabIndex = 16
		Me.txtTotal.TabStop = 0
		Me.txtTotal.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.txtTotal.Enabled = False
		Me.txtTotal.MaxLength = 15
		Me.txtTotal.PromptChar = "_"
		Me.txtTotal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotal.Name = "txtTotal"
		dgDetail.OcxState = CType(resources.GetObject("dgDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgDetail.Size = New System.Drawing.Size(665, 161)
		Me.dgDetail.Location = New System.Drawing.Point(0, 48)
		Me.dgDetail.TabIndex = 9
		Me.dgDetail.Name = "dgDetail"
		Me.Label13.Text = "Actual Subtotal"
		Me.Label13.Size = New System.Drawing.Size(81, 25)
		Me.Label13.Location = New System.Drawing.Point(464, 232)
		Me.Label13.TabIndex = 45
		Me.Label13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label12.Text = "GLM Subtotal"
		Me.Label12.Size = New System.Drawing.Size(73, 25)
		Me.Label12.Location = New System.Drawing.Point(264, 232)
		Me.Label12.TabIndex = 44
		Me.Label12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblTotal.Text = "Total:"
		Me.lblTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotal.Size = New System.Drawing.Size(33, 17)
		Me.lblTotal.Location = New System.Drawing.Point(480, 192)
		Me.lblTotal.TabIndex = 17
		Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
		Me.lblTotal.Enabled = True
		Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTotal.UseMnemonic = True
		Me.lblTotal.Visible = True
		Me.lblTotal.AutoSize = False
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTotal.Name = "lblTotal"
		Me.Controls.Add(cmdEdit)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(frHeader)
		Me.Controls.Add(Frame1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		Me.frHeader.Controls.Add(txtExtc)
		Me.frHeader.Controls.Add(txtSc)
		Me.frHeader.Controls.Add(cbGroupName)
		Me.frHeader.Controls.Add(txtWorkOrderNo)
		Me.frHeader.Controls.Add(cbPeriod)
		Me.frHeader.Controls.Add(txtYearPeriod)
		Me.frHeader.Controls.Add(cbMonthPeriod)
		Me.frHeader.Controls.Add(txtStoreId)
		Me.frHeader.Controls.Add(cbAccount)
		Me.frHeader.Controls.Add(txtInvoice)
		Me.frHeader.Controls.Add(txtStore)
		Me.frHeader.Controls.Add(dtDate)
		Me.frHeader.Controls.Add(cbState)
		Me.frHeader.Controls.Add(cbVendor)
		Me.frHeader.Controls.Add(cmdHelpCustomer)
		Me.frHeader.Controls.Add(cbCustomer)
		Me.frHeader.Controls.Add(Label15)
		Me.frHeader.Controls.Add(Label14)
		Me.frHeader.Controls.Add(Label11)
		Me.frHeader.Controls.Add(Label10)
		Me.frHeader.Controls.Add(Label9)
		Me.frHeader.Controls.Add(Label6)
		Me.frHeader.Controls.Add(lbEndDate)
		Me.frHeader.Controls.Add(lbStartDate)
		Me.frHeader.Controls.Add(Label8)
		Me.frHeader.Controls.Add(Label7)
		Me.frHeader.Controls.Add(Label3)
		Me.frHeader.Controls.Add(Label1)
		Me.frHeader.Controls.Add(label5)
		Me.frHeader.Controls.Add(lVendorName)
		Me.frHeader.Controls.Add(lVendorAddress)
		Me.frHeader.Controls.Add(Label4)
		Me.frHeader.Controls.Add(Label2)
		Me.Frame1.Controls.Add(frDetail)
		Me.frDetail.Controls.Add(txtGlmTotal)
		Me.frDetail.Controls.Add(Text1)
		Me.frDetail.Controls.Add(cmdNotes)
		Me.frDetail.Controls.Add(cmdDrop)
		Me.frDetail.Controls.Add(DataGrid1)
		Me.frDetail.Controls.Add(cbEquipment)
		Me.frDetail.Controls.Add(cbService)
		Me.frDetail.Controls.Add(cmdAdd)
		Me.frDetail.Controls.Add(txtTotal)
		Me.frDetail.Controls.Add(dgDetail)
		Me.frDetail.Controls.Add(Label13)
		Me.frDetail.Controls.Add(Label12)
		Me.frDetail.Controls.Add(lblTotal)
		CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.frHeader.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.frDetail.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class