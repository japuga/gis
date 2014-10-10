<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmStoreEqptEntry
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtEqptActualQty As System.Windows.Forms.TextBox
	Public WithEvents txtEqptSizeCapacity As System.Windows.Forms.TextBox
	Public WithEvents txtEqptSize As System.Windows.Forms.TextBox
	Public WithEvents txtEqptDesc As System.Windows.Forms.TextBox
	Public WithEvents cbEqptTempDesc As System.Windows.Forms.ComboBox
	Public WithEvents cbEqptTemp As System.Windows.Forms.ComboBox
	Public WithEvents cmdUpdate As System.Windows.Forms.Button
	Public WithEvents ckbAccount As System.Windows.Forms.CheckBox
	Public WithEvents txtStoreNumber As System.Windows.Forms.TextBox
	Public WithEvents txtCustName As System.Windows.Forms.TextBox
	Public WithEvents cbStatus As System.Windows.Forms.ComboBox
	Public WithEvents cbLoadId As System.Windows.Forms.ComboBox
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents dgAccountEqpt As AxMSDataGridLib.AxDataGrid
	Public WithEvents cbLoadDesc As System.Windows.Forms.ComboBox
	Public WithEvents cbContentDesc As System.Windows.Forms.ComboBox
	Public WithEvents cbEqptDesc As System.Windows.Forms.ComboBox
	Public WithEvents txtEqptQty As System.Windows.Forms.TextBox
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStoreEqptEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtEqptActualQty = New System.Windows.Forms.TextBox
		Me.txtEqptSizeCapacity = New System.Windows.Forms.TextBox
		Me.txtEqptSize = New System.Windows.Forms.TextBox
		Me.txtEqptDesc = New System.Windows.Forms.TextBox
		Me.cbEqptTempDesc = New System.Windows.Forms.ComboBox
		Me.cbEqptTemp = New System.Windows.Forms.ComboBox
		Me.cmdUpdate = New System.Windows.Forms.Button
		Me.ckbAccount = New System.Windows.Forms.CheckBox
		Me.txtStoreNumber = New System.Windows.Forms.TextBox
		Me.txtCustName = New System.Windows.Forms.TextBox
		Me.cbStatus = New System.Windows.Forms.ComboBox
		Me.cbLoadId = New System.Windows.Forms.ComboBox
		Me.cmdAdd = New System.Windows.Forms.Button
		Me.dgAccountEqpt = New AxMSDataGridLib.AxDataGrid
		Me.cbLoadDesc = New System.Windows.Forms.ComboBox
		Me.cbContentDesc = New System.Windows.Forms.ComboBox
		Me.cbEqptDesc = New System.Windows.Forms.ComboBox
		Me.txtEqptQty = New System.Windows.Forms.TextBox
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgAccountEqpt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Equipment"
		Me.ClientSize = New System.Drawing.Size(465, 592)
		Me.Location = New System.Drawing.Point(3, 96)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
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
		Me.Name = "frmStoreEqptEntry"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(49, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(248, 528)
		Me.cmdCancel.TabIndex = 11
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
		Me.cmdOk.Location = New System.Drawing.Point(168, 528)
		Me.cmdOk.TabIndex = 10
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.Frame1.Size = New System.Drawing.Size(425, 497)
		Me.Frame1.Location = New System.Drawing.Point(16, 16)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtEqptActualQty.AutoSize = False
		Me.txtEqptActualQty.Size = New System.Drawing.Size(105, 21)
		Me.txtEqptActualQty.Location = New System.Drawing.Point(272, 184)
		Me.txtEqptActualQty.TabIndex = 32
		Me.txtEqptActualQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEqptActualQty.AcceptsReturn = True
		Me.txtEqptActualQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEqptActualQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtEqptActualQty.CausesValidation = True
		Me.txtEqptActualQty.Enabled = True
		Me.txtEqptActualQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEqptActualQty.HideSelection = True
		Me.txtEqptActualQty.ReadOnly = False
		Me.txtEqptActualQty.Maxlength = 0
		Me.txtEqptActualQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEqptActualQty.MultiLine = False
		Me.txtEqptActualQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEqptActualQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEqptActualQty.TabStop = True
		Me.txtEqptActualQty.Visible = True
		Me.txtEqptActualQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEqptActualQty.Name = "txtEqptActualQty"
		Me.txtEqptSizeCapacity.AutoSize = False
		Me.txtEqptSizeCapacity.Size = New System.Drawing.Size(73, 21)
		Me.txtEqptSizeCapacity.Location = New System.Drawing.Point(304, 88)
		Me.txtEqptSizeCapacity.TabIndex = 30
		Me.txtEqptSizeCapacity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEqptSizeCapacity.AcceptsReturn = True
		Me.txtEqptSizeCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEqptSizeCapacity.BackColor = System.Drawing.SystemColors.Window
		Me.txtEqptSizeCapacity.CausesValidation = True
		Me.txtEqptSizeCapacity.Enabled = True
		Me.txtEqptSizeCapacity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEqptSizeCapacity.HideSelection = True
		Me.txtEqptSizeCapacity.ReadOnly = False
		Me.txtEqptSizeCapacity.Maxlength = 0
		Me.txtEqptSizeCapacity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEqptSizeCapacity.MultiLine = False
		Me.txtEqptSizeCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEqptSizeCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEqptSizeCapacity.TabStop = True
		Me.txtEqptSizeCapacity.Visible = True
		Me.txtEqptSizeCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEqptSizeCapacity.Name = "txtEqptSizeCapacity"
		Me.txtEqptSize.AutoSize = False
		Me.txtEqptSize.Enabled = False
		Me.txtEqptSize.Size = New System.Drawing.Size(73, 21)
		Me.txtEqptSize.Location = New System.Drawing.Point(304, 56)
		Me.txtEqptSize.ReadOnly = True
		Me.txtEqptSize.TabIndex = 29
		Me.txtEqptSize.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEqptSize.AcceptsReturn = True
		Me.txtEqptSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEqptSize.BackColor = System.Drawing.SystemColors.Window
		Me.txtEqptSize.CausesValidation = True
		Me.txtEqptSize.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEqptSize.HideSelection = True
		Me.txtEqptSize.Maxlength = 0
		Me.txtEqptSize.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEqptSize.MultiLine = False
		Me.txtEqptSize.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEqptSize.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEqptSize.TabStop = True
		Me.txtEqptSize.Visible = True
		Me.txtEqptSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEqptSize.Name = "txtEqptSize"
		Me.txtEqptDesc.AutoSize = False
		Me.txtEqptDesc.Size = New System.Drawing.Size(121, 21)
		Me.txtEqptDesc.Location = New System.Drawing.Point(88, 88)
		Me.txtEqptDesc.TabIndex = 28
		Me.txtEqptDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEqptDesc.AcceptsReturn = True
		Me.txtEqptDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEqptDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtEqptDesc.CausesValidation = True
		Me.txtEqptDesc.Enabled = True
		Me.txtEqptDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEqptDesc.HideSelection = True
		Me.txtEqptDesc.ReadOnly = False
		Me.txtEqptDesc.Maxlength = 0
		Me.txtEqptDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEqptDesc.MultiLine = False
		Me.txtEqptDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEqptDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEqptDesc.TabStop = True
		Me.txtEqptDesc.Visible = True
		Me.txtEqptDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEqptDesc.Name = "txtEqptDesc"
		Me.cbEqptTempDesc.Size = New System.Drawing.Size(105, 21)
		Me.cbEqptTempDesc.Location = New System.Drawing.Point(88, 256)
		Me.cbEqptTempDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEqptTempDesc.TabIndex = 6
		Me.cbEqptTempDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEqptTempDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbEqptTempDesc.CausesValidation = True
		Me.cbEqptTempDesc.Enabled = True
		Me.cbEqptTempDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEqptTempDesc.IntegralHeight = True
		Me.cbEqptTempDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEqptTempDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEqptTempDesc.Sorted = False
		Me.cbEqptTempDesc.TabStop = True
		Me.cbEqptTempDesc.Visible = True
		Me.cbEqptTempDesc.Name = "cbEqptTempDesc"
		Me.cbEqptTemp.Size = New System.Drawing.Size(105, 21)
		Me.cbEqptTemp.Location = New System.Drawing.Point(208, 256)
		Me.cbEqptTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEqptTemp.TabIndex = 24
		Me.cbEqptTemp.Visible = False
		Me.cbEqptTemp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEqptTemp.BackColor = System.Drawing.SystemColors.Window
		Me.cbEqptTemp.CausesValidation = True
		Me.cbEqptTemp.Enabled = True
		Me.cbEqptTemp.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEqptTemp.IntegralHeight = True
		Me.cbEqptTemp.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEqptTemp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEqptTemp.Sorted = False
		Me.cbEqptTemp.TabStop = True
		Me.cbEqptTemp.Name = "cbEqptTemp"
		Me.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdUpdate.Text = "Update Account"
		Me.cmdUpdate.Size = New System.Drawing.Size(89, 25)
		Me.cmdUpdate.Location = New System.Drawing.Point(112, 456)
		Me.cmdUpdate.TabIndex = 9
		Me.cmdUpdate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate.CausesValidation = True
		Me.cmdUpdate.Enabled = True
		Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUpdate.TabStop = True
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.ckbAccount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ckbAccount.Text = "Show Inactive Accounts"
		Me.ckbAccount.Size = New System.Drawing.Size(169, 17)
		Me.ckbAccount.Location = New System.Drawing.Point(16, 288)
		Me.ckbAccount.TabIndex = 22
		Me.ckbAccount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbAccount.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckbAccount.BackColor = System.Drawing.SystemColors.Control
		Me.ckbAccount.CausesValidation = True
		Me.ckbAccount.Enabled = True
		Me.ckbAccount.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckbAccount.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckbAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckbAccount.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckbAccount.TabStop = True
		Me.ckbAccount.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ckbAccount.Visible = True
		Me.ckbAccount.Name = "ckbAccount"
		Me.txtStoreNumber.AutoSize = False
		Me.txtStoreNumber.Enabled = False
		Me.txtStoreNumber.Size = New System.Drawing.Size(105, 21)
		Me.txtStoreNumber.Location = New System.Drawing.Point(304, 24)
		Me.txtStoreNumber.ReadOnly = True
		Me.txtStoreNumber.TabIndex = 21
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
		Me.txtCustName.AutoSize = False
		Me.txtCustName.Enabled = False
		Me.txtCustName.Size = New System.Drawing.Size(105, 21)
		Me.txtCustName.Location = New System.Drawing.Point(88, 24)
		Me.txtCustName.ReadOnly = True
		Me.txtCustName.TabIndex = 19
		Me.txtCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustName.AcceptsReturn = True
		Me.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustName.CausesValidation = True
		Me.txtCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustName.HideSelection = True
		Me.txtCustName.Maxlength = 0
		Me.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustName.MultiLine = False
		Me.txtCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustName.TabStop = True
		Me.txtCustName.Visible = True
		Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustName.Name = "txtCustName"
		Me.cbStatus.Size = New System.Drawing.Size(105, 21)
		Me.cbStatus.Location = New System.Drawing.Point(88, 216)
		Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStatus.TabIndex = 5
		Me.cbStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStatus.BackColor = System.Drawing.SystemColors.Window
		Me.cbStatus.CausesValidation = True
		Me.cbStatus.Enabled = True
		Me.cbStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStatus.IntegralHeight = True
		Me.cbStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStatus.Sorted = False
		Me.cbStatus.TabStop = True
		Me.cbStatus.Visible = True
		Me.cbStatus.Name = "cbStatus"
		Me.cbLoadId.Size = New System.Drawing.Size(81, 21)
		Me.cbLoadId.Location = New System.Drawing.Point(208, 152)
		Me.cbLoadId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbLoadId.TabIndex = 16
		Me.cbLoadId.Visible = False
		Me.cbLoadId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbLoadId.BackColor = System.Drawing.SystemColors.Window
		Me.cbLoadId.CausesValidation = True
		Me.cbLoadId.Enabled = True
		Me.cbLoadId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbLoadId.IntegralHeight = True
		Me.cbLoadId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbLoadId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbLoadId.Sorted = False
		Me.cbLoadId.TabStop = True
		Me.cbLoadId.Name = "cbLoadId"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAdd.Text = "Add Account"
		Me.cmdAdd.Size = New System.Drawing.Size(89, 25)
		Me.cmdAdd.Location = New System.Drawing.Point(16, 456)
		Me.cmdAdd.TabIndex = 8
		Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		dgAccountEqpt.OcxState = CType(resources.GetObject("dgAccountEqpt.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgAccountEqpt.Size = New System.Drawing.Size(385, 121)
		Me.dgAccountEqpt.Location = New System.Drawing.Point(16, 320)
		Me.dgAccountEqpt.TabIndex = 7
		Me.dgAccountEqpt.Name = "dgAccountEqpt"
		Me.cbLoadDesc.Size = New System.Drawing.Size(105, 21)
		Me.cbLoadDesc.Location = New System.Drawing.Point(88, 152)
		Me.cbLoadDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbLoadDesc.TabIndex = 3
		Me.cbLoadDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbLoadDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbLoadDesc.CausesValidation = True
		Me.cbLoadDesc.Enabled = True
		Me.cbLoadDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbLoadDesc.IntegralHeight = True
		Me.cbLoadDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbLoadDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbLoadDesc.Sorted = False
		Me.cbLoadDesc.TabStop = True
		Me.cbLoadDesc.Visible = True
		Me.cbLoadDesc.Name = "cbLoadDesc"
		Me.cbContentDesc.Size = New System.Drawing.Size(289, 21)
		Me.cbContentDesc.Location = New System.Drawing.Point(88, 120)
		Me.cbContentDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbContentDesc.TabIndex = 2
		Me.cbContentDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbContentDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbContentDesc.CausesValidation = True
		Me.cbContentDesc.Enabled = True
		Me.cbContentDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbContentDesc.IntegralHeight = True
		Me.cbContentDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbContentDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbContentDesc.Sorted = False
		Me.cbContentDesc.TabStop = True
		Me.cbContentDesc.Visible = True
		Me.cbContentDesc.Name = "cbContentDesc"
		Me.cbEqptDesc.Size = New System.Drawing.Size(105, 21)
		Me.cbEqptDesc.Location = New System.Drawing.Point(88, 56)
		Me.cbEqptDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEqptDesc.TabIndex = 1
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
		Me.txtEqptQty.AutoSize = False
		Me.txtEqptQty.Size = New System.Drawing.Size(105, 21)
		Me.txtEqptQty.Location = New System.Drawing.Point(88, 184)
		Me.txtEqptQty.TabIndex = 4
		Me.txtEqptQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEqptQty.AcceptsReturn = True
		Me.txtEqptQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEqptQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtEqptQty.CausesValidation = True
		Me.txtEqptQty.Enabled = True
		Me.txtEqptQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEqptQty.HideSelection = True
		Me.txtEqptQty.ReadOnly = False
		Me.txtEqptQty.Maxlength = 0
		Me.txtEqptQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEqptQty.MultiLine = False
		Me.txtEqptQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEqptQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEqptQty.TabStop = True
		Me.txtEqptQty.Visible = True
		Me.txtEqptQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEqptQty.Name = "txtEqptQty"
		Me.Label12.Text = "Actual Qty"
		Me.Label12.Size = New System.Drawing.Size(57, 17)
		Me.Label12.Location = New System.Drawing.Point(208, 184)
		Me.Label12.TabIndex = 31
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
		Me.Label11.Text = "Real Capacity"
		Me.Label11.Size = New System.Drawing.Size(73, 17)
		Me.Label11.Location = New System.Drawing.Point(224, 91)
		Me.Label11.TabIndex = 27
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
		Me.Label10.Text = "Capacity"
		Me.Label10.Size = New System.Drawing.Size(49, 17)
		Me.Label10.Location = New System.Drawing.Point(224, 58)
		Me.Label10.TabIndex = 26
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
		Me.Label9.Text = "Description"
		Me.Label9.Size = New System.Drawing.Size(65, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 91)
		Me.Label9.TabIndex = 25
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
		Me.Label8.Text = "Type"
		Me.Label8.Size = New System.Drawing.Size(49, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 258)
		Me.Label8.TabIndex = 23
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
		Me.Label7.Text = "Store"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.Location = New System.Drawing.Point(224, 26)
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
		Me.Label6.Text = "Customer"
		Me.Label6.Size = New System.Drawing.Size(57, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 26)
		Me.Label6.TabIndex = 18
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
		Me.Label5.Text = "Status"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 218)
		Me.Label5.TabIndex = 17
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
		Me.Label4.Text = "Qty"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 186)
		Me.Label4.TabIndex = 15
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
		Me.label3.Text = "Load"
		Me.label3.Size = New System.Drawing.Size(57, 17)
		Me.label3.Location = New System.Drawing.Point(16, 156)
		Me.label3.TabIndex = 14
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
		Me.Label2.Text = "Equipment"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 58)
		Me.Label2.TabIndex = 13
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
		Me.Label1.Text = "Content"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 122)
		Me.Label1.TabIndex = 12
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
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(txtEqptActualQty)
		Me.Frame1.Controls.Add(txtEqptSizeCapacity)
		Me.Frame1.Controls.Add(txtEqptSize)
		Me.Frame1.Controls.Add(txtEqptDesc)
		Me.Frame1.Controls.Add(cbEqptTempDesc)
		Me.Frame1.Controls.Add(cbEqptTemp)
		Me.Frame1.Controls.Add(cmdUpdate)
		Me.Frame1.Controls.Add(ckbAccount)
		Me.Frame1.Controls.Add(txtStoreNumber)
		Me.Frame1.Controls.Add(txtCustName)
		Me.Frame1.Controls.Add(cbStatus)
		Me.Frame1.Controls.Add(cbLoadId)
		Me.Frame1.Controls.Add(cmdAdd)
		Me.Frame1.Controls.Add(dgAccountEqpt)
		Me.Frame1.Controls.Add(cbLoadDesc)
		Me.Frame1.Controls.Add(cbContentDesc)
		Me.Frame1.Controls.Add(cbEqptDesc)
		Me.Frame1.Controls.Add(txtEqptQty)
		Me.Frame1.Controls.Add(Label12)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		CType(Me.dgAccountEqpt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class