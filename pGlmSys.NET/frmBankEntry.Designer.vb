<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBankEntry
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
	Public WithEvents cbQBBankName As System.Windows.Forms.ComboBox
	Public WithEvents cbQBGroupId As System.Windows.Forms.ComboBox
	Public WithEvents cbQBGroupDesc As System.Windows.Forms.ComboBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtLastCheckNo As System.Windows.Forms.TextBox
	Public WithEvents txtBankAccountBalance As System.Windows.Forms.TextBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents txtBankAccount As System.Windows.Forms.TextBox
	Public WithEvents cbBankName As System.Windows.Forms.ComboBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBankEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cbQBBankName = New System.Windows.Forms.ComboBox
		Me.cbQBGroupId = New System.Windows.Forms.ComboBox
		Me.cbQBGroupDesc = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtLastCheckNo = New System.Windows.Forms.TextBox
		Me.txtBankAccountBalance = New System.Windows.Forms.TextBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.txtBankAccount = New System.Windows.Forms.TextBox
		Me.cbBankName = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Bank Data Entry"
		Me.ClientSize = New System.Drawing.Size(362, 383)
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
		Me.Name = "frmBankEntry"
		Me.Frame1.Text = "QuickBooks Info"
		Me.Frame1.Size = New System.Drawing.Size(313, 105)
		Me.Frame1.Location = New System.Drawing.Point(24, 224)
		Me.Frame1.TabIndex = 13
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbQBBankName.Size = New System.Drawing.Size(153, 21)
		Me.cbQBBankName.Location = New System.Drawing.Point(104, 64)
		Me.cbQBBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBBankName.TabIndex = 18
		Me.cbQBBankName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBBankName.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBBankName.CausesValidation = True
		Me.cbQBBankName.Enabled = True
		Me.cbQBBankName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBBankName.IntegralHeight = True
		Me.cbQBBankName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBBankName.Sorted = False
		Me.cbQBBankName.TabStop = True
		Me.cbQBBankName.Visible = True
		Me.cbQBBankName.Name = "cbQBBankName"
		Me.cbQBGroupId.Size = New System.Drawing.Size(41, 21)
		Me.cbQBGroupId.Location = New System.Drawing.Point(272, 24)
		Me.cbQBGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupId.TabIndex = 17
		Me.cbQBGroupId.Visible = False
		Me.cbQBGroupId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBGroupId.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBGroupId.CausesValidation = True
		Me.cbQBGroupId.Enabled = True
		Me.cbQBGroupId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBGroupId.IntegralHeight = True
		Me.cbQBGroupId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBGroupId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBGroupId.Sorted = False
		Me.cbQBGroupId.TabStop = True
		Me.cbQBGroupId.Name = "cbQBGroupId"
		Me.cbQBGroupDesc.Enabled = False
		Me.cbQBGroupDesc.Size = New System.Drawing.Size(153, 21)
		Me.cbQBGroupDesc.Location = New System.Drawing.Point(104, 24)
		Me.cbQBGroupDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupDesc.TabIndex = 16
		Me.cbQBGroupDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBGroupDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBGroupDesc.CausesValidation = True
		Me.cbQBGroupDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBGroupDesc.IntegralHeight = True
		Me.cbQBGroupDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBGroupDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBGroupDesc.Sorted = False
		Me.cbQBGroupDesc.TabStop = True
		Me.cbQBGroupDesc.Visible = True
		Me.cbQBGroupDesc.Name = "cbQBGroupDesc"
		Me.Label7.Text = "Quick Books Bank"
		Me.Label7.Size = New System.Drawing.Size(81, 33)
		Me.Label7.Location = New System.Drawing.Point(16, 64)
		Me.Label7.TabIndex = 15
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
		Me.Label6.Text = "Company Group"
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 24)
		Me.Label6.TabIndex = 14
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
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(192, 336)
		Me.cmdCancel.TabIndex = 12
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
		Me.cmdOk.Location = New System.Drawing.Point(104, 336)
		Me.cmdOk.TabIndex = 11
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtLastCheckNo.AutoSize = False
		Me.txtLastCheckNo.Size = New System.Drawing.Size(97, 21)
		Me.txtLastCheckNo.Location = New System.Drawing.Point(96, 184)
		Me.txtLastCheckNo.TabIndex = 8
		Me.txtLastCheckNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLastCheckNo.AcceptsReturn = True
		Me.txtLastCheckNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLastCheckNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtLastCheckNo.CausesValidation = True
		Me.txtLastCheckNo.Enabled = True
		Me.txtLastCheckNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLastCheckNo.HideSelection = True
		Me.txtLastCheckNo.ReadOnly = False
		Me.txtLastCheckNo.Maxlength = 0
		Me.txtLastCheckNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLastCheckNo.MultiLine = False
		Me.txtLastCheckNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLastCheckNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLastCheckNo.TabStop = True
		Me.txtLastCheckNo.Visible = True
		Me.txtLastCheckNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLastCheckNo.Name = "txtLastCheckNo"
		Me.txtBankAccountBalance.AutoSize = False
		Me.txtBankAccountBalance.Size = New System.Drawing.Size(97, 21)
		Me.txtBankAccountBalance.Location = New System.Drawing.Point(96, 144)
		Me.txtBankAccountBalance.TabIndex = 9
		Me.txtBankAccountBalance.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBankAccountBalance.AcceptsReturn = True
		Me.txtBankAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBankAccountBalance.BackColor = System.Drawing.SystemColors.Window
		Me.txtBankAccountBalance.CausesValidation = True
		Me.txtBankAccountBalance.Enabled = True
		Me.txtBankAccountBalance.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBankAccountBalance.HideSelection = True
		Me.txtBankAccountBalance.ReadOnly = False
		Me.txtBankAccountBalance.Maxlength = 0
		Me.txtBankAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBankAccountBalance.MultiLine = False
		Me.txtBankAccountBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBankAccountBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBankAccountBalance.TabStop = True
		Me.txtBankAccountBalance.Visible = True
		Me.txtBankAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBankAccountBalance.Name = "txtBankAccountBalance"
		Me.cbCustId.Size = New System.Drawing.Size(89, 21)
		Me.cbCustId.Location = New System.Drawing.Point(248, 24)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 10
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
		Me.cbCustName.Size = New System.Drawing.Size(137, 21)
		Me.cbCustName.Location = New System.Drawing.Point(96, 24)
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
		Me.txtBankAccount.AutoSize = False
		Me.txtBankAccount.Size = New System.Drawing.Size(153, 21)
		Me.txtBankAccount.Location = New System.Drawing.Point(96, 104)
		Me.txtBankAccount.TabIndex = 7
		Me.txtBankAccount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBankAccount.AcceptsReturn = True
		Me.txtBankAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBankAccount.BackColor = System.Drawing.SystemColors.Window
		Me.txtBankAccount.CausesValidation = True
		Me.txtBankAccount.Enabled = True
		Me.txtBankAccount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBankAccount.HideSelection = True
		Me.txtBankAccount.ReadOnly = False
		Me.txtBankAccount.Maxlength = 0
		Me.txtBankAccount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBankAccount.MultiLine = False
		Me.txtBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBankAccount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBankAccount.TabStop = True
		Me.txtBankAccount.Visible = True
		Me.txtBankAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBankAccount.Name = "txtBankAccount"
		Me.cbBankName.Size = New System.Drawing.Size(137, 21)
		Me.cbBankName.Location = New System.Drawing.Point(96, 64)
		Me.cbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankName.TabIndex = 5
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
		Me.Label5.Text = "Last Check"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(24, 184)
		Me.Label5.TabIndex = 6
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
		Me.Label4.Text = "Balance"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 144)
		Me.Label4.TabIndex = 4
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
		Me.Label3.Text = "Customer"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 24)
		Me.Label3.TabIndex = 2
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
		Me.Label1.Text = "Bank"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 64)
		Me.Label1.TabIndex = 1
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
		Me.Label2.Text = "Bank Account"
		Me.Label2.Size = New System.Drawing.Size(49, 25)
		Me.Label2.Location = New System.Drawing.Point(24, 104)
		Me.Label2.TabIndex = 0
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
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtLastCheckNo)
		Me.Controls.Add(txtBankAccountBalance)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(txtBankAccount)
		Me.Controls.Add(cbBankName)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		Me.Frame1.Controls.Add(cbQBBankName)
		Me.Frame1.Controls.Add(cbQBGroupId)
		Me.Frame1.Controls.Add(cbQBGroupDesc)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class