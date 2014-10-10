<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVendorEntry
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
	Public WithEvents cbVendPayState As System.Windows.Forms.ComboBox
	Public WithEvents mtxtVendPayPhone1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtVendPayZip As System.Windows.Forms.TextBox
	Public WithEvents txtVendPayCity As System.Windows.Forms.TextBox
	Public WithEvents txtVendPayAddress As System.Windows.Forms.TextBox
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents mtxtVendPhone1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents txtQBName As System.Windows.Forms.TextBox
	Public WithEvents cbQBGroupId As System.Windows.Forms.ComboBox
	Public WithEvents cbQBGroupDesc As System.Windows.Forms.ComboBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents frQuickBooks As System.Windows.Forms.GroupBox
	Public WithEvents txtVendFax2 As System.Windows.Forms.TextBox
	Public WithEvents txtVendFax1 As System.Windows.Forms.TextBox
	Public WithEvents txtVendPhone2 As System.Windows.Forms.TextBox
	Public WithEvents txtVendPhone1 As System.Windows.Forms.TextBox
	Public WithEvents txtVendZip As System.Windows.Forms.TextBox
	Public WithEvents txtVendCity As System.Windows.Forms.TextBox
	Public WithEvents txtVendAddress As System.Windows.Forms.TextBox
	Public WithEvents txtVendRepre As System.Windows.Forms.TextBox
	Public WithEvents txtVendArea As System.Windows.Forms.TextBox
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents mtxtVendFax1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtVendPhone2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtVendFax2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVendorEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cbVendPayState = New System.Windows.Forms.ComboBox
		Me.mtxtVendPayPhone1 = New System.Windows.Forms.MaskedTextBox
		Me.txtVendPayZip = New System.Windows.Forms.TextBox
		Me.txtVendPayCity = New System.Windows.Forms.TextBox
		Me.txtVendPayAddress = New System.Windows.Forms.TextBox
		Me.Label18 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.mtxtVendPhone1 = New System.Windows.Forms.MaskedTextBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.frQuickBooks = New System.Windows.Forms.GroupBox
		Me.cmdSearch = New System.Windows.Forms.Button
		Me.txtQBName = New System.Windows.Forms.TextBox
		Me.cbQBGroupId = New System.Windows.Forms.ComboBox
		Me.cbQBGroupDesc = New System.Windows.Forms.ComboBox
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.txtVendFax2 = New System.Windows.Forms.TextBox
		Me.txtVendFax1 = New System.Windows.Forms.TextBox
		Me.txtVendPhone2 = New System.Windows.Forms.TextBox
		Me.txtVendPhone1 = New System.Windows.Forms.TextBox
		Me.txtVendZip = New System.Windows.Forms.TextBox
		Me.txtVendCity = New System.Windows.Forms.TextBox
		Me.txtVendAddress = New System.Windows.Forms.TextBox
		Me.txtVendRepre = New System.Windows.Forms.TextBox
		Me.txtVendArea = New System.Windows.Forms.TextBox
		Me.txtVendName = New System.Windows.Forms.TextBox
		Me.mtxtVendFax1 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtVendPhone2 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtVendFax2 = New System.Windows.Forms.MaskedTextBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		Me.Frame2.SuspendLayout()
		Me.frQuickBooks.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Vendor Data"
		Me.ClientSize = New System.Drawing.Size(481, 575)
		Me.Location = New System.Drawing.Point(4, 23)
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
		Me.Name = "frmVendorEntry"
		Me.Frame2.Text = "Payment Info"
		Me.Frame2.Size = New System.Drawing.Size(433, 137)
		Me.Frame2.Location = New System.Drawing.Point(16, 256)
		Me.Frame2.TabIndex = 40
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.cbVendPayState.Size = New System.Drawing.Size(73, 21)
		Me.cbVendPayState.Location = New System.Drawing.Point(288, 64)
		Me.cbVendPayState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendPayState.TabIndex = 14
		Me.cbVendPayState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendPayState.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendPayState.CausesValidation = True
		Me.cbVendPayState.Enabled = True
		Me.cbVendPayState.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendPayState.IntegralHeight = True
		Me.cbVendPayState.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendPayState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendPayState.Sorted = False
		Me.cbVendPayState.TabStop = True
		Me.cbVendPayState.Visible = True
		Me.cbVendPayState.Name = "cbVendPayState"
		Me.mtxtVendPayPhone1.AllowPromptAsInput = False
		Me.mtxtVendPayPhone1.Size = New System.Drawing.Size(137, 21)
		Me.mtxtVendPayPhone1.Location = New System.Drawing.Point(88, 96)
		Me.mtxtVendPayPhone1.TabIndex = 15
		Me.mtxtVendPayPhone1.MaxLength = 14
		Me.mtxtVendPayPhone1.Mask = "(###)-###-####"
		Me.mtxtVendPayPhone1.PromptChar = "_"
		Me.mtxtVendPayPhone1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtVendPayPhone1.Name = "mtxtVendPayPhone1"
		Me.txtVendPayZip.AutoSize = False
		Me.txtVendPayZip.Size = New System.Drawing.Size(89, 21)
		Me.txtVendPayZip.Location = New System.Drawing.Point(288, 96)
		Me.txtVendPayZip.Maxlength = 11
		Me.txtVendPayZip.TabIndex = 16
		Me.txtVendPayZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendPayZip.AcceptsReturn = True
		Me.txtVendPayZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendPayZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendPayZip.CausesValidation = True
		Me.txtVendPayZip.Enabled = True
		Me.txtVendPayZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendPayZip.HideSelection = True
		Me.txtVendPayZip.ReadOnly = False
		Me.txtVendPayZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendPayZip.MultiLine = False
		Me.txtVendPayZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendPayZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendPayZip.TabStop = True
		Me.txtVendPayZip.Visible = True
		Me.txtVendPayZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendPayZip.Name = "txtVendPayZip"
		Me.txtVendPayCity.AutoSize = False
		Me.txtVendPayCity.Size = New System.Drawing.Size(137, 21)
		Me.txtVendPayCity.Location = New System.Drawing.Point(88, 64)
		Me.txtVendPayCity.TabIndex = 13
		Me.txtVendPayCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendPayCity.AcceptsReturn = True
		Me.txtVendPayCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendPayCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendPayCity.CausesValidation = True
		Me.txtVendPayCity.Enabled = True
		Me.txtVendPayCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendPayCity.HideSelection = True
		Me.txtVendPayCity.ReadOnly = False
		Me.txtVendPayCity.Maxlength = 0
		Me.txtVendPayCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendPayCity.MultiLine = False
		Me.txtVendPayCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendPayCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendPayCity.TabStop = True
		Me.txtVendPayCity.Visible = True
		Me.txtVendPayCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendPayCity.Name = "txtVendPayCity"
		Me.txtVendPayAddress.AutoSize = False
		Me.txtVendPayAddress.Size = New System.Drawing.Size(297, 21)
		Me.txtVendPayAddress.Location = New System.Drawing.Point(88, 32)
		Me.txtVendPayAddress.TabIndex = 12
		Me.txtVendPayAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendPayAddress.AcceptsReturn = True
		Me.txtVendPayAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendPayAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendPayAddress.CausesValidation = True
		Me.txtVendPayAddress.Enabled = True
		Me.txtVendPayAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendPayAddress.HideSelection = True
		Me.txtVendPayAddress.ReadOnly = False
		Me.txtVendPayAddress.Maxlength = 0
		Me.txtVendPayAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendPayAddress.MultiLine = False
		Me.txtVendPayAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendPayAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendPayAddress.TabStop = True
		Me.txtVendPayAddress.Visible = True
		Me.txtVendPayAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendPayAddress.Name = "txtVendPayAddress"
		Me.Label18.Text = "State"
		Me.Label18.Size = New System.Drawing.Size(33, 17)
		Me.Label18.Location = New System.Drawing.Point(248, 64)
		Me.Label18.TabIndex = 45
		Me.Label18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label18.BackColor = System.Drawing.SystemColors.Control
		Me.Label18.Enabled = True
		Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label18.UseMnemonic = True
		Me.Label18.Visible = True
		Me.Label18.AutoSize = False
		Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label18.Name = "Label18"
		Me.Label17.Text = "Phone"
		Me.Label17.Size = New System.Drawing.Size(41, 21)
		Me.Label17.Location = New System.Drawing.Point(16, 96)
		Me.Label17.TabIndex = 44
		Me.Label17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.BackColor = System.Drawing.SystemColors.Control
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = False
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me.Label16.Text = "Zip"
		Me.Label16.Size = New System.Drawing.Size(25, 17)
		Me.Label16.Location = New System.Drawing.Point(248, 98)
		Me.Label16.TabIndex = 43
		Me.Label16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.BackColor = System.Drawing.SystemColors.Control
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label15.Text = "City"
		Me.Label15.Size = New System.Drawing.Size(41, 17)
		Me.Label15.Location = New System.Drawing.Point(16, 64)
		Me.Label15.TabIndex = 42
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
		Me.Label14.Text = "Payment Address"
		Me.Label14.Size = New System.Drawing.Size(49, 25)
		Me.Label14.Location = New System.Drawing.Point(16, 24)
		Me.Label14.TabIndex = 41
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
		Me.mtxtVendPhone1.AllowPromptAsInput = False
		Me.mtxtVendPhone1.Size = New System.Drawing.Size(145, 21)
		Me.mtxtVendPhone1.Location = New System.Drawing.Point(104, 184)
		Me.mtxtVendPhone1.TabIndex = 8
		Me.mtxtVendPhone1.MaxLength = 14
		Me.mtxtVendPhone1.Mask = "(###)-###-####"
		Me.mtxtVendPhone1.PromptChar = "_"
		Me.mtxtVendPhone1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtVendPhone1.Name = "mtxtVendPhone1"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(232, 536)
		Me.cmdCancel.TabIndex = 23
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "Ok"
		Me.cmdOk.Size = New System.Drawing.Size(57, 33)
		Me.cmdOk.Location = New System.Drawing.Point(160, 536)
		Me.cmdOk.TabIndex = 22
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.cbState.Size = New System.Drawing.Size(73, 21)
		Me.cbState.Location = New System.Drawing.Point(376, 56)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 3
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
		Me.frQuickBooks.Text = "Quick Books  Info"
		Me.frQuickBooks.Size = New System.Drawing.Size(433, 113)
		Me.frQuickBooks.Location = New System.Drawing.Point(16, 408)
		Me.frQuickBooks.TabIndex = 37
		Me.frQuickBooks.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frQuickBooks.BackColor = System.Drawing.SystemColors.Control
		Me.frQuickBooks.Enabled = True
		Me.frQuickBooks.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frQuickBooks.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frQuickBooks.Visible = True
		Me.frQuickBooks.Name = "frQuickBooks"
		Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSearch.Size = New System.Drawing.Size(41, 25)
		Me.cmdSearch.Location = New System.Drawing.Point(360, 56)
		Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
		Me.cmdSearch.TabIndex = 20
		Me.ToolTip1.SetToolTip(Me.cmdSearch, "Search")
		Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSearch.CausesValidation = True
		Me.cmdSearch.Enabled = True
		Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSearch.TabStop = True
		Me.cmdSearch.Name = "cmdSearch"
		Me.txtQBName.AutoSize = False
		Me.txtQBName.Size = New System.Drawing.Size(241, 21)
		Me.txtQBName.Location = New System.Drawing.Point(112, 56)
		Me.txtQBName.ReadOnly = True
		Me.txtQBName.Maxlength = 255
		Me.txtQBName.TabIndex = 19
		Me.txtQBName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQBName.AcceptsReturn = True
		Me.txtQBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtQBName.BackColor = System.Drawing.SystemColors.Window
		Me.txtQBName.CausesValidation = True
		Me.txtQBName.Enabled = True
		Me.txtQBName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQBName.HideSelection = True
		Me.txtQBName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQBName.MultiLine = False
		Me.txtQBName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQBName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQBName.TabStop = True
		Me.txtQBName.Visible = True
		Me.txtQBName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQBName.Name = "txtQBName"
		Me.cbQBGroupId.Size = New System.Drawing.Size(41, 21)
		Me.cbQBGroupId.Location = New System.Drawing.Point(296, 24)
		Me.cbQBGroupId.TabIndex = 18
		Me.cbQBGroupId.Text = "Combo1"
		Me.cbQBGroupId.Visible = False
		Me.cbQBGroupId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBGroupId.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBGroupId.CausesValidation = True
		Me.cbQBGroupId.Enabled = True
		Me.cbQBGroupId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBGroupId.IntegralHeight = True
		Me.cbQBGroupId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBGroupId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBGroupId.Sorted = False
		Me.cbQBGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cbQBGroupId.TabStop = True
		Me.cbQBGroupId.Name = "cbQBGroupId"
		Me.cbQBGroupDesc.Size = New System.Drawing.Size(169, 21)
		Me.cbQBGroupDesc.Location = New System.Drawing.Point(112, 24)
		Me.cbQBGroupDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupDesc.TabIndex = 17
		Me.cbQBGroupDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBGroupDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBGroupDesc.CausesValidation = True
		Me.cbQBGroupDesc.Enabled = True
		Me.cbQBGroupDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBGroupDesc.IntegralHeight = True
		Me.cbQBGroupDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBGroupDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBGroupDesc.Sorted = False
		Me.cbQBGroupDesc.TabStop = True
		Me.cbQBGroupDesc.Visible = True
		Me.cbQBGroupDesc.Name = "cbQBGroupDesc"
		Me.Label13.Text = "Quick Books Vendor Name"
		Me.Label13.Size = New System.Drawing.Size(65, 25)
		Me.Label13.Location = New System.Drawing.Point(16, 56)
		Me.Label13.TabIndex = 39
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
		Me.Label12.Text = "Company Group"
		Me.Label12.Size = New System.Drawing.Size(81, 17)
		Me.Label12.Location = New System.Drawing.Point(16, 24)
		Me.Label12.TabIndex = 38
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
		Me.txtVendFax2.AutoSize = False
		Me.txtVendFax2.Size = New System.Drawing.Size(121, 21)
		Me.txtVendFax2.Location = New System.Drawing.Point(360, 544)
		Me.txtVendFax2.Maxlength = 15
		Me.txtVendFax2.TabIndex = 26
		Me.txtVendFax2.Visible = False
		Me.txtVendFax2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendFax2.AcceptsReturn = True
		Me.txtVendFax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendFax2.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendFax2.CausesValidation = True
		Me.txtVendFax2.Enabled = True
		Me.txtVendFax2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendFax2.HideSelection = True
		Me.txtVendFax2.ReadOnly = False
		Me.txtVendFax2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendFax2.MultiLine = False
		Me.txtVendFax2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendFax2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendFax2.TabStop = True
		Me.txtVendFax2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendFax2.Name = "txtVendFax2"
		Me.txtVendFax1.AutoSize = False
		Me.txtVendFax1.Size = New System.Drawing.Size(121, 21)
		Me.txtVendFax1.Location = New System.Drawing.Point(360, 512)
		Me.txtVendFax1.Maxlength = 15
		Me.txtVendFax1.TabIndex = 24
		Me.txtVendFax1.Visible = False
		Me.txtVendFax1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendFax1.AcceptsReturn = True
		Me.txtVendFax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendFax1.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendFax1.CausesValidation = True
		Me.txtVendFax1.Enabled = True
		Me.txtVendFax1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendFax1.HideSelection = True
		Me.txtVendFax1.ReadOnly = False
		Me.txtVendFax1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendFax1.MultiLine = False
		Me.txtVendFax1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendFax1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendFax1.TabStop = True
		Me.txtVendFax1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendFax1.Name = "txtVendFax1"
		Me.txtVendPhone2.AutoSize = False
		Me.txtVendPhone2.Size = New System.Drawing.Size(121, 21)
		Me.txtVendPhone2.Location = New System.Drawing.Point(360, 488)
		Me.txtVendPhone2.Maxlength = 15
		Me.txtVendPhone2.TabIndex = 25
		Me.txtVendPhone2.Visible = False
		Me.txtVendPhone2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendPhone2.AcceptsReturn = True
		Me.txtVendPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendPhone2.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendPhone2.CausesValidation = True
		Me.txtVendPhone2.Enabled = True
		Me.txtVendPhone2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendPhone2.HideSelection = True
		Me.txtVendPhone2.ReadOnly = False
		Me.txtVendPhone2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendPhone2.MultiLine = False
		Me.txtVendPhone2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendPhone2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendPhone2.TabStop = True
		Me.txtVendPhone2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendPhone2.Name = "txtVendPhone2"
		Me.txtVendPhone1.AutoSize = False
		Me.txtVendPhone1.Size = New System.Drawing.Size(121, 21)
		Me.txtVendPhone1.Location = New System.Drawing.Point(360, 456)
		Me.txtVendPhone1.Maxlength = 15
		Me.txtVendPhone1.TabIndex = 21
		Me.txtVendPhone1.Visible = False
		Me.txtVendPhone1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendPhone1.AcceptsReturn = True
		Me.txtVendPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendPhone1.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendPhone1.CausesValidation = True
		Me.txtVendPhone1.Enabled = True
		Me.txtVendPhone1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendPhone1.HideSelection = True
		Me.txtVendPhone1.ReadOnly = False
		Me.txtVendPhone1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendPhone1.MultiLine = False
		Me.txtVendPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendPhone1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendPhone1.TabStop = True
		Me.txtVendPhone1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendPhone1.Name = "txtVendPhone1"
		Me.txtVendZip.AutoSize = False
		Me.txtVendZip.Size = New System.Drawing.Size(89, 21)
		Me.txtVendZip.Location = New System.Drawing.Point(304, 152)
		Me.txtVendZip.Maxlength = 11
		Me.txtVendZip.TabIndex = 7
		Me.txtVendZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendZip.AcceptsReturn = True
		Me.txtVendZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendZip.CausesValidation = True
		Me.txtVendZip.Enabled = True
		Me.txtVendZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendZip.HideSelection = True
		Me.txtVendZip.ReadOnly = False
		Me.txtVendZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendZip.MultiLine = False
		Me.txtVendZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendZip.TabStop = True
		Me.txtVendZip.Visible = True
		Me.txtVendZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendZip.Name = "txtVendZip"
		Me.txtVendCity.AutoSize = False
		Me.txtVendCity.Size = New System.Drawing.Size(145, 21)
		Me.txtVendCity.Location = New System.Drawing.Point(104, 152)
		Me.txtVendCity.Maxlength = 30
		Me.txtVendCity.TabIndex = 6
		Me.txtVendCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendCity.AcceptsReturn = True
		Me.txtVendCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendCity.CausesValidation = True
		Me.txtVendCity.Enabled = True
		Me.txtVendCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendCity.HideSelection = True
		Me.txtVendCity.ReadOnly = False
		Me.txtVendCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendCity.MultiLine = False
		Me.txtVendCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendCity.TabStop = True
		Me.txtVendCity.Visible = True
		Me.txtVendCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendCity.Name = "txtVendCity"
		Me.txtVendAddress.AutoSize = False
		Me.txtVendAddress.Size = New System.Drawing.Size(289, 21)
		Me.txtVendAddress.Location = New System.Drawing.Point(104, 120)
		Me.txtVendAddress.Maxlength = 80
		Me.txtVendAddress.TabIndex = 5
		Me.txtVendAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendAddress.AcceptsReturn = True
		Me.txtVendAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendAddress.CausesValidation = True
		Me.txtVendAddress.Enabled = True
		Me.txtVendAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendAddress.HideSelection = True
		Me.txtVendAddress.ReadOnly = False
		Me.txtVendAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendAddress.MultiLine = False
		Me.txtVendAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendAddress.TabStop = True
		Me.txtVendAddress.Visible = True
		Me.txtVendAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendAddress.Name = "txtVendAddress"
		Me.txtVendRepre.AutoSize = False
		Me.txtVendRepre.Size = New System.Drawing.Size(193, 21)
		Me.txtVendRepre.Location = New System.Drawing.Point(104, 88)
		Me.txtVendRepre.Maxlength = 20
		Me.txtVendRepre.TabIndex = 4
		Me.txtVendRepre.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendRepre.AcceptsReturn = True
		Me.txtVendRepre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendRepre.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendRepre.CausesValidation = True
		Me.txtVendRepre.Enabled = True
		Me.txtVendRepre.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendRepre.HideSelection = True
		Me.txtVendRepre.ReadOnly = False
		Me.txtVendRepre.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendRepre.MultiLine = False
		Me.txtVendRepre.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendRepre.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendRepre.TabStop = True
		Me.txtVendRepre.Visible = True
		Me.txtVendRepre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendRepre.Name = "txtVendRepre"
		Me.txtVendArea.AutoSize = False
		Me.txtVendArea.Size = New System.Drawing.Size(193, 21)
		Me.txtVendArea.Location = New System.Drawing.Point(104, 56)
		Me.txtVendArea.Maxlength = 40
		Me.txtVendArea.TabIndex = 2
		Me.txtVendArea.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendArea.AcceptsReturn = True
		Me.txtVendArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendArea.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendArea.CausesValidation = True
		Me.txtVendArea.Enabled = True
		Me.txtVendArea.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendArea.HideSelection = True
		Me.txtVendArea.ReadOnly = False
		Me.txtVendArea.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendArea.MultiLine = False
		Me.txtVendArea.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendArea.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendArea.TabStop = True
		Me.txtVendArea.Visible = True
		Me.txtVendArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendArea.Name = "txtVendArea"
		Me.txtVendName.AutoSize = False
		Me.txtVendName.Enabled = False
		Me.txtVendName.Size = New System.Drawing.Size(193, 21)
		Me.txtVendName.Location = New System.Drawing.Point(104, 24)
		Me.txtVendName.ReadOnly = True
		Me.txtVendName.TabIndex = 1
		Me.txtVendName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendName.AcceptsReturn = True
		Me.txtVendName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendName.CausesValidation = True
		Me.txtVendName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendName.HideSelection = True
		Me.txtVendName.Maxlength = 0
		Me.txtVendName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendName.MultiLine = False
		Me.txtVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendName.TabStop = True
		Me.txtVendName.Visible = True
		Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendName.Name = "txtVendName"
		Me.mtxtVendFax1.AllowPromptAsInput = False
		Me.mtxtVendFax1.Size = New System.Drawing.Size(145, 21)
		Me.mtxtVendFax1.Location = New System.Drawing.Point(304, 184)
		Me.mtxtVendFax1.TabIndex = 9
		Me.mtxtVendFax1.MaxLength = 14
		Me.mtxtVendFax1.Mask = "(###)-###-####"
		Me.mtxtVendFax1.PromptChar = "_"
		Me.mtxtVendFax1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtVendFax1.Name = "mtxtVendFax1"
		Me.mtxtVendPhone2.AllowPromptAsInput = False
		Me.mtxtVendPhone2.Size = New System.Drawing.Size(145, 21)
		Me.mtxtVendPhone2.Location = New System.Drawing.Point(104, 216)
		Me.mtxtVendPhone2.TabIndex = 10
		Me.mtxtVendPhone2.MaxLength = 14
		Me.mtxtVendPhone2.Mask = "(###)-###-####"
		Me.mtxtVendPhone2.PromptChar = "_"
		Me.mtxtVendPhone2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtVendPhone2.Name = "mtxtVendPhone2"
		Me.mtxtVendFax2.AllowPromptAsInput = False
		Me.mtxtVendFax2.Size = New System.Drawing.Size(145, 21)
		Me.mtxtVendFax2.Location = New System.Drawing.Point(304, 208)
		Me.mtxtVendFax2.TabIndex = 11
		Me.mtxtVendFax2.MaxLength = 14
		Me.mtxtVendFax2.Mask = "(###)-###-####"
		Me.mtxtVendFax2.PromptChar = "_"
		Me.mtxtVendFax2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtVendFax2.Name = "mtxtVendFax2"
		Me.Label11.Text = "Fax 2"
		Me.Label11.Size = New System.Drawing.Size(33, 17)
		Me.Label11.Location = New System.Drawing.Point(264, 216)
		Me.Label11.TabIndex = 36
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
		Me.Label10.Text = "Fax 1"
		Me.Label10.Size = New System.Drawing.Size(33, 17)
		Me.Label10.Location = New System.Drawing.Point(264, 184)
		Me.Label10.TabIndex = 35
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
		Me.Label9.Text = "Phone 2"
		Me.Label9.Size = New System.Drawing.Size(49, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 216)
		Me.Label9.TabIndex = 34
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
		Me.Label8.Text = "Phone 1"
		Me.Label8.Size = New System.Drawing.Size(49, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 184)
		Me.Label8.TabIndex = 33
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
		Me.Label7.Text = "Zip"
		Me.Label7.Size = New System.Drawing.Size(25, 17)
		Me.Label7.Location = New System.Drawing.Point(264, 152)
		Me.Label7.TabIndex = 32
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
		Me.Label6.Location = New System.Drawing.Point(16, 152)
		Me.Label6.TabIndex = 31
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
		Me.Label5.Text = "Address"
		Me.Label5.Size = New System.Drawing.Size(49, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 120)
		Me.Label5.TabIndex = 30
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
		Me.Label4.Text = "Representative"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 88)
		Me.Label4.TabIndex = 29
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
		Me.Label3.Text = "State"
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(336, 56)
		Me.Label3.TabIndex = 28
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
		Me.Label2.Text = "Area"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 56)
		Me.Label2.TabIndex = 27
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
		Me.label1.Text = "Vendor"
		Me.label1.Size = New System.Drawing.Size(57, 17)
		Me.label1.Location = New System.Drawing.Point(16, 24)
		Me.label1.TabIndex = 0
		Me.label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label1.BackColor = System.Drawing.SystemColors.Control
		Me.label1.Enabled = True
		Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label1.UseMnemonic = True
		Me.label1.Visible = True
		Me.label1.AutoSize = False
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label1.Name = "label1"
		Me.Controls.Add(Frame2)
		Me.Controls.Add(mtxtVendPhone1)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cbState)
		Me.Controls.Add(frQuickBooks)
		Me.Controls.Add(txtVendFax2)
		Me.Controls.Add(txtVendFax1)
		Me.Controls.Add(txtVendPhone2)
		Me.Controls.Add(txtVendPhone1)
		Me.Controls.Add(txtVendZip)
		Me.Controls.Add(txtVendCity)
		Me.Controls.Add(txtVendAddress)
		Me.Controls.Add(txtVendRepre)
		Me.Controls.Add(txtVendArea)
		Me.Controls.Add(txtVendName)
		Me.Controls.Add(mtxtVendFax1)
		Me.Controls.Add(mtxtVendPhone2)
		Me.Controls.Add(mtxtVendFax2)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(label1)
		Me.Frame2.Controls.Add(cbVendPayState)
		Me.Frame2.Controls.Add(mtxtVendPayPhone1)
		Me.Frame2.Controls.Add(txtVendPayZip)
		Me.Frame2.Controls.Add(txtVendPayCity)
		Me.Frame2.Controls.Add(txtVendPayAddress)
		Me.Frame2.Controls.Add(Label18)
		Me.Frame2.Controls.Add(Label17)
		Me.Frame2.Controls.Add(Label16)
		Me.Frame2.Controls.Add(Label15)
		Me.Frame2.Controls.Add(Label14)
		Me.frQuickBooks.Controls.Add(cmdSearch)
		Me.frQuickBooks.Controls.Add(txtQBName)
		Me.frQuickBooks.Controls.Add(cbQBGroupId)
		Me.frQuickBooks.Controls.Add(cbQBGroupDesc)
		Me.frQuickBooks.Controls.Add(Label13)
		Me.frQuickBooks.Controls.Add(Label12)
		Me.Frame2.ResumeLayout(False)
		Me.frQuickBooks.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class