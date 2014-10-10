<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSetting
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
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents txtWordTemplate As System.Windows.Forms.TextBox
	Public WithEvents cbDebugFlag As System.Windows.Forms.ComboBox
	Public WithEvents txtMaxBatchCheckDetails As System.Windows.Forms.TextBox
	Public WithEvents cbCheckPaperSource As System.Windows.Forms.ComboBox
	Public WithEvents txtCheckLogoFile As System.Windows.Forms.TextBox
	Public WithEvents txtReportDir As System.Windows.Forms.TextBox
	Public WithEvents cbFieldsFromDb As System.Windows.Forms.ComboBox
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public cdFileSave As System.Windows.Forms.SaveFileDialog
	Public cdFileFont As System.Windows.Forms.FontDialog
	Public cdFileColor As System.Windows.Forms.ColorDialog
	Public cdFilePrint As System.Windows.Forms.PrintDialog
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSetting))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me.txtWordTemplate = New System.Windows.Forms.TextBox
		Me.cbDebugFlag = New System.Windows.Forms.ComboBox
		Me.txtMaxBatchCheckDetails = New System.Windows.Forms.TextBox
		Me.cbCheckPaperSource = New System.Windows.Forms.ComboBox
		Me.txtCheckLogoFile = New System.Windows.Forms.TextBox
		Me.txtReportDir = New System.Windows.Forms.TextBox
		Me.cbFieldsFromDb = New System.Windows.Forms.ComboBox
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.cdFileSave = New System.Windows.Forms.SaveFileDialog
		Me.cdFileFont = New System.Windows.Forms.FontDialog
		Me.cdFileColor = New System.Windows.Forms.ColorDialog
		Me.cdFilePrint = New System.Windows.Forms.PrintDialog
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "System Parameters"
		Me.ClientSize = New System.Drawing.Size(536, 396)
		Me.Location = New System.Drawing.Point(4, 23)
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
		Me.Name = "frmSetting"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(536, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 5
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me.txtWordTemplate.AutoSize = False
		Me.txtWordTemplate.Size = New System.Drawing.Size(305, 21)
		Me.txtWordTemplate.Location = New System.Drawing.Point(192, 144)
		Me.txtWordTemplate.TabIndex = 14
		Me.txtWordTemplate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWordTemplate.AcceptsReturn = True
		Me.txtWordTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWordTemplate.BackColor = System.Drawing.SystemColors.Window
		Me.txtWordTemplate.CausesValidation = True
		Me.txtWordTemplate.Enabled = True
		Me.txtWordTemplate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWordTemplate.HideSelection = True
		Me.txtWordTemplate.ReadOnly = False
		Me.txtWordTemplate.Maxlength = 0
		Me.txtWordTemplate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWordTemplate.MultiLine = False
		Me.txtWordTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWordTemplate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWordTemplate.TabStop = True
		Me.txtWordTemplate.Visible = True
		Me.txtWordTemplate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWordTemplate.Name = "txtWordTemplate"
		Me.cbDebugFlag.Size = New System.Drawing.Size(65, 21)
		Me.cbDebugFlag.Location = New System.Drawing.Point(192, 328)
		Me.cbDebugFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbDebugFlag.TabIndex = 12
		Me.cbDebugFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbDebugFlag.BackColor = System.Drawing.SystemColors.Window
		Me.cbDebugFlag.CausesValidation = True
		Me.cbDebugFlag.Enabled = True
		Me.cbDebugFlag.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbDebugFlag.IntegralHeight = True
		Me.cbDebugFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbDebugFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbDebugFlag.Sorted = False
		Me.cbDebugFlag.TabStop = True
		Me.cbDebugFlag.Visible = True
		Me.cbDebugFlag.Name = "cbDebugFlag"
		Me.txtMaxBatchCheckDetails.AutoSize = False
		Me.txtMaxBatchCheckDetails.Size = New System.Drawing.Size(65, 21)
		Me.txtMaxBatchCheckDetails.Location = New System.Drawing.Point(192, 280)
		Me.txtMaxBatchCheckDetails.TabIndex = 10
		Me.txtMaxBatchCheckDetails.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMaxBatchCheckDetails.AcceptsReturn = True
		Me.txtMaxBatchCheckDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMaxBatchCheckDetails.BackColor = System.Drawing.SystemColors.Window
		Me.txtMaxBatchCheckDetails.CausesValidation = True
		Me.txtMaxBatchCheckDetails.Enabled = True
		Me.txtMaxBatchCheckDetails.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMaxBatchCheckDetails.HideSelection = True
		Me.txtMaxBatchCheckDetails.ReadOnly = False
		Me.txtMaxBatchCheckDetails.Maxlength = 0
		Me.txtMaxBatchCheckDetails.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMaxBatchCheckDetails.MultiLine = False
		Me.txtMaxBatchCheckDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMaxBatchCheckDetails.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxBatchCheckDetails.TabStop = True
		Me.txtMaxBatchCheckDetails.Visible = True
		Me.txtMaxBatchCheckDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMaxBatchCheckDetails.Name = "txtMaxBatchCheckDetails"
		Me.cbCheckPaperSource.Size = New System.Drawing.Size(145, 21)
		Me.cbCheckPaperSource.Location = New System.Drawing.Point(192, 232)
		Me.cbCheckPaperSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCheckPaperSource.TabIndex = 9
		Me.cbCheckPaperSource.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCheckPaperSource.BackColor = System.Drawing.SystemColors.Window
		Me.cbCheckPaperSource.CausesValidation = True
		Me.cbCheckPaperSource.Enabled = True
		Me.cbCheckPaperSource.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCheckPaperSource.IntegralHeight = True
		Me.cbCheckPaperSource.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCheckPaperSource.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCheckPaperSource.Sorted = False
		Me.cbCheckPaperSource.TabStop = True
		Me.cbCheckPaperSource.Visible = True
		Me.cbCheckPaperSource.Name = "cbCheckPaperSource"
		Me.txtCheckLogoFile.AutoSize = False
		Me.txtCheckLogoFile.Size = New System.Drawing.Size(305, 21)
		Me.txtCheckLogoFile.Location = New System.Drawing.Point(192, 184)
		Me.txtCheckLogoFile.TabIndex = 8
		Me.txtCheckLogoFile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCheckLogoFile.AcceptsReturn = True
		Me.txtCheckLogoFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCheckLogoFile.BackColor = System.Drawing.SystemColors.Window
		Me.txtCheckLogoFile.CausesValidation = True
		Me.txtCheckLogoFile.Enabled = True
		Me.txtCheckLogoFile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCheckLogoFile.HideSelection = True
		Me.txtCheckLogoFile.ReadOnly = False
		Me.txtCheckLogoFile.Maxlength = 0
		Me.txtCheckLogoFile.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCheckLogoFile.MultiLine = False
		Me.txtCheckLogoFile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCheckLogoFile.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCheckLogoFile.TabStop = True
		Me.txtCheckLogoFile.Visible = True
		Me.txtCheckLogoFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCheckLogoFile.Name = "txtCheckLogoFile"
		Me.txtReportDir.AutoSize = False
		Me.txtReportDir.Size = New System.Drawing.Size(305, 21)
		Me.txtReportDir.Location = New System.Drawing.Point(192, 104)
		Me.txtReportDir.TabIndex = 7
		Me.txtReportDir.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtReportDir.AcceptsReturn = True
		Me.txtReportDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReportDir.BackColor = System.Drawing.SystemColors.Window
		Me.txtReportDir.CausesValidation = True
		Me.txtReportDir.Enabled = True
		Me.txtReportDir.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReportDir.HideSelection = True
		Me.txtReportDir.ReadOnly = False
		Me.txtReportDir.Maxlength = 0
		Me.txtReportDir.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReportDir.MultiLine = False
		Me.txtReportDir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReportDir.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReportDir.TabStop = True
		Me.txtReportDir.Visible = True
		Me.txtReportDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReportDir.Name = "txtReportDir"
		Me.cbFieldsFromDb.Size = New System.Drawing.Size(65, 21)
		Me.cbFieldsFromDb.Location = New System.Drawing.Point(192, 64)
		Me.cbFieldsFromDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbFieldsFromDb.TabIndex = 6
		Me.cbFieldsFromDb.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbFieldsFromDb.BackColor = System.Drawing.SystemColors.Window
		Me.cbFieldsFromDb.CausesValidation = True
		Me.cbFieldsFromDb.Enabled = True
		Me.cbFieldsFromDb.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbFieldsFromDb.IntegralHeight = True
		Me.cbFieldsFromDb.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbFieldsFromDb.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbFieldsFromDb.Sorted = False
		Me.cbFieldsFromDb.TabStop = True
		Me.cbFieldsFromDb.Visible = True
		Me.cbFieldsFromDb.Name = "cbFieldsFromDb"
		Me.Label7.Text = "MS-Word InvoiceTemplate"
		Me.Label7.Size = New System.Drawing.Size(137, 17)
		Me.Label7.Location = New System.Drawing.Point(32, 144)
		Me.Label7.TabIndex = 13
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label6.Text = "Debug Application"
		Me.Label6.Size = New System.Drawing.Size(97, 17)
		Me.Label6.Location = New System.Drawing.Point(32, 336)
		Me.Label6.TabIndex = 11
		Me.ToolTip1.SetToolTip(Me.Label6, "Additional information is written to the logifle")
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Check Paper Source"
		Me.Label5.Size = New System.Drawing.Size(97, 25)
		Me.Label5.Location = New System.Drawing.Point(32, 232)
		Me.Label5.TabIndex = 4
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Check Logo File"
		Me.Label4.Size = New System.Drawing.Size(129, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 184)
		Me.Label4.TabIndex = 3
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Maximun number of Details per Batch Check"
		Me.Label3.Size = New System.Drawing.Size(137, 33)
		Me.Label3.Location = New System.Drawing.Point(32, 280)
		Me.Label3.TabIndex = 2
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
		Me.Label2.Text = "Report Default Folder"
		Me.Label2.Size = New System.Drawing.Size(129, 17)
		Me.Label2.Location = New System.Drawing.Point(32, 104)
		Me.Label2.TabIndex = 1
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
		Me.label1.Text = "Verify Fields from DB"
		Me.label1.Size = New System.Drawing.Size(113, 17)
		Me.label1.Location = New System.Drawing.Point(32, 64)
		Me.label1.TabIndex = 0
		Me.label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label1.BackColor = System.Drawing.SystemColors.Control
		Me.label1.Enabled = True
		Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label1.UseMnemonic = True
		Me.label1.Visible = True
		Me.label1.AutoSize = False
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label1.Name = "label1"
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(txtWordTemplate)
		Me.Controls.Add(cbDebugFlag)
		Me.Controls.Add(txtMaxBatchCheckDetails)
		Me.Controls.Add(cbCheckPaperSource)
		Me.Controls.Add(txtCheckLogoFile)
		Me.Controls.Add(txtReportDir)
		Me.Controls.Add(cbFieldsFromDb)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(label1)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class