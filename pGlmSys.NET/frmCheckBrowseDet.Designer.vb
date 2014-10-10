<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckBrowseDet
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
	Public WithEvents cmdRenumber As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdCLose As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents dgCheckDetail As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgChecks As AxMSDataGridLib.AxDataGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckBrowseDet))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdRenumber = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdCLose = New System.Windows.Forms.Button
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.dgCheckDetail = New AxMSDataGridLib.AxDataGrid
		Me.dgChecks = New AxMSDataGridLib.AxDataGrid
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgCheckDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgChecks, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Check List"
		Me.ClientSize = New System.Drawing.Size(462, 551)
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
		Me.Name = "frmCheckBrowseDet"
		Me.cmdRenumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRenumber.Text = "Renumber"
		Me.cmdRenumber.Size = New System.Drawing.Size(65, 33)
		Me.cmdRenumber.Location = New System.Drawing.Point(56, 504)
		Me.cmdRenumber.TabIndex = 5
		Me.cmdRenumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRenumber.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRenumber.CausesValidation = True
		Me.cmdRenumber.Enabled = True
		Me.cmdRenumber.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRenumber.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRenumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRenumber.TabStop = True
		Me.cmdRenumber.Name = "cmdRenumber"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel Check"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(144, 504)
		Me.cmdCancel.TabIndex = 4
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCLose.Text = "Close"
		Me.cmdCLose.Size = New System.Drawing.Size(65, 33)
		Me.cmdCLose.Location = New System.Drawing.Point(320, 504)
		Me.cmdCLose.TabIndex = 3
		Me.cmdCLose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCLose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCLose.CausesValidation = True
		Me.cmdCLose.Enabled = True
		Me.cmdCLose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCLose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCLose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCLose.TabStop = True
		Me.cmdCLose.Name = "cmdCLose"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrint.Text = "Print / Void"
		Me.cmdPrint.Size = New System.Drawing.Size(65, 33)
		Me.cmdPrint.Location = New System.Drawing.Point(232, 504)
		Me.cmdPrint.TabIndex = 2
		Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		dgCheckDetail.OcxState = CType(resources.GetObject("dgCheckDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgCheckDetail.Size = New System.Drawing.Size(401, 201)
		Me.dgCheckDetail.Location = New System.Drawing.Point(24, 280)
		Me.dgCheckDetail.TabIndex = 1
		Me.dgCheckDetail.Name = "dgCheckDetail"
		dgChecks.OcxState = CType(resources.GetObject("dgChecks.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgChecks.Size = New System.Drawing.Size(393, 225)
		Me.dgChecks.Location = New System.Drawing.Point(24, 24)
		Me.dgChecks.TabIndex = 0
		Me.dgChecks.Name = "dgChecks"
		Me.Controls.Add(cmdRenumber)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdCLose)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(dgCheckDetail)
		Me.Controls.Add(dgChecks)
		CType(Me.dgChecks, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgCheckDetail, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class