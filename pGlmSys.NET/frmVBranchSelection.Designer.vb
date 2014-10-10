<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVBranchSelection
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
	Public WithEvents cmdLeft As System.Windows.Forms.Button
	Public WithEvents cmdRight As System.Windows.Forms.Button
	Public WithEvents dgVBranch As AxMSDataGridLib.AxDataGrid
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents dgSelVBranch As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVBranchSelection))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.cmdLeft = New System.Windows.Forms.Button
		Me.cmdRight = New System.Windows.Forms.Button
		Me.dgVBranch = New AxMSDataGridLib.AxDataGrid
		Me.txtVendName = New System.Windows.Forms.TextBox
		Me.dgSelVBranch = New AxMSDataGridLib.AxDataGrid
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgVBranch, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSelVBranch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Vendor Branch Selection"
		Me.ClientSize = New System.Drawing.Size(610, 409)
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
		Me.Name = "frmVBranchSelection"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(320, 352)
		Me.cmdCancel.TabIndex = 7
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
		Me.cmdOk.Size = New System.Drawing.Size(57, 33)
		Me.cmdOk.Location = New System.Drawing.Point(232, 352)
		Me.cmdOk.TabIndex = 6
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.cmdLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeft.Text = "<"
		Me.cmdLeft.Size = New System.Drawing.Size(57, 33)
		Me.cmdLeft.Location = New System.Drawing.Point(280, 192)
		Me.cmdLeft.TabIndex = 5
		Me.cmdLeft.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeft.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeft.CausesValidation = True
		Me.cmdLeft.Enabled = True
		Me.cmdLeft.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeft.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeft.TabStop = True
		Me.cmdLeft.Name = "cmdLeft"
		Me.cmdRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRight.Text = ">"
		Me.cmdRight.Size = New System.Drawing.Size(57, 33)
		Me.cmdRight.Location = New System.Drawing.Point(280, 136)
		Me.cmdRight.TabIndex = 4
		Me.cmdRight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRight.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRight.CausesValidation = True
		Me.cmdRight.Enabled = True
		Me.cmdRight.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRight.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRight.TabStop = True
		Me.cmdRight.Name = "cmdRight"
		dgVBranch.OcxState = CType(resources.GetObject("dgVBranch.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgVBranch.Size = New System.Drawing.Size(217, 233)
		Me.dgVBranch.Location = New System.Drawing.Point(32, 72)
		Me.dgVBranch.TabIndex = 2
		Me.dgVBranch.Name = "dgVBranch"
		Me.txtVendName.AutoSize = False
		Me.txtVendName.Size = New System.Drawing.Size(473, 21)
		Me.txtVendName.Location = New System.Drawing.Point(96, 24)
		Me.txtVendName.TabIndex = 1
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
		dgSelVBranch.OcxState = CType(resources.GetObject("dgSelVBranch.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgSelVBranch.Size = New System.Drawing.Size(217, 233)
		Me.dgSelVBranch.Location = New System.Drawing.Point(360, 72)
		Me.dgSelVBranch.TabIndex = 3
		Me.dgSelVBranch.Name = "dgSelVBranch"
		Me.Label1.Text = "Vendor"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 24)
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
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cmdLeft)
		Me.Controls.Add(cmdRight)
		Me.Controls.Add(dgVBranch)
		Me.Controls.Add(txtVendName)
		Me.Controls.Add(dgSelVBranch)
		Me.Controls.Add(Label1)
		CType(Me.dgSelVBranch, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgVBranch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class