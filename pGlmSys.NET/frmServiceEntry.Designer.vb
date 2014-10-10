<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmServiceEntry
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
	Public WithEvents cbServDescConversion As System.Windows.Forms.ComboBox
	Public WithEvents cbServUnitDesc As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cbServFrequency As System.Windows.Forms.ComboBox
	Public WithEvents cbServClass As System.Windows.Forms.ComboBox
	Public WithEvents cbServMeasureUnit As System.Windows.Forms.ComboBox
	Public WithEvents cbServRateContract As System.Windows.Forms.ComboBox
	Public WithEvents txtServDesc As System.Windows.Forms.TextBox
	Public WithEvents cbServCredit As System.Windows.Forms.ComboBox
	Public WithEvents cbServEqpt As System.Windows.Forms.ComboBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmServiceEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbServDescConversion = New System.Windows.Forms.ComboBox
		Me.cbServUnitDesc = New System.Windows.Forms.ComboBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.cbServFrequency = New System.Windows.Forms.ComboBox
		Me.cbServClass = New System.Windows.Forms.ComboBox
		Me.cbServMeasureUnit = New System.Windows.Forms.ComboBox
		Me.cbServRateContract = New System.Windows.Forms.ComboBox
		Me.txtServDesc = New System.Windows.Forms.TextBox
		Me.cbServCredit = New System.Windows.Forms.ComboBox
		Me.cbServEqpt = New System.Windows.Forms.ComboBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Service Entry"
		Me.ClientSize = New System.Drawing.Size(319, 344)
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
		Me.Name = "frmServiceEntry"
		Me.cbServDescConversion.Size = New System.Drawing.Size(177, 21)
		Me.cbServDescConversion.Location = New System.Drawing.Point(128, 224)
		Me.cbServDescConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServDescConversion.TabIndex = 17
		Me.cbServDescConversion.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServDescConversion.BackColor = System.Drawing.SystemColors.Window
		Me.cbServDescConversion.CausesValidation = True
		Me.cbServDescConversion.Enabled = True
		Me.cbServDescConversion.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServDescConversion.IntegralHeight = True
		Me.cbServDescConversion.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServDescConversion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServDescConversion.Sorted = False
		Me.cbServDescConversion.TabStop = True
		Me.cbServDescConversion.Visible = True
		Me.cbServDescConversion.Name = "cbServDescConversion"
		Me.cbServUnitDesc.Size = New System.Drawing.Size(153, 21)
		Me.cbServUnitDesc.Location = New System.Drawing.Point(128, 88)
		Me.cbServUnitDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServUnitDesc.TabIndex = 16
		Me.cbServUnitDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServUnitDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbServUnitDesc.CausesValidation = True
		Me.cbServUnitDesc.Enabled = True
		Me.cbServUnitDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServUnitDesc.IntegralHeight = True
		Me.cbServUnitDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServUnitDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServUnitDesc.Sorted = False
		Me.cbServUnitDesc.TabStop = True
		Me.cbServUnitDesc.Visible = True
		Me.cbServUnitDesc.Name = "cbServUnitDesc"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(176, 296)
		Me.cmdCancel.TabIndex = 9
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
		Me.cmdOk.Location = New System.Drawing.Point(80, 296)
		Me.cmdOk.TabIndex = 8
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.cbServFrequency.Size = New System.Drawing.Size(73, 21)
		Me.cbServFrequency.Location = New System.Drawing.Point(128, 152)
		Me.cbServFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServFrequency.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.cbServFrequency, "Must a frequency be set for this service")
		Me.cbServFrequency.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServFrequency.BackColor = System.Drawing.SystemColors.Window
		Me.cbServFrequency.CausesValidation = True
		Me.cbServFrequency.Enabled = True
		Me.cbServFrequency.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServFrequency.IntegralHeight = True
		Me.cbServFrequency.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServFrequency.Sorted = False
		Me.cbServFrequency.TabStop = True
		Me.cbServFrequency.Visible = True
		Me.cbServFrequency.Name = "cbServFrequency"
		Me.cbServClass.Size = New System.Drawing.Size(113, 21)
		Me.cbServClass.Location = New System.Drawing.Point(128, 120)
		Me.cbServClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServClass.TabIndex = 4
		Me.cbServClass.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServClass.BackColor = System.Drawing.SystemColors.Window
		Me.cbServClass.CausesValidation = True
		Me.cbServClass.Enabled = True
		Me.cbServClass.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServClass.IntegralHeight = True
		Me.cbServClass.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServClass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServClass.Sorted = False
		Me.cbServClass.TabStop = True
		Me.cbServClass.Visible = True
		Me.cbServClass.Name = "cbServClass"
		Me.cbServMeasureUnit.Size = New System.Drawing.Size(57, 21)
		Me.cbServMeasureUnit.Location = New System.Drawing.Point(264, 288)
		Me.cbServMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServMeasureUnit.TabIndex = 3
		Me.cbServMeasureUnit.Visible = False
		Me.cbServMeasureUnit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServMeasureUnit.BackColor = System.Drawing.SystemColors.Window
		Me.cbServMeasureUnit.CausesValidation = True
		Me.cbServMeasureUnit.Enabled = True
		Me.cbServMeasureUnit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServMeasureUnit.IntegralHeight = True
		Me.cbServMeasureUnit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServMeasureUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServMeasureUnit.Sorted = False
		Me.cbServMeasureUnit.TabStop = True
		Me.cbServMeasureUnit.Name = "cbServMeasureUnit"
		Me.cbServRateContract.Size = New System.Drawing.Size(73, 21)
		Me.cbServRateContract.Location = New System.Drawing.Point(128, 264)
		Me.cbServRateContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServRateContract.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.cbServRateContract, "Benchmark Rate must be set on a Contract?")
		Me.cbServRateContract.Visible = False
		Me.cbServRateContract.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServRateContract.BackColor = System.Drawing.SystemColors.Window
		Me.cbServRateContract.CausesValidation = True
		Me.cbServRateContract.Enabled = True
		Me.cbServRateContract.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServRateContract.IntegralHeight = True
		Me.cbServRateContract.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServRateContract.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServRateContract.Sorted = False
		Me.cbServRateContract.TabStop = True
		Me.cbServRateContract.Name = "cbServRateContract"
		Me.txtServDesc.AutoSize = False
		Me.txtServDesc.Size = New System.Drawing.Size(169, 19)
		Me.txtServDesc.Location = New System.Drawing.Point(128, 24)
		Me.txtServDesc.TabIndex = 1
		Me.txtServDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtServDesc.AcceptsReturn = True
		Me.txtServDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtServDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtServDesc.CausesValidation = True
		Me.txtServDesc.Enabled = True
		Me.txtServDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtServDesc.HideSelection = True
		Me.txtServDesc.ReadOnly = False
		Me.txtServDesc.Maxlength = 0
		Me.txtServDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtServDesc.MultiLine = False
		Me.txtServDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtServDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtServDesc.TabStop = True
		Me.txtServDesc.Visible = True
		Me.txtServDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtServDesc.Name = "txtServDesc"
		Me.cbServCredit.Size = New System.Drawing.Size(73, 21)
		Me.cbServCredit.Location = New System.Drawing.Point(128, 56)
		Me.cbServCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServCredit.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.cbServCredit, "Service is a Credit or Debit")
		Me.cbServCredit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServCredit.BackColor = System.Drawing.SystemColors.Window
		Me.cbServCredit.CausesValidation = True
		Me.cbServCredit.Enabled = True
		Me.cbServCredit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServCredit.IntegralHeight = True
		Me.cbServCredit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServCredit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServCredit.Sorted = False
		Me.cbServCredit.TabStop = True
		Me.cbServCredit.Visible = True
		Me.cbServCredit.Name = "cbServCredit"
		Me.cbServEqpt.Size = New System.Drawing.Size(73, 21)
		Me.cbServEqpt.Location = New System.Drawing.Point(128, 184)
		Me.cbServEqpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServEqpt.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.cbServEqpt, "This service just applies to equipments")
		Me.cbServEqpt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServEqpt.BackColor = System.Drawing.SystemColors.Window
		Me.cbServEqpt.CausesValidation = True
		Me.cbServEqpt.Enabled = True
		Me.cbServEqpt.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServEqpt.IntegralHeight = True
		Me.cbServEqpt.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServEqpt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServEqpt.Sorted = False
		Me.cbServEqpt.TabStop = True
		Me.cbServEqpt.Visible = True
		Me.cbServEqpt.Name = "cbServEqpt"
		Me.Label8.Text = "Service for Conversion Units"
		Me.Label8.Size = New System.Drawing.Size(105, 25)
		Me.Label8.Location = New System.Drawing.Point(16, 224)
		Me.Label8.TabIndex = 18
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
		Me.Label7.Text = "Frequency Required"
		Me.Label7.Size = New System.Drawing.Size(97, 17)
		Me.Label7.Location = New System.Drawing.Point(16, 154)
		Me.Label7.TabIndex = 15
		Me.ToolTip1.SetToolTip(Me.Label7, "Must a frequency be set for this service")
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
		Me.Label6.Text = "Service Class"
		Me.Label6.Size = New System.Drawing.Size(73, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 122)
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
		Me.Label5.Text = "Measure Unit"
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 90)
		Me.Label5.TabIndex = 13
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
		Me.Label4.Text = "Contract Rated"
		Me.Label4.Size = New System.Drawing.Size(97, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 264)
		Me.Label4.TabIndex = 12
		Me.ToolTip1.SetToolTip(Me.Label4, "Benchmark Rate must be set on a Contract?")
		Me.Label4.Visible = False
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Invoice Behavior"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 58)
		Me.Label3.TabIndex = 11
		Me.ToolTip1.SetToolTip(Me.Label3, "Service is a Credit or Debit")
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
		Me.Label2.Text = "Equipment Required"
		Me.Label2.Size = New System.Drawing.Size(105, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 186)
		Me.Label2.TabIndex = 10
		Me.ToolTip1.SetToolTip(Me.Label2, "This service just applies to equipments")
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
		Me.Label1.Text = "Service Name"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 25)
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
		Me.Controls.Add(cbServDescConversion)
		Me.Controls.Add(cbServUnitDesc)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cbServFrequency)
		Me.Controls.Add(cbServClass)
		Me.Controls.Add(cbServMeasureUnit)
		Me.Controls.Add(cbServRateContract)
		Me.Controls.Add(txtServDesc)
		Me.Controls.Add(cbServCredit)
		Me.Controls.Add(cbServEqpt)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class