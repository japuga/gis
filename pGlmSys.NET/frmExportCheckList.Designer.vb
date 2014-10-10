<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmExportCheckList
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
	Public WithEvents dgCustCheck As AxMSDataGridLib.AxDataGrid
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents txtTotalAmount As System.Windows.Forms.TextBox
	Public WithEvents txtNumChecks As System.Windows.Forms.TextBox
	Public cdCheckSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents dgCheckList As AxMSDataGridLib.AxDataGrid
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblCustomer As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmExportCheckList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dgCustCheck = New AxMSDataGridLib.AxDataGrid
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.txtTotalAmount = New System.Windows.Forms.TextBox
		Me.txtNumChecks = New System.Windows.Forms.TextBox
		Me.cdCheckSave = New System.Windows.Forms.SaveFileDialog
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.dgCheckList = New AxMSDataGridLib.AxDataGrid
		Me.lblCustomer = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgCustCheck, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgCheckList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Check List "
		Me.ClientSize = New System.Drawing.Size(582, 571)
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
		Me.Name = "frmExportCheckList"
		dgCustCheck.OcxState = CType(resources.GetObject("dgCustCheck.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgCustCheck.Size = New System.Drawing.Size(505, 89)
		Me.dgCustCheck.Location = New System.Drawing.Point(24, 128)
		Me.dgCustCheck.TabIndex = 11
		Me.dgCustCheck.Visible = False
		Me.dgCustCheck.Name = "dgCustCheck"
		Me.cbCustId.Size = New System.Drawing.Size(97, 21)
		Me.cbCustId.Location = New System.Drawing.Point(384, 16)
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
		Me.cbCustName.Size = New System.Drawing.Size(225, 21)
		Me.cbCustName.Location = New System.Drawing.Point(136, 16)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 9
		Me.cbCustName.Visible = False
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
		Me.cbCustName.Name = "cbCustName"
		Me.txtTotalAmount.AutoSize = False
		Me.txtTotalAmount.Enabled = False
		Me.txtTotalAmount.Size = New System.Drawing.Size(81, 21)
		Me.txtTotalAmount.Location = New System.Drawing.Point(136, 88)
		Me.txtTotalAmount.TabIndex = 7
		Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalAmount.AcceptsReturn = True
		Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotalAmount.CausesValidation = True
		Me.txtTotalAmount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotalAmount.HideSelection = True
		Me.txtTotalAmount.ReadOnly = False
		Me.txtTotalAmount.Maxlength = 0
		Me.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotalAmount.MultiLine = False
		Me.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTotalAmount.TabStop = True
		Me.txtTotalAmount.Visible = True
		Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTotalAmount.Name = "txtTotalAmount"
		Me.txtNumChecks.AutoSize = False
		Me.txtNumChecks.Enabled = False
		Me.txtNumChecks.Size = New System.Drawing.Size(41, 21)
		Me.txtNumChecks.Location = New System.Drawing.Point(136, 56)
		Me.txtNumChecks.TabIndex = 6
		Me.txtNumChecks.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumChecks.AcceptsReturn = True
		Me.txtNumChecks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNumChecks.BackColor = System.Drawing.SystemColors.Window
		Me.txtNumChecks.CausesValidation = True
		Me.txtNumChecks.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNumChecks.HideSelection = True
		Me.txtNumChecks.ReadOnly = False
		Me.txtNumChecks.Maxlength = 0
		Me.txtNumChecks.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNumChecks.MultiLine = False
		Me.txtNumChecks.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNumChecks.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNumChecks.TabStop = True
		Me.txtNumChecks.Visible = True
		Me.txtNumChecks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNumChecks.Name = "txtNumChecks"
		Me.Frame1.Text = "Checks to be Exported"
		Me.Frame1.Size = New System.Drawing.Size(505, 337)
		Me.Frame1.Location = New System.Drawing.Point(24, 224)
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
		Me.cmdCancel.Location = New System.Drawing.Point(272, 288)
		Me.cmdCancel.TabIndex = 3
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
		Me.cmdOk.Text = "Export"
		Me.cmdOk.Size = New System.Drawing.Size(57, 33)
		Me.cmdOk.Location = New System.Drawing.Point(184, 288)
		Me.cmdOk.TabIndex = 2
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		dgCheckList.OcxState = CType(resources.GetObject("dgCheckList.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgCheckList.Size = New System.Drawing.Size(473, 249)
		Me.dgCheckList.Location = New System.Drawing.Point(16, 24)
		Me.dgCheckList.TabIndex = 1
		Me.dgCheckList.Name = "dgCheckList"
		Me.lblCustomer.Text = "Customer"
		Me.lblCustomer.Size = New System.Drawing.Size(65, 17)
		Me.lblCustomer.Location = New System.Drawing.Point(24, 16)
		Me.lblCustomer.TabIndex = 8
		Me.lblCustomer.Visible = False
		Me.lblCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCustomer.BackColor = System.Drawing.SystemColors.Control
		Me.lblCustomer.Enabled = True
		Me.lblCustomer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCustomer.UseMnemonic = True
		Me.lblCustomer.AutoSize = False
		Me.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCustomer.Name = "lblCustomer"
		Me.Label2.Text = "Total Amount"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 88)
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
		Me.label1.Text = "Number of Checks"
		Me.label1.Size = New System.Drawing.Size(105, 17)
		Me.label1.Location = New System.Drawing.Point(24, 56)
		Me.label1.TabIndex = 4
		Me.label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label1.BackColor = System.Drawing.SystemColors.Control
		Me.label1.Enabled = True
		Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label1.UseMnemonic = True
		Me.label1.Visible = True
		Me.label1.AutoSize = False
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label1.Name = "label1"
		Me.Controls.Add(dgCustCheck)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(txtTotalAmount)
		Me.Controls.Add(txtNumChecks)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lblCustomer)
		Me.Controls.Add(Label2)
		Me.Controls.Add(label1)
		Me.Frame1.Controls.Add(cmdCancel)
		Me.Frame1.Controls.Add(cmdOk)
		Me.Frame1.Controls.Add(dgCheckList)
		CType(Me.dgCheckList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgCustCheck, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class