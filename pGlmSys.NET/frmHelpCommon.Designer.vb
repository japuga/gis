<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHelpCommon
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents txtStoreZip As System.Windows.Forms.TextBox
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtStoreCity As System.Windows.Forms.TextBox
	Public WithEvents txtStoreNumber As System.Windows.Forms.TextBox
	Public WithEvents txtStoreName As System.Windows.Forms.TextBox
	Public WithEvents txtStoreAddress As System.Windows.Forms.TextBox
	Public WithEvents cmdFilter As System.Windows.Forms.Button
	Public WithEvents cmdShowAll As System.Windows.Forms.Button
	Public WithEvents txtAccountMask As System.Windows.Forms.TextBox
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents frStoreFilter As System.Windows.Forms.GroupBox
	Public WithEvents dgStore As AxMSDataGridLib.AxDataGrid
	Public WithEvents lRecords As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHelpCommon))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.frStoreFilter = New System.Windows.Forms.GroupBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.txtStoreZip = New System.Windows.Forms.TextBox
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtStoreCity = New System.Windows.Forms.TextBox
		Me.txtStoreNumber = New System.Windows.Forms.TextBox
		Me.txtStoreName = New System.Windows.Forms.TextBox
		Me.txtStoreAddress = New System.Windows.Forms.TextBox
		Me.cmdFilter = New System.Windows.Forms.Button
		Me.cmdShowAll = New System.Windows.Forms.Button
		Me.txtAccountMask = New System.Windows.Forms.TextBox
		Me.txtVendName = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.dgStore = New AxMSDataGridLib.AxDataGrid
		Me.lRecords = New System.Windows.Forms.Label
		Me.frStoreFilter.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgStore, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Store Lookup"
		Me.ClientSize = New System.Drawing.Size(672, 548)
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
		Me.Name = "frmHelpCommon"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Close"
		Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(296, 496)
		Me.cmdCancel.TabIndex = 13
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.frStoreFilter.Text = "Criteria"
		Me.frStoreFilter.Size = New System.Drawing.Size(617, 185)
		Me.frStoreFilter.Location = New System.Drawing.Point(24, 16)
		Me.frStoreFilter.TabIndex = 0
		Me.frStoreFilter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frStoreFilter.BackColor = System.Drawing.SystemColors.Control
		Me.frStoreFilter.Enabled = True
		Me.frStoreFilter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frStoreFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frStoreFilter.Visible = True
		Me.frStoreFilter.Name = "frStoreFilter"
		Me.cbCustId.Size = New System.Drawing.Size(185, 21)
		Me.cbCustId.Location = New System.Drawing.Point(272, 16)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 24
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
		Me.cbCustName.Size = New System.Drawing.Size(169, 21)
		Me.cbCustName.Location = New System.Drawing.Point(72, 16)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 23
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
		Me.txtStoreZip.AutoSize = False
		Me.txtStoreZip.Size = New System.Drawing.Size(129, 19)
		Me.txtStoreZip.Location = New System.Drawing.Point(312, 144)
		Me.txtStoreZip.TabIndex = 21
		Me.txtStoreZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreZip.AcceptsReturn = True
		Me.txtStoreZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreZip.CausesValidation = True
		Me.txtStoreZip.Enabled = True
		Me.txtStoreZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreZip.HideSelection = True
		Me.txtStoreZip.ReadOnly = False
		Me.txtStoreZip.Maxlength = 0
		Me.txtStoreZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreZip.MultiLine = False
		Me.txtStoreZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreZip.TabStop = True
		Me.txtStoreZip.Visible = True
		Me.txtStoreZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreZip.Name = "txtStoreZip"
		Me.cbState.Size = New System.Drawing.Size(137, 21)
		Me.cbState.Location = New System.Drawing.Point(312, 112)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 19
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
		Me.txtStoreCity.AutoSize = False
		Me.txtStoreCity.Size = New System.Drawing.Size(161, 19)
		Me.txtStoreCity.Location = New System.Drawing.Point(72, 144)
		Me.txtStoreCity.TabIndex = 17
		Me.txtStoreCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreCity.AcceptsReturn = True
		Me.txtStoreCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreCity.CausesValidation = True
		Me.txtStoreCity.Enabled = True
		Me.txtStoreCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreCity.HideSelection = True
		Me.txtStoreCity.ReadOnly = False
		Me.txtStoreCity.Maxlength = 0
		Me.txtStoreCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreCity.MultiLine = False
		Me.txtStoreCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreCity.TabStop = True
		Me.txtStoreCity.Visible = True
		Me.txtStoreCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreCity.Name = "txtStoreCity"
		Me.txtStoreNumber.AutoSize = False
		Me.txtStoreNumber.Size = New System.Drawing.Size(89, 19)
		Me.txtStoreNumber.Location = New System.Drawing.Point(72, 48)
		Me.txtStoreNumber.TabIndex = 7
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
		Me.txtStoreName.AutoSize = False
		Me.txtStoreName.Size = New System.Drawing.Size(113, 19)
		Me.txtStoreName.Location = New System.Drawing.Point(72, 80)
		Me.txtStoreName.TabIndex = 6
		Me.txtStoreName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreName.AcceptsReturn = True
		Me.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreName.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreName.CausesValidation = True
		Me.txtStoreName.Enabled = True
		Me.txtStoreName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreName.HideSelection = True
		Me.txtStoreName.ReadOnly = False
		Me.txtStoreName.Maxlength = 0
		Me.txtStoreName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreName.MultiLine = False
		Me.txtStoreName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreName.TabStop = True
		Me.txtStoreName.Visible = True
		Me.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreName.Name = "txtStoreName"
		Me.txtStoreAddress.AutoSize = False
		Me.txtStoreAddress.Size = New System.Drawing.Size(177, 19)
		Me.txtStoreAddress.Location = New System.Drawing.Point(72, 112)
		Me.txtStoreAddress.TabIndex = 5
		Me.txtStoreAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreAddress.AcceptsReturn = True
		Me.txtStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreAddress.CausesValidation = True
		Me.txtStoreAddress.Enabled = True
		Me.txtStoreAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreAddress.HideSelection = True
		Me.txtStoreAddress.ReadOnly = False
		Me.txtStoreAddress.Maxlength = 0
		Me.txtStoreAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreAddress.MultiLine = False
		Me.txtStoreAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreAddress.TabStop = True
		Me.txtStoreAddress.Visible = True
		Me.txtStoreAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreAddress.Name = "txtStoreAddress"
		Me.cmdFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFilter.Text = "Apply Filter"
		Me.cmdFilter.Size = New System.Drawing.Size(65, 25)
		Me.cmdFilter.Location = New System.Drawing.Point(536, 32)
		Me.cmdFilter.TabIndex = 4
		Me.cmdFilter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFilter.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFilter.CausesValidation = True
		Me.cmdFilter.Enabled = True
		Me.cmdFilter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFilter.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFilter.TabStop = True
		Me.cmdFilter.Name = "cmdFilter"
		Me.cmdShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdShowAll.Text = "Show All"
		Me.cmdShowAll.Size = New System.Drawing.Size(65, 25)
		Me.cmdShowAll.Location = New System.Drawing.Point(536, 80)
		Me.cmdShowAll.TabIndex = 3
		Me.cmdShowAll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdShowAll.BackColor = System.Drawing.SystemColors.Control
		Me.cmdShowAll.CausesValidation = True
		Me.cmdShowAll.Enabled = True
		Me.cmdShowAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdShowAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdShowAll.TabStop = True
		Me.cmdShowAll.Name = "cmdShowAll"
		Me.txtAccountMask.AutoSize = False
		Me.txtAccountMask.Size = New System.Drawing.Size(129, 19)
		Me.txtAccountMask.Location = New System.Drawing.Point(312, 48)
		Me.txtAccountMask.TabIndex = 2
		Me.txtAccountMask.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccountMask.AcceptsReturn = True
		Me.txtAccountMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccountMask.BackColor = System.Drawing.SystemColors.Window
		Me.txtAccountMask.CausesValidation = True
		Me.txtAccountMask.Enabled = True
		Me.txtAccountMask.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccountMask.HideSelection = True
		Me.txtAccountMask.ReadOnly = False
		Me.txtAccountMask.Maxlength = 0
		Me.txtAccountMask.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccountMask.MultiLine = False
		Me.txtAccountMask.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccountMask.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccountMask.TabStop = True
		Me.txtAccountMask.Visible = True
		Me.txtAccountMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccountMask.Name = "txtAccountMask"
		Me.txtVendName.AutoSize = False
		Me.txtVendName.Size = New System.Drawing.Size(129, 19)
		Me.txtVendName.Location = New System.Drawing.Point(312, 80)
		Me.txtVendName.TabIndex = 1
		Me.txtVendName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendName.AcceptsReturn = True
		Me.txtVendName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendName.CausesValidation = True
		Me.txtVendName.Enabled = True
		Me.txtVendName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendName.HideSelection = True
		Me.txtVendName.ReadOnly = False
		Me.txtVendName.Maxlength = 0
		Me.txtVendName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendName.MultiLine = False
		Me.txtVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendName.TabStop = True
		Me.txtVendName.Visible = True
		Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendName.Name = "txtVendName"
		Me.Label9.Text = "Customer"
		Me.Label9.Size = New System.Drawing.Size(57, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 16)
		Me.Label9.TabIndex = 22
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
		Me.Label8.Text = "Zip"
		Me.Label8.Size = New System.Drawing.Size(33, 17)
		Me.Label8.Location = New System.Drawing.Point(256, 144)
		Me.Label8.TabIndex = 20
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
		Me.Label7.Text = "State"
		Me.Label7.Size = New System.Drawing.Size(49, 17)
		Me.Label7.Location = New System.Drawing.Point(256, 112)
		Me.Label7.TabIndex = 18
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
		Me.Label6.Text = "City"
		Me.Label6.Size = New System.Drawing.Size(33, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 144)
		Me.Label6.TabIndex = 16
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
		Me.Label2.Text = "Number"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 48)
		Me.Label2.TabIndex = 12
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
		Me.Label3.Text = "Name"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 80)
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
		Me.Label4.Text = "Address"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 112)
		Me.Label4.TabIndex = 10
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
		Me.Label1.Text = "Account"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(256, 48)
		Me.Label1.TabIndex = 9
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
		Me.Label5.Text = "Vendor"
		Me.Label5.Size = New System.Drawing.Size(41, 17)
		Me.Label5.Location = New System.Drawing.Point(256, 80)
		Me.Label5.TabIndex = 8
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
		dgStore.OcxState = CType(resources.GetObject("dgStore.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgStore.Size = New System.Drawing.Size(617, 241)
		Me.dgStore.Location = New System.Drawing.Point(16, 232)
		Me.dgStore.TabIndex = 14
		Me.dgStore.Name = "dgStore"
		Me.lRecords.Text = "Total Records"
		Me.lRecords.Size = New System.Drawing.Size(121, 17)
		Me.lRecords.Location = New System.Drawing.Point(16, 480)
		Me.lRecords.TabIndex = 15
		Me.lRecords.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lRecords.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lRecords.BackColor = System.Drawing.SystemColors.Control
		Me.lRecords.Enabled = True
		Me.lRecords.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lRecords.Cursor = System.Windows.Forms.Cursors.Default
		Me.lRecords.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lRecords.UseMnemonic = True
		Me.lRecords.Visible = True
		Me.lRecords.AutoSize = False
		Me.lRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lRecords.Name = "lRecords"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(frStoreFilter)
		Me.Controls.Add(dgStore)
		Me.Controls.Add(lRecords)
		Me.frStoreFilter.Controls.Add(cbCustId)
		Me.frStoreFilter.Controls.Add(cbCustName)
		Me.frStoreFilter.Controls.Add(txtStoreZip)
		Me.frStoreFilter.Controls.Add(cbState)
		Me.frStoreFilter.Controls.Add(txtStoreCity)
		Me.frStoreFilter.Controls.Add(txtStoreNumber)
		Me.frStoreFilter.Controls.Add(txtStoreName)
		Me.frStoreFilter.Controls.Add(txtStoreAddress)
		Me.frStoreFilter.Controls.Add(cmdFilter)
		Me.frStoreFilter.Controls.Add(cmdShowAll)
		Me.frStoreFilter.Controls.Add(txtAccountMask)
		Me.frStoreFilter.Controls.Add(txtVendName)
		Me.frStoreFilter.Controls.Add(Label9)
		Me.frStoreFilter.Controls.Add(Label8)
		Me.frStoreFilter.Controls.Add(Label7)
		Me.frStoreFilter.Controls.Add(Label6)
		Me.frStoreFilter.Controls.Add(Label2)
		Me.frStoreFilter.Controls.Add(Label3)
		Me.frStoreFilter.Controls.Add(Label4)
		Me.frStoreFilter.Controls.Add(Label1)
		Me.frStoreFilter.Controls.Add(Label5)
		CType(Me.dgStore, System.ComponentModel.ISupportInitialize).EndInit()
		Me.frStoreFilter.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class