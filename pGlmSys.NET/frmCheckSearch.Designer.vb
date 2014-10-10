<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckSearch
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
	Public WithEvents cbAccountNo As System.Windows.Forms.ComboBox
	Public WithEvents cbInvoiceNo As System.Windows.Forms.ComboBox
	Public WithEvents cbAccount As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents dtEnd As AxMSComCtl2.AxDTPicker
	Public WithEvents dtStart As AxMSComCtl2.AxDTPicker
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents frDates As System.Windows.Forms.GroupBox
	Public WithEvents chDates As System.Windows.Forms.CheckBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckSearch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cbAccountNo = New System.Windows.Forms.ComboBox
		Me.cbInvoiceNo = New System.Windows.Forms.ComboBox
		Me.cbAccount = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cmdSearch = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.frDates = New System.Windows.Forms.GroupBox
		Me.dtEnd = New AxMSComCtl2.AxDTPicker
		Me.dtStart = New AxMSComCtl2.AxDTPicker
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.chDates = New System.Windows.Forms.CheckBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.frDates.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtStart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.Info
		Me.Text = "Search Criteria"
		Me.ClientSize = New System.Drawing.Size(416, 438)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
		Me.Name = "frmCheckSearch"
		Me.Frame1.BackColor = System.Drawing.SystemColors.Info
		Me.Frame1.Text = "Search Criteria"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Size = New System.Drawing.Size(385, 425)
		Me.Frame1.Location = New System.Drawing.Point(16, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Frame2.BackColor = System.Drawing.SystemColors.Window
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.ForeColor = System.Drawing.Color.Black
		Me.Frame2.Size = New System.Drawing.Size(353, 393)
		Me.Frame2.Location = New System.Drawing.Point(16, 16)
		Me.Frame2.TabIndex = 1
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.cbAccountNo.Size = New System.Drawing.Size(121, 21)
		Me.cbAccountNo.Location = New System.Drawing.Point(224, 160)
		Me.cbAccountNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAccountNo.TabIndex = 22
		Me.cbAccountNo.Visible = False
		Me.cbAccountNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbAccountNo.BackColor = System.Drawing.SystemColors.Window
		Me.cbAccountNo.CausesValidation = True
		Me.cbAccountNo.Enabled = True
		Me.cbAccountNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbAccountNo.IntegralHeight = True
		Me.cbAccountNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbAccountNo.Sorted = False
		Me.cbAccountNo.TabStop = True
		Me.cbAccountNo.Name = "cbAccountNo"
		Me.cbInvoiceNo.Size = New System.Drawing.Size(233, 21)
		Me.cbInvoiceNo.Location = New System.Drawing.Point(80, 128)
		Me.cbInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbInvoiceNo.TabIndex = 18
		Me.cbInvoiceNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbInvoiceNo.BackColor = System.Drawing.SystemColors.Window
		Me.cbInvoiceNo.CausesValidation = True
		Me.cbInvoiceNo.Enabled = True
		Me.cbInvoiceNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbInvoiceNo.IntegralHeight = True
		Me.cbInvoiceNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbInvoiceNo.Sorted = False
		Me.cbInvoiceNo.TabStop = True
		Me.cbInvoiceNo.Visible = True
		Me.cbInvoiceNo.Name = "cbInvoiceNo"
		Me.cbAccount.Size = New System.Drawing.Size(233, 21)
		Me.cbAccount.Location = New System.Drawing.Point(80, 96)
		Me.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAccount.TabIndex = 16
		Me.cbAccount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbAccount.BackColor = System.Drawing.SystemColors.Window
		Me.cbAccount.CausesValidation = True
		Me.cbAccount.Enabled = True
		Me.cbAccount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbAccount.IntegralHeight = True
		Me.cbAccount.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbAccount.Sorted = False
		Me.cbAccount.TabStop = True
		Me.cbAccount.Visible = True
		Me.cbAccount.Name = "cbAccount"
		Me.cbCustId.Size = New System.Drawing.Size(65, 21)
		Me.cbCustId.Location = New System.Drawing.Point(80, 32)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 12
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
		Me.cbCustId.Visible = True
		Me.cbCustId.Name = "cbCustId"
		Me.cbVendor.Size = New System.Drawing.Size(233, 21)
		Me.cbVendor.Location = New System.Drawing.Point(80, 64)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 11
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
		Me.cbCustName.Size = New System.Drawing.Size(161, 21)
		Me.cbCustName.Location = New System.Drawing.Point(152, 32)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.cbCustName.TabIndex = 10
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
		Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSearch.Text = "Search"
		Me.cmdSearch.Size = New System.Drawing.Size(57, 33)
		Me.cmdSearch.Location = New System.Drawing.Point(120, 312)
		Me.cmdSearch.TabIndex = 9
		Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSearch.CausesValidation = True
		Me.cmdSearch.Enabled = True
		Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSearch.TabStop = True
		Me.cmdSearch.Name = "cmdSearch"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(57, 33)
		Me.cmdClose.Location = New System.Drawing.Point(192, 312)
		Me.cmdClose.TabIndex = 8
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.frDates.BackColor = System.Drawing.Color.White
		Me.frDates.Size = New System.Drawing.Size(225, 73)
		Me.frDates.Location = New System.Drawing.Point(80, 192)
		Me.frDates.TabIndex = 3
		Me.frDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frDates.Enabled = True
		Me.frDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frDates.Visible = True
		Me.frDates.Name = "frDates"
		dtEnd.OcxState = CType(resources.GetObject("dtEnd.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtEnd.Size = New System.Drawing.Size(105, 21)
		Me.dtEnd.Location = New System.Drawing.Point(48, 40)
		Me.dtEnd.TabIndex = 4
		Me.dtEnd.Name = "dtEnd"
		dtStart.OcxState = CType(resources.GetObject("dtStart.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtStart.Size = New System.Drawing.Size(105, 21)
		Me.dtStart.Location = New System.Drawing.Point(48, 16)
		Me.dtStart.TabIndex = 5
		Me.dtStart.Name = "dtStart"
		Me.Label7.BackColor = System.Drawing.Color.White
		Me.Label7.Text = "From"
		Me.Label7.Size = New System.Drawing.Size(33, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 16)
		Me.Label7.TabIndex = 7
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label8.BackColor = System.Drawing.Color.White
		Me.Label8.Text = "To"
		Me.Label8.Size = New System.Drawing.Size(33, 17)
		Me.Label8.Location = New System.Drawing.Point(8, 40)
		Me.Label8.TabIndex = 6
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.chDates.BackColor = System.Drawing.Color.White
		Me.chDates.Text = "Checks Printed on"
		Me.chDates.Size = New System.Drawing.Size(129, 17)
		Me.chDates.Location = New System.Drawing.Point(32, 176)
		Me.chDates.TabIndex = 2
		Me.chDates.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chDates.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chDates.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chDates.CausesValidation = True
		Me.chDates.Enabled = True
		Me.chDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chDates.Cursor = System.Windows.Forms.Cursors.Default
		Me.chDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chDates.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chDates.TabStop = True
		Me.chDates.Visible = True
		Me.chDates.Name = "chDates"
		Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label9.Text = "*** Required Field"
		Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.Red
		Me.Label9.Size = New System.Drawing.Size(105, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 368)
		Me.Label9.TabIndex = 21
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.Enabled = True
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label4.Text = "***"
		Me.Label4.ForeColor = System.Drawing.Color.Red
		Me.Label4.Size = New System.Drawing.Size(17, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 64)
		Me.Label4.TabIndex = 20
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label3.Text = "***"
		Me.Label3.ForeColor = System.Drawing.Color.Red
		Me.Label3.Size = New System.Drawing.Size(17, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 32)
		Me.Label3.TabIndex = 19
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label2.Text = "Account"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(32, 96)
		Me.Label2.TabIndex = 17
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label1.Text = "Invoice"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(32, 128)
		Me.Label1.TabIndex = 15
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "Customer"
		Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(32, 32)
		Me.Label5.TabIndex = 14
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label6.BackColor = System.Drawing.SystemColors.Window
		Me.Label6.Text = "Vendor"
		Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label6.Size = New System.Drawing.Size(49, 17)
		Me.Label6.Location = New System.Drawing.Point(32, 64)
		Me.Label6.TabIndex = 13
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(cbAccountNo)
		Me.Frame2.Controls.Add(cbInvoiceNo)
		Me.Frame2.Controls.Add(cbAccount)
		Me.Frame2.Controls.Add(cbCustId)
		Me.Frame2.Controls.Add(cbVendor)
		Me.Frame2.Controls.Add(cbCustName)
		Me.Frame2.Controls.Add(cmdSearch)
		Me.Frame2.Controls.Add(cmdClose)
		Me.Frame2.Controls.Add(frDates)
		Me.Frame2.Controls.Add(chDates)
		Me.Frame2.Controls.Add(Label9)
		Me.Frame2.Controls.Add(Label4)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame2.Controls.Add(Label5)
		Me.Frame2.Controls.Add(Label6)
		Me.frDates.Controls.Add(dtEnd)
		Me.frDates.Controls.Add(dtStart)
		Me.frDates.Controls.Add(Label7)
		Me.frDates.Controls.Add(Label8)
		CType(Me.dtStart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtEnd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.frDates.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class