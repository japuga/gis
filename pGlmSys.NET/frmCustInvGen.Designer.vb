<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustInvGen
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
	Public WithEvents cmdSelectedValues As System.Windows.Forms.Button
	Public WithEvents ckTotalByStoreGroup As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents VScroll1 As System.Windows.Forms.VScrollBar
	Public WithEvents cbTemplate As System.Windows.Forms.ComboBox
	Public WithEvents cbGroupStore As System.Windows.Forms.ComboBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdDisplayAmounts As System.Windows.Forms.Button
	Public WithEvents cmdBuildDoc As System.Windows.Forms.Button
	Public WithEvents cbPeriod As System.Windows.Forms.ComboBox
	Public WithEvents txtLocation As System.Windows.Forms.TextBox
	Public WithEvents ckLocation As System.Windows.Forms.CheckBox
	Public WithEvents ckGrandTotal As System.Windows.Forms.CheckBox
	Public WithEvents ckTax As System.Windows.Forms.CheckBox
	Public WithEvents ckInvoiceFee As System.Windows.Forms.CheckBox
	Public WithEvents ckStoreFlatFee As System.Windows.Forms.CheckBox
	Public WithEvents ckSavingsPercent As System.Windows.Forms.CheckBox
	Public WithEvents txtGrandTotal As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtTax As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtInvoiceFee As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtStoreFlatFee As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtSavingsPercent As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtSavings As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtInvoiceTotal As System.Windows.Forms.MaskedTextBox
	Public WithEvents txtGreeting As System.Windows.Forms.TextBox
	Public WithEvents txtDescription As System.Windows.Forms.TextBox
	Public WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
	Public WithEvents txtAccountNo As System.Windows.Forms.TextBox
	Public WithEvents txBillingPeriod As System.Windows.Forms.TextBox
	Public WithEvents txtInvoiceDate As System.Windows.Forms.TextBox
	Public WithEvents txtAddress As System.Windows.Forms.TextBox
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents dtInvoiceDate As AxMSComCtl2.AxDTPicker
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustInvGen))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdSelectedValues = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.ckTotalByStoreGroup = New System.Windows.Forms.CheckBox
		Me.VScroll1 = New System.Windows.Forms.VScrollBar
		Me.cbTemplate = New System.Windows.Forms.ComboBox
		Me.cbGroupStore = New System.Windows.Forms.ComboBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdDisplayAmounts = New System.Windows.Forms.Button
		Me.cmdBuildDoc = New System.Windows.Forms.Button
		Me.cbPeriod = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtLocation = New System.Windows.Forms.TextBox
		Me.ckLocation = New System.Windows.Forms.CheckBox
		Me.ckGrandTotal = New System.Windows.Forms.CheckBox
		Me.ckTax = New System.Windows.Forms.CheckBox
		Me.ckInvoiceFee = New System.Windows.Forms.CheckBox
		Me.ckStoreFlatFee = New System.Windows.Forms.CheckBox
		Me.ckSavingsPercent = New System.Windows.Forms.CheckBox
		Me.txtGrandTotal = New System.Windows.Forms.MaskedTextBox
		Me.txtTax = New System.Windows.Forms.MaskedTextBox
		Me.txtInvoiceFee = New System.Windows.Forms.MaskedTextBox
		Me.txtStoreFlatFee = New System.Windows.Forms.MaskedTextBox
		Me.txtSavingsPercent = New System.Windows.Forms.MaskedTextBox
		Me.txtSavings = New System.Windows.Forms.MaskedTextBox
		Me.txtInvoiceTotal = New System.Windows.Forms.MaskedTextBox
		Me.txtGreeting = New System.Windows.Forms.TextBox
		Me.txtDescription = New System.Windows.Forms.TextBox
		Me.txtInvoiceNo = New System.Windows.Forms.TextBox
		Me.txtAccountNo = New System.Windows.Forms.TextBox
		Me.txBillingPeriod = New System.Windows.Forms.TextBox
		Me.txtInvoiceDate = New System.Windows.Forms.TextBox
		Me.txtAddress = New System.Windows.Forms.TextBox
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.dtInvoiceDate = New AxMSComCtl2.AxDTPicker
		Me.Label18 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Customer Invoice Generation"
		Me.ClientSize = New System.Drawing.Size(902, 590)
		Me.Location = New System.Drawing.Point(343, 208)
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
		Me.Name = "frmCustInvGen"
		Me.cmdSelectedValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSelectedValues.Text = "..."
		Me.cmdSelectedValues.Size = New System.Drawing.Size(33, 21)
		Me.cmdSelectedValues.Location = New System.Drawing.Point(312, 168)
		Me.cmdSelectedValues.TabIndex = 53
		Me.cmdSelectedValues.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectedValues.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSelectedValues.CausesValidation = True
		Me.cmdSelectedValues.Enabled = True
		Me.cmdSelectedValues.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSelectedValues.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSelectedValues.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSelectedValues.TabStop = True
		Me.cmdSelectedValues.Name = "cmdSelectedValues"
		Me.Frame2.Text = "Options"
		Me.Frame2.Size = New System.Drawing.Size(313, 129)
		Me.Frame2.Location = New System.Drawing.Point(16, 256)
		Me.Frame2.TabIndex = 51
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.ckTotalByStoreGroup.Text = "Show Total by Store Group"
		Me.ckTotalByStoreGroup.Size = New System.Drawing.Size(217, 17)
		Me.ckTotalByStoreGroup.Location = New System.Drawing.Point(48, 24)
		Me.ckTotalByStoreGroup.TabIndex = 52
		Me.ckTotalByStoreGroup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckTotalByStoreGroup.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckTotalByStoreGroup.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckTotalByStoreGroup.BackColor = System.Drawing.SystemColors.Control
		Me.ckTotalByStoreGroup.CausesValidation = True
		Me.ckTotalByStoreGroup.Enabled = True
		Me.ckTotalByStoreGroup.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckTotalByStoreGroup.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckTotalByStoreGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckTotalByStoreGroup.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckTotalByStoreGroup.TabStop = True
		Me.ckTotalByStoreGroup.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckTotalByStoreGroup.Visible = True
		Me.ckTotalByStoreGroup.Name = "ckTotalByStoreGroup"
		Me.VScroll1.Size = New System.Drawing.Size(25, 465)
		Me.VScroll1.Location = New System.Drawing.Point(864, 0)
		Me.VScroll1.TabIndex = 48
		Me.VScroll1.CausesValidation = True
		Me.VScroll1.Enabled = True
		Me.VScroll1.LargeChange = 1
		Me.VScroll1.Maximum = 32767
		Me.VScroll1.Minimum = 0
		Me.VScroll1.Cursor = System.Windows.Forms.Cursors.Default
		Me.VScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.VScroll1.SmallChange = 1
		Me.VScroll1.TabStop = True
		Me.VScroll1.Value = 0
		Me.VScroll1.Visible = True
		Me.VScroll1.Name = "VScroll1"
		Me.cbTemplate.Size = New System.Drawing.Size(201, 21)
		Me.cbTemplate.Location = New System.Drawing.Point(104, 208)
		Me.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbTemplate.TabIndex = 34
		Me.cbTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbTemplate.BackColor = System.Drawing.SystemColors.Window
		Me.cbTemplate.CausesValidation = True
		Me.cbTemplate.Enabled = True
		Me.cbTemplate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbTemplate.IntegralHeight = True
		Me.cbTemplate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbTemplate.Sorted = False
		Me.cbTemplate.TabStop = True
		Me.cbTemplate.Visible = True
		Me.cbTemplate.Name = "cbTemplate"
		Me.cbGroupStore.Size = New System.Drawing.Size(201, 21)
		Me.cbGroupStore.Location = New System.Drawing.Point(104, 168)
		Me.cbGroupStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbGroupStore.TabIndex = 32
		Me.cbGroupStore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbGroupStore.BackColor = System.Drawing.SystemColors.Window
		Me.cbGroupStore.CausesValidation = True
		Me.cbGroupStore.Enabled = True
		Me.cbGroupStore.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbGroupStore.IntegralHeight = True
		Me.cbGroupStore.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbGroupStore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbGroupStore.Sorted = False
		Me.cbGroupStore.TabStop = True
		Me.cbGroupStore.Visible = True
		Me.cbGroupStore.Name = "cbGroupStore"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(89, 41)
		Me.cmdClose.Location = New System.Drawing.Point(232, 408)
		Me.cmdClose.TabIndex = 30
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.cmdDisplayAmounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDisplayAmounts.Text = "Display Amounts"
		Me.cmdDisplayAmounts.Size = New System.Drawing.Size(89, 41)
		Me.cmdDisplayAmounts.Location = New System.Drawing.Point(32, 408)
		Me.cmdDisplayAmounts.TabIndex = 26
		Me.cmdDisplayAmounts.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDisplayAmounts.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDisplayAmounts.CausesValidation = True
		Me.cmdDisplayAmounts.Enabled = True
		Me.cmdDisplayAmounts.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDisplayAmounts.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDisplayAmounts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDisplayAmounts.TabStop = True
		Me.cmdDisplayAmounts.Name = "cmdDisplayAmounts"
		Me.cmdBuildDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBuildDoc.Text = "Build Document"
		Me.cmdBuildDoc.Size = New System.Drawing.Size(89, 41)
		Me.cmdBuildDoc.Location = New System.Drawing.Point(136, 408)
		Me.cmdBuildDoc.TabIndex = 25
		Me.cmdBuildDoc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBuildDoc.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBuildDoc.CausesValidation = True
		Me.cmdBuildDoc.Enabled = True
		Me.cmdBuildDoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBuildDoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBuildDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBuildDoc.TabStop = True
		Me.cmdBuildDoc.Name = "cmdBuildDoc"
		Me.cbPeriod.Size = New System.Drawing.Size(201, 21)
		Me.cbPeriod.Location = New System.Drawing.Point(104, 128)
		Me.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriod.TabIndex = 8
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
		Me.Frame1.Text = "Invoice Data"
		Me.Frame1.Size = New System.Drawing.Size(497, 601)
		Me.Frame1.Location = New System.Drawing.Point(352, 8)
		Me.Frame1.TabIndex = 5
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtLocation.AutoSize = False
		Me.txtLocation.Size = New System.Drawing.Size(305, 21)
		Me.txtLocation.Location = New System.Drawing.Point(104, 224)
		Me.txtLocation.TabIndex = 50
		Me.txtLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLocation.AcceptsReturn = True
		Me.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLocation.BackColor = System.Drawing.SystemColors.Window
		Me.txtLocation.CausesValidation = True
		Me.txtLocation.Enabled = True
		Me.txtLocation.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLocation.HideSelection = True
		Me.txtLocation.ReadOnly = False
		Me.txtLocation.Maxlength = 0
		Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLocation.MultiLine = False
		Me.txtLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLocation.TabStop = True
		Me.txtLocation.Visible = True
		Me.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLocation.Name = "txtLocation"
		Me.ckLocation.Text = "Location"
		Me.ckLocation.Size = New System.Drawing.Size(73, 17)
		Me.ckLocation.Location = New System.Drawing.Point(16, 224)
		Me.ckLocation.TabIndex = 49
		Me.ckLocation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckLocation.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckLocation.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckLocation.BackColor = System.Drawing.SystemColors.Control
		Me.ckLocation.CausesValidation = True
		Me.ckLocation.Enabled = True
		Me.ckLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckLocation.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckLocation.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckLocation.TabStop = True
		Me.ckLocation.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckLocation.Visible = True
		Me.ckLocation.Name = "ckLocation"
		Me.ckGrandTotal.Text = "Check1"
		Me.ckGrandTotal.Size = New System.Drawing.Size(17, 17)
		Me.ckGrandTotal.Location = New System.Drawing.Point(224, 496)
		Me.ckGrandTotal.TabIndex = 47
		Me.ckGrandTotal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckGrandTotal.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckGrandTotal.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckGrandTotal.BackColor = System.Drawing.SystemColors.Control
		Me.ckGrandTotal.CausesValidation = True
		Me.ckGrandTotal.Enabled = True
		Me.ckGrandTotal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckGrandTotal.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckGrandTotal.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckGrandTotal.TabStop = True
		Me.ckGrandTotal.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckGrandTotal.Visible = True
		Me.ckGrandTotal.Name = "ckGrandTotal"
		Me.ckTax.Text = "Check1"
		Me.ckTax.Size = New System.Drawing.Size(17, 17)
		Me.ckTax.Location = New System.Drawing.Point(224, 472)
		Me.ckTax.TabIndex = 46
		Me.ckTax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckTax.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckTax.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckTax.BackColor = System.Drawing.SystemColors.Control
		Me.ckTax.CausesValidation = True
		Me.ckTax.Enabled = True
		Me.ckTax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckTax.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckTax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckTax.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckTax.TabStop = True
		Me.ckTax.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckTax.Visible = True
		Me.ckTax.Name = "ckTax"
		Me.ckInvoiceFee.Text = "Check1"
		Me.ckInvoiceFee.Size = New System.Drawing.Size(17, 25)
		Me.ckInvoiceFee.Location = New System.Drawing.Point(224, 448)
		Me.ckInvoiceFee.TabIndex = 45
		Me.ckInvoiceFee.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckInvoiceFee.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckInvoiceFee.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckInvoiceFee.BackColor = System.Drawing.SystemColors.Control
		Me.ckInvoiceFee.CausesValidation = True
		Me.ckInvoiceFee.Enabled = True
		Me.ckInvoiceFee.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckInvoiceFee.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckInvoiceFee.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckInvoiceFee.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckInvoiceFee.TabStop = True
		Me.ckInvoiceFee.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckInvoiceFee.Visible = True
		Me.ckInvoiceFee.Name = "ckInvoiceFee"
		Me.ckStoreFlatFee.Text = "Check1"
		Me.ckStoreFlatFee.Size = New System.Drawing.Size(17, 17)
		Me.ckStoreFlatFee.Location = New System.Drawing.Point(224, 424)
		Me.ckStoreFlatFee.TabIndex = 44
		Me.ckStoreFlatFee.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckStoreFlatFee.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckStoreFlatFee.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckStoreFlatFee.BackColor = System.Drawing.SystemColors.Control
		Me.ckStoreFlatFee.CausesValidation = True
		Me.ckStoreFlatFee.Enabled = True
		Me.ckStoreFlatFee.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckStoreFlatFee.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckStoreFlatFee.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckStoreFlatFee.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckStoreFlatFee.TabStop = True
		Me.ckStoreFlatFee.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckStoreFlatFee.Visible = True
		Me.ckStoreFlatFee.Name = "ckStoreFlatFee"
		Me.ckSavingsPercent.Text = "Check1"
		Me.ckSavingsPercent.Size = New System.Drawing.Size(17, 17)
		Me.ckSavingsPercent.Location = New System.Drawing.Point(224, 400)
		Me.ckSavingsPercent.TabIndex = 43
		Me.ckSavingsPercent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckSavingsPercent.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckSavingsPercent.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckSavingsPercent.BackColor = System.Drawing.SystemColors.Control
		Me.ckSavingsPercent.CausesValidation = True
		Me.ckSavingsPercent.Enabled = True
		Me.ckSavingsPercent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckSavingsPercent.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckSavingsPercent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckSavingsPercent.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckSavingsPercent.TabStop = True
		Me.ckSavingsPercent.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckSavingsPercent.Visible = True
		Me.ckSavingsPercent.Name = "ckSavingsPercent"
		Me.txtGrandTotal.AllowPromptAsInput = False
		Me.txtGrandTotal.Size = New System.Drawing.Size(113, 19)
		Me.txtGrandTotal.Location = New System.Drawing.Point(288, 496)
		Me.txtGrandTotal.TabIndex = 41
		Me.txtGrandTotal.PromptChar = "_"
		Me.txtGrandTotal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrandTotal.Name = "txtGrandTotal"
		Me.txtTax.AllowPromptAsInput = False
		Me.txtTax.Size = New System.Drawing.Size(113, 19)
		Me.txtTax.Location = New System.Drawing.Point(288, 472)
		Me.txtTax.TabIndex = 40
		Me.txtTax.PromptChar = "_"
		Me.txtTax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTax.Name = "txtTax"
		Me.txtInvoiceFee.AllowPromptAsInput = False
		Me.txtInvoiceFee.Size = New System.Drawing.Size(113, 19)
		Me.txtInvoiceFee.Location = New System.Drawing.Point(288, 448)
		Me.txtInvoiceFee.TabIndex = 39
		Me.txtInvoiceFee.PromptChar = "_"
		Me.txtInvoiceFee.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoiceFee.Name = "txtInvoiceFee"
		Me.txtStoreFlatFee.AllowPromptAsInput = False
		Me.txtStoreFlatFee.Size = New System.Drawing.Size(113, 19)
		Me.txtStoreFlatFee.Location = New System.Drawing.Point(288, 424)
		Me.txtStoreFlatFee.TabIndex = 38
		Me.txtStoreFlatFee.PromptChar = "_"
		Me.txtStoreFlatFee.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreFlatFee.Name = "txtStoreFlatFee"
		Me.txtSavingsPercent.AllowPromptAsInput = False
		Me.txtSavingsPercent.Size = New System.Drawing.Size(113, 19)
		Me.txtSavingsPercent.Location = New System.Drawing.Point(288, 400)
		Me.txtSavingsPercent.TabIndex = 37
		Me.txtSavingsPercent.PromptChar = "_"
		Me.txtSavingsPercent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSavingsPercent.Name = "txtSavingsPercent"
		Me.txtSavings.AllowPromptAsInput = False
		Me.txtSavings.Size = New System.Drawing.Size(113, 19)
		Me.txtSavings.Location = New System.Drawing.Point(288, 376)
		Me.txtSavings.TabIndex = 36
		Me.txtSavings.PromptChar = "_"
		Me.txtSavings.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSavings.Name = "txtSavings"
		Me.txtInvoiceTotal.AllowPromptAsInput = False
		Me.txtInvoiceTotal.Size = New System.Drawing.Size(113, 19)
		Me.txtInvoiceTotal.Location = New System.Drawing.Point(288, 352)
		Me.txtInvoiceTotal.TabIndex = 35
		Me.txtInvoiceTotal.PromptChar = "_"
		Me.txtInvoiceTotal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoiceTotal.Name = "txtInvoiceTotal"
		Me.txtGreeting.AutoSize = False
		Me.txtGreeting.Size = New System.Drawing.Size(393, 49)
		Me.txtGreeting.Location = New System.Drawing.Point(16, 536)
		Me.txtGreeting.MultiLine = True
		Me.txtGreeting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtGreeting.TabIndex = 29
		Me.ToolTip1.SetToolTip(Me.txtGreeting, "Footer")
		Me.txtGreeting.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGreeting.AcceptsReturn = True
		Me.txtGreeting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGreeting.BackColor = System.Drawing.SystemColors.Window
		Me.txtGreeting.CausesValidation = True
		Me.txtGreeting.Enabled = True
		Me.txtGreeting.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGreeting.HideSelection = True
		Me.txtGreeting.ReadOnly = False
		Me.txtGreeting.Maxlength = 0
		Me.txtGreeting.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGreeting.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGreeting.TabStop = True
		Me.txtGreeting.Visible = True
		Me.txtGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGreeting.Name = "txtGreeting"
		Me.txtDescription.AutoSize = False
		Me.txtDescription.Size = New System.Drawing.Size(393, 73)
		Me.txtDescription.Location = New System.Drawing.Point(16, 256)
		Me.txtDescription.MultiLine = True
		Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtDescription.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me.txtDescription, "Body")
		Me.txtDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDescription.AcceptsReturn = True
		Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
		Me.txtDescription.CausesValidation = True
		Me.txtDescription.Enabled = True
		Me.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDescription.HideSelection = True
		Me.txtDescription.ReadOnly = False
		Me.txtDescription.Maxlength = 0
		Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDescription.TabStop = True
		Me.txtDescription.Visible = True
		Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDescription.Name = "txtDescription"
		Me.txtInvoiceNo.AutoSize = False
		Me.txtInvoiceNo.Size = New System.Drawing.Size(113, 19)
		Me.txtInvoiceNo.Location = New System.Drawing.Point(296, 184)
		Me.txtInvoiceNo.TabIndex = 17
		Me.txtInvoiceNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoiceNo.AcceptsReturn = True
		Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInvoiceNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtInvoiceNo.CausesValidation = True
		Me.txtInvoiceNo.Enabled = True
		Me.txtInvoiceNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInvoiceNo.HideSelection = True
		Me.txtInvoiceNo.ReadOnly = False
		Me.txtInvoiceNo.Maxlength = 0
		Me.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInvoiceNo.MultiLine = False
		Me.txtInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInvoiceNo.TabStop = True
		Me.txtInvoiceNo.Visible = True
		Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInvoiceNo.Name = "txtInvoiceNo"
		Me.txtAccountNo.AutoSize = False
		Me.txtAccountNo.Size = New System.Drawing.Size(113, 19)
		Me.txtAccountNo.Location = New System.Drawing.Point(104, 184)
		Me.txtAccountNo.TabIndex = 16
		Me.txtAccountNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccountNo.AcceptsReturn = True
		Me.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccountNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtAccountNo.CausesValidation = True
		Me.txtAccountNo.Enabled = True
		Me.txtAccountNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccountNo.HideSelection = True
		Me.txtAccountNo.ReadOnly = False
		Me.txtAccountNo.Maxlength = 0
		Me.txtAccountNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccountNo.MultiLine = False
		Me.txtAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccountNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccountNo.TabStop = True
		Me.txtAccountNo.Visible = True
		Me.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccountNo.Name = "txtAccountNo"
		Me.txBillingPeriod.AutoSize = False
		Me.txBillingPeriod.Size = New System.Drawing.Size(225, 21)
		Me.txBillingPeriod.Location = New System.Drawing.Point(104, 152)
		Me.txBillingPeriod.TabIndex = 13
		Me.txBillingPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txBillingPeriod.AcceptsReturn = True
		Me.txBillingPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txBillingPeriod.BackColor = System.Drawing.SystemColors.Window
		Me.txBillingPeriod.CausesValidation = True
		Me.txBillingPeriod.Enabled = True
		Me.txBillingPeriod.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txBillingPeriod.HideSelection = True
		Me.txBillingPeriod.ReadOnly = False
		Me.txBillingPeriod.Maxlength = 0
		Me.txBillingPeriod.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txBillingPeriod.MultiLine = False
		Me.txBillingPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txBillingPeriod.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txBillingPeriod.TabStop = True
		Me.txBillingPeriod.Visible = True
		Me.txBillingPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txBillingPeriod.Name = "txBillingPeriod"
		Me.txtInvoiceDate.AutoSize = False
		Me.txtInvoiceDate.Size = New System.Drawing.Size(249, 21)
		Me.txtInvoiceDate.Location = New System.Drawing.Point(104, 32)
		Me.txtInvoiceDate.TabIndex = 9
		Me.txtInvoiceDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoiceDate.AcceptsReturn = True
		Me.txtInvoiceDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInvoiceDate.BackColor = System.Drawing.SystemColors.Window
		Me.txtInvoiceDate.CausesValidation = True
		Me.txtInvoiceDate.Enabled = True
		Me.txtInvoiceDate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInvoiceDate.HideSelection = True
		Me.txtInvoiceDate.ReadOnly = False
		Me.txtInvoiceDate.Maxlength = 0
		Me.txtInvoiceDate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInvoiceDate.MultiLine = False
		Me.txtInvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInvoiceDate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInvoiceDate.TabStop = True
		Me.txtInvoiceDate.Visible = True
		Me.txtInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInvoiceDate.Name = "txtInvoiceDate"
		Me.txtAddress.AutoSize = False
		Me.txtAddress.Size = New System.Drawing.Size(297, 73)
		Me.txtAddress.Location = New System.Drawing.Point(104, 64)
		Me.txtAddress.MultiLine = True
		Me.txtAddress.TabIndex = 6
		Me.txtAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.AcceptsReturn = True
		Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtAddress.CausesValidation = True
		Me.txtAddress.Enabled = True
		Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAddress.HideSelection = True
		Me.txtAddress.ReadOnly = False
		Me.txtAddress.Maxlength = 0
		Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAddress.TabStop = True
		Me.txtAddress.Visible = True
		Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAddress.Name = "txtAddress"
		Me.Label19.Text = "Show in Doc"
		Me.Label19.Size = New System.Drawing.Size(73, 17)
		Me.Label19.Location = New System.Drawing.Point(200, 336)
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
		Me.Label16.Text = "Grand Total..............................................."
		Me.Label16.Size = New System.Drawing.Size(201, 17)
		Me.Label16.Location = New System.Drawing.Point(16, 496)
		Me.Label16.TabIndex = 28
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
		Me.Label15.Text = "Tax............................................................"
		Me.Label15.Size = New System.Drawing.Size(201, 17)
		Me.Label15.Location = New System.Drawing.Point(16, 472)
		Me.Label15.TabIndex = 27
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
		Me.Label14.Size = New System.Drawing.Size(9, 1)
		Me.Label14.Location = New System.Drawing.Point(160, 168)
		Me.Label14.TabIndex = 24
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
		Me.Label13.Text = "Invoice Fee..............................................."
		Me.Label13.Size = New System.Drawing.Size(201, 17)
		Me.Label13.Location = New System.Drawing.Point(16, 448)
		Me.Label13.TabIndex = 23
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
		Me.Label12.Text = "Store Flat Fee............................................"
		Me.Label12.Size = New System.Drawing.Size(209, 17)
		Me.Label12.Location = New System.Drawing.Point(16, 424)
		Me.Label12.TabIndex = 22
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
		Me.Label11.Text = "GLM Charges(Savings Percent) ................"
		Me.Label11.Size = New System.Drawing.Size(209, 17)
		Me.Label11.Location = New System.Drawing.Point(16, 400)
		Me.Label11.TabIndex = 21
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
		Me.Label10.Text = "Savings......................................................"
		Me.Label10.Size = New System.Drawing.Size(209, 17)
		Me.Label10.Location = New System.Drawing.Point(16, 376)
		Me.Label10.TabIndex = 20
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
		Me.Label9.Text = "Bill Payment................................................"
		Me.Label9.Size = New System.Drawing.Size(225, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 352)
		Me.Label9.TabIndex = 19
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
		Me.Label8.Text = "INVOICE NO:"
		Me.Label8.Size = New System.Drawing.Size(73, 17)
		Me.Label8.Location = New System.Drawing.Point(224, 184)
		Me.Label8.TabIndex = 15
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
		Me.Label7.Text = "ACCOUNT NO:"
		Me.Label7.Size = New System.Drawing.Size(97, 17)
		Me.Label7.Location = New System.Drawing.Point(16, 192)
		Me.Label7.TabIndex = 14
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
		Me.Label6.Text = "For the month of"
		Me.Label6.Size = New System.Drawing.Size(89, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 152)
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
		Me.Label5.Text = "Address"
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 88)
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
		Me.Label4.Text = "Invoice Date"
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 40)
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
		Me.cbCustId.Size = New System.Drawing.Size(73, 21)
		Me.cbCustId.Location = New System.Drawing.Point(232, 48)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 4
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
		Me.cbCustName.Size = New System.Drawing.Size(201, 21)
		Me.cbCustName.Location = New System.Drawing.Point(104, 88)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 3
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
		dtInvoiceDate.OcxState = CType(resources.GetObject("dtInvoiceDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtInvoiceDate.Size = New System.Drawing.Size(113, 21)
		Me.dtInvoiceDate.Location = New System.Drawing.Point(104, 48)
		Me.dtInvoiceDate.TabIndex = 1
		Me.dtInvoiceDate.Name = "dtInvoiceDate"
		Me.Label18.Text = "Template"
		Me.Label18.Size = New System.Drawing.Size(57, 17)
		Me.Label18.Location = New System.Drawing.Point(16, 208)
		Me.Label18.TabIndex = 33
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
		Me.Label17.Text = "Store Group"
		Me.Label17.Size = New System.Drawing.Size(65, 17)
		Me.Label17.Location = New System.Drawing.Point(16, 168)
		Me.Label17.TabIndex = 31
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
		Me.Label3.Text = "Invoicing Period"
		Me.Label3.Size = New System.Drawing.Size(81, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 128)
		Me.Label3.TabIndex = 7
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
		Me.Label2.Text = "Customer"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 88)
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
		Me.Label1.Text = "Invoice Date"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 48)
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
		Me.Controls.Add(cmdSelectedValues)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(VScroll1)
		Me.Controls.Add(cbTemplate)
		Me.Controls.Add(cbGroupStore)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(cmdDisplayAmounts)
		Me.Controls.Add(cmdBuildDoc)
		Me.Controls.Add(cbPeriod)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(dtInvoiceDate)
		Me.Controls.Add(Label18)
		Me.Controls.Add(Label17)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame2.Controls.Add(ckTotalByStoreGroup)
		Me.Frame1.Controls.Add(txtLocation)
		Me.Frame1.Controls.Add(ckLocation)
		Me.Frame1.Controls.Add(ckGrandTotal)
		Me.Frame1.Controls.Add(ckTax)
		Me.Frame1.Controls.Add(ckInvoiceFee)
		Me.Frame1.Controls.Add(ckStoreFlatFee)
		Me.Frame1.Controls.Add(ckSavingsPercent)
		Me.Frame1.Controls.Add(txtGrandTotal)
		Me.Frame1.Controls.Add(txtTax)
		Me.Frame1.Controls.Add(txtInvoiceFee)
		Me.Frame1.Controls.Add(txtStoreFlatFee)
		Me.Frame1.Controls.Add(txtSavingsPercent)
		Me.Frame1.Controls.Add(txtSavings)
		Me.Frame1.Controls.Add(txtInvoiceTotal)
		Me.Frame1.Controls.Add(txtGreeting)
		Me.Frame1.Controls.Add(txtDescription)
		Me.Frame1.Controls.Add(txtInvoiceNo)
		Me.Frame1.Controls.Add(txtAccountNo)
		Me.Frame1.Controls.Add(txBillingPeriod)
		Me.Frame1.Controls.Add(txtInvoiceDate)
		Me.Frame1.Controls.Add(txtAddress)
		Me.Frame1.Controls.Add(Label19)
		Me.Frame1.Controls.Add(Label16)
		Me.Frame1.Controls.Add(Label15)
		Me.Frame1.Controls.Add(Label14)
		Me.Frame1.Controls.Add(Label13)
		Me.Frame1.Controls.Add(Label12)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		CType(Me.dtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class