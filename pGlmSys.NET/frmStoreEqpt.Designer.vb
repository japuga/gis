<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmStoreEqpt
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
	Public WithEvents dgStoreEqpt As AxMSDataGridLib.AxDataGrid
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents dgStore As AxMSDataGridLib.AxDataGrid
	Public WithEvents lbEquipment As System.Windows.Forms.Label
	Public WithEvents lbCustomer As System.Windows.Forms.Label
	Public WithEvents lbState As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStoreEqpt))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dgStoreEqpt = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me.dgStore = New AxMSDataGridLib.AxDataGrid
		Me.lbEquipment = New System.Windows.Forms.Label
		Me.lbCustomer = New System.Windows.Forms.Label
		Me.lbState = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgStoreEqpt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgStore, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Equipment Assigned to Store"
		Me.ClientSize = New System.Drawing.Size(549, 550)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmStoreEqpt"
		dgStoreEqpt.OcxState = CType(resources.GetObject("dgStoreEqpt.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgStoreEqpt.Size = New System.Drawing.Size(497, 193)
		Me.dgStoreEqpt.Location = New System.Drawing.Point(24, 328)
		Me.dgStoreEqpt.TabIndex = 5
		Me.dgStoreEqpt.Name = "dgStoreEqpt"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(549, 44)
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
		dgStore.OcxState = CType(resources.GetObject("dgStore.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgStore.Size = New System.Drawing.Size(505, 169)
		Me.dgStore.Location = New System.Drawing.Point(16, 88)
		Me.dgStore.TabIndex = 1
		Me.dgStore.Name = "dgStore"
		Me.lbEquipment.Text = "Equipment"
		Me.lbEquipment.ForeColor = System.Drawing.Color.Red
		Me.lbEquipment.Size = New System.Drawing.Size(465, 17)
		Me.lbEquipment.Location = New System.Drawing.Point(24, 296)
		Me.lbEquipment.TabIndex = 4
		Me.lbEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbEquipment.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbEquipment.BackColor = System.Drawing.SystemColors.Control
		Me.lbEquipment.Enabled = True
		Me.lbEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbEquipment.UseMnemonic = True
		Me.lbEquipment.Visible = True
		Me.lbEquipment.AutoSize = False
		Me.lbEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbEquipment.Name = "lbEquipment"
		Me.lbCustomer.Text = "Customer"
		Me.lbCustomer.Size = New System.Drawing.Size(241, 17)
		Me.lbCustomer.Location = New System.Drawing.Point(16, 64)
		Me.lbCustomer.TabIndex = 3
		Me.lbCustomer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbCustomer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbCustomer.BackColor = System.Drawing.SystemColors.Control
		Me.lbCustomer.Enabled = True
		Me.lbCustomer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbCustomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbCustomer.UseMnemonic = True
		Me.lbCustomer.Visible = True
		Me.lbCustomer.AutoSize = False
		Me.lbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbCustomer.Name = "lbCustomer"
		Me.lbState.Text = "State"
		Me.lbState.Size = New System.Drawing.Size(137, 17)
		Me.lbState.Location = New System.Drawing.Point(272, 64)
		Me.lbState.TabIndex = 2
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
		Me.Controls.Add(dgStoreEqpt)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(dgStore)
		Me.Controls.Add(lbEquipment)
		Me.Controls.Add(lbCustomer)
		Me.Controls.Add(lbState)
		Me.Toolbar1.Items.Add(_Toolbar1_Button4)
		CType(Me.dgStore, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgStoreEqpt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class