<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustomerEntry
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
	Public WithEvents txtBillingAccountNo As System.Windows.Forms.TextBox
	Public WithEvents txtContractNumber As System.Windows.Forms.TextBox
	Public WithEvents cbNegativeSavingsFlag As System.Windows.Forms.ComboBox
	Public WithEvents chkPayInvoices As System.Windows.Forms.CheckBox
	Public WithEvents cbQBGroupId As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cbQBAccountName As System.Windows.Forms.ComboBox
	Public WithEvents cbQBCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbQBGroupDesc As System.Windows.Forms.ComboBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents frQuickBooks As System.Windows.Forms.GroupBox
	Public WithEvents txtCustReportName As System.Windows.Forms.TextBox
	Public WithEvents mtxtCustPhone3 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtCustPhone2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtCustPhone1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtCustZip As System.Windows.Forms.TextBox
	Public WithEvents txtCustCity As System.Windows.Forms.TextBox
	Public WithEvents txtCustEmail As System.Windows.Forms.TextBox
	Public WithEvents txtCustAddress As System.Windows.Forms.TextBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtContactTitle As System.Windows.Forms.TextBox
	Public WithEvents txtCustContact As System.Windows.Forms.TextBox
	Public WithEvents txtCustName As System.Windows.Forms.TextBox
	Public WithEvents txtCustId As System.Windows.Forms.TextBox
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustomerEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtBillingAccountNo = New System.Windows.Forms.TextBox
		Me.txtContractNumber = New System.Windows.Forms.TextBox
		Me.cbNegativeSavingsFlag = New System.Windows.Forms.ComboBox
		Me.chkPayInvoices = New System.Windows.Forms.CheckBox
		Me.cbQBGroupId = New System.Windows.Forms.ComboBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.frQuickBooks = New System.Windows.Forms.GroupBox
		Me.cbQBAccountName = New System.Windows.Forms.ComboBox
		Me.cbQBCustName = New System.Windows.Forms.ComboBox
		Me.cbQBGroupDesc = New System.Windows.Forms.ComboBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.txtCustReportName = New System.Windows.Forms.TextBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.mtxtCustPhone3 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtCustPhone2 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtCustPhone1 = New System.Windows.Forms.MaskedTextBox
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtCustZip = New System.Windows.Forms.TextBox
		Me.txtCustCity = New System.Windows.Forms.TextBox
		Me.txtCustEmail = New System.Windows.Forms.TextBox
		Me.txtCustAddress = New System.Windows.Forms.TextBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.txtContactTitle = New System.Windows.Forms.TextBox
		Me.txtCustContact = New System.Windows.Forms.TextBox
		Me.txtCustName = New System.Windows.Forms.TextBox
		Me.txtCustId = New System.Windows.Forms.TextBox
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label18 = New System.Windows.Forms.Label
		Me.label17 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.frQuickBooks.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Customer Entry"
		Me.ClientSize = New System.Drawing.Size(483, 563)
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
		Me.Name = "frmCustomerEntry"
		Me.txtBillingAccountNo.AutoSize = False
		Me.txtBillingAccountNo.Size = New System.Drawing.Size(161, 19)
		Me.txtBillingAccountNo.Location = New System.Drawing.Point(296, 152)
		Me.txtBillingAccountNo.TabIndex = 43
		Me.txtBillingAccountNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBillingAccountNo.AcceptsReturn = True
		Me.txtBillingAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBillingAccountNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtBillingAccountNo.CausesValidation = True
		Me.txtBillingAccountNo.Enabled = True
		Me.txtBillingAccountNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBillingAccountNo.HideSelection = True
		Me.txtBillingAccountNo.ReadOnly = False
		Me.txtBillingAccountNo.Maxlength = 0
		Me.txtBillingAccountNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBillingAccountNo.MultiLine = False
		Me.txtBillingAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBillingAccountNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBillingAccountNo.TabStop = True
		Me.txtBillingAccountNo.Visible = True
		Me.txtBillingAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBillingAccountNo.Name = "txtBillingAccountNo"
		Me.txtContractNumber.AutoSize = False
		Me.txtContractNumber.Size = New System.Drawing.Size(161, 19)
		Me.txtContractNumber.Location = New System.Drawing.Point(296, 120)
		Me.txtContractNumber.TabIndex = 41
		Me.txtContractNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContractNumber.AcceptsReturn = True
		Me.txtContractNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContractNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtContractNumber.CausesValidation = True
		Me.txtContractNumber.Enabled = True
		Me.txtContractNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContractNumber.HideSelection = True
		Me.txtContractNumber.ReadOnly = False
		Me.txtContractNumber.Maxlength = 0
		Me.txtContractNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContractNumber.MultiLine = False
		Me.txtContractNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContractNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContractNumber.TabStop = True
		Me.txtContractNumber.Visible = True
		Me.txtContractNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContractNumber.Name = "txtContractNumber"
		Me.cbNegativeSavingsFlag.Size = New System.Drawing.Size(57, 21)
		Me.cbNegativeSavingsFlag.Location = New System.Drawing.Point(144, 120)
		Me.cbNegativeSavingsFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbNegativeSavingsFlag.TabIndex = 20
		Me.cbNegativeSavingsFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbNegativeSavingsFlag.BackColor = System.Drawing.SystemColors.Window
		Me.cbNegativeSavingsFlag.CausesValidation = True
		Me.cbNegativeSavingsFlag.Enabled = True
		Me.cbNegativeSavingsFlag.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbNegativeSavingsFlag.IntegralHeight = True
		Me.cbNegativeSavingsFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbNegativeSavingsFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbNegativeSavingsFlag.Sorted = False
		Me.cbNegativeSavingsFlag.TabStop = True
		Me.cbNegativeSavingsFlag.Visible = True
		Me.cbNegativeSavingsFlag.Name = "cbNegativeSavingsFlag"
		Me.chkPayInvoices.Text = "Do NOT pay Invoices"
		Me.chkPayInvoices.Size = New System.Drawing.Size(137, 17)
		Me.chkPayInvoices.Location = New System.Drawing.Point(16, 152)
		Me.chkPayInvoices.TabIndex = 19
		Me.chkPayInvoices.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkPayInvoices.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkPayInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkPayInvoices.BackColor = System.Drawing.SystemColors.Control
		Me.chkPayInvoices.CausesValidation = True
		Me.chkPayInvoices.Enabled = True
		Me.chkPayInvoices.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkPayInvoices.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkPayInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkPayInvoices.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkPayInvoices.TabStop = True
		Me.chkPayInvoices.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkPayInvoices.Visible = True
		Me.chkPayInvoices.Name = "chkPayInvoices"
		Me.cbQBGroupId.Size = New System.Drawing.Size(89, 21)
		Me.cbQBGroupId.Location = New System.Drawing.Point(40, 512)
		Me.cbQBGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupId.TabIndex = 38
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
		Me.cbQBGroupId.TabStop = True
		Me.cbQBGroupId.Name = "cbQBGroupId"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(264, 512)
		Me.cmdCancel.TabIndex = 37
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
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(57, 33)
		Me.cmdOk.Location = New System.Drawing.Point(160, 512)
		Me.cmdOk.TabIndex = 36
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.frQuickBooks.Text = "Quick Books Settings"
		Me.frQuickBooks.Size = New System.Drawing.Size(337, 137)
		Me.frQuickBooks.Location = New System.Drawing.Point(16, 360)
		Me.frQuickBooks.TabIndex = 25
		Me.frQuickBooks.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frQuickBooks.BackColor = System.Drawing.SystemColors.Control
		Me.frQuickBooks.Enabled = True
		Me.frQuickBooks.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frQuickBooks.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frQuickBooks.Visible = True
		Me.frQuickBooks.Name = "frQuickBooks"
		Me.cbQBAccountName.Size = New System.Drawing.Size(177, 21)
		Me.cbQBAccountName.Location = New System.Drawing.Point(112, 88)
		Me.cbQBAccountName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBAccountName.TabIndex = 35
		Me.cbQBAccountName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBAccountName.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBAccountName.CausesValidation = True
		Me.cbQBAccountName.Enabled = True
		Me.cbQBAccountName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBAccountName.IntegralHeight = True
		Me.cbQBAccountName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBAccountName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBAccountName.Sorted = False
		Me.cbQBAccountName.TabStop = True
		Me.cbQBAccountName.Visible = True
		Me.cbQBAccountName.Name = "cbQBAccountName"
		Me.cbQBCustName.Size = New System.Drawing.Size(177, 21)
		Me.cbQBCustName.Location = New System.Drawing.Point(112, 56)
		Me.cbQBCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBCustName.TabIndex = 34
		Me.cbQBCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBCustName.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBCustName.CausesValidation = True
		Me.cbQBCustName.Enabled = True
		Me.cbQBCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBCustName.IntegralHeight = True
		Me.cbQBCustName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBCustName.Sorted = False
		Me.cbQBCustName.TabStop = True
		Me.cbQBCustName.Visible = True
		Me.cbQBCustName.Name = "cbQBCustName"
		Me.cbQBGroupDesc.Size = New System.Drawing.Size(177, 21)
		Me.cbQBGroupDesc.Location = New System.Drawing.Point(112, 24)
		Me.cbQBGroupDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupDesc.TabIndex = 33
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
		Me.Label15.Text = "Account Name"
		Me.Label15.Size = New System.Drawing.Size(81, 17)
		Me.Label15.Location = New System.Drawing.Point(16, 88)
		Me.Label15.TabIndex = 32
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
		Me.Label14.Text = "Customer Name"
		Me.Label14.Size = New System.Drawing.Size(81, 17)
		Me.Label14.Location = New System.Drawing.Point(16, 56)
		Me.Label14.TabIndex = 31
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
		Me.Label13.Text = "Company Group"
		Me.Label13.Size = New System.Drawing.Size(89, 17)
		Me.Label13.Location = New System.Drawing.Point(16, 24)
		Me.Label13.TabIndex = 30
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
		Me.txtCustReportName.AutoSize = False
		Me.txtCustReportName.Size = New System.Drawing.Size(361, 19)
		Me.txtCustReportName.Location = New System.Drawing.Point(96, 88)
		Me.txtCustReportName.TabIndex = 18
		Me.txtCustReportName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustReportName.AcceptsReturn = True
		Me.txtCustReportName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustReportName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustReportName.CausesValidation = True
		Me.txtCustReportName.Enabled = True
		Me.txtCustReportName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustReportName.HideSelection = True
		Me.txtCustReportName.ReadOnly = False
		Me.txtCustReportName.Maxlength = 0
		Me.txtCustReportName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustReportName.MultiLine = False
		Me.txtCustReportName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustReportName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustReportName.TabStop = True
		Me.txtCustReportName.Visible = True
		Me.txtCustReportName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustReportName.Name = "txtCustReportName"
		Me.Frame1.Text = "Main Address"
		Me.Frame1.Size = New System.Drawing.Size(449, 161)
		Me.Frame1.Location = New System.Drawing.Point(16, 184)
		Me.Frame1.TabIndex = 9
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.mtxtCustPhone3.AllowPromptAsInput = False
		Me.mtxtCustPhone3.Size = New System.Drawing.Size(105, 21)
		Me.mtxtCustPhone3.Location = New System.Drawing.Point(296, 120)
		Me.mtxtCustPhone3.TabIndex = 29
		Me.mtxtCustPhone3.MaxLength = 14
		Me.mtxtCustPhone3.Mask = "(###)-###-####"
		Me.mtxtCustPhone3.PromptChar = "_"
		Me.mtxtCustPhone3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtCustPhone3.Name = "mtxtCustPhone3"
		Me.mtxtCustPhone2.AllowPromptAsInput = False
		Me.mtxtCustPhone2.Size = New System.Drawing.Size(105, 21)
		Me.mtxtCustPhone2.Location = New System.Drawing.Point(296, 88)
		Me.mtxtCustPhone2.TabIndex = 28
		Me.mtxtCustPhone2.MaxLength = 14
		Me.mtxtCustPhone2.Mask = "(###)-###-####"
		Me.mtxtCustPhone2.PromptChar = "_"
		Me.mtxtCustPhone2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtCustPhone2.Name = "mtxtCustPhone2"
		Me.mtxtCustPhone1.AllowPromptAsInput = False
		Me.mtxtCustPhone1.Size = New System.Drawing.Size(105, 21)
		Me.mtxtCustPhone1.Location = New System.Drawing.Point(296, 56)
		Me.mtxtCustPhone1.TabIndex = 27
		Me.mtxtCustPhone1.MaxLength = 14
		Me.mtxtCustPhone1.Mask = "(###)-###-####"
		Me.mtxtCustPhone1.PromptChar = "_"
		Me.mtxtCustPhone1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtCustPhone1.Name = "mtxtCustPhone1"
		Me.cbState.Size = New System.Drawing.Size(81, 21)
		Me.cbState.Location = New System.Drawing.Point(64, 88)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 23
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
		Me.txtCustZip.AutoSize = False
		Me.txtCustZip.Size = New System.Drawing.Size(65, 19)
		Me.txtCustZip.Location = New System.Drawing.Point(64, 121)
		Me.txtCustZip.TabIndex = 24
		Me.txtCustZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustZip.AcceptsReturn = True
		Me.txtCustZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustZip.CausesValidation = True
		Me.txtCustZip.Enabled = True
		Me.txtCustZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustZip.HideSelection = True
		Me.txtCustZip.ReadOnly = False
		Me.txtCustZip.Maxlength = 0
		Me.txtCustZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustZip.MultiLine = False
		Me.txtCustZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustZip.TabStop = True
		Me.txtCustZip.Visible = True
		Me.txtCustZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustZip.Name = "txtCustZip"
		Me.txtCustCity.AutoSize = False
		Me.txtCustCity.Size = New System.Drawing.Size(121, 19)
		Me.txtCustCity.Location = New System.Drawing.Point(64, 57)
		Me.txtCustCity.TabIndex = 22
		Me.txtCustCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustCity.AcceptsReturn = True
		Me.txtCustCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustCity.CausesValidation = True
		Me.txtCustCity.Enabled = True
		Me.txtCustCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustCity.HideSelection = True
		Me.txtCustCity.ReadOnly = False
		Me.txtCustCity.Maxlength = 0
		Me.txtCustCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustCity.MultiLine = False
		Me.txtCustCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustCity.TabStop = True
		Me.txtCustCity.Visible = True
		Me.txtCustCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustCity.Name = "txtCustCity"
		Me.txtCustEmail.AutoSize = False
		Me.txtCustEmail.Size = New System.Drawing.Size(137, 19)
		Me.txtCustEmail.Location = New System.Drawing.Point(296, 24)
		Me.txtCustEmail.TabIndex = 26
		Me.txtCustEmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustEmail.AcceptsReturn = True
		Me.txtCustEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustEmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustEmail.CausesValidation = True
		Me.txtCustEmail.Enabled = True
		Me.txtCustEmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustEmail.HideSelection = True
		Me.txtCustEmail.ReadOnly = False
		Me.txtCustEmail.Maxlength = 0
		Me.txtCustEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustEmail.MultiLine = False
		Me.txtCustEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustEmail.TabStop = True
		Me.txtCustEmail.Visible = True
		Me.txtCustEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustEmail.Name = "txtCustEmail"
		Me.txtCustAddress.AutoSize = False
		Me.txtCustAddress.Size = New System.Drawing.Size(137, 19)
		Me.txtCustAddress.Location = New System.Drawing.Point(65, 24)
		Me.txtCustAddress.TabIndex = 21
		Me.txtCustAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustAddress.AcceptsReturn = True
		Me.txtCustAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustAddress.CausesValidation = True
		Me.txtCustAddress.Enabled = True
		Me.txtCustAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustAddress.HideSelection = True
		Me.txtCustAddress.ReadOnly = False
		Me.txtCustAddress.Maxlength = 0
		Me.txtCustAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustAddress.MultiLine = False
		Me.txtCustAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustAddress.TabStop = True
		Me.txtCustAddress.Visible = True
		Me.txtCustAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustAddress.Name = "txtCustAddress"
		Me.Label11.Text = "E-mail"
		Me.Label11.Size = New System.Drawing.Size(41, 17)
		Me.Label11.Location = New System.Drawing.Point(241, 25)
		Me.Label11.TabIndex = 17
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
		Me.Label10.Text = "Zip"
		Me.Label10.Size = New System.Drawing.Size(33, 17)
		Me.Label10.Location = New System.Drawing.Point(16, 122)
		Me.Label10.TabIndex = 16
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
		Me.Label9.Text = "State"
		Me.Label9.Size = New System.Drawing.Size(41, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 90)
		Me.Label9.TabIndex = 15
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
		Me.Label8.Text = "City"
		Me.Label8.Size = New System.Drawing.Size(33, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 58)
		Me.Label8.TabIndex = 14
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
		Me.Label7.Text = "Address"
		Me.Label7.Size = New System.Drawing.Size(41, 17)
		Me.Label7.Location = New System.Drawing.Point(17, 25)
		Me.Label7.TabIndex = 13
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
		Me.Label6.Text = "Phone 3"
		Me.Label6.Size = New System.Drawing.Size(49, 17)
		Me.Label6.Location = New System.Drawing.Point(240, 122)
		Me.Label6.TabIndex = 12
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
		Me.Label5.Text = "Phone 2"
		Me.Label5.Size = New System.Drawing.Size(49, 17)
		Me.Label5.Location = New System.Drawing.Point(240, 90)
		Me.Label5.TabIndex = 11
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
		Me.Label4.Text = "Phone 1"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(240, 58)
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
		Me.txtContactTitle.AutoSize = False
		Me.txtContactTitle.Size = New System.Drawing.Size(161, 19)
		Me.txtContactTitle.Location = New System.Drawing.Point(296, 56)
		Me.txtContactTitle.TabIndex = 8
		Me.txtContactTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContactTitle.AcceptsReturn = True
		Me.txtContactTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContactTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtContactTitle.CausesValidation = True
		Me.txtContactTitle.Enabled = True
		Me.txtContactTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContactTitle.HideSelection = True
		Me.txtContactTitle.ReadOnly = False
		Me.txtContactTitle.Maxlength = 0
		Me.txtContactTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContactTitle.MultiLine = False
		Me.txtContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContactTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContactTitle.TabStop = True
		Me.txtContactTitle.Visible = True
		Me.txtContactTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContactTitle.Name = "txtContactTitle"
		Me.txtCustContact.AutoSize = False
		Me.txtCustContact.Size = New System.Drawing.Size(121, 19)
		Me.txtCustContact.Location = New System.Drawing.Point(96, 56)
		Me.txtCustContact.TabIndex = 7
		Me.txtCustContact.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustContact.AcceptsReturn = True
		Me.txtCustContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustContact.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustContact.CausesValidation = True
		Me.txtCustContact.Enabled = True
		Me.txtCustContact.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustContact.HideSelection = True
		Me.txtCustContact.ReadOnly = False
		Me.txtCustContact.Maxlength = 0
		Me.txtCustContact.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustContact.MultiLine = False
		Me.txtCustContact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustContact.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustContact.TabStop = True
		Me.txtCustContact.Visible = True
		Me.txtCustContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustContact.Name = "txtCustContact"
		Me.txtCustName.AutoSize = False
		Me.txtCustName.Size = New System.Drawing.Size(161, 19)
		Me.txtCustName.Location = New System.Drawing.Point(296, 16)
		Me.txtCustName.TabIndex = 3
		Me.txtCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustName.AcceptsReturn = True
		Me.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustName.CausesValidation = True
		Me.txtCustName.Enabled = True
		Me.txtCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustName.HideSelection = True
		Me.txtCustName.ReadOnly = False
		Me.txtCustName.Maxlength = 0
		Me.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustName.MultiLine = False
		Me.txtCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustName.TabStop = True
		Me.txtCustName.Visible = True
		Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustName.Name = "txtCustName"
		Me.txtCustId.AutoSize = False
		Me.txtCustId.Size = New System.Drawing.Size(41, 19)
		Me.txtCustId.Location = New System.Drawing.Point(96, 16)
		Me.txtCustId.TabIndex = 1
		Me.txtCustId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustId.AcceptsReturn = True
		Me.txtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustId.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustId.CausesValidation = True
		Me.txtCustId.Enabled = True
		Me.txtCustId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustId.HideSelection = True
		Me.txtCustId.ReadOnly = False
		Me.txtCustId.Maxlength = 0
		Me.txtCustId.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustId.MultiLine = False
		Me.txtCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustId.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustId.TabStop = True
		Me.txtCustId.Visible = True
		Me.txtCustId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustId.Name = "txtCustId"
		Me.Label19.Text = "Billing Account"
		Me.Label19.Size = New System.Drawing.Size(73, 25)
		Me.Label19.Location = New System.Drawing.Point(216, 152)
		Me.Label19.TabIndex = 42
		Me.Label19.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label19.BackColor = System.Drawing.SystemColors.Control
		Me.Label19.Enabled = True
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.UseMnemonic = True
		Me.Label19.Visible = True
		Me.Label19.AutoSize = False
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Name = "Label19"
		Me.Label18.Text = "Contract No."
		Me.Label18.Size = New System.Drawing.Size(65, 25)
		Me.Label18.Location = New System.Drawing.Point(232, 120)
		Me.Label18.TabIndex = 40
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
		Me.label17.Text = "Show Negative Savings"
		Me.label17.Size = New System.Drawing.Size(121, 17)
		Me.label17.Location = New System.Drawing.Point(16, 120)
		Me.label17.TabIndex = 39
		Me.label17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label17.BackColor = System.Drawing.SystemColors.Control
		Me.label17.Enabled = True
		Me.label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label17.UseMnemonic = True
		Me.label17.Visible = True
		Me.label17.AutoSize = False
		Me.label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label17.Name = "label17"
		Me.Label16.Text = "Report Caption"
		Me.Label16.Size = New System.Drawing.Size(73, 17)
		Me.Label16.Location = New System.Drawing.Point(16, 88)
		Me.Label16.TabIndex = 6
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
		Me.Label12.Text = "Title"
		Me.Label12.Size = New System.Drawing.Size(33, 17)
		Me.Label12.Location = New System.Drawing.Point(240, 56)
		Me.Label12.TabIndex = 5
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
		Me.Label3.Text = "Contact Name"
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 56)
		Me.Label3.TabIndex = 4
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
		Me.Label2.Text = "Name"
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.Location = New System.Drawing.Point(240, 24)
		Me.Label2.TabIndex = 2
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
		Me.Label1.Text = "ID"
		Me.Label1.Size = New System.Drawing.Size(25, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.TabIndex = 0
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
		Me.Controls.Add(txtBillingAccountNo)
		Me.Controls.Add(txtContractNumber)
		Me.Controls.Add(cbNegativeSavingsFlag)
		Me.Controls.Add(chkPayInvoices)
		Me.Controls.Add(cbQBGroupId)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(frQuickBooks)
		Me.Controls.Add(txtCustReportName)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(txtContactTitle)
		Me.Controls.Add(txtCustContact)
		Me.Controls.Add(txtCustName)
		Me.Controls.Add(txtCustId)
		Me.Controls.Add(Label19)
		Me.Controls.Add(Label18)
		Me.Controls.Add(label17)
		Me.Controls.Add(Label16)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.frQuickBooks.Controls.Add(cbQBAccountName)
		Me.frQuickBooks.Controls.Add(cbQBCustName)
		Me.frQuickBooks.Controls.Add(cbQBGroupDesc)
		Me.frQuickBooks.Controls.Add(Label15)
		Me.frQuickBooks.Controls.Add(Label14)
		Me.frQuickBooks.Controls.Add(Label13)
		Me.Frame1.Controls.Add(mtxtCustPhone3)
		Me.Frame1.Controls.Add(mtxtCustPhone2)
		Me.Frame1.Controls.Add(mtxtCustPhone1)
		Me.Frame1.Controls.Add(cbState)
		Me.Frame1.Controls.Add(txtCustZip)
		Me.Frame1.Controls.Add(txtCustCity)
		Me.Frame1.Controls.Add(txtCustEmail)
		Me.Frame1.Controls.Add(txtCustAddress)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.frQuickBooks.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class