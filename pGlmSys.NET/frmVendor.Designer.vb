<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVendor
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
	Public WithEvents dgVendor As AxMSDataGridLib.AxDataGrid
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents lbState As System.Windows.Forms.Label
	Public WithEvents lbVendor As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVendor))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dgVendor = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me.lbState = New System.Windows.Forms.Label
		Me.lbVendor = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgVendor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Vendor Maintenance"
		Me.ClientSize = New System.Drawing.Size(612, 504)
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
		Me.Name = "frmVendor"
		dgVendor.OcxState = CType(resources.GetObject("dgVendor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgVendor.Size = New System.Drawing.Size(569, 385)
		Me.dgVendor.Location = New System.Drawing.Point(16, 104)
		Me.dgVendor.TabIndex = 1
		Me.dgVendor.Name = "dgVendor"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(612, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 0
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button4.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button4.AutoSize = False
		Me._Toolbar1_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button4.ToolTipText = "Print"
		Me._Toolbar1_Button4.Width = 10
		Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lbState.Text = "State"
		Me.lbState.Size = New System.Drawing.Size(177, 25)
		Me.lbState.Location = New System.Drawing.Point(16, 72)
		Me.lbState.TabIndex = 3
		Me.lbState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbState.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbState.BackColor = System.Drawing.SystemColors.Control
		Me.lbState.Enabled = True
		Me.lbState.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbState.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbState.UseMnemonic = True
		Me.lbState.Visible = True
		Me.lbState.AutoSize = False
		Me.lbState.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbState.Name = "lbState"
		Me.lbVendor.Text = "Vendor"
		Me.lbVendor.Size = New System.Drawing.Size(441, 17)
		Me.lbVendor.Location = New System.Drawing.Point(16, 56)
		Me.lbVendor.TabIndex = 2
		Me.lbVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbVendor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbVendor.BackColor = System.Drawing.SystemColors.Control
		Me.lbVendor.Enabled = True
		Me.lbVendor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbVendor.UseMnemonic = True
		Me.lbVendor.Visible = True
		Me.lbVendor.AutoSize = False
		Me.lbVendor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbVendor.Name = "lbVendor"
		Me.Controls.Add(dgVendor)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(lbState)
		Me.Controls.Add(lbVendor)
		Me.Toolbar1.Items.Add(_Toolbar1_Button4)
		CType(Me.dgVendor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class