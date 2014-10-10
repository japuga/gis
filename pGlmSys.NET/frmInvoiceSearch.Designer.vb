<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInvoiceSearch
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
	Public WithEvents dtStart As AxMSComCtl2.AxDTPicker
	Public WithEvents dtEnd As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents frDates As System.Windows.Forms.GroupBox
	Public WithEvents ckDates As System.Windows.Forms.CheckBox
	Public WithEvents txtInvoice As System.Windows.Forms.TextBox
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtStore As System.Windows.Forms.TextBox
	Public WithEvents cbCustomer As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblInvoice As System.Windows.Forms.Label
	Public WithEvents lblVendor As System.Windows.Forms.Label
	Public WithEvents lblState As System.Windows.Forms.Label
	Public WithEvents lblCustomer As System.Windows.Forms.Label
	Public WithEvents FrmCriteria As System.Windows.Forms.GroupBox
	Public WithEvents FrmSearch As System.Windows.Forms.Panel
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInvoiceSearch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.FrmSearch = New System.Windows.Forms.Panel
		Me.frDates = New System.Windows.Forms.GroupBox
		Me.dtStart = New AxMSComCtl2.AxDTPicker
		Me.dtEnd = New AxMSComCtl2.AxDTPicker
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.FrmCriteria = New System.Windows.Forms.GroupBox
		Me.ckDates = New System.Windows.Forms.CheckBox
		Me.txtInvoice = New System.Windows.Forms.TextBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtStore = New System.Windows.Forms.TextBox
		Me.cbCustomer = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblInvoice = New System.Windows.Forms.Label
		Me.lblVendor = New System.Windows.Forms.Label
		Me.lblState = New System.Windows.Forms.Label
		Me.lblCustomer = New System.Windows.Forms.Label
		Me.FrmSearch.SuspendLayout()
		Me.frDates.SuspendLayout()
		Me.FrmCriteria.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtStart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Invoice Search Crteria"
		Me.ClientSize = New System.Drawing.Size(296, 381)
		Me.Location = New System.Drawing.Point(260, 127)
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
		Me.Name = "frmInvoiceSearch"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdCancel.Size = New System.Drawing.Size(65, 49)
		Me.cmdCancel.Location = New System.Drawing.Point(144, 312)
		Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
		Me.cmdCancel.TabIndex = 10
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOk.Size = New System.Drawing.Size(57, 49)
		Me.cmdOk.Location = New System.Drawing.Point(72, 312)
		Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
		Me.cmdOk.TabIndex = 9
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.FrmSearch.BackColor = System.Drawing.SystemColors.Info
		Me.FrmSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.FrmSearch.Text = "Frame1"
		Me.FrmSearch.Size = New System.Drawing.Size(305, 385)
		Me.FrmSearch.Location = New System.Drawing.Point(-8, 0)
		Me.FrmSearch.TabIndex = 8
		Me.FrmSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrmSearch.Enabled = True
		Me.FrmSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrmSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.FrmSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrmSearch.Visible = True
		Me.FrmSearch.Name = "FrmSearch"
		Me.frDates.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.frDates.Size = New System.Drawing.Size(137, 73)
		Me.frDates.Location = New System.Drawing.Point(88, 208)
		Me.frDates.TabIndex = 17
		Me.frDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frDates.Enabled = True
		Me.frDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frDates.Visible = True
		Me.frDates.Name = "frDates"
		dtStart.OcxState = CType(resources.GetObject("dtStart.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtStart.Size = New System.Drawing.Size(81, 21)
		Me.dtStart.Location = New System.Drawing.Point(40, 16)
		Me.dtStart.TabIndex = 6
		Me.dtStart.Name = "dtStart"
		dtEnd.OcxState = CType(resources.GetObject("dtEnd.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtEnd.Size = New System.Drawing.Size(81, 21)
		Me.dtEnd.Location = New System.Drawing.Point(40, 40)
		Me.dtEnd.TabIndex = 7
		Me.dtEnd.Name = "dtEnd"
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "To:"
		Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label3.Size = New System.Drawing.Size(25, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 40)
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
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label2.BackColor = System.Drawing.SystemColors.Window
		Me.Label2.Text = "From:"
		Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label2.Size = New System.Drawing.Size(25, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 16)
		Me.Label2.TabIndex = 18
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.FrmCriteria.BackColor = System.Drawing.SystemColors.Window
		Me.FrmCriteria.Text = "Criteria"
		Me.FrmCriteria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrmCriteria.ForeColor = System.Drawing.SystemColors.WindowText
		Me.FrmCriteria.Size = New System.Drawing.Size(265, 289)
		Me.FrmCriteria.Location = New System.Drawing.Point(24, 16)
		Me.FrmCriteria.TabIndex = 11
		Me.FrmCriteria.Enabled = True
		Me.FrmCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrmCriteria.Visible = True
		Me.FrmCriteria.Name = "FrmCriteria"
		Me.ckDates.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ckDates.Text = "Dates"
		Me.ckDates.Size = New System.Drawing.Size(57, 17)
		Me.ckDates.Location = New System.Drawing.Point(8, 200)
		Me.ckDates.TabIndex = 5
		Me.ckDates.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ckDates.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckDates.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckDates.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ckDates.CausesValidation = True
		Me.ckDates.Enabled = True
		Me.ckDates.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckDates.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckDates.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckDates.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckDates.TabStop = True
		Me.ckDates.Visible = True
		Me.ckDates.Name = "ckDates"
		Me.txtInvoice.AutoSize = False
		Me.txtInvoice.Size = New System.Drawing.Size(81, 21)
		Me.txtInvoice.Location = New System.Drawing.Point(64, 160)
		Me.txtInvoice.TabIndex = 4
		Me.txtInvoice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvoice.AcceptsReturn = True
		Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtInvoice.BackColor = System.Drawing.SystemColors.Window
		Me.txtInvoice.CausesValidation = True
		Me.txtInvoice.Enabled = True
		Me.txtInvoice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInvoice.HideSelection = True
		Me.txtInvoice.ReadOnly = False
		Me.txtInvoice.Maxlength = 0
		Me.txtInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInvoice.MultiLine = False
		Me.txtInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInvoice.TabStop = True
		Me.txtInvoice.Visible = True
		Me.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInvoice.Name = "txtInvoice"
		Me.cbVendor.Size = New System.Drawing.Size(193, 21)
		Me.cbVendor.Location = New System.Drawing.Point(64, 128)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 3
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
		Me.cbState.Size = New System.Drawing.Size(81, 21)
		Me.cbState.Location = New System.Drawing.Point(64, 64)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 1
		Me.cbState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbState.BackColor = System.Drawing.SystemColors.Window
		Me.cbState.CausesValidation = True
		Me.cbState.Enabled = True
		Me.cbState.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbState.IntegralHeight = True
		Me.cbState.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbState.Sorted = False
		Me.cbState.TabStop = True
		Me.cbState.Visible = True
		Me.cbState.Name = "cbState"
		Me.txtStore.AutoSize = False
		Me.txtStore.Size = New System.Drawing.Size(81, 21)
		Me.txtStore.Location = New System.Drawing.Point(64, 96)
		Me.txtStore.TabIndex = 2
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
		Me.cbCustomer.Size = New System.Drawing.Size(81, 21)
		Me.cbCustomer.Location = New System.Drawing.Point(64, 32)
		Me.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustomer.TabIndex = 0
		Me.cbCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustomer.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustomer.CausesValidation = True
		Me.cbCustomer.Enabled = True
		Me.cbCustomer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustomer.IntegralHeight = True
		Me.cbCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustomer.Sorted = False
		Me.cbCustomer.TabStop = True
		Me.cbCustomer.Visible = True
		Me.cbCustomer.Name = "cbCustomer"
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "Store:"
		Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 96)
		Me.Label1.TabIndex = 16
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblInvoice.BackColor = System.Drawing.SystemColors.Window
		Me.lblInvoice.Text = "Invoice #:"
		Me.lblInvoice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblInvoice.Size = New System.Drawing.Size(49, 17)
		Me.lblInvoice.Location = New System.Drawing.Point(8, 160)
		Me.lblInvoice.TabIndex = 15
		Me.lblInvoice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInvoice.Enabled = True
		Me.lblInvoice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInvoice.UseMnemonic = True
		Me.lblInvoice.Visible = True
		Me.lblInvoice.AutoSize = False
		Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInvoice.Name = "lblInvoice"
		Me.lblVendor.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblVendor.BackColor = System.Drawing.SystemColors.Window
		Me.lblVendor.Text = "Vendor:"
		Me.lblVendor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblVendor.Size = New System.Drawing.Size(41, 17)
		Me.lblVendor.Location = New System.Drawing.Point(16, 128)
		Me.lblVendor.TabIndex = 14
		Me.lblVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVendor.Enabled = True
		Me.lblVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVendor.UseMnemonic = True
		Me.lblVendor.Visible = True
		Me.lblVendor.AutoSize = False
		Me.lblVendor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVendor.Name = "lblVendor"
		Me.lblState.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblState.BackColor = System.Drawing.SystemColors.Window
		Me.lblState.Text = "State:"
		Me.lblState.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblState.Size = New System.Drawing.Size(41, 17)
		Me.lblState.Location = New System.Drawing.Point(16, 64)
		Me.lblState.TabIndex = 13
		Me.lblState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblState.Enabled = True
		Me.lblState.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblState.UseMnemonic = True
		Me.lblState.Visible = True
		Me.lblState.AutoSize = False
		Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblState.Name = "lblState"
		Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblCustomer.BackColor = System.Drawing.SystemColors.Window
		Me.lblCustomer.Text = "Customer:"
		Me.lblCustomer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblCustomer.Size = New System.Drawing.Size(49, 17)
		Me.lblCustomer.Location = New System.Drawing.Point(8, 32)
		Me.lblCustomer.TabIndex = 12
		Me.lblCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCustomer.Enabled = True
		Me.lblCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCustomer.UseMnemonic = True
		Me.lblCustomer.Visible = True
		Me.lblCustomer.AutoSize = False
		Me.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCustomer.Name = "lblCustomer"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(FrmSearch)
		Me.FrmSearch.Controls.Add(frDates)
		Me.FrmSearch.Controls.Add(FrmCriteria)
		Me.frDates.Controls.Add(dtStart)
		Me.frDates.Controls.Add(dtEnd)
		Me.frDates.Controls.Add(Label3)
		Me.frDates.Controls.Add(Label2)
		Me.FrmCriteria.Controls.Add(ckDates)
		Me.FrmCriteria.Controls.Add(txtInvoice)
		Me.FrmCriteria.Controls.Add(cbVendor)
		Me.FrmCriteria.Controls.Add(cbState)
		Me.FrmCriteria.Controls.Add(txtStore)
		Me.FrmCriteria.Controls.Add(cbCustomer)
		Me.FrmCriteria.Controls.Add(Label1)
		Me.FrmCriteria.Controls.Add(lblInvoice)
		Me.FrmCriteria.Controls.Add(lblVendor)
		Me.FrmCriteria.Controls.Add(lblState)
		Me.FrmCriteria.Controls.Add(lblCustomer)
		CType(Me.dtEnd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtStart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FrmSearch.ResumeLayout(False)
		Me.frDates.ResumeLayout(False)
		Me.FrmCriteria.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class