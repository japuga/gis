<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepEnv
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
	Public WithEvents ckShowContract As System.Windows.Forms.CheckBox
	Public WithEvents cbStateId As System.Windows.Forms.ComboBox
	Public WithEvents cbGroupName As System.Windows.Forms.ComboBox
	Public WithEvents obPeriod As System.Windows.Forms.RadioButton
	Public WithEvents cbPeriodName As System.Windows.Forms.ComboBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents lbStartDate As System.Windows.Forms.Label
	Public WithEvents lbEndDate As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents txtReportCaption As System.Windows.Forms.TextBox
	Public WithEvents cbReportTemplate As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepEnv))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ckShowContract = New System.Windows.Forms.CheckBox
		Me.cbStateId = New System.Windows.Forms.ComboBox
		Me.cbGroupName = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.obPeriod = New System.Windows.Forms.RadioButton
		Me.cbPeriodName = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.lbStartDate = New System.Windows.Forms.Label
		Me.lbEndDate = New System.Windows.Forms.Label
		Me.cmdOk = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.txtReportCaption = New System.Windows.Forms.TextBox
		Me.cbReportTemplate = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Environmental Report"
		Me.ClientSize = New System.Drawing.Size(528, 372)
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
		Me.Name = "frmRepEnv"
		Me.ckShowContract.Text = "Show Contract Ranges"
		Me.ckShowContract.Size = New System.Drawing.Size(169, 17)
		Me.ckShowContract.Location = New System.Drawing.Point(40, 280)
		Me.ckShowContract.TabIndex = 20
		Me.ckShowContract.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckShowContract.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckShowContract.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckShowContract.BackColor = System.Drawing.SystemColors.Control
		Me.ckShowContract.CausesValidation = True
		Me.ckShowContract.Enabled = True
		Me.ckShowContract.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckShowContract.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckShowContract.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckShowContract.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckShowContract.TabStop = True
		Me.ckShowContract.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckShowContract.Visible = True
		Me.ckShowContract.Name = "ckShowContract"
		Me.cbStateId.Size = New System.Drawing.Size(73, 21)
		Me.cbStateId.Location = New System.Drawing.Point(328, 32)
		Me.cbStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStateId.TabIndex = 14
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
		Me.cbGroupName.Size = New System.Drawing.Size(137, 21)
		Me.cbGroupName.Location = New System.Drawing.Point(104, 64)
		Me.cbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbGroupName.TabIndex = 13
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
		Me.Frame1.Text = "Period/Date"
		Me.Frame1.Size = New System.Drawing.Size(449, 137)
		Me.Frame1.Location = New System.Drawing.Point(40, 128)
		Me.Frame1.TabIndex = 6
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.obPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriod.Text = "Invoicing Period"
		Me.obPeriod.Size = New System.Drawing.Size(97, 13)
		Me.obPeriod.Location = New System.Drawing.Point(16, 32)
		Me.obPeriod.TabIndex = 8
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
		Me.cbPeriodName.Size = New System.Drawing.Size(129, 21)
		Me.cbPeriodName.Location = New System.Drawing.Point(120, 32)
		Me.cbPeriodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodName.TabIndex = 7
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
		Me.Label6.Text = "From"
		Me.Label6.Size = New System.Drawing.Size(33, 17)
		Me.Label6.Location = New System.Drawing.Point(80, 64)
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
		Me.Label7.Text = "To"
		Me.Label7.Size = New System.Drawing.Size(17, 17)
		Me.Label7.Location = New System.Drawing.Point(80, 88)
		Me.Label7.TabIndex = 11
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
		Me.lbStartDate.Text = "Start"
		Me.lbStartDate.Size = New System.Drawing.Size(89, 17)
		Me.lbStartDate.Location = New System.Drawing.Point(120, 64)
		Me.lbStartDate.TabIndex = 10
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
		Me.lbEndDate.Text = "End"
		Me.lbEndDate.Size = New System.Drawing.Size(113, 17)
		Me.lbEndDate.Location = New System.Drawing.Point(120, 88)
		Me.lbEndDate.TabIndex = 9
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
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(57, 41)
		Me.cmdOk.Location = New System.Drawing.Point(200, 320)
		Me.cmdOk.TabIndex = 5
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 41)
		Me.cmdCancel.Location = New System.Drawing.Point(280, 320)
		Me.cmdCancel.TabIndex = 4
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cbCustId.Size = New System.Drawing.Size(65, 21)
		Me.cbCustId.Location = New System.Drawing.Point(168, 8)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 3
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
		Me.cbCustName.Size = New System.Drawing.Size(121, 21)
		Me.cbCustName.Location = New System.Drawing.Point(104, 32)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 2
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
		Me.txtReportCaption.AutoSize = False
		Me.txtReportCaption.Size = New System.Drawing.Size(377, 21)
		Me.txtReportCaption.Location = New System.Drawing.Point(104, 96)
		Me.txtReportCaption.TabIndex = 1
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
		Me.cbReportTemplate.Size = New System.Drawing.Size(153, 21)
		Me.cbReportTemplate.Location = New System.Drawing.Point(328, 64)
		Me.cbReportTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbReportTemplate.TabIndex = 0
		Me.cbReportTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbReportTemplate.BackColor = System.Drawing.SystemColors.Window
		Me.cbReportTemplate.CausesValidation = True
		Me.cbReportTemplate.Enabled = True
		Me.cbReportTemplate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbReportTemplate.IntegralHeight = True
		Me.cbReportTemplate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbReportTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbReportTemplate.Sorted = False
		Me.cbReportTemplate.TabStop = True
		Me.cbReportTemplate.Visible = True
		Me.cbReportTemplate.Name = "cbReportTemplate"
		Me.Label2.Text = "State"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(272, 32)
		Me.Label2.TabIndex = 19
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
		Me.label3.Text = "Store Group"
		Me.label3.Size = New System.Drawing.Size(57, 17)
		Me.label3.Location = New System.Drawing.Point(40, 64)
		Me.label3.TabIndex = 18
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
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 32)
		Me.Label1.TabIndex = 17
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
		Me.Label8.Text = "Report Caption"
		Me.Label8.Size = New System.Drawing.Size(49, 33)
		Me.Label8.Location = New System.Drawing.Point(40, 88)
		Me.Label8.TabIndex = 16
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
		Me.Label9.Text = "Template"
		Me.Label9.Size = New System.Drawing.Size(49, 17)
		Me.Label9.Location = New System.Drawing.Point(272, 64)
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
		Me.Controls.Add(ckShowContract)
		Me.Controls.Add(cbStateId)
		Me.Controls.Add(cbGroupName)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(txtReportCaption)
		Me.Controls.Add(cbReportTemplate)
		Me.Controls.Add(Label2)
		Me.Controls.Add(label3)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label9)
		Me.Frame1.Controls.Add(obPeriod)
		Me.Frame1.Controls.Add(cbPeriodName)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(lbStartDate)
		Me.Frame1.Controls.Add(lbEndDate)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class