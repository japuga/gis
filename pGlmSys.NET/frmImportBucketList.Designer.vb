<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmImportBucketList
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
	Public WithEvents cmdOpen As System.Windows.Forms.Button
	Public WithEvents txtFile As System.Windows.Forms.TextBox
	Public WithEvents cmdImport As System.Windows.Forms.Button
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public cdFileSave As System.Windows.Forms.SaveFileDialog
	Public cdFileFont As System.Windows.Forms.FontDialog
	Public cdFileColor As System.Windows.Forms.ColorDialog
	Public cdFilePrint As System.Windows.Forms.PrintDialog
	Public WithEvents _sbLoad_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbLoad As System.Windows.Forms.StatusStrip
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmImportBucketList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdOpen = New System.Windows.Forms.Button
		Me.txtFile = New System.Windows.Forms.TextBox
		Me.cmdImport = New System.Windows.Forms.Button
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.cdFileSave = New System.Windows.Forms.SaveFileDialog
		Me.cdFileFont = New System.Windows.Forms.FontDialog
		Me.cdFileColor = New System.Windows.Forms.ColorDialog
		Me.cdFilePrint = New System.Windows.Forms.PrintDialog
		Me.sbLoad = New System.Windows.Forms.StatusStrip
		Me._sbLoad_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me.Label1 = New System.Windows.Forms.Label
		Me.sbLoad.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Import Bucket List data"
		Me.ClientSize = New System.Drawing.Size(721, 207)
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
		Me.Name = "frmImportBucketList"
		Me.cmdOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOpen.Text = "Open "
		Me.cmdOpen.Size = New System.Drawing.Size(89, 25)
		Me.cmdOpen.Location = New System.Drawing.Point(592, 56)
		Me.cmdOpen.TabIndex = 2
		Me.cmdOpen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOpen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOpen.CausesValidation = True
		Me.cmdOpen.Enabled = True
		Me.cmdOpen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOpen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOpen.TabStop = True
		Me.cmdOpen.Name = "cmdOpen"
		Me.txtFile.AutoSize = False
		Me.txtFile.Size = New System.Drawing.Size(465, 21)
		Me.txtFile.Location = New System.Drawing.Point(120, 56)
		Me.txtFile.TabIndex = 1
		Me.txtFile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFile.AcceptsReturn = True
		Me.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFile.BackColor = System.Drawing.SystemColors.Window
		Me.txtFile.CausesValidation = True
		Me.txtFile.Enabled = True
		Me.txtFile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFile.HideSelection = True
		Me.txtFile.ReadOnly = False
		Me.txtFile.Maxlength = 0
		Me.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFile.MultiLine = False
		Me.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFile.TabStop = True
		Me.txtFile.Visible = True
		Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFile.Name = "txtFile"
		Me.cmdImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdImport.Text = "Import"
		Me.cmdImport.Size = New System.Drawing.Size(145, 25)
		Me.cmdImport.Location = New System.Drawing.Point(280, 104)
		Me.cmdImport.TabIndex = 0
		Me.cmdImport.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
		Me.cmdImport.CausesValidation = True
		Me.cmdImport.Enabled = True
		Me.cmdImport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdImport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdImport.TabStop = True
		Me.cmdImport.Name = "cmdImport"
		Me.sbLoad.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbLoad.Size = New System.Drawing.Size(721, 25)
		Me.sbLoad.Location = New System.Drawing.Point(0, 182)
		Me.sbLoad.TabIndex = 4
		Me.sbLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sbLoad.Name = "sbLoad"
		Me._sbLoad_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._sbLoad_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._sbLoad_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._sbLoad_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._sbLoad_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._sbLoad_Panel1.Size = New System.Drawing.Size(96, 25)
		Me._sbLoad_Panel1.AutoSize = False
		Me.Label1.Text = "Open  Excel File"
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 64)
		Me.Label1.TabIndex = 3
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
		Me.Controls.Add(cmdOpen)
		Me.Controls.Add(txtFile)
		Me.Controls.Add(cmdImport)
		Me.Controls.Add(sbLoad)
		Me.Controls.Add(Label1)
		Me.sbLoad.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._sbLoad_Panel1})
		Me.sbLoad.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class