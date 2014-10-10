<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepGlmInvoice
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
	Public WithEvents ckPrintFinal As System.Windows.Forms.CheckBox
	Public WithEvents cmdSelectValues As System.Windows.Forms.Button
	Public WithEvents cbReportTemplateDesc As System.Windows.Forms.ComboBox
	Public WithEvents ckGlmVendor As System.Windows.Forms.CheckBox
	Public WithEvents ckUseGlmRate As System.Windows.Forms.CheckBox
	Public WithEvents ckUseForBilling As System.Windows.Forms.CheckBox
	Public WithEvents txtReportName As System.Windows.Forms.TextBox
	Public WithEvents ckPublish As System.Windows.Forms.CheckBox
	Public WithEvents cbReportTemplate As System.Windows.Forms.ComboBox
	Public WithEvents txtReportCaption As System.Windows.Forms.TextBox
	Public WithEvents ckJustInvoice As System.Windows.Forms.CheckBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cbPeriodName As System.Windows.Forms.ComboBox
	Public WithEvents obRange As System.Windows.Forms.RadioButton
	Public WithEvents obPeriod As System.Windows.Forms.RadioButton
	Public WithEvents dtEndDate As AxMSComCtl2.AxDTPicker
	Public WithEvents dtStartDate As AxMSComCtl2.AxDTPicker
	Public WithEvents lbEndDate As System.Windows.Forms.Label
	Public WithEvents lbStartDate As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbGroupName As System.Windows.Forms.ComboBox
	Public WithEvents cbStateId As System.Windows.Forms.ComboBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepGlmInvoice))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ckPrintFinal = New System.Windows.Forms.CheckBox
		Me.cmdSelectValues = New System.Windows.Forms.Button
		Me.cbReportTemplateDesc = New System.Windows.Forms.ComboBox
		Me.ckGlmVendor = New System.Windows.Forms.CheckBox
		Me.ckUseGlmRate = New System.Windows.Forms.CheckBox
		Me.ckUseForBilling = New System.Windows.Forms.CheckBox
		Me.txtReportName = New System.Windows.Forms.TextBox
		Me.ckPublish = New System.Windows.Forms.CheckBox
		Me.cbReportTemplate = New System.Windows.Forms.ComboBox
		Me.txtReportCaption = New System.Windows.Forms.TextBox
		Me.ckJustInvoice = New System.Windows.Forms.CheckBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cbPeriodName = New System.Windows.Forms.ComboBox
		Me.obRange = New System.Windows.Forms.RadioButton
		Me.obPeriod = New System.Windows.Forms.RadioButton
		Me.dtEndDate = New AxMSComCtl2.AxDTPicker
		Me.dtStartDate = New AxMSComCtl2.AxDTPicker
		Me.lbEndDate = New System.Windows.Forms.Label
		Me.lbStartDate = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.cbGroupName = New System.Windows.Forms.ComboBox
		Me.cbStateId = New System.Windows.Forms.ComboBox
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Glm Invoice Report Criteria"
		Me.ClientSize = New System.Drawing.Size(642, 491)
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
		Me.Name = "frmRepGlmInvoice"
		Me.ckPrintFinal.Text = "Print Final Version"
		Me.ckPrintFinal.Size = New System.Drawing.Size(185, 17)
		Me.ckPrintFinal.Location = New System.Drawing.Point(240, 336)
		Me.ckPrintFinal.TabIndex = 34
		Me.ckPrintFinal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckPrintFinal.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckPrintFinal.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckPrintFinal.BackColor = System.Drawing.SystemColors.Control
		Me.ckPrintFinal.CausesValidation = True
		Me.ckPrintFinal.Enabled = True
		Me.ckPrintFinal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckPrintFinal.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckPrintFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckPrintFinal.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckPrintFinal.TabStop = True
		Me.ckPrintFinal.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckPrintFinal.Visible = True
		Me.ckPrintFinal.Name = "ckPrintFinal"
		Me.cmdSelectValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSelectValues.Text = "..."
		Me.cmdSelectValues.Size = New System.Drawing.Size(33, 21)
		Me.cmdSelectValues.Location = New System.Drawing.Point(232, 56)
		Me.cmdSelectValues.TabIndex = 33
		Me.cmdSelectValues.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectValues.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSelectValues.CausesValidation = True
		Me.cmdSelectValues.Enabled = True
		Me.cmdSelectValues.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSelectValues.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSelectValues.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSelectValues.TabStop = True
		Me.cmdSelectValues.Name = "cmdSelectValues"
		Me.cbReportTemplateDesc.Size = New System.Drawing.Size(249, 21)
		Me.cbReportTemplateDesc.Location = New System.Drawing.Point(368, 56)
		Me.cbReportTemplateDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbReportTemplateDesc.TabIndex = 32
		Me.cbReportTemplateDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbReportTemplateDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbReportTemplateDesc.CausesValidation = True
		Me.cbReportTemplateDesc.Enabled = True
		Me.cbReportTemplateDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbReportTemplateDesc.IntegralHeight = True
		Me.cbReportTemplateDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbReportTemplateDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbReportTemplateDesc.Sorted = False
		Me.cbReportTemplateDesc.TabStop = True
		Me.cbReportTemplateDesc.Visible = True
		Me.cbReportTemplateDesc.Name = "cbReportTemplateDesc"
		Me.ckGlmVendor.Text = "Display GLM as Vendor"
		Me.ckGlmVendor.Size = New System.Drawing.Size(161, 17)
		Me.ckGlmVendor.Location = New System.Drawing.Point(24, 408)
		Me.ckGlmVendor.TabIndex = 31
		Me.ckGlmVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckGlmVendor.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckGlmVendor.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckGlmVendor.BackColor = System.Drawing.SystemColors.Control
		Me.ckGlmVendor.CausesValidation = True
		Me.ckGlmVendor.Enabled = True
		Me.ckGlmVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckGlmVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckGlmVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckGlmVendor.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckGlmVendor.TabStop = True
		Me.ckGlmVendor.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckGlmVendor.Visible = True
		Me.ckGlmVendor.Name = "ckGlmVendor"
		Me.ckUseGlmRate.Text = "Use GLM Rate"
		Me.ckUseGlmRate.Size = New System.Drawing.Size(145, 17)
		Me.ckUseGlmRate.Location = New System.Drawing.Point(24, 384)
		Me.ckUseGlmRate.TabIndex = 30
		Me.ckUseGlmRate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckUseGlmRate.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckUseGlmRate.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckUseGlmRate.BackColor = System.Drawing.SystemColors.Control
		Me.ckUseGlmRate.CausesValidation = True
		Me.ckUseGlmRate.Enabled = True
		Me.ckUseGlmRate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckUseGlmRate.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckUseGlmRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckUseGlmRate.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckUseGlmRate.TabStop = True
		Me.ckUseGlmRate.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckUseGlmRate.Visible = True
		Me.ckUseGlmRate.Name = "ckUseGlmRate"
		Me.ckUseForBilling.Text = "Use for Customer Billing"
		Me.ckUseForBilling.Size = New System.Drawing.Size(145, 17)
		Me.ckUseForBilling.Location = New System.Drawing.Point(24, 360)
		Me.ckUseForBilling.TabIndex = 29
		Me.ckUseForBilling.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckUseForBilling.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckUseForBilling.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckUseForBilling.BackColor = System.Drawing.SystemColors.Control
		Me.ckUseForBilling.CausesValidation = True
		Me.ckUseForBilling.Enabled = True
		Me.ckUseForBilling.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckUseForBilling.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckUseForBilling.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckUseForBilling.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckUseForBilling.TabStop = True
		Me.ckUseForBilling.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckUseForBilling.Visible = True
		Me.ckUseForBilling.Name = "ckUseForBilling"
		Me.txtReportName.AutoSize = False
		Me.txtReportName.Size = New System.Drawing.Size(129, 21)
		Me.txtReportName.Location = New System.Drawing.Point(320, 392)
		Me.txtReportName.TabIndex = 28
		Me.txtReportName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReportName.AcceptsReturn = True
		Me.txtReportName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReportName.BackColor = System.Drawing.SystemColors.Window
		Me.txtReportName.CausesValidation = True
		Me.txtReportName.Enabled = True
		Me.txtReportName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReportName.HideSelection = True
		Me.txtReportName.ReadOnly = False
		Me.txtReportName.Maxlength = 0
		Me.txtReportName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReportName.MultiLine = False
		Me.txtReportName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReportName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReportName.TabStop = True
		Me.txtReportName.Visible = True
		Me.txtReportName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReportName.Name = "txtReportName"
		Me.ckPublish.Text = "Publish to Web"
		Me.ckPublish.Size = New System.Drawing.Size(185, 25)
		Me.ckPublish.Location = New System.Drawing.Point(240, 360)
		Me.ckPublish.TabIndex = 26
		Me.ckPublish.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckPublish.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckPublish.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckPublish.BackColor = System.Drawing.SystemColors.Control
		Me.ckPublish.CausesValidation = True
		Me.ckPublish.Enabled = True
		Me.ckPublish.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckPublish.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckPublish.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckPublish.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckPublish.TabStop = True
		Me.ckPublish.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckPublish.Visible = True
		Me.ckPublish.Name = "ckPublish"
		Me.cbReportTemplate.Enabled = False
		Me.cbReportTemplate.Size = New System.Drawing.Size(321, 21)
		Me.cbReportTemplate.Location = New System.Drawing.Point(296, 88)
		Me.cbReportTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.cbReportTemplate.TabIndex = 25
		Me.cbReportTemplate.Text = "cbReportTemplate"
		Me.cbReportTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbReportTemplate.BackColor = System.Drawing.SystemColors.Window
		Me.cbReportTemplate.CausesValidation = True
		Me.cbReportTemplate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbReportTemplate.IntegralHeight = True
		Me.cbReportTemplate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbReportTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbReportTemplate.Sorted = False
		Me.cbReportTemplate.TabStop = True
		Me.cbReportTemplate.Visible = True
		Me.cbReportTemplate.Name = "cbReportTemplate"
		Me.txtReportCaption.AutoSize = False
		Me.txtReportCaption.Size = New System.Drawing.Size(201, 21)
		Me.txtReportCaption.Location = New System.Drawing.Point(88, 88)
		Me.txtReportCaption.TabIndex = 23
		Me.txtReportCaption.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReportCaption.AcceptsReturn = True
		Me.txtReportCaption.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReportCaption.BackColor = System.Drawing.SystemColors.Window
		Me.txtReportCaption.CausesValidation = True
		Me.txtReportCaption.Enabled = True
		Me.txtReportCaption.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReportCaption.HideSelection = True
		Me.txtReportCaption.ReadOnly = False
		Me.txtReportCaption.Maxlength = 0
		Me.txtReportCaption.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReportCaption.MultiLine = False
		Me.txtReportCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReportCaption.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReportCaption.TabStop = True
		Me.txtReportCaption.Visible = True
		Me.txtReportCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReportCaption.Name = "txtReportCaption"
		Me.ckJustInvoice.Text = "Show just Stores with Invoices"
		Me.ckJustInvoice.Size = New System.Drawing.Size(177, 17)
		Me.ckJustInvoice.Location = New System.Drawing.Point(24, 336)
		Me.ckJustInvoice.TabIndex = 21
		Me.ckJustInvoice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckJustInvoice.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckJustInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckJustInvoice.BackColor = System.Drawing.SystemColors.Control
		Me.ckJustInvoice.CausesValidation = True
		Me.ckJustInvoice.Enabled = True
		Me.ckJustInvoice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckJustInvoice.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckJustInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckJustInvoice.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckJustInvoice.TabStop = True
		Me.ckJustInvoice.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckJustInvoice.Visible = True
		Me.ckJustInvoice.Name = "ckJustInvoice"
		Me.cbCustName.Size = New System.Drawing.Size(121, 21)
		Me.cbCustName.Location = New System.Drawing.Point(88, 24)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 0
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
		Me.cbCustId.Size = New System.Drawing.Size(65, 21)
		Me.cbCustId.Location = New System.Drawing.Point(152, 0)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 17
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
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 41)
		Me.cmdCancel.Location = New System.Drawing.Point(328, 432)
		Me.cmdCancel.TabIndex = 16
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
		Me.cmdOk.Location = New System.Drawing.Point(248, 432)
		Me.cmdOk.TabIndex = 15
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.Frame1.Text = "Period/Date"
		Me.Frame1.Size = New System.Drawing.Size(449, 201)
		Me.Frame1.Location = New System.Drawing.Point(24, 120)
		Me.Frame1.TabIndex = 3
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbPeriodName.Size = New System.Drawing.Size(129, 21)
		Me.cbPeriodName.Location = New System.Drawing.Point(120, 32)
		Me.cbPeriodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodName.TabIndex = 6
		Me.cbPeriodName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPeriodName.BackColor = System.Drawing.SystemColors.Window
		Me.cbPeriodName.CausesValidation = True
		Me.cbPeriodName.Enabled = True
		Me.cbPeriodName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbPeriodName.IntegralHeight = True
		Me.cbPeriodName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbPeriodName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbPeriodName.Sorted = False
		Me.cbPeriodName.TabStop = True
		Me.cbPeriodName.Visible = True
		Me.cbPeriodName.Name = "cbPeriodName"
		Me.obRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obRange.Text = "Invoices in Date Range"
		Me.obRange.Size = New System.Drawing.Size(161, 17)
		Me.obRange.Location = New System.Drawing.Point(16, 112)
		Me.obRange.TabIndex = 5
		Me.obRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obRange.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obRange.BackColor = System.Drawing.SystemColors.Control
		Me.obRange.CausesValidation = True
		Me.obRange.Enabled = True
		Me.obRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.obRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obRange.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obRange.TabStop = True
		Me.obRange.Checked = False
		Me.obRange.Visible = True
		Me.obRange.Name = "obRange"
		Me.obPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriod.Text = "Invoicing Period"
		Me.obPeriod.Size = New System.Drawing.Size(97, 13)
		Me.obPeriod.Location = New System.Drawing.Point(16, 32)
		Me.obPeriod.TabIndex = 4
		Me.obPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obPeriod.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriod.BackColor = System.Drawing.SystemColors.Control
		Me.obPeriod.CausesValidation = True
		Me.obPeriod.Enabled = True
		Me.obPeriod.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obPeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.obPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obPeriod.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obPeriod.TabStop = True
		Me.obPeriod.Checked = False
		Me.obPeriod.Visible = True
		Me.obPeriod.Name = "obPeriod"
		dtEndDate.OcxState = CType(resources.GetObject("dtEndDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtEndDate.Size = New System.Drawing.Size(89, 21)
		Me.dtEndDate.Location = New System.Drawing.Point(120, 160)
		Me.dtEndDate.TabIndex = 7
		Me.dtEndDate.Name = "dtEndDate"
		dtStartDate.OcxState = CType(resources.GetObject("dtStartDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtStartDate.Size = New System.Drawing.Size(89, 21)
		Me.dtStartDate.Location = New System.Drawing.Point(120, 136)
		Me.dtStartDate.TabIndex = 8
		Me.dtStartDate.Name = "dtStartDate"
		Me.lbEndDate.Text = "End"
		Me.lbEndDate.Size = New System.Drawing.Size(113, 17)
		Me.lbEndDate.Location = New System.Drawing.Point(120, 88)
		Me.lbEndDate.TabIndex = 14
		Me.lbEndDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.lbStartDate.Text = "Start"
		Me.lbStartDate.Size = New System.Drawing.Size(89, 17)
		Me.lbStartDate.Location = New System.Drawing.Point(120, 64)
		Me.lbStartDate.TabIndex = 13
		Me.lbStartDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label7.Text = "To"
		Me.Label7.Size = New System.Drawing.Size(17, 17)
		Me.Label7.Location = New System.Drawing.Point(80, 88)
		Me.Label7.TabIndex = 12
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
		Me.Label6.Text = "From"
		Me.Label6.Size = New System.Drawing.Size(33, 17)
		Me.Label6.Location = New System.Drawing.Point(80, 64)
		Me.Label6.TabIndex = 11
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
		Me.Label5.Text = "End Date"
		Me.Label5.Size = New System.Drawing.Size(49, 21)
		Me.Label5.Location = New System.Drawing.Point(64, 160)
		Me.Label5.TabIndex = 10
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
		Me.Label4.Text = "Start Date"
		Me.Label4.Size = New System.Drawing.Size(49, 21)
		Me.Label4.Location = New System.Drawing.Point(64, 136)
		Me.Label4.TabIndex = 9
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
		Me.cbGroupName.Size = New System.Drawing.Size(137, 21)
		Me.cbGroupName.Location = New System.Drawing.Point(88, 56)
		Me.cbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbGroupName.TabIndex = 2
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
		Me.cbStateId.Size = New System.Drawing.Size(73, 21)
		Me.cbStateId.Location = New System.Drawing.Point(368, 24)
		Me.cbStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStateId.TabIndex = 1
		Me.cbStateId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStateId.BackColor = System.Drawing.SystemColors.Window
		Me.cbStateId.CausesValidation = True
		Me.cbStateId.Enabled = True
		Me.cbStateId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStateId.IntegralHeight = True
		Me.cbStateId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStateId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStateId.Sorted = False
		Me.cbStateId.TabStop = True
		Me.cbStateId.Visible = True
		Me.cbStateId.Name = "cbStateId"
		Me.Label10.Text = "Report Name"
		Me.Label10.Size = New System.Drawing.Size(73, 17)
		Me.Label10.Location = New System.Drawing.Point(240, 392)
		Me.Label10.TabIndex = 27
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
		Me.Label9.Text = "Template"
		Me.Label9.Size = New System.Drawing.Size(49, 17)
		Me.Label9.Location = New System.Drawing.Point(312, 56)
		Me.Label9.TabIndex = 24
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
		Me.Label8.Text = "Report Caption"
		Me.Label8.Size = New System.Drawing.Size(49, 33)
		Me.Label8.Location = New System.Drawing.Point(24, 80)
		Me.Label8.TabIndex = 22
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
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 24)
		Me.Label1.TabIndex = 20
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
		Me.label3.Text = "Store Group"
		Me.label3.Size = New System.Drawing.Size(57, 17)
		Me.label3.Location = New System.Drawing.Point(24, 56)
		Me.label3.TabIndex = 19
		Me.label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label3.BackColor = System.Drawing.SystemColors.Control
		Me.label3.Enabled = True
		Me.label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label3.UseMnemonic = True
		Me.label3.Visible = True
		Me.label3.AutoSize = False
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label3.Name = "label3"
		Me.Label2.Text = "State"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(312, 24)
		Me.Label2.TabIndex = 18
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
		Me.Controls.Add(ckPrintFinal)
		Me.Controls.Add(cmdSelectValues)
		Me.Controls.Add(cbReportTemplateDesc)
		Me.Controls.Add(ckGlmVendor)
		Me.Controls.Add(ckUseGlmRate)
		Me.Controls.Add(ckUseForBilling)
		Me.Controls.Add(txtReportName)
		Me.Controls.Add(ckPublish)
		Me.Controls.Add(cbReportTemplate)
		Me.Controls.Add(txtReportCaption)
		Me.Controls.Add(ckJustInvoice)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cbGroupName)
		Me.Controls.Add(cbStateId)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label1)
		Me.Controls.Add(label3)
		Me.Controls.Add(Label2)
		Me.Frame1.Controls.Add(cbPeriodName)
		Me.Frame1.Controls.Add(obRange)
		Me.Frame1.Controls.Add(obPeriod)
		Me.Frame1.Controls.Add(dtEndDate)
		Me.Frame1.Controls.Add(dtStartDate)
		Me.Frame1.Controls.Add(lbEndDate)
		Me.Frame1.Controls.Add(lbStartDate)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		CType(Me.dtStartDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtEndDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class