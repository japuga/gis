<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPeriodEntry
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
	Public WithEvents cbPeriodStatusId As System.Windows.Forms.ComboBox
	Public WithEvents cbPeriodStatusDesc As System.Windows.Forms.ComboBox
	Public WithEvents txtCustName As System.Windows.Forms.TextBox
	Public WithEvents txtPeriodName As System.Windows.Forms.TextBox
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents dtStartDate As AxMSComCtl2.AxDTPicker
	Public WithEvents dtEndDate As AxMSComCtl2.AxDTPicker
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPeriodEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbPeriodStatusId = New System.Windows.Forms.ComboBox
		Me.cbPeriodStatusDesc = New System.Windows.Forms.ComboBox
		Me.txtCustName = New System.Windows.Forms.TextBox
		Me.txtPeriodName = New System.Windows.Forms.TextBox
		Me.cmdOk = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.dtStartDate = New AxMSComCtl2.AxDTPicker
		Me.dtEndDate = New AxMSComCtl2.AxDTPicker
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Period Data Entry"
		Me.ClientSize = New System.Drawing.Size(427, 233)
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
		Me.Name = "frmPeriodEntry"
		Me.cbPeriodStatusId.Size = New System.Drawing.Size(121, 21)
		Me.cbPeriodStatusId.Location = New System.Drawing.Point(264, 136)
		Me.cbPeriodStatusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodStatusId.TabIndex = 13
		Me.cbPeriodStatusId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPeriodStatusId.BackColor = System.Drawing.SystemColors.Window
		Me.cbPeriodStatusId.CausesValidation = True
		Me.cbPeriodStatusId.Enabled = True
		Me.cbPeriodStatusId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbPeriodStatusId.IntegralHeight = True
		Me.cbPeriodStatusId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbPeriodStatusId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbPeriodStatusId.Sorted = False
		Me.cbPeriodStatusId.TabStop = True
		Me.cbPeriodStatusId.Visible = True
		Me.cbPeriodStatusId.Name = "cbPeriodStatusId"
		Me.cbPeriodStatusDesc.Size = New System.Drawing.Size(137, 21)
		Me.cbPeriodStatusDesc.Location = New System.Drawing.Point(104, 136)
		Me.cbPeriodStatusDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPeriodStatusDesc.TabIndex = 12
		Me.cbPeriodStatusDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPeriodStatusDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbPeriodStatusDesc.CausesValidation = True
		Me.cbPeriodStatusDesc.Enabled = True
		Me.cbPeriodStatusDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbPeriodStatusDesc.IntegralHeight = True
		Me.cbPeriodStatusDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbPeriodStatusDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbPeriodStatusDesc.Sorted = False
		Me.cbPeriodStatusDesc.TabStop = True
		Me.cbPeriodStatusDesc.Visible = True
		Me.cbPeriodStatusDesc.Name = "cbPeriodStatusDesc"
		Me.txtCustName.AutoSize = False
		Me.txtCustName.Size = New System.Drawing.Size(121, 19)
		Me.txtCustName.Location = New System.Drawing.Point(104, 8)
		Me.txtCustName.TabIndex = 10
		Me.txtCustName.Text = "Text1"
		Me.txtCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustName.AcceptsReturn = True
		Me.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustName.CausesValidation = True
		Me.txtCustName.Enabled = True
		Me.txtCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustName.HideSelection = True
		Me.txtCustName.ReadOnly = False
		Me.txtCustName.Maxlength = 0
		Me.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustName.MultiLine = False
		Me.txtCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustName.TabStop = True
		Me.txtCustName.Visible = True
		Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustName.Name = "txtCustName"
		Me.txtPeriodName.AutoSize = False
		Me.txtPeriodName.Size = New System.Drawing.Size(185, 21)
		Me.txtPeriodName.Location = New System.Drawing.Point(104, 48)
		Me.txtPeriodName.TabIndex = 3
		Me.txtPeriodName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPeriodName.AcceptsReturn = True
		Me.txtPeriodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPeriodName.BackColor = System.Drawing.SystemColors.Window
		Me.txtPeriodName.CausesValidation = True
		Me.txtPeriodName.Enabled = True
		Me.txtPeriodName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPeriodName.HideSelection = True
		Me.txtPeriodName.ReadOnly = False
		Me.txtPeriodName.Maxlength = 0
		Me.txtPeriodName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPeriodName.MultiLine = False
		Me.txtPeriodName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPeriodName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPeriodName.TabStop = True
		Me.txtPeriodName.Visible = True
		Me.txtPeriodName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPeriodName.Name = "txtPeriodName"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(49, 33)
		Me.cmdOk.Location = New System.Drawing.Point(136, 184)
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
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(49, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(216, 184)
		Me.cmdCancel.TabIndex = 0
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		dtStartDate.OcxState = CType(resources.GetObject("dtStartDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtStartDate.Size = New System.Drawing.Size(89, 23)
		Me.dtStartDate.Location = New System.Drawing.Point(104, 96)
		Me.dtStartDate.TabIndex = 2
		Me.dtStartDate.Name = "dtStartDate"
		dtEndDate.OcxState = CType(resources.GetObject("dtEndDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtEndDate.Size = New System.Drawing.Size(89, 23)
		Me.dtEndDate.Location = New System.Drawing.Point(280, 96)
		Me.dtEndDate.TabIndex = 4
		Me.dtEndDate.Name = "dtEndDate"
		Me.Label6.Text = "Period Status"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(24, 144)
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
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 8)
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
		Me.Label2.Text = "Label2"
		Me.Label2.Size = New System.Drawing.Size(25, 1)
		Me.Label2.Location = New System.Drawing.Point(32, 48)
		Me.Label2.TabIndex = 8
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
		Me.Label3.Text = "Period Name"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 48)
		Me.Label3.TabIndex = 7
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
		Me.Label4.Text = "Start Date"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 96)
		Me.Label4.TabIndex = 6
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
		Me.Label5.Text = "End Date"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(224, 96)
		Me.Label5.TabIndex = 5
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
		Me.Controls.Add(cbPeriodStatusId)
		Me.Controls.Add(cbPeriodStatusDesc)
		Me.Controls.Add(txtCustName)
		Me.Controls.Add(txtPeriodName)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(dtStartDate)
		Me.Controls.Add(dtEndDate)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label5)
		CType(Me.dtEndDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtStartDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class