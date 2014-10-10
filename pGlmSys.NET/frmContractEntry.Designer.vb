<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmContractEntry
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
	Public WithEvents txtGlmRate As System.Windows.Forms.TextBox
	Public WithEvents ckbOverrideExpFlag As System.Windows.Forms.CheckBox
	Public WithEvents ckbDefaultService As System.Windows.Forms.CheckBox
	Public WithEvents cbRateStatus As System.Windows.Forms.ComboBox
	Public WithEvents cbRateDesc As System.Windows.Forms.ComboBox
	Public WithEvents txtContractComments As System.Windows.Forms.TextBox
	Public WithEvents cbFreqPeriod As System.Windows.Forms.ComboBox
	Public WithEvents cbVendName As System.Windows.Forms.ComboBox
	Public WithEvents txtCurrRate As System.Windows.Forms.TextBox
	Public WithEvents txtOldRate As System.Windows.Forms.TextBox
	Public WithEvents txtFreqComments As System.Windows.Forms.TextBox
	Public WithEvents txtFreqTimes As System.Windows.Forms.TextBox
	Public WithEvents udFreqTimes As System.Windows.Forms.Label
	Public WithEvents _ckbFreqDay_6 As System.Windows.Forms.CheckBox
	Public WithEvents _ckbFreqDay_5 As System.Windows.Forms.CheckBox
	Public WithEvents _ckbFreqDay_4 As System.Windows.Forms.CheckBox
	Public WithEvents _ckbFreqDay_3 As System.Windows.Forms.CheckBox
	Public WithEvents _ckbFreqDay_2 As System.Windows.Forms.CheckBox
	Public WithEvents _ckbFreqDay_1 As System.Windows.Forms.CheckBox
	Public WithEvents _ckbFreqDay_0 As System.Windows.Forms.CheckBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents lbTimes As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents fmService As System.Windows.Forms.GroupBox
	Public WithEvents cbServDesc As System.Windows.Forms.ComboBox
	Public WithEvents cbEqptDesc As System.Windows.Forms.ComboBox
	Public WithEvents cmdVendorSearch As System.Windows.Forms.Button
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents txtStoreNumber As System.Windows.Forms.TextBox
	Public WithEvents txtCustId As System.Windows.Forms.TextBox
	Public WithEvents dtOpening As AxMSComCtl2.AxDTPicker
	Public WithEvents dtExpiration As AxMSComCtl2.AxDTPicker
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents lbExpiration As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents ckbFreqDay As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContractEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtGlmRate = New System.Windows.Forms.TextBox
		Me.ckbOverrideExpFlag = New System.Windows.Forms.CheckBox
		Me.ckbDefaultService = New System.Windows.Forms.CheckBox
		Me.cbRateStatus = New System.Windows.Forms.ComboBox
		Me.cbRateDesc = New System.Windows.Forms.ComboBox
		Me.txtContractComments = New System.Windows.Forms.TextBox
		Me.cbFreqPeriod = New System.Windows.Forms.ComboBox
		Me.cbVendName = New System.Windows.Forms.ComboBox
		Me.txtCurrRate = New System.Windows.Forms.TextBox
		Me.txtOldRate = New System.Windows.Forms.TextBox
		Me.fmService = New System.Windows.Forms.GroupBox
		Me.txtFreqComments = New System.Windows.Forms.TextBox
		Me.txtFreqTimes = New System.Windows.Forms.TextBox
		Me.udFreqTimes = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me._ckbFreqDay_6 = New System.Windows.Forms.CheckBox
		Me._ckbFreqDay_5 = New System.Windows.Forms.CheckBox
		Me._ckbFreqDay_4 = New System.Windows.Forms.CheckBox
		Me._ckbFreqDay_3 = New System.Windows.Forms.CheckBox
		Me._ckbFreqDay_2 = New System.Windows.Forms.CheckBox
		Me._ckbFreqDay_1 = New System.Windows.Forms.CheckBox
		Me._ckbFreqDay_0 = New System.Windows.Forms.CheckBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.lbTimes = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.cbServDesc = New System.Windows.Forms.ComboBox
		Me.cbEqptDesc = New System.Windows.Forms.ComboBox
		Me.cmdVendorSearch = New System.Windows.Forms.Button
		Me.txtVendName = New System.Windows.Forms.TextBox
		Me.txtStoreNumber = New System.Windows.Forms.TextBox
		Me.txtCustId = New System.Windows.Forms.TextBox
		Me.dtOpening = New AxMSComCtl2.AxDTPicker
		Me.dtExpiration = New AxMSComCtl2.AxDTPicker
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.lbExpiration = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.ckbFreqDay = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.Frame1.SuspendLayout()
		Me.fmService.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtOpening, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtExpiration, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ckbFreqDay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Contract Info"
		Me.ClientSize = New System.Drawing.Size(422, 574)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmContractEntry"
		Me.Frame1.Size = New System.Drawing.Size(393, 521)
		Me.Frame1.Location = New System.Drawing.Point(16, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtGlmRate.AutoSize = False
		Me.txtGlmRate.Size = New System.Drawing.Size(89, 21)
		Me.txtGlmRate.Location = New System.Drawing.Point(24, 328)
		Me.txtGlmRate.TabIndex = 49
		Me.txtGlmRate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGlmRate.AcceptsReturn = True
		Me.txtGlmRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGlmRate.BackColor = System.Drawing.SystemColors.Window
		Me.txtGlmRate.CausesValidation = True
		Me.txtGlmRate.Enabled = True
		Me.txtGlmRate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGlmRate.HideSelection = True
		Me.txtGlmRate.ReadOnly = False
		Me.txtGlmRate.Maxlength = 0
		Me.txtGlmRate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGlmRate.MultiLine = False
		Me.txtGlmRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGlmRate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGlmRate.TabStop = True
		Me.txtGlmRate.Visible = True
		Me.txtGlmRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGlmRate.Name = "txtGlmRate"
		Me.ckbOverrideExpFlag.Text = "Override Expiration Date"
		Me.ckbOverrideExpFlag.Size = New System.Drawing.Size(137, 17)
		Me.ckbOverrideExpFlag.Location = New System.Drawing.Point(24, 424)
		Me.ckbOverrideExpFlag.TabIndex = 46
		Me.ckbOverrideExpFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbOverrideExpFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckbOverrideExpFlag.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckbOverrideExpFlag.BackColor = System.Drawing.SystemColors.Control
		Me.ckbOverrideExpFlag.CausesValidation = True
		Me.ckbOverrideExpFlag.Enabled = True
		Me.ckbOverrideExpFlag.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckbOverrideExpFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckbOverrideExpFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckbOverrideExpFlag.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckbOverrideExpFlag.TabStop = True
		Me.ckbOverrideExpFlag.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckbOverrideExpFlag.Visible = True
		Me.ckbOverrideExpFlag.Name = "ckbOverrideExpFlag"
		Me.ckbDefaultService.Text = "Default Frequency"
		Me.ckbDefaultService.Size = New System.Drawing.Size(113, 17)
		Me.ckbDefaultService.Location = New System.Drawing.Point(24, 400)
		Me.ckbDefaultService.TabIndex = 45
		Me.ckbDefaultService.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbDefaultService.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckbDefaultService.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckbDefaultService.BackColor = System.Drawing.SystemColors.Control
		Me.ckbDefaultService.CausesValidation = True
		Me.ckbDefaultService.Enabled = True
		Me.ckbDefaultService.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckbDefaultService.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckbDefaultService.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckbDefaultService.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckbDefaultService.TabStop = True
		Me.ckbDefaultService.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckbDefaultService.Visible = True
		Me.ckbDefaultService.Name = "ckbDefaultService"
		Me.cbRateStatus.Size = New System.Drawing.Size(41, 21)
		Me.cbRateStatus.Location = New System.Drawing.Point(160, 368)
		Me.cbRateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbRateStatus.TabIndex = 44
		Me.cbRateStatus.Visible = False
		Me.cbRateStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbRateStatus.BackColor = System.Drawing.SystemColors.Window
		Me.cbRateStatus.CausesValidation = True
		Me.cbRateStatus.Enabled = True
		Me.cbRateStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbRateStatus.IntegralHeight = True
		Me.cbRateStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbRateStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbRateStatus.Sorted = False
		Me.cbRateStatus.TabStop = True
		Me.cbRateStatus.Name = "cbRateStatus"
		Me.cbRateDesc.Size = New System.Drawing.Size(137, 21)
		Me.cbRateDesc.Location = New System.Drawing.Point(24, 368)
		Me.cbRateDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbRateDesc.TabIndex = 22
		Me.cbRateDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbRateDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbRateDesc.CausesValidation = True
		Me.cbRateDesc.Enabled = True
		Me.cbRateDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbRateDesc.IntegralHeight = True
		Me.cbRateDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbRateDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbRateDesc.Sorted = False
		Me.cbRateDesc.TabStop = True
		Me.cbRateDesc.Visible = True
		Me.cbRateDesc.Name = "cbRateDesc"
		Me.txtContractComments.AutoSize = False
		Me.txtContractComments.Size = New System.Drawing.Size(145, 41)
		Me.txtContractComments.Location = New System.Drawing.Point(24, 464)
		Me.txtContractComments.Maxlength = 60
		Me.txtContractComments.MultiLine = True
		Me.txtContractComments.TabIndex = 23
		Me.txtContractComments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContractComments.AcceptsReturn = True
		Me.txtContractComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContractComments.BackColor = System.Drawing.SystemColors.Window
		Me.txtContractComments.CausesValidation = True
		Me.txtContractComments.Enabled = True
		Me.txtContractComments.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContractComments.HideSelection = True
		Me.txtContractComments.ReadOnly = False
		Me.txtContractComments.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContractComments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContractComments.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContractComments.TabStop = True
		Me.txtContractComments.Visible = True
		Me.txtContractComments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContractComments.Name = "txtContractComments"
		Me.cbFreqPeriod.Size = New System.Drawing.Size(145, 21)
		Me.cbFreqPeriod.Location = New System.Drawing.Point(184, 168)
		Me.cbFreqPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbFreqPeriod.TabIndex = 25
		Me.cbFreqPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbFreqPeriod.BackColor = System.Drawing.SystemColors.Window
		Me.cbFreqPeriod.CausesValidation = True
		Me.cbFreqPeriod.Enabled = True
		Me.cbFreqPeriod.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbFreqPeriod.IntegralHeight = True
		Me.cbFreqPeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbFreqPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbFreqPeriod.Sorted = False
		Me.cbFreqPeriod.TabStop = True
		Me.cbFreqPeriod.Visible = True
		Me.cbFreqPeriod.Name = "cbFreqPeriod"
		Me.cbVendName.Size = New System.Drawing.Size(289, 21)
		Me.cbVendName.Location = New System.Drawing.Point(24, 80)
		Me.cbVendName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendName.TabIndex = 8
		Me.cbVendName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendName.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendName.CausesValidation = True
		Me.cbVendName.Enabled = True
		Me.cbVendName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendName.IntegralHeight = True
		Me.cbVendName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendName.Sorted = False
		Me.cbVendName.TabStop = True
		Me.cbVendName.Visible = True
		Me.cbVendName.Name = "cbVendName"
		Me.txtCurrRate.AutoSize = False
		Me.txtCurrRate.Size = New System.Drawing.Size(89, 21)
		Me.txtCurrRate.Location = New System.Drawing.Point(24, 288)
		Me.txtCurrRate.TabIndex = 21
		Me.txtCurrRate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCurrRate.AcceptsReturn = True
		Me.txtCurrRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCurrRate.BackColor = System.Drawing.SystemColors.Window
		Me.txtCurrRate.CausesValidation = True
		Me.txtCurrRate.Enabled = True
		Me.txtCurrRate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCurrRate.HideSelection = True
		Me.txtCurrRate.ReadOnly = False
		Me.txtCurrRate.Maxlength = 0
		Me.txtCurrRate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCurrRate.MultiLine = False
		Me.txtCurrRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCurrRate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCurrRate.TabStop = True
		Me.txtCurrRate.Visible = True
		Me.txtCurrRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCurrRate.Name = "txtCurrRate"
		Me.txtOldRate.AutoSize = False
		Me.txtOldRate.Size = New System.Drawing.Size(89, 21)
		Me.txtOldRate.Location = New System.Drawing.Point(24, 248)
		Me.txtOldRate.TabIndex = 20
		Me.txtOldRate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOldRate.AcceptsReturn = True
		Me.txtOldRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtOldRate.BackColor = System.Drawing.SystemColors.Window
		Me.txtOldRate.CausesValidation = True
		Me.txtOldRate.Enabled = True
		Me.txtOldRate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOldRate.HideSelection = True
		Me.txtOldRate.ReadOnly = False
		Me.txtOldRate.Maxlength = 0
		Me.txtOldRate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOldRate.MultiLine = False
		Me.txtOldRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOldRate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOldRate.TabStop = True
		Me.txtOldRate.Visible = True
		Me.txtOldRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOldRate.Name = "txtOldRate"
		Me.fmService.Size = New System.Drawing.Size(185, 305)
		Me.fmService.Location = New System.Drawing.Point(184, 208)
		Me.fmService.TabIndex = 17
		Me.fmService.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fmService.BackColor = System.Drawing.SystemColors.Control
		Me.fmService.Enabled = True
		Me.fmService.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fmService.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fmService.Visible = True
		Me.fmService.Name = "fmService"
		Me.txtFreqComments.AutoSize = False
		Me.txtFreqComments.Size = New System.Drawing.Size(153, 19)
		Me.txtFreqComments.Location = New System.Drawing.Point(16, 272)
		Me.txtFreqComments.Maxlength = 40
		Me.txtFreqComments.TabIndex = 32
		Me.txtFreqComments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFreqComments.AcceptsReturn = True
		Me.txtFreqComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFreqComments.BackColor = System.Drawing.SystemColors.Window
		Me.txtFreqComments.CausesValidation = True
		Me.txtFreqComments.Enabled = True
		Me.txtFreqComments.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFreqComments.HideSelection = True
		Me.txtFreqComments.ReadOnly = False
		Me.txtFreqComments.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFreqComments.MultiLine = False
		Me.txtFreqComments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFreqComments.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFreqComments.TabStop = True
		Me.txtFreqComments.Visible = True
		Me.txtFreqComments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFreqComments.Name = "txtFreqComments"
		Me.txtFreqTimes.AutoSize = False
		Me.txtFreqTimes.Size = New System.Drawing.Size(25, 25)
		Me.txtFreqTimes.Location = New System.Drawing.Point(16, 32)
		Me.txtFreqTimes.Maxlength = 2
		Me.txtFreqTimes.TabIndex = 29
		Me.txtFreqTimes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFreqTimes.AcceptsReturn = True
		Me.txtFreqTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFreqTimes.BackColor = System.Drawing.SystemColors.Window
		Me.txtFreqTimes.CausesValidation = True
		Me.txtFreqTimes.Enabled = True
		Me.txtFreqTimes.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFreqTimes.HideSelection = True
		Me.txtFreqTimes.ReadOnly = False
		Me.txtFreqTimes.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFreqTimes.MultiLine = False
		Me.txtFreqTimes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFreqTimes.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFreqTimes.TabStop = True
		Me.txtFreqTimes.Visible = True
		Me.txtFreqTimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFreqTimes.Name = "txtFreqTimes"
		Me.udFreqTimes.Size = New System.Drawing.Size(16, 25)
		Me.udFreqTimes.Location = New System.Drawing.Point(40, 32)
		Me.udFreqTimes.TabIndex = 28
		Me.udFreqTimes.Text = "udFreqTimes"
		Me.udFreqTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.udFreqTimes.BackColor = System.Drawing.Color.Red
		Me.udFreqTimes.Name = "udFreqTimes"
		Me.Frame3.Text = "Service Days"
		Me.Frame3.Size = New System.Drawing.Size(113, 185)
		Me.Frame3.Location = New System.Drawing.Point(16, 64)
		Me.Frame3.TabIndex = 24
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		Me._ckbFreqDay_6.Text = "Sun&day"
		Me._ckbFreqDay_6.Size = New System.Drawing.Size(73, 17)
		Me._ckbFreqDay_6.Location = New System.Drawing.Point(16, 160)
		Me._ckbFreqDay_6.TabIndex = 40
		Me._ckbFreqDay_6.Tag = "D"
		Me._ckbFreqDay_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_6.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_6.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_6.CausesValidation = True
		Me._ckbFreqDay_6.Enabled = True
		Me._ckbFreqDay_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_6.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_6.TabStop = True
		Me._ckbFreqDay_6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_6.Visible = True
		Me._ckbFreqDay_6.Name = "_ckbFreqDay_6"
		Me._ckbFreqDay_5.Text = "&Saturday"
		Me._ckbFreqDay_5.Size = New System.Drawing.Size(73, 17)
		Me._ckbFreqDay_5.Location = New System.Drawing.Point(16, 137)
		Me._ckbFreqDay_5.TabIndex = 39
		Me._ckbFreqDay_5.Tag = "S"
		Me._ckbFreqDay_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_5.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_5.CausesValidation = True
		Me._ckbFreqDay_5.Enabled = True
		Me._ckbFreqDay_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_5.TabStop = True
		Me._ckbFreqDay_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_5.Visible = True
		Me._ckbFreqDay_5.Name = "_ckbFreqDay_5"
		Me._ckbFreqDay_4.Text = "&Friday"
		Me._ckbFreqDay_4.Size = New System.Drawing.Size(73, 17)
		Me._ckbFreqDay_4.Location = New System.Drawing.Point(16, 115)
		Me._ckbFreqDay_4.TabIndex = 38
		Me._ckbFreqDay_4.Tag = "F"
		Me._ckbFreqDay_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_4.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_4.CausesValidation = True
		Me._ckbFreqDay_4.Enabled = True
		Me._ckbFreqDay_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_4.TabStop = True
		Me._ckbFreqDay_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_4.Visible = True
		Me._ckbFreqDay_4.Name = "_ckbFreqDay_4"
		Me._ckbFreqDay_3.Text = "Thu&rsday"
		Me._ckbFreqDay_3.Size = New System.Drawing.Size(73, 17)
		Me._ckbFreqDay_3.Location = New System.Drawing.Point(16, 96)
		Me._ckbFreqDay_3.TabIndex = 37
		Me._ckbFreqDay_3.Tag = "R"
		Me._ckbFreqDay_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_3.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_3.CausesValidation = True
		Me._ckbFreqDay_3.Enabled = True
		Me._ckbFreqDay_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_3.TabStop = True
		Me._ckbFreqDay_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_3.Visible = True
		Me._ckbFreqDay_3.Name = "_ckbFreqDay_3"
		Me._ckbFreqDay_2.Text = "&Wednesday"
		Me._ckbFreqDay_2.Size = New System.Drawing.Size(89, 17)
		Me._ckbFreqDay_2.Location = New System.Drawing.Point(16, 72)
		Me._ckbFreqDay_2.TabIndex = 35
		Me._ckbFreqDay_2.Tag = "W"
		Me._ckbFreqDay_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_2.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_2.CausesValidation = True
		Me._ckbFreqDay_2.Enabled = True
		Me._ckbFreqDay_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_2.TabStop = True
		Me._ckbFreqDay_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_2.Visible = True
		Me._ckbFreqDay_2.Name = "_ckbFreqDay_2"
		Me._ckbFreqDay_1.Text = "&Tuesday"
		Me._ckbFreqDay_1.Size = New System.Drawing.Size(73, 17)
		Me._ckbFreqDay_1.Location = New System.Drawing.Point(16, 48)
		Me._ckbFreqDay_1.TabIndex = 33
		Me._ckbFreqDay_1.Tag = "T"
		Me._ckbFreqDay_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_1.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_1.CausesValidation = True
		Me._ckbFreqDay_1.Enabled = True
		Me._ckbFreqDay_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_1.TabStop = True
		Me._ckbFreqDay_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_1.Visible = True
		Me._ckbFreqDay_1.Name = "_ckbFreqDay_1"
		Me._ckbFreqDay_0.Text = "&Monday"
		Me._ckbFreqDay_0.Size = New System.Drawing.Size(73, 17)
		Me._ckbFreqDay_0.Location = New System.Drawing.Point(16, 24)
		Me._ckbFreqDay_0.TabIndex = 31
		Me._ckbFreqDay_0.Tag = "M"
		Me._ckbFreqDay_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._ckbFreqDay_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._ckbFreqDay_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._ckbFreqDay_0.BackColor = System.Drawing.SystemColors.Control
		Me._ckbFreqDay_0.CausesValidation = True
		Me._ckbFreqDay_0.Enabled = True
		Me._ckbFreqDay_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._ckbFreqDay_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._ckbFreqDay_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._ckbFreqDay_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._ckbFreqDay_0.TabStop = True
		Me._ckbFreqDay_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._ckbFreqDay_0.Visible = True
		Me._ckbFreqDay_0.Name = "_ckbFreqDay_0"
		Me.Label8.Text = "Frequency Comments"
		Me.Label8.Size = New System.Drawing.Size(113, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 256)
		Me.Label8.TabIndex = 41
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
		Me.lbTimes.Text = "times"
		Me.lbTimes.Size = New System.Drawing.Size(113, 33)
		Me.lbTimes.Location = New System.Drawing.Point(64, 32)
		Me.lbTimes.TabIndex = 30
		Me.lbTimes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbTimes.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbTimes.BackColor = System.Drawing.SystemColors.Control
		Me.lbTimes.Enabled = True
		Me.lbTimes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbTimes.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbTimes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbTimes.UseMnemonic = True
		Me.lbTimes.Visible = True
		Me.lbTimes.AutoSize = False
		Me.lbTimes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbTimes.Name = "lbTimes"
		Me.Label7.Text = "Times of Service"
		Me.Label7.Size = New System.Drawing.Size(81, 17)
		Me.Label7.Location = New System.Drawing.Point(16, 16)
		Me.Label7.TabIndex = 27
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
		Me.cbServDesc.Size = New System.Drawing.Size(185, 21)
		Me.cbServDesc.Location = New System.Drawing.Point(184, 128)
		Me.cbServDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServDesc.TabIndex = 12
		Me.cbServDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbServDesc.CausesValidation = True
		Me.cbServDesc.Enabled = True
		Me.cbServDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServDesc.IntegralHeight = True
		Me.cbServDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServDesc.Sorted = False
		Me.cbServDesc.TabStop = True
		Me.cbServDesc.Visible = True
		Me.cbServDesc.Name = "cbServDesc"
		Me.cbEqptDesc.Size = New System.Drawing.Size(129, 21)
		Me.cbEqptDesc.Location = New System.Drawing.Point(24, 128)
		Me.cbEqptDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEqptDesc.TabIndex = 11
		Me.cbEqptDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEqptDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbEqptDesc.CausesValidation = True
		Me.cbEqptDesc.Enabled = True
		Me.cbEqptDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEqptDesc.IntegralHeight = True
		Me.cbEqptDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEqptDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEqptDesc.Sorted = False
		Me.cbEqptDesc.TabStop = True
		Me.cbEqptDesc.Visible = True
		Me.cbEqptDesc.Name = "cbEqptDesc"
		Me.cmdVendorSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdVendorSearch.Size = New System.Drawing.Size(41, 21)
		Me.cmdVendorSearch.Location = New System.Drawing.Point(296, 56)
		Me.cmdVendorSearch.Image = CType(resources.GetObject("cmdVendorSearch.Image"), System.Drawing.Image)
		Me.cmdVendorSearch.TabIndex = 10
		Me.cmdVendorSearch.Visible = False
		Me.cmdVendorSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdVendorSearch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdVendorSearch.CausesValidation = True
		Me.cmdVendorSearch.Enabled = True
		Me.cmdVendorSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdVendorSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdVendorSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdVendorSearch.TabStop = True
		Me.cmdVendorSearch.Name = "cmdVendorSearch"
		Me.txtVendName.AutoSize = False
		Me.txtVendName.Size = New System.Drawing.Size(217, 21)
		Me.txtVendName.Location = New System.Drawing.Point(80, 56)
		Me.txtVendName.ReadOnly = True
		Me.txtVendName.TabIndex = 9
		Me.txtVendName.Visible = False
		Me.txtVendName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendName.AcceptsReturn = True
		Me.txtVendName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendName.CausesValidation = True
		Me.txtVendName.Enabled = True
		Me.txtVendName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendName.HideSelection = True
		Me.txtVendName.Maxlength = 0
		Me.txtVendName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendName.MultiLine = False
		Me.txtVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendName.TabStop = True
		Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendName.Name = "txtVendName"
		Me.txtStoreNumber.AutoSize = False
		Me.txtStoreNumber.Enabled = False
		Me.txtStoreNumber.Size = New System.Drawing.Size(129, 21)
		Me.txtStoreNumber.Location = New System.Drawing.Point(184, 32)
		Me.txtStoreNumber.ReadOnly = True
		Me.txtStoreNumber.TabIndex = 5
		Me.txtStoreNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreNumber.AcceptsReturn = True
		Me.txtStoreNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreNumber.CausesValidation = True
		Me.txtStoreNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreNumber.HideSelection = True
		Me.txtStoreNumber.Maxlength = 0
		Me.txtStoreNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreNumber.MultiLine = False
		Me.txtStoreNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreNumber.TabStop = True
		Me.txtStoreNumber.Visible = True
		Me.txtStoreNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreNumber.Name = "txtStoreNumber"
		Me.txtCustId.AutoSize = False
		Me.txtCustId.Enabled = False
		Me.txtCustId.Size = New System.Drawing.Size(129, 21)
		Me.txtCustId.Location = New System.Drawing.Point(24, 32)
		Me.txtCustId.ReadOnly = True
		Me.txtCustId.TabIndex = 1
		Me.txtCustId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustId.AcceptsReturn = True
		Me.txtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustId.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustId.CausesValidation = True
		Me.txtCustId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustId.HideSelection = True
		Me.txtCustId.Maxlength = 0
		Me.txtCustId.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustId.MultiLine = False
		Me.txtCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustId.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustId.TabStop = True
		Me.txtCustId.Visible = True
		Me.txtCustId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustId.Name = "txtCustId"
		dtOpening.OcxState = CType(resources.GetObject("dtOpening.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtOpening.Size = New System.Drawing.Size(129, 21)
		Me.dtOpening.Location = New System.Drawing.Point(24, 168)
		Me.dtOpening.TabIndex = 15
		Me.dtOpening.Name = "dtOpening"
		dtExpiration.OcxState = CType(resources.GetObject("dtExpiration.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtExpiration.Size = New System.Drawing.Size(129, 21)
		Me.dtExpiration.Location = New System.Drawing.Point(24, 208)
		Me.dtExpiration.TabIndex = 16
		Me.dtExpiration.Name = "dtExpiration"
		Me.Label15.Text = "GLM Rate"
		Me.Label15.Size = New System.Drawing.Size(81, 17)
		Me.Label15.Location = New System.Drawing.Point(24, 312)
		Me.Label15.TabIndex = 48
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
		Me.Label14.Text = "Label14"
		Me.Label14.Size = New System.Drawing.Size(25, 1)
		Me.Label14.Location = New System.Drawing.Point(16, 320)
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
		Me.Label13.Text = "Rate Status"
		Me.Label13.Size = New System.Drawing.Size(57, 17)
		Me.Label13.Location = New System.Drawing.Point(24, 352)
		Me.Label13.TabIndex = 36
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
		Me.Label12.Text = "Comments"
		Me.Label12.Size = New System.Drawing.Size(81, 17)
		Me.Label12.Location = New System.Drawing.Point(24, 448)
		Me.Label12.TabIndex = 34
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
		Me.Label11.Text = "Service Period"
		Me.Label11.Size = New System.Drawing.Size(81, 17)
		Me.Label11.Location = New System.Drawing.Point(184, 152)
		Me.Label11.TabIndex = 26
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
		Me.Label10.Text = "Current Rate"
		Me.Label10.Size = New System.Drawing.Size(81, 17)
		Me.Label10.Location = New System.Drawing.Point(24, 272)
		Me.Label10.TabIndex = 19
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
		Me.Label9.Text = "Previous Rate"
		Me.Label9.Size = New System.Drawing.Size(81, 17)
		Me.Label9.Location = New System.Drawing.Point(24, 232)
		Me.Label9.TabIndex = 18
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
		Me.lbExpiration.Text = "Expiration Date"
		Me.lbExpiration.Size = New System.Drawing.Size(89, 17)
		Me.lbExpiration.Location = New System.Drawing.Point(24, 192)
		Me.lbExpiration.TabIndex = 14
		Me.lbExpiration.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbExpiration.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbExpiration.BackColor = System.Drawing.SystemColors.Control
		Me.lbExpiration.Enabled = True
		Me.lbExpiration.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbExpiration.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbExpiration.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbExpiration.UseMnemonic = True
		Me.lbExpiration.Visible = True
		Me.lbExpiration.AutoSize = False
		Me.lbExpiration.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbExpiration.Name = "lbExpiration"
		Me.Label6.Text = "Opening Date"
		Me.Label6.Size = New System.Drawing.Size(89, 17)
		Me.Label6.Location = New System.Drawing.Point(24, 152)
		Me.Label6.TabIndex = 13
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
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 16)
		Me.Label1.TabIndex = 7
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
		Me.Label2.Text = "Store"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(184, 16)
		Me.Label2.TabIndex = 6
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
		Me.Label3.Text = "Vendor"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 64)
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
		Me.Label4.Text = "Equipment"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 112)
		Me.Label4.TabIndex = 3
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
		Me.Label5.Text = "Service"
		Me.Label5.Size = New System.Drawing.Size(41, 17)
		Me.Label5.Location = New System.Drawing.Point(184, 112)
		Me.Label5.TabIndex = 2
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
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(49, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(224, 528)
		Me.cmdCancel.TabIndex = 43
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
		Me.cmdOk.Size = New System.Drawing.Size(49, 33)
		Me.cmdOk.Location = New System.Drawing.Point(144, 528)
		Me.cmdOk.TabIndex = 42
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Frame1.Controls.Add(txtGlmRate)
		Me.Frame1.Controls.Add(ckbOverrideExpFlag)
		Me.Frame1.Controls.Add(ckbDefaultService)
		Me.Frame1.Controls.Add(cbRateStatus)
		Me.Frame1.Controls.Add(cbRateDesc)
		Me.Frame1.Controls.Add(txtContractComments)
		Me.Frame1.Controls.Add(cbFreqPeriod)
		Me.Frame1.Controls.Add(cbVendName)
		Me.Frame1.Controls.Add(txtCurrRate)
		Me.Frame1.Controls.Add(txtOldRate)
		Me.Frame1.Controls.Add(fmService)
		Me.Frame1.Controls.Add(cbServDesc)
		Me.Frame1.Controls.Add(cbEqptDesc)
		Me.Frame1.Controls.Add(cmdVendorSearch)
		Me.Frame1.Controls.Add(txtVendName)
		Me.Frame1.Controls.Add(txtStoreNumber)
		Me.Frame1.Controls.Add(txtCustId)
		Me.Frame1.Controls.Add(dtOpening)
		Me.Frame1.Controls.Add(dtExpiration)
		Me.Frame1.Controls.Add(Label15)
		Me.Frame1.Controls.Add(Label14)
		Me.Frame1.Controls.Add(Label13)
		Me.Frame1.Controls.Add(Label12)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(lbExpiration)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label5)
		Me.fmService.Controls.Add(txtFreqComments)
		Me.fmService.Controls.Add(txtFreqTimes)
		Me.fmService.Controls.Add(udFreqTimes)
		Me.fmService.Controls.Add(Frame3)
		Me.fmService.Controls.Add(Label8)
		Me.fmService.Controls.Add(lbTimes)
		Me.fmService.Controls.Add(Label7)
		Me.Frame3.Controls.Add(_ckbFreqDay_6)
		Me.Frame3.Controls.Add(_ckbFreqDay_5)
		Me.Frame3.Controls.Add(_ckbFreqDay_4)
		Me.Frame3.Controls.Add(_ckbFreqDay_3)
		Me.Frame3.Controls.Add(_ckbFreqDay_2)
		Me.Frame3.Controls.Add(_ckbFreqDay_1)
		Me.Frame3.Controls.Add(_ckbFreqDay_0)
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_6, CType(6, Short))
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_5, CType(5, Short))
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_4, CType(4, Short))
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_3, CType(3, Short))
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_2, CType(2, Short))
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_1, CType(1, Short))
		Me.ckbFreqDay.SetIndex(_ckbFreqDay_0, CType(0, Short))
		CType(Me.ckbFreqDay, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtExpiration, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtOpening, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.fmService.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class