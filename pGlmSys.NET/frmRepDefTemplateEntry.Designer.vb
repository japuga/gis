<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepDefTemplateEntry
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
	Public WithEvents UpDown1 As System.Windows.Forms.Label
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents txtColOrder As System.Windows.Forms.TextBox
	Public WithEvents txtRepTemplateFile As System.Windows.Forms.TextBox
	Public WithEvents txtRepTemplateDesc As System.Windows.Forms.TextBox
	Public WithEvents txtRepTemplateName As System.Windows.Forms.TextBox
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepDefTemplateEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdBrowse = New System.Windows.Forms.Button
		Me.UpDown1 = New System.Windows.Forms.Label
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.txtColOrder = New System.Windows.Forms.TextBox
		Me.txtRepTemplateFile = New System.Windows.Forms.TextBox
		Me.txtRepTemplateDesc = New System.Windows.Forms.TextBox
		Me.txtRepTemplateName = New System.Windows.Forms.TextBox
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
        Me.SuspendLayout()
        Me.ToolTip1.Active = True
        Me.Text = "Report Template Maintenance"
        Me.ClientSize = New System.Drawing.Size(565, 250)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Name = "frmRepDefTemplateEntry"

		Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBrowse.Text = "Browse"
		Me.cmdBrowse.Size = New System.Drawing.Size(73, 25)
		Me.cmdBrowse.Location = New System.Drawing.Point(456, 144)
		Me.cmdBrowse.TabIndex = 10
		Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrowse.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBrowse.CausesValidation = True
		Me.cmdBrowse.Enabled = True
		Me.cmdBrowse.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBrowse.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBrowse.TabStop = True
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.UpDown1.Size = New System.Drawing.Size(16, 21)
		Me.UpDown1.Location = New System.Drawing.Point(154, 176)
		Me.UpDown1.TabIndex = 9
		Me.UpDown1.Text = "UpDown1"
		Me.UpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UpDown1.BackColor = System.Drawing.Color.Red
		Me.UpDown1.Name = "UpDown1"
		Me.txtColOrder.AutoSize = False
		Me.txtColOrder.Size = New System.Drawing.Size(33, 21)
		Me.txtColOrder.Location = New System.Drawing.Point(120, 176)
		Me.txtColOrder.TabIndex = 8
		Me.txtColOrder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtColOrder.AcceptsReturn = True
		Me.txtColOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtColOrder.BackColor = System.Drawing.SystemColors.Window
		Me.txtColOrder.CausesValidation = True
		Me.txtColOrder.Enabled = True
		Me.txtColOrder.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtColOrder.HideSelection = True
		Me.txtColOrder.ReadOnly = False
		Me.txtColOrder.Maxlength = 0
		Me.txtColOrder.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtColOrder.MultiLine = False
		Me.txtColOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtColOrder.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtColOrder.TabStop = True
		Me.txtColOrder.Visible = True
		Me.txtColOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtColOrder.Name = "txtColOrder"
		Me.txtRepTemplateFile.AutoSize = False
		Me.txtRepTemplateFile.Size = New System.Drawing.Size(321, 21)
		Me.txtRepTemplateFile.Location = New System.Drawing.Point(120, 144)
		Me.txtRepTemplateFile.TabIndex = 7
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
		Me.txtRepTemplateDesc.AutoSize = False
		Me.txtRepTemplateDesc.Size = New System.Drawing.Size(321, 21)
		Me.txtRepTemplateDesc.Location = New System.Drawing.Point(120, 112)
		Me.txtRepTemplateDesc.TabIndex = 6
		Me.txtRepTemplateDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRepTemplateDesc.AcceptsReturn = True
		Me.txtRepTemplateDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRepTemplateDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtRepTemplateDesc.CausesValidation = True
		Me.txtRepTemplateDesc.Enabled = True
		Me.txtRepTemplateDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRepTemplateDesc.HideSelection = True
		Me.txtRepTemplateDesc.ReadOnly = False
		Me.txtRepTemplateDesc.Maxlength = 0
		Me.txtRepTemplateDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRepTemplateDesc.MultiLine = False
		Me.txtRepTemplateDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRepTemplateDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRepTemplateDesc.TabStop = True
		Me.txtRepTemplateDesc.Visible = True
		Me.txtRepTemplateDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRepTemplateDesc.Name = "txtRepTemplateDesc"
		Me.txtRepTemplateName.AutoSize = False
		Me.txtRepTemplateName.Size = New System.Drawing.Size(161, 21)
		Me.txtRepTemplateName.Location = New System.Drawing.Point(120, 80)
		Me.txtRepTemplateName.TabIndex = 5
		Me.txtRepTemplateName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRepTemplateName.AcceptsReturn = True
		Me.txtRepTemplateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRepTemplateName.BackColor = System.Drawing.SystemColors.Window
		Me.txtRepTemplateName.CausesValidation = True
		Me.txtRepTemplateName.Enabled = True
		Me.txtRepTemplateName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRepTemplateName.HideSelection = True
		Me.txtRepTemplateName.ReadOnly = False
		Me.txtRepTemplateName.Maxlength = 0
		Me.txtRepTemplateName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRepTemplateName.MultiLine = False
		Me.txtRepTemplateName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRepTemplateName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRepTemplateName.TabStop = True
		Me.txtRepTemplateName.Visible = True
		Me.txtRepTemplateName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRepTemplateName.Name = "txtRepTemplateName"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(565, 44)
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
		Me.Label4.Text = "Order"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 184)
		Me.Label4.TabIndex = 4
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
		Me.Label3.Text = "Template File"
		Me.Label3.Size = New System.Drawing.Size(81, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 149)
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
		Me.Label2.Text = "Description"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 115)
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
		Me.Label1.Text = "Template Name"
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 80)
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
		Me.Controls.Add(cmdBrowse)
		Me.Controls.Add(UpDown1)
		Me.Controls.Add(txtColOrder)
		Me.Controls.Add(txtRepTemplateFile)
		Me.Controls.Add(txtRepTemplateDesc)
		Me.Controls.Add(txtRepTemplateName)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class