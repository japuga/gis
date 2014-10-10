<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustInvTemplateEntry
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
	Public WithEvents cmdBrowse As System.Windows.Forms.Button
	Public WithEvents txtFilename As System.Windows.Forms.TextBox
	Public WithEvents txtDescription As System.Windows.Forms.TextBox
	Public WithEvents txtTemplateName As System.Windows.Forms.TextBox
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustInvTemplateEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdBrowse = New System.Windows.Forms.Button
		Me.txtFilename = New System.Windows.Forms.TextBox
		Me.txtDescription = New System.Windows.Forms.TextBox
		Me.txtTemplateName = New System.Windows.Forms.TextBox
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "MS-Word Template Entry"
		Me.ClientSize = New System.Drawing.Size(528, 221)
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
		Me.Name = "frmCustInvTemplateEntry"
		Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBrowse.Text = "Browse"
		Me.cmdBrowse.Size = New System.Drawing.Size(81, 25)
		Me.cmdBrowse.Location = New System.Drawing.Point(408, 136)
		Me.cmdBrowse.TabIndex = 6
		Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBrowse.CausesValidation = True
		Me.cmdBrowse.Enabled = True
		Me.cmdBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBrowse.TabStop = True
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.txtFilename.AutoSize = False
		Me.txtFilename.Size = New System.Drawing.Size(313, 21)
		Me.txtFilename.Location = New System.Drawing.Point(88, 136)
		Me.txtFilename.TabIndex = 5
		Me.txtFilename.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFilename.AcceptsReturn = True
		Me.txtFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFilename.BackColor = System.Drawing.SystemColors.Window
		Me.txtFilename.CausesValidation = True
		Me.txtFilename.Enabled = True
		Me.txtFilename.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFilename.HideSelection = True
		Me.txtFilename.ReadOnly = False
		Me.txtFilename.Maxlength = 0
		Me.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFilename.MultiLine = False
		Me.txtFilename.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFilename.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFilename.TabStop = True
		Me.txtFilename.Visible = True
		Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFilename.Name = "txtFilename"
		Me.txtDescription.AutoSize = False
		Me.txtDescription.Size = New System.Drawing.Size(313, 21)
		Me.txtDescription.Location = New System.Drawing.Point(88, 104)
		Me.txtDescription.TabIndex = 2
		Me.txtDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDescription.AcceptsReturn = True
		Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
		Me.txtDescription.CausesValidation = True
		Me.txtDescription.Enabled = True
		Me.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDescription.HideSelection = True
		Me.txtDescription.ReadOnly = False
		Me.txtDescription.Maxlength = 0
		Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDescription.MultiLine = False
		Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDescription.TabStop = True
		Me.txtDescription.Visible = True
		Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDescription.Name = "txtDescription"
		Me.txtTemplateName.AutoSize = False
		Me.txtTemplateName.Size = New System.Drawing.Size(161, 21)
		Me.txtTemplateName.Location = New System.Drawing.Point(88, 64)
		Me.txtTemplateName.TabIndex = 1
		Me.txtTemplateName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTemplateName.AcceptsReturn = True
		Me.txtTemplateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTemplateName.BackColor = System.Drawing.SystemColors.Window
		Me.txtTemplateName.CausesValidation = True
		Me.txtTemplateName.Enabled = True
		Me.txtTemplateName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTemplateName.HideSelection = True
		Me.txtTemplateName.ReadOnly = False
		Me.txtTemplateName.Maxlength = 0
		Me.txtTemplateName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTemplateName.MultiLine = False
		Me.txtTemplateName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTemplateName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTemplateName.TabStop = True
		Me.txtTemplateName.Visible = True
		Me.txtTemplateName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTemplateName.Name = "txtTemplateName"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(528, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 7
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me.Label3.Text = "File Name"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 136)
		Me.Label3.TabIndex = 4
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
		Me.Label2.Text = "Description"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 104)
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
		Me.Label1.Text = "Template"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 72)
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
		Me.Controls.Add(cmdBrowse)
		Me.Controls.Add(txtFilename)
		Me.Controls.Add(txtDescription)
		Me.Controls.Add(txtTemplateName)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class