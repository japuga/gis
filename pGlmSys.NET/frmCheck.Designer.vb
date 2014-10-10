<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheck
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtCheckNo As System.Windows.Forms.TextBox
	Public WithEvents cbBankAccount As System.Windows.Forms.ComboBox
	Public WithEvents cbBankName As System.Windows.Forms.ComboBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Account As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents frCheck As System.Windows.Forms.GroupBox
	Public WithEvents obCreditCard As System.Windows.Forms.RadioButton
	Public WithEvents obCheck As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cbVendPayZip As System.Windows.Forms.ComboBox
	Public WithEvents cbVendPayCity As System.Windows.Forms.ComboBox
	Public WithEvents cbVendPayment As System.Windows.Forms.ComboBox
	Public WithEvents cmdVBranch As System.Windows.Forms.Button
	Public WithEvents cbVendPayAddress As System.Windows.Forms.ComboBox
	Public WithEvents dgPending As AxMSDataGridLib.AxDataGrid
	Public WithEvents cbCustomerName As System.Windows.Forms.ComboBox
	Public WithEvents cmdDrop As System.Windows.Forms.Button
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cbCustomer As System.Windows.Forms.ComboBox
	Public WithEvents dgSelected As AxMSDataGridLib.AxDataGrid
	Public WithEvents txtAmount As System.Windows.Forms.MaskedTextBox
	Public WithEvents dtTranDate As AxMSComCtl2.AxDTPicker
	Public WithEvents txtAuthorizationCode As System.Windows.Forms.TextBox
	Public WithEvents cbCardNumber As System.Windows.Forms.ComboBox
	Public WithEvents cbCardBankName As System.Windows.Forms.ComboBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents frCreditCard As System.Windows.Forms.GroupBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheck))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command1 = New System.Windows.Forms.Button
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.frCheck = New System.Windows.Forms.GroupBox
		Me.txtCheckNo = New System.Windows.Forms.TextBox
		Me.cbBankAccount = New System.Windows.Forms.ComboBox
		Me.cbBankName = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Account = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.obCreditCard = New System.Windows.Forms.RadioButton
		Me.obCheck = New System.Windows.Forms.RadioButton
		Me.cbVendPayZip = New System.Windows.Forms.ComboBox
		Me.cbVendPayCity = New System.Windows.Forms.ComboBox
		Me.cbVendPayment = New System.Windows.Forms.ComboBox
		Me.cmdVBranch = New System.Windows.Forms.Button
		Me.cbVendPayAddress = New System.Windows.Forms.ComboBox
		Me.dgPending = New AxMSDataGridLib.AxDataGrid
		Me.cbCustomerName = New System.Windows.Forms.ComboBox
		Me.cmdDrop = New System.Windows.Forms.Button
		Me.cmdAdd = New System.Windows.Forms.Button
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cbCustomer = New System.Windows.Forms.ComboBox
		Me.dgSelected = New AxMSDataGridLib.AxDataGrid
		Me.txtAmount = New System.Windows.Forms.MaskedTextBox
		Me.frCreditCard = New System.Windows.Forms.GroupBox
		Me.dtTranDate = New AxMSComCtl2.AxDTPicker
		Me.txtAuthorizationCode = New System.Windows.Forms.TextBox
		Me.cbCardNumber = New System.Windows.Forms.ComboBox
		Me.cbCardBankName = New System.Windows.Forms.ComboBox
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.frCheck.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.frCreditCard.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgPending, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelected, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtTranDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.Info
		Me.Text = "Check Generation"
		Me.ClientSize = New System.Drawing.Size(632, 519)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
		Me.Name = "frmCheck"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Command1"
		Me.Command1.Size = New System.Drawing.Size(97, 17)
		Me.Command1.Location = New System.Drawing.Point(448, 480)
		Me.Command1.TabIndex = 16
		Me.Command1.Visible = False
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(169, 41)
		Me.Text1.Location = New System.Drawing.Point(424, 440)
		Me.Text1.TabIndex = 15
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
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 41)
		Me.cmdCancel.Location = New System.Drawing.Point(328, 456)
		Me.cmdCancel.TabIndex = 8
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
		Me.cmdOk.Size = New System.Drawing.Size(57, 41)
		Me.cmdOk.Location = New System.Drawing.Point(248, 456)
		Me.cmdOk.TabIndex = 7
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.Frame1.BackColor = System.Drawing.SystemColors.Window
		Me.Frame1.Text = "Invoice Criteria"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Frame1.Size = New System.Drawing.Size(609, 441)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.frCheck.BackColor = System.Drawing.SystemColors.highlightText
		Me.frCheck.Text = "Check"
		Me.frCheck.Size = New System.Drawing.Size(201, 129)
		Me.frCheck.Location = New System.Drawing.Point(328, 24)
		Me.frCheck.TabIndex = 29
		Me.frCheck.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frCheck.Enabled = True
		Me.frCheck.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frCheck.Visible = True
		Me.frCheck.Name = "frCheck"
		Me.txtCheckNo.AutoSize = False
		Me.txtCheckNo.Size = New System.Drawing.Size(105, 21)
		Me.txtCheckNo.Location = New System.Drawing.Point(56, 88)
		Me.txtCheckNo.TabIndex = 32
		Me.txtCheckNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCheckNo.AcceptsReturn = True
		Me.txtCheckNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCheckNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtCheckNo.CausesValidation = True
		Me.txtCheckNo.Enabled = True
		Me.txtCheckNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCheckNo.HideSelection = True
		Me.txtCheckNo.ReadOnly = False
		Me.txtCheckNo.Maxlength = 0
		Me.txtCheckNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCheckNo.MultiLine = False
		Me.txtCheckNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCheckNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCheckNo.TabStop = True
		Me.txtCheckNo.Visible = True
		Me.txtCheckNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCheckNo.Name = "txtCheckNo"
		Me.cbBankAccount.Size = New System.Drawing.Size(137, 21)
		Me.cbBankAccount.Location = New System.Drawing.Point(56, 56)
		Me.cbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankAccount.TabIndex = 31
		Me.cbBankAccount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBankAccount.BackColor = System.Drawing.SystemColors.Window
		Me.cbBankAccount.CausesValidation = True
		Me.cbBankAccount.Enabled = True
		Me.cbBankAccount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbBankAccount.IntegralHeight = True
		Me.cbBankAccount.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbBankAccount.Sorted = False
		Me.cbBankAccount.TabStop = True
		Me.cbBankAccount.Visible = True
		Me.cbBankAccount.Name = "cbBankAccount"
		Me.cbBankName.Size = New System.Drawing.Size(137, 21)
		Me.cbBankName.Location = New System.Drawing.Point(56, 24)
		Me.cbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankName.TabIndex = 30
		Me.cbBankName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBankName.BackColor = System.Drawing.SystemColors.Window
		Me.cbBankName.CausesValidation = True
		Me.cbBankName.Enabled = True
		Me.cbBankName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbBankName.IntegralHeight = True
		Me.cbBankName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbBankName.Sorted = False
		Me.cbBankName.TabStop = True
		Me.cbBankName.Visible = True
		Me.cbBankName.Name = "cbBankName"
		Me.Label7.BackColor = System.Drawing.SystemColors.Window
		Me.Label7.Text = "Check #"
		Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label7.Size = New System.Drawing.Size(49, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 88)
		Me.Label7.TabIndex = 35
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Account.BackColor = System.Drawing.Color.White
		Me.Account.Text = "Account"
		Me.Account.Size = New System.Drawing.Size(49, 17)
		Me.Account.Location = New System.Drawing.Point(8, 56)
		Me.Account.TabIndex = 34
		Me.Account.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Account.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Account.Enabled = True
		Me.Account.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Account.Cursor = System.Windows.Forms.Cursors.Default
		Me.Account.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Account.UseMnemonic = True
		Me.Account.Visible = True
		Me.Account.AutoSize = False
		Me.Account.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Account.Name = "Account"
		Me.Label8.BackColor = System.Drawing.Color.White
		Me.Label8.Text = "Bank"
		Me.Label8.Size = New System.Drawing.Size(41, 17)
		Me.Label8.Location = New System.Drawing.Point(8, 24)
		Me.Label8.TabIndex = 33
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Frame2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Frame2.Text = "Payment Type"
		Me.Frame2.ForeColor = System.Drawing.Color.Red
		Me.Frame2.Size = New System.Drawing.Size(201, 41)
		Me.Frame2.Location = New System.Drawing.Point(8, 144)
		Me.Frame2.TabIndex = 25
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.obCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCreditCard.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.obCreditCard.Text = "Credit Card"
		Me.obCreditCard.Size = New System.Drawing.Size(81, 17)
		Me.obCreditCard.Location = New System.Drawing.Point(104, 16)
		Me.obCreditCard.TabIndex = 27
		Me.obCreditCard.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obCreditCard.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCreditCard.CausesValidation = True
		Me.obCreditCard.Enabled = True
		Me.obCreditCard.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obCreditCard.Cursor = System.Windows.Forms.Cursors.Default
		Me.obCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obCreditCard.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obCreditCard.TabStop = True
		Me.obCreditCard.Checked = False
		Me.obCreditCard.Visible = True
		Me.obCreditCard.Name = "obCreditCard"
		Me.obCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.obCheck.Text = "Check"
		Me.obCheck.Size = New System.Drawing.Size(65, 17)
		Me.obCheck.Location = New System.Drawing.Point(24, 16)
		Me.obCheck.TabIndex = 26
		Me.obCheck.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCheck.CausesValidation = True
		Me.obCheck.Enabled = True
		Me.obCheck.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obCheck.Cursor = System.Windows.Forms.Cursors.Default
		Me.obCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obCheck.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obCheck.TabStop = True
		Me.obCheck.Checked = False
		Me.obCheck.Visible = True
		Me.obCheck.Name = "obCheck"
		Me.cbVendPayZip.Size = New System.Drawing.Size(97, 21)
		Me.cbVendPayZip.Location = New System.Drawing.Point(272, 376)
		Me.cbVendPayZip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendPayZip.TabIndex = 24
		Me.cbVendPayZip.Visible = False
		Me.cbVendPayZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendPayZip.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendPayZip.CausesValidation = True
		Me.cbVendPayZip.Enabled = True
		Me.cbVendPayZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendPayZip.IntegralHeight = True
		Me.cbVendPayZip.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendPayZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendPayZip.Sorted = False
		Me.cbVendPayZip.TabStop = True
		Me.cbVendPayZip.Name = "cbVendPayZip"
		Me.cbVendPayCity.Size = New System.Drawing.Size(97, 21)
		Me.cbVendPayCity.Location = New System.Drawing.Point(272, 360)
		Me.cbVendPayCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendPayCity.TabIndex = 23
		Me.cbVendPayCity.Visible = False
		Me.cbVendPayCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendPayCity.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendPayCity.CausesValidation = True
		Me.cbVendPayCity.Enabled = True
		Me.cbVendPayCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendPayCity.IntegralHeight = True
		Me.cbVendPayCity.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendPayCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendPayCity.Sorted = False
		Me.cbVendPayCity.TabStop = True
		Me.cbVendPayCity.Name = "cbVendPayCity"
		Me.cbVendPayment.Size = New System.Drawing.Size(249, 21)
		Me.cbVendPayment.Location = New System.Drawing.Point(56, 88)
		Me.cbVendPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendPayment.TabIndex = 22
		Me.cbVendPayment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendPayment.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendPayment.CausesValidation = True
		Me.cbVendPayment.Enabled = True
		Me.cbVendPayment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendPayment.IntegralHeight = True
		Me.cbVendPayment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendPayment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendPayment.Sorted = False
		Me.cbVendPayment.TabStop = True
		Me.cbVendPayment.Visible = True
		Me.cbVendPayment.Name = "cbVendPayment"
		Me.cmdVBranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdVBranch.Size = New System.Drawing.Size(41, 40)
		Me.cmdVBranch.Location = New System.Drawing.Point(224, 112)
		Me.cmdVBranch.Image = CType(resources.GetObject("cmdVBranch.Image"), System.Drawing.Image)
		Me.cmdVBranch.TabIndex = 20
		Me.cmdVBranch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdVBranch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdVBranch.CausesValidation = True
		Me.cmdVBranch.Enabled = True
		Me.cmdVBranch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdVBranch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdVBranch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdVBranch.TabStop = True
		Me.cmdVBranch.Name = "cmdVBranch"
		Me.cbVendPayAddress.Size = New System.Drawing.Size(249, 21)
		Me.cbVendPayAddress.Location = New System.Drawing.Point(272, 344)
		Me.cbVendPayAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendPayAddress.TabIndex = 19
		Me.cbVendPayAddress.Visible = False
		Me.cbVendPayAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendPayAddress.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendPayAddress.CausesValidation = True
		Me.cbVendPayAddress.Enabled = True
		Me.cbVendPayAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendPayAddress.IntegralHeight = True
		Me.cbVendPayAddress.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendPayAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendPayAddress.Sorted = False
		Me.cbVendPayAddress.TabStop = True
		Me.cbVendPayAddress.Name = "cbVendPayAddress"
		dgPending.OcxState = CType(resources.GetObject("dgPending.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgPending.Size = New System.Drawing.Size(249, 217)
		Me.dgPending.Location = New System.Drawing.Point(16, 216)
		Me.dgPending.TabIndex = 12
		Me.dgPending.Name = "dgPending"
		Me.cbCustomerName.Enabled = False
		Me.cbCustomerName.Size = New System.Drawing.Size(145, 21)
		Me.cbCustomerName.Location = New System.Drawing.Point(144, 24)
		Me.cbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.cbCustomerName.TabIndex = 2
		Me.cbCustomerName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustomerName.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustomerName.CausesValidation = True
		Me.cbCustomerName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustomerName.IntegralHeight = True
		Me.cbCustomerName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustomerName.Sorted = False
		Me.cbCustomerName.TabStop = True
		Me.cbCustomerName.Visible = True
		Me.cbCustomerName.Name = "cbCustomerName"
		Me.cmdDrop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdDrop.Size = New System.Drawing.Size(33, 32)
		Me.cmdDrop.Location = New System.Drawing.Point(288, 312)
		Me.cmdDrop.Image = CType(resources.GetObject("cmdDrop.Image"), System.Drawing.Image)
		Me.cmdDrop.TabIndex = 6
		Me.cmdDrop.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDrop.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDrop.CausesValidation = True
		Me.cmdDrop.Enabled = True
		Me.cmdDrop.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDrop.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDrop.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDrop.TabStop = True
		Me.cmdDrop.Name = "cmdDrop"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAdd.Size = New System.Drawing.Size(33, 32)
		Me.cmdAdd.Location = New System.Drawing.Point(288, 272)
		Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
		Me.cmdAdd.TabIndex = 5
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		Me.cbState.Size = New System.Drawing.Size(65, 21)
		Me.cbState.Location = New System.Drawing.Point(56, 120)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 4
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
		Me.cbVendor.Size = New System.Drawing.Size(249, 21)
		Me.cbVendor.Location = New System.Drawing.Point(56, 56)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 3
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
		Me.cbCustomer.Size = New System.Drawing.Size(73, 21)
		Me.cbCustomer.Location = New System.Drawing.Point(56, 24)
		Me.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustomer.TabIndex = 1
		Me.cbCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustomer.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustomer.CausesValidation = True
		Me.cbCustomer.Enabled = True
		Me.cbCustomer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustomer.IntegralHeight = True
		Me.cbCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustomer.Sorted = False
		Me.cbCustomer.TabStop = True
		Me.cbCustomer.Visible = True
		Me.cbCustomer.Name = "cbCustomer"
		dgSelected.OcxState = CType(resources.GetObject("dgSelected.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelected.Size = New System.Drawing.Size(249, 217)
		Me.dgSelected.Location = New System.Drawing.Point(344, 216)
		Me.dgSelected.TabIndex = 17
		Me.dgSelected.Name = "dgSelected"
		Me.txtAmount.AllowPromptAsInput = False
		Me.txtAmount.Size = New System.Drawing.Size(105, 21)
		Me.txtAmount.Location = New System.Drawing.Point(384, 160)
		Me.txtAmount.TabIndex = 44
		Me.txtAmount.TabStop = 0
		Me.txtAmount.BackColor = System.Drawing.SystemColors.Info
		Me.txtAmount.Enabled = False
		Me.txtAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAmount.PromptChar = "_"
		Me.txtAmount.Name = "txtAmount"
		Me.frCreditCard.BackColor = System.Drawing.SystemColors.highlightText
		Me.frCreditCard.Text = "Credit Card"
		Me.frCreditCard.Size = New System.Drawing.Size(217, 145)
		Me.frCreditCard.Location = New System.Drawing.Point(328, 8)
		Me.frCreditCard.TabIndex = 28
		Me.frCreditCard.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frCreditCard.Enabled = True
		Me.frCreditCard.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frCreditCard.Visible = True
		Me.frCreditCard.Name = "frCreditCard"
		dtTranDate.OcxState = CType(resources.GetObject("dtTranDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtTranDate.Size = New System.Drawing.Size(105, 21)
		Me.dtTranDate.Location = New System.Drawing.Point(72, 112)
		Me.dtTranDate.TabIndex = 43
		Me.dtTranDate.Name = "dtTranDate"
		Me.txtAuthorizationCode.AutoSize = False
		Me.txtAuthorizationCode.Size = New System.Drawing.Size(113, 19)
		Me.txtAuthorizationCode.Location = New System.Drawing.Point(72, 88)
		Me.txtAuthorizationCode.TabIndex = 42
		Me.txtAuthorizationCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAuthorizationCode.AcceptsReturn = True
		Me.txtAuthorizationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAuthorizationCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtAuthorizationCode.CausesValidation = True
		Me.txtAuthorizationCode.Enabled = True
		Me.txtAuthorizationCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAuthorizationCode.HideSelection = True
		Me.txtAuthorizationCode.ReadOnly = False
		Me.txtAuthorizationCode.Maxlength = 0
		Me.txtAuthorizationCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAuthorizationCode.MultiLine = False
		Me.txtAuthorizationCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAuthorizationCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAuthorizationCode.TabStop = True
		Me.txtAuthorizationCode.Visible = True
		Me.txtAuthorizationCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAuthorizationCode.Name = "txtAuthorizationCode"
		Me.cbCardNumber.Size = New System.Drawing.Size(137, 21)
		Me.cbCardNumber.Location = New System.Drawing.Point(72, 56)
		Me.cbCardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCardNumber.TabIndex = 41
		Me.cbCardNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCardNumber.BackColor = System.Drawing.SystemColors.Window
		Me.cbCardNumber.CausesValidation = True
		Me.cbCardNumber.Enabled = True
		Me.cbCardNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCardNumber.IntegralHeight = True
		Me.cbCardNumber.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCardNumber.Sorted = False
		Me.cbCardNumber.TabStop = True
		Me.cbCardNumber.Visible = True
		Me.cbCardNumber.Name = "cbCardNumber"
		Me.cbCardBankName.Size = New System.Drawing.Size(137, 21)
		Me.cbCardBankName.Location = New System.Drawing.Point(72, 24)
		Me.cbCardBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCardBankName.TabIndex = 40
		Me.cbCardBankName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCardBankName.BackColor = System.Drawing.SystemColors.Window
		Me.cbCardBankName.CausesValidation = True
		Me.cbCardBankName.Enabled = True
		Me.cbCardBankName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCardBankName.IntegralHeight = True
		Me.cbCardBankName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCardBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCardBankName.Sorted = False
		Me.cbCardBankName.TabStop = True
		Me.cbCardBankName.Visible = True
		Me.cbCardBankName.Name = "cbCardBankName"
		Me.Label14.BackColor = System.Drawing.Color.White
		Me.Label14.Text = "Date"
		Me.Label14.Size = New System.Drawing.Size(41, 17)
		Me.Label14.Location = New System.Drawing.Point(8, 112)
		Me.Label14.TabIndex = 39
		Me.Label14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label13.BackColor = System.Drawing.Color.White
		Me.Label13.Text = "Auth Code"
		Me.Label13.Size = New System.Drawing.Size(105, 17)
		Me.Label13.Location = New System.Drawing.Point(8, 88)
		Me.Label13.TabIndex = 38
		Me.Label13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label12.BackColor = System.Drawing.Color.White
		Me.Label12.Text = "Credit Card"
		Me.Label12.Size = New System.Drawing.Size(65, 17)
		Me.Label12.Location = New System.Drawing.Point(8, 56)
		Me.Label12.TabIndex = 37
		Me.Label12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label11.BackColor = System.Drawing.Color.White
		Me.Label11.Text = "Bank"
		Me.Label11.Size = New System.Drawing.Size(33, 17)
		Me.Label11.Location = New System.Drawing.Point(8, 24)
		Me.Label11.TabIndex = 36
		Me.Label11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "Amount"
		Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.Location = New System.Drawing.Point(328, 160)
		Me.Label6.TabIndex = 45
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label10.Text = "View Branches"
		Me.Label10.Size = New System.Drawing.Size(81, 17)
		Me.Label10.Location = New System.Drawing.Point(144, 120)
		Me.Label10.TabIndex = 21
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label9.Text = "Payment Address"
		Me.Label9.Size = New System.Drawing.Size(57, 25)
		Me.Label9.Location = New System.Drawing.Point(8, 80)
		Me.Label9.TabIndex = 18
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.Label5.Text = "Selected Invoices"
		Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label5.Size = New System.Drawing.Size(249, 25)
		Me.Label5.Location = New System.Drawing.Point(344, 192)
		Me.Label5.TabIndex = 14
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.Name = "Label5"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.Label4.Text = "Pending Invoices"
		Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label4.Size = New System.Drawing.Size(249, 25)
		Me.Label4.Location = New System.Drawing.Point(16, 192)
		Me.Label4.TabIndex = 13
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Name = "Label4"
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "State"
		Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 120)
		Me.Label3.TabIndex = 11
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.BackColor = System.Drawing.SystemColors.Window
		Me.Label2.Text = "Vendor"
		Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label2.Size = New System.Drawing.Size(49, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.TabIndex = 10
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "Customer"
		Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 24)
		Me.Label1.TabIndex = 9
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Command1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(frCheck)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame1.Controls.Add(cbVendPayZip)
		Me.Frame1.Controls.Add(cbVendPayCity)
		Me.Frame1.Controls.Add(cbVendPayment)
		Me.Frame1.Controls.Add(cmdVBranch)
		Me.Frame1.Controls.Add(cbVendPayAddress)
		Me.Frame1.Controls.Add(dgPending)
		Me.Frame1.Controls.Add(cbCustomerName)
		Me.Frame1.Controls.Add(cmdDrop)
		Me.Frame1.Controls.Add(cmdAdd)
		Me.Frame1.Controls.Add(cbState)
		Me.Frame1.Controls.Add(cbVendor)
		Me.Frame1.Controls.Add(cbCustomer)
		Me.Frame1.Controls.Add(dgSelected)
		Me.Frame1.Controls.Add(txtAmount)
		Me.Frame1.Controls.Add(frCreditCard)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.frCheck.Controls.Add(txtCheckNo)
		Me.frCheck.Controls.Add(cbBankAccount)
		Me.frCheck.Controls.Add(cbBankName)
		Me.frCheck.Controls.Add(Label7)
		Me.frCheck.Controls.Add(Account)
		Me.frCheck.Controls.Add(Label8)
		Me.Frame2.Controls.Add(obCreditCard)
		Me.Frame2.Controls.Add(obCheck)
		Me.frCreditCard.Controls.Add(dtTranDate)
		Me.frCreditCard.Controls.Add(txtAuthorizationCode)
		Me.frCreditCard.Controls.Add(cbCardNumber)
		Me.frCreditCard.Controls.Add(cbCardBankName)
		Me.frCreditCard.Controls.Add(Label14)
		Me.frCreditCard.Controls.Add(Label13)
		Me.frCreditCard.Controls.Add(Label12)
		Me.frCreditCard.Controls.Add(Label11)
		CType(Me.dtTranDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSelected, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgPending, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.frCheck.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.frCreditCard.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class