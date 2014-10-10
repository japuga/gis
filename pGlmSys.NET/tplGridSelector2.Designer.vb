<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class tplGridSelector2
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
	Public WithEvents cbHeader As System.Windows.Forms.ComboBox
	Public WithEvents txtHeader As System.Windows.Forms.TextBox
	Public WithEvents cmdRight As System.Windows.Forms.Button
	Public WithEvents cmdLeft As System.Windows.Forms.Button
	Public WithEvents dgLeft As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgRight As AxMSDataGridLib.AxDataGrid
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents lbHeader As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(tplGridSelector2))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbHeader = New System.Windows.Forms.ComboBox
		Me.txtHeader = New System.Windows.Forms.TextBox
		Me.cmdRight = New System.Windows.Forms.Button
		Me.cmdLeft = New System.Windows.Forms.Button
		Me.dgLeft = New AxMSDataGridLib.AxDataGrid
		Me.dgRight = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me.lbHeader = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgLeft, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgRight, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(619, 429)
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
		Me.Name = "tplGridSelector2"
		Me.cbHeader.Size = New System.Drawing.Size(113, 21)
		Me.cbHeader.Location = New System.Drawing.Point(368, 56)
		Me.cbHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbHeader.TabIndex = 6
		Me.cbHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbHeader.BackColor = System.Drawing.SystemColors.Window
		Me.cbHeader.CausesValidation = True
		Me.cbHeader.Enabled = True
		Me.cbHeader.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbHeader.IntegralHeight = True
		Me.cbHeader.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbHeader.Sorted = False
		Me.cbHeader.TabStop = True
		Me.cbHeader.Visible = True
		Me.cbHeader.Name = "cbHeader"
		Me.txtHeader.AutoSize = False
		Me.txtHeader.Size = New System.Drawing.Size(153, 21)
		Me.txtHeader.Location = New System.Drawing.Point(176, 56)
		Me.txtHeader.TabIndex = 5
		Me.txtHeader.Text = "txtHeader"
		Me.txtHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHeader.AcceptsReturn = True
		Me.txtHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtHeader.BackColor = System.Drawing.SystemColors.Window
		Me.txtHeader.CausesValidation = True
		Me.txtHeader.Enabled = True
		Me.txtHeader.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHeader.HideSelection = True
		Me.txtHeader.ReadOnly = False
		Me.txtHeader.Maxlength = 0
		Me.txtHeader.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHeader.MultiLine = False
		Me.txtHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHeader.TabStop = True
		Me.txtHeader.Visible = True
		Me.txtHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtHeader.Name = "txtHeader"
		Me.cmdRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRight.Text = ">"
		Me.cmdRight.Size = New System.Drawing.Size(33, 33)
		Me.cmdRight.Location = New System.Drawing.Point(288, 200)
		Me.cmdRight.TabIndex = 1
		Me.cmdRight.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRight.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRight.CausesValidation = True
		Me.cmdRight.Enabled = True
		Me.cmdRight.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRight.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRight.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRight.TabStop = True
		Me.cmdRight.Name = "cmdRight"
		Me.cmdLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLeft.Text = "<"
		Me.cmdLeft.Size = New System.Drawing.Size(33, 33)
		Me.cmdLeft.Location = New System.Drawing.Point(288, 264)
		Me.cmdLeft.TabIndex = 0
		Me.cmdLeft.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLeft.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLeft.CausesValidation = True
		Me.cmdLeft.Enabled = True
		Me.cmdLeft.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLeft.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLeft.TabStop = True
		Me.cmdLeft.Name = "cmdLeft"
		dgLeft.OcxState = CType(resources.GetObject("dgLeft.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgLeft.Size = New System.Drawing.Size(257, 305)
		Me.dgLeft.Location = New System.Drawing.Point(16, 96)
		Me.dgLeft.TabIndex = 2
		Me.dgLeft.Name = "dgLeft"
		dgRight.OcxState = CType(resources.GetObject("dgRight.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgRight.Size = New System.Drawing.Size(257, 305)
		Me.dgRight.Location = New System.Drawing.Point(336, 96)
		Me.dgRight.TabIndex = 3
		Me.dgRight.Name = "dgRight"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(619, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 7
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button5.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button5.AutoSize = False
		Me._Toolbar1_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button5.ToolTipText = "Print"
		Me._Toolbar1_Button5.Width = 10
		Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lbHeader.Text = "lbHeader"
		Me.lbHeader.Size = New System.Drawing.Size(113, 17)
		Me.lbHeader.Location = New System.Drawing.Point(40, 56)
		Me.lbHeader.TabIndex = 4
		Me.lbHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbHeader.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbHeader.BackColor = System.Drawing.SystemColors.Control
		Me.lbHeader.Enabled = True
		Me.lbHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbHeader.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbHeader.UseMnemonic = True
		Me.lbHeader.Visible = True
		Me.lbHeader.AutoSize = False
		Me.lbHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbHeader.Name = "lbHeader"
		Me.Controls.Add(cbHeader)
		Me.Controls.Add(txtHeader)
		Me.Controls.Add(cmdRight)
		Me.Controls.Add(cmdLeft)
		Me.Controls.Add(dgLeft)
		Me.Controls.Add(dgRight)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(lbHeader)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		CType(Me.dgRight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgLeft, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class