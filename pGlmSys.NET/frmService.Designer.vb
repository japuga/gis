<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmService
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
	Public WithEvents dgService As AxMSDataGridLib.AxDataGrid
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmService))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dgService = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgService, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Service Maintenance"
		Me.ClientSize = New System.Drawing.Size(639, 349)
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
		Me.Name = "frmService"
		dgService.OcxState = CType(resources.GetObject("dgService.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgService.Size = New System.Drawing.Size(601, 257)
		Me.dgService.Location = New System.Drawing.Point(16, 72)
		Me.dgService.TabIndex = 1
		Me.dgService.Name = "dgService"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(639, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 0
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button5.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button5.AutoSize = False
		Me._Toolbar1_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button5.ToolTipText = "Print"
		Me._Toolbar1_Button5.Width = 10
		Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Controls.Add(dgService)
		Me.Controls.Add(Toolbar1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		CType(Me.dgService, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class