<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepDefEntry
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
	Public WithEvents txtTableName As System.Windows.Forms.TextBox
	Public WithEvents cmdOption As System.Windows.Forms.Button
	Public WithEvents dgRepDefTemplate As AxMSDataGridLib.AxDataGrid
	Public WithEvents txtRepNo As System.Windows.Forms.TextBox
	Public WithEvents cmdNewTemplate As System.Windows.Forms.Button
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents cmdBrowse As System.Windows.Forms.Button
	Public WithEvents cmdDeleteTemplate As System.Windows.Forms.Button
	Public WithEvents cmdEditTemplate As System.Windows.Forms.Button
	Public WithEvents txtRepTemplateFile As System.Windows.Forms.TextBox
	Public WithEvents txtRepSpName As System.Windows.Forms.TextBox
	Public WithEvents txtRepCaption As System.Windows.Forms.TextBox
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepDefEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtTableName = New System.Windows.Forms.TextBox
		Me.cmdOption = New System.Windows.Forms.Button
		Me.dgRepDefTemplate = New AxMSDataGridLib.AxDataGrid
		Me.txtRepNo = New System.Windows.Forms.TextBox
		Me.cmdNewTemplate = New System.Windows.Forms.Button
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.cmdBrowse = New System.Windows.Forms.Button
		Me.cmdDeleteTemplate = New System.Windows.Forms.Button
		Me.cmdEditTemplate = New System.Windows.Forms.Button
		Me.txtRepTemplateFile = New System.Windows.Forms.TextBox
		Me.txtRepSpName = New System.Windows.Forms.TextBox
		Me.txtRepCaption = New System.Windows.Forms.TextBox
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me.label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgRepDefTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Report Settings"
		Me.ClientSize = New System.Drawing.Size(648, 492)
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
		Me.Name = "frmRepDefEntry"
		Me.txtTableName.AutoSize = False
		Me.txtTableName.Size = New System.Drawing.Size(145, 21)
		Me.txtTableName.Location = New System.Drawing.Point(480, 104)
		Me.txtTableName.TabIndex = 15
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
		Me.cmdOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOption.Text = "Service Options"
		Me.cmdOption.Size = New System.Drawing.Size(89, 25)
		Me.cmdOption.Location = New System.Drawing.Point(544, 168)
		Me.cmdOption.TabIndex = 13
		Me.cmdOption.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOption.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOption.CausesValidation = True
		Me.cmdOption.Enabled = True
		Me.cmdOption.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOption.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOption.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOption.TabStop = True
		Me.cmdOption.Name = "cmdOption"
		dgRepDefTemplate.OcxState = CType(resources.GetObject("dgRepDefTemplate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgRepDefTemplate.Size = New System.Drawing.Size(601, 217)
		Me.dgRepDefTemplate.Location = New System.Drawing.Point(24, 200)
		Me.dgRepDefTemplate.TabIndex = 12
		Me.dgRepDefTemplate.Name = "dgRepDefTemplate"
		Me.txtRepNo.AutoSize = False
		Me.txtRepNo.Size = New System.Drawing.Size(41, 19)
		Me.txtRepNo.Location = New System.Drawing.Point(472, 72)
		Me.txtRepNo.TabIndex = 11
		Me.txtRepNo.Visible = False
		Me.txtRepNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRepNo.AcceptsReturn = True
		Me.txtRepNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRepNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtRepNo.CausesValidation = True
		Me.txtRepNo.Enabled = True
		Me.txtRepNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRepNo.HideSelection = True
		Me.txtRepNo.ReadOnly = False
		Me.txtRepNo.Maxlength = 0
		Me.txtRepNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRepNo.MultiLine = False
		Me.txtRepNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRepNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRepNo.TabStop = True
		Me.txtRepNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRepNo.Name = "txtRepNo"
		Me.cmdNewTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNewTemplate.Text = "New Template"
		Me.cmdNewTemplate.Size = New System.Drawing.Size(81, 41)
		Me.cmdNewTemplate.Location = New System.Drawing.Point(24, 432)
		Me.cmdNewTemplate.TabIndex = 10
		Me.cmdNewTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNewTemplate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNewTemplate.CausesValidation = True
		Me.cmdNewTemplate.Enabled = True
		Me.cmdNewTemplate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNewTemplate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNewTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNewTemplate.TabStop = True
		Me.cmdNewTemplate.Name = "cmdNewTemplate"
		Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBrowse.Text = "Browse"
		Me.cmdBrowse.Size = New System.Drawing.Size(89, 25)
		Me.cmdBrowse.Location = New System.Drawing.Point(544, 136)
		Me.cmdBrowse.TabIndex = 9
		Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBrowse.CausesValidation = True
		Me.cmdBrowse.Enabled = True
		Me.cmdBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBrowse.TabStop = True
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.cmdDeleteTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDeleteTemplate.Text = "Delete Template"
		Me.cmdDeleteTemplate.Size = New System.Drawing.Size(81, 41)
		Me.cmdDeleteTemplate.Location = New System.Drawing.Point(232, 432)
		Me.cmdDeleteTemplate.TabIndex = 8
		Me.cmdDeleteTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDeleteTemplate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDeleteTemplate.CausesValidation = True
		Me.cmdDeleteTemplate.Enabled = True
		Me.cmdDeleteTemplate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDeleteTemplate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDeleteTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDeleteTemplate.TabStop = True
		Me.cmdDeleteTemplate.Name = "cmdDeleteTemplate"
		Me.cmdEditTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEditTemplate.Text = "Edit Template"
		Me.cmdEditTemplate.Size = New System.Drawing.Size(81, 41)
		Me.cmdEditTemplate.Location = New System.Drawing.Point(128, 432)
		Me.cmdEditTemplate.TabIndex = 7
		Me.cmdEditTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEditTemplate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEditTemplate.CausesValidation = True
		Me.cmdEditTemplate.Enabled = True
		Me.cmdEditTemplate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEditTemplate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEditTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEditTemplate.TabStop = True
		Me.cmdEditTemplate.Name = "cmdEditTemplate"
		Me.txtRepTemplateFile.AutoSize = False
		Me.txtRepTemplateFile.Size = New System.Drawing.Size(401, 21)
		Me.txtRepTemplateFile.Location = New System.Drawing.Point(136, 136)
		Me.txtRepTemplateFile.TabIndex = 6
		Me.txtRepTemplateFile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRepTemplateFile.AcceptsReturn = True
		Me.txtRepTemplateFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRepTemplateFile.BackColor = System.Drawing.SystemColors.Window
		Me.txtRepTemplateFile.CausesValidation = True
		Me.txtRepTemplateFile.Enabled = True
		Me.txtRepTemplateFile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRepTemplateFile.HideSelection = True
		Me.txtRepTemplateFile.ReadOnly = False
		Me.txtRepTemplateFile.Maxlength = 0
		Me.txtRepTemplateFile.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRepTemplateFile.MultiLine = False
		Me.txtRepTemplateFile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRepTemplateFile.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRepTemplateFile.TabStop = True
		Me.txtRepTemplateFile.Visible = True
		Me.txtRepTemplateFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRepTemplateFile.Name = "txtRepTemplateFile"
		Me.txtRepSpName.AutoSize = False
		Me.txtRepSpName.Size = New System.Drawing.Size(225, 21)
		Me.txtRepSpName.Location = New System.Drawing.Point(136, 104)
		Me.txtRepSpName.TabIndex = 5
		Me.txtRepSpName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRepSpName.AcceptsReturn = True
		Me.txtRepSpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRepSpName.BackColor = System.Drawing.SystemColors.Window
		Me.txtRepSpName.CausesValidation = True
		Me.txtRepSpName.Enabled = True
		Me.txtRepSpName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRepSpName.HideSelection = True
		Me.txtRepSpName.ReadOnly = False
		Me.txtRepSpName.Maxlength = 0
		Me.txtRepSpName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRepSpName.MultiLine = False
		Me.txtRepSpName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRepSpName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRepSpName.TabStop = True
		Me.txtRepSpName.Visible = True
		Me.txtRepSpName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRepSpName.Name = "txtRepSpName"
		Me.txtRepCaption.AutoSize = False
		Me.txtRepCaption.Size = New System.Drawing.Size(273, 21)
		Me.txtRepCaption.Location = New System.Drawing.Point(136, 72)
		Me.txtRepCaption.TabIndex = 4
		Me.txtRepCaption.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRepCaption.AcceptsReturn = True
		Me.txtRepCaption.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRepCaption.BackColor = System.Drawing.SystemColors.Window
		Me.txtRepCaption.CausesValidation = True
		Me.txtRepCaption.Enabled = True
		Me.txtRepCaption.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRepCaption.HideSelection = True
		Me.txtRepCaption.ReadOnly = False
		Me.txtRepCaption.Maxlength = 0
		Me.txtRepCaption.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRepCaption.MultiLine = False
		Me.txtRepCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRepCaption.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRepCaption.TabStop = True
		Me.txtRepCaption.Visible = True
		Me.txtRepCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRepCaption.Name = "txtRepCaption"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(648, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 1
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button5.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button5.AutoSize = False
		Me._Toolbar1_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button5.ToolTipText = "Print"
		Me._Toolbar1_Button5.Width = 10
		Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.label4.Text = "Data Table Name"
		Me.label4.Size = New System.Drawing.Size(89, 17)
		Me.label4.Location = New System.Drawing.Point(384, 104)
		Me.label4.TabIndex = 14
		Me.label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label4.BackColor = System.Drawing.SystemColors.Control
		Me.label4.Enabled = True
		Me.label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label4.UseMnemonic = True
		Me.label4.Visible = True
		Me.label4.AutoSize = False
		Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label4.Name = "label4"
		Me.Label3.Text = "Default Template File"
		Me.Label3.Size = New System.Drawing.Size(105, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 136)
		Me.Label3.TabIndex = 3
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
		Me.Label2.Text = "Stored Procedure"
		Me.Label2.Size = New System.Drawing.Size(97, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 104)
		Me.Label2.TabIndex = 2
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
		Me.Label1.Text = "Report Name"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 72)
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
		Me.Controls.Add(txtTableName)
		Me.Controls.Add(cmdOption)
		Me.Controls.Add(dgRepDefTemplate)
		Me.Controls.Add(txtRepNo)
		Me.Controls.Add(cmdNewTemplate)
		Me.Controls.Add(cmdBrowse)
		Me.Controls.Add(cmdDeleteTemplate)
		Me.Controls.Add(cmdEditTemplate)
		Me.Controls.Add(txtRepTemplateFile)
		Me.Controls.Add(txtRepSpName)
		Me.Controls.Add(txtRepCaption)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		CType(Me.dgRepDefTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class