<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckBatch
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
	Public WithEvents cmdShowVBranch As System.Windows.Forms.Button
	Public WithEvents obSelectedBranches As System.Windows.Forms.RadioButton
	Public WithEvents obAllBranches As System.Windows.Forms.RadioButton
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents ckZeroedInvoice As System.Windows.Forms.CheckBox
	Public WithEvents ckPeriod As System.Windows.Forms.CheckBox
	Public WithEvents cbPeriodStart As System.Windows.Forms.ComboBox
	Public WithEvents cbPeriodEnd As System.Windows.Forms.ComboBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents lbPeriodStartDate As System.Windows.Forms.Label
	Public WithEvents lbPeriodEndDate As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents txtCheckNo As System.Windows.Forms.TextBox
	Public WithEvents cbBankName As System.Windows.Forms.ComboBox
	Public WithEvents cbBankAccount As System.Windows.Forms.ComboBox
	Public WithEvents txtDetail1 As System.Windows.Forms.TextBox
	Public WithEvents txtDetail2 As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents label9 As System.Windows.Forms.Label
	Public WithEvents frBatch As System.Windows.Forms.GroupBox
	Public WithEvents cmdAbort As System.Windows.Forms.Button
	Public WithEvents cmdSavePrint As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents picLogo As System.Windows.Forms.PictureBox
	Public WithEvents _sbBatch_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbBatch As System.Windows.Forms.StatusStrip
	Public WithEvents cmdBatch As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckBatch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.frBatch = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdShowVBranch = New System.Windows.Forms.Button
		Me.obSelectedBranches = New System.Windows.Forms.RadioButton
		Me.obAllBranches = New System.Windows.Forms.RadioButton
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.ckZeroedInvoice = New System.Windows.Forms.CheckBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.ckPeriod = New System.Windows.Forms.CheckBox
		Me.cbPeriodStart = New System.Windows.Forms.ComboBox
		Me.cbPeriodEnd = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.lbPeriodStartDate = New System.Windows.Forms.Label
		Me.lbPeriodEndDate = New System.Windows.Forms.Label
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.txtCheckNo = New System.Windows.Forms.TextBox
		Me.cbBankName = New System.Windows.Forms.ComboBox
		Me.cbBankAccount = New System.Windows.Forms.ComboBox
		Me.txtDetail1 = New System.Windows.Forms.TextBox
		Me.txtDetail2 = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.label9 = New System.Windows.Forms.Label
		Me.cmdAbort = New System.Windows.Forms.Button
		Me.cmdSavePrint = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.picLogo = New System.Windows.Forms.PictureBox
		Me.sbBatch = New System.Windows.Forms.StatusStrip
		Me._sbBatch_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me.cmdBatch = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.frBatch.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.sbBatch.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Batch Check Generation"
		Me.ClientSize = New System.Drawing.Size(671, 472)
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
		Me.Name = "frmCheckBatch"
		Me.frBatch.Text = "Select Options"
		Me.frBatch.Size = New System.Drawing.Size(649, 361)
		Me.frBatch.Location = New System.Drawing.Point(16, 8)
		Me.frBatch.TabIndex = 8
		Me.frBatch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frBatch.BackColor = System.Drawing.SystemColors.Control
		Me.frBatch.Enabled = True
		Me.frBatch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frBatch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frBatch.Visible = True
		Me.frBatch.Name = "frBatch"
		Me.Frame2.Size = New System.Drawing.Size(281, 121)
		Me.Frame2.Location = New System.Drawing.Point(344, 128)
		Me.Frame2.TabIndex = 29
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.cmdShowVBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdShowVBranch.Text = "List"
		Me.cmdShowVBranch.Size = New System.Drawing.Size(73, 25)
		Me.cmdShowVBranch.Location = New System.Drawing.Point(160, 84)
		Me.cmdShowVBranch.TabIndex = 34
		Me.cmdShowVBranch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdShowVBranch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdShowVBranch.CausesValidation = True
		Me.cmdShowVBranch.Enabled = True
		Me.cmdShowVBranch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdShowVBranch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdShowVBranch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdShowVBranch.TabStop = True
		Me.cmdShowVBranch.Name = "cmdShowVBranch"
		Me.obSelectedBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obSelectedBranches.Text = "Select  Branches"
		Me.obSelectedBranches.Size = New System.Drawing.Size(169, 17)
		Me.obSelectedBranches.Location = New System.Drawing.Point(48, 88)
		Me.obSelectedBranches.TabIndex = 32
		Me.obSelectedBranches.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obSelectedBranches.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obSelectedBranches.BackColor = System.Drawing.SystemColors.Control
		Me.obSelectedBranches.CausesValidation = True
		Me.obSelectedBranches.Enabled = True
		Me.obSelectedBranches.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obSelectedBranches.Cursor = System.Windows.Forms.Cursors.Default
		Me.obSelectedBranches.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obSelectedBranches.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obSelectedBranches.TabStop = True
		Me.obSelectedBranches.Checked = False
		Me.obSelectedBranches.Visible = True
		Me.obSelectedBranches.Name = "obSelectedBranches"
		Me.obAllBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obAllBranches.Text = "All Vendor Branches"
		Me.obAllBranches.Size = New System.Drawing.Size(185, 17)
		Me.obAllBranches.Location = New System.Drawing.Point(48, 64)
		Me.obAllBranches.TabIndex = 31
		Me.obAllBranches.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obAllBranches.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obAllBranches.BackColor = System.Drawing.SystemColors.Control
		Me.obAllBranches.CausesValidation = True
		Me.obAllBranches.Enabled = True
		Me.obAllBranches.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obAllBranches.Cursor = System.Windows.Forms.Cursors.Default
		Me.obAllBranches.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obAllBranches.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obAllBranches.TabStop = True
		Me.obAllBranches.Checked = False
		Me.obAllBranches.Visible = True
		Me.obAllBranches.Name = "obAllBranches"
		Me.cbVendor.Size = New System.Drawing.Size(257, 21)
		Me.cbVendor.Location = New System.Drawing.Point(16, 32)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 30
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
		Me.Label7.Text = "Vendor"
		Me.Label7.Size = New System.Drawing.Size(49, 17)
		Me.Label7.Location = New System.Drawing.Point(16, 16)
		Me.Label7.TabIndex = 33
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
		Me.ckZeroedInvoice.Text = "Update status in Invoices with Zero balance"
		Me.ckZeroedInvoice.Size = New System.Drawing.Size(281, 17)
		Me.ckZeroedInvoice.Location = New System.Drawing.Point(16, 64)
		Me.ckZeroedInvoice.TabIndex = 28
		Me.ckZeroedInvoice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckZeroedInvoice.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckZeroedInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckZeroedInvoice.BackColor = System.Drawing.SystemColors.Control
		Me.ckZeroedInvoice.CausesValidation = True
		Me.ckZeroedInvoice.Enabled = True
		Me.ckZeroedInvoice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckZeroedInvoice.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckZeroedInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckZeroedInvoice.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckZeroedInvoice.TabStop = True
		Me.ckZeroedInvoice.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckZeroedInvoice.Visible = True
		Me.ckZeroedInvoice.Name = "ckZeroedInvoice"
		Me.Frame1.Size = New System.Drawing.Size(289, 145)
		Me.Frame1.Location = New System.Drawing.Point(16, 88)
		Me.Frame1.TabIndex = 15
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.ckPeriod.Text = "Apply Invoice Period"
		Me.ckPeriod.Size = New System.Drawing.Size(129, 17)
		Me.ckPeriod.Location = New System.Drawing.Point(16, 16)
		Me.ckPeriod.TabIndex = 18
		Me.ckPeriod.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ckPeriod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckPeriod.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckPeriod.BackColor = System.Drawing.SystemColors.Control
		Me.ckPeriod.CausesValidation = True
		Me.ckPeriod.Enabled = True
		Me.ckPeriod.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckPeriod.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckPeriod.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckPeriod.TabStop = True
		Me.ckPeriod.Visible = True
		Me.ckPeriod.Name = "ckPeriod"
		Me.cbPeriodStart.Size = New System.Drawing.Size(161, 21)
		Me.cbPeriodStart.Location = New System.Drawing.Point(104, 40)
		Me.cbPeriodStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodStart.TabIndex = 17
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
		Me.cbPeriodEnd.Size = New System.Drawing.Size(161, 21)
		Me.cbPeriodEnd.Location = New System.Drawing.Point(104, 72)
		Me.cbPeriodEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodEnd.TabIndex = 16
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
		Me.Label3.Text = "Start Period"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 40)
		Me.Label3.TabIndex = 22
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
		Me.Label4.Text = "End Period"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 72)
		Me.Label4.TabIndex = 21
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
		Me.lbPeriodStartDate.Text = "Start"
		Me.lbPeriodStartDate.Size = New System.Drawing.Size(73, 17)
		Me.lbPeriodStartDate.Location = New System.Drawing.Point(32, 112)
		Me.lbPeriodStartDate.TabIndex = 20
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
		Me.lbPeriodEndDate.Text = "End"
		Me.lbPeriodEndDate.Size = New System.Drawing.Size(73, 17)
		Me.lbPeriodEndDate.Location = New System.Drawing.Point(136, 112)
		Me.lbPeriodEndDate.TabIndex = 19
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
		Me.cbCustName.Size = New System.Drawing.Size(225, 21)
		Me.cbCustName.Location = New System.Drawing.Point(72, 24)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 1
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
		Me.cbCustId.Size = New System.Drawing.Size(49, 21)
		Me.cbCustId.Location = New System.Drawing.Point(296, 24)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 14
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
		Me.txtCheckNo.AutoSize = False
		Me.txtCheckNo.Size = New System.Drawing.Size(145, 21)
		Me.txtCheckNo.Location = New System.Drawing.Point(472, 104)
		Me.txtCheckNo.TabIndex = 13
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
		Me.cbBankName.Size = New System.Drawing.Size(145, 21)
		Me.cbBankName.Location = New System.Drawing.Point(472, 24)
		Me.cbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankName.TabIndex = 12
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
		Me.cbBankAccount.Size = New System.Drawing.Size(145, 21)
		Me.cbBankAccount.Location = New System.Drawing.Point(472, 64)
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
		Me.txtDetail1.AutoSize = False
		Me.txtDetail1.Size = New System.Drawing.Size(505, 21)
		Me.txtDetail1.Location = New System.Drawing.Point(16, 264)
		Me.txtDetail1.TabIndex = 10
		Me.txtDetail1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDetail1.AcceptsReturn = True
		Me.txtDetail1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDetail1.BackColor = System.Drawing.SystemColors.Window
		Me.txtDetail1.CausesValidation = True
		Me.txtDetail1.Enabled = True
		Me.txtDetail1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDetail1.HideSelection = True
		Me.txtDetail1.ReadOnly = False
		Me.txtDetail1.Maxlength = 0
		Me.txtDetail1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDetail1.MultiLine = False
		Me.txtDetail1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDetail1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDetail1.TabStop = True
		Me.txtDetail1.Visible = True
		Me.txtDetail1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDetail1.Name = "txtDetail1"
		Me.txtDetail2.AutoSize = False
		Me.txtDetail2.Size = New System.Drawing.Size(505, 21)
		Me.txtDetail2.Location = New System.Drawing.Point(16, 304)
		Me.txtDetail2.TabIndex = 9
		Me.txtDetail2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDetail2.AcceptsReturn = True
		Me.txtDetail2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDetail2.BackColor = System.Drawing.SystemColors.Window
		Me.txtDetail2.CausesValidation = True
		Me.txtDetail2.Enabled = True
		Me.txtDetail2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDetail2.HideSelection = True
		Me.txtDetail2.ReadOnly = False
		Me.txtDetail2.Maxlength = 0
		Me.txtDetail2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDetail2.MultiLine = False
		Me.txtDetail2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDetail2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDetail2.TabStop = True
		Me.txtDetail2.Visible = True
		Me.txtDetail2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDetail2.Name = "txtDetail2"
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.TabIndex = 27
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
		Me.Label2.Text = "Bank"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(360, 24)
		Me.Label2.TabIndex = 26
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
		Me.label5.Text = "Account"
		Me.label5.Size = New System.Drawing.Size(49, 17)
		Me.label5.Location = New System.Drawing.Point(360, 64)
		Me.label5.TabIndex = 25
		Me.label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label5.BackColor = System.Drawing.SystemColors.Control
		Me.label5.Enabled = True
		Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label5.UseMnemonic = True
		Me.label5.Visible = True
		Me.label5.AutoSize = False
		Me.label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label5.Name = "label5"
		Me.Label6.Text = "Begining Check No"
		Me.Label6.Size = New System.Drawing.Size(97, 17)
		Me.Label6.Location = New System.Drawing.Point(360, 104)
		Me.Label6.TabIndex = 24
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
		Me.label9.Text = "Check Foot Note"
		Me.label9.Size = New System.Drawing.Size(89, 17)
		Me.label9.Location = New System.Drawing.Point(16, 248)
		Me.label9.TabIndex = 23
		Me.label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label9.BackColor = System.Drawing.SystemColors.Control
		Me.label9.Enabled = True
		Me.label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label9.UseMnemonic = True
		Me.label9.Visible = True
		Me.label9.AutoSize = False
		Me.label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label9.Name = "label9"
		Me.cmdAbort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAbort.Text = "Abort"
		Me.cmdAbort.Size = New System.Drawing.Size(73, 41)
		Me.cmdAbort.Location = New System.Drawing.Point(312, 384)
		Me.cmdAbort.TabIndex = 7
		Me.cmdAbort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAbort.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAbort.CausesValidation = True
		Me.cmdAbort.Enabled = True
		Me.cmdAbort.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAbort.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAbort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAbort.TabStop = True
		Me.cmdAbort.Name = "cmdAbort"
		Me.cmdSavePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSavePrint.Text = "Save and Print"
		Me.cmdSavePrint.Size = New System.Drawing.Size(73, 41)
		Me.cmdSavePrint.Location = New System.Drawing.Point(216, 384)
		Me.cmdSavePrint.TabIndex = 6
		Me.cmdSavePrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSavePrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSavePrint.CausesValidation = True
		Me.cmdSavePrint.Enabled = True
		Me.cmdSavePrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSavePrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSavePrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSavePrint.TabStop = True
		Me.cmdSavePrint.Name = "cmdSavePrint"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save Only"
		Me.cmdSave.Size = New System.Drawing.Size(73, 41)
		Me.cmdSave.Location = New System.Drawing.Point(120, 384)
		Me.cmdSave.TabIndex = 5
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.picLogo.Size = New System.Drawing.Size(100, 89)
		Me.picLogo.Location = New System.Drawing.Point(528, 360)
		Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
		Me.picLogo.TabIndex = 2
		Me.picLogo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picLogo.Dock = System.Windows.Forms.DockStyle.None
		Me.picLogo.BackColor = System.Drawing.SystemColors.Control
		Me.picLogo.CausesValidation = True
		Me.picLogo.Enabled = True
		Me.picLogo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picLogo.Cursor = System.Windows.Forms.Cursors.Default
		Me.picLogo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picLogo.TabStop = True
		Me.picLogo.Visible = True
		Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picLogo.Name = "picLogo"
		Me.sbBatch.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbBatch.Size = New System.Drawing.Size(671, 25)
		Me.sbBatch.Location = New System.Drawing.Point(0, 447)
		Me.sbBatch.TabIndex = 0
		Me.sbBatch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sbBatch.Name = "sbBatch"
		Me._sbBatch_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._sbBatch_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._sbBatch_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._sbBatch_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._sbBatch_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._sbBatch_Panel1.Size = New System.Drawing.Size(96, 25)
		Me._sbBatch_Panel1.AutoSize = False
		Me.cmdBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBatch.Text = "Run Batch"
		Me.cmdBatch.Size = New System.Drawing.Size(73, 41)
		Me.cmdBatch.Location = New System.Drawing.Point(24, 384)
		Me.cmdBatch.TabIndex = 4
		Me.cmdBatch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBatch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBatch.CausesValidation = True
		Me.cmdBatch.Enabled = True
		Me.cmdBatch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBatch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBatch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBatch.TabStop = True
		Me.cmdBatch.Name = "cmdBatch"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(73, 41)
		Me.cmdClose.Location = New System.Drawing.Point(408, 384)
		Me.cmdClose.TabIndex = 3
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.Controls.Add(frBatch)
		Me.Controls.Add(cmdAbort)
		Me.Controls.Add(cmdSavePrint)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(picLogo)
		Me.Controls.Add(sbBatch)
		Me.Controls.Add(cmdBatch)
		Me.Controls.Add(cmdClose)
		Me.frBatch.Controls.Add(Frame2)
		Me.frBatch.Controls.Add(ckZeroedInvoice)
		Me.frBatch.Controls.Add(Frame1)
		Me.frBatch.Controls.Add(cbCustName)
		Me.frBatch.Controls.Add(cbCustId)
		Me.frBatch.Controls.Add(txtCheckNo)
		Me.frBatch.Controls.Add(cbBankName)
		Me.frBatch.Controls.Add(cbBankAccount)
		Me.frBatch.Controls.Add(txtDetail1)
		Me.frBatch.Controls.Add(txtDetail2)
		Me.frBatch.Controls.Add(Label1)
		Me.frBatch.Controls.Add(Label2)
		Me.frBatch.Controls.Add(label5)
		Me.frBatch.Controls.Add(Label6)
		Me.frBatch.Controls.Add(label9)
		Me.Frame2.Controls.Add(cmdShowVBranch)
		Me.Frame2.Controls.Add(obSelectedBranches)
		Me.Frame2.Controls.Add(obAllBranches)
		Me.Frame2.Controls.Add(cbVendor)
		Me.Frame2.Controls.Add(Label7)
		Me.Frame1.Controls.Add(ckPeriod)
		Me.Frame1.Controls.Add(cbPeriodStart)
		Me.Frame1.Controls.Add(cbPeriodEnd)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(lbPeriodStartDate)
		Me.Frame1.Controls.Add(lbPeriodEndDate)
		Me.sbBatch.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._sbBatch_Panel1})
		Me.frBatch.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.sbBatch.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class