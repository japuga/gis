<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWebReportEntry
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
	Public WithEvents cbEnabledFlag As System.Windows.Forms.ComboBox
	Public WithEvents txtReportDesc As System.Windows.Forms.TextBox
	Public WithEvents txtTableName As System.Windows.Forms.TextBox
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWebReportEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cbEnabledFlag = New System.Windows.Forms.ComboBox
		Me.txtReportDesc = New System.Windows.Forms.TextBox
		Me.txtTableName = New System.Windows.Forms.TextBox
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Web Report"
		Me.ClientSize = New System.Drawing.Size(499, 302)
		Me.Location = New System.Drawing.Point(4, 30)
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
		Me.Name = "frmWebReportEntry"
		Me.cbEnabledFlag.Size = New System.Drawing.Size(137, 21)
		Me.cbEnabledFlag.Location = New System.Drawing.Point(120, 136)
		Me.cbEnabledFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEnabledFlag.TabIndex = 6
		Me.cbEnabledFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEnabledFlag.BackColor = System.Drawing.SystemColors.Window
		Me.cbEnabledFlag.CausesValidation = True
		Me.cbEnabledFlag.Enabled = True
		Me.cbEnabledFlag.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEnabledFlag.IntegralHeight = True
		Me.cbEnabledFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEnabledFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEnabledFlag.Sorted = False
		Me.cbEnabledFlag.TabStop = True
		Me.cbEnabledFlag.Visible = True
		Me.cbEnabledFlag.Name = "cbEnabledFlag"
		Me.txtReportDesc.AutoSize = False
		Me.txtReportDesc.Size = New System.Drawing.Size(305, 19)
		Me.txtReportDesc.Location = New System.Drawing.Point(120, 104)
		Me.txtReportDesc.TabIndex = 4
		Me.txtReportDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReportDesc.AcceptsReturn = True
		Me.txtReportDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReportDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtReportDesc.CausesValidation = True
		Me.txtReportDesc.Enabled = True
		Me.txtReportDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReportDesc.HideSelection = True
		Me.txtReportDesc.ReadOnly = False
		Me.txtReportDesc.Maxlength = 0
		Me.txtReportDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReportDesc.MultiLine = False
		Me.txtReportDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReportDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReportDesc.TabStop = True
		Me.txtReportDesc.Visible = True
		Me.txtReportDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReportDesc.Name = "txtReportDesc"
		Me.txtTableName.AutoSize = False
		Me.txtTableName.Size = New System.Drawing.Size(129, 19)
		Me.txtTableName.Location = New System.Drawing.Point(120, 64)
		Me.txtTableName.TabIndex = 2
		Me.txtTableName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTableName.AcceptsReturn = True
		Me.txtTableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTableName.BackColor = System.Drawing.SystemColors.Window
		Me.txtTableName.CausesValidation = True
		Me.txtTableName.Enabled = True
		Me.txtTableName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTableName.HideSelection = True
		Me.txtTableName.ReadOnly = False
		Me.txtTableName.Maxlength = 0
		Me.txtTableName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTableName.MultiLine = False
		Me.txtTableName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTableName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTableName.TabStop = True
		Me.txtTableName.Visible = True
		Me.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTableName.Name = "txtTableName"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(499, 44)
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
		Me.Label3.Text = "Publish"
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 136)
		Me.Label3.TabIndex = 5
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
		Me.Label2.Text = "Report Name"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(32, 104)
		Me.Label2.TabIndex = 3
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
		Me.Label1.Text = "Report Type"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.Location = New System.Drawing.Point(32, 64)
		Me.Label1.TabIndex = 1
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
		Me.Controls.Add(cbEnabledFlag)
		Me.Controls.Add(txtReportDesc)
		Me.Controls.Add(txtTableName)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button4)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class