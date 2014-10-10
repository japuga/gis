<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class tplGridSelector
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
	Public WithEvents dgLeft As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgRight As AxMSDataGridLib.AxDataGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(tplGridSelector))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.cmdLeft = New System.Windows.Forms.Button
		Me.cmdRight = New System.Windows.Forms.Button
		Me.dgLeft = New AxMSDataGridLib.AxDataGrid
		Me.dgRight = New AxMSDataGridLib.AxDataGrid
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgLeft, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgRight, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Member Selector"
		Me.ClientSize = New System.Drawing.Size(638, 432)
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
		Me.Name = "tplGridSelector"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(136, 368)
		Me.cmdCancel.TabIndex = 5
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
		Me.cmdOk.Size = New System.Drawing.Size(73, 33)
		Me.cmdOk.Location = New System.Drawing.Point(24, 368)
		Me.cmdOk.TabIndex = 4
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
		Me.cmdLeft.Size = New System.Drawing.Size(33, 33)
		Me.cmdLeft.Location = New System.Drawing.Point(296, 200)
		Me.cmdLeft.TabIndex = 3
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
		Me.cmdRight.Size = New System.Drawing.Size(33, 33)
		Me.cmdRight.Location = New System.Drawing.Point(296, 136)
		Me.cmdRight.TabIndex = 2
		Me.cmdRight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRight.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRight.CausesValidation = True
		Me.cmdRight.Enabled = True
		Me.cmdRight.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRight.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRight.TabStop = True
		Me.cmdRight.Name = "cmdRight"
		dgLeft.OcxState = CType(resources.GetObject("dgLeft.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgLeft.Size = New System.Drawing.Size(257, 305)
		Me.dgLeft.Location = New System.Drawing.Point(24, 32)
		Me.dgLeft.TabIndex = 0
		Me.dgLeft.Name = "dgLeft"
		dgRight.OcxState = CType(resources.GetObject("dgRight.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgRight.Size = New System.Drawing.Size(257, 305)
		Me.dgRight.Location = New System.Drawing.Point(344, 32)
		Me.dgRight.TabIndex = 1
		Me.dgRight.Name = "dgRight"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cmdLeft)
		Me.Controls.Add(cmdRight)
		Me.Controls.Add(dgLeft)
		Me.Controls.Add(dgRight)
		CType(Me.dgRight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgLeft, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class