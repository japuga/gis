<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckBrowse
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
	Public WithEvents txtToCheck As System.Windows.Forms.TextBox
	Public WithEvents txtFromCheck As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents frChecks As System.Windows.Forms.GroupBox
	Public WithEvents chCheckRange As System.Windows.Forms.CheckBox
	Public WithEvents chDates As System.Windows.Forms.CheckBox
	Public WithEvents dtEnd As AxMSComCtl2.AxDTPicker
	Public WithEvents dtStart As AxMSComCtl2.AxDTPicker
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents frDates As System.Windows.Forms.GroupBox
	Public WithEvents cbBankAccount As System.Windows.Forms.ComboBox
	Public WithEvents cbBank As System.Windows.Forms.ComboBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents label2 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckBrowse))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.frChecks = New System.Windows.Forms.GroupBox
		Me.txtToCheck = New System.Windows.Forms.TextBox
		Me.txtFromCheck = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.chCheckRange = New System.Windows.Forms.CheckBox
		Me.chDates = New System.Windows.Forms.CheckBox
		Me.frDates = New System.Windows.Forms.GroupBox
		Me.dtEnd = New AxMSComCtl2.AxDTPicker
		Me.dtStart = New AxMSComCtl2.AxDTPicker
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.cbBankAccount = New System.Windows.Forms.ComboBox
		Me.cbBank = New System.Windows.Forms.ComboBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdSearch = New System.Windows.Forms.Button
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.label2 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.frChecks.SuspendLayout()
		Me.frDates.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtStart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.Info
		Me.Text = "Check Query"
		Me.ClientSize = New System.Drawing.Size(434, 475)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "frmCheckBrowse"
		Me.Frame1.BackColor = System.Drawing.SystemColors.Info
		Me.Frame1.Text = "Search Criteria"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Size = New System.Drawing.Size(385, 457)
		Me.Frame1.Location = New System.Drawing.Point(24, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Frame2.BackColor = System.Drawing.SystemColors.Window
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Frame2.Size = New System.Drawing.Size(353, 425)
		Me.Frame2.Location = New System.Drawing.Point(16, 16)
		Me.Frame2.TabIndex = 1
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.frChecks.BackColor = System.Drawing.Color.White
		Me.frChecks.Size = New System.Drawing.Size(225, 81)
		Me.frChecks.Location = New System.Drawing.Point(80, 184)
		Me.frChecks.TabIndex = 20
		Me.frChecks.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frChecks.Enabled = True
		Me.frChecks.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frChecks.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frChecks.Visible = True
		Me.frChecks.Name = "frChecks"
		Me.txtToCheck.AutoSize = False
		Me.txtToCheck.Size = New System.Drawing.Size(89, 21)
		Me.txtToCheck.Location = New System.Drawing.Point(56, 48)
		Me.txtToCheck.TabIndex = 24
		Me.txtToCheck.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtToCheck.AcceptsReturn = True
		Me.txtToCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtToCheck.BackColor = System.Drawing.SystemColors.Window
		Me.txtToCheck.CausesValidation = True
		Me.txtToCheck.Enabled = True
		Me.txtToCheck.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtToCheck.HideSelection = True
		Me.txtToCheck.ReadOnly = False
		Me.txtToCheck.Maxlength = 0
		Me.txtToCheck.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtToCheck.MultiLine = False
		Me.txtToCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtToCheck.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtToCheck.TabStop = True
		Me.txtToCheck.Visible = True
		Me.txtToCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtToCheck.Name = "txtToCheck"
		Me.txtFromCheck.AutoSize = False
		Me.txtFromCheck.Size = New System.Drawing.Size(89, 21)
		Me.txtFromCheck.Location = New System.Drawing.Point(56, 16)
		Me.txtFromCheck.TabIndex = 23
		Me.txtFromCheck.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFromCheck.AcceptsReturn = True
		Me.txtFromCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFromCheck.BackColor = System.Drawing.SystemColors.Window
		Me.txtFromCheck.CausesValidation = True
		Me.txtFromCheck.Enabled = True
		Me.txtFromCheck.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFromCheck.HideSelection = True
		Me.txtFromCheck.ReadOnly = False
		Me.txtFromCheck.Maxlength = 0
		Me.txtFromCheck.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFromCheck.MultiLine = False
		Me.txtFromCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFromCheck.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFromCheck.TabStop = True
		Me.txtFromCheck.Visible = True
		Me.txtFromCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFromCheck.Name = "txtFromCheck"
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Text = "To #"
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 48)
		Me.Label3.TabIndex = 22
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Text = "From #"
		Me.Label1.Size = New System.Drawing.Size(37, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.TabIndex = 21
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.chCheckRange.BackColor = System.Drawing.Color.White
		Me.chCheckRange.Text = "Checks Range"
		Me.chCheckRange.Size = New System.Drawing.Size(105, 17)
		Me.chCheckRange.Location = New System.Drawing.Point(32, 168)
		Me.chCheckRange.TabIndex = 19
		Me.chCheckRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chCheckRange.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chCheckRange.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chCheckRange.CausesValidation = True
		Me.chCheckRange.Enabled = True
		Me.chCheckRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chCheckRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.chCheckRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chCheckRange.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chCheckRange.TabStop = True
		Me.chCheckRange.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chCheckRange.Visible = True
		Me.chCheckRange.Name = "chCheckRange"
		Me.chDates.BackColor = System.Drawing.Color.White
		Me.chDates.Text = "Checks Printed on"
		Me.chDates.Size = New System.Drawing.Size(129, 17)
		Me.chDates.Location = New System.Drawing.Point(32, 272)
		Me.chDates.TabIndex = 14
		Me.chDates.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chDates.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chDates.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chDates.CausesValidation = True
		Me.chDates.Enabled = True
		Me.chDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chDates.Cursor = System.Windows.Forms.Cursors.Default
		Me.chDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chDates.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chDates.TabStop = True
		Me.chDates.Visible = True
		Me.chDates.Name = "chDates"
		Me.frDates.BackColor = System.Drawing.Color.White
		Me.frDates.Size = New System.Drawing.Size(225, 73)
		Me.frDates.Location = New System.Drawing.Point(80, 288)
		Me.frDates.TabIndex = 13
		Me.frDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frDates.Enabled = True
		Me.frDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frDates.Visible = True
		Me.frDates.Name = "frDates"
		dtEnd.OcxState = CType(resources.GetObject("dtEnd.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtEnd.Size = New System.Drawing.Size(105, 21)
		Me.dtEnd.Location = New System.Drawing.Point(48, 40)
		Me.dtEnd.TabIndex = 18
		Me.dtEnd.Name = "dtEnd"
		dtStart.OcxState = CType(resources.GetObject("dtStart.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtStart.Size = New System.Drawing.Size(105, 21)
		Me.dtStart.Location = New System.Drawing.Point(48, 16)
		Me.dtStart.TabIndex = 17
		Me.dtStart.Name = "dtStart"
		Me.Label8.BackColor = System.Drawing.Color.White
		Me.Label8.Text = "To"
		Me.Label8.Size = New System.Drawing.Size(33, 17)
		Me.Label8.Location = New System.Drawing.Point(8, 40)
		Me.Label8.TabIndex = 16
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
		Me.Label7.BackColor = System.Drawing.Color.White
		Me.Label7.Text = "From"
		Me.Label7.Size = New System.Drawing.Size(33, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 16)
		Me.Label7.TabIndex = 15
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.cbBankAccount.Size = New System.Drawing.Size(153, 21)
		Me.cbBankAccount.Location = New System.Drawing.Point(160, 128)
		Me.cbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankAccount.TabIndex = 11
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
		Me.cbBank.Size = New System.Drawing.Size(233, 21)
		Me.cbBank.Location = New System.Drawing.Point(80, 96)
		Me.cbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBank.TabIndex = 10
		Me.cbBank.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBank.BackColor = System.Drawing.SystemColors.Window
		Me.cbBank.CausesValidation = True
		Me.cbBank.Enabled = True
		Me.cbBank.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbBank.IntegralHeight = True
		Me.cbBank.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbBank.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbBank.Sorted = False
		Me.cbBank.TabStop = True
		Me.cbBank.Visible = True
		Me.cbBank.Name = "cbBank"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(57, 33)
		Me.cmdClose.Location = New System.Drawing.Point(192, 376)
		Me.cmdClose.TabIndex = 9
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSearch.Text = "Search"
		Me.cmdSearch.Size = New System.Drawing.Size(57, 33)
		Me.cmdSearch.Location = New System.Drawing.Point(112, 376)
		Me.cmdSearch.TabIndex = 8
		Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSearch.CausesValidation = True
		Me.cmdSearch.Enabled = True
		Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSearch.TabStop = True
		Me.cmdSearch.Name = "cmdSearch"
		Me.cbCustName.Size = New System.Drawing.Size(161, 21)
		Me.cbCustName.Location = New System.Drawing.Point(152, 32)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.cbCustName.TabIndex = 4
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
		Me.cbVendor.Size = New System.Drawing.Size(233, 21)
		Me.cbVendor.Location = New System.Drawing.Point(80, 64)
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
		Me.cbCustId.Size = New System.Drawing.Size(65, 21)
		Me.cbCustId.Location = New System.Drawing.Point(80, 32)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 2
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
		Me.cbCustId.Visible = True
		Me.cbCustId.Name = "cbCustId"
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Text = "Bank Account"
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.Location = New System.Drawing.Point(80, 128)
		Me.Label4.TabIndex = 12
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.label2.BackColor = System.Drawing.SystemColors.Window
		Me.label2.Text = "Bank"
		Me.label2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.label2.Size = New System.Drawing.Size(41, 17)
		Me.label2.Location = New System.Drawing.Point(32, 96)
		Me.label2.TabIndex = 7
		Me.label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label2.Enabled = True
		Me.label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label2.UseMnemonic = True
		Me.label2.Visible = True
		Me.label2.AutoSize = False
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label2.Name = "label2"
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "Vendor"
		Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label6.Size = New System.Drawing.Size(49, 17)
		Me.Label6.Location = New System.Drawing.Point(32, 64)
		Me.Label6.TabIndex = 6
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
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "Customer"
		Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(32, 32)
		Me.Label5.TabIndex = 5
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(frChecks)
		Me.Frame2.Controls.Add(chCheckRange)
		Me.Frame2.Controls.Add(chDates)
		Me.Frame2.Controls.Add(frDates)
		Me.Frame2.Controls.Add(cbBankAccount)
		Me.Frame2.Controls.Add(cbBank)
		Me.Frame2.Controls.Add(cmdClose)
		Me.Frame2.Controls.Add(cmdSearch)
		Me.Frame2.Controls.Add(cbCustName)
		Me.Frame2.Controls.Add(cbVendor)
		Me.Frame2.Controls.Add(cbCustId)
		Me.Frame2.Controls.Add(Label4)
		Me.Frame2.Controls.Add(label2)
		Me.Frame2.Controls.Add(Label6)
		Me.Frame2.Controls.Add(Label5)
		Me.frChecks.Controls.Add(txtToCheck)
		Me.frChecks.Controls.Add(txtFromCheck)
		Me.frChecks.Controls.Add(Label3)
		Me.frChecks.Controls.Add(Label1)
		Me.frDates.Controls.Add(dtEnd)
		Me.frDates.Controls.Add(dtStart)
		Me.frDates.Controls.Add(Label8)
		Me.frDates.Controls.Add(Label7)
		CType(Me.dtStart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtEnd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.frChecks.ResumeLayout(False)
		Me.frDates.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class