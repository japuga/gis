<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepUniversal
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
	Public WithEvents cmdAllRightContent As System.Windows.Forms.Button
	Public WithEvents cmdRightContent As System.Windows.Forms.Button
	Public WithEvents cmdLeftContent As System.Windows.Forms.Button
	Public WithEvents cmdAllLeftContent As System.Windows.Forms.Button
	Public WithEvents dgContent As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgSelContent As AxMSDataGridLib.AxDataGrid
	Public WithEvents _lbTitle_3 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_3 As System.Windows.Forms.GroupBox
	Public WithEvents _obEquipment_2 As System.Windows.Forms.RadioButton
	Public WithEvents _obEquipment_1 As System.Windows.Forms.RadioButton
	Public WithEvents _obEquipment_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents dgEquipment As AxMSDataGridLib.AxDataGrid
	Public WithEvents cmdAllLeftEquipment As System.Windows.Forms.Button
	Public WithEvents cmdLeftEquipment As System.Windows.Forms.Button
	Public WithEvents cmdRightEquipment As System.Windows.Forms.Button
	Public WithEvents cmdAllRightEquipment As System.Windows.Forms.Button
	Public WithEvents dgSelEquipment As AxMSDataGridLib.AxDataGrid
	Public WithEvents _lbTitle_2 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_2 As System.Windows.Forms.GroupBox
	Public WithEvents cbInvoiceEqpt As System.Windows.Forms.CheckBox
	Public WithEvents cbWithoutEqpt As System.Windows.Forms.CheckBox
	Public WithEvents cbReportTemplate As System.Windows.Forms.ComboBox
	Public WithEvents txtReportTitle As System.Windows.Forms.TextBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents txtReportCaption As System.Windows.Forms.TextBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbGroupName As System.Windows.Forms.ComboBox
	Public WithEvents cbStateId As System.Windows.Forms.ComboBox
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents _lbTitle_0 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_0 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFinish As System.Windows.Forms.Button
	Public WithEvents cmdNext As System.Windows.Forms.Button
	Public WithEvents cmdPrev As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents _sb_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sb As System.Windows.Forms.StatusStrip
	Public WithEvents cbPeriodName As System.Windows.Forms.ComboBox
	Public WithEvents obSinglePeriod As System.Windows.Forms.RadioButton
	Public WithEvents obRangePeriod As System.Windows.Forms.RadioButton
	Public WithEvents cbPeriodStart As System.Windows.Forms.ComboBox
	Public WithEvents cbPeriodEnd As System.Windows.Forms.ComboBox
	Public WithEvents obRange As System.Windows.Forms.RadioButton
	Public WithEvents obPeriodNameSingle As System.Windows.Forms.RadioButton
	Public WithEvents obPeriodDateSingle As System.Windows.Forms.RadioButton
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents obPeriodDateRange As System.Windows.Forms.RadioButton
	Public WithEvents obPeriodNameRange As System.Windows.Forms.RadioButton
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents dtEndDate As AxMSComCtl2.AxDTPicker
	Public WithEvents dtStartDate As AxMSComCtl2.AxDTPicker
	Public WithEvents lbPeriodEndDate As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents lbPeriodStartDate As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents lbEndDate As System.Windows.Forms.Label
	Public WithEvents lbStartDate As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _lbTitle_1 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_1 As System.Windows.Forms.GroupBox
	Public WithEvents dgDebug As AxMSDataGridLib.AxDataGrid
	Public WithEvents cmdAllLeftVendor As System.Windows.Forms.Button
	Public WithEvents cmdLeftVendor As System.Windows.Forms.Button
	Public WithEvents cmdRightVendor As System.Windows.Forms.Button
	Public WithEvents cmdAllRightVendor As System.Windows.Forms.Button
	Public WithEvents dgVendor As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgSelVendor As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents _lbTitle_6 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_6 As System.Windows.Forms.GroupBox
	Public WithEvents cmdAllLeftServ As System.Windows.Forms.Button
	Public WithEvents cmdLeftServ As System.Windows.Forms.Button
	Public WithEvents cmdRightServ As System.Windows.Forms.Button
	Public WithEvents cmdAllRightServ As System.Windows.Forms.Button
	Public WithEvents dgSelService As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgService As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents _lbTitle_5 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_5 As System.Windows.Forms.GroupBox
	Public WithEvents cmdAllLeftLoad As System.Windows.Forms.Button
	Public WithEvents cmdLeftLoad As System.Windows.Forms.Button
	Public WithEvents cmdRightLoad As System.Windows.Forms.Button
	Public WithEvents cmdAllRightLoad As System.Windows.Forms.Button
	Public WithEvents dgLoad As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgSelLoad As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents _lbTitle_4 As System.Windows.Forms.Label
	Public WithEvents _frCriteria_4 As System.Windows.Forms.GroupBox
	Public WithEvents frCriteria As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents lbTitle As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents obEquipment As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepUniversal))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._frCriteria_3 = New System.Windows.Forms.GroupBox
		Me.cmdAllRightContent = New System.Windows.Forms.Button
		Me.cmdRightContent = New System.Windows.Forms.Button
		Me.cmdLeftContent = New System.Windows.Forms.Button
		Me.cmdAllLeftContent = New System.Windows.Forms.Button
		Me.dgContent = New AxMSDataGridLib.AxDataGrid
		Me.dgSelContent = New AxMSDataGridLib.AxDataGrid
		Me._lbTitle_3 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me._frCriteria_2 = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._obEquipment_2 = New System.Windows.Forms.RadioButton
		Me._obEquipment_1 = New System.Windows.Forms.RadioButton
		Me._obEquipment_0 = New System.Windows.Forms.RadioButton
		Me.dgEquipment = New AxMSDataGridLib.AxDataGrid
		Me.cmdAllLeftEquipment = New System.Windows.Forms.Button
		Me.cmdLeftEquipment = New System.Windows.Forms.Button
		Me.cmdRightEquipment = New System.Windows.Forms.Button
		Me.cmdAllRightEquipment = New System.Windows.Forms.Button
		Me.dgSelEquipment = New AxMSDataGridLib.AxDataGrid
		Me._lbTitle_2 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me._frCriteria_0 = New System.Windows.Forms.GroupBox
		Me.cbInvoiceEqpt = New System.Windows.Forms.CheckBox
		Me.cbWithoutEqpt = New System.Windows.Forms.CheckBox
		Me.cbReportTemplate = New System.Windows.Forms.ComboBox
		Me.txtReportTitle = New System.Windows.Forms.TextBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.txtReportCaption = New System.Windows.Forms.TextBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbGroupName = New System.Windows.Forms.ComboBox
		Me.cbStateId = New System.Windows.Forms.ComboBox
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label18 = New System.Windows.Forms.Label
		Me._lbTitle_0 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.cmdFinish = New System.Windows.Forms.Button
		Me.cmdNext = New System.Windows.Forms.Button
		Me.cmdPrev = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.sb = New System.Windows.Forms.StatusStrip
		Me._sb_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me._frCriteria_1 = New System.Windows.Forms.GroupBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cbPeriodName = New System.Windows.Forms.ComboBox
		Me.obSinglePeriod = New System.Windows.Forms.RadioButton
		Me.obRangePeriod = New System.Windows.Forms.RadioButton
		Me.cbPeriodStart = New System.Windows.Forms.ComboBox
		Me.cbPeriodEnd = New System.Windows.Forms.ComboBox
		Me.obRange = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.obPeriodNameSingle = New System.Windows.Forms.RadioButton
		Me.obPeriodDateSingle = New System.Windows.Forms.RadioButton
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.obPeriodDateRange = New System.Windows.Forms.RadioButton
		Me.obPeriodNameRange = New System.Windows.Forms.RadioButton
		Me.dtEndDate = New AxMSComCtl2.AxDTPicker
		Me.dtStartDate = New AxMSComCtl2.AxDTPicker
		Me.lbPeriodEndDate = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.lbPeriodStartDate = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.lbEndDate = New System.Windows.Forms.Label
		Me.lbStartDate = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me._lbTitle_1 = New System.Windows.Forms.Label
		Me._frCriteria_6 = New System.Windows.Forms.GroupBox
		Me.dgDebug = New AxMSDataGridLib.AxDataGrid
		Me.cmdAllLeftVendor = New System.Windows.Forms.Button
		Me.cmdLeftVendor = New System.Windows.Forms.Button
		Me.cmdRightVendor = New System.Windows.Forms.Button
		Me.cmdAllRightVendor = New System.Windows.Forms.Button
		Me.dgVendor = New AxMSDataGridLib.AxDataGrid
		Me.dgSelVendor = New AxMSDataGridLib.AxDataGrid
		Me.Label17 = New System.Windows.Forms.Label
		Me._lbTitle_6 = New System.Windows.Forms.Label
		Me._frCriteria_5 = New System.Windows.Forms.GroupBox
		Me.cmdAllLeftServ = New System.Windows.Forms.Button
		Me.cmdLeftServ = New System.Windows.Forms.Button
		Me.cmdRightServ = New System.Windows.Forms.Button
		Me.cmdAllRightServ = New System.Windows.Forms.Button
		Me.dgSelService = New AxMSDataGridLib.AxDataGrid
		Me.dgService = New AxMSDataGridLib.AxDataGrid
		Me.Label16 = New System.Windows.Forms.Label
		Me._lbTitle_5 = New System.Windows.Forms.Label
		Me._frCriteria_4 = New System.Windows.Forms.GroupBox
		Me.cmdAllLeftLoad = New System.Windows.Forms.Button
		Me.cmdLeftLoad = New System.Windows.Forms.Button
		Me.cmdRightLoad = New System.Windows.Forms.Button
		Me.cmdAllRightLoad = New System.Windows.Forms.Button
		Me.dgLoad = New AxMSDataGridLib.AxDataGrid
		Me.dgSelLoad = New AxMSDataGridLib.AxDataGrid
		Me.Label15 = New System.Windows.Forms.Label
		Me._lbTitle_4 = New System.Windows.Forms.Label
		Me.frCriteria = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.lbTitle = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.obEquipment = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me._frCriteria_3.SuspendLayout()
		Me._frCriteria_2.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me._frCriteria_0.SuspendLayout()
		Me.sb.SuspendLayout()
		Me._frCriteria_1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me._frCriteria_6.SuspendLayout()
		Me._frCriteria_5.SuspendLayout()
		Me._frCriteria_4.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgContent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelContent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgDebug, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgVendor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelVendor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelService, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgService, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgLoad, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelLoad, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.frCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.obEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Universal Report"
		Me.ClientSize = New System.Drawing.Size(675, 599)
		Me.Location = New System.Drawing.Point(130, 41)
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
		Me.Name = "frmRepUniversal"
		Me._frCriteria_3.Text = "Content"
		Me._frCriteria_3.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_3.Size = New System.Drawing.Size(465, 505)
		Me._frCriteria_3.Location = New System.Drawing.Point(72, 88)
		Me._frCriteria_3.TabIndex = 17
		Me._frCriteria_3.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_3.Enabled = True
		Me._frCriteria_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._frCriteria_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_3.Visible = True
		Me._frCriteria_3.Name = "_frCriteria_3"
		Me.cmdAllRightContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllRightContent.Text = ">>"
		Me.cmdAllRightContent.Size = New System.Drawing.Size(49, 33)
		Me.cmdAllRightContent.Location = New System.Drawing.Point(208, 120)
		Me.cmdAllRightContent.TabIndex = 29
		Me.cmdAllRightContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllRightContent.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllRightContent.CausesValidation = True
		Me.cmdAllRightContent.Enabled = True
		Me.cmdAllRightContent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllRightContent.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllRightContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllRightContent.TabStop = True
		Me.cmdAllRightContent.Name = "cmdAllRightContent"
		Me.cmdRightContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRightContent.Text = ">"
		Me.cmdRightContent.Size = New System.Drawing.Size(49, 33)
		Me.cmdRightContent.Location = New System.Drawing.Point(208, 176)
		Me.cmdRightContent.TabIndex = 28
		Me.cmdRightContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRightContent.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRightContent.CausesValidation = True
		Me.cmdRightContent.Enabled = True
		Me.cmdRightContent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRightContent.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRightContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRightContent.TabStop = True
		Me.cmdRightContent.Name = "cmdRightContent"
		Me.cmdLeftContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeftContent.Text = "<"
		Me.cmdLeftContent.Size = New System.Drawing.Size(49, 33)
		Me.cmdLeftContent.Location = New System.Drawing.Point(208, 232)
		Me.cmdLeftContent.TabIndex = 27
		Me.cmdLeftContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeftContent.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeftContent.CausesValidation = True
		Me.cmdLeftContent.Enabled = True
		Me.cmdLeftContent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeftContent.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeftContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeftContent.TabStop = True
		Me.cmdLeftContent.Name = "cmdLeftContent"
		Me.cmdAllLeftContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllLeftContent.Text = "<<"
		Me.cmdAllLeftContent.Size = New System.Drawing.Size(49, 33)
		Me.cmdAllLeftContent.Location = New System.Drawing.Point(208, 288)
		Me.cmdAllLeftContent.TabIndex = 26
		Me.cmdAllLeftContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllLeftContent.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllLeftContent.CausesValidation = True
		Me.cmdAllLeftContent.Enabled = True
		Me.cmdAllLeftContent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllLeftContent.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllLeftContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllLeftContent.TabStop = True
		Me.cmdAllLeftContent.Name = "cmdAllLeftContent"
		dgContent.OcxState = CType(resources.GetObject("dgContent.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgContent.Size = New System.Drawing.Size(169, 201)
		Me.dgContent.Location = New System.Drawing.Point(16, 120)
		Me.dgContent.TabIndex = 19
		Me.dgContent.Name = "dgContent"
		dgSelContent.OcxState = CType(resources.GetObject("dgSelContent.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelContent.Size = New System.Drawing.Size(169, 201)
		Me.dgSelContent.Location = New System.Drawing.Point(280, 120)
		Me.dgSelContent.TabIndex = 20
		Me.dgSelContent.Name = "dgSelContent"
		Me._lbTitle_3.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_3.Text = " Step 4.  Contents>>"
		Me._lbTitle_3.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_3.Size = New System.Drawing.Size(201, 17)
		Me._lbTitle_3.Location = New System.Drawing.Point(24, 16)
		Me._lbTitle_3.TabIndex = 32
		Me._lbTitle_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_3.Enabled = True
		Me._lbTitle_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbTitle_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_3.UseMnemonic = True
		Me._lbTitle_3.Visible = True
		Me._lbTitle_3.AutoSize = False
		Me._lbTitle_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_3.Name = "_lbTitle_3"
		Me.Label14.Text = "Select Equipment Contents"
		Me.Label14.Size = New System.Drawing.Size(209, 17)
		Me.Label14.Location = New System.Drawing.Point(32, 64)
		Me.Label14.TabIndex = 18
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
		Me._frCriteria_2.Text = "Equipment"
		Me._frCriteria_2.ForeColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me._frCriteria_2.Size = New System.Drawing.Size(449, 481)
		Me._frCriteria_2.Location = New System.Drawing.Point(56, 64)
		Me._frCriteria_2.TabIndex = 13
		Me._frCriteria_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_2.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_2.Enabled = True
		Me._frCriteria_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_2.Visible = True
		Me._frCriteria_2.Name = "_frCriteria_2"
		Me.Frame2.Size = New System.Drawing.Size(385, 105)
		Me.Frame2.Location = New System.Drawing.Point(24, 56)
		Me.Frame2.TabIndex = 34
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me._obEquipment_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._obEquipment_2.Text = "All"
		Me._obEquipment_2.Size = New System.Drawing.Size(97, 17)
		Me._obEquipment_2.Location = New System.Drawing.Point(16, 72)
		Me._obEquipment_2.TabIndex = 37
		Me._obEquipment_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._obEquipment_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._obEquipment_2.BackColor = System.Drawing.SystemColors.Control
		Me._obEquipment_2.CausesValidation = True
		Me._obEquipment_2.Enabled = True
		Me._obEquipment_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._obEquipment_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._obEquipment_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._obEquipment_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._obEquipment_2.TabStop = True
		Me._obEquipment_2.Checked = False
		Me._obEquipment_2.Visible = True
		Me._obEquipment_2.Name = "_obEquipment_2"
		Me._obEquipment_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._obEquipment_1.Text = "Temporary"
		Me._obEquipment_1.Size = New System.Drawing.Size(113, 17)
		Me._obEquipment_1.Location = New System.Drawing.Point(16, 48)
		Me._obEquipment_1.TabIndex = 36
		Me._obEquipment_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._obEquipment_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._obEquipment_1.BackColor = System.Drawing.SystemColors.Control
		Me._obEquipment_1.CausesValidation = True
		Me._obEquipment_1.Enabled = True
		Me._obEquipment_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._obEquipment_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._obEquipment_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._obEquipment_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._obEquipment_1.TabStop = True
		Me._obEquipment_1.Checked = False
		Me._obEquipment_1.Visible = True
		Me._obEquipment_1.Name = "_obEquipment_1"
		Me._obEquipment_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._obEquipment_0.Text = "Permanent"
		Me._obEquipment_0.Size = New System.Drawing.Size(97, 17)
		Me._obEquipment_0.Location = New System.Drawing.Point(16, 24)
		Me._obEquipment_0.TabIndex = 35
		Me._obEquipment_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._obEquipment_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._obEquipment_0.BackColor = System.Drawing.SystemColors.Control
		Me._obEquipment_0.CausesValidation = True
		Me._obEquipment_0.Enabled = True
		Me._obEquipment_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._obEquipment_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._obEquipment_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._obEquipment_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._obEquipment_0.TabStop = True
		Me._obEquipment_0.Checked = False
		Me._obEquipment_0.Visible = True
		Me._obEquipment_0.Name = "_obEquipment_0"
		dgEquipment.OcxState = CType(resources.GetObject("dgEquipment.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgEquipment.Size = New System.Drawing.Size(169, 265)
		Me.dgEquipment.Location = New System.Drawing.Point(8, 192)
		Me.dgEquipment.TabIndex = 15
		Me.dgEquipment.Name = "dgEquipment"
		Me.cmdAllLeftEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllLeftEquipment.Text = "<<"
		Me.cmdAllLeftEquipment.Size = New System.Drawing.Size(41, 33)
		Me.cmdAllLeftEquipment.Location = New System.Drawing.Point(208, 376)
		Me.cmdAllLeftEquipment.TabIndex = 24
		Me.cmdAllLeftEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllLeftEquipment.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllLeftEquipment.CausesValidation = True
		Me.cmdAllLeftEquipment.Enabled = True
		Me.cmdAllLeftEquipment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllLeftEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllLeftEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllLeftEquipment.TabStop = True
		Me.cmdAllLeftEquipment.Name = "cmdAllLeftEquipment"
		Me.cmdLeftEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeftEquipment.Text = "<"
		Me.cmdLeftEquipment.Size = New System.Drawing.Size(41, 33)
		Me.cmdLeftEquipment.Location = New System.Drawing.Point(208, 320)
		Me.cmdLeftEquipment.TabIndex = 23
		Me.cmdLeftEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeftEquipment.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeftEquipment.CausesValidation = True
		Me.cmdLeftEquipment.Enabled = True
		Me.cmdLeftEquipment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeftEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeftEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeftEquipment.TabStop = True
		Me.cmdLeftEquipment.Name = "cmdLeftEquipment"
		Me.cmdRightEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRightEquipment.Text = ">"
		Me.cmdRightEquipment.Size = New System.Drawing.Size(41, 33)
		Me.cmdRightEquipment.Location = New System.Drawing.Point(208, 264)
		Me.cmdRightEquipment.TabIndex = 22
		Me.cmdRightEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRightEquipment.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRightEquipment.CausesValidation = True
		Me.cmdRightEquipment.Enabled = True
		Me.cmdRightEquipment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRightEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRightEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRightEquipment.TabStop = True
		Me.cmdRightEquipment.Name = "cmdRightEquipment"
		Me.cmdAllRightEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllRightEquipment.Text = ">>"
		Me.cmdAllRightEquipment.Size = New System.Drawing.Size(41, 33)
		Me.cmdAllRightEquipment.Location = New System.Drawing.Point(208, 216)
		Me.cmdAllRightEquipment.TabIndex = 21
		Me.cmdAllRightEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllRightEquipment.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllRightEquipment.CausesValidation = True
		Me.cmdAllRightEquipment.Enabled = True
		Me.cmdAllRightEquipment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllRightEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllRightEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllRightEquipment.TabStop = True
		Me.cmdAllRightEquipment.Name = "cmdAllRightEquipment"
		dgSelEquipment.OcxState = CType(resources.GetObject("dgSelEquipment.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelEquipment.Size = New System.Drawing.Size(169, 265)
		Me.dgSelEquipment.Location = New System.Drawing.Point(272, 192)
		Me.dgSelEquipment.TabIndex = 16
		Me.dgSelEquipment.Name = "dgSelEquipment"
		Me._lbTitle_2.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_2.Text = " Step 3. Equipment Types>>"
		Me._lbTitle_2.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_2.ForeColor = System.Drawing.Color.FromARGB(64, 64, 0)
		Me._lbTitle_2.Size = New System.Drawing.Size(329, 17)
		Me._lbTitle_2.Location = New System.Drawing.Point(8, 16)
		Me._lbTitle_2.TabIndex = 31
		Me._lbTitle_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_2.Enabled = True
		Me._lbTitle_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_2.UseMnemonic = True
		Me._lbTitle_2.Visible = True
		Me._lbTitle_2.AutoSize = False
		Me._lbTitle_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_2.Name = "_lbTitle_2"
		Me.Label12.Text = "Select Equipment Types"
		Me.Label12.Size = New System.Drawing.Size(145, 17)
		Me.Label12.Location = New System.Drawing.Point(24, 40)
		Me.Label12.TabIndex = 14
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
		Me._frCriteria_0.Text = "General"
		Me._frCriteria_0.Size = New System.Drawing.Size(449, 497)
		Me._frCriteria_0.Location = New System.Drawing.Point(0, 0)
		Me._frCriteria_0.TabIndex = 3
		Me._frCriteria_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_0.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_0.Enabled = True
		Me._frCriteria_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._frCriteria_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_0.Visible = True
		Me._frCriteria_0.Name = "_frCriteria_0"
		Me.cbInvoiceEqpt.Text = "Just Invoices with Equipment"
		Me.cbInvoiceEqpt.Size = New System.Drawing.Size(257, 17)
		Me.cbInvoiceEqpt.Location = New System.Drawing.Point(48, 328)
		Me.cbInvoiceEqpt.TabIndex = 100
		Me.cbInvoiceEqpt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbInvoiceEqpt.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cbInvoiceEqpt.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cbInvoiceEqpt.BackColor = System.Drawing.SystemColors.Control
		Me.cbInvoiceEqpt.CausesValidation = True
		Me.cbInvoiceEqpt.Enabled = True
		Me.cbInvoiceEqpt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cbInvoiceEqpt.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbInvoiceEqpt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbInvoiceEqpt.Appearance = System.Windows.Forms.Appearance.Normal
		Me.cbInvoiceEqpt.TabStop = True
		Me.cbInvoiceEqpt.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cbInvoiceEqpt.Visible = True
		Me.cbInvoiceEqpt.Name = "cbInvoiceEqpt"
		Me.cbWithoutEqpt.Text = "Include service charges without contract"
		Me.cbWithoutEqpt.Size = New System.Drawing.Size(337, 17)
		Me.cbWithoutEqpt.Location = New System.Drawing.Point(24, 304)
		Me.cbWithoutEqpt.TabIndex = 98
		Me.cbWithoutEqpt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbWithoutEqpt.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cbWithoutEqpt.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cbWithoutEqpt.BackColor = System.Drawing.SystemColors.Control
		Me.cbWithoutEqpt.CausesValidation = True
		Me.cbWithoutEqpt.Enabled = True
		Me.cbWithoutEqpt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cbWithoutEqpt.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbWithoutEqpt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbWithoutEqpt.Appearance = System.Windows.Forms.Appearance.Normal
		Me.cbWithoutEqpt.TabStop = True
		Me.cbWithoutEqpt.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cbWithoutEqpt.Visible = True
		Me.cbWithoutEqpt.Name = "cbWithoutEqpt"
		Me.cbReportTemplate.Size = New System.Drawing.Size(145, 21)
		Me.cbReportTemplate.Location = New System.Drawing.Point(80, 181)
		Me.cbReportTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbReportTemplate.TabIndex = 68
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
		Me.txtReportTitle.AutoSize = False
		Me.txtReportTitle.Size = New System.Drawing.Size(249, 21)
		Me.txtReportTitle.Location = New System.Drawing.Point(80, 248)
		Me.txtReportTitle.TabIndex = 65
		Me.txtReportTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReportTitle.AcceptsReturn = True
		Me.txtReportTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReportTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtReportTitle.CausesValidation = True
		Me.txtReportTitle.Enabled = True
		Me.txtReportTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReportTitle.HideSelection = True
		Me.txtReportTitle.ReadOnly = False
		Me.txtReportTitle.Maxlength = 0
		Me.txtReportTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReportTitle.MultiLine = False
		Me.txtReportTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReportTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReportTitle.TabStop = True
		Me.txtReportTitle.Visible = True
		Me.txtReportTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReportTitle.Name = "txtReportTitle"
		Me.cbCustId.Size = New System.Drawing.Size(65, 21)
		Me.cbCustId.Location = New System.Drawing.Point(264, 80)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 12
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
		Me.txtReportCaption.AutoSize = False
		Me.txtReportCaption.Size = New System.Drawing.Size(249, 21)
		Me.txtReportCaption.Location = New System.Drawing.Point(80, 214)
		Me.txtReportCaption.TabIndex = 8
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
		Me.cbCustName.Size = New System.Drawing.Size(161, 21)
		Me.cbCustName.Location = New System.Drawing.Point(80, 80)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 7
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
		Me.cbGroupName.Size = New System.Drawing.Size(137, 21)
		Me.cbGroupName.Location = New System.Drawing.Point(80, 147)
		Me.cbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbGroupName.TabIndex = 6
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
		Me.cbStateId.Location = New System.Drawing.Point(80, 114)
		Me.cbStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStateId.TabIndex = 5
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
		Me.Label19.Text = "Template"
		Me.Label19.Size = New System.Drawing.Size(49, 17)
		Me.Label19.Location = New System.Drawing.Point(16, 184)
		Me.Label19.TabIndex = 67
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
		Me.Label18.Text = "Report Title"
		Me.Label18.Size = New System.Drawing.Size(57, 33)
		Me.Label18.Location = New System.Drawing.Point(16, 248)
		Me.Label18.TabIndex = 64
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
		Me._lbTitle_0.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_0.Text = " Step 1. General >>"
		Me._lbTitle_0.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_0.ForeColor = System.Drawing.Color.FromARGB(64, 64, 0)
		Me._lbTitle_0.Size = New System.Drawing.Size(409, 17)
		Me._lbTitle_0.Location = New System.Drawing.Point(8, 24)
		Me._lbTitle_0.TabIndex = 30
		Me._lbTitle_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_0.Enabled = True
		Me._lbTitle_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_0.UseMnemonic = True
		Me._lbTitle_0.Visible = True
		Me._lbTitle_0.AutoSize = False
		Me._lbTitle_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_0.Name = "_lbTitle_0"
		Me.Label8.Text = "Customer Caption"
		Me.Label8.Size = New System.Drawing.Size(49, 33)
		Me.Label8.Location = New System.Drawing.Point(16, 208)
		Me.Label8.TabIndex = 11
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
		Me.label3.Text = "Store Group"
		Me.label3.Size = New System.Drawing.Size(57, 17)
		Me.label3.Location = New System.Drawing.Point(16, 152)
		Me.label3.TabIndex = 10
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
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 112)
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
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 80)
		Me.Label1.TabIndex = 4
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
		Me.cmdFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFinish.Text = "Finish"
		Me.cmdFinish.Size = New System.Drawing.Size(73, 33)
		Me.cmdFinish.Location = New System.Drawing.Point(376, 536)
		Me.cmdFinish.TabIndex = 2
		Me.cmdFinish.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFinish.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFinish.CausesValidation = True
		Me.cmdFinish.Enabled = True
		Me.cmdFinish.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFinish.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFinish.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFinish.TabStop = True
		Me.cmdFinish.Name = "cmdFinish"
		Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNext.Text = "Next >>"
		Me.cmdNext.Size = New System.Drawing.Size(73, 33)
		Me.cmdNext.Location = New System.Drawing.Point(288, 536)
		Me.cmdNext.TabIndex = 1
		Me.cmdNext.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNext.CausesValidation = True
		Me.cmdNext.Enabled = True
		Me.cmdNext.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNext.TabStop = True
		Me.cmdNext.Name = "cmdNext"
		Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrev.Text = "<< Previous"
		Me.cmdPrev.Size = New System.Drawing.Size(73, 33)
		Me.cmdPrev.Location = New System.Drawing.Point(200, 536)
		Me.cmdPrev.TabIndex = 0
		Me.cmdPrev.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrev.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrev.CausesValidation = True
		Me.cmdPrev.Enabled = True
		Me.cmdPrev.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrev.TabStop = True
		Me.cmdPrev.Name = "cmdPrev"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(73, 33)
		Me.cmdClose.Location = New System.Drawing.Point(112, 536)
		Me.cmdClose.TabIndex = 54
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.sb.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sb.Size = New System.Drawing.Size(675, 25)
		Me.sb.Location = New System.Drawing.Point(0, 574)
		Me.sb.TabIndex = 99
		Me.sb.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sb.Name = "sb"
		Me._sb_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._sb_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._sb_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._sb_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._sb_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._sb_Panel1.Size = New System.Drawing.Size(96, 25)
		Me._sb_Panel1.AutoSize = False
		Me._frCriteria_1.Text = "Period"
		Me._frCriteria_1.Size = New System.Drawing.Size(441, 497)
		Me._frCriteria_1.Location = New System.Drawing.Point(40, 24)
		Me._frCriteria_1.TabIndex = 69
		Me._frCriteria_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_1.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_1.Enabled = True
		Me._frCriteria_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._frCriteria_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_1.Visible = True
		Me._frCriteria_1.Name = "_frCriteria_1"
		Me.Frame1.Text = "Period/Date Range"
		Me.Frame1.Size = New System.Drawing.Size(417, 345)
		Me.Frame1.Location = New System.Drawing.Point(16, 72)
		Me.Frame1.TabIndex = 70
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbPeriodName.Size = New System.Drawing.Size(177, 21)
		Me.cbPeriodName.Location = New System.Drawing.Point(128, 32)
		Me.cbPeriodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodName.TabIndex = 82
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
		Me.obSinglePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obSinglePeriod.Text = "Single Period"
		Me.obSinglePeriod.Size = New System.Drawing.Size(105, 17)
		Me.obSinglePeriod.Location = New System.Drawing.Point(16, 32)
		Me.obSinglePeriod.TabIndex = 81
		Me.obSinglePeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obSinglePeriod.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obSinglePeriod.BackColor = System.Drawing.SystemColors.Control
		Me.obSinglePeriod.CausesValidation = True
		Me.obSinglePeriod.Enabled = True
		Me.obSinglePeriod.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obSinglePeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.obSinglePeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obSinglePeriod.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obSinglePeriod.TabStop = True
		Me.obSinglePeriod.Checked = False
		Me.obSinglePeriod.Visible = True
		Me.obSinglePeriod.Name = "obSinglePeriod"
		Me.obRangePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obRangePeriod.Text = "Period Range - Accumulated"
		Me.obRangePeriod.Size = New System.Drawing.Size(289, 17)
		Me.obRangePeriod.Location = New System.Drawing.Point(16, 128)
		Me.obRangePeriod.TabIndex = 80
		Me.obRangePeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obRangePeriod.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obRangePeriod.BackColor = System.Drawing.SystemColors.Control
		Me.obRangePeriod.CausesValidation = True
		Me.obRangePeriod.Enabled = True
		Me.obRangePeriod.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obRangePeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.obRangePeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obRangePeriod.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obRangePeriod.TabStop = True
		Me.obRangePeriod.Checked = False
		Me.obRangePeriod.Visible = True
		Me.obRangePeriod.Name = "obRangePeriod"
		Me.cbPeriodStart.Size = New System.Drawing.Size(129, 21)
		Me.cbPeriodStart.Location = New System.Drawing.Point(88, 152)
		Me.cbPeriodStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodStart.TabIndex = 79
		Me.cbPeriodStart.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPeriodStart.BackColor = System.Drawing.SystemColors.Window
		Me.cbPeriodStart.CausesValidation = True
		Me.cbPeriodStart.Enabled = True
		Me.cbPeriodStart.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbPeriodStart.IntegralHeight = True
		Me.cbPeriodStart.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbPeriodStart.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbPeriodStart.Sorted = False
		Me.cbPeriodStart.TabStop = True
		Me.cbPeriodStart.Visible = True
		Me.cbPeriodStart.Name = "cbPeriodStart"
		Me.cbPeriodEnd.Size = New System.Drawing.Size(129, 21)
		Me.cbPeriodEnd.Location = New System.Drawing.Point(280, 152)
		Me.cbPeriodEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodEnd.TabIndex = 78
		Me.cbPeriodEnd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPeriodEnd.BackColor = System.Drawing.SystemColors.Window
		Me.cbPeriodEnd.CausesValidation = True
		Me.cbPeriodEnd.Enabled = True
		Me.cbPeriodEnd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbPeriodEnd.IntegralHeight = True
		Me.cbPeriodEnd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbPeriodEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbPeriodEnd.Sorted = False
		Me.cbPeriodEnd.TabStop = True
		Me.cbPeriodEnd.Visible = True
		Me.cbPeriodEnd.Name = "cbPeriodEnd"
		Me.obRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obRange.Text = "Invoices in Date Range"
		Me.obRange.Size = New System.Drawing.Size(161, 17)
		Me.obRange.Location = New System.Drawing.Point(16, 264)
		Me.obRange.TabIndex = 77
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
		Me.Frame3.Size = New System.Drawing.Size(297, 41)
		Me.Frame3.Location = New System.Drawing.Point(48, 80)
		Me.Frame3.TabIndex = 74
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		Me.obPeriodNameSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodNameSingle.Text = "Show Period Name"
		Me.obPeriodNameSingle.Size = New System.Drawing.Size(121, 13)
		Me.obPeriodNameSingle.Location = New System.Drawing.Point(8, 16)
		Me.obPeriodNameSingle.TabIndex = 76
		Me.obPeriodNameSingle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obPeriodNameSingle.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodNameSingle.BackColor = System.Drawing.SystemColors.Control
		Me.obPeriodNameSingle.CausesValidation = True
		Me.obPeriodNameSingle.Enabled = True
		Me.obPeriodNameSingle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obPeriodNameSingle.Cursor = System.Windows.Forms.Cursors.Default
		Me.obPeriodNameSingle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obPeriodNameSingle.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obPeriodNameSingle.TabStop = True
		Me.obPeriodNameSingle.Checked = False
		Me.obPeriodNameSingle.Visible = True
		Me.obPeriodNameSingle.Name = "obPeriodNameSingle"
		Me.obPeriodDateSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodDateSingle.Text = "Show Dates"
		Me.obPeriodDateSingle.Size = New System.Drawing.Size(89, 17)
		Me.obPeriodDateSingle.Location = New System.Drawing.Point(200, 16)
		Me.obPeriodDateSingle.TabIndex = 75
		Me.obPeriodDateSingle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obPeriodDateSingle.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodDateSingle.BackColor = System.Drawing.SystemColors.Control
		Me.obPeriodDateSingle.CausesValidation = True
		Me.obPeriodDateSingle.Enabled = True
		Me.obPeriodDateSingle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obPeriodDateSingle.Cursor = System.Windows.Forms.Cursors.Default
		Me.obPeriodDateSingle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obPeriodDateSingle.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obPeriodDateSingle.TabStop = True
		Me.obPeriodDateSingle.Checked = False
		Me.obPeriodDateSingle.Visible = True
		Me.obPeriodDateSingle.Name = "obPeriodDateSingle"
		Me.Frame4.Size = New System.Drawing.Size(297, 41)
		Me.Frame4.Location = New System.Drawing.Point(48, 208)
		Me.Frame4.TabIndex = 71
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Name = "Frame4"
		Me.obPeriodDateRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodDateRange.Text = "Show Dates"
		Me.obPeriodDateRange.Size = New System.Drawing.Size(89, 17)
		Me.obPeriodDateRange.Location = New System.Drawing.Point(200, 16)
		Me.obPeriodDateRange.TabIndex = 73
		Me.obPeriodDateRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obPeriodDateRange.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodDateRange.BackColor = System.Drawing.SystemColors.Control
		Me.obPeriodDateRange.CausesValidation = True
		Me.obPeriodDateRange.Enabled = True
		Me.obPeriodDateRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obPeriodDateRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.obPeriodDateRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obPeriodDateRange.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obPeriodDateRange.TabStop = True
		Me.obPeriodDateRange.Checked = False
		Me.obPeriodDateRange.Visible = True
		Me.obPeriodDateRange.Name = "obPeriodDateRange"
		Me.obPeriodNameRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodNameRange.Text = "Show Period Name"
		Me.obPeriodNameRange.Size = New System.Drawing.Size(121, 13)
		Me.obPeriodNameRange.Location = New System.Drawing.Point(16, 16)
		Me.obPeriodNameRange.TabIndex = 72
		Me.obPeriodNameRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obPeriodNameRange.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obPeriodNameRange.BackColor = System.Drawing.SystemColors.Control
		Me.obPeriodNameRange.CausesValidation = True
		Me.obPeriodNameRange.Enabled = True
		Me.obPeriodNameRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obPeriodNameRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.obPeriodNameRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obPeriodNameRange.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obPeriodNameRange.TabStop = True
		Me.obPeriodNameRange.Checked = False
		Me.obPeriodNameRange.Visible = True
		Me.obPeriodNameRange.Name = "obPeriodNameRange"
		dtEndDate.OcxState = CType(resources.GetObject("dtEndDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtEndDate.Size = New System.Drawing.Size(89, 21)
		Me.dtEndDate.Location = New System.Drawing.Point(104, 312)
		Me.dtEndDate.TabIndex = 83
		Me.dtEndDate.Name = "dtEndDate"
		dtStartDate.OcxState = CType(resources.GetObject("dtStartDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtStartDate.Size = New System.Drawing.Size(89, 21)
		Me.dtStartDate.Location = New System.Drawing.Point(104, 288)
		Me.dtStartDate.TabIndex = 84
		Me.dtStartDate.Name = "dtStartDate"
		Me.lbPeriodEndDate.Text = "End"
		Me.lbPeriodEndDate.Size = New System.Drawing.Size(81, 17)
		Me.lbPeriodEndDate.Location = New System.Drawing.Point(216, 192)
		Me.lbPeriodEndDate.TabIndex = 96
		Me.lbPeriodEndDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbPeriodEndDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbPeriodEndDate.BackColor = System.Drawing.SystemColors.Control
		Me.lbPeriodEndDate.Enabled = True
		Me.lbPeriodEndDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbPeriodEndDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbPeriodEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbPeriodEndDate.UseMnemonic = True
		Me.lbPeriodEndDate.Visible = True
		Me.lbPeriodEndDate.AutoSize = False
		Me.lbPeriodEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbPeriodEndDate.Name = "lbPeriodEndDate"
		Me.Label13.Text = "To"
		Me.Label13.Size = New System.Drawing.Size(25, 17)
		Me.Label13.Location = New System.Drawing.Point(184, 192)
		Me.Label13.TabIndex = 95
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
		Me.lbPeriodStartDate.Text = "Start"
		Me.lbPeriodStartDate.Size = New System.Drawing.Size(73, 17)
		Me.lbPeriodStartDate.Location = New System.Drawing.Point(96, 192)
		Me.lbPeriodStartDate.TabIndex = 94
		Me.lbPeriodStartDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbPeriodStartDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbPeriodStartDate.BackColor = System.Drawing.SystemColors.Control
		Me.lbPeriodStartDate.Enabled = True
		Me.lbPeriodStartDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbPeriodStartDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbPeriodStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbPeriodStartDate.UseMnemonic = True
		Me.lbPeriodStartDate.Visible = True
		Me.lbPeriodStartDate.AutoSize = False
		Me.lbPeriodStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbPeriodStartDate.Name = "lbPeriodStartDate"
		Me.Label11.Text = "From"
		Me.Label11.Size = New System.Drawing.Size(33, 17)
		Me.Label11.Location = New System.Drawing.Point(48, 192)
		Me.Label11.TabIndex = 93
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
		Me.lbEndDate.Text = "End"
		Me.lbEndDate.Size = New System.Drawing.Size(113, 17)
		Me.lbEndDate.Location = New System.Drawing.Point(216, 64)
		Me.lbEndDate.TabIndex = 92
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
		Me.lbStartDate.Location = New System.Drawing.Point(88, 64)
		Me.lbStartDate.TabIndex = 91
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
		Me.Label7.Location = New System.Drawing.Point(184, 64)
		Me.Label7.TabIndex = 90
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
		Me.Label6.Location = New System.Drawing.Point(48, 64)
		Me.Label6.TabIndex = 89
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
		Me.Label9.Text = "From Period"
		Me.Label9.Size = New System.Drawing.Size(41, 25)
		Me.Label9.Location = New System.Drawing.Point(48, 152)
		Me.Label9.TabIndex = 88
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
		Me.Label10.Text = "To Period"
		Me.Label10.Size = New System.Drawing.Size(33, 25)
		Me.Label10.Location = New System.Drawing.Point(240, 152)
		Me.Label10.TabIndex = 87
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
		Me.Label4.Text = "Start Date"
		Me.Label4.Size = New System.Drawing.Size(49, 21)
		Me.Label4.Location = New System.Drawing.Point(48, 288)
		Me.Label4.TabIndex = 86
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
		Me.Label5.Text = "End Date"
		Me.Label5.Size = New System.Drawing.Size(49, 21)
		Me.Label5.Location = New System.Drawing.Point(48, 312)
		Me.Label5.TabIndex = 85
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
		Me._lbTitle_1.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_1.Text = " Step 2. Periods and Dates>>"
		Me._lbTitle_1.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_1.ForeColor = System.Drawing.Color.FromARGB(64, 64, 0)
		Me._lbTitle_1.Size = New System.Drawing.Size(409, 17)
		Me._lbTitle_1.Location = New System.Drawing.Point(8, 24)
		Me._lbTitle_1.TabIndex = 97
		Me._lbTitle_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_1.Enabled = True
		Me._lbTitle_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_1.UseMnemonic = True
		Me._lbTitle_1.Visible = True
		Me._lbTitle_1.AutoSize = False
		Me._lbTitle_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_1.Name = "_lbTitle_1"
		Me._frCriteria_6.Text = "Vendor"
		Me._frCriteria_6.Size = New System.Drawing.Size(465, 457)
		Me._frCriteria_6.Location = New System.Drawing.Point(208, 176)
		Me._frCriteria_6.TabIndex = 55
		Me._frCriteria_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_6.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_6.Enabled = True
		Me._frCriteria_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._frCriteria_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_6.Visible = True
		Me._frCriteria_6.Name = "_frCriteria_6"
		dgDebug.OcxState = CType(resources.GetObject("dgDebug.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgDebug.Size = New System.Drawing.Size(409, 121)
		Me.dgDebug.Location = New System.Drawing.Point(24, 328)
		Me.dgDebug.TabIndex = 66
		Me.dgDebug.Visible = False
		Me.dgDebug.Name = "dgDebug"
		Me.cmdAllLeftVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllLeftVendor.Text = "<<"
		Me.cmdAllLeftVendor.Size = New System.Drawing.Size(49, 33)
		Me.cmdAllLeftVendor.Location = New System.Drawing.Point(208, 288)
		Me.cmdAllLeftVendor.TabIndex = 63
		Me.cmdAllLeftVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllLeftVendor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllLeftVendor.CausesValidation = True
		Me.cmdAllLeftVendor.Enabled = True
		Me.cmdAllLeftVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllLeftVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllLeftVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllLeftVendor.TabStop = True
		Me.cmdAllLeftVendor.Name = "cmdAllLeftVendor"
		Me.cmdLeftVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeftVendor.Text = "<"
		Me.cmdLeftVendor.Size = New System.Drawing.Size(49, 33)
		Me.cmdLeftVendor.Location = New System.Drawing.Point(208, 232)
		Me.cmdLeftVendor.TabIndex = 62
		Me.cmdLeftVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeftVendor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeftVendor.CausesValidation = True
		Me.cmdLeftVendor.Enabled = True
		Me.cmdLeftVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeftVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeftVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeftVendor.TabStop = True
		Me.cmdLeftVendor.Name = "cmdLeftVendor"
		Me.cmdRightVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRightVendor.Text = ">"
		Me.cmdRightVendor.Size = New System.Drawing.Size(49, 33)
		Me.cmdRightVendor.Location = New System.Drawing.Point(208, 176)
		Me.cmdRightVendor.TabIndex = 61
		Me.cmdRightVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRightVendor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRightVendor.CausesValidation = True
		Me.cmdRightVendor.Enabled = True
		Me.cmdRightVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRightVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRightVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRightVendor.TabStop = True
		Me.cmdRightVendor.Name = "cmdRightVendor"
		Me.cmdAllRightVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllRightVendor.Text = ">>"
		Me.cmdAllRightVendor.Size = New System.Drawing.Size(49, 33)
		Me.cmdAllRightVendor.Location = New System.Drawing.Point(208, 120)
		Me.cmdAllRightVendor.TabIndex = 60
		Me.cmdAllRightVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllRightVendor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllRightVendor.CausesValidation = True
		Me.cmdAllRightVendor.Enabled = True
		Me.cmdAllRightVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllRightVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllRightVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllRightVendor.TabStop = True
		Me.cmdAllRightVendor.Name = "cmdAllRightVendor"
		dgVendor.OcxState = CType(resources.GetObject("dgVendor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgVendor.Size = New System.Drawing.Size(169, 201)
		Me.dgVendor.Location = New System.Drawing.Point(16, 120)
		Me.dgVendor.TabIndex = 58
		Me.dgVendor.Name = "dgVendor"
		dgSelVendor.OcxState = CType(resources.GetObject("dgSelVendor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelVendor.Size = New System.Drawing.Size(169, 201)
		Me.dgSelVendor.Location = New System.Drawing.Point(280, 120)
		Me.dgSelVendor.TabIndex = 59
		Me.dgSelVendor.Name = "dgSelVendor"
		Me.Label17.Text = "Select Vendors"
		Me.Label17.Size = New System.Drawing.Size(137, 25)
		Me.Label17.Location = New System.Drawing.Point(32, 72)
		Me.Label17.TabIndex = 57
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
		Me._lbTitle_6.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_6.Text = "Step 7. Vendors"
		Me._lbTitle_6.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_6.ForeColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me._lbTitle_6.Size = New System.Drawing.Size(417, 25)
		Me._lbTitle_6.Location = New System.Drawing.Point(16, 24)
		Me._lbTitle_6.TabIndex = 56
		Me._lbTitle_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_6.Enabled = True
		Me._lbTitle_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_6.UseMnemonic = True
		Me._lbTitle_6.Visible = True
		Me._lbTitle_6.AutoSize = False
		Me._lbTitle_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_6.Name = "_lbTitle_6"
		Me._frCriteria_5.Text = "Service"
		Me._frCriteria_5.Size = New System.Drawing.Size(465, 489)
		Me._frCriteria_5.Location = New System.Drawing.Point(128, 152)
		Me._frCriteria_5.TabIndex = 45
		Me._frCriteria_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_5.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_5.Enabled = True
		Me._frCriteria_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._frCriteria_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_5.Visible = True
		Me._frCriteria_5.Name = "_frCriteria_5"
		Me.cmdAllLeftServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllLeftServ.Text = "<<"
		Me.cmdAllLeftServ.Size = New System.Drawing.Size(41, 33)
		Me.cmdAllLeftServ.Location = New System.Drawing.Point(208, 320)
		Me.cmdAllLeftServ.TabIndex = 53
		Me.cmdAllLeftServ.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllLeftServ.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllLeftServ.CausesValidation = True
		Me.cmdAllLeftServ.Enabled = True
		Me.cmdAllLeftServ.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllLeftServ.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllLeftServ.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllLeftServ.TabStop = True
		Me.cmdAllLeftServ.Name = "cmdAllLeftServ"
		Me.cmdLeftServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeftServ.Text = "<"
		Me.cmdLeftServ.Size = New System.Drawing.Size(41, 33)
		Me.cmdLeftServ.Location = New System.Drawing.Point(208, 264)
		Me.cmdLeftServ.TabIndex = 52
		Me.cmdLeftServ.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeftServ.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeftServ.CausesValidation = True
		Me.cmdLeftServ.Enabled = True
		Me.cmdLeftServ.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeftServ.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeftServ.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeftServ.TabStop = True
		Me.cmdLeftServ.Name = "cmdLeftServ"
		Me.cmdRightServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRightServ.Text = ">"
		Me.cmdRightServ.Size = New System.Drawing.Size(41, 33)
		Me.cmdRightServ.Location = New System.Drawing.Point(208, 208)
		Me.cmdRightServ.TabIndex = 51
		Me.cmdRightServ.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRightServ.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRightServ.CausesValidation = True
		Me.cmdRightServ.Enabled = True
		Me.cmdRightServ.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRightServ.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRightServ.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRightServ.TabStop = True
		Me.cmdRightServ.Name = "cmdRightServ"
		Me.cmdAllRightServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllRightServ.Text = ">>"
		Me.cmdAllRightServ.Size = New System.Drawing.Size(41, 33)
		Me.cmdAllRightServ.Location = New System.Drawing.Point(208, 160)
		Me.cmdAllRightServ.TabIndex = 50
		Me.cmdAllRightServ.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllRightServ.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllRightServ.CausesValidation = True
		Me.cmdAllRightServ.Enabled = True
		Me.cmdAllRightServ.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllRightServ.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllRightServ.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllRightServ.TabStop = True
		Me.cmdAllRightServ.Name = "cmdAllRightServ"
		dgSelService.OcxState = CType(resources.GetObject("dgSelService.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelService.Size = New System.Drawing.Size(177, 265)
		Me.dgSelService.Location = New System.Drawing.Point(272, 120)
		Me.dgSelService.TabIndex = 49
		Me.dgSelService.Name = "dgSelService"
		dgService.OcxState = CType(resources.GetObject("dgService.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgService.Size = New System.Drawing.Size(177, 265)
		Me.dgService.Location = New System.Drawing.Point(8, 120)
		Me.dgService.TabIndex = 48
		Me.dgService.Name = "dgService"
		Me.Label16.Text = "Select service charges:"
		Me.Label16.Size = New System.Drawing.Size(137, 25)
		Me.Label16.Location = New System.Drawing.Point(48, 48)
		Me.Label16.TabIndex = 47
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
		Me._lbTitle_5.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_5.Text = "Step 6. Services >>"
		Me._lbTitle_5.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_5.Size = New System.Drawing.Size(201, 24)
		Me._lbTitle_5.Location = New System.Drawing.Point(8, 16)
		Me._lbTitle_5.TabIndex = 46
		Me._lbTitle_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_5.Enabled = True
		Me._lbTitle_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbTitle_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_5.UseMnemonic = True
		Me._lbTitle_5.Visible = True
		Me._lbTitle_5.AutoSize = False
		Me._lbTitle_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_5.Name = "_lbTitle_5"
		Me._frCriteria_4.Text = "Load"
		Me._frCriteria_4.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frCriteria_4.Size = New System.Drawing.Size(465, 457)
		Me._frCriteria_4.Location = New System.Drawing.Point(96, 120)
		Me._frCriteria_4.TabIndex = 25
		Me._frCriteria_4.BackColor = System.Drawing.SystemColors.Control
		Me._frCriteria_4.Enabled = True
		Me._frCriteria_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._frCriteria_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frCriteria_4.Visible = True
		Me._frCriteria_4.Name = "_frCriteria_4"
		Me.cmdAllLeftLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllLeftLoad.Text = "<<"
		Me.cmdAllLeftLoad.Size = New System.Drawing.Size(49, 33)
		Me.cmdAllLeftLoad.Location = New System.Drawing.Point(208, 288)
		Me.cmdAllLeftLoad.TabIndex = 43
		Me.cmdAllLeftLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllLeftLoad.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllLeftLoad.CausesValidation = True
		Me.cmdAllLeftLoad.Enabled = True
		Me.cmdAllLeftLoad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllLeftLoad.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllLeftLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllLeftLoad.TabStop = True
		Me.cmdAllLeftLoad.Name = "cmdAllLeftLoad"
		Me.cmdLeftLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeftLoad.Text = "<"
		Me.cmdLeftLoad.Size = New System.Drawing.Size(49, 33)
		Me.cmdLeftLoad.Location = New System.Drawing.Point(208, 232)
		Me.cmdLeftLoad.TabIndex = 42
		Me.cmdLeftLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeftLoad.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeftLoad.CausesValidation = True
		Me.cmdLeftLoad.Enabled = True
		Me.cmdLeftLoad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeftLoad.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeftLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeftLoad.TabStop = True
		Me.cmdLeftLoad.Name = "cmdLeftLoad"
		Me.cmdRightLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRightLoad.Text = ">"
		Me.cmdRightLoad.Size = New System.Drawing.Size(49, 33)
		Me.cmdRightLoad.Location = New System.Drawing.Point(208, 176)
		Me.cmdRightLoad.TabIndex = 41
		Me.cmdRightLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRightLoad.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRightLoad.CausesValidation = True
		Me.cmdRightLoad.Enabled = True
		Me.cmdRightLoad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRightLoad.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRightLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRightLoad.TabStop = True
		Me.cmdRightLoad.Name = "cmdRightLoad"
		Me.cmdAllRightLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAllRightLoad.Text = ">>"
		Me.cmdAllRightLoad.Size = New System.Drawing.Size(49, 33)
		Me.cmdAllRightLoad.Location = New System.Drawing.Point(208, 120)
		Me.cmdAllRightLoad.TabIndex = 40
		Me.cmdAllRightLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAllRightLoad.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAllRightLoad.CausesValidation = True
		Me.cmdAllRightLoad.Enabled = True
		Me.cmdAllRightLoad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAllRightLoad.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAllRightLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAllRightLoad.TabStop = True
		Me.cmdAllRightLoad.Name = "cmdAllRightLoad"
		dgLoad.OcxState = CType(resources.GetObject("dgLoad.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgLoad.Size = New System.Drawing.Size(169, 201)
		Me.dgLoad.Location = New System.Drawing.Point(16, 120)
		Me.dgLoad.TabIndex = 38
		Me.dgLoad.Name = "dgLoad"
		dgSelLoad.OcxState = CType(resources.GetObject("dgSelLoad.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelLoad.Size = New System.Drawing.Size(169, 201)
		Me.dgSelLoad.Location = New System.Drawing.Point(280, 120)
		Me.dgSelLoad.TabIndex = 39
		Me.dgSelLoad.Name = "dgSelLoad"
		Me.Label15.Text = "Select Load Type"
		Me.Label15.Size = New System.Drawing.Size(201, 17)
		Me.Label15.Location = New System.Drawing.Point(32, 64)
		Me.Label15.TabIndex = 44
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
		Me._lbTitle_4.BackColor = System.Drawing.Color.Yellow
		Me._lbTitle_4.Text = "  Step 5. Load Types>>"
		Me._lbTitle_4.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbTitle_4.ForeColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me._lbTitle_4.Size = New System.Drawing.Size(217, 17)
		Me._lbTitle_4.Location = New System.Drawing.Point(8, 24)
		Me._lbTitle_4.TabIndex = 33
		Me._lbTitle_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTitle_4.Enabled = True
		Me._lbTitle_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTitle_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTitle_4.UseMnemonic = True
		Me._lbTitle_4.Visible = True
		Me._lbTitle_4.AutoSize = False
		Me._lbTitle_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTitle_4.Name = "_lbTitle_4"
		Me.Controls.Add(_frCriteria_3)
		Me.Controls.Add(_frCriteria_2)
		Me.Controls.Add(_frCriteria_0)
		Me.Controls.Add(cmdFinish)
		Me.Controls.Add(cmdNext)
		Me.Controls.Add(cmdPrev)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(sb)
		Me.Controls.Add(_frCriteria_1)
		Me.Controls.Add(_frCriteria_6)
		Me.Controls.Add(_frCriteria_5)
		Me.Controls.Add(_frCriteria_4)
		Me._frCriteria_3.Controls.Add(cmdAllRightContent)
		Me._frCriteria_3.Controls.Add(cmdRightContent)
		Me._frCriteria_3.Controls.Add(cmdLeftContent)
		Me._frCriteria_3.Controls.Add(cmdAllLeftContent)
		Me._frCriteria_3.Controls.Add(dgContent)
		Me._frCriteria_3.Controls.Add(dgSelContent)
		Me._frCriteria_3.Controls.Add(_lbTitle_3)
		Me._frCriteria_3.Controls.Add(Label14)
		Me._frCriteria_2.Controls.Add(Frame2)
		Me._frCriteria_2.Controls.Add(dgEquipment)
		Me._frCriteria_2.Controls.Add(cmdAllLeftEquipment)
		Me._frCriteria_2.Controls.Add(cmdLeftEquipment)
		Me._frCriteria_2.Controls.Add(cmdRightEquipment)
		Me._frCriteria_2.Controls.Add(cmdAllRightEquipment)
		Me._frCriteria_2.Controls.Add(dgSelEquipment)
		Me._frCriteria_2.Controls.Add(_lbTitle_2)
		Me._frCriteria_2.Controls.Add(Label12)
		Me.Frame2.Controls.Add(_obEquipment_2)
		Me.Frame2.Controls.Add(_obEquipment_1)
		Me.Frame2.Controls.Add(_obEquipment_0)
		Me._frCriteria_0.Controls.Add(cbInvoiceEqpt)
		Me._frCriteria_0.Controls.Add(cbWithoutEqpt)
		Me._frCriteria_0.Controls.Add(cbReportTemplate)
		Me._frCriteria_0.Controls.Add(txtReportTitle)
		Me._frCriteria_0.Controls.Add(cbCustId)
		Me._frCriteria_0.Controls.Add(txtReportCaption)
		Me._frCriteria_0.Controls.Add(cbCustName)
		Me._frCriteria_0.Controls.Add(cbGroupName)
		Me._frCriteria_0.Controls.Add(cbStateId)
		Me._frCriteria_0.Controls.Add(Label19)
		Me._frCriteria_0.Controls.Add(Label18)
		Me._frCriteria_0.Controls.Add(_lbTitle_0)
		Me._frCriteria_0.Controls.Add(Label8)
		Me._frCriteria_0.Controls.Add(label3)
		Me._frCriteria_0.Controls.Add(Label2)
		Me._frCriteria_0.Controls.Add(Label1)
		Me.sb.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._sb_Panel1})
		Me._frCriteria_1.Controls.Add(Frame1)
		Me._frCriteria_1.Controls.Add(_lbTitle_1)
		Me.Frame1.Controls.Add(cbPeriodName)
		Me.Frame1.Controls.Add(obSinglePeriod)
		Me.Frame1.Controls.Add(obRangePeriod)
		Me.Frame1.Controls.Add(cbPeriodStart)
		Me.Frame1.Controls.Add(cbPeriodEnd)
		Me.Frame1.Controls.Add(obRange)
		Me.Frame1.Controls.Add(Frame3)
		Me.Frame1.Controls.Add(Frame4)
		Me.Frame1.Controls.Add(dtEndDate)
		Me.Frame1.Controls.Add(dtStartDate)
		Me.Frame1.Controls.Add(lbPeriodEndDate)
		Me.Frame1.Controls.Add(Label13)
		Me.Frame1.Controls.Add(lbPeriodStartDate)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(lbEndDate)
		Me.Frame1.Controls.Add(lbStartDate)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame3.Controls.Add(obPeriodNameSingle)
		Me.Frame3.Controls.Add(obPeriodDateSingle)
		Me.Frame4.Controls.Add(obPeriodDateRange)
		Me.Frame4.Controls.Add(obPeriodNameRange)
		Me._frCriteria_6.Controls.Add(dgDebug)
		Me._frCriteria_6.Controls.Add(cmdAllLeftVendor)
		Me._frCriteria_6.Controls.Add(cmdLeftVendor)
		Me._frCriteria_6.Controls.Add(cmdRightVendor)
		Me._frCriteria_6.Controls.Add(cmdAllRightVendor)
		Me._frCriteria_6.Controls.Add(dgVendor)
		Me._frCriteria_6.Controls.Add(dgSelVendor)
		Me._frCriteria_6.Controls.Add(Label17)
		Me._frCriteria_6.Controls.Add(_lbTitle_6)
		Me._frCriteria_5.Controls.Add(cmdAllLeftServ)
		Me._frCriteria_5.Controls.Add(cmdLeftServ)
		Me._frCriteria_5.Controls.Add(cmdRightServ)
		Me._frCriteria_5.Controls.Add(cmdAllRightServ)
		Me._frCriteria_5.Controls.Add(dgSelService)
		Me._frCriteria_5.Controls.Add(dgService)
		Me._frCriteria_5.Controls.Add(Label16)
		Me._frCriteria_5.Controls.Add(_lbTitle_5)
		Me._frCriteria_4.Controls.Add(cmdAllLeftLoad)
		Me._frCriteria_4.Controls.Add(cmdLeftLoad)
		Me._frCriteria_4.Controls.Add(cmdRightLoad)
		Me._frCriteria_4.Controls.Add(cmdAllRightLoad)
		Me._frCriteria_4.Controls.Add(dgLoad)
		Me._frCriteria_4.Controls.Add(dgSelLoad)
		Me._frCriteria_4.Controls.Add(Label15)
		Me._frCriteria_4.Controls.Add(_lbTitle_4)
		Me.frCriteria.SetIndex(_frCriteria_3, CType(3, Short))
		Me.frCriteria.SetIndex(_frCriteria_2, CType(2, Short))
		Me.frCriteria.SetIndex(_frCriteria_0, CType(0, Short))
		Me.frCriteria.SetIndex(_frCriteria_1, CType(1, Short))
		Me.frCriteria.SetIndex(_frCriteria_6, CType(6, Short))
		Me.frCriteria.SetIndex(_frCriteria_5, CType(5, Short))
		Me.frCriteria.SetIndex(_frCriteria_4, CType(4, Short))
		Me.lbTitle.SetIndex(_lbTitle_3, CType(3, Short))
		Me.lbTitle.SetIndex(_lbTitle_2, CType(2, Short))
		Me.lbTitle.SetIndex(_lbTitle_0, CType(0, Short))
		Me.lbTitle.SetIndex(_lbTitle_1, CType(1, Short))
		Me.lbTitle.SetIndex(_lbTitle_6, CType(6, Short))
		Me.lbTitle.SetIndex(_lbTitle_5, CType(5, Short))
		Me.lbTitle.SetIndex(_lbTitle_4, CType(4, Short))
		Me.obEquipment.SetIndex(_obEquipment_2, CType(2, Short))
		Me.obEquipment.SetIndex(_obEquipment_1, CType(1, Short))
		Me.obEquipment.SetIndex(_obEquipment_0, CType(0, Short))
		CType(Me.obEquipment, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lbTitle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.frCriteria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSelLoad, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgLoad, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgService, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSelService, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSelVendor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgVendor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgDebug, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtStartDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtEndDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSelEquipment, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgEquipment, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSelContent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgContent, System.ComponentModel.ISupportInitialize).EndInit()
		Me._frCriteria_3.ResumeLayout(False)
		Me._frCriteria_2.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me._frCriteria_0.ResumeLayout(False)
		Me.sb.ResumeLayout(False)
		Me._frCriteria_1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me._frCriteria_6.ResumeLayout(False)
		Me._frCriteria_5.ResumeLayout(False)
		Me._frCriteria_4.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class