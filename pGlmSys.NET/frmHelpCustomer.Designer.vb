<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHelpCustomer
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
	Public WithEvents txtStore As System.Windows.Forms.TextBox
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents txtAccountMask As System.Windows.Forms.TextBox
	Public WithEvents cmdShowAll As System.Windows.Forms.Button
	Public WithEvents cmdFilter As System.Windows.Forms.Button
	Public WithEvents txtStoreAddress As System.Windows.Forms.TextBox
	Public WithEvents txtStoreName As System.Windows.Forms.TextBox
	Public WithEvents txtStoreNumber As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents frStoreFilter As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents dgStore As AxMSDataGridLib.AxDataGrid
	Public WithEvents lRecords As System.Windows.Forms.Label
	Public WithEvents lbMessage As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHelpCustomer))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtStore = New System.Windows.Forms.TextBox
		Me.frStoreFilter = New System.Windows.Forms.GroupBox
		Me.txtVendName = New System.Windows.Forms.TextBox
		Me.txtAccountMask = New System.Windows.Forms.TextBox
		Me.cmdShowAll = New System.Windows.Forms.Button
		Me.cmdFilter = New System.Windows.Forms.Button
		Me.txtStoreAddress = New System.Windows.Forms.TextBox
		Me.txtStoreName = New System.Windows.Forms.TextBox
		Me.txtStoreNumber = New System.Windows.Forms.TextBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.dgStore = New AxMSDataGridLib.AxDataGrid
		Me.lRecords = New System.Windows.Forms.Label
		Me.lbMessage = New System.Windows.Forms.Label
		Me.frStoreFilter.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgStore, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Customer Information"
		Me.ClientSize = New System.Drawing.Size(656, 488)
		Me.Location = New System.Drawing.Point(326, 185)
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
		Me.Name = "frmHelpCustomer"
		Me.txtStore.AutoSize = False
		Me.txtStore.Size = New System.Drawing.Size(233, 21)
		Me.txtStore.Location = New System.Drawing.Point(224, 128)
		Me.txtStore.TabIndex = 13
		Me.txtStore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStore.AcceptsReturn = True
		Me.txtStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStore.BackColor = System.Drawing.SystemColors.Window
		Me.txtStore.CausesValidation = True
		Me.txtStore.Enabled = True
		Me.txtStore.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStore.HideSelection = True
		Me.txtStore.ReadOnly = False
		Me.txtStore.Maxlength = 0
		Me.txtStore.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStore.MultiLine = False
		Me.txtStore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStore.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStore.TabStop = True
		Me.txtStore.Visible = True
		Me.txtStore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStore.Name = "txtStore"
		Me.frStoreFilter.Text = "Store Filters"
		Me.frStoreFilter.Size = New System.Drawing.Size(617, 121)
		Me.frStoreFilter.Location = New System.Drawing.Point(16, 8)
		Me.frStoreFilter.TabIndex = 4
		Me.frStoreFilter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frStoreFilter.BackColor = System.Drawing.SystemColors.Control
		Me.frStoreFilter.Enabled = True
		Me.frStoreFilter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frStoreFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frStoreFilter.Visible = True
		Me.frStoreFilter.Name = "frStoreFilter"
		Me.txtVendName.AutoSize = False
		Me.txtVendName.Size = New System.Drawing.Size(129, 19)
		Me.txtVendName.Location = New System.Drawing.Point(312, 56)
		Me.txtVendName.TabIndex = 18
		Me.txtVendName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendName.AcceptsReturn = True
		Me.txtVendName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendName.CausesValidation = True
		Me.txtVendName.Enabled = True
		Me.txtVendName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendName.HideSelection = True
		Me.txtVendName.ReadOnly = False
		Me.txtVendName.Maxlength = 0
		Me.txtVendName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendName.MultiLine = False
		Me.txtVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendName.TabStop = True
		Me.txtVendName.Visible = True
		Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendName.Name = "txtVendName"
		Me.txtAccountMask.AutoSize = False
		Me.txtAccountMask.Size = New System.Drawing.Size(129, 19)
		Me.txtAccountMask.Location = New System.Drawing.Point(312, 24)
		Me.txtAccountMask.TabIndex = 17
		Me.txtAccountMask.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccountMask.AcceptsReturn = True
		Me.txtAccountMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccountMask.BackColor = System.Drawing.SystemColors.Window
		Me.txtAccountMask.CausesValidation = True
		Me.txtAccountMask.Enabled = True
		Me.txtAccountMask.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccountMask.HideSelection = True
		Me.txtAccountMask.ReadOnly = False
		Me.txtAccountMask.Maxlength = 0
		Me.txtAccountMask.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccountMask.MultiLine = False
		Me.txtAccountMask.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccountMask.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccountMask.TabStop = True
		Me.txtAccountMask.Visible = True
		Me.txtAccountMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccountMask.Name = "txtAccountMask"
		Me.cmdShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdShowAll.Text = "Show All"
		Me.cmdShowAll.Size = New System.Drawing.Size(65, 25)
		Me.cmdShowAll.Location = New System.Drawing.Point(536, 80)
		Me.cmdShowAll.TabIndex = 12
		Me.cmdShowAll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdShowAll.BackColor = System.Drawing.SystemColors.Control
		Me.cmdShowAll.CausesValidation = True
		Me.cmdShowAll.Enabled = True
		Me.cmdShowAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdShowAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdShowAll.TabStop = True
		Me.cmdShowAll.Name = "cmdShowAll"
		Me.cmdFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFilter.Text = "Apply Filter"
		Me.cmdFilter.Size = New System.Drawing.Size(65, 25)
		Me.cmdFilter.Location = New System.Drawing.Point(536, 32)
		Me.cmdFilter.TabIndex = 11
		Me.cmdFilter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFilter.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFilter.CausesValidation = True
		Me.cmdFilter.Enabled = True
		Me.cmdFilter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFilter.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFilter.TabStop = True
		Me.cmdFilter.Name = "cmdFilter"
		Me.txtStoreAddress.AutoSize = False
		Me.txtStoreAddress.Size = New System.Drawing.Size(177, 19)
		Me.txtStoreAddress.Location = New System.Drawing.Point(64, 88)
		Me.txtStoreAddress.TabIndex = 10
		Me.txtStoreAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreAddress.AcceptsReturn = True
		Me.txtStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreAddress.CausesValidation = True
		Me.txtStoreAddress.Enabled = True
		Me.txtStoreAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreAddress.HideSelection = True
		Me.txtStoreAddress.ReadOnly = False
		Me.txtStoreAddress.Maxlength = 0
		Me.txtStoreAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreAddress.MultiLine = False
		Me.txtStoreAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreAddress.TabStop = True
		Me.txtStoreAddress.Visible = True
		Me.txtStoreAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreAddress.Name = "txtStoreAddress"
		Me.txtStoreName.AutoSize = False
		Me.txtStoreName.Size = New System.Drawing.Size(113, 19)
		Me.txtStoreName.Location = New System.Drawing.Point(64, 56)
		Me.txtStoreName.TabIndex = 9
		Me.txtStoreName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreName.AcceptsReturn = True
		Me.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreName.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreName.CausesValidation = True
		Me.txtStoreName.Enabled = True
		Me.txtStoreName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreName.HideSelection = True
		Me.txtStoreName.ReadOnly = False
		Me.txtStoreName.Maxlength = 0
		Me.txtStoreName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreName.MultiLine = False
		Me.txtStoreName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreName.TabStop = True
		Me.txtStoreName.Visible = True
		Me.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreName.Name = "txtStoreName"
		Me.txtStoreNumber.AutoSize = False
		Me.txtStoreNumber.Size = New System.Drawing.Size(89, 19)
		Me.txtStoreNumber.Location = New System.Drawing.Point(64, 24)
		Me.txtStoreNumber.TabIndex = 8
		Me.txtStoreNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreNumber.AcceptsReturn = True
		Me.txtStoreNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreNumber.CausesValidation = True
		Me.txtStoreNumber.Enabled = True
		Me.txtStoreNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreNumber.HideSelection = True
		Me.txtStoreNumber.ReadOnly = False
		Me.txtStoreNumber.Maxlength = 0
		Me.txtStoreNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreNumber.MultiLine = False
		Me.txtStoreNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreNumber.TabStop = True
		Me.txtStoreNumber.Visible = True
		Me.txtStoreNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreNumber.Name = "txtStoreNumber"
		Me.Label5.Text = "Vendor"
		Me.Label5.Size = New System.Drawing.Size(41, 17)
		Me.Label5.Location = New System.Drawing.Point(256, 56)
		Me.Label5.TabIndex = 16
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
		Me.Label1.Text = "Account"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(256, 24)
		Me.Label1.TabIndex = 15
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
		Me.Label4.Text = "Address"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 88)
		Me.Label4.TabIndex = 7
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
		Me.Label3.Text = "Name"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 56)
		Me.Label3.TabIndex = 6
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
		Me.Label2.Text = "Number"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 24)
		Me.Label2.TabIndex = 5
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
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(336, 440)
		Me.cmdCancel.TabIndex = 2
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
		Me.cmdOk.Size = New System.Drawing.Size(57, 33)
		Me.cmdOk.Location = New System.Drawing.Point(256, 440)
		Me.cmdOk.TabIndex = 1
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		dgStore.OcxState = CType(resources.GetObject("dgStore.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgStore.Size = New System.Drawing.Size(617, 241)
		Me.dgStore.Location = New System.Drawing.Point(16, 176)
		Me.dgStore.TabIndex = 0
		Me.dgStore.Name = "dgStore"
		Me.lRecords.Text = "Total Records"
		Me.lRecords.Size = New System.Drawing.Size(121, 17)
		Me.lRecords.Location = New System.Drawing.Point(16, 424)
		Me.lRecords.TabIndex = 14
		Me.lRecords.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lRecords.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lRecords.BackColor = System.Drawing.SystemColors.Control
		Me.lRecords.Enabled = True
		Me.lRecords.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lRecords.Cursor = System.Windows.Forms.Cursors.Default
		Me.lRecords.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lRecords.UseMnemonic = True
		Me.lRecords.Visible = True
		Me.lRecords.AutoSize = False
		Me.lRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lRecords.Name = "lRecords"
		Me.lbMessage.Text = "Please Choose a Store:"
		Me.lbMessage.ForeColor = System.Drawing.Color.Red
		Me.lbMessage.Size = New System.Drawing.Size(169, 17)
		Me.lbMessage.Location = New System.Drawing.Point(16, 136)
		Me.lbMessage.TabIndex = 3
		Me.lbMessage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbMessage.BackColor = System.Drawing.SystemColors.Control
		Me.lbMessage.Enabled = True
		Me.lbMessage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbMessage.UseMnemonic = True
		Me.lbMessage.Visible = True
		Me.lbMessage.AutoSize = False
		Me.lbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbMessage.Name = "lbMessage"
		Me.Controls.Add(txtStore)
		Me.Controls.Add(frStoreFilter)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(dgStore)
		Me.Controls.Add(lRecords)
		Me.Controls.Add(lbMessage)
		Me.frStoreFilter.Controls.Add(txtVendName)
		Me.frStoreFilter.Controls.Add(txtAccountMask)
		Me.frStoreFilter.Controls.Add(cmdShowAll)
		Me.frStoreFilter.Controls.Add(cmdFilter)
		Me.frStoreFilter.Controls.Add(txtStoreAddress)
		Me.frStoreFilter.Controls.Add(txtStoreName)
		Me.frStoreFilter.Controls.Add(txtStoreNumber)
		Me.frStoreFilter.Controls.Add(Label5)
		Me.frStoreFilter.Controls.Add(Label1)
		Me.frStoreFilter.Controls.Add(Label4)
		Me.frStoreFilter.Controls.Add(Label3)
		Me.frStoreFilter.Controls.Add(Label2)
		CType(Me.dgStore, System.ComponentModel.ISupportInitialize).EndInit()
		Me.frStoreFilter.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class