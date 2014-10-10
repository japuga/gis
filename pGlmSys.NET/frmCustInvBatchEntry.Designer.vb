<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustInvBatchEntry
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
	Public WithEvents obStore As System.Windows.Forms.RadioButton
	Public WithEvents obCustomer As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cbTemplate As System.Windows.Forms.ComboBox
	Public WithEvents txBatchDesc As System.Windows.Forms.TextBox
	Public WithEvents cbStoreGroup As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents txtInvoiceDate As System.Windows.Forms.TextBox
	Public WithEvents txBillingPeriod As System.Windows.Forms.TextBox
	Public WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
	Public WithEvents txtDescription As System.Windows.Forms.TextBox
	Public WithEvents txtGreeting As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbPeriod As System.Windows.Forms.ComboBox
	Public WithEvents cmdBuildDoc As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents dtInvoiceDate As AxMSComCtl2.AxDTPicker
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustInvBatchEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.obStore = New System.Windows.Forms.RadioButton
		Me.obCustomer = New System.Windows.Forms.RadioButton
		Me.cbTemplate = New System.Windows.Forms.ComboBox
		Me.txBatchDesc = New System.Windows.Forms.TextBox
		Me.cbStoreGroup = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtInvoiceDate = New System.Windows.Forms.TextBox
		Me.txBillingPeriod = New System.Windows.Forms.TextBox
		Me.txtInvoiceNo = New System.Windows.Forms.TextBox
		Me.txtDescription = New System.Windows.Forms.TextBox
		Me.txtGreeting = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.cbPeriod = New System.Windows.Forms.ComboBox
		Me.cmdBuildDoc = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.dtInvoiceDate = New AxMSComCtl2.AxDTPicker
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "MS-Word Invoice Batch Generation"
		Me.ClientSize = New System.Drawing.Size(811, 516)
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
		Me.Name = "frmCustInvBatchEntry"
		Me.Frame2.Text = "Account No"
		Me.Frame2.Size = New System.Drawing.Size(329, 105)
		Me.Frame2.Location = New System.Drawing.Point(40, 264)
		Me.Frame2.TabIndex = 27
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.obStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obStore.Text = "Use Account from Store "
		Me.obStore.Size = New System.Drawing.Size(201, 17)
		Me.obStore.Location = New System.Drawing.Point(16, 64)
		Me.obStore.TabIndex = 29
		Me.obStore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obStore.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obStore.BackColor = System.Drawing.SystemColors.Control
		Me.obStore.CausesValidation = True
		Me.obStore.Enabled = True
		Me.obStore.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obStore.Cursor = System.Windows.Forms.Cursors.Default
		Me.obStore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obStore.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obStore.TabStop = True
		Me.obStore.Checked = False
		Me.obStore.Visible = True
		Me.obStore.Name = "obStore"
		Me.obCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCustomer.Text = "Use Account from Customer "
		Me.obCustomer.Size = New System.Drawing.Size(273, 25)
		Me.obCustomer.Location = New System.Drawing.Point(16, 24)
		Me.obCustomer.TabIndex = 28
		Me.obCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obCustomer.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCustomer.BackColor = System.Drawing.SystemColors.Control
		Me.obCustomer.CausesValidation = True
		Me.obCustomer.Enabled = True
		Me.obCustomer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.obCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obCustomer.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obCustomer.TabStop = True
		Me.obCustomer.Checked = False
		Me.obCustomer.Visible = True
		Me.obCustomer.Name = "obCustomer"
		Me.cbTemplate.Size = New System.Drawing.Size(201, 21)
		Me.cbTemplate.Location = New System.Drawing.Point(128, 192)
		Me.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbTemplate.TabIndex = 26
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
		Me.txBatchDesc.AutoSize = False
		Me.txBatchDesc.Size = New System.Drawing.Size(241, 19)
		Me.txBatchDesc.Location = New System.Drawing.Point(128, 224)
		Me.txBatchDesc.Maxlength = 100
		Me.txBatchDesc.TabIndex = 24
		Me.txBatchDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txBatchDesc.AcceptsReturn = True
		Me.txBatchDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txBatchDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txBatchDesc.CausesValidation = True
		Me.txBatchDesc.Enabled = True
		Me.txBatchDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txBatchDesc.HideSelection = True
		Me.txBatchDesc.ReadOnly = False
		Me.txBatchDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txBatchDesc.MultiLine = False
		Me.txBatchDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txBatchDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txBatchDesc.TabStop = True
		Me.txBatchDesc.Visible = True
		Me.txBatchDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txBatchDesc.Name = "txBatchDesc"
		Me.cbStoreGroup.Size = New System.Drawing.Size(201, 21)
		Me.cbStoreGroup.Location = New System.Drawing.Point(128, 160)
		Me.cbStoreGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStoreGroup.TabIndex = 22
		Me.cbStoreGroup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStoreGroup.BackColor = System.Drawing.SystemColors.Window
		Me.cbStoreGroup.CausesValidation = True
		Me.cbStoreGroup.Enabled = True
		Me.cbStoreGroup.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStoreGroup.IntegralHeight = True
		Me.cbStoreGroup.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStoreGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStoreGroup.Sorted = False
		Me.cbStoreGroup.TabStop = True
		Me.cbStoreGroup.Visible = True
		Me.cbStoreGroup.Name = "cbStoreGroup"
		Me.cbCustName.Size = New System.Drawing.Size(201, 21)
		Me.cbCustName.Location = New System.Drawing.Point(128, 88)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 14
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
		Me.cbCustId.Size = New System.Drawing.Size(73, 21)
		Me.cbCustId.Location = New System.Drawing.Point(256, 48)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 13
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
		Me.Frame1.Text = "Invoice Data"
		Me.Frame1.Size = New System.Drawing.Size(425, 513)
		Me.Frame1.Location = New System.Drawing.Point(384, 0)
		Me.Frame1.TabIndex = 3
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtInvoiceDate.AutoSize = False
		Me.txtInvoiceDate.Size = New System.Drawing.Size(249, 21)
		Me.txtInvoiceDate.Location = New System.Drawing.Point(104, 32)
		Me.txtInvoiceDate.TabIndex = 8
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
		Me.txBillingPeriod.AutoSize = False
		Me.txBillingPeriod.Size = New System.Drawing.Size(225, 21)
		Me.txBillingPeriod.Location = New System.Drawing.Point(104, 64)
		Me.txBillingPeriod.TabIndex = 7
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
		Me.txtInvoiceNo.AutoSize = False
		Me.txtInvoiceNo.Size = New System.Drawing.Size(193, 19)
		Me.txtInvoiceNo.Location = New System.Drawing.Point(104, 96)
		Me.txtInvoiceNo.TabIndex = 6
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
		Me.txtDescription.AutoSize = False
		Me.txtDescription.Size = New System.Drawing.Size(393, 113)
		Me.txtDescription.Location = New System.Drawing.Point(16, 152)
		Me.txtDescription.MultiLine = True
		Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtDescription.TabIndex = 5
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
		Me.txtGreeting.AutoSize = False
		Me.txtGreeting.Size = New System.Drawing.Size(393, 97)
		Me.txtGreeting.Location = New System.Drawing.Point(16, 320)
		Me.txtGreeting.MultiLine = True
		Me.txtGreeting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtGreeting.TabIndex = 4
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
		Me.Label7.Text = "Letter Footer"
		Me.Label7.Size = New System.Drawing.Size(81, 17)
		Me.Label7.Location = New System.Drawing.Point(16, 296)
		Me.Label7.TabIndex = 20
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
		Me.Label5.Text = "Letter Body"
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 128)
		Me.Label5.TabIndex = 19
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
		Me.Label4.TabIndex = 12
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
		Me.Label6.Text = "For the month of"
		Me.Label6.Size = New System.Drawing.Size(89, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 72)
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
		Me.Label8.Text = "INVOICE NO:"
		Me.Label8.Size = New System.Drawing.Size(73, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 96)
		Me.Label8.TabIndex = 10
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
		Me.Label14.Text = "Label14"
		Me.Label14.Size = New System.Drawing.Size(9, 1)
		Me.Label14.Location = New System.Drawing.Point(160, 168)
		Me.Label14.TabIndex = 9
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
		Me.cbPeriod.Size = New System.Drawing.Size(201, 21)
		Me.cbPeriod.Location = New System.Drawing.Point(128, 128)
		Me.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriod.TabIndex = 2
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
		Me.cmdBuildDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBuildDoc.Text = "Generate Invoices"
		Me.cmdBuildDoc.Size = New System.Drawing.Size(89, 41)
		Me.cmdBuildDoc.Location = New System.Drawing.Point(24, 464)
		Me.cmdBuildDoc.TabIndex = 1
		Me.cmdBuildDoc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBuildDoc.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBuildDoc.CausesValidation = True
		Me.cmdBuildDoc.Enabled = True
		Me.cmdBuildDoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBuildDoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBuildDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBuildDoc.TabStop = True
		Me.cmdBuildDoc.Name = "cmdBuildDoc"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(89, 41)
		Me.cmdClose.Location = New System.Drawing.Point(136, 464)
		Me.cmdClose.TabIndex = 0
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		dtInvoiceDate.OcxState = CType(resources.GetObject("dtInvoiceDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtInvoiceDate.Size = New System.Drawing.Size(113, 21)
		Me.dtInvoiceDate.Location = New System.Drawing.Point(128, 48)
		Me.dtInvoiceDate.TabIndex = 15
		Me.dtInvoiceDate.Name = "dtInvoiceDate"
		Me.Label11.Text = "Template"
		Me.Label11.Size = New System.Drawing.Size(73, 17)
		Me.Label11.Location = New System.Drawing.Point(40, 192)
		Me.Label11.TabIndex = 25
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
		Me.Label10.Text = "Batch Desc"
		Me.Label10.Size = New System.Drawing.Size(73, 17)
		Me.Label10.Location = New System.Drawing.Point(40, 232)
		Me.Label10.TabIndex = 23
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
		Me.Label9.Text = "Store Group"
		Me.Label9.Size = New System.Drawing.Size(65, 17)
		Me.Label9.Location = New System.Drawing.Point(40, 160)
		Me.Label9.TabIndex = 21
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
		Me.Label1.Text = "Invoice Date"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 48)
		Me.Label1.TabIndex = 18
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
		Me.Label2.Text = "Customer"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(40, 88)
		Me.Label2.TabIndex = 17
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
		Me.Label3.Text = "Invoicing Period"
		Me.Label3.Size = New System.Drawing.Size(81, 17)
		Me.Label3.Location = New System.Drawing.Point(40, 128)
		Me.Label3.TabIndex = 16
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
		Me.Controls.Add(Frame2)
		Me.Controls.Add(cbTemplate)
		Me.Controls.Add(txBatchDesc)
		Me.Controls.Add(cbStoreGroup)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cbPeriod)
		Me.Controls.Add(cmdBuildDoc)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(dtInvoiceDate)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label3)
		Me.Frame2.Controls.Add(obStore)
		Me.Frame2.Controls.Add(obCustomer)
		Me.Frame1.Controls.Add(txtInvoiceDate)
		Me.Frame1.Controls.Add(txBillingPeriod)
		Me.Frame1.Controls.Add(txtInvoiceNo)
		Me.Frame1.Controls.Add(txtDescription)
		Me.Frame1.Controls.Add(txtGreeting)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label14)
		CType(Me.dtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class