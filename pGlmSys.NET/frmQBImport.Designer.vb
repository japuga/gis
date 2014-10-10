<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmQBImport
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
	Public WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdImport As System.Windows.Forms.Button
	Public WithEvents cbQBGroupDesc As System.Windows.Forms.ComboBox
	Public WithEvents cbQBGroupId As System.Windows.Forms.ComboBox
	Public WithEvents cmdOpen As System.Windows.Forms.Button
	Public WithEvents txtFile As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents dgImport As AxMSDataGridLib.AxDataGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmQBImport))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdImport = New System.Windows.Forms.Button
		Me.cbQBGroupDesc = New System.Windows.Forms.ComboBox
		Me.cbQBGroupId = New System.Windows.Forms.ComboBox
		Me.cmdOpen = New System.Windows.Forms.Button
		Me.txtFile = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.dgImport = New AxMSDataGridLib.AxDataGrid
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgImport, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Quick Books Import"
		Me.ClientSize = New System.Drawing.Size(591, 215)
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
		Me.Name = "frmQBImport"
		Me.ProgressBar1.Size = New System.Drawing.Size(89, 25)
		Me.ProgressBar1.Location = New System.Drawing.Point(24, 344)
		Me.ProgressBar1.TabIndex = 10
		Me.ProgressBar1.Visible = False
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.Frame1.Text = "Load Info"
		Me.Frame1.Size = New System.Drawing.Size(537, 169)
		Me.Frame1.Location = New System.Drawing.Point(24, 8)
		Me.Frame1.TabIndex = 1
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.Location = New System.Drawing.Point(264, 120)
		Me.cmdClose.TabIndex = 9
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.cmdImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdImport.Text = "Import"
		Me.cmdImport.Size = New System.Drawing.Size(81, 25)
		Me.cmdImport.Location = New System.Drawing.Point(136, 120)
		Me.cmdImport.TabIndex = 8
		Me.cmdImport.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
		Me.cmdImport.CausesValidation = True
		Me.cmdImport.Enabled = True
		Me.cmdImport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdImport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdImport.TabStop = True
		Me.cmdImport.Name = "cmdImport"
		Me.cbQBGroupDesc.Size = New System.Drawing.Size(153, 21)
		Me.cbQBGroupDesc.Location = New System.Drawing.Point(144, 32)
		Me.cbQBGroupDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupDesc.TabIndex = 7
		Me.cbQBGroupDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBGroupDesc.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBGroupDesc.CausesValidation = True
		Me.cbQBGroupDesc.Enabled = True
		Me.cbQBGroupDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBGroupDesc.IntegralHeight = True
		Me.cbQBGroupDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBGroupDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBGroupDesc.Sorted = False
		Me.cbQBGroupDesc.TabStop = True
		Me.cbQBGroupDesc.Visible = True
		Me.cbQBGroupDesc.Name = "cbQBGroupDesc"
		Me.cbQBGroupId.Size = New System.Drawing.Size(129, 21)
		Me.cbQBGroupId.Location = New System.Drawing.Point(328, 32)
		Me.cbQBGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbQBGroupId.TabIndex = 6
		Me.cbQBGroupId.Visible = False
		Me.cbQBGroupId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbQBGroupId.BackColor = System.Drawing.SystemColors.Window
		Me.cbQBGroupId.CausesValidation = True
		Me.cbQBGroupId.Enabled = True
		Me.cbQBGroupId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbQBGroupId.IntegralHeight = True
		Me.cbQBGroupId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbQBGroupId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbQBGroupId.Sorted = False
		Me.cbQBGroupId.TabStop = True
		Me.cbQBGroupId.Name = "cbQBGroupId"
		Me.cmdOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOpen.Text = "Open File"
		Me.cmdOpen.Size = New System.Drawing.Size(81, 21)
		Me.cmdOpen.Location = New System.Drawing.Point(328, 72)
		Me.cmdOpen.TabIndex = 5
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
		Me.txtFile.Enabled = False
		Me.txtFile.Size = New System.Drawing.Size(161, 19)
		Me.txtFile.Location = New System.Drawing.Point(144, 72)
		Me.txtFile.TabIndex = 4
		Me.txtFile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFile.AcceptsReturn = True
		Me.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFile.BackColor = System.Drawing.SystemColors.Window
		Me.txtFile.CausesValidation = True
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
		Me.Label2.Text = "Quick Books Data File"
		Me.Label2.Size = New System.Drawing.Size(113, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 72)
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
		Me.Label1.Text = "Quick Books Company"
		Me.Label1.Size = New System.Drawing.Size(113, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 32)
		Me.Label1.TabIndex = 2
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
		dgImport.OcxState = CType(resources.GetObject("dgImport.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgImport.Size = New System.Drawing.Size(473, 249)
		Me.dgImport.Location = New System.Drawing.Point(160, 216)
		Me.dgImport.TabIndex = 0
		Me.dgImport.Name = "dgImport"
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(dgImport)
		Me.Frame1.Controls.Add(cmdClose)
		Me.Frame1.Controls.Add(cmdImport)
		Me.Frame1.Controls.Add(cbQBGroupDesc)
		Me.Frame1.Controls.Add(cbQBGroupId)
		Me.Frame1.Controls.Add(cmdOpen)
		Me.Frame1.Controls.Add(txtFile)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		CType(Me.dgImport, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class