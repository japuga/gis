<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmExportCheckExcp
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
	Public WithEvents dgCheckDetail As AxMSDataGridLib.AxDataGrid
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents dgException As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmExportCheckExcp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dgCheckDetail = New AxMSDataGridLib.AxDataGrid
		Me.cmdClose = New System.Windows.Forms.Button
		Me.dgException = New AxMSDataGridLib.AxDataGrid
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgCheckDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgException, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Exception Check List"
		Me.ClientSize = New System.Drawing.Size(677, 505)
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
		Me.Name = "frmExportCheckExcp"
		dgCheckDetail.OcxState = CType(resources.GetObject("dgCheckDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgCheckDetail.Size = New System.Drawing.Size(601, 169)
		Me.dgCheckDetail.Location = New System.Drawing.Point(32, 256)
		Me.dgCheckDetail.TabIndex = 3
		Me.dgCheckDetail.Name = "dgCheckDetail"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(73, 33)
		Me.cmdClose.Location = New System.Drawing.Point(290, 448)
		Me.cmdClose.TabIndex = 2
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		dgException.OcxState = CType(resources.GetObject("dgException.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgException.Size = New System.Drawing.Size(601, 177)
		Me.dgException.Location = New System.Drawing.Point(32, 32)
		Me.dgException.TabIndex = 1
		Me.dgException.Name = "dgException"
		Me.Label1.Text = "Export process failed due to duplicate Checks found:"
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Red
		Me.Label1.Size = New System.Drawing.Size(361, 17)
		Me.Label1.Location = New System.Drawing.Point(32, 8)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(dgCheckDetail)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(dgException)
		Me.Controls.Add(Label1)
		CType(Me.dgException, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgCheckDetail, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class