<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRateSearch
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
	Public WithEvents cbAccountStatus As System.Windows.Forms.ComboBox
	Public WithEvents dgRates As AxMSDataGridLib.AxDataGrid
	Public WithEvents cmdFilter As System.Windows.Forms.Button
	Public WithEvents cbZip As System.Windows.Forms.ComboBox
	Public WithEvents txtCity As System.Windows.Forms.TextBox
	Public WithEvents ckZip As System.Windows.Forms.RadioButton
	Public WithEvents ckStateCity As System.Windows.Forms.RadioButton
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtZip As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbContent As System.Windows.Forms.ComboBox
	Public WithEvents cbEquipment As System.Windows.Forms.ComboBox
	Public WithEvents cbService As System.Windows.Forms.ComboBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRateSearch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbAccountStatus = New System.Windows.Forms.ComboBox
		Me.dgRates = New AxMSDataGridLib.AxDataGrid
		Me.cmdFilter = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cbZip = New System.Windows.Forms.ComboBox
		Me.txtCity = New System.Windows.Forms.TextBox
		Me.ckZip = New System.Windows.Forms.RadioButton
		Me.ckStateCity = New System.Windows.Forms.RadioButton
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtZip = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.cbContent = New System.Windows.Forms.ComboBox
		Me.cbEquipment = New System.Windows.Forms.ComboBox
		Me.cbService = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgRates, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Rate Search"
		Me.ClientSize = New System.Drawing.Size(881, 545)
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
		Me.Name = "frmRateSearch"
		Me.cbAccountStatus.Size = New System.Drawing.Size(265, 21)
		Me.cbAccountStatus.Location = New System.Drawing.Point(88, 144)
		Me.cbAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAccountStatus.TabIndex = 18
		Me.cbAccountStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbAccountStatus.BackColor = System.Drawing.SystemColors.Window
		Me.cbAccountStatus.CausesValidation = True
		Me.cbAccountStatus.Enabled = True
		Me.cbAccountStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbAccountStatus.IntegralHeight = True
		Me.cbAccountStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbAccountStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbAccountStatus.Sorted = False
		Me.cbAccountStatus.TabStop = True
		Me.cbAccountStatus.Visible = True
		Me.cbAccountStatus.Name = "cbAccountStatus"
		dgRates.OcxState = CType(resources.GetObject("dgRates.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgRates.Size = New System.Drawing.Size(857, 305)
		Me.dgRates.Location = New System.Drawing.Point(8, 224)
		Me.dgRates.TabIndex = 16
		Me.dgRates.Name = "dgRates"
		Me.cmdFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFilter.Text = "Apply Filter"
		Me.cmdFilter.Size = New System.Drawing.Size(97, 25)
		Me.cmdFilter.Location = New System.Drawing.Point(96, 184)
		Me.cmdFilter.TabIndex = 15
		Me.cmdFilter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFilter.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFilter.CausesValidation = True
		Me.cmdFilter.Enabled = True
		Me.cmdFilter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFilter.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFilter.TabStop = True
		Me.cmdFilter.Name = "cmdFilter"
		Me.Frame1.Text = "Location"
		Me.Frame1.Size = New System.Drawing.Size(377, 185)
		Me.Frame1.Location = New System.Drawing.Point(440, 24)
		Me.Frame1.TabIndex = 6
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbZip.Size = New System.Drawing.Size(161, 21)
		Me.cbZip.Location = New System.Drawing.Point(104, 144)
		Me.cbZip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbZip.TabIndex = 14
		Me.cbZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbZip.BackColor = System.Drawing.SystemColors.Window
		Me.cbZip.CausesValidation = True
		Me.cbZip.Enabled = True
		Me.cbZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbZip.IntegralHeight = True
		Me.cbZip.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbZip.Sorted = False
		Me.cbZip.TabStop = True
		Me.cbZip.Visible = True
		Me.cbZip.Name = "cbZip"
		Me.txtCity.AutoSize = False
		Me.txtCity.Size = New System.Drawing.Size(241, 21)
		Me.txtCity.Location = New System.Drawing.Point(104, 72)
		Me.txtCity.TabIndex = 12
		Me.txtCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCity.AcceptsReturn = True
		Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtCity.CausesValidation = True
		Me.txtCity.Enabled = True
		Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCity.HideSelection = True
		Me.txtCity.ReadOnly = False
		Me.txtCity.Maxlength = 0
		Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCity.MultiLine = False
		Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCity.TabStop = True
		Me.txtCity.Visible = True
		Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCity.Name = "txtCity"
		Me.ckZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckZip.Text = "By Zip"
		Me.ckZip.Size = New System.Drawing.Size(105, 17)
		Me.ckZip.Location = New System.Drawing.Point(24, 128)
		Me.ckZip.TabIndex = 10
		Me.ckZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckZip.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckZip.BackColor = System.Drawing.SystemColors.Control
		Me.ckZip.CausesValidation = True
		Me.ckZip.Enabled = True
		Me.ckZip.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckZip.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckZip.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckZip.TabStop = True
		Me.ckZip.Checked = False
		Me.ckZip.Visible = True
		Me.ckZip.Name = "ckZip"
		Me.ckStateCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckStateCity.Text = "By State/City"
		Me.ckStateCity.Size = New System.Drawing.Size(89, 17)
		Me.ckStateCity.Location = New System.Drawing.Point(24, 24)
		Me.ckStateCity.TabIndex = 9
		Me.ckStateCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckStateCity.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ckStateCity.BackColor = System.Drawing.SystemColors.Control
		Me.ckStateCity.CausesValidation = True
		Me.ckStateCity.Enabled = True
		Me.ckStateCity.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ckStateCity.Cursor = System.Windows.Forms.Cursors.Default
		Me.ckStateCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ckStateCity.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ckStateCity.TabStop = True
		Me.ckStateCity.Checked = False
		Me.ckStateCity.Visible = True
		Me.ckStateCity.Name = "ckStateCity"
		Me.cbState.Size = New System.Drawing.Size(97, 21)
		Me.cbState.Location = New System.Drawing.Point(104, 48)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 7
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
		Me.txtZip.Text = "Zip"
		Me.txtZip.Size = New System.Drawing.Size(41, 17)
		Me.txtZip.Location = New System.Drawing.Point(64, 152)
		Me.txtZip.TabIndex = 13
		Me.txtZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtZip.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.txtZip.BackColor = System.Drawing.SystemColors.Control
		Me.txtZip.Enabled = True
		Me.txtZip.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txtZip.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtZip.UseMnemonic = True
		Me.txtZip.Visible = True
		Me.txtZip.AutoSize = False
		Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtZip.Name = "txtZip"
		Me.Label5.Text = "City"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(64, 72)
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
		Me.Label1.Text = "State"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(64, 48)
		Me.Label1.TabIndex = 8
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
		Me.cbContent.Size = New System.Drawing.Size(265, 21)
		Me.cbContent.Location = New System.Drawing.Point(88, 104)
		Me.cbContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbContent.TabIndex = 5
		Me.cbContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbContent.BackColor = System.Drawing.SystemColors.Window
		Me.cbContent.CausesValidation = True
		Me.cbContent.Enabled = True
		Me.cbContent.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbContent.IntegralHeight = True
		Me.cbContent.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbContent.Sorted = False
		Me.cbContent.TabStop = True
		Me.cbContent.Visible = True
		Me.cbContent.Name = "cbContent"
		Me.cbEquipment.Size = New System.Drawing.Size(265, 21)
		Me.cbEquipment.Location = New System.Drawing.Point(88, 72)
		Me.cbEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEquipment.TabIndex = 3
		Me.cbEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEquipment.BackColor = System.Drawing.SystemColors.Window
		Me.cbEquipment.CausesValidation = True
		Me.cbEquipment.Enabled = True
		Me.cbEquipment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEquipment.IntegralHeight = True
		Me.cbEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEquipment.Sorted = False
		Me.cbEquipment.TabStop = True
		Me.cbEquipment.Visible = True
		Me.cbEquipment.Name = "cbEquipment"
		Me.cbService.Size = New System.Drawing.Size(265, 21)
		Me.cbService.Location = New System.Drawing.Point(88, 32)
		Me.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbService.TabIndex = 1
		Me.cbService.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbService.BackColor = System.Drawing.SystemColors.Window
		Me.cbService.CausesValidation = True
		Me.cbService.Enabled = True
		Me.cbService.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbService.IntegralHeight = True
		Me.cbService.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbService.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbService.Sorted = False
		Me.cbService.TabStop = True
		Me.cbService.Visible = True
		Me.cbService.Name = "cbService"
		Me.Label6.Text = "Account"
		Me.Label6.Size = New System.Drawing.Size(49, 17)
		Me.Label6.Location = New System.Drawing.Point(24, 144)
		Me.Label6.TabIndex = 17
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
		Me.Label4.Text = "Content"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 104)
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
		Me.Label3.Text = "Equipment"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 72)
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
		Me.Label2.Text = "Service"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 40)
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
		Me.Controls.Add(cbAccountStatus)
		Me.Controls.Add(dgRates)
		Me.Controls.Add(cmdFilter)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cbContent)
		Me.Controls.Add(cbEquipment)
		Me.Controls.Add(cbService)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Frame1.Controls.Add(cbZip)
		Me.Frame1.Controls.Add(txtCity)
		Me.Frame1.Controls.Add(ckZip)
		Me.Frame1.Controls.Add(ckStateCity)
		Me.Frame1.Controls.Add(cbState)
		Me.Frame1.Controls.Add(txtZip)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label1)
		CType(Me.dgRates, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class