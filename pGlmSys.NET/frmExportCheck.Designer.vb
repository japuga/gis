<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmExportCheck
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
	Public WithEvents chExported As System.Windows.Forms.CheckBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents frVendor As System.Windows.Forms.GroupBox
	Public WithEvents cbBankAccount As System.Windows.Forms.ComboBox
	Public WithEvents cbBankName As System.Windows.Forms.ComboBox
	Public WithEvents txtCheckTo As System.Windows.Forms.TextBox
	Public WithEvents txtCheckFrom As System.Windows.Forms.TextBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents frCheckRange As System.Windows.Forms.GroupBox
	Public WithEvents dtTo As AxMSComCtl2.AxDTPicker
	Public WithEvents dtFrom As AxMSComCtl2.AxDTPicker
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents frDateRange As System.Windows.Forms.GroupBox
	Public WithEvents radioVendor As System.Windows.Forms.RadioButton
	Public WithEvents radioCheckRange As System.Windows.Forms.RadioButton
	Public WithEvents radioDateRange As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmExportCheck))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.chExported = New System.Windows.Forms.CheckBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.frVendor = New System.Windows.Forms.GroupBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.frCheckRange = New System.Windows.Forms.GroupBox
		Me.cbBankAccount = New System.Windows.Forms.ComboBox
		Me.cbBankName = New System.Windows.Forms.ComboBox
		Me.txtCheckTo = New System.Windows.Forms.TextBox
		Me.txtCheckFrom = New System.Windows.Forms.TextBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.frDateRange = New System.Windows.Forms.GroupBox
		Me.dtTo = New AxMSComCtl2.AxDTPicker
		Me.dtFrom = New AxMSComCtl2.AxDTPicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.radioVendor = New System.Windows.Forms.RadioButton
		Me.radioCheckRange = New System.Windows.Forms.RadioButton
		Me.radioDateRange = New System.Windows.Forms.RadioButton
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.frVendor.SuspendLayout()
		Me.frCheckRange.SuspendLayout()
		Me.frDateRange.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtTo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Check Selection Criteria"
		Me.ClientSize = New System.Drawing.Size(430, 543)
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
		Me.Name = "frmExportCheck"
		Me.chExported.Text = "Show already extracted Checks"
		Me.chExported.Size = New System.Drawing.Size(233, 17)
		Me.chExported.Location = New System.Drawing.Point(136, 48)
		Me.chExported.TabIndex = 22
		Me.chExported.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chExported.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chExported.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chExported.BackColor = System.Drawing.SystemColors.Control
		Me.chExported.CausesValidation = True
		Me.chExported.Enabled = True
		Me.chExported.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chExported.Cursor = System.Windows.Forms.Cursors.Default
		Me.chExported.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chExported.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chExported.TabStop = True
		Me.chExported.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chExported.Visible = True
		Me.chExported.Name = "chExported"
		Me.cbCustId.Size = New System.Drawing.Size(57, 21)
		Me.cbCustId.Location = New System.Drawing.Point(336, 16)
		Me.cbCustId.TabIndex = 21
		Me.cbCustId.Text = "Combo2"
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
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cbCustId.TabStop = True
		Me.cbCustId.Name = "cbCustId"
		Me.cbCustName.Size = New System.Drawing.Size(193, 21)
		Me.cbCustName.Location = New System.Drawing.Point(136, 16)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 20
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
		Me.Frame1.Text = "Choose Criteria"
		Me.Frame1.Size = New System.Drawing.Size(369, 457)
		Me.Frame1.Location = New System.Drawing.Point(24, 72)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(200, 416)
		Me.cmdCancel.TabIndex = 8
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
		Me.cmdOk.Location = New System.Drawing.Point(104, 416)
		Me.cmdOk.TabIndex = 7
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.frVendor.Size = New System.Drawing.Size(297, 49)
		Me.frVendor.Location = New System.Drawing.Point(32, 360)
		Me.frVendor.TabIndex = 6
		Me.frVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frVendor.BackColor = System.Drawing.SystemColors.Control
		Me.frVendor.Enabled = True
		Me.frVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frVendor.Visible = True
		Me.frVendor.Name = "frVendor"
		Me.cbVendor.Size = New System.Drawing.Size(233, 21)
		Me.cbVendor.Location = New System.Drawing.Point(56, 16)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 17
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
		Me.Label5.Text = "Name"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 16)
		Me.Label5.TabIndex = 18
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
		Me.frCheckRange.Size = New System.Drawing.Size(297, 153)
		Me.frCheckRange.Location = New System.Drawing.Point(32, 176)
		Me.frCheckRange.TabIndex = 5
		Me.frCheckRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frCheckRange.BackColor = System.Drawing.SystemColors.Control
		Me.frCheckRange.Enabled = True
		Me.frCheckRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frCheckRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frCheckRange.Visible = True
		Me.frCheckRange.Name = "frCheckRange"
		Me.cbBankAccount.Size = New System.Drawing.Size(145, 21)
		Me.cbBankAccount.Location = New System.Drawing.Point(80, 48)
		Me.cbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankAccount.TabIndex = 26
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
		Me.cbBankName.Size = New System.Drawing.Size(121, 21)
		Me.cbBankName.Location = New System.Drawing.Point(80, 16)
		Me.cbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBankName.TabIndex = 25
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
		Me.txtCheckTo.AutoSize = False
		Me.txtCheckTo.Size = New System.Drawing.Size(73, 19)
		Me.txtCheckTo.Location = New System.Drawing.Point(144, 120)
		Me.txtCheckTo.Maxlength = 10
		Me.txtCheckTo.TabIndex = 16
		Me.txtCheckTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCheckTo.AcceptsReturn = True
		Me.txtCheckTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCheckTo.BackColor = System.Drawing.SystemColors.Window
		Me.txtCheckTo.CausesValidation = True
		Me.txtCheckTo.Enabled = True
		Me.txtCheckTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCheckTo.HideSelection = True
		Me.txtCheckTo.ReadOnly = False
		Me.txtCheckTo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCheckTo.MultiLine = False
		Me.txtCheckTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCheckTo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCheckTo.TabStop = True
		Me.txtCheckTo.Visible = True
		Me.txtCheckTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCheckTo.Name = "txtCheckTo"
		Me.txtCheckFrom.AutoSize = False
		Me.txtCheckFrom.Size = New System.Drawing.Size(73, 19)
		Me.txtCheckFrom.Location = New System.Drawing.Point(144, 88)
		Me.txtCheckFrom.Maxlength = 10
		Me.txtCheckFrom.TabIndex = 15
		Me.txtCheckFrom.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCheckFrom.AcceptsReturn = True
		Me.txtCheckFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCheckFrom.BackColor = System.Drawing.SystemColors.Window
		Me.txtCheckFrom.CausesValidation = True
		Me.txtCheckFrom.Enabled = True
		Me.txtCheckFrom.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCheckFrom.HideSelection = True
		Me.txtCheckFrom.ReadOnly = False
		Me.txtCheckFrom.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCheckFrom.MultiLine = False
		Me.txtCheckFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCheckFrom.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCheckFrom.TabStop = True
		Me.txtCheckFrom.Visible = True
		Me.txtCheckFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCheckFrom.Name = "txtCheckFrom"
		Me.Label8.Text = "Account"
		Me.Label8.Size = New System.Drawing.Size(49, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 48)
		Me.Label8.TabIndex = 24
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
		Me.Label7.Text = "Bank"
		Me.Label7.Size = New System.Drawing.Size(49, 17)
		Me.Label7.Location = New System.Drawing.Point(16, 16)
		Me.Label7.TabIndex = 23
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
		Me.Label4.Text = "To Check"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(80, 120)
		Me.Label4.TabIndex = 14
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
		Me.Label3.Text = "From Check"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(80, 88)
		Me.Label3.TabIndex = 13
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
		Me.frDateRange.Size = New System.Drawing.Size(297, 97)
		Me.frDateRange.Location = New System.Drawing.Point(32, 48)
		Me.frDateRange.TabIndex = 4
		Me.frDateRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frDateRange.BackColor = System.Drawing.SystemColors.Control
		Me.frDateRange.Enabled = True
		Me.frDateRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frDateRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frDateRange.Visible = True
		Me.frDateRange.Name = "frDateRange"
		dtTo.OcxState = CType(resources.GetObject("dtTo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtTo.Size = New System.Drawing.Size(94, 23)
		Me.dtTo.Location = New System.Drawing.Point(56, 56)
		Me.dtTo.TabIndex = 12
		Me.dtTo.Name = "dtTo"
		dtFrom.OcxState = CType(resources.GetObject("dtFrom.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtFrom.Size = New System.Drawing.Size(94, 23)
		Me.dtFrom.Location = New System.Drawing.Point(56, 16)
		Me.dtFrom.TabIndex = 11
		Me.dtFrom.Name = "dtFrom"
		Me.Label2.Text = "To"
		Me.Label2.Size = New System.Drawing.Size(25, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 56)
		Me.Label2.TabIndex = 10
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
		Me.Label1.Text = "From"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.TabIndex = 9
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
		Me.radioVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.radioVendor.Text = "Vendor"
		Me.radioVendor.Size = New System.Drawing.Size(57, 25)
		Me.radioVendor.Location = New System.Drawing.Point(16, 336)
		Me.radioVendor.TabIndex = 3
		Me.radioVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.radioVendor.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.radioVendor.BackColor = System.Drawing.SystemColors.Control
		Me.radioVendor.CausesValidation = True
		Me.radioVendor.Enabled = True
		Me.radioVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.radioVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.radioVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.radioVendor.Appearance = System.Windows.Forms.Appearance.Normal
		Me.radioVendor.TabStop = True
		Me.radioVendor.Checked = False
		Me.radioVendor.Visible = True
		Me.radioVendor.Name = "radioVendor"
		Me.radioCheckRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.radioCheckRange.Text = "Check Number Range"
		Me.radioCheckRange.Size = New System.Drawing.Size(153, 33)
		Me.radioCheckRange.Location = New System.Drawing.Point(16, 152)
		Me.radioCheckRange.TabIndex = 2
		Me.radioCheckRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.radioCheckRange.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.radioCheckRange.BackColor = System.Drawing.SystemColors.Control
		Me.radioCheckRange.CausesValidation = True
		Me.radioCheckRange.Enabled = True
		Me.radioCheckRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.radioCheckRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.radioCheckRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.radioCheckRange.Appearance = System.Windows.Forms.Appearance.Normal
		Me.radioCheckRange.TabStop = True
		Me.radioCheckRange.Checked = False
		Me.radioCheckRange.Visible = True
		Me.radioCheckRange.Name = "radioCheckRange"
		Me.radioDateRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.radioDateRange.Text = "Checks Date Range"
		Me.radioDateRange.Size = New System.Drawing.Size(193, 25)
		Me.radioDateRange.Location = New System.Drawing.Point(16, 24)
		Me.radioDateRange.TabIndex = 1
		Me.radioDateRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.radioDateRange.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.radioDateRange.BackColor = System.Drawing.SystemColors.Control
		Me.radioDateRange.CausesValidation = True
		Me.radioDateRange.Enabled = True
		Me.radioDateRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.radioDateRange.Cursor = System.Windows.Forms.Cursors.Default
		Me.radioDateRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.radioDateRange.Appearance = System.Windows.Forms.Appearance.Normal
		Me.radioDateRange.TabStop = True
		Me.radioDateRange.Checked = False
		Me.radioDateRange.Visible = True
		Me.radioDateRange.Name = "radioDateRange"
		Me.Label6.Text = "Customer"
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.Location = New System.Drawing.Point(32, 16)
		Me.Label6.TabIndex = 19
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
		Me.Controls.Add(chExported)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Label6)
		Me.Frame1.Controls.Add(cmdCancel)
		Me.Frame1.Controls.Add(cmdOk)
		Me.Frame1.Controls.Add(frVendor)
		Me.Frame1.Controls.Add(frCheckRange)
		Me.Frame1.Controls.Add(frDateRange)
		Me.Frame1.Controls.Add(radioVendor)
		Me.Frame1.Controls.Add(radioCheckRange)
		Me.Frame1.Controls.Add(radioDateRange)
		Me.frVendor.Controls.Add(cbVendor)
		Me.frVendor.Controls.Add(Label5)
		Me.frCheckRange.Controls.Add(cbBankAccount)
		Me.frCheckRange.Controls.Add(cbBankName)
		Me.frCheckRange.Controls.Add(txtCheckTo)
		Me.frCheckRange.Controls.Add(txtCheckFrom)
		Me.frCheckRange.Controls.Add(Label8)
		Me.frCheckRange.Controls.Add(Label7)
		Me.frCheckRange.Controls.Add(Label4)
		Me.frCheckRange.Controls.Add(Label3)
		Me.frDateRange.Controls.Add(dtTo)
		Me.frDateRange.Controls.Add(dtFrom)
		Me.frDateRange.Controls.Add(Label2)
		Me.frDateRange.Controls.Add(Label1)
		CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtTo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.frVendor.ResumeLayout(False)
		Me.frCheckRange.ResumeLayout(False)
		Me.frDateRange.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class